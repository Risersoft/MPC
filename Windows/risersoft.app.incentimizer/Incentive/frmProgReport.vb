Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmProgReport
    Inherits frmMax
    Dim myVueCurrProc, myVueLotLast, myVueEmp, myVueGroup As New clsWinView
    Public rMatDep As DataRow, vwDate As DateTime, dvMatDep As DataView

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.initForm()
    End Sub

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        myVueCurrProc.SetGrid(Me.UltraGrid5)
        myVueGroup.SetGrid(Me.UltraGrid4)
        myVueEmp.SetGrid(Me.UltraGridEmp)
        myVueLotLast.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overloads Function PrepForm(MatDepID As Integer, Dated As DateTime) As Boolean
        Dim strXML As String = "<PARAMS MATDEPID= """ & MatDepID & """ Dated= """ & Dated & """/>"
        Return Me.PrepForm(Me.pView, EnumfrmMode.acEditM, MatDepID, strXML)
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProgReportModel = Me.InitData("frmProgReportModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.dt_date.Value = Me.vBag("Dated")
            vwDate = Me.dt_date.Value

            rMatDep = Me.Controller.CommonData.MatDepRow(myUtils.cValTN(Me.vBag("matdepid")))
            Me.Text = "Daily Progress Report for " & myRow("depname")

            HandleDate(myUtils.cDateTN(Me.dt_date.Value, DateTime.MinValue))
            DoButtons(Not myUtils.cBoolTN(myWinSQL2.ParamValue("@isFinalWOT", Me.Model.ModelParams)))

            Me.FormPrepared = True
            End If
            Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("LotReport"))
            myVueEmp.PrepEdit(Me.Model.GridViews("Emp"))
            myVueGroup.PrepEdit(Me.Model.GridViews("Group"))
            myVueCurrProc.PrepEdit(Me.Model.GridViews("CurrProc"))
            myVueLotLast.PrepEdit(Me.Model.GridViews("LotLast"))

            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "matdep", "", Me.cmb_matdepid,, 2)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()

        VSave = False
        If Me.ValidateData() Then
            If Me.dt_date.Value > Now.Date Then WinFormUtils.AddError(Me.dt_date, "Please Select Valid Date.")
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()

    End Function

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim oView As clsWinView = Nothing, Params As New List(Of clsSQLParam), oret As clsProcOutput,
            rIncType, rPP, sr, rShift As DataRow, oMasterData As New clsMasterDataHRP(Me.Controller)

        Select Case Me.UltraTabControl2.SelectedTab.Index
            Case 0 : oView = myVueLotLast
            Case 1 : oView = myVueCurrProc
        End Select
        If Not oView Is Nothing Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If (Not oView.ContextRow Is Nothing) AndAlso (Not IsNothing(Me.dt_date.Value)) Then
                Me.InitError()

                sr = myUtils.DataRowFromGridRow(oView.ContextRow)
                Params.Add(New clsSQLParam("@Date", Me.dt_date.Value, GetType(Date), False))
                Params.Add(New clsSQLParam("@plnprocid", myUtils.cValTN(sr("plnprocid")), GetType(Integer), False))
                oret = Me.GenerateParamsOutput("inc", Params)
                If oret.GetCalcRows("proc").Length > 0 Then rIncType = oret.GetCalcRows("proc")(0)
                rPP = oMasterData.PPRow(myUtils.cValTN(sr("companyid")), Me.dt_date.Value, False)

                If rPP Is Nothing Then
                    WinFormUtils.AddError(Me.dt_date, "The date does not have a corresponding Pay Period")
                ElseIf rIncType Is Nothing Then
                    WinFormUtils.AddError(Me.btnFile, "Incentive Type not defined for this process")
                ElseIf myUtils.IsInList(rIncType("prodinctype"), "NA") Then
                    WinFormUtils.AddError(Me.btnFile, "Incentive Type is Not applicable for this process")
                Else
                    rShift = Nothing
                        If myUtils.cBoolTN(rIncType("separateshifts")) Then
                            Dim f2 As New frmGrid
                            Params.Clear()
                            Dim Model As clsViewModel = Me.GenerateParamsModel("shift", Params)
                            f2.myView.PrepEdit(Model)

                            If f2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                                rShift = myUtils.DataRowFromGridRow(f2.myView.ContextRow)
                            End If

                            If Not IsNothing(rShift) Then
                                Dim strXML As String = "<PARAMS  MatDepID=""" & rMatDep("MatDepID") & """  ShiftID=""" & rShift("shiftid") & """ prodlotrouteid=""" & sr("prodlotrouteid") & """ Dated=""" & Me.dt_date.Value & """ payperiodid=""" & rPP("payperiodid") & """ prodinctype=""" & rIncType("prodinctype") & """ pidunitid=""" & sr("pidunitid") & """ qtyreq=""" & sr("qtyreq") & """ plnprocid=""" & sr("plnprocid") & """/>"
                                Me.ShowLotReport(strXML, sr)
                            End If
                        Else
                            Dim strXML As String = "<PARAMS  MatDepID=""" & rMatDep("MatDepID") & """ prodlotrouteid=""" & sr("prodlotrouteid") & """ Dated=""" & Me.dt_date.Value & """ payperiodid=""" & rPP("payperiodid") & """ prodinctype=""" & rIncType("prodinctype") & """ pidunitid=""" & sr("pidunitid") & """ qtyreq=""" & sr("qtyreq") & """ plnprocid=""" & sr("plnprocid") & """/>"
                            Me.ShowLotReport(strXML, sr)
                        End If
                    End If
                    Me.ShowError()
            End If
        End If
    End Sub
    Protected Friend Sub ShowLotReport(strXML As String, sr As DataRow)
        Dim fr1 As New frmProdLotReport
        If fr1.PrepForm(Me.myView, EnumfrmMode.acAddM, 0, strXML) Then
            For Each str1 As String In New String() {"woinfo", "lotnum", "produnitname", "seqprocname"}
                fr1.myRow(str1) = sr(str1)
            Next
            fr1.ShowDialog()
            If fr1.DoRefresh Then
                reCalc(True)
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        reCalc(True)
    End Sub

    Private Sub btnAddDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click
        Dim rr() As DataRow, Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Dated", Format(dt_date.Value, "dd-MMM-yyyy"), GetType(DateTime), False))
        rr = Me.AdvancedSelect("contriemp", Params)

        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            Dim cont As Boolean = False
            For Each r1 As DataRow In Me.Controller.Data.CopySelectedRows(myVueEmp.mainGrid.myDv.Table, rr, "employeeid", False)
                r1("matdepid") = rMatDep("matdepid")
                r1("dated") = Me.dt_date.Value
                cont = True
            Next
            If cont Then
                Me.reCalc(False)
            End If
        End If
    End Sub

    Private Sub btnEditDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDoc.Click
        myVueEmp.ContextRow = myVueEmp.mainGrid.ActiveRow
        If Not myVueEmp.ContextRow Is Nothing Then
            Dim ProdContriEmpID As Integer = myUtils.cValTN(myVueEmp.ContextRow.CellValue("prodcontriempid"))
            If ProdContriEmpID = 0 Then
                MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
            Else
                Dim f2 As New frmProdContriEmp

                If f2.PrepForm(Me.myVueEmp, EnumfrmMode.acEditM, myUtils.DataRowFromGridRow(myVueEmp.ContextRow)("EmployeeID"), "<PARAMS  MatDepID=""" & rMatDep("MatDepID") & """   Dated=""" & Me.dt_date.Value & """/>") Then
                    f2.ShowDialog()
                    If f2.DoRefresh Then
                        reCalc(True)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dt_date_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_date.AfterCloseUp
        reCalc(False)
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            Dim f2 As New frmProdLotReport
            If f2.PrepForm(Me.myView, EnumfrmMode.acEditM, myUtils.DataRowFromGridRow(myView.ContextRow)("ProdLotReportID"), "<PARAMS  MatDepID=""" & rMatDep("MatDepID") & """ Dated=""" & Me.dt_date.Value & """/>") Then
                f2.ShowDialog()
                If f2.DoRefresh Then Me.reCalc(True)
            End If
        End If
    End Sub

    Private Sub btnPrnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrnEmp.Click
        Me.Controller.PrintingPress.GenerateAndShowReport(myVueEmp, EnumPrintWhat.acAllBands)
    End Sub

    Private Sub btnDelDoc_Click(sender As Object, e As EventArgs) Handles btnDelDoc.Click
        myVueEmp.ContextRow = myVueEmp.mainGrid.ActiveRow
        If Not myVueEmp.ContextRow Is Nothing Then
            If myUtils.cValTN(myVueEmp.ContextRow.CellValue("prodcontriempid")) = 0 Then
                myVueEmp.mainGrid.ButtonAction("del")
            Else
                Dim oRet As clsProcOutput = Me.GenerateIDOutput("deleteemp", myUtils.cValTN(myVueEmp.ContextRow.CellValue("prodcontriempid")))
                If oRet.Success Then
                    Dim rr As DataRow() = New DataRow() {myWinUtils.DataRowFromGridRow(myVueEmp.mainGrid.myGrid.ActiveRow)}
                    myUtils.RemoveRows(rr)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btnProcessHours_Click(sender As Object, e As EventArgs) Handles btnProcessHours.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Date", Me.dt_date.Value, GetType(Date), False))
        Params.Add(New clsSQLParam("@matdepid", myUtils.cValTN(cmb_matdepid.Value), GetType(Integer), False))
        Dim oret As clsProcOutput = Me.GenerateParamsOutput("calcincen", Params)
        If Not oret.Success Then MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
    End Sub

    Private Sub btnPrnProg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrnProg.Click
        Me.Controller.PrintingPress.GenerateAndShowReport(myView, EnumPrintWhat.acAllBands)
    End Sub

    Private Sub btnEditGroup_Click(sender As Object, e As EventArgs) Handles btnEditGroup.Click
        Dim oReportProc As New clsProdReportProc(Me.Controller)
        myVueGroup.ContextRow = myVueGroup.mainGrid.ActiveRow
        If Not myVueGroup.ContextRow Is Nothing Then
            Dim f2 As New frmProdContriEmpGrp
            If f2.PrepForm(myVueGroup, myUtils.DataRowFromGridRow(myVueGroup.ContextRow), oReportProc) Then
                f2.ShowDialog()
                If f2.DoRefresh Then
                    reCalc(True)
                End If
            End If
        End If
    End Sub

    Private Function reCalc(ForceRefresh As Boolean) As Boolean

        If (Not IsNothing(Me.dt_date.Value)) Then
            If vwDate <> Me.dt_date.Value Then
                Me.VSave()
                Me.PrepForm(rMatDep("matdepid"), Me.dt_date.Value)
            ElseIf ForceRefresh Then
                Me.PrepForm(rMatDep("matdepid"), Me.dt_date.Value)
            End If
        End If
        Return True
    End Function

    Private Sub dt_date_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_date.Leave, dt_date.AfterCloseUp
        reCalc(False)
        HandleDate(dt_date.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub

    Public Sub DoButtons(ByVal Enable As Boolean)
        btnSave.Enabled = Enable
        btnOK.Enabled = Enable
        btnEdit.Enabled = Enable
        btnEditDoc.Enabled = Enable
        btnDelDoc.Enabled = Enable
        btnAddDoc.Enabled = Enable
        btnEditGroup.Enabled = Enable
        btnFile.Enabled = Enable
    End Sub

End Class
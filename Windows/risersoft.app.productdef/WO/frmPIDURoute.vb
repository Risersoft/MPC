Imports ut = Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmPIDURoute
    Inherits frmMax
    Dim myVueBasic As New clsWinView, dv As DataView
    Dim fBom As frmPIDUMatBOM, fp As frmMax

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridOp)
        myVueBasic.SetGrid(Me.UltraGridBasic)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        fBom = New frmPIDUMatBOM
        fBom.AddtoTab(Me.UltraTabControl1, "bom", True)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDURouteModel = Me.InitData("frmPIDURouteModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            fp = pView.fParentWin
            fBom.PrepFormRow(myView, myRow.Row, myRow("pidunitid"))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("Op"))
            myVueBasic.PrepEdit(Me.Model.GridViews("Basic"))
            myWinSQL.AssignCmb(Me.dsCombo, "PlnRouting", "", Me.cmb_PlnRoutingID)
            myWinSQL.AssignCmb(Me.dsCombo, "PlnProcTypeIncen", "", Me.cmb_PlnProcTypeIncenID)
            myWinSQL.AssignCmb(Me.dsCombo, "PlnStdSeqProc", "", Me.cmb_PlnStdSeqProcID)

            dv = myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID1, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID2, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID3, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID4, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID5, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevPIDURouteID6, , 1)
            dv.RowFilter = "plnpidurouteid<>" & myUtils.cValTN(myRow("plnpidurouteid"))

            Return True
        End If
        Return False
    End Function
   
    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If Me.SaveModel() Then
                fBom.VSave()
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub btn_EditOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditOp.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmOp), "plnopid", "")
        If Not nr Is Nothing Then
            Dim oRet As clsProcOutput = Me.GenerateIDOutput("Op", frmIDX)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btn_AddOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOp.Click
        If Me.VSave Then
            Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmOp), "plnopid", "<PARAMS PlnPIDURouteID=""" & myRow("PlnPIDURouteID") & """/>")
            If Not nr Is Nothing Then
                Dim oRet As clsProcOutput = Me.GenerateIDOutput("Op", frmIDX)
                If oRet.Success Then
                    Me.UpdateViewData(myView, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btn_DeleteOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelOp.Click
        Dim oRet As New clsProcOutput
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Operation", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                DeleteOp(myUtils.cValTN(myView.ContextRow.CellValue("PlnOpid")))
            End If
        End If
    End Sub

    Private Sub btnAddBasic_Click(sender As Object, e As EventArgs) Handles btnAddBasic.Click
        Dim rr() As DataRow
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@plnproctypeincenid", myUtils.cValTN(myRow("plnproctypeincenid")), GetType(Integer), False))
        rr = Me.AdvancedSelect("prodbasic", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            For i As Integer = 1 To 3
                If myUtils.cValTN(rr(0)("prodtype" & i)) > 0 Then
                    Dim nr As DataRow = myUtils.CopyOneRow(rr(0), myVueBasic.mainGrid.myDS.Tables(0))
                    nr("typenum") = i
                    nr("plnpidurouteid") = frmIDX
                    nr("basicprod") = rr(0)("prodtype" & i)
                    nr("typedescrip") = rr(0)("typedescrip" & i)
                End If
            Next
        End If
    End Sub

    Private Sub UltraGridBasic_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridBasic.AfterCellUpdate
        Select Case e.Cell.Column.Key.Trim.ToLower
            Case "typenum"
                Dim str1 As String = "prodtype" & CInt(myUtils.cValTN(e.Cell.Value))
                If e.Cell.Band.Columns.Exists(str1) Then
                    e.Cell.Row.Cells("basicprod").Value = e.Cell.Row.Cells(str1).Value
                Else
                    e.Cell.Row.Cells("basicprod").Value = 0
                End If
                Dim str2 As String = "typedescrip" & CInt(myUtils.cValTN(e.Cell.Value))
                If e.Cell.Band.Columns.Exists(str2) Then
                    e.Cell.Row.Cells("typedescrip").Value = e.Cell.Row.Cells(str2).Value
                Else
                    e.Cell.Row.Cells("typedescrip").Value = ""
                End If
        End Select
        myVueBasic.mainGrid.myGrid.UpdateData()
        Me.UpdatePIDURouteBasic()

    End Sub

    Private Sub UpdatePIDURouteBasic()
        Dim oDef As New clsPIDURouteBase(Me.Controller)
        oDef.UpdatePIDURouteBasic(fp.myRow.Row, myRow.Row, myVueBasic.mainGrid.myDS.Tables(0))
    End Sub

    Private Sub btnDelBasic_Click(sender As Object, e As EventArgs) Handles btnDelBasic.Click
        myVueBasic.mainGrid.ButtonAction("del")
        Me.UpdatePIDURouteBasic()
    End Sub

    Private Sub btnSelectSeqProc_Click(sender As Object, e As EventArgs) Handles btnSelectSeqProc.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@plnprocid", myUtils.cValTN(myRow("plnprocid")), GetType(Integer), False))
        Dim rr() As DataRow = Me.AdvancedSelect("plnstdseqproc", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cm.EndCurrentEdit()
            Dim cont As Boolean = True
            If myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                cont = (MsgBox("Routing Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
            End If
            If cont Then
                myRow("plnprocid") = rr(0)("plnprocid")
                myRow("plnstdseqprocid") = rr(0)("plnstdseqprocid")
                cm.Refresh()
            End If
        End If
    End Sub

    Private Sub btnSelectPlnRouting_Click(sender As Object, e As EventArgs) Handles btnSelectPlnRouting.Click
        If frmMode = EnumfrmMode.acEditM OrElse Me.VSave Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@plnprocid", myUtils.cValTN(myRow("plnprocid")), GetType(Integer), False))
            Dim rr() As DataRow = Me.AdvancedSelect("plnrouting", Params)
            If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                cm.EndCurrentEdit()
                Dim cont As Boolean = True
                If myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                    cont = (MsgBox("Routing Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
                End If
                If cont Then
                    myRow("plnroutingid") = rr(0)("plnroutingid")
                    Dim oRet As clsProcOutput = Me.GenerateDataOutput("SelectPlnRouting", myRow.Row.Table.DataSet, fp.myRow("pidunitid"))
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    End If
                    cm.Refresh()
                End If
            End If
        End If
    End Sub

    Private Sub btnSelectProcTypeIncen_Click(sender As Object, e As EventArgs) Handles btnSelectProcTypeIncen.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@plnprocid", myUtils.cValTN(myRow("plnprocid")), GetType(Integer), False))
        Dim rr() As DataRow = Me.AdvancedSelect("plnproctypeincen", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cm.EndCurrentEdit()
            Dim cont As Boolean = True
            If myVueBasic.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                cont = (MsgBox("Incentive Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
            End If
            If cont Then
                myRow("plnproctypeincenid") = rr(0)("plnproctypeincenid")
                Dim oRet As clsProcOutput = Me.GenerateDataOutput("SelectProcTypeIncen", myRow.Row.Table.DataSet, fp.myRow("pidunitid"))
                If oRet.Success Then
                    Me.UpdateViewData(myVueBasic, oRet)
                End If
                cm.Refresh()
            End If
        End If

    End Sub

    Private Sub btnGenerateBOM_Click(sender As Object, e As EventArgs) Handles btnGenerateBOM.Click
        cm.EndCurrentEdit()
        If myUtils.cValTN(myRow("plnstdseqprocid")) > 0 Then
            Dim cont As Boolean = True
            If fBom.myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                cont = (MsgBox("BOM Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
            End If
            If cont Then
                Dim oRet As clsProcOutput = Me.GenerateDataOutput("GenerateBOM", myRow.Row.Table.DataSet, fp.myRow("pidunitid"))
                If oRet.Success Then
                    fBom.LoadProcessBOMTree()
                End If
            End If
        End If
    End Sub

    Private Sub DeleteOp(plnOpid As Integer)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@plnpidurouteid", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params.Add(New clsSQLParam("@plnopid", plnOpid, GetType(Integer), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("deleteop", Params)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
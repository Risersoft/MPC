Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmProdLotMat
    Inherits frmMax
    Dim myViewRes, myViewPOLPO, myViewJOWMO, myViewReqPO, myViewReqJWO, myViewPlnO As New clsWinView
    Dim fBOM As frmMatPos

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        myViewRes.SetGrid(UltraGrid2)
        myViewPOLPO.SetGrid(UltraGrid3)
        myViewJOWMO.SetGrid(UltraGrid4)
        myViewReqPO.SetGrid(UltraGrid5)
        myViewPlnO.SetGrid(UltraGrid6)
        myViewReqJWO.SetGrid(UltraGrid7)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        fBOM = New frmMatPos
        fBOM.AddtoTab(Me.UltraTabControl3, "bom", True)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotMatModel = Me.InitData("frmProdLotMatModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then fBOM.PrepForm(pView, frmMode, frmIDX)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("LotMRP"))
            myViewRes.PrepEdit(Me.Model.GridViews("Res"))
            myViewPOLPO.PrepEdit(Me.Model.GridViews("POLPO"))
            myViewJOWMO.PrepEdit(Me.Model.GridViews("JOWMO"))
            myViewReqPO.PrepEdit(Me.Model.GridViews("ReqPO"))
            myViewPlnO.PrepEdit(Me.Model.GridViews("PlnO"))
            myViewReqJWO.PrepEdit(Me.Model.GridViews("ReqJWO"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False

        If Me.CanSave() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Public Overrides Sub MakeDownLevel()
        Me.Panel1.Visible = False
        Me.Panel4.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Private Sub btnRunMRP_Click(sender As Object, e As EventArgs) Handles btnRunMRP.Click
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("calculate", myUtils.cValTN(myRow("ProdLotId")))
        If oRet.Success Then Me.UpdateViewData(myView, oRet) Else MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Me.dt_MRPRunDate.Value = Now.Date
        Me.VSave()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not IsNothing(myView.ContextRow) Then
            Dim f As New frmPlnResSumm
            If f.PrepForm(myView, EnumfrmMode.acAddM, 0, "<PARAMS PRODLOTID=""" & frmIDX & """/>") Then
                f.ShowDialog()

                Dim oRet As clsProcOutput = Me.GenerateIDOutput("generate", myUtils.cValTN(myRow("ProdLotId")))
                If oRet.Success Then
                    Me.UpdateViewData(myView, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Params As New List(Of clsSQLParam), str1 As String = "", str2 As String = ""
        Params.Add(New clsSQLParam("@itemidcsv", myUtils.MakeCSV(myView.mainGrid.myDv.Table.Select(), "ItemID"), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("items", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            If myUtils.cBoolTN(rr(0)("IsETO")) = True Then
                Params.Clear()
                Params.Add(New clsSQLParam("@ItemID", myUtils.cValTN(rr(0)("itemid")), GetType(Integer), False))
                Dim oView As clsViewModel = Me.GenerateParamsModel("lotmrp", Params)
                If oView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                    Dim f1 As New frmGrid
                    f1.myView.PrepEdit(oView)
                    If f1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        str2 = "VarWoInfo=""" & myUtils.cStrTN(f1.myView.ContextRow.CellValue("WoInfo")) & """ VarNum=""" & myUtils.cStrTN(f1.myView.ContextRow.CellValue("VarNum")) & """"
                    Else
                        Exit Sub
                    End If
                Else
                    MsgBox("Item Not Defined for Lot BOM", MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    Exit Sub
                End If
            End If
            str1 = "<PARAMS PRODLOTID=""" & myUtils.cValTN(frmIDX) & """ ItemID=""" & myUtils.cValTN(rr(0)("ItemID")) & """ LotInfo=""" & myUtils.cStrTN(myRow.Row("LotInfo")) & """ ItemCode=""" & myUtils.cStrTN(rr(0)("ItemCode")) & """ ItemName =""" & myUtils.cStrTN(rr(0)("ItemName")) & """ " & str2 & "/>"

            Dim f As New frmPlnResSumm
            If f.PrepForm(myView, EnumfrmMode.acAddM, 0, str1) Then
                f.ShowDialog()

                Dim oRet As clsProcOutput = Me.GenerateIDOutput("generate", myUtils.cValTN(myRow("ProdLotId")))
                If oRet.Success Then
                    Me.UpdateViewData(myView, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub
End Class
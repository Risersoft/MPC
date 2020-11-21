Imports ut = Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmProdLotRouteScene
    Inherits frmMax

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Sub MakeDownLevel()
        Me.PanelSave.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotRouteSceneModel = Me.InitData("frmProdLotRouteSceneModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("LotOp"))

            myWinSQL.AssignCmb(Me.dsCombo, "PlnRouting", "", Me.cmb_PlnRoutingID)
            myWinSQL.AssignCmb(Me.dsCombo, "PlnProcShop", "", Me.cmb_PlnProcShopID)

            Me.cmb_IsOutSourced.ValueList = Me.Model.ValueLists("OutSourced").ComboList
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

    Private Sub btn_EditOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditLotOp.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmProdLotOp), "ProdLotOpID", "")
        If Not nr Is Nothing Then
            RefreshGrid("refresh", 0)
        End If
    End Sub

    Private Sub btn_DeleteOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelOp.Click
        Dim oRet As New clsProcOutput
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Operation", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                RefreshGrid("delete", myUtils.cValTN(myView.ContextRow.CellValue("ProdLotOpid")))
            End If
        End If
    End Sub

    Private Sub btnSelectPlnRouting_Click(sender As Object, e As EventArgs) Handles btnSelectPlnRouting.Click
        Dim oRet As New clsProcOutput
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
                myRow("PlnProcShopID") = rr(0)("plnprocshopid")
                RefreshGrid("generate", 0)
            End If
        End If
    End Sub

    Private Sub RefreshGrid(key As String, ProdLotOpid As Integer)
        Dim oRet As New clsProcOutput
        Dim Params1 As New List(Of clsSQLParam)
        Params1.Add(New clsSQLParam("@ProdLotRouteSceneID", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params1.Add(New clsSQLParam("@ProdLotOpid", myUtils.cValTN(ProdLotOpid), GetType(Integer), False))
        oRet = Me.GenerateParamsOutput(key.Trim.ToLower, Params1)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
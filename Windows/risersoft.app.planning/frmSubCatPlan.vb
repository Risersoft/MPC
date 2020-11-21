Imports Infragistics.Win
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmSubCatPlan
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridSupp)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmSubCatPlanModel = Me.InitData("frmSubCatPlanModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                codesys.SetConf(Me.dsCombo.Tables("ItemSBHead"), Me.cmb_ItemSBHeadID, Me.ComboUnit)

                Me.cmb_ItemSBHeadID.Value = CInt(myUtils.cValTN(myRow("ItemSbHeadID")))
                Me.codesys.HandleCombo(Me.cmb_ItemSBHeadID, EnumWantEvent.acForceEvent)
                PrepForm = True
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Supp"))

            Me.cmb_VendorListHead.ValueList = Me.Model.ValueLists("Head").ComboList
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        If Me.CanSave Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim f As New frmSubCatSupp
        If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS SUBCATID=""" & frmIDX & """/>") Then
            f.ShowDialog()
            RefreshGrid("refresh", 0)
        End If
    End Sub

    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        Dim f As New frmSubCatSupp
        If (Not myView.ContextRow Is Nothing) AndAlso f.PrepForm(myView, EnumfrmMode.acEditM, myView.ContextRow.CellValue("SubCatSuppID")) Then
            f.ShowDialog()
            RefreshGrid("refresh", 0)
        End If
    End Sub

    Private Sub btnDelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelItem.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                RefreshGrid("delete", myUtils.cValTN(myView.ContextRow.CellValue("SubCatSuppID")))
            End If
        End If
    End Sub

    Private Sub RefreshGrid(key As String, SubCatSuppID As Integer)
        Dim oRet As New clsProcOutput
        Dim Params1 As New List(Of clsSQLParam)
        Params1.Add(New clsSQLParam("@SubCatID", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params1.Add(New clsSQLParam("@SubCatSuppID", myUtils.cValTN(SubCatSuppID), GetType(Integer), False))
        oRet = Me.GenerateParamsOutput(key.Trim.ToLower, Params1)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
Imports risersoft.app.mxform
Public Class frmItemPlan
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim myViewML As New clsWinView

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGridSupp)
        Me.myViewML.SetGrid(Me.UGridML)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmItemPlanModel = Me.InitData("frmItemPlanModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.cmb_subcatID.Value = CInt(myUtils.cValTN(myRow("subcatid")))
            Me.codesys.HandleCombo(Me.cmb_subcatID, EnumWantEvent.acForceEvent)

            Me.CtlItemVMS1.InitVMS(frmIDX)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Supp"), , btnDelItem)
            myViewML.PrepEdit(Me.Model.GridViews("ML"))
            Me.myViewML.mainGrid.HighlightRows()

            myWinSQL.AssignCmb(Me.dsCombo, "Size", "", Me.cmb_ItemSizeID)
            myWinSQL.AssignCmb(Me.dsCombo, "CostItem", "", Me.cmb_CostingItemID)
            codesys.SetConf(Me.dsCombo.Tables("Items"), Me.cmb_subcatID, Me.ComboUnit)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False

        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Dim hasdefs As Boolean = False

        If Not Me.cmb_subcatID.SelectedRow Is Nothing Then
            hasdefs = myUtils.cBoolTN(Me.cmb_subcatID.SelectedRow.Cells("hasdefs").Value)
            If myUtils.cValTN(Me.cmb_subcatID.SelectedRow.Cells("costingtype").Value) = 4 Then
                Me.Panel2.Visible = True
            Else
                Me.Panel2.Visible = False
            End If
        End If

    End Sub

    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click
        Dim f As New frmItemSupp
        f.fMat = Me
        myView.ContextRow = Nothing
        If f.PrepForm(Me.myView, EnumfrmMode.acEditM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim f As New frmItemSupp
            f.fMat = Me
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "") Then f.ShowDialog()
        Else
            MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If
    End Sub
End Class
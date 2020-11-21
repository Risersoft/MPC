Imports risersoft.app.mxform

Public Class frmMat_SpItem
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim f As frmMatListSp

    Public Sub initForm()

        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMat_SpItemModel = Me.InitData("frmMat_SpItemModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            f = CType(pView.fParentWin, frmMatListSp)
            If prepMode = EnumfrmMode.acEditM Then
                CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVMSID"))
                cmb_ItemId.Value = Me.CtlItemVMS1.myParentID
            End If
            Me.codesys.HandleCombo(Me.cmb_ItemId, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Me.codesys.SetConf(NewModel.dsCombo.Tables("Items"), Me.cmb_ItemId, Me.cmb_ItemName, Me.cmb_ItemUnit)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        myRow("ItemVMSID") = Me.CtlItemVMS1.ItemVMSID
        If Me.ValidateData() Then
            If Me.DuplicatesOK(f.myView.mainGrid, "SoSpareID", myUtils.cValTN(myRow("SoSpareID")), "MatListSpareID", True) = MsgBoxResult.No Then WinFormUtils.AddError(Me.CtlItemVMS1, "Duplicate Item")
            If Me.CanSave Then
                If Me.SaveModel() Then
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Me.CtlItemVMS1.InitVMS(myUtils.cValTN(cmb_ItemId.Value), , EnumWantEvent.acForceEvent)
    End Sub
End Class
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared
Imports risersoft.shared.Extensions

Public Class frmPIDUMat
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDUMatModel = Me.InitData("frmPIDUMatModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            If prepMode = EnumfrmMode.acEditM Then
                CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVMSID"))
                cmb_ItemId.Value = Me.CtlItemVMS1.myParentID
            End If
            Me.codesys.HandleCombo(Me.cmb_ItemId, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))
            Me.cmb_ProdByPIDURouteID.ReadOnly = myUtils.NullNot(myRow("consbypidurouteid"))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_ConsByPIDURouteID, , 2)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_ProdByPIDURouteID, , 2)
            Me.cmb_AfterEnd.ValueList = Me.Model.ValueLists("AfterEnd").ComboList
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
Imports risersoft.app.mxform
Public Class frmMat_SPHead
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim f As frmMatListSp

    Public Sub initForm()

        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMat_SPHeadModel = Me.InitData("frmMat_SPHeadModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            f = CType(pView.fParentWin, frmMatListSp)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Me.codesys.SetConf(NewModel.dsCombo.Tables("Heads"), Me.cmb_MatHeadID, Me.cmb_HeadCode)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.DuplicatesOK(f.myView.mainGrid, "sospareid", myUtils.cValTN(myRow("sospareid")), "matlistspareid", True) = MsgBoxResult.No Then WinFormUtils.AddError(Me.cmb_MatHeadID, "Duplicate Item")
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
End Class
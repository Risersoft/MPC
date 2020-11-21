
Public Class frmItemSupp
    Inherits frmMax
    Dim WithEvents ItemCodeSys As New clsCodeSystem
    Friend fMat As frmItemPlan

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        myWinSQL.AssignCmb(fMat.dsCombo, "Vendor", "", Me.cmb_VendorID)
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            PrepForm = True
        End If
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click, btnCancel.Click
        Me.InitError()
        If myUtils.NullNot(Me.cmb_VendorID.Value) Then WinFormUtils.AddError(Me.cmb_VendorID, "Select a Party")
        If Me.CanSave Then
            cm.EndCurrentEdit()
            myRow("partyname") = Me.cmb_VendorID.Text
            Me.SaveSoftData()
        End If
    End Sub
End Class








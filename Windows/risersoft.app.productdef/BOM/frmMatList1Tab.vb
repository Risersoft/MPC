Public Class frmMatList1Tab
    Inherits frmMax
    Friend myHead As New clsWinView, fMat As frmMax, matindex As Integer

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid5)
        myHead.SetGrid(Me.UltraGrid25)
    End Sub
End Class

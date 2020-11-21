Imports risersoft.shared
Imports Infragistics.Win.UltraWinGrid

Public Class myFuncs
    Inherits risersoft.app.shared.myFuncs
    Public Sub ColorPID(ByVal oview As clsWinView, ByVal frmidx As String, ByVal e As clsRow)
        Dim gRow As UltraGridRow = e.Row
        If gRow.Cells.Count > 0 Then
            If myUtils.NullNot(gRow.Cells("prodfiledate").Value) Then
                gRow.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
            Else
                If myUtils.cBoolTN(gRow.Cells("iscompleted").Value) = False AndAlso myUtils.cValTN(gRow.Cells("numlots").Value) = 0 Then
                    gRow.Appearance.BackColor = System.Drawing.Color.LightPink
                Else
                    gRow.Appearance.BackColor = System.Drawing.Color.LightGreen
                End If
            End If
        End If
    End Sub
End Class
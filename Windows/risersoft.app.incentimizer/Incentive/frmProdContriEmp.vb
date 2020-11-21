Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmProdContriEmp
    Inherits frmMax
    Dim mProc As clsProdReportProc, myVueGrp, myVueOther As New clsWinView

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myVueGrp.SetGrid(Me.UltraGrid2)
        myVueOther.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(btnOK, btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Dim objModel As frmProdContriEmpModel = Me.InitData("frmProdContriEmpModel", oview, prepMode, prepIdx, strXML)

        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overloads Function BindModel(NewModel As clsFormDataModel, oView As clsWinView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myVueGrp.PrepEdit(Me.Model.GridViews("EmpGrp"))
            myVueOther.PrepEdit(Me.Model.GridViews("Other"))
            myView.PrepEdit(Me.Model.GridViews("EmpInd"))
        End If
        Return True
    End Function

    Private Sub recalc()
        Me.txt_TotHours.Text = myUtils.cValTN(Me.txt_OtherProd.Text) + myUtils.cValTN(Me.txt_OtherOT.Text) + myUtils.cValTN(Me.txt_OtherGen.Text) + myUtils.cValTN(Me.txt_GenHours.Text) + myUtils.cValTN(Me.txt_OTHours.Text) + myUtils.cValTN(Me.txt_ProdHours.Text)
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub txt_OTHours_ValueChanged(sender As Object, e As EventArgs) Handles txt_OTHours.ValueChanged
        If Me.FormPrepared Then Me.recalc()
    End Sub

    Private Sub txt_GenHours_ValueChanged(sender As Object, e As EventArgs) Handles txt_GenHours.ValueChanged
        If Me.FormPrepared Then Me.recalc()
    End Sub
End Class

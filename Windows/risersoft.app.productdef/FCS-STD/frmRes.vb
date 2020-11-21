Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared
Public Class frmRes
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dS As DataTable
        Me.FormPrepared = False
        Dim objModel As frmResModel = Me.InitData("frmResModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            If myUtils.cValTN(myRow("employeeid")) > 0 Then
                Me.Text = "Employee Resource"
                dS = Me.Model.DatasetCollection("Emp").Tables(0)
                Me.lblCode.Text = dS.Rows(0)("EmpCode")
                Me.lblDep.Text = dS.Rows(0)("DepName")
                Me.lblName.Text = dS.Rows(0)("FullName")
                Me.Panel1.Visible = True
                Me.Panel3.Visible = False
                Me.Height = Me.Panel1.Height * 3

            Else

                Me.Text = "Other Resource"
                Me.Panel1.Visible = False
                Me.Panel3.Visible = True
                Me.Height = Me.Panel1.Height * 3
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "shift", "", Me.cmb_shiftid)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If Me.SaveModel() Then
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

End Class
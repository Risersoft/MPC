Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmProdBasic
    Inherits frmMax
    Friend fp As frmPlnProcTypeIncen, fv As frmAttribValue
    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        fv = New frmAttribValue
        fv.AddToPanel(Me.SplitContainer1.Panel2, True, DockStyle.Fill)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False

        Dim objModel As frmProdBasicModel = Me.InitData("frmProdBasicModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            fp = CType(oView.fParentWin, frmPlnProcTypeIncen)

            If myUtils.cStrTN(fp.myRow("typedescrip1")).Trim.Length > 0 Then
                Me.lblType1.Text = fp.myRow("typedescrip1")
            Else
                Me.lblType1.Text = "Default Type"
            End If
            If myUtils.cStrTN(fp.myRow("typedescrip2")).Trim.Length > 0 Then
                Me.lblType2.Text = fp.myRow("typedescrip2")
            Else
                Me.lblType2.Visible = False
                Me.txt_ProdType2.Visible = False
            End If
            If myUtils.cStrTN(fp.myRow("typedescrip3")).Trim.Length > 0 Then
                Me.lblType3.Text = fp.myRow("typedescrip3")
            Else
                Me.lblType3.Visible = False
                Me.txt_prodType3.Visible = False
            End If

            fv.SetupForm(Me, "plnprocid", fp.myRow("plnprocid"), "PPR", "prodbasicid", frmIDX, "isreq")

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
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
                fv.VSave()
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function
End Class

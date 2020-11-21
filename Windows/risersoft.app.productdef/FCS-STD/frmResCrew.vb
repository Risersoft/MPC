Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared
Imports Infragistics.Win.UltraWinTabControl
Public Class frmResCrew
    Inherits frmMax

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGridResources)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmResCrewModel = Me.InitData("frmResCrewModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Resources"))
            If myUtils.cBoolTN(myRow("isother")) Then
                myView.mainGrid.PrepEntSelect("<SYS ENT=""RESOTHER""/>", Me.btnDel, Me.btnSelRes)
            Else
                myView.mainGrid.PrepEntSelect("<SYS ENT=""RESEMP""/>", Me.btnDel, Me.btnSelRes)
            End If
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
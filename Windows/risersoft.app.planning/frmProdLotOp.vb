Imports risersoft.app.mxform
Public Class frmProdLotOp
    Inherits frmMax
    Dim myViewAct, myViewRes, myViewActRes, myViewResAct As New clsWinView

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGrid1)
        myViewAct.SetGrid(Me.UltraGrid2)
        myViewRes.SetGrid(Me.UltraGrid3)
        myViewActRes.SetGrid(Me.UltraGrid4)
        myViewResAct.SetGrid(Me.UltraGrid5)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotOpModel = Me.InitData("frmProdLotOpModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("OpUp"), Me.btnAddParam, Me.btnDelParam)
            myViewAct.PrepEdit(Me.Model.GridViews("Act"))
            myViewRes.PrepEdit(Me.Model.GridViews("Res"))
            myViewActRes.PrepEdit(Me.Model.GridViews("ActRes"))
            myViewResAct.PrepEdit(Me.Model.GridViews("ResAct"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False

        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraGrid2_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid2.AfterRowActivate
        Dim str1 As String
        If myViewAct.mainGrid.myGrid.ActiveRow Is Nothing Then
            myViewActRes.mainGrid.myDv.RowFilter = "ItemID=0"
        Else
            str1 = "ProdLotOpActID=" & myUtils.cValTN(myViewAct.mainGrid.myGrid.ActiveRow.Cells("ProdLotOpActID").Value)
            myViewActRes.mainGrid.myDv.RowFilter = str1
        End If
    End Sub

    Private Sub UltraGrid3_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid3.AfterRowActivate
        Dim str1 As String
        If myViewRes.mainGrid.myGrid.ActiveRow Is Nothing Then
            myViewResAct.mainGrid.myDv.RowFilter = "ItemID=0"
        Else
            str1 = "PlnResourceID=" & myUtils.cValTN(myViewRes.mainGrid.myGrid.ActiveRow.Cells("PlnResourceID").Value)
            myViewResAct.mainGrid.myDv.RowFilter = str1
        End If
    End Sub
End Class
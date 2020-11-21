Imports ug = Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmProdLotRoute
    Inherits frmMax
    Dim fList As New clsCollection(Of Integer, frmProdLotRouteScene)

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControlScene.Tabs.Clear()
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotRouteModel = Me.InitData("frmProdLotRouteModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                fList.Clear()
                For Each r2 As DataRow In Me.Model.DatasetCollection("route").Tables("route").Rows
                    Dim f2 As New frmProdLotRouteScene
                    If f2.PrepForm(Me.myView, EnumfrmMode.acEditM, myUtils.cValTN(r2("ProdLotRouteSceneID")), "") Then
                        fList.Add(r2("SceneNum"), f2)
                        Dim uTab2 As UltraTab = f2.AddtoTab(Me.UltraTabControlScene, r2("SceneNum"), True)
                        uTab2.Text = r2("SceneName")
                    End If
                Next
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ProdList"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.CanSave() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                For Each f2 As frmProdLotRouteScene In fList.Values
                    f2.VSave()
                Next
                Me.GenerateIDOutput("prodlot", myUtils.cValTN(myRow("ProdLotId")))
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class
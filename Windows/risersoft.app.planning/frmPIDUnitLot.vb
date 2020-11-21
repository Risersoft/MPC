Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Public Class frmPIDUnitLot
    Inherits frmMax

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(UltraGrid1)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDUnitLotModel = Me.InitData("frmPIDUnitLotModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.Text = myRow("PIDInfo")
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Lots"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError() 
        VSave = False

        If Me.CanSave Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditLot.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmProdLot), "ProdLotID", "")
        If Not nr Is Nothing Then
          RefreshGrid()
        End If
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLot.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmProdLot), "ProdLotID", "<PARAMS PIDUNITID=""" & myRow("PIDUNITID") & """/>")
        If Not nr Is Nothing Then
            RefreshGrid()
        End If
    End Sub

    Private Sub RefreshGrid()
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("prodlot", frmIDX)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
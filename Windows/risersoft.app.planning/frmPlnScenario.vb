Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports System.Windows.Forms

Public Class frmPlnScenario
    Inherits frmMax2
    Dim myViewMRP As New clsWinView

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        myViewMRP.SetGrid(UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPlnScenarioModel = Me.InitData("frmPlnScenarioModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ProdLot"))
            myViewMRP.PrepEdit(Me.Model.GridViews("MRP"))
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
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        win.myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, report.Message)
    End Sub
    Private Sub SetEnabled(Enabled As Boolean)
        If Not Enabled Then Me.RichTextBox1.Clear()
        For Each pnl As Panel In New Panel() {Me.Panel4, Me.Panel5, Me.Panel6, Me.Panel7}
            pnl.Enabled = Enabled
        Next
    End Sub

    Private Async Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "ZIP File (*.zip)|*.zip"
        sfd.FilterIndex = 1
        If sfd.ShowDialog = DialogResult.OK Then
            Me.SetEnabled(False)
            Dim oRet As clsProcOutput = Await Me.GenerateIDOutputAsync("export", myUtils.cValTN(myRow("scenenum")), AddressOf ProgressChanged)
            Dim oFiler As New clsMultiFiler(Me.Controller, "pln")
            Await oFiler.FileProvider.DownloadFileAsync(oRet.Description, sfd.FileName)
            Me.SetEnabled(True)
        End If
    End Sub
    Private Async Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim ofd As New OpenFileDialog, Params As New List(Of clsSQLParam)
        ofd.Filter = "ZIP File (*.zip)|*.zip"
        ofd.FilterIndex = 1
        Dim oFiler As New clsMultiFiler(Me.Controller, "pln")
        If ofd.ShowDialog = DialogResult.OK Then
            Me.SetEnabled(False)
            Dim filename As String = Await oFiler.FileProvider.UpLoadAsync(ofd.FileName, System.Guid.NewGuid.ToString, "")
            Params.Add(New clsSQLParam("@scenenum", myUtils.cValTN(myRow("scenenum")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@filename", filename, GetType(Uri), False))
            Await Me.GenerateParamsOutputAsync("import", Params, AddressOf ProgressChanged)
            Me.SetEnabled(True)
            RefreshGridMyView()
        End If
    End Sub


    Private Async Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        Me.SetEnabled(False)
        Await Me.GenerateIDOutputAsync("publish", myUtils.cValTN(myRow("scenenum")), AddressOf ProgressChanged)
        Me.SetEnabled(True)
        RefreshGridMyView()
    End Sub

    Private Async Sub btnRunMRP_Click(sender As Object, e As EventArgs) Handles btnRunMRP.Click
        Me.SetEnabled(True)
        Dim oRet As clsProcOutput = Await Me.GenerateIDOutputAsync("generate", myUtils.cValTN(myRow("SceneNum")), AddressOf ProgressChanged)
        If oRet.Success Then
            Me.UpdateViewData(myViewMRP, oRet)
            Me.dt_MRPRunDate.Value = Now.Date
            Me.VSave()
            Me.SetEnabled(True)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Async Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Me.SetEnabled(False)
        Await Me.GenerateIDOutputAsync("run", myUtils.cValTN(myRow("scenenum")), AddressOf ProgressChanged)
        Me.SetEnabled(True)
        RefreshGridMyView()
    End Sub

    Private Sub RefreshGridMyView()
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("prodlotroute", frmIDX)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
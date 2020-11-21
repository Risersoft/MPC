Imports ut = Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app2.shared

Public Class frmPIDURouteList
    Inherits frmMax2
    Implements IfWizMax, ITFSetup
    Dim dic As clsCollecString(Of Boolean)
    Public fTF As frmWizMax
    Dim startTime As Date
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridRoute)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        dic = myWinApp.objAppExtender.dicMat
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDURouteListModel = Me.InitData("frmPIDURouteListModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("Route"))
            myWinSQL.AssignCmb(Me.dsCombo, "PlnStdSeq", "", Me.cmb_PlnStdSeqID)
            Return True
        End If
        Return False
    End Function

    Private Sub btn_ReGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReGenerate.Click
        If myUtils.cBoolTN(dic("des")) Then
            Dim cont As Boolean = True
            If myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                cont = (MsgBox("Routing Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
            End If

            If cont Then
                Me.reCalc(0)
            End If
        End If

    End Sub

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

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmPIDURoute), "plnpidurouteid", "")
        If Not nr Is Nothing Then
            Dim oRet As clsProcOutput = Me.GenerateIDOutput("Route", frmIDX)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmPIDURoute), "plnpidurouteid", "<PARAMS PIDUNITID=""" & myRow("pidunitid") & """/>")
        If Not nr Is Nothing Then
            Dim oRet As clsProcOutput = Me.GenerateIDOutput("Route", frmIDX)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Routing", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(frmIDX), GetType(Integer), False))
                Params.Add(New clsSQLParam("@PlnPIDURouteid", myUtils.cValTN(myView.ContextRow.CellValue("PlnPIDURouteid")), GetType(Integer), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delete", Params)
                If oRet.Success Then
                    Me.UpdateViewData(myView, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Public Function btnActionText() As String Implements IfWizMax.btnActionText

    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return True
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput
        Dim str1 As String = "Routing List for " & fTF.oWO.rPIDU("pidinfo")
        Me.Controller.PrintingPress.GenerateAndSaveReport(myView, fTF.oWO, "Routing List", str1, EnumPrintWhat.acAllBands, "", 1)

    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        If Me.FormPrepared Then Return True Else Return Me.DoSetup
    End Function

    Public Function ShowTabKeys() As ArrayList Implements IfWizMax.ShowTabKeys

    End Function

    Public Sub StartAction() Implements IfWizMax.StartAction

    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction

    End Sub

    Public Overrides Sub MakeDownLevel()
        Me.Panel1.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Public Function DoSetup() As Boolean Implements ITFSetup.DoSetup
        Return Me.PrepForm(fTF.myView, EnumfrmMode.acEditM, fTF.myRow("pidunitid"))
    End Function

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = Me.AdvancedSelect("select", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            Dim cont As Boolean = True
            If myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                cont = (MsgBox("Routing Data already created. If you continue, existing data will be erased. Continue?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
            End If
            If cont Then
                cm.EndCurrentEdit()
                myRow("plnstdseqid") = rr(0)("plnstdseqid")
                Me.reCalc(rr(0)("plnstdseqid"))
            End If
        End If
    End Sub

    Private Async Sub reCalc(StdSeqID As Integer)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(myRow("pidunitid")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@StdSeqID", myUtils.cValTN(StdSeqID), GetType(Integer), False))
        Me.Invoke(Sub()
                      Me.StartPrep()
                      fTF.StartTimedProgressBar(80, 60, fTF.UltraProgressBar1, "Creating Routing List")
                  End Sub)
        Dim oRet As clsProcOutput = Await Me.GenerateParamsOutputAsync("recalc", Params, AddressOf ProgressChanged)
        fTF.Invoke(Sub()
                       Me.CompleteRun("Completed", False)
                       If oRet.Success Then
                           Me.UpdateViewData(myView, oRet)
                       Else
                           MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                       End If
                   End Sub)
    End Sub
    Private Sub StartPrep()
        fTF.StartPrep()
        startTime = Now

    End Sub
    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        Select Case report.ReportType
            Case EnumReportType.TaskProgress
                Me.ReportProgress(report.Percentage, report.Message)
            Case EnumReportType.Message
                Me.ReportProgress(0, report.Message)

        End Select
    End Sub
    Public Sub ReportProgress(ByVal ProgressPercentage As Integer, ByVal msgProg As String)
        fTF.ReportProgress(ProgressPercentage, msgProg, DateDiff(DateInterval.Second, startTime, Now))
    End Sub
    Public Sub CompleteRun(ByVal result As String, ByVal cancelled As Boolean)
        fTF.UltraProgressBar1.Visible = False
        fTF.RestoreButtons()
        Debug.WriteLine(result)
    End Sub
End Class
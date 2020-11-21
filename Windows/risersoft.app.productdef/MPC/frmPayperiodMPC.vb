Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app2.shared
Imports risersoft.shared.Extensions
Imports risersoft.app.shared

Public Class frmPayperiodMPC
    Inherits frmMax

    Dim f As New frmApiTaskStatus

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOk, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridHolidays)

        f.AddtoTab(Me.UltraTabControl2, "status", True)
        f.SetParent(Me)
        AddHandler f.TaskExecuted, AddressOf TaskExecuted

    End Sub

    Public Sub TaskExecuted(sender As Object, TaskId As String)
        WinFormUtils.SetReadOnly(Me.UltraPanel1, True, True)
        WinFormUtils.SetReadOnly(Me.UltraPanel3, True, True)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmPayPeriodMPCModel = Me.InitData("frmPayPeriodMPCModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "postperiod", "", Me.cmb_PostPeriodID)
            AssignMasters()

        End If

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean

        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Holiday"), Me.btnAddHoliday, Me.btnDelHoliday)

            Return True
        End If
        Return False
    End Function

    Private Sub AssignMasters()
        myWinSQL.AssignCmb(Me.dsCombo, "finyear", "", Me.cmb_PostPeriodID)
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        Dim objProc As clsProcOutput = Nothing
        VSave = False

        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()

    End Function

    Private Async Sub btn_Incentive_Click(sender As Object, e As EventArgs) Handles btn_Incentive.Click
        Dim oret = GetParams("calcppinc", "")
        MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
    End Sub

    Private Function GetParams(Key As String, UploadType As String)
        WinFormUtils.SetReadOnly(Me.UltraPanel1, True, False)
        WinFormUtils.SetReadOnly(Me.UltraPanel3, True, False)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PayperiodID", myUtils.cValTN(myRow("PayperiodID")), GetType(Integer), False))
        Dim oRet = Me.GenerateParamsOutput(Key, Params)
        Dim result As Guid
        If System.Guid.TryParse(oRet.Description, result) Then
            f.AddTask(result.ToString)
        End If
        Return oRet

    End Function


End Class





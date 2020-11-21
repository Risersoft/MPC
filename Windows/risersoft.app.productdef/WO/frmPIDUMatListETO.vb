Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmPIDUMatListETO
    Inherits frmMax
    Implements IfWizMax
    Dim myVueSpec As New clsWinView
    Public fTF As frmMax

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridItems)
        myVueSpec.SetGrid(Me.UltraGridSpecs)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDUMatListETOModel = Me.InitData("frmPIDUMatListETOModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("Items"))
            myVueSpec.PrepEdit(Me.Model.GridViews("Specs"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.SaveModel() Then
            Return True
        End If
        Me.Refresh()
    End Function

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "items"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmETOItem), "pidunititemvarid", "")
                If Not nr Is Nothing Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("items", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If

            Case "specs"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueSpec, "edit", GetType(frmSpecs2), "itemvmsid", "")
                If Not nr Is Nothing Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("specs", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myVueSpec, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = Me.AdvancedSelect(Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower, Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            Dim str1 As String = "<PARAMS PIDUNITID=""" & myRow("pidunitid") & """ ITEMID=""" & rr(0)("itemid") & """/>"
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "items"
                    Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmETOItem), "pidunititemvarid", str1)
                    If Not nr Is Nothing Then
                        Dim oRet As clsProcOutput = Me.GenerateIDOutput("items", frmIDX)
                        If oRet.Success Then
                            Me.UpdateViewData(myView, oRet)
                        Else
                            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                        End If
                    End If

                Case "specs"
                    Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueSpec, "add", GetType(frmSpecs2), "itemvmsid", str1)
                    If Not nr Is Nothing Then
                        Dim oRet As clsProcOutput = Me.GenerateIDOutput("specs", frmIDX)
                        If oRet.Success Then
                            Me.UpdateViewData(myVueSpec, oRet)
                        Else
                            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                        End If
                    End If
            End Select
        End If
    End Sub

    Public Function btnActionText() As String Implements IfWizMax.btnActionText

    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return True
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput

    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        Return Me.PrepForm(fTF.myView, EnumfrmMode.acEditM, fTF.myRow("pidunitid"))
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

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click

        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower

            Case "items"
                If MsgBox("Are you sure you want to delete this Item", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(frmIDX), GetType(Integer), False))
                    Params.Add(New clsSQLParam("@itemVMSID", myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("itemVMSID").Value), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delitems", Params)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If

            Case "specs"
                If MsgBox("Are you sure you want to delete this Specs", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(frmIDX), GetType(Integer), False))
                    Params.Add(New clsSQLParam("@itemVMSID", myUtils.cValTN(myVueSpec.mainGrid.myGrid.ActiveRow.Cells("itemVMSID").Value), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delspecs", Params)
                    If oRet.Success Then
                        Me.UpdateViewData(myVueSpec, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
        End Select

    End Sub
End Class
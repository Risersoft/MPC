Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared
Imports risersoft.shared.Extensions

Public Class frmPlnProc
    Inherits frmMax
    Dim myVueShop, myVueIncType, myVueProcType, myVueSeqProc As New clsWinView
    Dim fa As frmAttribClassAssign

    Public Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGridRoutings)
        Me.myVueShop.SetGrid(Me.UltraGridVueShop)
        Me.myVueIncType.SetGrid(Me.UltraGridIncType)
        Me.myVueProcType.SetGrid(Me.UltraGridProcType)
        Me.myVueSeqProc.SetGrid(Me.UltraGridSeqProc)

        fa = New frmAttribClassAssign
        fa.AddtoTab(Me.UltraTabControl1, "class", True)

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPlnProcModel = Me.InitData("frmPlnProcModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            fa.SetupForm(Me, "ppr", "plnprocid", frmIDX)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("Routings"))
            myVueShop.PrepEdit(Me.Model.GridViews("VueShop"))
            myVueIncType.PrepEdit(Me.Model.GridViews("IncType"))
            myVueProcType.PrepEdit(Me.Model.GridViews("ProcType"))
            myVueSeqProc.PrepEdit(Me.Model.GridViews("SeqProc"))

            Me.cmb_RequireMO.ValueList = Me.Model.ValueLists("RequireMO").ComboList

            Return True
        End If
        Return False
    End Function

    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click

        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "routing"
                myView.mainGrid.ButtonAction("del")
            Case "shop"
                myVueShop.ContextRow = myVueShop.mainGrid.ActiveRow
                If Not myVueShop.ContextRow Is Nothing Then
                    If myUtils.cValTN(myVueShop.ContextRow.CellValue("plnprocshopid")) = 0 Then
                        myVueShop.mainGrid.ButtonAction("del")
                    Else
                        If MsgBox("Are you sure you want to delete this Shop", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("deleteshop", myUtils.cValTN(myVueShop.ContextRow.CellValue("plnprocshopid")))
                            If oRet.Success Then
                                Dim rr As DataRow() = New DataRow() {myUtils.DataRowFromGridRow(myVueShop.ContextRow)}
                                myUtils.RemoveRows(rr)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
                End If
            Case "stdseqproc"
                myVueSeqProc.mainGrid.ButtonAction("del")
            Case "inctype"
                myVueIncType.ContextRow = myVueIncType.mainGrid.ActiveRow
                If Not myVueIncType.ContextRow Is Nothing Then
                    Dim oMasterData As New clsMasterDataHRP(Me.Controller)
                    Dim PostPeriodID As Integer = myUtils.cValTN(myVueIncType.ContextRow.CellValue("postperiodid"))
                    If oMasterData.dtPayPeriod.Select("postperiodid=" & PostPeriodID & " and isfinal=1").Length > 0 Then
                        MsgBox("Finalized Payperiods - this Incentive Type cannot be deleted")
                    Else
                        myVueIncType.mainGrid.ButtonAction("del")
                    End If
                End If
            Case "typeincen"
                myVueProcType.mainGrid.ButtonAction("del")
        End Select
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        If myUtils.IsInList(e.Tab.Key.Trim.ToLower, "shop") Then
            btnEditItem.Visible = False
        Else
            btnEditItem.Visible = True
        End If
    End Sub

    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "routing"
                myView.ContextRow = myView.mainGrid.ActiveRow
                If Not myView.ContextRow Is Nothing Then
                    Dim frm As New frmRouting
                    If frm.PrepForm(Me.myView, EnumfrmMode.acEditM, Me.myView.ContextRow.CellValue("plnroutingid")) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("plnrouting", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myView, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
                End If
            Case "stdseqproc"
                Dim frm As New frmSeqProc
                myVueSeqProc.ContextRow = myVueSeqProc.mainGrid.ActiveRow
                If Not myVueSeqProc.ContextRow Is Nothing Then
                    If frm.PrepForm(Me.myVueSeqProc, EnumfrmMode.acEditM, Me.myVueSeqProc.ContextRow.CellValue("plnstdseqprocid")) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("seqproc", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myVueSeqProc, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If

                End If
            Case "inctype"
                Dim f As New frmIncType
                f.fMat = Me
                myVueIncType.ContextRow = myVueIncType.mainGrid.ActiveRow
                If Not myVueIncType.ContextRow Is Nothing Then
                    If f.PrepForm(Me.myVueIncType, EnumfrmMode.acEditM, "") Then f.ShowDialog()
                End If
            Case "typeincen"
                Dim frm As New frmPlnProcTypeIncen
                myVueProcType.ContextRow = myVueProcType.mainGrid.ActiveRow
                If Not myVueProcType.ContextRow Is Nothing Then
                    If frm.PrepForm(Me.myVueProcType, EnumfrmMode.acEditM, Me.myVueProcType.ContextRow.CellValue("plnproctypeincenid")) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("typeincen", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myVueProcType, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim str1 As String = "<PARAMS plnprocid=""" & frmIDX & """/>"
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "routing"
                    Dim frm As New frmRouting
                    If frm.PrepForm(Me.myView, EnumfrmMode.acAddM, "", str1) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("plnrouting", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myView, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
                Case "shop"
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@plnProcid", frmIDX, GetType(Integer), False))
                    Dim rr() As DataRow = Me.AdvancedSelect("shops", Params)
                    If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                        For Each r1 As DataRow In rr
                            Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueShop.mainGrid.myDS.Tables(0))
                            r2("plnProcid") = frmIDX
                        Next
                    End If
                Case "stdseqproc"
                    Dim frm As New frmSeqProc
                    If frm.PrepForm(Me.myVueSeqProc, EnumfrmMode.acAddM, "", str1) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("seqproc", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myVueSeqProc, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
                Case "inctype"
                    If Me.frmMode = EnumfrmMode.acEditM Then
                        Dim f As New frmIncType
                        f.fMat = Me
                        If f.PrepForm(myVueIncType, EnumfrmMode.acAddM, "", "") Then f.ShowDialog()
                    Else
                        MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
                    End If
                Case "typeincen"
                    Dim frm As New frmPlnProcTypeIncen
                    If frm.PrepForm(Me.myVueProcType, EnumfrmMode.acAddM, "", str1) Then
                        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Dim oRet As clsProcOutput = Me.GenerateIDOutput("typeincen", frmIDX)
                            If oRet.Success Then
                                Me.UpdateViewData(myVueProcType, oRet)
                            Else
                                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    End If
            End Select
        Else
            MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If Me.SaveModel() Then
                fa.VSave()
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function
End Class

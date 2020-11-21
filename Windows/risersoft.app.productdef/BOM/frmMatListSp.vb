Imports  Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxform
Public Class frmMatListSp
    Inherits frmMax
    Dim myViewHead As New clsWinView, oSort As clsWinSort
    Dim dtOldHead As DataTable

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myViewHead.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        oSort = New clsWinSort(myView, Me.btnMoveUp, Me.btnMoveDown, Me.btnRenumber, "sortindex")
    End Sub

    Private Sub UpdateOldNum()
        Dim oret As clsProcOutput = Me.GenerateIDOutput("sparename", myUtils.cValTN(frmIDX))
        If oret.Success Then
            Dim dt As DataTable = oret.Data.Tables(0)
            Me.LabelOldNum.Text = myWinData.SelectDistinct(dt, "ItemVMSId").Select.Length
            dtOldHead = myWinData.SelectDistinct(dt, "SpareName", True)
        Else
            MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMatListSpModel = Me.InitData("frmMatListSpModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                Me.Text = "Spare Material List for " & myUtils.cStrTN(myRow("PidInfo"))
                oSort.reSort()
                Me.UpdateOldNum()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Spares"))
            myViewHead.PrepEdit(Me.Model.GridViews("Heads"))
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
                Me.DoRefresh = True
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click, btnEdit.Click, btnAddHead.Click
        Dim f As frmMax, ref As Boolean = False
        myView.ContextRow = myView.mainGrid.ActiveRow
        myViewHead.ContextRow = myViewHead.mainGrid.ActiveRow
        Select Case LCase(CType(sender, Control).Name)
            Case "btnadditem"
                If Not myViewHead.ContextRow Is Nothing Then
                    f = New frmMat_SpItem
                    If f.PrepForm(myViewHead, EnumfrmMode.acAddM, "", "<PARAMS PIDUNITID=""" & frmIDX & """ SOSPAREID=""" & myViewHead.ContextRow.CellValue("SOSPAREid") & """/>") Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
            Case "btnaddhead"
                If Not myViewHead.ContextRow Is Nothing Then
                    f = New frmMat_SPHead
                    If f.PrepForm(myViewHead, EnumfrmMode.acAddM, "", "<PARAMS PIDUNITID=""" & frmIDX & """ SOSPAREID=""" & myViewHead.ContextRow.CellValue("SOSPAREid") & """/>") Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
            Case "btnedit"
                If Not myView.ContextRow Is Nothing Then
                    If myUtils.cValTN(myView.ContextRow.CellValue("matheadid")) > 0 Then
                        f = New frmMat_SPHead
                    Else
                        f = New frmMat_SpItem
                    End If
                    If f.PrepForm(myViewHead, EnumfrmMode.acEditM, myView.ContextRow.CellValue("matlistspareid")) Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
        End Select

        If ref Then
            Dim oRet As clsProcOutput = Me.GenerateIDOutput("head", frmIDX)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
            oRet = Me.GenerateIDOutput("spare", frmIDX)
            If oRet.Success Then
                Me.UpdateViewData(myViewHead, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
            Me.UpdateOldNum()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim oRet As clsProcOutput = Me.GenerateIDOutput("delete", myUtils.cValTN(myView.ContextRow.CellValue("matlistspareid")))
                If oRet.Success Then
                    oRet = Me.GenerateIDOutput("head", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                    oRet = Me.GenerateIDOutput("spare", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myViewHead, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
                Me.UpdateOldNum()
            End If
        End If
    End Sub

    Private Sub LabelOldNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOldNum.Click
        If Not Me.dtOldHead Is Nothing Then
            Dim f As New frmGrid
            f.myView.mainGrid.BindView(myUtils.MakeDSfromTable(dtOldHead, False))
            f.myView.mainGrid.QuickConf("", True, , , "Heads with Old Versions")
            f.ShowDialog()
        End If
    End Sub
End Class
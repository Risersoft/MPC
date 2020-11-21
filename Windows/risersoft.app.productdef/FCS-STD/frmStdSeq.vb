Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmStdSeq
    Inherits frmMax
    Dim fParamQual As frmDesParamQual, dicMat As clsCollecString(Of Boolean)

    Public Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridSequenceProc)
        dicMat = myWinApp.objAppExtender.dicMat

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmStdSeqModel = Me.InitData("frmStdSeqModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            If myUtils.cBoolTN(dicMat("des")) Then

                fParamQual = New frmDesParamQual
                If fParamQual.PrepFormRow(Me) Then
                    fParamQual.AddtoTab(Me.UltraTabControl1, "paramqual", True)
                Else
                    fParamQual = Nothing
                    Me.UltraTabControl1.Tabs("paramqual").Visible = False
                End If

            Else
                Me.UltraTabControl1.Tabs("paramqual").Visible = False
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("SequenceProc"))

            Return True
        End If
        Return False
    End Function

    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditOp.Click
        If Not Me.myView.mainGrid.myGrid.ActiveRow Is Nothing Then
            Dim frm As New frmSeqSeqProc
            If frm.PrepForm(Me.myView, EnumfrmMode.acEditM, Me.myView.mainGrid.myGrid.ActiveRow.Cells("plnStdSeqSeqProcID").Value) Then
                If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@plnStdSeqid", myUtils.cValTN(frmIDX), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("refresh", Params)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOp.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim f As New frmSeqSeqProc
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS plnStdSeqID=""" & frmIDX & """/>") Then
                If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@plnStdSeqID", myUtils.cValTN(frmIDX), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("refresh", Params)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        Else
            MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If (fParamQual IsNot Nothing) AndAlso (Not fParamQual.ValidateData) Then WinFormUtils.AddError(fParamQual, "Qualifying Parameters Errors")
            If Me.SaveModel() Then
                If (Not fParamQual Is Nothing) Then fParamQual.VSave()
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub btnDelOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelOp.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Sequence Process", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@plnStdSeqID", myUtils.cValTN(frmIDX), GetType(Integer), False))
                Params.Add(New clsSQLParam("@plnstdseqseqprocid", myUtils.cValTN(myView.ContextRow.CellValue("plnstdseqseqprocid")), GetType(Integer), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delete", Params)
                If oRet.Success Then
                    Me.UpdateViewData(myView, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub
End Class
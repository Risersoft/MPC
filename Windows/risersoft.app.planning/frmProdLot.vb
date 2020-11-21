Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Imports Infragistics.Win.UltraWinSchedule

Public Class frmProdLot
    Inherits frmMax
    Dim myViewOp, myViewProdSerial As New clsWinView
    Dim fMat As frmProdLotMat

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(UltraGrid1)
        myView.SetGantt(Me.UltraGanttView1)
        myViewProdSerial.SetGrid(Me.UltraGrid2)
        myViewOp.SetGrid(Me.UltraGrid3)
        fMat = New frmProdLotMat
        fMat.AddtoTab(Me.UltraTabControl1, "mat", True)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotModel = Me.InitData("frmProdLotModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.Text = Me.GenerateDataOutput("text", Nothing, myUtils.cValTN(myRow("PidUnitId"))).Description

            Me.UltraTabControl1.Tabs("mat").Visible = (frmMode = EnumfrmMode.acEditM)
            If frmMode = EnumfrmMode.acEditM Then
                fMat.PrepForm(pView, frmMode, frmIDX)
                Me.CreateProject()
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Route"))
            myViewOp.PrepEdit(Me.Model.GridViews("OP"))
            myViewProdSerial.PrepEdit(Me.Model.GridViews("Serial"), Me.btnAddTF, Me.btnDelTF)
            Return True
        End If
        Return False
    End Function

    Private Sub CreateProject()

        Dim conf As New clsGanttConf With {.StartTimeField = "startdate", .FinishTimeField = "finishdate", .IsCompletedField = "iscompleted"}
        conf.Levels.Add(New clsGanttConfLevel With {.IDField = "prodlotrouteid", .NameField = "seqprocname"})
        Dim model = PanelModelUtils.GenerateGanttModel(conf, Me.Controller, "Lot Routing", myView.mainGrid.myDS)
        GanttUtils.BindModel(Me.UltraGanttView1, model)
    End Sub

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

    Private Sub btnEditRouting_Click(sender As Object, e As EventArgs) Handles btnEditRouting.Click
        Select Case Me.UltraTabControlRouting.SelectedTab.Key.Trim.ToLower
            Case "proc"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmProdLotRoute), "prodlotrouteid", "")
                If Not nr Is Nothing Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("proc", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            Case "op"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myViewOp, "edit", GetType(frmProdLotOp), "prodlotopid", "")
                If Not nr Is Nothing Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("op", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myViewOp, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
        End Select
    End Sub

    Private Sub UltraButton1_Click_1(sender As Object, e As EventArgs) Handles UltraButton1.Click
        If Not myUtils.NullNot(Me.dt_SDate.Value) Then
            For Each r As DataRow In myView.mainGrid.myDS.Tables(0).Select("releasedate is null")
                r("releasedate") = Me.dt_SDate.Value
            Next
        End If
    End Sub
End Class

Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmMatListCost
    Inherits frmMax
    Implements IfWizMax
    Dim fBag As New clsCollection(Of Integer, frmMatList1Tab), oGen As clsMatListGenerator
    Friend matindex As Integer
    Public fTF As frmMax

    Public Sub initForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        matindex = 1

        oGen = New clsMatListGenerator(Me.Controller)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMatListCostModel = Me.InitData("frmMatListCostModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                Me.LoadMatlistTabs()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepFormRow(r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.InitData(r1) Then
            frmIDX = myUtils.cValTN(myRow("PidUnitId"))
            Me.LoadMatlistTabs()
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub LoadMatlistTabs()
        Dim dt1 As DataTable, r As DataRow
        Dim uTab As UltraTab, f As frmMatList1Tab

        Me.UltraTabControl1.Tabs.Clear()
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
   
        dt1 = Me.Model.DatasetCollection("matheadtype").Tables(0)
        For Each r In dt1.Rows
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(myRow("PIDUnitID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@headtypeid", myUtils.cValTN(r("HeadTypeId")), GetType(Integer), False))
            Dim oRet As clsProcOutput = Me.GenerateParamsOutput("mathead", Params)
            Dim Model As clsViewModel = Me.GenerateParamsModel("matlist", Params)
            If oRet.Success Then
                f = New frmMatList1Tab
                f.fMat = Me
                fBag.Add(r("HeadTypeId"), f)

                f.myView.PrepEdit(Model)

                f.myHead.mainGrid.MainConf("showrownumber") = True
                f.myHead.mainGrid.MainConf("ColHeaders") = False
                f.myHead.mainGrid.BindView(oRet.Data, , 0)
                f.myHead.mainGrid.QuickConf("", True, "1", True, "Unused Heads")

                uTab = f.AddtoTab(Me.UltraTabControl1, r("HeadTypeId"), True)
                uTab.Text = Replace(r("HeadType"), "&", "&&")
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        Next
    End Sub

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

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, btnEdit.Click
        Dim f As New frmMat_Cost, ref As Boolean = False
        Dim fTab As frmMatList1Tab

        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)
        fTab.myView.ContextRow = fTab.myView.mainGrid.ActiveRow
        fTab.myHead.ContextRow = fTab.myHead.mainGrid.ActiveRow
        Select Case LCase(CType(sender, Control).Name)
            Case "btnadd"
                If Not fTab.myHead.ContextRow Is Nothing Then
                    If f.PrepForm(fTab.myHead, EnumfrmMode.acAddM, "", "<PARAMS PIDUNITID=""" & frmIDX & """ MATHEADID=""" & fTab.myHead.ContextRow.CellValue("MatHeadId").Value & """/>") Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
            Case "btnedit"
                If Not fTab.myView.ContextRow Is Nothing Then
                    If f.PrepForm(fTab.myHead, EnumfrmMode.acEditM, fTab.myView.ContextRow.CellValue("MatListCostId")) Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
        End Select

        If ref Then
            RefreshFTabView(myUtils.cValTN(c), fTab.myView, fTab.myHead)
        End If
    End Sub

    Private Sub RefreshFTabView(HeadTypeID As Integer, fTabMyView As clsWinView, fTabMyHead As clsWinView)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params.Add(New clsSQLParam("@headtypeid", myUtils.cValTN(HeadTypeID), GetType(Integer), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("mathead", Params)
        Dim Model As clsViewModel = Me.GenerateParamsModel("matlist", Params)
        If oRet.Success Then
            fTabMyView.PrepEdit(Model)
            Me.UpdateViewData(fTabMyHead, oRet)
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key)), fTab As frmMatList1Tab
        fTab = fBag(c)
        fTab.myView.ContextRow = fTab.myView.mainGrid.ActiveRow
        If Not fTab.myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim oret As clsProcOutput = Me.GenerateIDOutput("delete", myUtils.cValTN(fTab.myView.ContextRow.CellValue("matlistcostid")))
                If oret.Success Then
                    RefreshFTabView(myUtils.cValTN(c), fTab.myView, fTab.myHead)
                Else
                    MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Dim fTab As frmMatList1Tab
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)
        If Not fTab Is Nothing Then fTab.myView.mainGrid.Genwidth()
    End Sub

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return True
    End Function

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        Dim cont As Boolean = False
        If Me.FormPrepared Then
            cont = True
        Else
            cont = Me.PrepFormRow(fTF.myRow.Row)
        End If
        Return cont
    End Function

    Public Overrides Sub MakeDownLevel()
        Me.Panel1.Visible = False
        Me.Panel4.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        oGen.MakeCostMatList(myRow("PidUnitId"))
        For Each fTab In fBag.Values
            Dim c As Integer = CInt(myUtils.cValTN(fTab.uTab.Key))
            RefreshFTabView(c, fTab.myView, fTab.myHead)
        Next
    End Sub

    Public Function btnActionText() As String Implements IfWizMax.btnActionText
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput
    End Sub

    Public Function ShowTabKeys() As ArrayList Implements IfWizMax.ShowTabKeys
    End Function

    Public Sub StartAction() Implements IfWizMax.StartAction
    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction
    End Sub
End Class
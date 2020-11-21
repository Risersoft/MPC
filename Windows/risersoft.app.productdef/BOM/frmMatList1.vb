Imports  Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.Xml
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmMatList1
    Inherits frmMax
    Implements IfWizMax
    Dim fBag As New clsConf, dtOldHead As DataTable
    Friend matindex As Integer
    Public fTF As frmMax

    Public Sub initForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        matindex = 1

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim myXML As New XmlDocument, oAttr As XmlAttribute, oNode As XmlNode
        Me.FormPrepared = False
        Dim objModel As frmMatList1Model = Me.InitData("frmMatList1Model", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                If strXML.Trim.Length > 0 Then
                    oAttr = Nothing
                    myXML.LoadXml(myUtils.ProperXML(strXML))
                    oNode = myXML.SelectSingleNode("/ROOT/FRM/SYS")
                    If Not oNode Is Nothing Then oAttr = oNode.Attributes.GetNamedItem("TAG")
                    If Not oAttr Is Nothing Then matindex = myUtils.cValTN(oAttr.Value)
                End If
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

    Private Sub LoadMatlistTabs()
        Dim sql As String = "", str1 As String = "", r As DataRow
        Dim uTab As UltraTab, f As frmMatList1Tab

        If myRow.Row.Table.Columns.Contains("pidinfo") Then str1 = " for " & myUtils.cStrTN(myRow("PidInfo"))
        If matindex = 2 Then
            Me.Text = "Matlist2" & str1
        Else
            Me.Text = "Matlist1" & str1
        End If

        Me.UltraTabControl1.Tabs.Clear()
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize

        Dim dt As DataTable = Me.Model.DatasetCollection("matheadtype").Tables(0)
        For Each r In dt.Rows
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@matindex", myUtils.cValTN(matindex), GetType(Integer), False))
            Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
            Params.Add(New clsSQLParam("@headtypeid", myUtils.cValTN(r("HeadTypeId")), GetType(Integer), False))
            Dim oRet As clsProcOutput = Me.GenerateParamsOutput("matlistmathead", Params)
            If oRet.Success Then
                f = New frmMatList1Tab
                f.fMat = Me
                f.matindex = Me.matindex
                fBag.Add(r("headtypeid"), f)

                f.myView.mainGrid.MainConf("showrownumber") = True
                f.myView.mainGrid.MainConf("RHFACTOR") = 2 : f.myView.mainGrid.MainConf("HeadFACTOR") = 2.1
                f.myView.mainGrid.BindView(oRet.Data, , 0)
                f.myView.mainGrid.QuickConf("", True, "1-1-2-1-1", True)

                f.myHead.mainGrid.MainConf("showrownumber") = True
                f.myHead.mainGrid.MainConf("ColHeaders") = False
                f.myHead.mainGrid.BindView(oRet.Data, , 1)
                f.myHead.mainGrid.QuickConf("", True, "1", True, "Unused Heads")

                uTab = f.AddtoTab(Me.UltraTabControl1, r("headtypeid"), True)
                uTab.Text = Replace(r("headtype"), "&", "&&")
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        Next
        Me.UpdateOldNum()
    End Sub

    Private Sub UpdateOldNum()
        Dim oret As clsProcOutput = Me.GenerateIDOutput("oldhead", myUtils.cValTN(frmIDX))
        Dim dt As DataTable
        If oret.Success Then
            dt = oret.Data.Tables(0)
        Else
            MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Me.LabelOldNum.Text = myWinData.SelectDistinct(dt, "ItemVMSId").Select.Length
        dtOldHead = myWinData.SelectDistinct(dt, "HeadName", True)
    End Sub

    Public Overloads Function PrepFormRow(oView As clsView, r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.InitData(r1, oView) Then
            Me.Model.Name = "frmMatList1Model"
            Me.Model.DatasetCollection.AddUpd("matheadtype", Me.GenerateIDOutput("matheadtype", 0).Data)
            frmIDX = myUtils.cValTN(myRow("PidUnitId"))
            Me.LoadMatlistTabs()
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
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

    Private Sub RefreshFTabView(HeadTypeID As Integer, fTabMyView As clsWinView, fTabMyHead As clsWinView)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@matindex", myUtils.cValTN(Me.matindex), GetType(Integer), False))
        Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params.Add(New clsSQLParam("@headtypeid", myUtils.cValTN(HeadTypeID), GetType(Integer), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("matlistmathead", Params)
        If oRet.Success Then
            Dim oRet1 As New clsProcOutput
            Dim oRet2 As New clsProcOutput
            oRet1.AddTable("MatList", oRet.Data.Tables("matlist"))
            oRet2.AddTable("MatHead", oRet.Data.Tables("mathead"))

            Me.UpdateViewData(fTabMyView, oRet1)
            Me.UpdateViewData(fTabMyHead, oRet2)
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click, btnEdit.Click
        Dim f As New frmMat, ref As Boolean = False
        Dim fTab As frmMatList1Tab

        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)
        fTab.myView.ContextRow = fTab.myView.mainGrid.ActiveRow
        fTab.myHead.ContextRow = fTab.myHead.mainGrid.ActiveRow
        Select Case LCase(CType(sender, Control).Name)
            Case "btnadd"
                If Not fTab.myHead.ContextRow Is Nothing Then
                    If f.PrepForm(fTab.myHead, EnumfrmMode.acAddM, "", "<PARAMS PIDUNITID=""" & frmIDX & """ MATHEADID=""" & fTab.myHead.ContextRow.CellValue("matheadid") & """ listindex =""" & Me.matindex & """/>") Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
            Case "btnedit"
                If Not fTab.myView.ContextRow Is Nothing Then
                    If f.PrepForm(fTab.myHead, EnumfrmMode.acEditM, fTab.myView.ContextRow.CellValue("matlistid"), "<PARAMS listindex =""" & Me.matindex & """/>") Then If f.ShowDialog(Me.ParentForm) = DialogResult.OK Then ref = True
                End If
        End Select
        If ref Then
            RefreshFTabView(myUtils.cValTN(c), fTab.myView, fTab.myHead)
            Me.UpdateOldNum()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key)), fTab As frmMatList1Tab
        fTab = fBag(c)
        fTab.myView.ContextRow = fTab.myView.mainGrid.ActiveRow
        If Not fTab.myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim oret As clsProcOutput = Me.GenerateIDOutput("delete", myUtils.cValTN(fTab.myView.ContextRow.CellValue("MatListId")))
                If oret.Success Then
                    RefreshFTabView(myUtils.cValTN(c), fTab.myView, fTab.myHead)
                Else
                    MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
                Me.UpdateOldNum()
            End If
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim RefPidUnitId As Integer, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim str1 As String, r1 As DataRow
        Dim fTab As frmMatList1Tab, oView As clsWinView

        gRow = pView.mainGrid.myGrid.ActiveRow
        If (Not gRow Is Nothing) AndAlso (gRow.Band.Columns.Exists("PidUnitId")) Then
            RefPidUnitId = gRow.Cells("PidUnitId").Value
            If frmIDX = RefPidUnitId Then
                MsgBox("Please select a different work order", MsgBoxStyle.OkOnly, myWinApp.Vars("appname"))
            Else
                Dim f As New frmMatList1Copy
                f.matindex = Me.matindex
                If f.PrepForm(myView, EnumfrmMode.acEditM, RefPidUnitId) Then
                    If f.ShowDialog(Me) = DialogResult.OK Then
                        str1 = ""
                        For Each de In Me.fBag
                            fTab = CType(de.Value, frmMatList1Tab)
                            oView = CType(f.fBag(de.Key), frmMatList1Tab).myView
                            For Each r1 In oView.mainGrid.myDS.Tables(0).Select("sysincl=1")
                                gRow = win.myWinUtils.FindRow(fTab.myView.mainGrid.myGrid, "MatHeadId", myUtils.cValTN(r1("MatHeadId")))
                                If gRow Is Nothing Then str1 = str1 & IIf(str1 = "", "", ",") & r1("MatHeadId")
                            Next
                        Next

                        Dim Params As New List(Of clsSQLParam)
                        Params.Add(New clsSQLParam("@matheadidcsv", IIf(str1.Trim = "", "0", str1), GetType(Integer), True))
                        Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
                        Params.Add(New clsSQLParam("@refpidunitid", myUtils.cValTN(RefPidUnitId), GetType(Integer), False))
                        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("btncopy", Params)
                        If oRet.Success Then
                            For Each de In Me.fBag
                                fTab = CType(de.Value, frmMatList1Tab)
                                Dim c As Integer = CInt(myUtils.cValTN(fTab.uTab.Key))
                                RefreshFTabView(c, fTab.myView, fTab.myHead)
                            Next
                            Me.UpdateOldNum()
                        End If
                    End If
                End If
                f.Dispose()
                f = Nothing
            End If
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Dim fTab As frmMatList1Tab
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)
        If Not fTab Is Nothing Then fTab.myView.mainGrid.Genwidth()
    End Sub

    Private Sub LabelOldNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelOldNum.Click
        If Not Me.dtOldHead Is Nothing Then
            Dim f As New frmGrid
            f.myView.mainGrid.BindView(myUtils.MakeDSfromTable(dtOldHead, False))
            f.myView.mainGrid.QuickConf("", True, , , "Heads with Old Versions")
            f.ShowDialog()
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
        Dim cont As Boolean = False
        If Me.FormPrepared Then
            cont = True
        Else
            cont = Me.PrepFormRow(fTF.pView, fTF.myRow.Row)
        End If
        Return cont
    End Function

    Public Function ShowTabKeys() As ArrayList Implements IfWizMax.ShowTabKeys
    End Function

    Public Sub StartAction() Implements IfWizMax.StartAction
    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction
    End Sub

    Public Overrides Sub MakeDownLevel()
        Me.Panel1.Visible = False
        Me.Panel4.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        Dim oWO As clsWOInfo = myPIDU.GenerateWOInfo(Me.Controller, myRow("PidUnitId"))
        Dim oGen = oWO.CreateGenerator()
        oGen.MakeMatList1(oWO, c)
        Dim fTab As frmMatList1Tab = fBag(c)
        RefreshFTabView(c, fTab.myView, fTab.myHead)
        Me.UpdateOldNum()
    End Sub
End Class
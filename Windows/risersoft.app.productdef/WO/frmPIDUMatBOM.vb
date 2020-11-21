Imports Infragistics.Win.UltraWinTree
Imports risersoft.app.mxent
Imports Infragistics.Win.Misc
Imports risersoft.app.mxform

Public Class frmPIDUMatBOM
    Inherits frmMax
    Implements IfWizMax
    Dim dvMat1, dvAlt1, dvMat2, dvAlt2 As DataView, matbompending As Boolean = True, myBOM As New clsBOMGeneratorBase(Me.Controller)
    Dim myVueItemBOM As New clsWinView, myVueAltBOM1, myVueAltBOM2 As New clsWinView
    Public fTF As frmMax

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridBOM)
        myVueAltBOM1.SetGrid(Me.UltraGridAltBOM1)
        myVueItemBOM.SetGrid(Me.UltraGridItemBOM)
        myVueAltBOM2.SetGrid(Me.UltraGridAltBOM2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepFormRow(oView As clsView, r As DataRow, prepIDX As String) As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDUMatBOMModel = Me.InitData("frmPIDUMatBOMModel", oView, EnumfrmMode.acEditM, prepIDX, "")
        If Me.BindModel(objModel, oView) Then
            If Me.InitData(r) Then
                frmIDX = prepIDX
                Me.LoadProcessBOMTree()

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

    Private Function BOMDataSet(ProcessBOM As Boolean) As DataSet
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(myRow("pidunitid")), GetType(Integer), False))
        If ProcessBOM AndAlso myRow.Row.Table.Columns.Contains("plnpidurouteid") Then Params.Add(New clsSQLParam("@plnpidurouteid", myUtils.cValTN(myRow("plnpidurouteid")), GetType(Integer), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("matalt", Params)
        Return oRet.Data
    End Function

    Friend Sub LoadProcessBOMTree()
        If myRow.Row.Table.Columns.Contains("plnpidurouteid") Then
            Me.PanelButtons.Visible = True
            Me.UltraTabControl1.Tabs("matbom").Visible = False
        Else
            Me.PanelButtons.Visible = False
            Me.UltraTabControl1.Tabs("matbom").Visible = True
        End If

        Dim ds As DataSet = Me.BOMDataSet(True)
        Dim dtTree As DataTable = myBOM.SetBOMChildFilter(ds.Tables(0).Copy)
        Dim dvList As List(Of DataView) = Me.LoadTree(myView, myVueAltBOM1, Me.UltraTree1, ds.Tables(0), dtTree, ds.Tables(1))
        dvMat1 = dvList(0)
        dvAlt1 = dvList(1)

        matbompending = True
    End Sub

    Friend Sub LoadItemVMSBOMTree()
        Dim oret As clsProcOutput = Me.GenerateIDOutput("itemvmsbom", myUtils.cValTN(fTF.myRow("pidunitid")))
        If oret.Success Then
            Dim dtGrid As DataTable = oret.Data.Tables(0)
            Dim dtTree As DataTable = myBOM.SetBOMChildFilter(dtGrid.Copy)
            Dim ds As DataSet = Me.BOMDataSet(False)

            Dim dvList As List(Of DataView) = Me.LoadTree(myVueItemBOM, myVueAltBOM2, Me.UltraTree2, dtGrid, dtTree, ds.Tables(1))
            dvMat2 = dvList(0)
            dvAlt2 = dvList(1)

            matbompending = False
        Else
            MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Friend Function LoadTree(oViewMat As clsWinView, oViewMatAlt As clsWinView, oTree As UltraTree, dt1 As DataTable, dt2 As DataTable, dt3 As DataTable) As List(Of DataView)
        Dim ViewList As New List(Of DataView)

        WinTreeUtils.BuildBOMTree(oTree, "childbomids,itemvmsid,plnstdseqprocid,pidumatbomid,pidunitid,Index,ItemCode,Spec,Descrip,Qty,UOM", "0-0-0-0-0-2-3-1-6-1-1")

        oViewMat.mainGrid.MainConf("showrownumber") = True
        ViewList.Add(oViewMat.mainGrid.BindView(dt1.DataSet, , 0))
        oViewMat.mainGrid.QuickConf("", True, "2-2-1-2-1-1-1", , "BOM")

        oViewMatAlt.mainGrid.MainConf("showrownumber") = True
        ViewList.Add(oViewMatAlt.mainGrid.BindView(dt3.DataSet, , 1))
        oViewMatAlt.mainGrid.QuickConf("", True, "1-3-1", , "Alternates")

        WinTreeUtils.MakeTree(oTree.Nodes, Nothing, dt2, "pidumatbomid", "Descrip", "parentbomid", "sortindex,itemcode desc", New WinTreeUtils.dSetNodeProps(AddressOf SetProcessTreeNodeProp), Nothing)
        WinTreeUtils.ExpandNodes(oTree, 3)
        If oTree.Nodes.Count > 0 Then oTree.ActiveNode = oTree.Nodes(0)

        Return ViewList
    End Function

    Private Sub SetNodeColumns(xNode As UltraTreeNode, rNode As DataRow)
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("qty"), Format(myUtils.cValTN(rNode("qty")), "0.####"))
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("uom"), rNode("unitname"))
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("spec"), rNode("specwrite"))
        If myUtils.NullNot(rNode("ITEMVMSID")) Then xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("Index"), rNode("sortindex"))
    End Sub

    Private Sub SetProcessTreeNodeProp(xNode As UltraTreeNode, rNode As DataRow)
        Me.SetNodeColumns(xNode, rNode)
        If myUtils.NullNot(rNode("itemvmsid")) Then
            'process
            xNode.Override.NodeAppearance.BackColor = Color.Aqua
        Else
            'Material
            xNode.Override.NodeAppearance.BackColor = Color.LightGray
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        cm.EndCurrentEdit()
        Me.LoadProcessBOMTree()
        If Me.SaveModel() Then
            Return True
        End If
        Me.Refresh()
    End Function

    Private Sub btn_reLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reLoad.Click
        myWinApp.objAppExtender.MakeBOM(Me.Controller, frmIDX)
        Me.LoadProcessBOMTree()

    End Sub

    Private Sub frmMatPos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.UltraTree1.Width = Me.Width / 2
        Me.UltraTree2.Width = Me.Width / 2
    End Sub

    Private Sub UltraTree1_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles UltraTree1.AfterSelect
        Me.HandleTreeSelection(Me.UltraTree1, Me.UltraLabel1, dvMat1, dvAlt1)
    End Sub

    Private Sub UltraTree2_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles UltraTree2.AfterSelect
        Me.HandleTreeSelection(Me.UltraTree2, Me.UltraLabel2, dvMat2, dvAlt2)
    End Sub

    Private Sub HandleTreeSelection(oTree As UltraTree, oLabel As UltraLabel, dvMat As DataView, dvAlt As DataView)
        Dim str1 As String, oNode As UltraTreeNode

        If oTree.SelectedNodes.Count = 0 Then oNode = oTree.Nodes(0) Else oNode = oTree.SelectedNodes(0)
        oLabel.Text = Me.NodeAddress(oNode)
        str1 = myUtils.cStrTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("childbomids")))
        If str1.Trim.Length = 0 Then str1 = "0"
        dvMat.RowFilter = "pidumatbomid in (" & str1 & ")"

        str1 = myUtils.cStrTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("itemvmsid")))
        If str1.Trim.Length = 0 Then str1 = "0"
        dvAlt.RowFilter = "itemvmsid in (" & str1 & ")"

    End Sub

    Public Function NodeAddress(ByVal oNode As UltraTreeNode, Optional ByVal includeRoot As Boolean = True) As String
        Dim str1 As String

        While Not oNode Is Nothing
            If (Not includeRoot) AndAlso (oNode.Parent Is Nothing) Then Exit While
            str1 = myUtils.cStrTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("Descrip"))) & IIf(str1 = "", "", " > " & vbCrLf) & str1
            oNode = oNode.Parent
        End While
        Return str1
    End Function

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
            Me.LoadProcessBOMTree()
            cont = True
        Else
            cont = Me.PrepFormRow(fTF.myView, fTF.myRow.Row, fTF.myRow("pidunitid"))
        End If
        Return cont
    End Function

    Public Function ShowTabKeys() As ArrayList Implements IfWizMax.ShowTabKeys

    End Function

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        Dim rRoot As DataRow = myView.mainGrid.myDv.Table.Select("parentbomid is null")(0)
        Dim strXML As String = "<PARAMS PARENTBOMID=""" & rRoot("pidumatbomid") & """ PRODBYPIDUROUTEID=""" & myRow("plnpidurouteid") & """/>"
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmPIDUMat), "pidumatbomid", "", strXML)

    End Sub

    Private Sub btnAddAlt_Click(sender As Object, e As EventArgs) Handles btnAddAlt.Click
        Dim oNode As UltraTreeNode
        If Me.UltraTree1.SelectedNodes.Count = 0 Then oNode = Me.UltraTree1.Nodes(0) Else oNode = Me.UltraTree1.SelectedNodes(0)
        Dim itemvmsid As Integer = myUtils.cValTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("itemvmsid")))
        Dim strXML As String = "<PARAMS itemvmsid=""" & itemvmsid & """ pidunitid=""" & myRow("pidunitid") & """/>"
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueAltBOM1, "add", GetType(frmPIDUMatBOMAlt), "frmPIDUMatBOMAltid", "", strXML)
        If Not nr Is Nothing Then
            Me.LoadProcessBOMTree()
            Me.HandleTreeSelection(Me.UltraTree1, Me.UltraLabel1, dvMat1, dvAlt1)
        End If
    End Sub

    Private Sub btnDelAlt_Click(seidnder As Object, e As EventArgs) Handles btnDelAlt.Click
        myVueAltBOM1.ContextRow = myVueAltBOM1.mainGrid.ActiveRow
        If Not myVueAltBOM1.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Alternate Process", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
                Params.Add(New clsSQLParam("@PIDUMatBOMAltid", myUtils.cValTN(myVueAltBOM1.ContextRow.CellValue("PIDUMatBOMAltid")), GetType(Integer), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delete", Params)
                If oRet.Success Then
                    LoadProcessBOMTree()
                    Me.HandleTreeSelection(Me.UltraTree1, Me.UltraLabel1, dvMat1, dvAlt1)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btnAddAlt2_Click(sender As Object, e As EventArgs) Handles btnAddAlt2.Click
        Dim oNode As UltraTreeNode
        If Me.UltraTree2.SelectedNodes.Count = 0 Then oNode = Me.UltraTree2.Nodes(0) Else oNode = Me.UltraTree2.SelectedNodes(0)
        Dim itemvmsid As Integer = myUtils.cValTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("itemvmsid")))
        Dim strXML As String = "<PARAMS itemvmsid=""" & itemvmsid & """ pidunitid=""" & myRow("pidunitid") & """/>"
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueAltBOM2, "add", GetType(frmPIDUMatBOMAlt), "frmPIDUMatBOMAltid", "", strXML)

        If Not nr Is Nothing Then
            Me.LoadItemVMSBOMTree()
            Me.HandleTreeSelection(Me.UltraTree2, Me.UltraLabel2, dvMat2, dvAlt2)
        End If
    End Sub

    Private Sub btnDelAlt2_Click(sender As Object, e As EventArgs) Handles btnDelAlt2.Click
        myVueAltBOM2.ContextRow = myVueAltBOM2.mainGrid.ActiveRow
        If Not myVueAltBOM2.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this Alternate Process", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
                Params.Add(New clsSQLParam("@PIDUMatBOMAltid", myUtils.cValTN(myVueAltBOM2.ContextRow.CellValue("PIDUMatBOMAltid")), GetType(Integer), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delete", Params)
                If oRet.Success Then
                    Me.LoadItemVMSBOMTree()
                    Me.HandleTreeSelection(Me.UltraTree2, Me.UltraLabel2, dvMat2, dvAlt2)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Public Sub StartAction() Implements IfWizMax.StartAction

    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction

    End Sub

    Public Overrides Sub MakeDownLevel()
        Me.Panel4.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        If e.Tab.Key.Trim.ToLower = "matbom" AndAlso matbompending Then
            Me.LoadItemVMSBOMTree()
        End If
    End Sub

    Private Sub btn_AddConsBom_Click(sender As Object, e As EventArgs) Handles btn_AddConsBom.Click
        Dim rRoot As DataRow = myView.mainGrid.myDv.Table.Select("parentbomid is null")(0)
        Dim strXML As String = "<PARAMS PARENTBOMID=""" & rRoot("pidumatbomid") & """ CONSBYPIDUROUTEID=""" & myRow("plnpidurouteid") & """/>"
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmPIDUMat), "pidumatbomid", "", strXML)

    End Sub

    Private Sub btn_DelBom_Click(sender As Object, e As EventArgs) Handles btn_DelBom.Click

    End Sub

    Private Sub btn_EditBom_Click(sender As Object, e As EventArgs) Handles btn_EditBom.Click
        Dim rBOM As DataRow = myUtils.DataRowFromGridRow(myView.mainGrid.ActiveRow)
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmPIDUMat), "pidumatbomid", rBOM("pidumatbomid"), "")

    End Sub
End Class
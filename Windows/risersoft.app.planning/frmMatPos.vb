Imports Infragistics.Win.UltraWinTree
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmMatPos
    Inherits frmMax
    Dim myBOM As New clsBOMGeneratorBase(Me.Controller)
    Dim myVueItems As New clsWinView

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        myVueItems.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        'TODO: Handle Alternate materials in MRP
        Me.UltraTabControl2.Tabs(1).Visible = False
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMatPosModel = Me.InitData("frmMatPosModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Supp"))

            Dim dt2 As DataTable
            WinTreeUtils.BuildBOMTree(UltraTree1, "childbomids,prodlotrouteid,prodlotbomid,prodlotid,Index,SeqProcName,ItemCode,Ver,ItemName,QtyReqBOM,QtyReqMRP,UOM,DateReq", "0-0-0-0-4-2-3-1-6-1-1-1-1")

            dt2 = myBOM.SetChildFilter(Me.dsForm.Tables("ProdLotBOM").Copy, Nothing, "childbomids", "parentlotbomid", "prodlotbomid")
            myUtils.DeleteRows(dt2.Select(myUtils.CombineWhere(False, "matpc='c'", "isnull(isleafnode,0)=1")))
            WinTreeUtils.MakeTree(UltraTree1.Nodes, Nothing, dt2, "prodlotbomid", "ItemName", "parentlotbomid", "itemcode desc", New WinTreeUtils.dSetNodeProps(AddressOf SetNodeProp), Nothing)
            WinTreeUtils.ExpandNodes(UltraTree1, 3)
            Me.UltraTree1_AfterSelect(Nothing, Nothing)

            Return True
        End If
        Return False
    End Function

    Private Sub SetNodeProp(xNode As UltraTreeNode, rNode As DataRow)
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("uom"), rNode("unitname"))
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("ver"), rNode("specwrite"))
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        If Me.CanSave() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btn_reLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objModel As frmMatPosModel = Me.InitData("frmMatPosModel", pView, frmMode, frmIDX, "")
        Me.BindModel(objModel, Me.pView)
    End Sub

    Private Sub frmMatPos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.UltraTree1.Width = Me.Width / 2
    End Sub

    Private Sub UltraTree1_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles UltraTree1.AfterSelect
        Dim str1 As String = "0", oNode As UltraTreeNode = Nothing

        If Me.UltraTree1.SelectedNodes.Count > 0 Then oNode = Me.UltraTree1.SelectedNodes(0)
        If oNode Is Nothing AndAlso Me.UltraTree1.Nodes.Count > 0 Then oNode = Me.UltraTree1.Nodes(0)
        If Not oNode Is Nothing Then str1 = myUtils.cStrTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("childbomids")))
        Me.UltraLabel1.Text = Me.NodeAddress(oNode)
        myView.mainGrid.myDv.RowFilter = "prodlotbomid in (" & str1 & ")"
        myView.mainGrid.ExpandFirstRow()
    End Sub

    Public Function NodeAddress(ByVal oNode As UltraTreeNode, Optional ByVal includeRoot As Boolean = True) As String
        Dim str1 As String = ""

        While Not oNode Is Nothing
            If (Not includeRoot) AndAlso (oNode.Parent Is Nothing) Then Exit While
            str1 = myUtils.cStrTN(oNode.GetCellValue(oNode.DataColumnSetResolved.Columns("itemname"))) & IIf(str1 = "", "", " > " & vbCrLf) & str1
            oNode = oNode.Parent
        End While
        Return str1
    End Function

    Public Overrides Sub MakeDownLevel()
        Me.Panel4.Visible = False
        MyBase.MakeDownLevel()
    End Sub
End Class
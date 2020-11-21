Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.Extensions
Imports risersoft.shared.portable

Public Class frmMatSelect
    Inherits frmMax
    Friend myViewItems As New clsWinView
    Dim selType As Integer
    Friend ds As DataSet

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myViewItems.SetGrid(Me.UltraGridItems)
        myView.SetGrid(Me.UltraGridItemVMS)

        WinFormUtils.SetButtonConf(Nothing, Me.btnCancel)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myWinSQL.AssignCmb(NewModel.dsCombo, "Heads", "", Me.cmb_MatHeadID)
        cmb_Show.ValueList = NewModel.ValueLists("Show").ComboList
        Return True
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.InitData("", "", oView, prepMode, prepIDX, strXML, "")
        Dim MatHeadID = myUtils.cValTN(Me.vBag("MatHeadID"))
        If MatHeadID > 0 Then
            If Me.BindModel(Me.pView.fParent.Model) Then
                cmb_Show.Value = 1
                Me.cmb_MatHeadID.Value = MatHeadID
                selType = myUtils.cValTN(Me.cmb_MatHeadID.SelectedRow.Cells("selectiontype").Value)
                If selType = 0 Then selType = 1

                myView.myMode = EnumViewMode.acSelectM : myView.MultiSelect = (selType <> 2)
                myView.mainGrid.BindView(ds, , 0)
                If selType = 3 Then
                    myView.mainGrid.MainConf("rhfactor") = 2
                    myView.mainGrid.QuickConf("", True, "1-3-1-1-1-2-2-2", True)
                Else
                    myView.mainGrid.MainConf("rhfactor") = 1
                    myView.mainGrid.QuickConf("", True, "1-1-1-2-2-2", True)
                End If

                myViewItems.mainGrid.BindView(myFuncsBase.AttributedItemsTable(Me.Controller, ds.Tables(1), Nothing), , 0)
                myViewItems.mainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(Me.Controller, myViewItems.mainGrid.myDv.Table.DataSet.Tables("attrib"))
                myViewItems.mainGrid.QuickConf("", True, "1-1-1-1", True)
                myViewItems.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterUIType = FilterUIType.FilterRow
                myViewItems.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterEvaluationTrigger = FilterEvaluationTrigger.OnCellValueChange
                myViewItems.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterRowPrompt = "     Click Here to Filter Data"

                ItemGridFormat(myUtils.cValTN(Me.vBag("SubCatID")))
                chkOldSpec.Checked = True
                HandleShow()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Private Sub cmb_Show_Leave(sender As Object, e As EventArgs) Handles cmb_Show.Leave, cmb_Show.AfterCloseUp
        HandleShow()
    End Sub

    Private Sub HandleShow()
        If myUtils.cValTN(cmb_Show.Value) = 1 Then
            Dim str As String = myUtils.MakeCSV(Me.myView.mainGrid.myDv.Table.Select, "ItemID")
            myViewItems.mainGrid.myDv.RowFilter = "ItemID in (" & str & ")"
        Else
            myViewItems.mainGrid.myDv.RowFilter = ""
        End If
    End Sub

    Private Sub UltraGridItems_AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridItems.AfterRowActivate
        myViewItems.ContextRow = myViewItems.mainGrid.ActiveRow
        If Not myViewItems.ContextRow Is Nothing Then
            ApplyVMSFilter(Me.chkOldSpec.Checked)
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Not IsNothing(myView.mainGrid.myGrid.ActiveRow) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
        Me.Close()
    End Sub

    Private Sub UltraGridItems_BeforeRowDeactivate(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UltraGridItems.BeforeRowDeactivate
        If selType <> 2 Then
            If myView.mainGrid.myDv.Table.Select("SysIncl = 1").Length > 0 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ItemGridFormat(SubCatID As Integer)
        Dim str1 As String = ""
        If SubCatID > 0 Then
            myViewItems.mainGrid.myDv.RowFilter = "SubCatId=" & myUtils.cValTN(SubCatID)
            myViewItems.mainGrid.myDv.Sort = "ItemCode"
            If Me.UltraGridItems.Rows.Count > 0 Then
                Me.UltraGridItems.ActiveRow = Me.UltraGridItems.GetRow(ChildRow.First)
                Me.UltraGridItems.ActiveRow.Selected = True
            End If
            str1 = myAttribBase.ParamWidthString(Me.Controller, myViewItems.mainGrid.myDv.Table.DataSet.Tables("attrib"), "SubCatId", SubCatID)
            myViewItems.mainGrid.QuickConf("", True, "1-4" & str1, True)
        End If
    End Sub

    Private Sub chkOldSpec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOldSpec.CheckedChanged
        If Not myView.mainGrid.myDv Is Nothing Then ApplyVMSFilter(Me.chkOldSpec.Checked)
    End Sub

    Private Sub ApplyVMSFilter(ByVal ShowCurrVMSOnly As Boolean)
        Dim str1, str2 As String
        If ShowCurrVMSOnly Then str1 = "((IsCurrent=1))" Else str1 = ""
        Dim gr As clsRow = myViewItems.mainGrid.ActiveRow
        If Not gr Is Nothing Then str2 = "ItemId = " & myUtils.cValTN(gr.CellValue("ItemId"))
        If str1 <> "" AndAlso str2 <> "" Then myView.mainGrid.myDv.RowFilter = str1 & " AND " & str2 Else myView.mainGrid.myDv.RowFilter = str1 & str2
    End Sub
End Class
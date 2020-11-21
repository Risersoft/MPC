Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmIndent
    Inherits frmMax
    Friend fItem As frmIndentItem
    Dim dv, dvMatDep As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridItemList)

        fItem = New frmIndentItem
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me
        fItem.fItemSelect.InitPanel(fItem.UltraTabControl1.Tabs("Quantity").TabPage, Nothing, Me)
        fItem.Enabled = False
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmIndentModel = Me.InitData("frmIndentModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            HandleDate(myUtils.cDateTN(myRow("IndentDate"), DateTime.MinValue))
            cmb_MatDepID.Value = myUtils.cValTN(myRow("MatDepID"))
            HandleMatDepID(myRow("IndentDate"))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Items"))
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "MatDep", "", Me.cmb_MatDepID,, 2)
            myWinSQL.AssignCmb(NewModel.dsCombo, "MvtType", "", Me.cmb_MvtType)
            dv = myWinSQL.AssignCmb(Me.dsCombo, "ForMatDep", "", Me.cmb_ForMatDepID, , 2)
            fItem.BindModel(NewModel)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If (myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave) AndAlso Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraGridItemList_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGridItemList.AfterRowActivate
        Me.InitError()
        myView.mainGrid.myGrid.UpdateData()

        Dim r1 As DataRow = myWinUtils.DataRowFromGridRow(myView.mainGrid.myGrid.ActiveRow)
        fItem.PrepForm(r1)
        fItem.Enabled = True
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If myView.mainGrid.myDv.Table.Select.Length = 0 OrElse fItem.VSave Then
            myView.mainGrid.ButtonAction("add")
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("del")
        If myView.mainGrid.myDv.Table.Select.Length = 0 Then
            fItem.Enabled = False
        End If
    End Sub

    Private Sub cmb_MatDepID_Leave(sender As Object, e As EventArgs) Handles cmb_MatDepID.Leave, cmb_MatDepID.AfterCloseUp
        HandleMatDepID(dt_IndentDate.Value)
    End Sub

    Private Sub HandleMatDepID(dated As Date)
        Dim CampusID As Integer

        If Not cmb_MatDepID.SelectedRow Is Nothing Then
            CampusID = myUtils.cValTN(cmb_MatDepID.SelectedRow.Cells("CampusID").Value)
        Else
            CampusID = 0
        End If
        Dim str1 As String = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
        dv.RowFilter = myUtils.CombineWhere(False, "CampusID = " & CampusID, str1)
        If cmb_ForMatDepID.SelectedRow Is Nothing Then cmb_ForMatDepID.Value = DBNull.Value
    End Sub

    Private Sub dt_IndentDate_Leave(sender As Object, e As EventArgs) Handles dt_IndentDate.Leave, dt_IndentDate.AfterCloseUp
        HandleDate(dt_IndentDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class
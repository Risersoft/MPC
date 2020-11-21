Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmMfgOrder
    Inherits frmMax
    Friend fItem As frmMfgOrderItem
    Dim dv, dvDep, dvCamp As DataView
    Dim WithEvents DepsCodeSys As New clsCodeSystem

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridItemList)

        Me.AddUEGB(Me.UEGB_Header, 3, Me.UEGB_ItemList.Name)
        Me.AddUEGB(Me.UEGB_ItemList, 2, Me.UEGB_Header.Name)
        Me.AddUEGB(Me.UEGB_ItemDetail, 1)

        fItem = New frmMfgOrderItem
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me

        fItem.Enabled = False
        EnableBtn(False)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMfgOrderModel = Me.InitData("frmMfgOrderModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.cmb_matdepid.Value = myRow("matdepid")
            DepsCodeSys.HandleCombo(Me.cmb_matdepid, EnumWantEvent.acForceEvent)
            HandleOrderType(myUtils.cStrTN(myRow("OrderType")))
            HandleDate(myUtils.cDateTN(myRow("OrderDate"), DateTime.MinValue))

            Me.Text = myUtils.cStrTN(myWinSQL2.ParamValue("@FormText", Me.Model.ModelParams))
            If myUtils.cValTN(myRow("PidUnitId")) > 0 Then
                fItem.btnAddLots.Visible = True
                fItem.btnAddOther.Visible = False
            Else
                fItem.btnAddLots.Visible = False
                fItem.btnAddOther.Visible = True
            End If

            If myUtils.cBoolTN(myWinSQL2.ParamValue("@Status", Me.Model.ModelParams)) Then
                btnSave.Enabled = False
                btnOK.Enabled = False
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("PurItems"))
            dvCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_CampusId,, 2)
            dvDep = New DataView(NewModel.dsCombo.Tables("DepsMat"))
            DepsCodeSys.SetConf(dvDep, Me.cmb_matdepid)
            myWinSQL.AssignCmb(Me.dsCombo, "Status", "", Me.cmb_StatusNum)
            dv = myWinSQL.AssignCmb(Me.dsCombo, "OrderType", "", Me.Cmb_OrderType, , 2)

            fItem.BindModel(NewModel)
            Return True
        End If
        Return False
    End Function

    Private Sub DepsCodeSys_ItemChanged() Handles DepsCodeSys.ItemChanged
        cm.EndCurrentEdit()
        If Not IsNothing(cmb_matdepid.SelectedRow) Then cmb_CampusId.Value = cmb_matdepid.SelectedRow.Cells("CampusId").Value
    End Sub

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

        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        fItem.PrepForm(r1)

        fItem.myView.mainGrid.myDv.RowFilter = "PurItemID = " & myView.mainGrid.myGrid.ActiveRow.Cells("PurItemID").Value
        fItem.Enabled = True

        fItem.HandlePurItemHist(btnDel)
        HandlePurItemHist()
    End Sub

    Private Sub HandlePurItemHist()
        Dim rr1() As DataRow = dsForm.Tables("PurItemHist").Select()
        If rr1.Length > 0 Then
            If Not IsNothing(cmb_matdepid) Then WinFormUtils.SetReadOnly(cmb_matdepid, False, False)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave Then
            Dim gr As UltraGridRow
            gr = myView.mainGrid.ButtonAction("add")

            fItem.Enabled = True
            fItem.Focus()
        End If
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Cmb_OrderType_Leave(sender As Object, e As EventArgs) Handles Cmb_OrderType.Leave, Cmb_OrderType.AfterCloseUp
        HandleOrderType(Cmb_OrderType.Value)
    End Sub

    Private Sub HandleOrderType(OrderType As String)
        If Not myUtils.IsInList(myUtils.cStrTN(OrderType), "") Then
            EnableBtn(True)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("del")
        If myView.mainGrid.myDv.Table.Select.Length = 0 Then
            Cmb_OrderType.ReadOnly = False
            fItem.Enabled = False
            EnableBtn(True)
        End If
    End Sub

    Private Sub EnableBtn(Bool As Boolean)
        btnAdd.Enabled = Bool
        btnDel.Enabled = Bool
    End Sub

    Private Sub dt_OrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dt_OrderDate.ValueChanged
        If Me.FormPrepared = True Then HandleDate(dt_OrderDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
        dvCamp.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "CampusID")
    End Sub
End Class
Imports risersoft.app.mxent

Public Class frmMfgOrderItem
    Inherits frmMax
    Protected Friend fMat As frmMax
    Dim WithEvents ItemCodeSys As New clsCodeSystem

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        myView.SetGrid(UltraGridDelSchedule)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(fMat.Model.GridViews("PurItemDet"))
        ItemCodeSys.SetConf(NewModel.dsCombo.Tables("Items"), Me.cmb_ItemId, Me.cmbItemName, Me.cmb_BaseUnitID, cmb_BaseUnitID2)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_QtyUnitID)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_RateUnitId)
        myWinSQL.AssignCmb(NewModel.dsCombo, "StockStage", "", Me.cmb_StockStage)
        Return True
    End Function

    Public Overloads Function PrepForm(ByVal r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r1) Then
            Me.cmb_ItemId.Value = myRow("ItemID")
            ItemCodeSys.HandleCombo(Me.cmb_ItemId, EnumWantEvent.acForceEvent)
            Me.CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVMSId"))
            myRow("classtype") = "M"
            HandleTotalQty(myUtils.cValTN(myRow("TotalQty")))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub ReadOnlyControlCommon(Enabled As Boolean)
        WinFormUtils.SetReadOnly(Me.UltraTabControl1.Tabs("General").TabPage, True, Enabled)
        txt_QtyRate.ReadOnly = True
        txt_QtyRecd.ReadOnly = True
        txt_RemQuan.ReadOnly = True
        cmb_BaseUnitID.ReadOnly = True
        cmb_QtyUnitID.ReadOnly = True
        txt_TotalQty.ReadOnly = False
        cmb_BaseUnitID2.ReadOnly = True
        dt_Datecomp.ReadOnly = True
        If myUtils.cValTN(myRow("QtyRecd")) > 0 Then Me.CtlItemVMS1.Enabled = False
    End Sub

    Public Sub HandlePurItemHist(InputControl As System.Windows.Forms.Control)
        Dim rr1() As DataRow = fMat.dsForm.Tables("PurItemHist").Select("PurItemID = " & myUtils.cValTN(myRow("PurItemID")))
        If rr1.Length > 0 Then
            Me.ReadOnlyControlCommon(False)
        Else
            Me.ReadOnlyControlCommon(True)
            If Not IsNothing(InputControl) Then InputControl.Enabled = True
        End If

        If rr1.Length > 0 Then
            If Not IsNothing(InputControl) Then InputControl.Enabled = False
        End If
    End Sub

    Private Sub ItemCodeSys_ItemChanged() Handles ItemCodeSys.ItemChanged
        cm.EndCurrentEdit()
        Me.CtlItemVMS1.InitVMS(myUtils.cValTN(cmb_ItemId.Value), , EnumWantEvent.acForceEvent)
        myRow("ItemName") = myUtils.cStrTN(cmbItemName.Text)
        myRow("ItemCode") = myUtils.cStrTN(Me.cmb_ItemId.Text)
        If Not myUtils.NullNot(cmb_ItemId.SelectedRow) Then
            If Not myUtils.NullNot(cmb_ItemId.SelectedRow.Cells("OrderQtyUnitId").Value) Then
                cmb_QtyUnitID.Value = cmb_ItemId.SelectedRow.Cells("OrderQtyUnitId").Value
            Else
                cmb_QtyUnitID.Value = cmb_ItemId.SelectedRow.Cells("ItemUnitId").Value
            End If

            If Not myUtils.NullNot(cmb_ItemId.SelectedRow.Cells("OrderRateUnitId").Value) Then
                cmb_RateUnitId.Value = cmb_ItemId.SelectedRow.Cells("OrderRateUnitId").Value
            Else
                cmb_RateUnitId.Value = cmb_ItemId.SelectedRow.Cells("ItemUnitId").Value
            End If
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()
        cm.EndCurrentEdit()
        If IsNothing(myRow) Then
            WinFormUtils.AddError(Me.cmb_ItemId, "Please Generate Transaction")
            Exit Function
        End If

        If myUtils.NullNot(cmb_ItemId.Value) Then WinFormUtils.AddError(cmb_ItemId, "Select Item Code")
        If myUtils.NullNot(cmbItemName.Value) Then WinFormUtils.AddError(cmbItemName, "Select Item Name")
        If Me.CtlItemVMS1.ItemVMSID = 0 Then WinFormUtils.AddError(Me.CtlItemVMS1, "Select Item Specification")
        If myUtils.cValTN(txt_TotalQty.Value) <= 0 Then WinFormUtils.AddError(txt_TotalQty, "Enter Total Qty")


        If myUtils.cValTN(cmb_ItemId.SelectedRow.Cells("OrderQtyNumReq").Value) = 1 Then
            Dim r1 As DataRow = CtlItemVMS1.SelectedVMSRow()
            If myUtils.cValTN(r1("QtyOrderNum")) <= 0 Then WinFormUtils.AddError(txt_TotalQty, "Please define convert factor, Then proceed.")
        End If
        If myUtils.NullNot(cmb_StockStage.Value) Then WinFormUtils.AddError(cmb_StockStage, "Select Stock Stage")

        myView.mainGrid.UpdateData()
        Dim QtyDelSch As Decimal = myView.mainGrid.Model.GetColSum("Quantity", "PurItemID = " & myUtils.cValTN(myRow("PurItemID")))
        If myUtils.cValTN(myRow("TotalQty")) <> myUtils.cValTN(QtyDelSch) Then WinFormUtils.AddError(txt_TotalQty, "Enter Total Quantity According to Delievery Schedule")

        For Each r1 As DataRow In fMat.dsForm.Tables("PurItemDet").Select("PurItemID = " & myUtils.cValTN(myRow("PurItemID")))
            If myUtils.cValTN(r1("Quantity")) < myUtils.cValTN(r1("QtyRecd")) Then WinFormUtils.AddError(txt_TotalQty, "Material Voucher already created. Total Quantity can not be less then Recieved Quantity.")
        Next

        If Me.CanSave Then
            myRow("ItemVMSId") = Me.CtlItemVMS1.ItemVMSID
            myRow("RateUnitID") = myUtils.cValTN(Me.cmb_RateUnitId.Value)
            myRow("QtyUnitID") = myUtils.cValTN(Me.cmb_QtyUnitID.Value)
            If fMat.frmMode = EnumfrmMode.acAddM Then myRow("IsCompleted") = False
            If fMat.frmMode = EnumfrmMode.acAddM Then myRow("Status") = "InComplete"
            SetOrderNumDescrip()
            VSave = True
        End If
    End Function

    Private Sub btnAddLots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLots.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(fMat.myRow("PIDUnitID")), GetType(Integer), False))
        Dim rr() As DataRow = fMat.AdvancedSelect("prodlot", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In rr
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, fMat.dsForm.Tables("PurItemDet"))
                r2("PurItemID") = myUtils.cValTN(myRow("PurItemID"))
            Next
        End If
    End Sub

    Private Sub btnSelectReq_Click(sender As Object, e As EventArgs)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@campusid", myUtils.cValTN(fMat.myRow("CampusID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@itemvmsid", myUtils.cValTN(myRow("ItemVMSId")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@classtype", "'" & myUtils.cStrTN(myRow("ClassType")) & "'", GetType(String), False))
        Params.Add(New clsSQLParam("@isagainstjwo", 0, GetType(Integer), False))

        Dim rr() As DataRow = fMat.AdvancedSelect("itemreq", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In rr
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, fMat.dsForm.Tables("MatReqItemPur"))
                r2("PurItemID") = myUtils.cValTN(myRow("PurItemID"))
            Next
        End If
    End Sub

    Public Function CalculateQty(r1 As DataRow) As Decimal
        Dim a As Decimal, r2 As DataRow
        If Not IsNothing(r1("ItemID")) Then
            Dim dt1 As DataTable = fMat.GenerateIDOutput("itemvms", myUtils.cValTN(r1("ItemVMSID"))).Data.Tables(0)
            If dt1.Rows.Count > 0 Then
                r2 = dt1.Rows(0)
                a = myItemUnit.ConvertFactor(Me.Controller, myUtils.cValTN(r1("ItemID")), myUtils.cValTN(r2("PIDUnitID")), myUtils.cValTN(r2("VarNum")), myUtils.cValTN(r1("QtyUnitID")), myUtils.cValTN(r1("RateUnitId")))
            End If
        End If
        Return a
    End Function

    Private Sub txt_TotalQty_Leave(sender As Object, e As EventArgs) Handles txt_TotalQty.Leave
        HandleTotalQty(myUtils.cValTN(txt_TotalQty.Value))
    End Sub

    Private Sub HandleTotalQty(TotalQty As Decimal)
        Dim a As Decimal = CalculateQty(myRow.Row)
        txt_QtyRate.Value = myUtils.cValTN(TotalQty) * myUtils.cValTN(a)
    End Sub

    Private Sub btnAddOther_Click(sender As Object, e As EventArgs) Handles btnAddOther.Click
        myView.mainGrid.ButtonAction("add")
        myView.mainGrid.myGrid.ActiveRow.Cells("PurItemID").Value = myUtils.cValTN(myRow("PurItemID"))
    End Sub

    Private Sub btnDelDS_Click(sender As Object, e As EventArgs) Handles btnDelDS.Click
        myView.mainGrid.ButtonAction("del")
    End Sub

    Private Sub SetOrderNumDescrip()
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@totalqty", myUtils.cValTN(myRow("TotalQty")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@itemvmsid", myUtils.cValTN(myRow("ItemVMSID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@qtyunitid", myUtils.cValTN(myRow("QtyUnitID")), GetType(Integer), False))
        Dim oRet As clsProcOutput = fMat.GenerateParamsOutput("ordernumdescrip", Params)
        If oRet.Success Then
            myRow("OrderNumDescrip") = oRet.Description
        End If
    End Sub

    Private Sub btnCopyDate_Click(sender As Object, e As EventArgs) Handles btnCopyDate.Click
        Dim rr() As DataRow = fMat.dsForm.Tables("PurItemDet").Select("PurItemID = " & myUtils.cValTN(myRow("PurItemID")))
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In rr
                r1("DeliveryDate") = myUtils.cStrTN(rr(0)("DeliveryDate"))
            Next
        End If
    End Sub
End Class
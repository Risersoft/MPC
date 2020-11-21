Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxent

Public Class frmPurReqItem
    Inherits frmMax
    Friend fMat As frmPurReq, dvTransType, dvStockStage, dvValClass As DataView
    Dim WithEvents ItemCodeSys As New clsCodeSystem

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        myView.SetGrid(UltraGridItemDet)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(NewModel.GridViews("ItemDet"))
        ItemCodeSys.SetConf(NewModel.dsCombo.Tables("Items"), Me.cmb_ItemId, Me.cmbItemName, Me.cmb_BaseUnitID, Me.cmb_BaseUnitID2)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_ItemUnitID)
        dvTransType = myWinSQL.AssignCmb(NewModel.dsCombo, "TransType", "", Me.cmb_TransType, , 1)
        dvStockStage = myWinSQL.AssignCmb(NewModel.dsCombo, "StockSTage", "", Me.cmb_StockStage, , 1)
        dvValClass = myWinSQL.AssignCmb(NewModel.dsCombo, "ValuationClass", "", Me.cmb_ValuationClass, , 1)
        Return True
    End Function

    Public Overloads Function PrepForm(ByVal r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r1) Then
            Me.cmb_ItemId.Value = myRow("ItemID")
            ItemCodeSys.HandleCombo(Me.cmb_ItemId, EnumWantEvent.acForceEvent)
            Me.CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVMSId"))
            HandleMatReqType(myUtils.cStrTN(fMat.myRow("MatReqType")), myUtils.cBoolTN(fMat.myRow("isagainstjwo")))
            HandleClassType(dvValClass, myUtils.cStrTN(fMat.myRow("MatReqType")), myUtils.cBoolTN(fMat.myRow("isagainstjwo")), myUtils.cStrTN(myRow("TransType")))
            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Private Sub ItemCodeSys_ItemChanged() Handles ItemCodeSys.ItemChanged
        cm.EndCurrentEdit()
        Me.CtlItemVMS1.InitVMS(myUtils.cValTN(cmb_ItemId.Value), , EnumWantEvent.acForceEvent)
        myRow("ItemName") = myUtils.cStrTN(cmbItemName.Text)
        myRow("ItemCode") = myUtils.cStrTN(cmb_ItemId.Text)
        If Not myUtils.NullNot(cmb_ItemId.SelectedRow) Then
            If Not myUtils.NullNot(cmb_ItemId.SelectedRow.Cells("OrderQtyUnitID").Value) Then
                myRow("ItemUnitID") = cmb_ItemId.SelectedRow.Cells("OrderQtyUnitID").Value
            Else
                myRow("ItemUnitID") = cmb_ItemId.SelectedRow.Cells("ItemUnitId").Value
            End If
            myRow("UnitName") = myUtils.cStrTN(cmb_ItemUnitID.Text)
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()

        If IsNothing(myRow) Then
            WinFormUtils.AddError(Me.txt_QtyReq, "Please Generate Transaction")
            Exit Function
        End If

        If myUtils.cValTN(Me.txt_QtyReq.Text) <= 0 Then WinFormUtils.AddError(txt_QtyReq, "Enter Qty Required")
        If myUtils.IsInList(myUtils.cStrTN(fMat.myRow("MatReqType")), "M") AndAlso myUtils.NullNot(Me.cmb_TransType.Value) Then WinFormUtils.AddError(cmb_TransType, "Select Trans Type")
        If myUtils.IsInList(myUtils.cStrTN(fMat.myRow("MatReqType")), "M") AndAlso myUtils.NullNot(Me.cmb_ValuationClass.Value) Then WinFormUtils.AddError(cmb_ValuationClass, "Select Valuation Class")
        If Not myUtils.IsInList(myUtils.cStrTN(fMat.myRow("MatReqType")), "M") AndAlso myUtils.NullNot(Me.cmb_StockStage.Value) Then WinFormUtils.AddError(cmb_StockStage, "Select Stock Stage")
        If myUtils.NullNot(Me.cmb_ItemId.Value) Then WinFormUtils.AddError(cmb_ItemId, "Select Item ID")
        If myUtils.cValTN(Me.CtlItemVMS1.ItemVMSID) = 0 Then WinFormUtils.AddError(cmb_ItemId, "Select Item VMS")

        cm.EndCurrentEdit()
        If myUtils.cValTN(myRow("QtyReq")) <> myUtils.cValTN(CalculateQty) Then WinFormUtils.AddError(txt_QtyReq, "Enter Total Quantity According to Delievery Schedule")
        If myUtils.cValTN(myRow("QtyPur")) > myUtils.cValTN(myRow("QtyReq")) Then WinFormUtils.AddError(txt_QtyReq, "Qty of Requisition can't be less then Qty of PO.")


        If Me.CanSave Then
            myRow("IsCompleted") = myUtils.cBoolTN(myRow("IsCompleted"))
            If Not myUtils.NullNot(Me.CtlItemVMS1.ItemVMSID) Then
                myRow("ItemVMSId") = Me.CtlItemVMS1.ItemVMSID
            End If
            SetOrderNumDescrip()
            If fMat.frmMode = EnumfrmMode.acAddM Then myRow("IsCompleted") = False
            VSave = True
        End If
    End Function

    Private Sub UltraGridItemDet_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridItemDet.AfterCellUpdate
        cm.EndCurrentEdit()
        Me.UltraGridItemDet.UpdateData()
        myRow("QtyReq") = CalculateQty()
    End Sub

    Private Function CalculateQty() As Integer
        Dim TotQty As Decimal
        For Each r1 As DataRow In myView.mainGrid.myDv.Table.Select("MatReqItemID = " & myUtils.cValTN(myRow("MatReqItemID")))
            TotQty = myUtils.cValTN(TotQty) + myUtils.cValTN(r1("Qty"))
        Next
        Return TotQty
    End Function

    Private Sub btnAddMachine_Click(sender As Object, e As EventArgs) Handles btnAddMachine.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@assetclass", "'" & myUtils.cStrTN(cmb_ValuationClass.Value) & "'", GetType(String), False))
        Params.Add(New clsSQLParam("@machineidcsv", myUtils.MakeCSV(myView.mainGrid.myDv.Table.Select, "MachineID"), GetType(Integer), True))
        Dim rr() As DataRow = fMat.AdvancedSelect("machine", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim r2 As DataRow = myUtils.CopyOneRow(rr(0), fMat.dsForm.Tables("MatReqItemDet"))
            r2("MatReqItemID") = myUtils.cValTN(myRow("MatReqItemID"))
        End If
    End Sub

    Private Sub btnDel_Click_1(sender As Object, e As EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("Del")
        myRow("QtyReq") = CalculateQty()
    End Sub

    Private Sub btnAddOther_Click(sender As Object, e As EventArgs) Handles btnAddOther.Click
        myView.mainGrid.ButtonAction("Add")
        myView.mainGrid.myGrid.ActiveRow.Cells("MatReqItemID").Value = myUtils.cValTN(myRow("MatReqItemID"))
    End Sub

    Private Sub btnAddLots_Click(sender As Object, e As EventArgs) Handles btnAddLots.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(fMat.myRow("PIDUnitID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@matreqtype", "'" & myUtils.cStrTN(fMat.cmb_MatReqType.Value) & "'", GetType(String), False))
        Dim rr() As DataRow = fMat.AdvancedSelect("prodlot", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In rr
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, fMat.dsForm.Tables("MatReqItemDet"))
                r2("MatReqItemID") = myUtils.cValTN(myRow("MatReqItemID"))
                r2("DateReq") = DBNull.Value
            Next
        End If
    End Sub

    Private Sub SetOrderNumDescrip()
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@QtyReq", myUtils.cValTN(myRow("QtyReq")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@ItemVMSID", myUtils.cValTN(myRow("ItemVMSID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@ItemUnitID", myUtils.cValTN(myRow("ItemUnitID")), GetType(Integer), False))
        Dim oRet As clsProcOutput = fMat.GenerateParamsOutput("ordernumdescrip", Params)
        If oRet.Success Then
            myRow("OrderNumDescrip") = oRet.Description
        End If
    End Sub
    Public Sub HandleMatReqType(MatReqType As String, isAgainstJWO As Boolean)
        If Not myUtils.IsInList(myUtils.cStrTN(MatReqType), "") Then
            Me.cmb_ValuationClass.ReadOnly = True
            Me.cmb_StockStage.ReadOnly = False
            Me.cmb_TransType.ReadOnly = False
            If myUtils.IsInList(myUtils.cStrTN(MatReqType), "M") Then
                Me.dvTransType.RowFilter = "CodeClass = 'Asset'"
                Me.cmb_ValuationClass.ReadOnly = False
                Me.cmb_StockStage.ReadOnly = True
                Me.cmb_StockStage.Value = DBNull.Value
            ElseIf isAgainstJWO Then
                Me.dvTransType.RowFilter = "CodeClass = 'Service'"
                Me.cmb_ValuationClass.Value = "LABOUR"
            Else
                Me.dvTransType.RowFilter = "CodeClass = 'Material'"
                Me.cmb_ValuationClass.Value = DBNull.Value
                Me.cmb_TransType.ReadOnly = True
                Me.cmb_TransType.Value = DBNull.Value
            End If
            If Me.cmb_TransType.SelectedRow Is Nothing Then Me.cmb_TransType.Value = DBNull.Value
            If Me.cmb_ValuationClass.SelectedRow Is Nothing Then Me.cmb_ValuationClass.Value = DBNull.Value
        End If
    End Sub

    Private Sub cmb_TransType_Leave(sender As Object, e As EventArgs) Handles cmb_TransType.Leave, cmb_TransType.AfterCloseUp
        HandleClassType(dvValClass, myUtils.cStrTN(fMat.myRow("MatReqType")), myUtils.cBoolTN(fMat.myRow("isagainstjwo")), myUtils.cStrTN(cmb_TransType.Value))
    End Sub

    Private Sub HandleClassType(dv As DataView, MatReqType As String, isAgainstJWO As Boolean, TransType As String)
        If myUtils.IsInList(myUtils.cStrTN(MatReqType), "M") Then
            risersoft.app.mxform.myFuncs.TransTypeFilter(dv, "A", TransType)
        ElseIf isAgainstJWO Then
            risersoft.app.mxform.myFuncs.TransTypeFilter(dv, "S", TransType)
            Me.cmb_ValuationClass.Value = "LABOUR"
        Else
            risersoft.app.mxform.myFuncs.TransTypeFilter(dv, "M", TransType)
        End If
    End Sub
End Class
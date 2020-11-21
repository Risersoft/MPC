Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMfgOrderModel
    Inherits clsFormDataModel
    Dim myViewItem As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("PurItems")
        myViewItem = Me.GetViewModel("PurItemDet")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "select StatusNum, StatusText from Status where StatusType = 'PO' order by StatusNum"
        Me.AddLookupField("StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = "Select CampusID, DispName, WODate, CompletedOn from mmlistCampus()  Order by DispName"
        Me.AddLookupField("CampusId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campus").TableName)

        sql = "Select MatDepID, DepName, CampusID, WODate,CompletedOn from mmListDepsMat() where IsShop = 1 Order by DepName"
        Me.AddLookupField("matdepid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "DepsMat").TableName)

        sql = myFuncsBase.CodeWordSQL("Purch", "OrderType", "(CodeWord = 'MO')")
        Me.AddLookupField("OrderType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "OrderType").TableName)

        sql = "Select ItemId, ItemCode, ItemName, UnitName, UnitName2, ItemUnitId, ItemUnitID2, OrderQtyUnitId, OrderRateUnitId, OrderQtyNumReq from InvListItems()  Order by ItemName"
        Me.AddLookupField("PurItems", "ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

        sql = "Select ItemUnitID, UnitName from ItemUnits"
        Me.AddLookupField("PurItems", "QtyUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Units").TableName)
        Me.AddLookupField("PurItems", "RateUnitId", "Units")

        sql = "Select CodeWord, DescripShort, CodeClass from CodeWords  where CodeClass in ('Material') and CodeWord in ('WIP','FG')  Order by CodeClass "
        Me.AddLookupField("PurItems", "StockStage", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "StockStage").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from PurOrder Where PurOrderID = " & prepIDX
        Me.InitData(sql, "PidUnitID", oView, prepMode, prepIDX, strXML)

        If frmMode = EnumfrmMode.acAddM Then
            myRow("OrderDate") = Now.Date
            myRow("StatusNum") = 1
            myRow("OrderType") = "MO"
        End If

        If myUtils.cValTN(myRow("PidUnitId")) > 0 Then
            sql = "Select * from plnlistpidunit() where PidUnitId = " & myUtils.cValTN(myRow("PidUnitId"))
            Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            If dt1.Rows.Count > 0 Then
                Me.ModelParams.Add(New clsSQLParam("@FormText", "'Manufacturing Order for " & myUtils.cStrTN(dt1.Rows(0)("pidinfo")) & "'", GetType(String), False))
            End If
        Else
            Me.ModelParams.Add(New clsSQLParam("@FormText", "'Stock Manufacturing Order'", GetType(String), False))
        End If


        Me.BindDataTable(myUtils.cValTN(prepIDX))

        myView.MainGrid.BindGridData(Me.dsForm, 1)
        myView.MainGrid.QuickConf("", True, "1-2-1-1-1-1-1")
        str1 = "<BAND IDFIELD=""PurItemID"" TABLE=""PurItems"" INDEX=""0""><COL KEY=""PurItemID, PurOrderID, ItemVMSID, RateUnitID, PriceSlabID, QtyUnitID, ClassType, TransType, ValuationClass,  Datecomp, RemQuan, TotalQty, Rate, RequireTC,  IsCompleted, ModifiedBy, [Status], Remark, QtyRecd,StockStage, PPSubType,OrderNumDescrip""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        myViewItem.MainGrid.BindGridData(Me.dsForm, 2)
        myViewItem.MainGrid.QuickConf("", True, "1-1-1-1")
        str1 = "<BAND IDFIELD=""PurItemDetID"" TABLE=""PurItemDet"" INDEX=""0""><COL KEY=""PurItemDetID, PurItemID, ProdLotID, Quantity, QtyRecd, DeliveryDate, ExpFinDate, Updatedate""/><COL KEY=""AtMatDepID"" LOOKUPSQL=""Select MatDepID, DepName from DepsMat  where (IsStore = 1) or (IsShop = 1)"" CAPTION=""Delivery At""/></BAND>"
        myViewItem.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Me.ModelParams.Add(New clsSQLParam("@Status", myFuncs.CheckStatus(myContext, "PurOrderID", myUtils.cValTN(myRow("PurOrderID"))), GetType(Boolean), False))

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(ByVal PurOrderId As Integer)
        Dim Sql As String = "", str, str1, str2, Str3 As String, ds As DataSet

        str = " Where PurItemId in (Select PurItemId from PurItems where PurOrderId = " & PurOrderId & ")"
        str1 = "SELECT  PurItemID, PurOrderID, ItemVMSID,ItemID, ClassType, StockStage, TransType, ValuationClass,  DateComp, RemQuan, QtyRecd,  QtyUnitID, RateCurrency, RateUnitID, PriceSlabID, RequireTC,  IsCompleted, ModifiedBy, [Status], AmountWV, PPSubType, OrderNumDescrip, ItemCode, ItemName, TotalQty, QtyRate, BasicRate, AmountTot, Remark FROM PurListOItems() where PurOrderID = " & PurOrderId & ""
        str2 = "Select PurItemDetID, PurItemID, ProdLotID, Updatedate, QtyRecd, ExpFinDate, WONum, LotNum, AtMatDepID, DeliveryDate, Quantity from PurListItemDet() " & str & ""
        Str3 = "Select Distinct PurItemID from PurItemHist " & str & ""

        Sql = str1 & ";" & str2 & ";" & Str3
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)

        myUtils.AddTable(Me.dsForm, ds, "PurItems", 0)
        myUtils.AddTable(Me.dsForm, ds, "PurItemDet", 1)
        myUtils.AddTable(Me.dsForm, ds, "PurItemHist", 2)

        myContext.Tables.SetAuto(Me.dsForm.Tables("PurItems"), Me.dsForm.Tables("PurItemDet"), "PurItemID", "_PurItemID")
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If Me.SelectedRow("OrderType") Is Nothing Then Me.AddError("OrderType", "Please Select Order Type")
        If Me.SelectedRow("CampusId") Is Nothing Then Me.AddError("CampusId", "Please select Campus")
        If Me.SelectedRow("matdepid") Is Nothing Then Me.AddError("matdepid", "Please select Department")
        If Me.myView.MainGrid.myDV.Table.Select.Length = 0 Then Me.AddError("", "Please Enter Some Transactions")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If myFuncs.CheckStatus(myContext, "PurOrderID", myUtils.cValTN(myRow("PurOrderID"))) Then
                Me.AddError("OrderNum", "Order Completed, can't be update.")
            End If
            Dim ObjVouch As New clsVoucherNum(myContext)
            ObjVouch.GetNewSerialNo("PurOrderId", myRow("OrderType"), myRow.Row)
            Dim r1 As DataRow = myContext.CommonData.FinRow(myRow("OrderDate"))
            If Not myUtils.NullNot(r1) Then
                myRow("FinYearID") = r1("FinYearID")
            End If

            If Me.CanSave Then
                Dim mfgDescrip As String = " Manufacturing Order No: " & myUtils.cStrTN(myRow("OrderNum")) & ", Dt. " & Format(myRow("OrderDate"), "dd-MMM-yyyy")
                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PurOrderId", frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    frmIDX = myRow("PurOrderId")

                    myUtils.ChangeAll(dsForm.Tables("PurItems").Select, "PurOrderId=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("PurItems"), "Select PurItemID, PurOrderID, ItemVMSID,ClassType, TransType, ValuationClass,  DateComp, RemQuan, QtyRecd,  QtyUnitID, RateCurrency, RateUnitID, PriceSlabID, RequireTC,  IsCompleted, ModifiedBy, [Status], AmountWV, PPSubType, TotalQty, QtyRate, BasicRate, AmountTot, Remark,OrderNumDescrip,StockStage from PurItems")
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("PurItemDet"), "Select PurItemDetID, PurItemID, ProdLotID, Updatedate, Quantity, QtyRecd, DeliveryDate, ExpFinDate,AtMatDepID from PurItemDet", True)

                    frmMode = EnumfrmMode.acEditM
                    myContext.Provider.dbConn.CommitTransaction(mfgDescrip, frmIDX)
                    VSave = True
                Catch e As Exception
                    myContext.Provider.dbConn.RollBackTransaction(mfgDescrip, e.Message)
                    Me.AddException("", e)
                End Try
            End If
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "itemvms"
                Dim sql As String = "Select PIDUnitID, VarNum from ItemVMS where ItemVMSID = " & myUtils.cValTN(frmIDX) & ""
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing, str2 As String = ""
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "prodlot"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitId", Params))

                    Dim Sql As String = "<MODROW><SQLWHERE2>PIDUnitID = " & PIDUnitID & "</SQLWHERE2></MODROW>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ProdLotID""/>", True,, Sql)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "ordernumdescrip"
                    Dim TotalQty As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@totalqty", Params))
                    Dim QtyUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@qtyunitid", Params))
                    Dim ItemVMSID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@itemvmsid", Params))
                    oRet.Description = myFuncs.CalcOrderNumDescrip(myContext, ItemVMSID, TotalQty, QtyUnitID)
            End Select
        End If
        Return oRet
    End Function
End Class

Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPurReqModel
    Inherits clsFormDataModel
    Dim myViewItem As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myViewItem = Me.GetViewModel("ItemDet")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select MatDepID, DepName, CampusID, WODate,CompletedOn, IsStore from mmListDepsMat() where isnull(GivesReq,0) = 1  Order by DepName"
        Me.AddLookupField("MatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "MatDep").TableName)

        sql = myFuncsBase.CodeWordSQL("MatReq", "ReqType", "")
        Me.AddLookupField("MatReqType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "MatReqType").TableName)

        sql = "Select ItemId, ItemCode, ItemName, UnitName, UnitName2, ItemUnitId, ItemUnitID2, OrderQtyUnitID from InvListItems()  Order by ItemName"
        Me.AddLookupField("MatReqItems", "ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

        sql = "Select ItemUnitID, UnitName from ItemUnits"
        Me.AddLookupField("MatReqItems", "ItemUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Units").TableName)

        sql = "Select CodeWord, DescripShort, CodeClass from CodeWords  where CodeClass in ('Asset','Service') and CodeWord in ('ARO','ARW','APN', 'APU','EXP')  Order by CodeClass "
        Me.AddLookupField("MatReqItems", "TransType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "TransType").TableName)

        sql = "Select CodeWord, DescripShort, CodeClass from CodeWords  where CodeClass in ('Material') and CodeWord in ('RM', 'CG', 'CT', 'ST')  Order by CodeClass "
        Me.AddLookupField("MatreqItems", "StockStage", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "StockStage").TableName)

        sql = "Select Class,Class,ClassType,(','+TransTypeCSV) as TransTypeCSV from AccountClass where ClassType = 'A' or (ClassType = 'S' and ClassSubType in ('P','B'))"
        Me.AddLookupField("MatReqItems", "ValuationClass", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "ValuationClass").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select *  from MatReq  where MatReqID = " & prepIDX
        Me.InitData(sql, "MatReqType,PIDUnitID", oView, prepMode, prepIDX, strXML)

        If myUtils.cValTN(myRow("PIDUnitID")) > 0 Then
            myRow("MatReqType") = "W"
            Me.FormPrepared = True
        Else
            Me.FormPrepared = (myUtils.cStrTN(myRow("MatReqType")).Trim.Length > 0)
        End If

        If frmMode = EnumfrmMode.acAddM Then myRow("MRDate") = Now.Date
        If frmMode = EnumfrmMode.acAddM Then myRow("StatusNum") = 1

        Me.BindDataTable(myUtils.cValTN(prepIDX))

        myView.MainGrid.BindGridData(Me.dsForm, 1)
        myView.MainGrid.QuickConf("", True, "1-2-1-1-2", True)
        str1 = "<BAND IDFIELD=""MatReqItemID"" TABLE=""MatReqItems"" INDEX=""0""><COL KEY=""MatReqID, MatReqItemID, ItemVMSID, ItemUnitID, WhereUse, ModifiedBy, TransType, StockStage, ValutaionClass, Remark, LastMnthCons, Supplier, IsCompleted, QtyPur,OrderNumDescrip""/><COL KEY=""QtyReq"" CAPTION=""Qty""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        myViewItem.MainGrid.BindGridData(Me.dsForm, 2)
        myViewItem.MainGrid.MainConf("HIDECOLS") = IIf(myUtils.IsInList(myUtils.cStrTN(myRow("MatReqType")), "M"), "LotInfo", "MacInfo")
        myViewItem.MainGrid.QuickConf("", True, "1-1-1-1", True)
        str1 = "<BAND IDFIELD=""MatReqItemDetID"" TABLE=""MatReqItemDet"" INDEX=""0""><COL KEY=""MatReqItemDetID, MatReqItemID, MachineID, QtyPur, UpdateDate, ProdLotID, Qty""/><COL KEY=""DateReq"" CAPTION=""Date""/></BAND>"
        myViewItem.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Me.ModelParams.Add(New clsSQLParam("@Status", myFuncs.CheckStatus(myContext, "MatReqID", myUtils.cValTN(myRow("MatReqID"))), GetType(Boolean), False))
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(ByVal MatReqID As Integer)
        Dim ds As DataSet, Sql, str1, str2 As String

        str1 = "Select MatReqID, MatReqItemID, ItemVMSID, ItemID, IsCompleted, QtyPur, ItemUnitID, WhereUse, ModifiedBy, TransType, StockStage, ValuationClass, LastMnthCons, QtyStock, QtyStore, Supplier,OrderNumDescrip, ItemCode, ItemName, UnitName, QtyReq, Remark From plnListMatReqItems() where MatReqID = " & MatReqID & ""
        str2 = "Select MatReqItemDetID, MatReqItemID, MachineID, QtyPur, UpdateDate, ProdLotID, LotInfo, MacInfo, DateReq, Qty from PlnListMatReqItemDet() Where MatReqID = " & MatReqID & ""

        Sql = " " & str1 & "; " & str2 & ""
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)

        myUtils.AddTable(Me.dsForm, ds, "MatReqItems", 0)
        myUtils.AddTable(Me.dsForm, ds, "MatReqItemDet", 1)

        myContext.Tables.SetAuto(Me.dsForm.Tables("MatReqItems"), Me.dsForm.Tables("MatReqItemDet"), "MatReqItemID", "_MatReqItemDet")
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("MatReqType") Is Nothing Then Me.AddError("MatReqType", "Please Req. Type")
        If Me.SelectedRow("MatDepID") Is Nothing Then Me.AddError("MatDepID", "Please select Department")
        If myUtils.NullNot(myRow("IsAgainstJWO")) Then Me.AddError("IsAgainstJWO", "Select Against")
        If (myUtils.cStrTN(myRow("MatReqType")) = "W") AndAlso myUtils.NullNot(myRow("PIDUnitID")) Then Me.AddError("MatReqType", "Select Proper Work Order")
        If Me.myView.MainGrid.myDV.Table.Select.Length = 0 Then Me.AddError("", "Please Enter Some Transactions")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If myFuncs.CheckStatus(myContext, "MatReqID", myUtils.cValTN(myRow("MatReqID"))) Then
                Me.AddError("SNum", "Requisition Completed, can't be update.")
            End If

            Dim ObjVouch As New clsVoucherNum(myContext)
            ObjVouch.GetNewSerialNo("MatReqID", myRow("MatReqType"), myRow.Row)

            Dim r1 As DataRow = myContext.CommonData.FinRow(myRow("MRDate"))
            If Not myUtils.NullNot(r1) Then
                myRow("FinYearID") = r1("FinYearID")
            End If

            BindStockQty()
            If Me.CanSave Then
                Dim MatdepDescrip As String = Me.SelectedRow("MatDepID")("DepName")
                Dim PurReqDescrip As String = " Material Requisition for: " & MatdepDescrip & ", Dt. " & Format(myRow("MRDate"), "dd-MMM-yyyy")
                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "MatReqID", frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    frmIDX = myRow("MatReqID")

                    myUtils.ChangeAll(dsForm.Tables("MatReqItems").Select, "MatReqID=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("MatReqItems"), "Select MatReqID, MatReqItemID, ItemVMSID, IsCompleted, QtyPur, ItemUnitID, WhereUse, ModifiedBy, TransType, StockStage, ValuationClass, LastMnthCons, QtyStock, QtyStore, QtyReq, Supplier, Remark,OrderNumDescrip from MatReqItems")
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("MatReqItemDet"), "Select MatReqItemDetID, MatReqItemID, MachineID, QtyPur, UpdateDate, ProdLotID, Qty, DateReq from MatReqItemDet", True)

                    frmMode = EnumfrmMode.acEditM
                    myContext.Provider.dbConn.CommitTransaction(PurReqDescrip, frmIDX)
                    VSave = True
                Catch e As Exception
                    myContext.Provider.dbConn.RollBackTransaction(PurReqDescrip, e.Message)
                    Me.AddException("", e)
                End Try
            End If
        End If
    End Function

    Private Sub BindStockQty()
        Dim objMatStock As New clsMatStock(myContext)
        Dim CompanyID As Integer = myContext.CommonData.GetCompanyIDFromDepMat(myRow("MatDepID"))

        Dim StartDate As Date = DateSerial(myUtils.cDateTN(myRow("MRDate"), Now.Date).Year, myUtils.cDateTN(myRow("MRDate"), Now.Date).Month - 1, 1)
        Dim EndDate As Date = DateSerial(myUtils.cDateTN(myRow("MRDate"), Now.Date).Year, myUtils.cDateTN(myRow("MRDate"), Now.Date).Month, 0)

        For Each r1 As DataRow In myView.MainGrid.myDV.Table.Select
            Dim ds1 As DataSet = objMatStock.StockStatement(myUtils.cValTN(CompanyID), myRow("MRDate"), "IT", "ItemID = " & myUtils.cValTN(r1("ItemID")) & " and CampusID = " & myUtils.cValTN(Me.SelectedRow("MatDepID")("CampusID")) & "")
            r1("QtyStock") = myUtils.cValTN(ds1.Tables("Item").Compute("sum(Qty)", ""))

            Dim ds2 As DataSet = objMatStock.PeriodConsumption(myUtils.cValTN(CompanyID), StartDate, EndDate, "IT", "ItemID = " & myUtils.cValTN(r1("ItemID")) & " and CampusID = " & myUtils.cValTN(Me.SelectedRow("MatDepID")("CampusID")) & "")
            r1("LastMnthCons") = myUtils.cValTN(ds2.Tables(0).Compute("sum(Qty)", ""))


            Dim ds3 As DataSet = objMatStock.StockStatementDep(myUtils.cValTN(CompanyID), myRow("MRDate"), "IT", "ItemID = " & myUtils.cValTN(r1("ItemID")) & " and MatDepID in (Select MatDepID from DepsMat where CampusID = " & myUtils.cValTN(Me.SelectedRow("MatDepID")("CampusID")) & " and IsStore = 1)")
            r1("QtyStore") = myUtils.cValTN(ds3.Tables("Item").Compute("sum(QtyTot)", ""))
        Next
    End Sub

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing, sql As String = ""
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "prodlot"
                    Dim MatReqType As String = myUtils.cStrTN(myContext.SQL.ParamValue("@matreqtype", Params))
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))

                    If myUtils.IsInList(MatReqType, "W") Then sql = "<MODROW><SQLWHERE2>PIDUnitID = " & PIDUnitID & "</SQLWHERE2></MODROW>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ProdLotID""/>", True, , sql)
                Case "machine"
                    Dim MachineIDCSV As String = myContext.SQL.ParamValue("@machineidcsv", Params)
                    Dim AssetClass As String = myUtils.cStrTN(myContext.SQL.ParamValue("@assetclass", Params))
                    sql = "<MODROW><SQLWHERE2>AssetClass = '" & AssetClass & "' and MachineID not in (" & MachineIDCSV & ")</SQLWHERE2></MODROW>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""MACHINEID""/>", False, , sql)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "ordernumdescrip"
                    Dim QtyReq As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@QtyReq", Params))
                    Dim ItemUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ItemUnitID", Params))
                    Dim ItemVMSID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@itemvmsid", Params))
                    oRet.Description = myFuncs.CalcOrderNumDescrip(myContext, ItemVMSID, QtyReq, ItemUnitID)
            End Select
        End If
        Return oRet
    End Function
End Class

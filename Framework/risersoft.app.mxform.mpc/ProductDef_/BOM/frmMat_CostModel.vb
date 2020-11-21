Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMat_CostModel
    Inherits clsFormDataModel
    Dim myViewFrmGrid As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SubCat")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "Select MatHeadID,HeadName,SelectionType,isFormatList1, isFormatList2 from MatHeads order by MatHeadID"
        Me.AddLookupField("MatHeadID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Heads").TableName)

        Sql = "select ItemID, ItemCode, ItemName from Items"
        Me.AddLookupField("ItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "items").TableName)

        Sql = "select CostingItemId, CostItemName, PurchasePrice, PurchPriceLastUpd from CostingItems"
        Me.AddLookupField("CostingItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CostingItem").TableName)

        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from MatListCost where MatListCostID = " & prepIDX
        Me.InitData(Sql, "PidUnitID,MatHeadID", oView, prepMode, prepIDX, strXML)

        If myUtils.cValTN(myRow("MatHeadID")) > 0 Then
            Sql = "select distinct subcatid,costingtype, costingitemid, InitialCode, SubCatName from deslistitems() where matheadid = " & myUtils.cValTN(myRow("matheadid"))
            myView.MainGrid.QuickConf(Sql, True, "1-4", True, , , 0)
        End If

        If frmMode = EnumfrmMode.acAddM Then
            myRow("ismanual") = True    'for auto matlist1. Auto wont delete anything that has been added/modified manually
            'TODO: Make ismanual visible on form. And enable Select button / qty / rate if it is manual
        End If

        FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If (myUtils.cBoolTN(myRow("ismanual"))) AndAlso (Me.SelectedRow("ItemID") Is Nothing) AndAlso (Me.SelectedRow("CostingItemID") Is Nothing) Then Me.AddError("ItemName", "Select Item")
        If myUtils.cValTN(myRow("Qty")) = 0 Then Me.AddError("Qty", "Enter Qty")
        If myUtils.cValTN(myRow("Rate")) = 0 Then Me.AddError("Rate", "Enter Rate")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim ds As DataSet, Sql As String
        VSave = False
        If Me.Validate Then

            Sql = "select * from PidUnit where PidUnitid = " & myRow("PidUnitid")
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Dim MatCostDescrip As String = " Costing Material for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PIDInfo")) & " for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "MatListCostID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("MatListCostID")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(MatCostDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatCostDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "text"
                Dim sql As String = "select PidInfo from deslistpidunittot() where PidUnitId = " & myUtils.cValTN(frmIDX)
                Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt2.Rows.Count > 0 Then oRet.Description = "Costing Material for " & myUtils.cStrTN(dt2.Rows(0)("PidInfo"))
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim CostingType As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@costingtype", Params))
            Dim SubCatID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@subcatid", Params))
            Select Case SelectionKey.Trim.ToLower
                Case "costingitems"
                    Select Case myUtils.cValTN(CostingType)
                        Case 1, 3
                            Dim sql As String = "select costingitemid, CostItemName, PurchasePrice, PurchPriceLastUpd from costingitems where subcatid=" & myUtils.cValTN(SubCatID)
                            Model.MainGrid.MainConf("autorowht") = True
                            Model.MainGrid.MainConf("formatxml") = "<COL KEY=""PurchPriceLastUpd"" CAPTION=""UpdatedOn""/>"
                            Model.MainGrid.QuickConf(sql, True, "3-1-1", False, "Costing Items")
                        Case 4
                            Dim sql As String = "select itemid, ItemCode, ItemName, PurchasePrice, PurchPriceLastUpd from items where subcatid=" & myUtils.cValTN(SubCatID)
                            Model.MainGrid.MainConf("autorowht") = True
                            Model.MainGrid.MainConf("formatxml") = "<COL KEY=""PurchPriceLastUpd"" CAPTION=""UpdatedOn""/>"
                            Model.MainGrid.QuickConf(sql, True, "1-3-1-1", False, "Items")
                    End Select
            End Select
        End If
        Return Model
    End Function
End Class

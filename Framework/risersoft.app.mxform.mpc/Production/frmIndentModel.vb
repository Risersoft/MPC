Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmIndentModel
    Inherits clsFormDataModel
    Dim ObjVouch As New clsVoucherNum(myContext)

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "Select MatDepID, DepName, CampusID, WODate,CompletedOn from mmListDepsMat() where IsShop = 1 Order by DepName"
        Me.AddLookupField("MatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "MatDep").TableName)

        Sql = "Select MatDepID, DepName, CampusID, WODate,CompletedOn from mmListDepsMat() where IsStore = 1 Order by DepName"
        Me.AddLookupField("ForMatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "ForMatDep").TableName)

        Sql = myFuncsBase.CodeWordSQL("Material", "MvtType", "Codeword in ('GI', 'TP')")
        Me.AddLookupField("MvtType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "MvtType").TableName)


        '----------------frmItemSelect-------------------------------------------
        Sql = "Select ItemId, ItemCode, ItemName, UnitName, ItemUnitId, IsEto, SubCatId, ItemUnitId2, OrderQtyUnitId, OrderRateUnitId, IssueUnitId, OrderQtyNumReq, OrderQtyNumText,ValuationClass from InvListItems()  Order by ItemName"
        Me.AddLookupField("IndentItem", "ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Items").TableName)

        Sql = "Select VarNum as VarNumId, VarNum, VarName, ItemId, PidUnitId from PIDUnitItemVar where PidUnitItemVarId = 0 Order by VarName"
        Me.AddLookupField("IndentItem", "VarNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "VarNum").TableName)

        '------------------------Indent Item----------
        Sql = "Select ItemUnitID, UnitName from ItemUnits"
        Me.AddLookupField("IndentItem", "ItemUnitIDEntry", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Units").TableName)
        Me.AddLookupField("IndentItem", "ItemUnitID", "Units")
        Me.AddLookupField("IndentItem", "ItemUnitID2", "Units")
        Me.AddLookupField("IndentItem", "OrderRateUnitID", "Units")
    End Sub

    Public Overrides Function PrepForm(oview As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        If prepMode = EnumfrmMode.acAddM Then prepIdx = 0
        sql = "Select * from Indent Where IndentID = " & prepIdx
        Me.InitData(sql, "", oview, prepMode, prepIdx, strXML)

        If frmMode = EnumfrmMode.acAddM Then myRow("IndentDate") = Now.Date

        BindDataTable(prepIdx)
        myView.MainGrid.BindGridData(dsForm, 1)
        myView.MainGrid.QuickConf("", True, "1-3-1-1")
        str1 = "<BAND IDFIELD=""IndentItemID"" TABLE=""IndentItem"" INDEX=""0""><COL KEY="" IndentItemID, IndentID, ItemID, PIDUnitID, VarNum, QtyEntry, ItemUnitIDEntry, QtySKU1, QtySKU2""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        If myUtils.cValTN(myRow("MatVouchID")) > 0 Then
            Me.AddError("IndentNum", "MatVouch is created against this Indent. Can't be Edited.")
            Me.FormPrepared = False
        Else
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Function BindDataTable(ByVal IndentID As Integer) As DataSet
        Dim Sql As String = "Select IndentItemID, IndentID, ItemID, PIDUnitID, ItemUnitIDEntry,ItemUnitID,ItemUnitID2, QtySKU1, QtySKU2, ItemDescrip, WOInfo, VarNum, ItemCode, ItemName, UnitName, QtyEntry from proListIndentItem() where IndentID = " & IndentID
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        myUtils.AddTable(dsForm, ds, "IndentItem", 0)
        Return dsForm
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("MatDepID") Is Nothing Then Me.AddError("MatDepID", "Please Select Department")
        If Me.SelectedRow("ForMatDepID") Is Nothing Then Me.AddError("ForMatDepID", "Please select For Department")
        If Me.SelectedRow("MvtType") Is Nothing Then Me.AddError("MvtType", "Please Select Mvt Type")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim r1 As DataRow = myContext.CommonData.FinRow(myRow("IndentDate"))
            If Not myUtils.NullNot(r1) Then
                myRow("FinYearID") = myUtils.cValTN(r1("FinYearID"))
            End If
            ObjVouch.GetNewSerialNo("IndentID", "", myRow.Row)

            Dim IndentDescrip As String = myRow("IndentNum").ToString & " Dt. " & Format(myRow("IndentDate"), "dd-MMM-yyyy")

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "IndentId", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("IndentId")

                myUtils.ChangeAll(dsForm.Tables("IndentItem").Select, "IndentId=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("IndentItem"), "Select IndentItemID, IndentID, ItemID, PIDUnitID, ItemUnitIDEntry, QtySKU1, QtySKU2, VarNum, QtyEntry from IndentItem ")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(IndentDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(IndentDescrip, frmIDX)
                Me.AddException("", e)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "pidunititemvar"
                Dim sql As String = "select *, varnum as varnumid from pidunititemvar where itemid = " & myUtils.cValTN(frmIDX) & " order by itemid, pidunitid, varnum"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "pidunit"
                Dim sql As String = "select * from plnlistpidunit() where pidunitid = " & myUtils.cValTN(frmIDX)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet
    End Function

   Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing, sql As String
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "pidunit"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PIDUnitID""/>", False)
            End Select
        End If
        Return Model
    End Function
End Class

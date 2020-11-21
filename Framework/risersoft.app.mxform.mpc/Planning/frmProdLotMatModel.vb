Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotMatModel
    Inherits clsFormDataModel
    Dim myViewRes, myViewPOLPO, myViewJOWMO, myViewReqPO, myViewReqJWO, myViewPlnO As clsViewModel
    Dim oProc As New clsProdLotMRP(myContext)

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("LotMRP")
        myViewRes = Me.GetViewModel("Res")
        myViewPOLPO = Me.GetViewModel("POLPO")
        myViewJOWMO = Me.GetViewModel("JOWMO")
        myViewReqPO = Me.GetViewModel("ReqPO")
        myViewPlnO = Me.GetViewModel("PlnO")
        myViewReqJWO = Me.GetViewModel("ReqJWO")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "select * from plnListProdLots() where prodlotid = " & prepIDX
            Me.InitData(sql, "pidunitid", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "select * from ProdLots where prodlotid=" & frmIDX

            Dim dsMRP As DataSet = oProc.GenerateLotMRPTable(myUtils.cValTN(myRow("ProdLotId")))
            myView.MainGrid.BindGridData(dsMRP, 0)
            myView.MainGrid.QuickConf("", True, "1-1-1-3-1-0-1-1-1-1-1-1-1-1-1", True)

            myViewRes.MainGrid.MainConf("showrownumber") = True
            sql = "select PlnReserveID, ProdLotID, LotInfo, ItemID, PIDUnitID, ItemCode, VarWOInfo, VarNum, ItemName, LastBalance, LastDated from plnListReserve() where prodlotid = " & frmIDX
            myViewRes.MainGrid.QuickConf(sql, True, "1.5-1-0.5-3-1-1", True)

            sql = "select PurItemDetID, ProdLotID, ItemID, PIDUnitID,OrderType, ItemCode, WOInfo, VarNum, ItemName, QtyRem, UpdateDate from PurListItemDet() where prodlotid = " & frmIDX & " and ordertype in ('po','lpo')"
            myViewPOLPO.MainGrid.QuickConf(sql, True, "0.5-1.5-1-0.5-3-1-1", True)

            sql = "select PurItemDetID, ProdLotID, ItemID, PIDUnitID,OrderType, ItemCode, WOInfo, VarNum, ItemName, QtyRem, UpdateDate from PurListItemDet() where prodlotid = " & frmIDX & " and ordertype in ('mo','jwo')"
            myViewJOWMO.MainGrid.QuickConf(sql, True, "0.5-1.5-1-0.5-3-1-1", True)

            sql = "select MatReqItemDetID, ProdLotID, ItemID, PIDUnitID, ItemCode, VarWOInfo, VarNum, ItemName, QtyRem, UpdateDate from plnListMatReqItemDet() where prodlotid = " & frmIDX & " and isnull(isagainstjwo,0)=0"
            myViewReqPO.MainGrid.QuickConf(sql, True, "1.5-1-0.5-3-1-1", True)

            sql = "select MatReqItemDetID, ProdLotID, ItemID, PIDUnitID, ItemCode, VarWOInfo, VarNum, ItemName, QtyRem, UpdateDate from plnListMatReqItemDet() where prodlotid = " & frmIDX & " and isnull(isagainstjwo,0)=1"
            myViewReqJWO.MainGrid.QuickConf(sql, True, "1.5-1-0.5-3-1-1", True)

            sql = "select PlnPlanOrderID, ProdLotID, ItemID, PIDUnitID,OrderType, ItemCode, VarWOInfo, VarNum, ItemName, QtyReq, DateReq from plnListPlanOrder() where prodlotid = " & frmIDX
            myViewPlnO.MainGrid.QuickConf(sql, True, "0.5-1.5-1-0.5-3-1-1", True)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim LotDescrip As String = " LotNo: " & myRow("LotNum").ToString & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "prodlotid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(LotDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(LotDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "items"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("ItemID Not in (@itemidcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ItemID""/>", False, , "<MODROW><SQLWHERE2>" & sql & "</SQLWHERE2></MODROW>")
                Case "lotmrp"
                    Dim ItemID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ItemID", Params))
                    Dim sql As String = "select pidunititemvarid, pidunitid, ItemID, ItemCode, ItemName, WOInfo, VarNum, VarName, SpecNum, RevNum from plnListpidunititemvar() where ItemID= " & ItemID
                    Model = New clsViewModel(vwState, myContext)
                    Model.MainGrid.QuickConf(sql, True, "1-3-1-3-1-1")
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "generate"
                oRet.Data = oProc.GenerateLotMRPTable(frmIDX)
            Case "calculate"
                Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from plnListProdLots() where prodlotid = " & frmIDX).Tables(0)
                oProc.CalcluateLotMRPTable(dt.Rows(0))
                oRet.Data = oProc.GenerateLotMRPTable(frmIDX)
        End Select
        Return oRet
    End Function
End Class

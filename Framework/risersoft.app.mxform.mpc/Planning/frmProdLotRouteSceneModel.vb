Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotRouteSceneModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("LotOp")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "select PlnRoutingID,RouteName  from PlnRouting where RouteName is Not Null"
        Me.AddLookupField("PlnRoutingID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PlnRouting").TableName)

        sql = "select PlnProcShopID,DepName  from mmListProcShop()"
        Me.AddLookupField("PlnProcShopID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PlnProcShop").TableName)

        Dim vlist As New clsValueList
        vlist.Add(False, "In-House")
        vlist.Add(True, "OutSourced")
        Me.ValueLists.Add("OutSourced", vlist)
        Me.AddLookupField("IsOutSourced", "OutSourced")

        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim sql As String = "select * from plnListProdLotRoute() where ProdLotRouteSceneID = " & prepIDX
            Me.InitData(sql, "ProdLotRouteSceneID", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "select * from ProdLotRouteScene where ProdLotRouteSceneID = " & prepIDX

            myView.MainGrid.MainConf("ShowRowNumber") = True
            myView.MainGrid.BindGridData(GenerateData("op", frmIDX), 0)
            myView.MainGrid.QuickConf("", True, "2-2-1-1", True)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim RouteDescrip As String = myUtils.cStrTN(myRow("SeqProcName"))
            Dim LotDescrip As String = " Lot Process Scenario for: " & RouteDescrip & ", Info: " & myUtils.cStrTN(myRow("PIDInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ProdLotRouteSceneID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
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
                Case "plnrouting"
                    Dim PlnProcID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnprocid", Params))
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PLNROUTINGID""/>", False, , "<FILTER KEY=""plnproc""><VALUE VALUE1=""" & myUtils.cValTN(PlnProcID) & """ /></FILTER>")
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim ProdLotRouteSceneID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ProdLotRouteSceneID", Params))
            Select Case dataKey.Trim.ToLower
                Case "delete"
                    Dim ProdLotOpid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ProdLotOpid", Params))
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "Delete from ProdLotOp where ProdLotOpid = " & ProdLotOpid)
                    oRet.Data = GenerateData("op", ProdLotRouteSceneID)
                Case "generate"
                    Dim oDef As New clsProdLotPln(myContext)
                    Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from plnListProdLotRoute() where ProdLotRouteSceneID = " & ProdLotRouteSceneID)
                    oDef.GenerateLotRouteOp(ds.Tables(0).Rows(0))
                    oRet.Data = GenerateData("op", ProdLotRouteSceneID)
                Case "refresh"
                    oRet.Data = GenerateData("op", ProdLotRouteSceneID)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim ds As DataSet
        Select Case DataKey.Trim.ToLower
            Case "op"
                ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select ProdLotOpID, PlnOpID, sortindex, OpName , PreviousOperations, StartDate, FinishDate from plnListProdLotOp() where ProdLotRouteSceneID = " & myUtils.cValTN(ID) & " order by SortIndex")
        End Select
        Return ds
    End Function
End Class
Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDURouteListModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Route")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select PlnStdSeqID, StdSeqName  from PlnStdSeq order by StdSeqName "
        Me.AddLookupField("PlnStdSeqID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PlnStdSeq").TableName)
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim Sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from deslistpidunittot() where pidunitid= " & prepIDX
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.BindGridData(GenerateData("Route", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "2-2-1-3-2")

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim RouteListDescrip As String = myUtils.cStrTN(myRow("PIDInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PidUnitID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PidUnitID")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(RouteListDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(RouteListDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim PidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params))

        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "delete"
                    Dim PlnPIDURouteid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PlnPIDURouteid", Params))
                    Dim Sql As String = "select prodlotreportid from proListLotReport() where PlnPIDURouteid=" & myUtils.cValTN(PlnPIDURouteid)
                    Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
                    If dt.Rows.Count > 0 Then
                        oRet.AddError("Lot Report already exixts... Cannot Delete")
                    Else
                        Sql = "delete from PlnPIDURoute where PlnPIDURouteid=" & myUtils.cValTN(PlnPIDURouteid)
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                        sql = "delete from PlnOp where PlnPIDURouteid=" & myUtils.cValTN(PlnPIDURouteid)
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                        oRet.Data = GenerateData("route", PidUnitID)
                    End If
                Case "recalc"
                    Dim Sql As String = "select prodlotreportid from proListLotReport() where PidUnitID=" & myUtils.cValTN(PidUnitID)
                    Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
                    If dt.Rows.Count > 0 Then
                        oRet.AddError("Lot Report already exixts... Cannot Regenerate")
                    Else
                        Dim StdSeqID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@StdSeqID", Params))
                        Dim oGen As New clsProdLotPln(myContext)
                        oGen.ClearRoutings(PidUnitID)
                        Dim oWO As clsWOInfo = myPIDU.GenerateWOInfo(myContext, PidUnitID)
                        If StdSeqID > 0 Then oGen.GenerateRoutings(oWO, StdSeqID) Else oGen.GenerateRoutings(oWO)
                        oGen.GenerateLotRoutingsPIDU(PidUnitID)
                        oRet.Data = GenerateData("route", PidUnitID)
                    End If
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "route"
                oRet.Data = GenerateData("route", myUtils.cValTN(frmIDX))
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "route"
                Dim sql As String = "Select PlnPIDURouteID, SeqProcName, RouteName, VarRunTime, PreviousRoutings, CompletionStatus from plnListPIDURoute() where pidunitid=" & myUtils.cValTN(ID) & " order by sortindex"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "select"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""plnstdseqid""/>")
            End Select
        End If
        Return Model
    End Function
End Class

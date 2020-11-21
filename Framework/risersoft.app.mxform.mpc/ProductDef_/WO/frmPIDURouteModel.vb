Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDURouteModel
    Inherits clsFormDataModel
    Dim myVueBasic As New clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Op")
        myVueBasic = Me.GetViewModel("Basic")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select PlnRoutingID, RouteName from PlnRouting where RouteName is not null"
        Me.AddLookupField("PlnRoutingID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PlnRouting").TableName)

        Sql = "select PlnProcTypeIncenID, ProcTypeDescrip from PlnProcTypeIncen where proctypeDescrip is not null"
        Me.AddLookupField("PlnProcTypeIncenID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PlnProcTypeIncen").TableName)

        Sql = "select PlnStdSeqProcID, SeqProcName from PlnStdSeqProc where SeqProcName is not null"
        Me.AddLookupField("PlnStdSeqProcID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PlnStdSeqProc").TableName)

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from PlnPIDURoute where PlnPIDURouteid = " & prepIDX
        Me.InitData(sql, "pidunitid", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.BindGridData(GenerateData("op", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "3-1-1-1-1-2-3-3", True)

        sql = "select distinct plnPIDURouteID,SeqProcName from PlnPIDURoute where pidunitid = " & myRow("pidunitid") & " order by seqprocname"
        Me.AddLookupField("PrevPIDURouteID1", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "seqproc").TableName)
        Me.AddLookupField("PrevPIDURouteID2", "seqproc")
        Me.AddLookupField("PrevPIDURouteID3", "seqproc")
        Me.AddLookupField("PrevPIDURouteID4", "seqproc")
        Me.AddLookupField("PrevPIDURouteID5", "seqproc")
        Me.AddLookupField("PrevPIDURouteID6", "seqproc")

        myVueBasic.MainGrid.BindGridData(GenerateData("opbasic", frmIDX), 0)
        myVueBasic.MainGrid.QuickConf("", True, "3-1-2-1-1-1", True)
        Dim str1 As String = "<BAND INDEX=""0"" IDFIELD=""plnpiduroutebasicID"" TABLE=""plnpiduroutebasic""><COL KEY=""PlnPIDURouteID, ProdBasicID, Descrip, BasicProd, TypeDescrip, TypeNum"" NOEDIT=""True""/><COL KEY=""IncenProdTot""/></BAND>"
        myVueBasic.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("SeqProcName")).Trim.Length = 0 Then Me.AddError("SeqProcName", "Enter Work Process Name")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim sql As String = "select PIDUnitID, PIDInfo, DescripWO from PidUnit where PidUnitid = " & myRow("PidUnitid")
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Dim RouteListDescrip As String = " Routing Process for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PIDInfo")) & " for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO")) & " for Sequence Process: " & myUtils.cStrTN(myRow("SeqProcName"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PlnPIDURouteID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PlnPIDURouteID")
                myVueBasic.MainGrid.SaveChanges(, "plnpidurouteid=" & frmIDX)
                frmMode = EnumfrmMode.acEditM
                Dim oGen As New clsProdLotPln(myContext)
                oGen.GenerateLotRoutingsPIDU(myRow("PidUnitID"))
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
        Dim PlnPIDURouteid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PlnPIDURouteid", Params))
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "delete"
                    Dim plnopid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnopid", Params))
                    Dim sql As String = "delete from plnop where plnopid=" & myUtils.cValTN(plnopid)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("op", PlnPIDURouteid)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "op"
                oRet.Data = GenerateData("op", myUtils.cValTN(frmIDX))
            Case "opbasic"
                oRet.Data = GenerateData("opbasic", myUtils.cValTN(frmIDX))
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "op"
                Dim sql As String = "Select PlnOpID, OpName, SetupTime, FixedRunTime, VarRunTime, VarRunQty, Machines, PreviousOperations, AlternateOperations from PlnListPIDURouteOp() where PlnPIDURouteID = " & ID & " order by sortindex,PlnPIDURouteID"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "opbasic"
                Dim sql As String = "Select PlnPIDURouteBasicID, PlnPIDURouteID, ProdBasicID,TypeDescrip1,ProdType1,TypeDescrip2,ProdType2,TypeDescrip3,ProdType3,Descrip, TypeNum,TypeDescrip, BasicProd, IncenProdTot, ProdUnitName from PlnListPIDURouteBasic() where PlnPIDURouteID = " & ID & " order by typenum"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "prodbasic"
                    Dim plnproctypeincenid = myUtils.cValTN(myContext.SQL.ParamValue("@plnproctypeincenid", Params))
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PRODBASICID""/>", False, , "<MODROW><SQLWHERE2>plnproctypeincenid = " & plnproctypeincenid & "</SQLWHERE2><HIDECOLS>PERSONS,CATPROC,PROCNAME,PROCTYPEDESCRIP</HIDECOLS></MODROW>")
                Case "plnrouting"
                    Dim plnprocid = myUtils.cValTN(myContext.SQL.ParamValue("@plnprocid", Params))
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PLNROUTINGID""/>", False, , "	 <FILTER KEY=""plnproc""><VALUE VALUE1=""" & myUtils.cValTN(plnprocid) & """ /></FILTER>")
                Case "plnproctypeincen"
                    Dim plnprocid = myUtils.cValTN(myContext.SQL.ParamValue("@plnprocid", Params))
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PLNPROCTYPEINCENID""/>", False, , "	<FILTER KEY=""plnproc""><VALUE VALUE1=""" & myUtils.cValTN(plnprocid) & """ /></FILTER>")
                Case "plnstdseqproc"
                    Dim strFilter As String = ""
                    Dim plnprocid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnprocid", Params))
                    If plnprocid > 0 Then strFilter = "	<FILTER KEY=""plnproc""><VALUE VALUE1=""" & plnprocid & """ /></FILTER>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PLNSTDSEQPROCID""/>", False,  , strFilter)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "SelectPlnRouting"
                Dim oDef As New clsPIDURouteBase(myContext)
                Dim oWO As clsWOInfo = myPIDU.GenerateWOInfo(myContext, frmIDX)
                oDef.GeneratePIDURouteOp(oWO, ds.Tables(0).Rows(0))
                oRet.Data = GenerateData("op", ds.Tables(0).Rows(0)("PlnPIDURouteid"))
            Case "SelectProcTypeIncen"
                Dim oDef As New clsPIDURouteBase(myContext)
                Dim oWO As clsWOInfo = myPIDU.GenerateWOInfo(myContext, frmIDX)
                oDef.GeneratePIDURouteBasic(oWO, ds.Tables(0).Rows(0))
                oRet.Data = GenerateData("opbasic", ds.Tables(0).Rows(0)("PlnPIDURouteid"))
            Case "GenerateBOM"
                Dim oDef As New clsPIDURouteBase(myContext)
                Dim oWO As clsWOInfo = myPIDU.GenerateWOInfo(myContext, frmIDX)
                oDef.GeneratePIDURouteBOM(oWO, ds.Tables(0).Rows(0))
        End Select
        Return oRet
    End Function
End Class

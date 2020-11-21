Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProgReportModel
    Inherits clsFormDataModel
    Dim sql As String, oReportProc As New clsProdReportProc(myContext)
    Dim myVueCurrProc, myVueLotLast, myVueEmp, myVueGroup, myVueGrp, myVueOther As clsViewModel, vwDate As DateTime, rMatDep As DataRow

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("LotReport")
        myVueEmp = Me.GetViewModel("Emp")
        myVueGroup = Me.GetViewModel("Group")
        myVueCurrProc = Me.GetViewModel("CurrProc")
        myVueLotLast = Me.GetViewModel("LotLast")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "select matdepid,depname, WODate,CompletedOn from mmListDepsMat() order by depname"
        Me.AddLookupField("matdepid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "matdep").TableName)

        'for ProdContriEmpGrp
        sql = "select plnprocid, procname from plnproc"
        Me.AddLookupField("PlnProcID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "proc").TableName)

        sql = "select shiftid, shift from shift"
        Me.AddLookupField("ShiftID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "shift").TableName)

        sql = myFuncsBase.CodeWordSQL("incentive", "inctype", "")
        Me.AddLookupField("ProdIncType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "incentive").TableName)

    End Sub

    Public Overrides Function PrepForm(oview As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dt1 As DataTable, oMasterData As New clsMasterDataHRP(myContext)
        Me.FormPrepared = False

        Me.InitData("", "matdepid,dated", oview, prepMode, prepIdx, strXML)
        If Not Me.vBag.Contains("dated") Then Me.vBag.Add("dated", Now.Date)

        vwDate = Me.vBag("Dated")
        Dim dsReport As DataSet = oReportProc.dsProdReport(vwDate, myUtils.cValTN(Me.vBag("matdepid")))
        Me.DatasetCollection.Add("report", dsReport)

        Dim CompanyID As Integer = myContext.CommonData.GetCompanyIDFromDepMat(Me.vBag("matdepid"))
        Dim rPP As DataRow = oMasterData.rPayPeriod(CompanyID, vwDate)
        Me.ModelParams.Add(New clsSQLParam("@isFinalWOT", myUtils.cBoolTN(rPP("isfinalWOT")), GetType(Boolean), False))

        If (Not dsReport Is Nothing) Then
            Dim dic1 As New clsCollecString(Of String)
            Dim dated As DateTime = Convert.ToDateTime(Me.vBag("Dated"))
            dic1.Add("RefContriEmpGrp", "select distinct employeeid,empcode,fullname from prolistcontriempgrp() where " & myUtils.CombineWhere(False, "matdepid=" & myUtils.cValTN(Me.vBag("matdepid")), "datediff(dd,dated,'" & Format(dated, "dd-MMM-yyyy") & "')<7", "JoinDate <= '" & Format(dated, "dd-MMM-yyyy") & "'", "LeaveDate is null or LeaveDate > '" & Format(dated, "dd-MMM-yyyy") & "'"))
            Me.AddDataSet("Ref", dic1)

            rMatDep = myContext.CommonData.MatDepRow(myUtils.cValTN(Me.vBag("matdepid")))

            If Not rMatDep Is Nothing Then
                If Me.InitData(rMatDep, oview) Then
                    frmIDX = 0
                    frmMode = EnumfrmMode.acEditM

                    Me.BindViews(rMatDep, dsReport)

                End If
            End If
        End If
        Return Me.FormPrepared
    End Function
    Protected Friend Sub BindViews(rMatDep As DataRow, ds As DataSet)
        myVueCurrProc.MainGrid.BindGridData(ds, ds.Tables.IndexOf("curr"))
        myVueCurrProc.MainGrid.QuickConf("", True, "2-1-5-2", True, "Lot Processes")

        myVueLotLast.MainGrid.BindGridData(ds, ds.Tables.IndexOf("last"))
        myVueLotLast.MainGrid.QuickConf("", True, "2-1-5-2", True, "Lot Processes")

        Dim dt1 = ds.Tables("contriemp")

        myVueEmp.MainGrid.BindGridData(dt1.DataSet, dt1.DataSet.Tables.IndexOf(dt1))
        myVueEmp.MainGrid.QuickConf("", True, "1-3-1-1-1-1-1-1-1-1-0-0-2", True, "Person Summary")
        myVueEmp.MainGrid.myDV.RowFilter = "MatDepID = " & myUtils.cValTN(Me.vBag("matdepid"))

        Dim dt3 As DataTable = ds.Tables("procgroup")
        myVueGroup.MainGrid.BindGridData(dt3.DataSet, dt3.DataSet.Tables.IndexOf(dt3))
        myVueGroup.MainGrid.QuickConf("", True, "2-1-1-1", True, "Group Processes")

        Dim sqlw1 As String = "matdepid = " & rMatDep("MatDepID")
        Dim sqlw2 As String = "dated='" & Format(vwDate, "dd-MMM-yyyy") & "'"
        Dim sql1 As String = "select prodlotreportid,prodlotrouteid,plnpidurouteid,companyid,pidunitid,plnprocid,qtyreq,totalprod, produnitname, shiftid, SeqProcName, WOInfo, LotNum, Shift, IncenProd, ProgToday, ProgTotal, Remark from proListLotReport() where " & myUtils.CombineWhere(False, sqlw1, sqlw2) & " order by plnprocid, sdate"
        myView.MainGrid.QuickConf(sql1, True, "2-2-1-1-1-2-2-3", True, "Lot Reports")

    End Sub
    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        If myVueEmp.ContextRow Is Nothing Then
            Select Case dataKey.Trim.ToLower
                Case "deleteemp"
                    sql = "delete from Prodcontriemp where ProdcontriempID = " & myUtils.cValTN(frmIDX)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim id As Integer, Dated As Date
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)

        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "inc"
                    Dated = (myContext.SQL.ParamValue("@Date", Params))
                    id = myUtils.cValTN(myContext.SQL.ParamValue("@plnprocid", Params))
                    oRet.AddDataRow("proc", oReportProc.rIncType(id, Dated))
                Case "calcincen"
                    Dim oMasterData As New clsMasterDataHRP(myContext)
                    Dated = myContext.SQL.ParamValue("@Date", Params)
                    Dim MatDepID As Integer = (myContext.SQL.ParamValue("@matdepid", Params))
                    Dim CompanyID As Integer = myContext.CommonData.GetCompanyIDFromDepMat(MatDepID)
                    Dim rPP As DataRow = oMasterData.rPayPeriod(CompanyID, Dated)
                    If rPP Is Nothing Then
                        oRet.AddError("Pay period not found")
                    Else
                        id = rPP("payperiodid")
                        Dim objInc As New clsIncentiveProc(myContext)
                        oRet = objInc.CalculateIncentiveData(id)
                    End If
            End Select
        End If
        Return oRet

    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)

        Select Case SelectionKey.Trim.ToLower
            Case "shift"
                sql = "Select shiftid,Shift,Stime,Etime,LunchOut,LunchIn from Shift where isnull(Forpersons,1)=1 order by stime"
                Model.MainGrid.QuickConf(sql, True, "2-1-1-1-1", True, "Shifts")

            Case "contriemp"
                Dim Dated As Date = myContext.SQL.ParamValue("@Dated", Params)
                Dim str1 As String = myFuncs.FilterTimeDependent(Dated, "JoinDate", "LeaveDate", 0)
                Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""EMPLOYEEID""/>", True, , "<FILTER KEY=""isworker""><VALUE VALUE1=""1""/></FILTER><MODROW><SQLWHERE2>" & XMLUtils.ReplaceSpecialChars(str1) & "</SQLWHERE2></MODROW>")

            Case "contriempgrp"
                Dim Dated As Date = myContext.SQL.ParamValue("@Dated", Params)
                Dim str1 As String = myFuncs.FilterTimeDependent(Dated, "JoinDate", "LeaveDate", 0)
                Dim sql As String = myContext.SQL.PopulateSQLParams("EmployeeID Not in (@empidcsv)", Params)
                Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""EmployeeID""/>", True, , "<FILTER KEY=""isworker""><VALUE VALUE1=""1""/></FILTER><MODROW><SQLWHERE2>" & myUtils.CombineWhere(False, sql, XMLUtils.ReplaceSpecialChars(str1)) & "</SQLWHERE2></MODROW>")

        End Select
        Return Model
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim dsReport As DataSet = Me.DatasetCollection("report")
            Dim oRet As clsProcOutput = oReportProc.SaveContriEmpGrp(myRow("matdepid"), dsReport)
            If oRet.Success Then
                Me.BindViews(myRow.Row, dsReport)
                VSave = True
            Else
                Me.AddError("MatDepID", oRet.Message)
            End If
        End If
        Return VSave
    End Function
End Class

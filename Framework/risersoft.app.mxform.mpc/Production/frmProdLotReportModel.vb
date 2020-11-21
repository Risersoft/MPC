Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotReportModel
    Inherits clsFormDataModel
    Dim sql As String

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "select matdepid, depname, WODate,CompletedOn from mmListDepsMat()"
        Me.AddLookupField("matdepid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "deps").TableName)

        sql = "select plnprocid, procname from plnproc"
        Me.AddLookupField("PlnProcID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "proc").TableName)

        sql = "select shiftid, shift from shift"
        Me.AddLookupField("ShiftID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "shift").TableName)

        sql = myFuncsBase.CodeWordSQL("incentive", "inctype", "")
        Me.AddLookupField("ProdIncType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "incentive").TableName)

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oview As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String, oReportProc As New clsProdReportProc(myContext), dsReport As DataSet, nr As DataRow
        Me.FormPrepared = False
        Me.InitData("", "MatDepID,ShiftID,prodlotrouteid,Dated,payperiodid,prodinctype,pidunitid,qtyreq", oview, prepMode, prepIdx, strXML)
        dsReport = oReportProc.dsProdReport(Me.vBag("dated"), myUtils.cValTN(Me.vBag("matdepid")))
        If prepMode = EnumfrmMode.acEditM Then
            nr = oReportProc.ProdReportRow(dsReport.Tables("report"), frmIDX)
        Else
            nr = oReportProc.ProdReportRow(dsReport.Tables("report"), Me.vBag("MatDepID"), Me.vBag("prodlotrouteid"), Me.vBag("prodinctype"), Me.vBag("Dated"), Me.vBag("payperiodid"), Me.vBag("ShiftID"))
            If nr.RowState = DataRowState.Added Then
                nr("pidunitid") = Me.vBag("pidunitid")
                nr("plnprocid") = Me.vBag("plnprocid")
                nr("qtyreq") = Me.vBag("qtyreq")
            Else
                prepIdx = nr("prodlotreportid")
            End If
        End If

        Dim dt1 As DataTable = oReportProc.PopulateProdProgressTable(nr, nr.Table.DataSet.Tables("progress"))

        If Me.InitData(nr, pView, prepIdx) Then
            Dim dic1 As New clsCollecString(Of String)
            Dim dated As DateTime = Convert.ToDateTime(Me.vBag("Dated"))
            dic1.Add("ind", "select distinct employeeid,0 as prodprogressid,worktype,empcode,fullname from prolistcontriempind() where " & myUtils.CombineWhere(False, "prodlotrouteid=" & myUtils.cValTN(myRow("prodlotrouteid")), "JoinDate <= '" & Format(dated, "dd-MMM-yyyy") & "'", "LeaveDate is null or LeaveDate > '" & Format(dated, "dd-MMM-yyyy") & "'"))
            Me.AddDataSet("contriempindref", dic1)
        End If
        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim mProc As New clsProdReportProc(myContext)
        VSave = False
        If Me.Validate Then
            Dim oRet As clsProcOutput = mProc.SaveLotReport(myRow("matdepid"), myRow.Row.Table.DataSet)
            If oRet.Success Then
                frmMode = EnumfrmMode.acEditM
                frmIDX = myRow("prodlotreportid")
                VSave = True
            Else
                Me.AddError("MatDepID", oRet.Message)
            End If
        End If

        Return VSave
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "addemp"
                    Dim Dated As Date = myContext.SQL.ParamValue("@Dated", Params)
                    Dim str1 As String = myFuncs.FilterTimeDependent(Dated, "JoinDate", "LeaveDate", 0)
                    Dim sql As String = myContext.SQL.PopulateSQLParams("EmployeeID Not in (@empidcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""EmployeeID""/>", True, , "<FILTER KEY=""isworker""><VALUE VALUE1=""1""/></FILTER><MODROW><SQLWHERE2>" & myUtils.CombineWhere(False, sql, XMLUtils.ReplaceSpecialChars(str1)) & "</SQLWHERE2></MODROW>")

            End Select
        End If
        Return Model
    End Function
End Class

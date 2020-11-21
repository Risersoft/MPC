Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
Imports risersoft.shared.cloud

<DataContract>
Public Class frmPayPeriodMPCModel
    Inherits clsFormDataModel

    Dim rComp As DataRow

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Holiday")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim vlistlp As New clsValueList
        vlistlp.Add(True, "Working")
        vlistlp.Add(False, "Holiday")

        Me.ValueLists.Add("Tnvlp", vlistlp)
        Me.AddLookupField("HolidayType", "HolidayType", "Tnvlp")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, sql1, str1 As String
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from PayPeriod where PayPeriodID = " & prepIDX
        Me.InitData(sql, "companyid", oView, prepMode, prepIDX, strXML)

        AssignMasters()

        sql = "select holidayid, CampusID, Dated, Holiday, Isworking from Holiday where CampusID in (select CampusID from Campus where CompanyID= " & myUtils.cValTN(myRow("CompanyID")) & ") and dated > = '" & Format(myRow("sdate"), "yyyy-MMM-dd") & "' and Dated < = '" & Format(myRow("edate"), "yyyy-MMM-dd") & "'"
        myView.MainGrid.QuickConf(sql, True, "1-1-1-1")
        sql1 = " select CampusID, DispName  from Campus where CompanyID in (select Companyid from Company where CompanyID = " & myUtils.cValTN(myRow("CompanyID")) & ") "
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""HOLIDAY"" IDFIELD=""HOLIDAYID""><COL KEY=""Dated,Holiday""/><COL KEY=""Isworking"" CAPTION=""Type"" VLIST=""False;Holiday|True;Working""/><COL KEY=""CampusID"" CAPTION=""Campus"" WFACTOR=""2"" LOOKUPSQL = """ & sql1 & """/></BAND>", EnumEditType.acCommandAndEdit)


        If (Not (frmMode = EnumfrmMode.acEditM) AndAlso (myUtils.cBoolTN(myRow("isfinal")))) Then Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Private Sub AssignMasters()
        Dim dt As DataTable, sql As String
        Dim oMaster As New clsMasterDataHRP(myContext)

        If frmMode = EnumfrmMode.acAddM Then
            rComp = myContext.CommonData.rCompany(Me.vBag("CompanyID"))
            myRow("CompanyID") = rComp("CompanyID")
            Dim str1 As String = "companyid=" & myRow("companyid")
            If myUtils.cStrTN(Me.vBag("TYPE")).Trim.ToLower = "old" Then
                sql = "SELECT top 1 (sdate) as st from payperiod where " & str1 & "  order by sdate asc"
            Else
                sql = "Select top 1 (edate) As ed from payperiod where " & str1 & " order by edate desc"
            End If
            dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            If dt.Rows.Count > 0 Then
                If myUtils.cStrTN(Me.vBag("TYPE")).Trim.ToLower = "old" Then
                    myRow("sdate") = DateAdd("m", -1, dt.Rows(0)(0))
                Else
                    myRow("sdate") = DateAdd("d", 1, dt.Rows(0)(0))
                End If
            Else
                myRow("sdate") = rComp("FinStartDate")
            End If
            myRow("edate") = DateAdd("d", -1, DateAdd("m", 1, myRow("sdate")))
        Else
            rComp = myContext.CommonData.rCompany(myRow("CompanyID"))
        End If

        Dim nr1 = oMaster.oMasterFICO.rPostPeriod(myRow("sdate"), "FinStartDate")
        If Not nr1 Is Nothing Then
            myRow("postperiodid") = nr1("postperiodid")
        End If

        If myRow("sdate") < rComp("FinStartDate") Then myRow("isfinal") = True

        sql = "Select postperiodid,qtrdescrip from PostPeriod"
        Me.AddLookupField("postperiodid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "postperiod").TableName)


    End Sub



    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.NullNot(myRow("SDate")) Then Me.AddError("SDate", "Select a starting Date")
        If myUtils.NullNot(myRow("eDate")) Then Me.AddError("eDate", "Select an ending Date")
        If Me.SelectedRow("PostPeriodID") Is Nothing Then Me.AddError("PostPeriodID", "Select a posting period")
        If myUtils.cStrTN(myRow("PayPeriodName")).Trim.Length = 0 Then Me.AddError("PayPeriodName", "Enter a Description")

        myView.MainGrid.CheckValid("Dated,isworking,holiday,CampusID", , , "<CHECK COND=""Dated&gt;='" & Format(myRow("sdate"), "yyyy-MMM-dd") & "' AND Dated&lt;='" & Format(myRow("edate"), "yyyy-MMM-dd") & "'"" MSG=""Select Date within limits""/>")


        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim PayperiodDescrip As String = myUtils.cStrTN(myRow("PayPeriodName"))
            Try
                If frmMode = EnumfrmMode.acAddM Then
                    myRow("isfinal") = False
                    myRow("isfinalwot") = False
                    myRow("haswot") = True
                    myRow("forcesingleot") = True
                End If
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PayPeriodID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow.Row("PayPeriodID")

                Me.myView.MainGrid.SaveChanges()

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(PayperiodDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(PayperiodDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If

        Return VSave
    End Function


    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim PayPeriodID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@payperiodid", Params))
        Dim ReturnTaskID As String = myContext.SQL.ParamValue("@ApiTaskID", Params)

        If oRet.Success Then
            Dim queueName = myContext.Controller.CalcQueueName
            If myUtils.IsInList(dataKey, "infojson") AndAlso Not String.IsNullOrWhiteSpace(ReturnTaskID) Then
                oRet.Description = myContext.Provider.objSQLHelper.ExecuteScalar(CommandType.Text, "SELECT INFOJSON FROM APITASK WHERE APITaskID ='" & ReturnTaskID.ToString & "'").ToString
            ElseIf myUtils.IsInList(dataKey, "payloadstatus") AndAlso Not String.IsNullOrWhiteSpace(ReturnTaskID) Then
                oRet = QueueTaskProvider.GetTaskStatus(myContext, ReturnTaskID)
            Else
                Select Case dataKey.Trim.ToLower
                    Case "calcppinc"
                        Dim dicParams As New Dictionary(Of String, String)
                        oRet = TaskProviderFactory.CheckAddTask(myContext, "pp", dataKey, PayPeriodID, Params, queueName, dicParams)
                        If oRet.Success Then oRet.Description = oRet.GetCalcRows("task")(0)("apitaskid").ToString
                End Select
            End If
        End If
        Return oRet
    End Function

End Class


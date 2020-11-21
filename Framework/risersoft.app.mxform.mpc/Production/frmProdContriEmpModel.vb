Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdContriEmpModel
    Inherits clsFormDataModel
    Dim mProc As New clsProdReportProc(myContext), myVueGrp, myVueOther As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("EmpInd")
        myVueGrp = Me.GetViewModel("EmpGrp")
        myVueOther = Me.GetViewModel("Other")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oview As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dsReport As DataSet, rrEmp(), nr As DataRow

        Me.FormPrepared = False

        Me.InitData("", "matdepid,dated", oview, prepMode, prepIdx, strXML)
        dsReport = mProc.dsProdReport(Me.vBag("Dated"), myUtils.cValTN(Me.vBag("matdepid")))
        rrEmp = dsReport.Tables("contriemp").Select("EmployeeID = " & prepIdx)
        If rrEmp.Length > 0 Then
            nr = rrEmp(0)
        Else
            nr = myContext.Tables.AddNewRow(dsReport.Tables("contriemp"))
            nr("employeeid") = prepIdx
            nr("dated") = Me.vBag("Dated")
            nr("matdepid") = myUtils.cValTN(Me.vBag("matdepid"))
        End If

        If Me.InitData(nr, oview, prepIdx) Then
            Dim dated As DateTime = Convert.ToDateTime(Me.vBag("dated"))
            Dim str1 As String = myUtils.CombineWhere(False, "employeeid=" & prepIdx, "MatDepID=" & Me.vBag("matdepid"), "Dated=" & "'" & Format(dated, "dd-MMM-yyyy") & "'")
            Dim str2 As String = myUtils.CombineWhere(False, "employeeid=" & prepIdx, "matdepid<>" & Me.vBag("matdepid"), "dated='" & Format(dated, "dd-MMM-yyyy") & "'", "JoinDate <= '" & Format(dated, "dd-MMM-yyyy") & "'", "LeaveDate is null or LeaveDate > '" & Format(dated, "dd-MMM-yyyy") & "'")

            Dim sql1 As String = "Select prodcontriempindid, DepName, WOInfo, LotNum, SeqProcName, Shift, WorkType, NumHours, Remark from proListContriEmpInd() where  " & str1
            myView.MainGrid.QuickConf(sql1, True, "2-2-1-2-1-1-1-2", True)

            Dim sql2 As String = "Select prodcontriempgrpid, DepName, ProcName, Shift, WorkType, NumHours, Remark from proListContriEmpGrp() where  " & str1
            myVueGrp.MainGrid.QuickConf(sql2, True, "2-2-1-1-1-2", True)

            Dim sql3 As String = "Select prodcontriempid, DepName, OTHours, GenHours, Remark from proListContriEmp() where  " & str2
            myVueOther.MainGrid.QuickConf(sql3, True, "2-1-1-2", True)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Dim oMaster As New clsMasterDataHRP(myContext)

        Me.InitError()
        Dim dtAttendance As DataTable = Me.dsForm.Tables("Attend")
        If dtAttendance.Select.Length > 0 Then
            Dim rrAttend() As DataRow = dtAttendance.Select("employeeid=" & myUtils.cValTN(myRow("employeeid")))
            If rrAttend.Length > 0 Then
                Dim rShift As DataRow = oMaster.rShift(myUtils.cValTN(rrAttend(0)("shiftid")))
                Dim PaidHours As Decimal = (rrAttend(0)("present") + rrAttend(0)("ExtraDay")) * If(rShift Is Nothing, 0, rShift("whours"))
                If myUtils.cValTN(myRow("TotHours")) > myUtils.cValTN(rrAttend(0)("TotWorkHours")) * 1.05 Then Me.AddError("TotHours", "Total Prod Hours cannot be Greater than Attendance Hours")
                If myUtils.cValTN(myRow("OTHours")) > myUtils.cValTN(rrAttend(0)("TotWorkHours")) - PaidHours Then
                    Me.AddError("OTHours", "OTHours Exceed")
                End If
            Else
                Me.AddError("TotHours", "Attendance not found")
            End If
        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            mProc.SaveContriEmp(myRow.Row.Table.DataSet)
            VSave = True
        End If
        Return VSave
    End Function

End Class

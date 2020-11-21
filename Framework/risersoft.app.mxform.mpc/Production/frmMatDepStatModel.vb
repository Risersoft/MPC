Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatDepStatModel
    Inherits clsFormDataModel
    Dim myVueAbsent, myVueVac, myVueComm, myVuePendInd, myVueMacTools, myVueFuture, myVueNCFIR, myVueTAC, myVueMO As clsViewModel

    Protected Overrides Sub InitViews()
        myVueAbsent = Me.GetViewModel("Absent")
        myVueVac = Me.GetViewModel("Vac")
        myVueComm = Me.GetViewModel("Comm")
        myVuePendInd = Me.GetViewModel("PendInd")
        myVueMacTools = Me.GetViewModel("MacTools")
        myVueFuture = Me.GetViewModel("Future")
        myVueNCFIR = Me.GetViewModel("NCFIR")
        myVueTAC = Me.GetViewModel("TAC")
        myVueMO = Me.GetViewModel("MO")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oview As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, sql2 As String, dt1 As DataTable, dated As Date, rEmp As DataRow
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acEditM Then
            If myContext.AppModel.MyEmpID > 0 Then
                sql = "select * from depsmat where matdepid = " & prepIdx
                Me.InitData(sql, "", oview, prepMode, prepIdx, strXML)

                myContext.Provider.ProcessTag(myVueAbsent, "<VIEW KEY=""listtodayabsent""><FILTER KEY=""dep""><VALUE VALUE1=""" & myUtils.cValTN(myRow("depid")) & """/></FILTER></VIEW>")

                myVueVac.MainGrid.QuickConf("select vacancyid, depid, Dated, VacCode, Vacancy,NumPers, Remark from Vacancy where isnull(iscompleted,0)=0 and depid= " & myUtils.cValTN(myRow("Depid")), True, "1-1-2-1-3", True, "Pending Vacancies")
                myVueVac.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""VACANCY"" IDFIELD=""VACANCYID""><COL KEY=""VacCode"" CAPTION=""Code"" SKIP=""True""/><COL KEY=""depid""/><COL KEY=""Numpers"" CAPTION=""Nos."" DEFAULTVALUE=""1""/><COL KEY=""Remark,Vacancy"" BIGTEXT=""True""/><COL KEY=""Dated"" DEFAULTVALUE=""" & Now & """/></BAND>", EnumEditType.acCommandAndEdit)

                myVuePendInd.MainGrid.MainConf("rhfactor") = 2
                myVuePendInd.MainGrid.QuickConf("select distinct matvouchitemid,0 as isurgent, DepName,VouchNum,VouchDate,ItemCode, ItemName,UnitName,WOInfo from invlistmatvouchitem() where matdepid = " & frmIDX, True, "1-1-1-1.5-2-1-1-1-1", , "Pending Indent Items")
                myVuePendInd.MainGrid.PrepEdit("<BAND TABLE=""matvouchitem"" IDFIELD=""matvouchitemid"" INDEX=""0""><COL KEY=""isurgent""/></BAND>", EnumEditType.acCommandAndEdit)

                myVueMacTools.MainGrid.QuickConf("select prodcommentid, catcode, madebyempid, matdepid, Dated,Comment from prodcomment where catcode=1 and isnull(iscompleted,0)=0 and matdepid = " & frmIDX & " AND madebyempid = " & myContext.AppModel.MyEmpID, True, "1-5", False, "Pending Machine / Tools Requirement")
                myVueMacTools.MainGrid.PrepEdit("<BAND TABLE=""prodcomment"" IDFIELD=""prodcommentID"" INDEX=""0""><COL KEY=""catcode,madebyempid,matdepid,comment""/><COL KEY=""Dated"" DEFAULTVALUE=""" & Format(Now, "dd-MMM-yyyy") & """ NOEDIT=""True""/></BAND>", EnumEditType.acCommandAndEdit)

                myVueFuture.MainGrid.QuickConf("select prodcommentid, catcode, madebyempid, matdepid, Dated,Comment from prodcomment where catcode=1 and isnull(iscompleted,0)=0 and matdepid = " & frmIDX & " AND madebyempid = " & myContext.AppModel.MyEmpID, True, "1-5", False, "Pending Steps / Suggestions for Better Quality / Reduction in Time / Reduction in Wastage")
                myVueFuture.MainGrid.PrepEdit("<BAND TABLE=""prodcomment"" IDFIELD=""prodcommentID"" INDEX=""0""><COL KEY=""catcode,madebyempid,matdepid,comment""/><COL KEY=""Dated"" DEFAULTVALUE=""" & Format(Now, "dd-MMM-yyyy") & """ NOEDIT=""True""/></BAND>", EnumEditType.acCommandAndEdit)

                sql = " select matdepid, depname from depsmat where isshop=1 order by matdepid"
                sql2 = "select prodserialid, prodserialnum from prodserial order by prodserialnum"
                myVueNCFIR.MainGrid.QuickConf("select prodncid, pidunitid, matdepid, NCDate, WOInfo , PartyName, DescripWO, ProdSerialID, formatdepid, FIR from proListNCItem() where matdepid = " & frmIDX & " AND isnull(ncnum,'')=''", True, "1-1-1-2-1.5-1-4", True)
                myVueNCFIR.MainGrid.PrepEdit("<BAND TABLE=""prodnc"" IDFIELD=""prodncid"" INDEX=""0""><COL KEY=""matdepid,pidunitid""/><COL KEY=""FIR"" BIGTEXT=""True""/><COL KEY=""formatdepid"" LOOKUPSQL=""" & sql & """ CAPTION=""For Dep""/><COL KEY=""ncDate"" CAPTION=""Dated"" DEFAULTVALUE=""" & Format(Now, "dd-MMM-yyyy") & """/><COL KEY=""prodserialid"" CAPTION=""Serial No."" LOOKUPSQL=""" & sql2 & """/></BAND>", EnumEditType.acCommandAndEdit)

                myVueTAC.MainGrid.MainConf("selfirstrow") = True
                myVueTAC.MainGrid.MainConf("defaultgroupon") = "process"
                myVueTAC.MainGrid.QuickConf("select ProdLotRouteID,StartDate ,Procname as Process, WOInfo, PartyName,DescripWO , LotNum, SeqProcName, FinishDate  from plnlistprodlotroute() where iscompleted=0 and SceneNum = 0 and finishdate<dateadd(ww,1,getdate()) and matdepid  = " & frmIDX & " order by finishdate", True, "1-1-2-1-2-2-2")
                myVueTAC.MainGrid.PrepEdit("<BAND TABLE=""ProdLotRoute"" IDFIELD=""ProdLotRouteID"" INDEX=""0""><COL KEY=""startdate""/><COL KEY=""finishdate"" CAPTION=""Exp Fin Date""/></BAND>", EnumEditType.acCommandAndEdit)

                myVueMO.MainGrid.MainConf("selfirstrow") = True
                myVueMO.MainGrid.QuickConf("select puritemdetid,updatedate,LotWOInfo,LotNum,PartyName,DescripWO,ItemCode,ItemName,QtyDue,QtyRecd,DeliveryDate,expfindate from purlistoitemdue() where iscompleted=0 and DeliveryDate<dateadd(ww,1,getdate()) and matdepid=" & frmIDX & " order by DeliveryDate", True, "1-1-1-2-1-3-1-1-1-1")
                myVueMO.MainGrid.PrepEdit("<BAND TABLE=""puritemdet"" IDFIELD=""puritemdetID"" INDEX=""0""><COL KEY=""updatedate""/><COL KEY=""expfindate"" CAPTION=""Exp Fin Date""/></BAND>", EnumEditType.acCommandAndEdit)
                Me.FormPrepared = True
            Else
                Me.AddError("depcode", "Your email/login ID is not defined in MAX. Please inform Personnel department")
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        myVueVac.MainGrid.CheckValid("vacancy,dated")
        myVueComm.MainGrid.CheckValid("employeeid,dated,commenttypeid")
        myVueMacTools.MainGrid.CheckValid("comment")
        myVueFuture.MainGrid.CheckValid("comment")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim MatDepStatDescrip As String = myUtils.cStrTN(myRow("DepCode")) & ", Name: " & myUtils.cStrTN(myRow("DepName"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "matdepid", frmIDX)
                myVueVac.MainGrid.SaveChanges(, "depid=" & myUtils.cValTN(myRow("Depid")))
                myVueComm.MainGrid.SaveChanges(, "madebyempid=" & myContext.AppModel.MyEmpID)
                myVuePendInd.MainGrid.SaveChanges()
                myVueMacTools.MainGrid.SaveChanges(, "madebyempid=" & myContext.AppModel.MyEmpID & ",matdepid=" & frmIDX & ",catcode=1")
                myVueFuture.MainGrid.SaveChanges(, "madebyempid=" & myContext.AppModel.MyEmpID & ",matdepid=" & frmIDX & ",catcode=2")
                myVueTAC.MainGrid.SaveChanges(, "startdate=" & Format(Now, "dd-MMM-yyyy"))
                myVueMO.MainGrid.SaveChanges(, "updatedate=" & Format(Now, "dd-MMM-yyyy"))

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(MatDepStatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatDepStatDescrip, frmIDX)
                Me.AddException("", e)
            End Try
        End If
        Return VSave
    End Function
End Class

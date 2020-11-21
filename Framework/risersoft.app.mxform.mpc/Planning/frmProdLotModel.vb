Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotModel
    Inherits clsFormDataModel
    Dim myViewOp, myViewProdSerial As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Route")
        myViewOp = Me.GetViewModel("OP")
        myViewProdSerial = Me.GetViewModel("Serial")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim Sql, str1 As String
        FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from prodlots where prodlotid = " & prepIDX
        Me.InitData(Sql, "pidunitid", oView, prepMode, prepIDX, strXML)

        myViewProdSerial.MainGrid.QuickConf("select prodserialid,prodlotid,ProdSerialNum,Weight,StatusNum from prodserial where prodlotid = " & frmIDX, True, "0-3-1-3", True)
        str1 = "<BAND TABLE=""prodserial"" IDFIELD=""prodserialid"" INDEX=""0""><COL KEY=""prodserialnum,weight,workorderid,prodlotid""/><COL KEY=""StatusNum"" LOOKUPSQL=""Select statusnum,statustext from status where statustype='PS' order by statusnum"" CAPTION=""Status""/></BAND>"
        myViewProdSerial.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        Me.PrepareRouteMat()

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "text"
                Dim oProc As New clsMVProcQtyRes(myContext)
                Dim Sql As String = "Select * from PIDUnit  where PidUnitId = " & frmIDX
                Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
                If dt2.Rows.Count > 0 Then oRet.Description = "Lot for " & dt2.Rows(0)("PidInfo")
        End Select
        Return oRet
    End Function

    Private Function PrepareRouteMat() As Boolean

        myView.MainGrid.MainConf("showrownumber") = True
        myView.MainGrid.BindGridData(GenerateData("proc", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "2-0.5-4-0.5-2-1-1-1-0.5", True)

        myViewOp.MainGrid.MainConf("showrownumber") = True
        myViewOp.MainGrid.BindGridData(GenerateData("op", frmIDX), 0)
        myViewOp.MainGrid.QuickConf("", True, "2-2-2-1-1", True)
        Return True

    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cValTN(myRow("LotNum")) <= 0 Then Me.AddError("LotNum", "Enter a Lot Number")
        If myUtils.cValTN(myRow("QtyReq")) <= 0 Then Me.AddError("QtyReq", "Enter Qty Required")
        If myUtils.NullNot(myRow("DateReq")) Then Me.AddError("DateReq", "Enter Required Date")

        myViewProdSerial.MainGrid.CheckValid("ProdSerialNum,StatusNum")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim ds As DataSet, Sql As String
        VSave = False
        If Me.Validate Then
            Sql = "select * from PidUnit where PidUnitid = " & myRow("PidUnitid")
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Dim LotDescrip As String = " LotNo: " & myRow("LotNum").ToString & ", for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PidInfo")) & ", for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "prodlotid", frmIDX)
                Dim OldMode As EnumfrmMode = frmMode
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("prodlotid")
                frmMode = EnumfrmMode.acEditM
                myViewProdSerial.MainGrid.SaveChanges(, "prodlotid=" & frmIDX)

                Dim oGen As New clsProdLotPln(myContext)
                oGen.GenerateLotRoutings(myRow("ProdLotID"))

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(LotDescrip, frmIDX)
                VSave = True
                If OldMode = EnumfrmMode.acAddM Then Me.PrepareRouteMat()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(LotDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "proc"
                oRet.Data = GenerateData("proc", myUtils.cValTN(ID))
            Case "op"
                oRet.Data = GenerateData("op", myUtils.cValTN(ID))
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "proc"
                Dim sql As String = "select ProdLotRouteSceneID, ProdLotRouteID,sortindex, SeqProcName, Qty, RouteName, VarRunTime, PreviousRoutings, ReleaseDate, StartDate, FinishDate, IsCompleted from plnListProdLotRoute() where prodlotid = " & ID & " and isnull(Scenenum,0)=0 order by startdate,sortindex"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "op"
                Dim sql As String = "select ProdLotRouteSceneID, ProdLotOpID, PlnOpID, sortindex, SeqProcName, OpName , PreviousOperations, StartDate, FinishDate from plnListProdLotOp() where prodlotid = " & ID & " and isnull(Scenenum,0)=0 order by startdate,sortindex"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function
End Class

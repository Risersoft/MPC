Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPlnResModel
    Inherits clsFormDataModel
    Public ObjPlnResProc As New clsPlnResProc(myContext)

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("PlnRes")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "Select CampusId, DispName,CompanyId, WODate, CompletedOn from mmlistCampus() Where CampusType in ('CM')"
        Me.AddLookupField("CampusId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Campus").TableName)

        Sql = myFuncsBase.CodeWordSQL("MRP", "ResItemType", "CodeWord in ('SR','SU')")
        Me.AddLookupField("ResItemType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "ResItemType").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select PlnReserveID, ProdLotId,PidUnitId,ItemId,VarNum,VarWOInfo,LotInfo,ItemCode,ItemName,CampusId,LastBalance, LastDated, TotConsumption, MinBalance from plnListReserve() where plnReserveId=" & prepIDX
        Me.InitData(Sql, "ProdLotId,PidUnitId,ItemId,VarNum,VarWOInfo,ItemCode,ItemName,CampusId", oView, prepMode, prepIDX, strXML)
        Me.sqlForm = "select * from plnreserve where plnreserveid=" & frmIDX

        Me.BindDataTable(myUtils.cValTN(prepIDX))
        ObjPlnResProc.LoadVouch(myUtils.cValTN(myRow("plnReserveId")))

        myView.MainGrid.BindGridData(Me.dsForm, 1)
        myView.MainGrid.QuickConf("", True, "1-1-1-1-1", True, "Items")
        Dim str1 As String = "<BAND INDEX = ""1"" TABLE = ""PlnReserveItem"" IDFIELD=""PlnReserveItemID""><COL KEY =""PlnReserveID,PostPeriodID, Dated, ResItemType, Qty""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        ObjPlnResProc.GenerateVoucherDelta(myRow.Row.Table, myView.MainGrid.myDV.Table)
        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(ByVal PlnReserveID As Integer)
        Dim ds As DataSet
        Dim sql As String = "Select PlnReserveItemId,PlnReserveID,ResItemSort,PostPeriodID, MatVouchItemID, VouchNum, Dated, ResItemType, Qty, 0.00 as Balance from PlnListReserveItem() where PlnReserveId=" & PlnReserveID & " order by Dated asc"
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

        myUtils.AddTable(Me.dsForm, ds, "PlnReserveItem", 0)
        myContext.Tables.SetAuto(Me.dsForm.Tables("PlnReserveItem"), Nothing, "PlnReserveItemID", "_PlnReserveItem")
    End Sub

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            ObjPlnResProc.GenerateVoucherDelta(myRow.Row.Table, myView.MainGrid.myDV.Table)
            Dim oRet As clsProcOutput = ObjPlnResProc.CheckBalance()

            Dim Sql As String = "select * from PidUnit where PidUnitid = " & myRow("PidUnitid")
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Dim sql1 As String = "Select * from ProdLots where ProdLotId  = " & myRow("ProdLotId")
            Dim ds1 As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
            Dim CampusDescrip As String = Me.SelectedRow("CampusId")("DispName")
            Dim PlnResDescrip As String = " Reservation for " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PidInfo")) & " for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO")) & " for: " & myUtils.cValTN(ds1.Tables(0).Rows(0)("LotNum")) & " for Campus: " & CampusDescrip & ""

            If oRet.Success Then
                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PlnReserveID", frmIDX)
                    If frmMode = EnumfrmMode.acEditM OrElse myView.MainGrid.myDV.Table.Select.Length > 0 Then
                        myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                        frmIDX = myRow("PlnReserveID")
                        Me.myView.MainGrid.SaveChanges(1, "PlnReserveID = " & frmIDX)
                        ObjPlnResProc.UpdateBalance()
                        frmMode = EnumfrmMode.acEditM
                        myContext.Provider.dbConn.CommitTransaction(PlnResDescrip, frmIDX)
                    End If
                    VSave = True
                Catch e As Exception
                    myContext.Provider.dbConn.RollBackTransaction(PlnResDescrip, e.Message)
                    Me.AddError("", "This voucher could not be saved" & vbCrLf & " Error was " & e.Message & vbCrLf & e.StackTrace)
                End Try
            Else
                Me.AddError("", oRet.Message)
            End If
        End If
    End Function

    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "descrip"
                Dim oProc As New clsMVProcQtyRes(myContext)
                oRet.Description = "UnReserved Stock ON " & Now.Date & " - " & oProc.GetSimilarStock(ds.Tables(0).Rows(0), "QtyUR", Now.Date) & ""
        End Select
        Return oRet
    End Function
End Class

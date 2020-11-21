Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotOpModel
    Inherits clsFormDataModel
    Dim myViewAct, myViewRes, myViewActRes, myViewResAct As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("OpUp")
        myViewAct = Me.GetViewModel("Act")
        myViewRes = Me.GetViewModel("Res")
        myViewActRes = Me.GetViewModel("ActRes")
        myViewResAct = Me.GetViewModel("ResAct")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "Select * from plnlistprodlotop() where prodlotopid = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "select prodlotopid, updatedate,qtycomplete from prodlotop where prodlotopid =0"

            sql = "select * from prodlotopupd where prodlotopid=" & prepIDX
            myView.MainGrid.QuickConf(sql, True, "1-1", True)
            str1 = "<BAND TABLE=""ProdLotOpUpd"" IDFIELD=""ProdLotOpUpdID"" INDEX=""0""><COL KEY=""ProdLotOpID,updatedate,qtycomplete""/></BAND>"
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            str1 = "<COL KEY=""StartTime"" FORMAT=""dd MMM yy HH:mm""/><COL KEY=""SRTINDEX"" CAPTION=""Type"" VLIST=""1;Setup|2;Run|3;Teardown""/>"
            myViewAct.MainGrid.MainConf("FORMATXML") = str1
            sql = "select ProdLotOpActID, ProdLotOpID, SRTIndex,StartTime,LengthMin from ProdLotOpAct where ProdLotopid=" & prepIDX
            myViewAct.MainGrid.QuickConf(sql, True, "1-1-1", True)

            sql = "select ProdLotOpActResID, ProdLotOpActID, PlnResourceID, ResourceName from plnListProdLotOpActRes() where ProdLotOpID =" & prepIDX & " order by ResourceName"
            Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            myViewActRes.MainGrid.BindGridData(dt1.DataSet, 0)
            myViewActRes.MainGrid.QuickConf("", True, "1", True)

            sql = "select distinct PlnResourceID, ResourceName from plnListProdLotOpActRes() where ProdLotOpID =" & prepIDX & " order by ResourceName"
            myViewRes.MainGrid.QuickConf(sql, True, "1", True)

            myViewResAct.MainGrid.MainConf("FORMATXML") = str1
            sql = "select ProdLotOpActResID, ProdLotOpActID, PlnResourceID, ProdLotOpID, SRTIndex,StartTime,LengthMin from plnListProdLotOpActRes() where ProdLotOpID =" & prepIDX & " order by StartTime"
            Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            myViewResAct.MainGrid.BindGridData(dt2.DataSet, 0)
            myViewResAct.MainGrid.QuickConf("", True, "1-1-1", True)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("UpdateDate,QtyComplete")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim LotDescrip As String = " Operation for: " & myUtils.cStrTN(myRow("Opname")) & " for: " & myUtils.cStrTN(myRow("PidInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ProdLotOpID", frmIDX)
                myRow("UpdateDate") = myView.MainGrid.myDS.Tables(0).Compute("max(UpdateDate)", "")
                myRow("QtyComplete") = myView.MainGrid.myDS.Tables(0).Compute("sum(QtyComplete)", "")
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                myView.MainGrid.SaveChanges(, "ProdLotOpID=" & frmIDX)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(LotDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(LotDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

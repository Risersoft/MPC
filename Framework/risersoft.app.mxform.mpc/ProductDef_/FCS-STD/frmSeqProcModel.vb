Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSeqProcModel
    Inherits clsFormDataModel
    Dim myVueProd As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Consumed")
        myVueProd = Me.GetViewModel("Produced")

    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim Sql As String = "select plnProcID,ProcName from plnproc order by procname"
        Me.AddLookupField("plnProcID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "plnproc").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from plnStdSeqProc where plnStdSeqProcID = " & prepIDX
        Me.InitData(sql, "plnstdSeqid", oView, prepMode, prepIDX, strXML, "plnstdseqprocid", "seqprocname")

        If frmMode = EnumfrmMode.acAddM Then myRow("incycledays") = True
        
        sql = "select plnseqprocmatid, plnstdseqprocid, MatHeadid, AfterEnd, MarginDays, QtyFactor, ProdBySeqProcID from plnseqprocmat where plnstdseqprocid =" & frmIDX
        myView.MainGrid.QuickConf(sql, True, "3-2-1-1-2", True)
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnseqprocmatid"" TABLE=""plnseqprocmat""><COL KEY=""MATHEADID"" CAPTION=""Material Head"" LOOKUPSQL=""Select matheadid, headname from matheads"" NOEDIT=""True""/><COL KEY=""Afterend"" CAPTION=""Type"" VLIST=""False;Before Start|True;After End""/><COL KEY=""MarginDays,QtyFactor,plnstdseqprocid""/><COL KEY=""prodbyseqprocid"" CAPTION=""Produced By"" LOOKUPSQL=""Select plnstdseqprocid, seqprocname from plnstdseqproc order by seqprocname""/></BAND>", EnumEditType.acCommandAndEdit)

        sql = "select plnseqprocmatid, prodbyseqprocid, MatHeadid, AfterEnd, MarginDays, QtyFactor, PlnStdSeqProcID from plnseqprocmat where prodbyseqprocid =" & frmIDX
        myVueProd.MainGrid.QuickConf(sql, True, "3-2-1-1-2", True)
        myVueProd.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnseqprocmatid"" TABLE=""plnseqprocmat""><COL KEY=""MATHEADID"" CAPTION=""Material Head"" LOOKUPSQL=""Select matheadid, headname from matheads"" NOEDIT=""True""/><COL KEY=""Afterend"" CAPTION=""Type"" VLIST=""False;Before Start|True;After End""/><COL KEY=""MarginDays,QtyFactor,prodbyseqprocid""/><COL KEY=""plnstdseqprocid"" CAPTION=""Consumed By"" LOOKUPSQL=""Select plnstdseqprocid, seqprocname from plnstdseqproc order by seqprocname""/></BAND>", EnumEditType.acCommandAndEdit)

        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateParamTrans(Me, "plnstdseqprocid", frmIDX)

        sql = "Select * from desparamfield where idfield='plnStdSeqProcID' and idvalue=" & myUtils.cValTN(myRow("plnStdSeqProcID"))
        Me.AddDataSet("desparamfldlst", sql)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("SeqProcName")).Trim.Length = 0 Then Me.AddError("SeqProcName", "Enter Sequence Process Name")
        If Me.SelectedRow("PlnProcID") Is Nothing Then Me.AddError("PlnProcID", "Enter Plan Process")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then
            dic.Add("Plnproc", "Select Plnprocid, ProcName from Plnproc where Plnprocid = " & myRow("Plnprocid"))
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim SeqProcDescrip As String = myRow("SeqProcName").ToString & " for: " & myUtils.cStrTN(ds.Tables("Plnproc").Rows(0)("ProcName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnStdSeqProcid", frmIDX)
                myUtils.ChangeAll(myView.MainGrid.myDS.Tables(0).Select("margindays is null"), "margindays=2")
                myUtils.ChangeAll(myView.MainGrid.myDS.Tables(0).Select("afterend is null"), "afterend=false")
                myUtils.ChangeAll(myView.MainGrid.myDS.Tables(0).Select("qtyfactor is null"), "qtyfactor=1")

                myUtils.ChangeAll(myVueProd.MainGrid.myDS.Tables(0).Select("margindays is null"), "margindays=2")
                myUtils.ChangeAll(myVueProd.MainGrid.myDS.Tables(0).Select("afterend is null"), "afterend=false")
                myUtils.ChangeAll(myVueProd.MainGrid.myDS.Tables(0).Select("qtyfactor is null"), "qtyfactor=1")
                myView.MainGrid.CheckValid("margindays,afterend,qtyfactor")
                myVueProd.MainGrid.CheckValid("margindays,afterend,qtyfactor")

                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnStdSeqProcid")
                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "plnStdSeqProcid=" & frmIDX)
                myVueProd.MainGrid.SaveChanges(, "prodBySeqProcid=" & frmIDX)
                Me.GridViews("ParamTrans").MainGrid.SaveChanges(, "idfield=plnStdSeqProcid,idvalue=" & frmIDX)

                Dim dtFieldList As DataTable = Me.DatasetCollection("desparamfldlst").Tables(0)
                myUtils.DeleteRows(dtFieldList.Select("isnull(formula,'')=''"))
                myUtils.ChangeAll(dtFieldList.Select(), "idvalue=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(dtFieldList, "select * from desparamfield where desparamfieldid=0")

                myContext.Provider.dbConn.CommitTransaction(SeqProcDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(SeqProcDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

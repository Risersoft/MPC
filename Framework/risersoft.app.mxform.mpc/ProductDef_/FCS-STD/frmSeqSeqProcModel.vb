Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSeqSeqProcModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select * from plnStdSeqSeqProc where plnStdSeqSeqProcID = " & prepIDX
        Me.InitData(Sql, "plnstdSeqid", oView, prepMode, prepIDX, strXML)

        Sql = "select plnstdseqprocid, procname, seqprocname from plnliststdseqproc() where (plnStdSeqProcid not in (select plnstdseqprocid from plnstdseqseqproc where plnStdSeqid = " & myRow("plnStdSeqid") & ")) or (plnstdseqprocid=" & myUtils.cValTN(myRow("plnstdseqprocid")) & ") order by seqprocname"
        Me.AddLookupField("plnstdseqprocid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "plnliststdseqproc()").TableName)

        Sql = "select distinct plnStdSeqProcID,SeqProcName from PlnStdSeqProc where plnStdSeqProcid in (select plnstdseqprocid from plnstdseqseqproc where plnStdSeqid = " & myRow("plnStdSeqid") & ") order by seqprocname"
        Me.AddLookupField("PrevSeqProcID1", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "seqproc").TableName)
        Me.AddLookupField("PrevSeqProcID2", "seqproc")
        Me.AddLookupField("PrevSeqProcID3", "seqproc")
        Me.AddLookupField("PrevSeqProcID4", "seqproc")
        Me.AddLookupField("PrevSeqProcID5", "seqproc")
        Me.AddLookupField("PrevSEqProcID6", "seqproc")

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("plnstdSeqid")).Trim.Length = 0 Then Me.AddError("plnstdSeqid", "Enter Plan Process")
        If myUtils.TwoSimilar(False, myUtils.cValTN(myRow("PrevSeqProcID1")), myUtils.cValTN(myRow("PrevSeqProcID2")), myUtils.cValTN(myRow("PrevSeqProcID3")), myUtils.cValTN(myRow("PrevSeqProcID4")), myUtils.cValTN(myRow("PrevSeqProcID5")), myUtils.cValTN(myRow("PrevSeqProcID6"))) Then Me.AddError("PrevSeqProcID1", "Same process selected")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then
            dic.Add("plnstdSeq", "Select plnstdSeqid, StdSeqName from plnstdSeq where plnstdSeqid = " & myRow("plnstdSeqid"))
            dic.Add("plnstdseqproc", "Select plnstdseqprocid, SeqProcName from plnstdseqproc where plnstdseqprocid = " & myRow("plnstdseqprocid"))
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim SeqProcDescrip As String = ds.Tables("plnstdseqproc").Rows(0)("SeqProcName").ToString & " for: " & myUtils.cStrTN(ds.Tables("plnstdSeq").Rows(0)("StdSeqName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnStdSeqSeqProcid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnStdSeqSeqProcid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(SeqProcDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(SeqProcDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class






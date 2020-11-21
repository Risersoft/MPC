Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmStdSeqModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SequenceProc")
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
        Dim Sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "Select * from plnstdseq where plnStdSeqid = " & prepIDX
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""SeqProcName"" CAPTION=""Sequence Process""/><COL KEY=""ProcName"" CAPTION=""Plan Process""/>"
        myView.MainGrid.BindGridData(GenerateData("Op", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "2-1-3-3", True)

        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateParamQual(Me, "plnstdseqid", frmIDX)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("StdSeqName")).Trim.Length = 0 Then Me.AddError("StdSeqName", "Enter Sequence Name")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim StdSeqDescrip As String = myRow("StdSeqName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnStdSeqID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnStdSeqID")
                frmMode = EnumfrmMode.acEditM
                Me.GridViews("ParamQual").MainGrid.SaveChanges(, "idvalue=" & frmIDX & ",idfield=plnstdseqid")

                myContext.Provider.dbConn.CommitTransaction(StdSeqDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(StdSeqDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim plnStdSeqID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnStdSeqID", Params))
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "refresh"
                    oRet.Data = GenerateData("op", plnStdSeqID)
                Case "delete"
                    Dim plnstdseqseqprocid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnstdseqseqprocid", Params))
                    Dim sql As String = "delete from plnstdseqseqproc where plnstdseqseqprocid =" & myUtils.cValTN(plnstdseqseqprocid)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("op", plnStdSeqID)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "op"
                Dim sql As String = "Select * from plnListStdSeqSeqProc() where plnstdSeqid= " & ID & " order by sortindex,plnStdSeqProcID"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class


Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmOpModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Lots")
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
        Dim Sql, str1, str2 As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "Select * from plnop where plnopid = " & prepIDX
        Me.InitData(Sql, "plnroutingid,plnpidurouteid,prodlotroutesceneid", oView, prepMode, prepIDX, strXML, "plnopid", "opname")

        myView.MainGrid.QuickConf("select plnopbatchid, plnopid, BatchAttrib, AttribValue, AttribStart, AttribEnd from plnOpBatch where plnopid = %frmIDX%", True, "3-1-1-1", True, "Batching Setup")
        str1 = "<BAND TABLE=""PlnOpBatch"" IDFIELD=""plnOpBatchID"" INDEX=""0""><COL KEY=""plnopid""/><COL KEY=""BatchAttrib"" CAPTION=""Attribute""/><COL KEY=""AttribValue"" CAPTION=""Value""/><COL KEY=""AttribStart"" CAPTION=""Range Start""/><COL KEY=""AttribEnd"" CAPTION=""Range End""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Dim oSQL As New clsSQLBuilder(myContext)
        oSQL.sqlSelectGet = "distinct plnOpid,OpName,sortindex"
        oSQL.sqlOrderBy = "sortindex,plnopid"
        If Not myUtils.NullNot(myRow("prodlotroutesceneid")) Then
            oSQL.sqlFromGet = "plnListProdLotOp()"
            str1 = "prodlotroutesceneid = " & myUtils.cValTN(myRow("prodlotroutesceneid"))
            str2 = "plnpidurouteid = " & myUtils.cValTN(myRow("plnpidurouteid"))
        ElseIf Not myUtils.NullNot(myRow("plnpidurouteid")) Then
            oSQL.sqlFromGet = "plnListPIDURouteOp()"
            str1 = "plnpidurouteid = " & myUtils.cValTN(myRow("plnpidurouteid"))
        Else
            oSQL.sqlFromGet = "plnListOp()"
            str1 = "plnroutingid = " & myUtils.cValTN(myRow("plnroutingid"))
        End If

        'Previous And alternate operations
        oSQL.sqlWhere = myUtils.CombineWhere(False, "plnopid<>" & frmIDX, str1)
        Sql = oSQL.GenerateSQLGet(True)
        Me.AddLookupField("PrevOpID1", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PrevOp").TableName)
        Me.AddLookupField("PrevOPID2", "PrevOp")
        Me.AddLookupField("PrevOpID3", "PrevOp")
        Me.AddLookupField("PrevOpID4", "PrevOp")
        Me.AddLookupField("PrevOpID5", "PrevOp")
        Me.AddLookupField("PrevOpID6", "PrevOp")

        If str2 = "" Then str2 = str1
        oSQL.sqlWhere = myUtils.CombineWhere(False, "plnopid<>" & frmIDX, str2, "isnull(movetostdalt,0)=1")
        Sql = oSQL.GenerateSQLGet(True)
        Me.AddLookupField("AltOpID1", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "altop").TableName)
        Me.AddLookupField("AltOpID2", "altop")
        Me.AddLookupField("AltOpID3", "altop")

        Sql = "Select * from desparamfield where idfield='plnopid' and idvalue=" & myUtils.cValTN(myRow("plnopid"))
        Me.AddDataSet("desparamfldlst", Sql)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("OpName")).Trim.Length = 0 Then Me.AddError("OpName", "Enter Operation Name")
        If myUtils.TwoSimilar(False, myUtils.cValTN(myRow("AltOpID1")), myUtils.cValTN(myRow("AltOpID2")), myUtils.cValTN(myRow("AltOpID3")), myUtils.cValTN(myRow("PrevOpID1")), myUtils.cValTN(myRow("PrevOPID2")), myUtils.cValTN(myRow("PrevOpID3"))) Then Me.AddError("AltOpID1", "Same operation selected")
        If myUtils.cBoolTN(myRow("MovetoStdAlt")) AndAlso (myUtils.cValTN(myRow("AltOpID1")) > 0 OrElse myUtils.cValTN(myRow("AltOpID2")) > 0 OrElse myUtils.cValTN(myRow("AltOpID3")) > 0 OrElse myUtils.cValTN(myRow("PrevOpID1")) > 0 OrElse myUtils.cValTN(myRow("PrevOPID2")) > 0 OrElse myUtils.cValTN(myRow("PrevOpID3")) > 0 OrElse myUtils.cValTN(myRow("PrevOpID4")) > 0 OrElse myUtils.cValTN(myRow("PrevOpID5")) > 0 OrElse myUtils.cValTN(myRow("PrevOpID6")) > 0) Then Me.AddError("MovetoStdAlt", "Uncheck if you want to select alternate or previous operations")
        myView.MainGrid.CheckValid("BatchAttrib")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then

            Dim OPDescrip As String = myUtils.cStrTN(myRow("OpName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnOpid", frmIDX)

                If myUtils.cValTN(myRow("overlapper")) > 0 OrElse myUtils.cValTN(myRow("overlapcount")) > 0 Then
                    myRow("sequencecons") = "O"
                Else
                    myRow("sequencecons") = "S"
                End If
                If myUtils.cBoolTN(myRow("lockedseq")) Then myRow("sequencecons") = myRow("sequencecons") & "*"

                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnOpid")
                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "plnOpid=" & frmIDX)

                Dim dtFieldList As DataTable = Me.DatasetCollection("desparamfldlst").Tables(0)
                myUtils.DeleteRows(dtFieldList.Select("isnull(formula,'')=''"))
                myUtils.ChangeAll(dtFieldList.Select(), "idvalue=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(dtFieldList, "select * from desparamfield where desparamfieldid=0")

                myContext.Provider.dbConn.CommitTransaction(OPDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(OPDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "macinfo"
                If ds.Tables(0).Rows.Count > 0 Then oRet.Description = myFuncs.MacInfo(myContext, myUtils.cValTN(ds.Tables(0).Rows(0)("machineid")), myUtils.cValTN(ds.Tables(0).Rows(0)("plnmcgroupid")))
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "machine"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""MACHINEID""/>", False)
                Case "macgroup"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PLNMCGROUPID""/>", False)
            End Select
        End If
        Return Model
    End Function
End Class

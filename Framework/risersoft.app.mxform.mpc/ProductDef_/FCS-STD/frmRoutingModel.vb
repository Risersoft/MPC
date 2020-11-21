Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmRoutingModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("op")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim Sql As String = "select matdepid,depname from depsmat where isnull(isshop,0)=1 order by depname"
        Me.AddLookupField("matdepid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "depsmat").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from plnrouting where plnroutingid = " & prepIDX
        Me.InitData(sql, "plnprocid", oView, prepMode, prepIDX, strXML, "plnroutingid", "routename")

        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""RouteName"" CAPTION=""Routing""/>"
        myView.MainGrid.BindGridData(GenerateData("Op", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "3-1-1-1-1-3-3", True)

        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateParamQual(Me, "plnroutingid", frmIDX)

        sql = "Select * from desparamfield where idfield='plnroutingid' and idvalue=" & myUtils.cValTN(myRow("plnroutingid"))
        Me.AddDataSet("desparamfldlst", sql)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("RouteName")).Trim.Length = 0 Then Me.AddError("RouteName", "Enter Routing Name")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then
            dic.Add("Plnproc", "Select Plnprocid, ProcName from Plnproc where Plnprocid = " & myRow("Plnprocid"))
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim RoutingDescrip As String = myRow("RouteName").ToString & " for: " & myUtils.cStrTN(ds.Tables("Plnproc").Rows(0)("ProcName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnroutingid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnroutingid")
                frmMode = EnumfrmMode.acEditM
                Me.GridViews("ParamQual").MainGrid.SaveChanges(, "idvalue=" & frmIDX & ",idfield=plnroutingid")

                Dim dtFieldList As DataTable = Me.DatasetCollection("desparamfldlst").Tables(0)
                myUtils.DeleteRows(dtFieldList.Select("isnull(formula,'')=''"))
                myUtils.ChangeAll(dtFieldList.Select(), "idvalue=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(dtFieldList, "select * from desparamfield where desparamfieldid=0")

                myContext.Provider.dbConn.CommitTransaction(RoutingDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(RoutingDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim plnroutingid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnroutingid", Params))
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "refresh"
                    oRet.Data = GenerateData("op", plnroutingid)
                Case "delete"
                    Dim plnopid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnopid", Params))
                    Dim sql As String = "delete from plnop where plnopid=" & myUtils.cValTN(plnopid)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("op", plnroutingid)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "op"
                Dim sql As String = "Select * from plnListOP() where plnroutingid= " & ID & " order by sortindex,plnopid"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class

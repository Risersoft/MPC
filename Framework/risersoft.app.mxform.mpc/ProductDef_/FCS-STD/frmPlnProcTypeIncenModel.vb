Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPlnProcTypeIncenModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("BasicProd")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim Sql As String = "select plnProcID,ProcName from plnproc order by procname"
        Me.AddLookupField("plnProcID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "plnproc").TableName)

        Sql = "select distinct typedescrip1,typedescrip2,typedescrip3 from plnproctypeincen where typedescrip1 is not null"
        Dim dt1 As DataTable = myContext.Data.SelectDistinct(myContext.Tables.Decrossnum(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0), "typedescrip"), "typedescrip", , , "len(typedescrip)>0")
        Me.ValueLists.Add("typedescrip", myContext.SQL.VListFromTable(dt1))

        Sql = "select distinct produnitname from plnproctypeincen where produnitname is not null"
        Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        Me.ValueLists.Add("produnitname", myContext.SQL.VListFromTable(dt2))
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim Sql As String
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "Select * from plnProcTypeIncen where plnproctypeincenID = " & prepIDX
        Me.InitData(Sql, "plnprocid", oView, prepMode, prepIDX, strXML, "plnproctypeincenid", "description")

        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""PIDUDesParamID"" CAPTION=""Parameter Code Work Order""/><COL KEY=""RouteDesParamID"" CAPTION=""Parameter Code Routing""/>"
        myView.MainGrid.BindGridData(GenerateData("prodbasic", frmIDX), 0)
        myView.MainGrid.MainConf("CONSUMEHIDECOLSWIDTH") = False
        myView.MainGrid.MainConf("HIDECOLS") = myContext.Data.GenColList(myContext.Data.SelectCols(myView.MainGrid.myDS.Tables(0), "", "*"), "Descrip, Persons, ProdType1, ProdType2, ProdType3, Remark")
        myView.MainGrid.QuickConf("", True, "3-3-1-1-1-3", True)

        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateParamQual(Me, "plnproctypeincenid", frmIDX)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("ProcTypeDescrip")).Trim.Length = 0 Then Me.AddError("ProcTypeDescrip", "Enter Process Type Name")
        If Me.SelectedRow("PlnProcID") Is Nothing Then Me.AddError("PlnProcID", "Enter Plan Process")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then
            dic.Add("Plnproc", "Select Plnprocid, ProcName from Plnproc where Plnprocid = " & myRow("Plnprocid"))
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim ProcTypeDescrip As String = myRow("ProcTypeDescrip").ToString & " for: " & myUtils.cStrTN(ds.Tables("Plnproc").Rows(0)("ProcName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnProctypeincenid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnProctypeincenid")
                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "plnProctypeincenid=" & frmIDX)
                Me.GridViews("ParamQual").MainGrid.SaveChanges(, "idvalue=" & frmIDX & ",idfield=plnproctypeincenid")

                myContext.Provider.dbConn.CommitTransaction(ProcTypeDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ProcTypeDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "prodbasic"
                oRet.Data = GenerateData(dataKey, frmIDX)

        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "prodbasic"
                Dim sql As String = "Select * from prodbasic where plnproctypeincenid = " & myUtils.cValTN(ID)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

        End Select
        Return oRet.Data
    End Function
End Class




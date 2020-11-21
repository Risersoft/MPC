Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDUMatModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim vlist As New clsValueList
        vlist.Add(False, "Before Start")
        vlist.Add(True, "After End")
        Me.ValueLists.Add("AfterEnd", vlist)
        Me.AddLookupField("AfterEnd", "AfterEnd")

        Dim sql As String = "Select ItemId, ItemCode, ItemName, UnitName from invlistitems() order by ItemName"
        Me.AddLookupField("ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim Sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from pidumatbom where pidumatbomid = " & prepIDX
        Me.InitData(Sql, "parentbomid,prodbypidurouteid,consbypidurouteid", oView, prepMode, prepIDX, strXML)

        If myUtils.NullNot(myRow("consbypidurouteid")) Then myRow("plnpidurouteid") = myRow("prodbypidurouteid") Else myRow("plnpidurouteid") = myRow("consbypidurouteid")

        Sql = "select distinct plnPIDURouteID,SeqProcName from PlnPIDURoute where pidunitid in (select pidunitid from plnpiduroute where plnpidurouteid=" & myRow("plnpidurouteid") & ") order by seqprocname"
        Me.AddLookupField("ConsByPIDURouteID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "seqproc").TableName)
        Me.AddLookupField("ProdByPIDURouteID", "seqproc")

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim sql As String = "select plnPIDURouteID,SeqProcName from PlnPIDURoute where PlnPIDURouteid = " & myRow("PlnPIDURouteid")
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Dim PIDUMatDescrip As String = " Work Order Material for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("SeqProcName"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "pidumatbomid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("pidumatbomid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(PIDUMatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(PIDUMatDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmHeadTypeModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql = "select distinct prepgroup from matheadtype where len(isnull(prepgroup,''))>0 order by prepgroup"
        Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        Me.ValueLists.Add("prepgroup", myContext.SQL.VListFromTable(dt1))
        Me.AddLookupField("PrepGroup", "PrepGroup")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim Sql As String = "select * from MatHeadType where HeadTypeID = " & myUtils.cValTN(prepIDX)
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML, "HeadTypeID", "HeadType,MatList1Title")

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("HeadType")).Trim.Length = 0 Then Me.AddError("HeadType", "Please Enter Head Type")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim HeadTypeDescrip As String = myUtils.cStrTN(myRow("HeadType"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "HeadTypeId", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("HeadTypeId")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(HeadTypeDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(HeadTypeDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

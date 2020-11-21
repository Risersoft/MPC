Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdBasicModel
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
        Dim Sql As String
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0

        Sql = "select * from prodbasic where prodbasicid = " & prepIDX
        Me.InitData(Sql, "plnproctypeincenid", oView, prepMode, prepIDX, strXML)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("Descrip")).Trim.Length = 0 Then Me.AddError("Descrip", "Enter Description")
        If myUtils.cValTN(myRow("ProdType1")) = 0 Then Me.AddError("ProdType1", "Enter Production")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then
            dic.Add("prodtypeincen", "Select plnproctypeincenid, ProcTypeDescrip from plnproctypeincen where plnproctypeincenid = " & myRow("plnproctypeincenid"))
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim ProdBasicDescrip As String = " Basic Production: " & myRow("Descrip").ToString & " for: " & myUtils.cStrTN(ds.Tables("prodtypeincen").Rows(0)("ProcTypeDescrip"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "prodbasicid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("prodbasicid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ProdBasicDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ProdBasicDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

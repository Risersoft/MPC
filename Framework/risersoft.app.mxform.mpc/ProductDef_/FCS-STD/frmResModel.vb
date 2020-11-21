Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmResModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select shiftid, shift from shift order by shift"
        Me.AddLookupField("shiftid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "shift").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim Sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from plnresource where plnresourceid = " & prepIDX
        Me.InitData(Sql, "employeeid", oView, prepMode, prepIDX, strXML)

        If myUtils.cValTN(myRow("employeeid")) > 0 Then
            Sql = "Select * from hrplistemp() where employeeid =" & myUtils.cValTN(myRow("employeeid"))
            Me.AddDataSet("Emp", Sql)

            myRow("qty") = 1
        Else
            If myUtils.NullNot(myRow("shiftid")) Then myRow("shiftid") = 3
        End If

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("ResourceName")).Trim.Length = 0 Then Me.AddError("ResourceName", "Enter Name")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim ResDescrip As String = myRow("ResourceName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnresourceid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnresourceid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ResDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ResDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMat_SpItemModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "Select ItemId, ItemCode, ItemName, UnitName from invlistitems() order by ItemName"
        Me.AddLookupField("ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "Select * from MatListSpare where MatListSpareID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "PidUnitID,SoSpareID", oView, prepMode, prepIDX, strXML)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cValTN(myRow("ItemVMSID")) = 0 Then Me.AddError("ItemVMSID", "Select Item Specification")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim ds As DataSet, Sql As String
        VSave = False
        If Me.Validate Then
            Sql = "select * from PidUnit where PidUnitid = " & myRow("PidUnitid")
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Dim MatDescrip As String = " Spare Item for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PIDInfo")) & " for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO"))
            If myUtils.cValTN(myRow("ItemVMSID")) > 0 Then SetOrderNumDescrip(myRow.Row)
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "MatListSpareID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("MatListSpareId")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(MatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatDescrip, e.Message)
                    Me.AddException("", e)
                End Try
            End If
    End Function

    Private Sub SetOrderNumDescrip(r1 As DataRow)
        Dim Sql As String = "select ItemUnitID from InvListItemVMS() where ItemVMSID = " & myUtils.cValTN(r1("ItemVMSID"))
        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        r1("OrderNumDescrip") = myFuncs.CalcOrderNumDescrip(myContext, myUtils.cValTN(r1("ItemVMSID")), myUtils.cValTN(r1("Qty")), myUtils.cValTN(dt.Rows(0)("ItemUnitID")))
    End Sub
End Class

Imports risersoft.shared
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDUMatBOMAltModel
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
        sqlForm = "Select * from PIDUMatBOMAlt where PIDUMatBOMAltid=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "pidunitid,itemvmsid", oView, prepMode, prepIDX, strXML)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        dic.Add("PidUnit", "select PIDUnitID, PIDInfo, DescripWO from PidUnit where PidUnitid = " & myRow("PidUnitid"))
        dic.Add("Item", "Select ItemId, ItemVMSID, ItemCode, ItemName from InvListItemVMS() where ItemVMSID = " & myRow("ItemVMSID"))
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        Dim BOMAltDescrip As String = " Alternate BOM for: " & myUtils.cStrTN(ds.Tables("PidUnit").Rows(0)("PIDInfo")) & " for: " & myUtils.cStrTN(ds.Tables("PidUnit").Rows(0)("DescripWO")) & " for Item: " & myUtils.cStrTN(ds.Tables("Item").Rows(0)("ItemName"))
        Try
            myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PIDUMatBOMAltid", frmIDX)
            myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
            frmIDX = myRow("PIDUMatBOMAltid")
            frmMode = EnumfrmMode.acEditM
            myContext.Provider.dbConn.CommitTransaction(BOMAltDescrip, frmIDX)
            VSave = True
        Catch e As Exception
            myContext.Provider.dbConn.RollBackTransaction(BOMAltDescrip, e.Message)
            Me.AddError("", e.Message)
        End Try
    End Function
End Class




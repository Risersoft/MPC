Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSubCatSuppModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "Select VendorID, PartyName, VendorType  from PurListVendor() Order BY PartyName"
        Me.AddLookupField("VendorID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Vendor").TableName)
        Me.AddLookupField("MakeID", "Vendor")


        Dim vlist As New clsValueList
        vlist.Add("A")
        vlist.Add("DR")
        vlist.Add("Noted")
        Me.ValueLists.Add("Cat", vlist)
        Me.AddLookupField("Category", "Cat")

        Dim vlist1 As New clsValueList
        vlist1.Add("A")
        vlist1.Add("B")
        vlist1.Add("C")
        vlist1.Add("E")
        Me.ValueLists.Add("Rat", vlist1)
        Me.AddLookupField("RatDelivery", "Rat")
        Me.AddLookupField("RatPrice", "Rat")
        Me.AddLookupField("RatQuality", "Rat")
        Me.AddLookupField("RatResponse", "Rat")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim sql As String = "Select * from ItemSubCatSupp where SubCatSuppID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sql, "SubCatID", oView, prepMode, prepIDX, strXML, "MakeID")

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("MakeID") Is Nothing Then Me.AddError("MakeID", "Please Select Party")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            Dim Sql As String = "Select * from ItemSubCats where SubCatID = " & myRow("SubCatID")
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Dim SubCatDescrip As String = " Supplier Item for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("SubCatName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "SubCatSuppID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("SubCatSuppID")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(SubCatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(SubCatDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

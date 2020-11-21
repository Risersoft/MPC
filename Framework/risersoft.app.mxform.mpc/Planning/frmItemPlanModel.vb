Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmItemPlanModel
    Inherits clsFormDataModel
    Dim myViewML As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Supp")
        myViewML = Me.GetViewModel("ML")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String

        Sql = "Select ItemSizeID, ItemSize from ItemSizes Order by ItemSize"
        Me.AddLookupField("ItemSizeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Size").TableName)

        Sql = "Select CostingItemID,CostItemName,SubCatID from CostingItems order by SubCatID,CostItemName"
        Me.AddLookupField("CostingItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CostItem").TableName)

        Sql = "Select distinct SubcatId, SubCatName, UnitName, HasDefs, CostingType from invListItemSubCats()  order by SubCatName"
        Me.AddLookupField("SubcatId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Items").TableName)

        Sql = "Select VendorID, PartyName from purListVendor() order by PartyName"
        Me.AddLookupField("SupplierItem", "VendorID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Vendor").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "Select * from InvListItems() where ItemId = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            myView.MainGrid.QuickConf("Select SuppItemId, VendorId, ItemId, PartyName, Rate, perDC, SuppSpecs, IsApproved from purListSuppItems() where ItemId = " & frmIDX, True, "3-1-0.5-1.5-0.5", True)
            str1 = "<BAND IDFIELD=""SuppItemId"" TABLE=""SupplierItem"" INDEX=""0""><COL NOEDIT=""True"" KEY=""ItemId,VendorId,Rate,perDC,SuppSpecs,IsApproved""/></BAND>"
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            myViewML.Mode = EnumViewMode.acSelectM : myViewML.MultiSelect = True
            myViewML.MainGrid.QuickConf("Select ItemLevelId,ItemId,il.MatDepId,DepName,MinQty,ReOrderQty from ItemLevels as il inner join DepsMat as dm on dm.MatDepId= il.MatDepId where ItemId = %frmidx%", True, "2-1-1", True, "Minimum Levels")
            str1 = "<BAND IDFIELD=""ItemLevelId"" TABLE=""ItemLevels"" INDEX=""0""><COL KEY=""ItemId,MatDepId,MinQty,ReorderQty""/></BAND>"
            sql = "Select MatDepId,DepName from DepsMat where isStore=1 order by DepName"
            myContext.Data.ReverseTick(myViewML.MainGrid.myDS.Tables(0), sql, "MatDepId")
            myViewML.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.myRow("ItemName").ToString.Trim.Length = 0 Then Me.AddError("ItemName", "Please Select Item Name")
        If Me.myRow("ItemCode").ToString.Trim.Length = 0 Then Me.AddError("ItemCode", "Please Select Item Code")
        If Me.SelectedRow("SubCatID") Is Nothing Then Me.AddError("SubCatID", "Please Select Sub Category")
        myViewML.MainGrid.CheckValid("", "sysincl=true", , "<CHECK COND=""MinQty>0 or ReOrderQty>0"" MSG=""Please enter at least one qty""/>")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim ItemDescrip As String = " Planning Data for Code: " & myUtils.cStrTN(myRow("ItemCode")) & ", Name: " & myUtils.cStrTN(myRow("ItemName"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ItemId", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select ItemId,PurchasePrice,PurchPriceLastUpd,ItemCode,OldCode,OldName,ItemName,ShelfLife,SubCatId,CostingItemID,ItemSizeID,minOrderQty from Items Where ItemID is Null")
                frmIDX = myRow("itemid")
                Me.myView.MainGrid.SaveChanges(, "ItemId=" & frmIDX)
                Me.myViewML.MainGrid.SaveChanges(, "ItemId=" & frmIDX)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ItemDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ItemDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

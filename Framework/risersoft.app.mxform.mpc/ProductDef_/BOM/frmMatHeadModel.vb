Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatHeadModel
    Inherits clsFormDataModel
    Dim myViewPln As clsViewModel


    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SubCat")
        myViewPln = Me.GetViewModel("Pln")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String

        Sql = "select HeadTypeId, HeadType from MatHeadType order by HeadTypeId"
        Me.AddLookupField("HeadTypeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Heads").TableName)

        Sql = "select ItemUnitId, UnitName from ItemUnits order by UnitName"
        Me.AddLookupField("ItemUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Units").TableName)

        Sql = "Select MatDepId, DepName, WODate, CompletedOn from mmListDepsMat() where isnull(AcceptsMO,0)=1 order by DepName"
        Me.AddLookupField("MatDepId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "DepsMat").TableName)

        Dim vlist As New clsValueList
        vlist.Add(1, "Multiple VMS in One Item Code")
        vlist.Add(2, "One VMS only")
        vlist.Add(3, "Multiple Item Codes")
        Me.ValueLists.Add("SelectionType", vlist)
        Me.AddLookupField("SelectionType", "SelectionType")

        Dim dicMat = myContext.App.objAppExtender.dicMat
        If myUtils.cBoolTN(dicMat("des")) Then
            Sql = "select CostingItemId, CostItemName from CostingItems order by CostItemName"
            Me.AddLookupField("CostingItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Cost").TableName)

            Sql = "select ItemUnitId, UnitName from ItemUnits order by UnitName"
            Me.AddLookupField("CostingUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Units").TableName)

            Sql = "select DesParamId,ParamCode,ParamName from desParams where isMatParam=1 order by ParamCode"
            Me.AddLookupField("NADesParamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PAR").TableName)

            Sql = "select DesParamId,ParamCode,ParamName,riDesTableId from DesParams where isnull(isMatParam,0)=1 or isnull(isDesPiduParam,0)=1 order by ParamCode"
            Me.AddLookupField("RateDesParamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PARdt").TableName)

            Sql = "select Distinct HeadNumType from MatHeads where HeadNumType is Not Null order by HeadNumType"
            Me.ValueLists.Add("HeadNumType", myContext.SQL.VListFromTable(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)))
            Me.AddLookupField("HeadNumType", "HeadNumType")

            Dim vlist1 As New clsValueList
            vlist1.Add(0, "Defined in Head")
            vlist1.Add(1, "Selected Sub category")
            vlist1.Add(2, "Design Table Column")
            Me.ValueLists.Add("RemarkTypeCode", vlist1)
            Me.AddLookupField("RemarkTypeCode", "RemarkTypeCode")


            Dim vlist2 As New clsValueList
            vlist2.Add(0, "Not Selected / Manual")
            vlist2.Add(1, "Fixed Costing Item")
            vlist2.Add(2, "Param Table row Item")
            vlist2.Add(3, "Param Table row Costing Item")
            vlist2.Add(4, "Param Value")
            vlist2.Add(5, "Fixed Item")
            vlist2.Add(6, "Evaluate Formula Item")
            vlist2.Add(7, "Evaluate Formula Costing Item")
            Me.ValueLists.Add("CostRateCode", vlist2)
            Me.AddLookupField("CostRateCode", "CostRateCode")

            Dim vlist3 As New clsValueList
            vlist3.Add(0, "Not Selected / Manual")
            vlist3.Add(1, "Param Table row Item")
            vlist3.Add(2, "Fixed Item, Decide by Qty")
            vlist3.Add(3, "Search in sub category and items using parameters")
            vlist3.Add(4, "Param Value")
            vlist3.Add(5, "Evaluate Formula")
            Me.ValueLists.Add("ItemSelecType", vlist3)
            Me.AddLookupField("ItemSelecType", "ItemSelecType")


            Dim vlist4 As New clsValueList
            vlist4.Add(0, "Not Selected / Manual")
            vlist4.Add(1, "Fixed Qty if item is present")
            vlist4.Add(2, "Param Value")
            vlist4.Add(3, "Param Table Column")
            vlist4.Add(4, "Evaluate formula")
            Me.ValueLists.Add("CostQtyCode", vlist4)
            Me.AddLookupField("CostQtyCode", "CostQtyCode")


            Dim vlist5 As New clsValueList
            vlist5.Add(0, "Not Selected / Manual")
            vlist5.Add(1, "Fixed Qty if item is present")
            vlist5.Add(2, "Param Value")
            vlist5.Add(3, "Param Table Column")
            vlist5.Add(4, "Evaluate formula")
            vlist5.Add(5, "As Reqd, Evaluate formula")
            Me.ValueLists.Add("QtySelecType", vlist5)
            Me.AddLookupField("QtySelecType", "QtySelecType")


            Sql = "Select desTableColId,ColumnName, desTableId from desTableCols order by ColumnName"
            Me.AddLookupField("RateDesTableColID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "TableCol").TableName)
            Me.AddLookupField("RateDesTableCol2ID", "TableCol")
            Me.AddLookupField("CostQtyDesTableColID", "TableCol")
            Me.AddLookupField("MatDesTableColID", "TableCol")
            Me.AddLookupField("MatDesTableColID2", "TableCol")
            Me.AddLookupField("QtyDesTableColID", "TableCol")
            Me.AddLookupField("RemarkDesTableColID", "TableCol")

            Sql = "Select ItemId, ItemCode, ItemName, UnitName from invListItems() order by ItemName"
            Me.AddLookupField("FixedItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Items").TableName)
        End If
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String
        Me.FormPrepared = False
        sql = "select * from MatHeads where MatHeadId = " & myUtils.cValTN(prepIDX)
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML, "MatHeadId", "HeadCode,HeadName")

        If frmMode = EnumfrmMode.acAddM Then
            myRow("isFormatList1") = True
            myRow("isForCostingMats") = False
        End If

        myView.MainGrid.QuickConf("select MathdISCID, matheadid, mathdisc.subcatid, InitialCode, SubCatName from mathdisc inner join invlistitemsubcats() as ilisc on mathdisc.subcatid = ilisc.subcatid where matheadid = " & myUtils.cValTN(frmIDX), True, "1-4", True)
        str1 = "<BAND INDEX=""0"" TABLE=""MATHDISC"" IDFIELD=""MATHDISCID""><COL KEY=""matheadid, subcatid""/></BAND>"""
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        sql = "select matheadid,headname,headtype from deslistmatheads() where matheadid <> " & myUtils.cValTN(frmIDX) & " order by headtype,sortindex"
        Me.AddLookupField("ParentHeadID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PARhead").TableName)

        sql = "select plnseqprocmatid, MatHeadid,plnstdseqprocid,  AfterEnd, MarginDays, QtyFactor,ProdBySeqProcID from plnseqprocmat where matheadid =" & frmIDX
        myViewPln.MainGrid.QuickConf(sql, True, "3-2-1-1-3", True)
        myViewPln.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnseqprocmatid"" TABLE=""plnseqprocmat""><COL KEY=""plnstdseqprocid"" CAPTION=""Seq Proc"" LOOKUPSQL=""Select plnstdseqprocid, seqprocname from plnstdseqproc"" NOEDIT=""True""/><COL KEY=""Afterend"" CAPTION=""Type"" VLIST=""False;Before Start|True;After End""/><COL KEY=""MarginDays,QtyFactor,matheadid""/><COL KEY=""prodbyseqprocid"" CAPTION=""Produced By"" LOOKUPSQL=""Select plnstdseqprocid, seqprocname from plnstdseqproc order by seqprocname""/></BAND>", EnumEditType.acCommandAndEdit)

        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateParamTrans(Me, "MatHeadID", frmIDX)

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Dim dicMat = myContext.App.objAppExtender.dicMat
        If myUtils.cStrTN(myRow("HeadName")).Trim.Length = 0 Then Me.AddError("HeadName", "Enter Head Name")
        If Me.SelectedRow("HeadTypeID") Is Nothing Then Me.AddError("HeadTypeID", "Select a Head Type")
        If (myUtils.cBoolTN(myRow("IsForCostingMats")) = False) AndAlso (myUtils.cBoolTN(myRow("IsForMatList1")) = False) AndAlso (myUtils.cBoolTN(myRow("IsForMatList2")) = False) AndAlso (myUtils.cBoolTN(myRow("ForceInMatPlan")) = False) Then Me.AddError("IsForMatList1", "At least one Purpose should be selected")
        If myUtils.cBoolTN(dicMat("des")) Then Me.ValidateMatHeadDes()
        Return Me.CanSave
    End Function

    Public Function ValidateMatHeadDes() As Boolean
        '----------------Costing Items
        Select Case myUtils.cValTN(myRow("CostRateCode"))
            Case 1
                'fixed costing item
                If myUtils.cValTN(myRow("CostingItemID")) = 0 Then Me.AddError("CostingItemID", "Select Costing Item")
            Case 2, 3, 4
                'rate parameter
                If myUtils.cValTN(myRow("RateDesParamID")) = 0 Then Me.AddError("RateDesParamID", "Select Rate Parameter")
            Case 5
                'fixed item
                If myUtils.cValTN(myRow("FixedItemID")) = 0 Then Me.AddError("FixedItemID", "Select Item")
        End Select

        Select Case myUtils.cValTN(myRow("CostQtyCode"))
            Case 1
                'fixed qty
                If myUtils.cValTN(myRow("CostFixedQty")) = 0 Then Me.AddError("CostFixedQty", "Enter Fixed Qty")
            Case 2
                'qty parameter
                If myUtils.cValTN(myRow("CostQtyDesParamID")) = 0 Then Me.AddError("CostQtyDesParamID", "Select Qty Parameter")
        End Select

        '---------------Matlist1 
        Select Case myUtils.cValTN(myRow("ItemSelecType"))
            Case 1
                'item parameter
                If myUtils.cValTN(myRow("MatDesParamID")) = 0 Then Me.AddError("MatDesParamID", "Select Rate Parameter")
            Case 2
                'fixed  item
                If myUtils.cValTN(myRow("FixedItemID")) = 0 Then Me.AddError("FixedItemID", "Select Item")
            Case 3
                'search using parameters
        End Select

        Select Case myUtils.cValTN(myRow("QtySelecType"))
            Case 1
                'fixed qty
                If myUtils.cValTN(myRow("FixedQty")) = 0 Then Me.AddError("FixedQty", "Enter Fixed Qty")
            Case 2
                'qty parameter
                If myUtils.cValTN(myRow("QtyDesParamID")) = 0 Then Me.AddError("QtyDesParamID", "Select Qty Parameter")
        End Select
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim MatHeadDescrip As String = " Code: " & myRow("HeadCode").ToString & " Name: " & myRow("HeadName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "MatHeadId", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("MatHeadId")
                Me.myView.MainGrid.SaveChanges(, "MatHeadId=" & frmIDX)
                Me.myViewPln.MainGrid.SaveChanges(, "MatHeadId=" & frmIDX)
                Me.GridViews("ParamTrans").MainGrid.SaveChanges(, "idfield=MatHeadId,idvalue=" & frmIDX)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(MatHeadDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatHeadDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "subcat"
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf("Select SubCatId, InitialCode, SubCatName from invListItemSubCats() as ilisc order by SubCatName", True, "1-4")
                    Dim str1 As String = "<BAND IDFIELD=""SubCatId"" TABLE=""ItemSubCats"" INDEX=""0"">/></BAND>"
                    Model.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)
                Case "plnstdseqproc"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""plnstdseqprocid""/>")
            End Select
        End If
        Return Model
    End Function
End Class

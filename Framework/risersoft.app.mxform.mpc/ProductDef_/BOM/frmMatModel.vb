Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatModel
    Inherits clsFormDataModel
    Dim myVueSubCat, myVueItems, myVueBOM As clsViewModel
    Dim SelType As Integer

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ItemVMS")
        myVueSubCat = Me.GetViewModel("SubCat")
        myVueItems = Me.GetViewModel("Items")
        myVueBOM = Me.GetViewModel("BOM")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "select MatHeadId,HeadName,SelectionType,isFormatList1, isFormatList2 from MatHeads order by MatHeadId"
        Me.AddLookupField("MatHeadID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Heads").TableName)
        Me.AddLookupField("MatSelect", "MatHeadID", "Heads")


        Dim vlist As New clsValueList
        vlist.Add(0, "All Items")
        vlist.Add(1, "Items With Available Version")
        Me.ValueLists.Add("Show", vlist)
        Me.AddLookupField("MatSelect", "Show", "Show")

        sql = "Select ItemUnitID, UnitName from ItemUnits"
        Me.AddLookupField("ItemUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Units").TableName)
        Me.AddLookupField("ItemUnitID2", "Units")
        Me.AddLookupField("OrderQtyUnitID", "Units")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim sql As String = "select * from MatList1 where MatListId = " & prepIDX
        Me.InitData(sql, "PIDUnitID,MatHeadID", oView, prepMode, prepIDX, strXML)

        Dim vlist As New clsValueList
        If myUtils.cValTN(myRow("PIDUnitID")) > 0 Then
            For Each r1 As DataRow In myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select distinct tag from MatList1 where PIDUnitID = " & myUtils.cValTN(myRow("PIDUnitID")) & " order by tag").Tables(0).Select
                vlist.Add(myUtils.cStrTN(r1(0)))
            Next
            Me.ValueLists.Add("Tag", vlist)
            Me.AddLookupField("Tag", "Tag")
        End If

        If Not IsNothing(Me.SelectedRow("MatHeadID")) Then SelType = myUtils.cValTN(Me.SelectedRow("MatHeadID")("selectiontype"))

        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select PIDUnitID,PidInfo from deslistpidunittot() where PIDUnitID = " & myUtils.cValTN(myRow("PIDUnitID"))).Tables(0)
        If dt.Rows.Count > 0 Then
            Me.ModelParams.Add(New clsSQLParam("@pidinfo", "'" & myUtils.cStrTN(dt.Rows(0)("PidInfo")) & "'", GetType(String), False))
        End If

        BindDataTable(myUtils.cValTN(myRow("MatHeadID")), frmIDX)

        myVueSubCat.MainGrid.BindGridData(Me.dsForm, 1)
        myVueSubCat.MainGrid.QuickConf("", True, "1-4", True)

        myVueItems.MainGrid.BindGridData(myFuncsBase.AttributedItemsTable(myContext, dsForm.Tables("Items"), myVueSubCat.MainGrid.myDV.Table), 0)
        myVueItems.MainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(Me.myContext, myVueItems.MainGrid.myDV.Table.DataSet.Tables("attrib"))
        myVueItems.MainGrid.QuickConf("", True, "1-4-1-1-1-1-1", True)

        myView.MainGrid.BindGridData(Me.dsForm, 3)
        If SelType = 3 Then
            myView.MainGrid.MainConf("rhfactor") = 2
            myView.MainGrid.QuickConf("", True, "1-3-1-1-2-1-2-2-2-1.5", True)
            myRow("spec") = ""
        Else
            myView.MainGrid.MainConf("rhfactor") = 1
            myView.MainGrid.QuickConf("", True, "1-1-0-1-2-2-2-1.5", True)
        End If
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""MatListVMS"" IDFIELD=""MatListVMSID""><COL KEY=""ItemVMSId,MatListId""/><COL KEY=""SpecVMS"" CAPTION=""MatList1 Spec""/></BAND>", EnumEditType.acCommandAndEdit)

        FillBOMGrid(frmIDX)

        If frmMode = EnumfrmMode.acAddM Then
            Dim ForList1, ForList2 As Integer

            Dim ListIndex As Integer = myUtils.cValTN(Me.vBag("ListIndex"))
            If Not IsNothing(Me.SelectedRow("MatHeadID")) Then ForList1 = myUtils.cValTN(Me.SelectedRow("MatHeadID")("isForMatList1"))
            If Not IsNothing(Me.SelectedRow("MatHeadID")) Then ForList2 = myUtils.cValTN(Me.SelectedRow("MatHeadID")("isForMatList2"))
            If ListIndex > 0 Then
                myRow("ListIndex") = ListIndex
            ElseIf ForList1 AndAlso (Not ForList2) Then
                myRow("ListIndex") = 1
            ElseIf ForList2 AndAlso (Not ForList1) Then
                myRow("ListIndex") = 2
            End If
        End If
        myRow("QtyAsReq") = myUtils.cBoolTN(myRow("QtyAsReq"))

        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(MatHeadID As Integer, MatListID As Integer)
        Dim dic As New clsCollecString(Of String)
        dic.Add("SubCat", "Select distinct SubCatID,ItemUnitID,ItemUnitID2,OrderQtyUnitID,InitialCode,SubCatName from deslistitems() where MatHeadID = " & myUtils.cValTN(MatHeadID))
        dic.Add("Items", "Select distinct ItemID, MatSpec,SubCatID,ItemCode,ItemName From deslistitems() where ItemID in (Select distinct ItemID From deslistMatList1() where ItemID is Not NULL and MatListID = " & MatListID & ")")
        dic.Add("MatlistVMS", "Select distinct MatListID, VarPidUnitId as PidUnitID, PIDUnitItemVarID, VarNum, SubCatID, isCurrent,ItemVmsId,ItemID,SpecMatSpec, MatListVmsId,OrderNumDescrip,ItemCode, ItemName, SpecNum, RevNum, SpecVMS, Make, KanSpecs, SuppSpec, StdSpec, Packing from deslistMatList1() where ItemVmsId is not null and MatListID = " & MatListID)
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        For Each dt1 As DataTable In ds.Tables
            myUtils.AddTable(Me.dsForm, dt1, dt1.TableName)
        Next


    End Sub

    Private Sub FillBOMGrid(MatListID As Integer)
        Dim eConf1 As New clsBandConf(), eConf2 As New clsBandConf()
        Dim dic As New clsCollecString(Of String)

        dic.Add("MatlistVMS", "Select distinct MatListID, VarPidUnitId as PidUnitID, PIDUnitItemVarID, VarNum, SubCatID, isCurrent,ItemVmsId,ItemID,SpecMatSpec, MatListVmsId,OrderNumDescrip,ItemCode, ItemName, SpecNum, RevNum, SpecVMS, Make, KanSpecs, SuppSpec, StdSpec, Packing from deslistMatList1() where ItemVmsId is not null and MatListID = " & MatListID)
        dic.Add("BOM", "Select * from deslistmatlist1BOM() where MatListID = " & MatListID)
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        ds.Relations.Add("vmsbom", ds.Tables("MatlistVMS").Columns("MatListVMSId"), ds.Tables("BOM").Columns("MatListVMSId"))

        eConf1.QuickConf2("", True, "1-3-1-1-2-1-2-2-2-1.5", True)
        eConf2.QuickConf2("", True, "2.5-5-2-2-1-2-1", True, "Bill of Material")
        myVueBOM.MainGrid.cMainList.Clear()
        myVueBOM.MainGrid.cMainList.Add(eConf1)
        myVueBOM.MainGrid.cMainList.Add(eConf2)
        myVueBOM.MainGrid.MainConf("ComplexView") = True
        myVueBOM.MainGrid.BindGridData(ds)
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myRow("Spec").ToString.IndexOf("'") > 0 OrElse myRow("Spec").ToString.IndexOf("""") > 0 Then Me.AddError("Spec", "Cannot contain apostrophe")
        If myUtils.cValTN(myRow("ListIndex")) = 0 Then Me.AddError("ListIndex", "Select a MatList Index")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dt, dt1 As DataTable, dic As clsCollecString(Of Boolean) = myContext.App.objAppExtender.dicMat
        Dim ds As DataSet, Sql1 As String
        VSave = False
        If Me.Validate Then
            Sql1 = "select * from PidUnit where PidUnitid = " & myRow("PidUnitid")
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql1)
            Dim MatHeadDescrip As String = Me.SelectedRow("MatHeadID")("HeadName")
            Dim MatDescrip As String = " Material for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("PIDInfo")) & " for: " & myUtils.cStrTN(ds.Tables(0).Rows(0)("DescripWO")) & ", HeadName: " & MatHeadDescrip & ""

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "MatListId", frmIDX)
                myRow("NumSpecs") = myView.MainGrid.myDS.Tables("MatlistVMS").Select().Length
                myRow("NumCodes") = myContext.Data.SelectDistinct(myView.MainGrid.myDS.Tables("MatlistVMS"), "ItemId", True, , "").Rows.Count
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmMode = EnumfrmMode.acEditM
                frmIDX = myRow("MatListId")

                If (Not myUtils.cBoolTN(myRow("QtyAsReq"))) AndAlso myUtils.cBoolTN(dic("unit")) Then SetOrderNumDescrip(myUtils.cValTN(myRow("Qty")), myUtils.cValTN(myRow("ItemUnitID")), Me.dsForm.Tables("MatlistVMS"))
                myUtils.ChangeAll(Me.dsForm.Tables("MatlistVMS").Select, "MatListId=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(Me.dsForm.Tables("MatlistVMS"), "Select ItemVMSId, MatListId, SpecVMS, OrderNumDescrip from MatListVMS")

                Dim CheckItem As Boolean = myContext.SQL.ParamValue("@CheckItem", Me.ClientParams)
                If CheckItem Then
                    SelType = myUtils.cValTN(Me.SelectedRow("MatHeadID")("selectionType"))
                    If SelType = 3 Then
                        For Each r As DataRow In myView.MainGrid.myDS.Tables("MatlistVMS").Select()
                            If myUtils.cStrTN(r("SpecVMS")).Trim.Length > 0 Then myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "Update ItemVMS set SpecMatSpec = '" & r("SpecVMS") & "' where ItemVMSId = " & myUtils.cValTN(r("ItemVMSId")))
                        Next
                    Else
                        For Each r As DataRow In myContext.Data.SelectDistinct(myView.MainGrid.myDS.Tables("MatlistVMS"), "ItemID", False).Select()
                            myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "Update Items set MatSpec = '" & myUtils.cStrTN(myRow("Spec")) & "' where ItemId = " & myUtils.cValTN(r("ItemId")))
                        Next
                    End If
                End If

                Dim sql As String = "Select * from MatListVMSBom Where MatListVMSId in (select MatListVMSId from MatListVMS where MatListId = " & frmIDX & ")"
                dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                myUtils.DeleteRows(dt.Select)
                For Each r As DataRow In myView.MainGrid.myDS.Tables("MatlistVMS").Select()
                    dt1 = dt.Clone
                    myVMSBOM.BuildBOMdt(myContext, dt1, r("ItemVMSId"))
                    myUtils.ChangeAll(dt1.Select, "MatListVMSId=" & r("MatListVMSId"))
                    myUtils.CopyRows(dt1.Select, dt)
                Next

                myContext.Provider.objSQLHelper.SaveResults(dt, sql)

                FillBOMGrid(frmIDX)
                myContext.Provider.dbConn.CommitTransaction(MatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "itemsitemvms"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select ETOPIDUnitIDCSV from PIDUnit where PIDUnitID = @PIDUnitID", Params)
                    Dim rPIDU As DataRow = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0).Rows(0)
                    Dim SelType As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SelType", Params))
                    Dim ItemIDCSV As String = myUtils.cStrTN(myContext.SQL.ParamValue("@ItemIDCSV", Params))
                    Dim strVMS, strItem As String

                    If SelType = 1 Then
                        If ItemIDCSV <> 0 Then strVMS = " and ItemVMSID Not in (@ItemVMSIDCSV) and ItemID in (@ItemIDCSV)" Else strVMS = " and ItemVMSID Not in (@ItemVMSIDCSV)"
                        If ItemIDCSV <> 0 Then strItem = " and ItemID in (@ItemIDCSV)" Else strItem = ""
                    ElseIf SelType = 3 Then
                        strVMS = " and ItemVMSID Not in (@ItemVMSIDCSV)"
                        strItem = ""
                    End If


                    Dim Sql1 As String = myContext.SQL.PopulateSQLParams("select itemvmsid,iscurrent,PIDUnitItemVarID, SubCatID,PIDUnitID,VarNum,itemid,specmatspec, ItemCode, ItemName, SpecNum, RevNum,  Make, KanSpecs, SuppSpec, Packing from InvListItemVMS()  where SubCatID = @SubCatID " & strVMS & " and (PIDUnitID = @PIDUnitID or PIDUnitID is NULL or PIDUnitID in (" & IIf(myUtils.cStrTN(rPIDU(0)).Trim = "", "0", myUtils.cStrTN(rPIDU(0))) & "))", Params)
                    Dim Sql2 As String = myContext.SQL.PopulateSQLParams("select itemid,subcatid,MatSpec,ItemCode,ItemName from invListItems() where SubCatID = @SubCatID " & strItem, Params)
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("ItemVMS", Sql1)
                    dic.Add("Items", Sql2)
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            End Select
        End If
        Return oRet
    End Function

    Private Sub SetOrderNumDescrip(Qty As Decimal, QtyUnitID As Integer, dt As DataTable)
        For Each r As DataRow In dt.Select()
            r("OrderNumDescrip") = myFuncs.CalcOrderNumDescrip(myContext, myUtils.cValTN(r("ItemVMSID")), Qty, QtyUnitID)
        Next
    End Sub
End Class

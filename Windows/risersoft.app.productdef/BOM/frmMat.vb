Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions
Imports risersoft.shared.portable

Public Class frmMat
    Inherits frmMax
    Dim myVueSubCat, myVueItems, myVueBOM As New clsWinView
    Dim selType As Integer

    Public Sub initForm()
        myVueSubCat.SetGrid(Me.UltraGridSubCat)
        myVueItems.SetGrid(Me.UltraGridItems)
        myView.SetGrid(Me.UltraGridItemVMS)
        myVueBOM.SetGrid(Me.UltraGridBOM)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ItemVMS"))
            myVueSubCat.PrepEdit(Me.Model.GridViews("SubCat"))
            myVueItems.PrepEdit(Me.Model.GridViews("Items"))
            If selType <> 1 Then myVueItems.mainGrid.myGrid.UpdateMode = UpdateMode.OnCellChangeOrLostFocus

            If selType = 3 Then
                myVueItems.mainGrid.HighlightRows()
                AddHandler myVueItems.mainGrid.myGrid.AfterCellUpdate, AddressOf UltraGridItems_AfterCellUpdate
                Me.txt_Spec.Enabled = False
            Else
                AddHandler myVueItems.mainGrid.myGrid.AfterSelectChange, AddressOf UltraGridItems_AfterSelectChange
                Me.txt_Spec.Enabled = True
            End If
            AddHandler myView.mainGrid.myGrid.AfterCellUpdate, AddressOf UltraGridItemVMS_AfterCellUpdate

            myVueBOM.GenView(Me.Model.GridViews("BOM"), EnumViewCallType.acNormal)
            myWinSQL.AssignCmb(Me.dsCombo, "Heads", "", Me.cmb_MatHeadID)

            myWinSQL.AssignCmb(Me.dsCombo, "Units", "", Me.cmb_ItemUnitID)
            myWinSQL.AssignCmb(Me.dsCombo, "Units", "", Me.cmb_BaseUnitID)
            myWinSQL.AssignCmb(Me.dsCombo, "Units", "", Me.cmb_BaseUnitID2)
            Return True
        End If
        Return False
    End Function

    Protected Friend Function SelectMatHeadID() As Integer
        Dim f As New frmGrid
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(Me.vBag("PidUnitId")), GetType(Integer), False))
        Dim ds As DataSet = Me.Controller.DataProvider.LoadAppData(myWinApp.Info, "matheads", Params, False).Result.Data

        f.myView.mainGrid.BindView(ds, , 0)
        f.myView.mainGrid.QuickConf("", True, "1", True, "Unused Heads")
        If f.ShowDialog = DialogResult.OK Then Return f.myView.mainGrid.myGrid.ActiveRow.Cells("MatHeadId").Value

    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Me.InitData("", "", oview, prepMode, prepIdx, strXML)
        If frmMode = EnumfrmMode.acAddM AndAlso myUtils.cValTN(Me.vBag("MatHeadId")) = 0 Then
            Me.vBag("MatHeadId") = Me.SelectMatHeadID
            strXML = Me.Controller.Data.VarBagXML(Me.vBag)
        End If

        Dim objModel As frmMatModel = Me.InitData("frmMatModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.txt_Qty.Enabled = Not myUtils.cBoolTN(myRow("QtyAsReq"))

            If myUtils.cValTN(myRow("PidUnitId")) > 0 Then
                Me.cmb_Tag.ValueList = Me.Model.ValueLists("Tag").ComboList
            End If

            If myUtils.cValTN(myRow("MatHeadId")) > 0 Then
                Me.cmb_MatHeadID.Value = myRow("MatHeadId")
                selType = myUtils.cValTN(Me.cmb_MatHeadID.SelectedRow.Cells("SelectionType").Value)

                If frmMode = EnumfrmMode.acAddM Then
                    Dim listindex As Integer = myUtils.cValTN(Me.vBag("listIndex"))
                    Dim forlist1 As Integer = myUtils.cValTN(Me.cmb_MatHeadID.SelectedRow.Cells("isFormatList1").Value)
                    Dim forlist2 As Integer = myUtils.cValTN(Me.cmb_MatHeadID.SelectedRow.Cells("isFormatList2").Value)
                    If listindex > 0 Then
                        Me.cmb_listindex.ReadOnly = True
                    ElseIf forlist1 AndAlso (Not forlist2) Then
                        Me.cmb_listindex.ReadOnly = True
                    ElseIf forlist2 AndAlso (Not forlist1) Then
                        Me.cmb_listindex.ReadOnly = True
                    Else
                        Me.cmb_listindex.ReadOnly = False
                    End If
                End If
                If selType = 0 Then selType = 1
                Dim str As String = myUtils.cStrTN(myWinSQL2.ParamValue("@pidinfo", Me.Model.ModelParams))
                Me.Text = "Material for " & str : Me.txt_pidinfo.Text = str

                SetSubCatFilterAndVMSLabel()
                If myVueSubCat.mainGrid.myDv.Count > 0 Then
                    Me.myVueSubCat.mainGrid.myGrid.ActiveRow = Me.myVueSubCat.mainGrid.myGrid.GetRow(ChildRow.First)
                    Me.myVueSubCat.mainGrid.myGrid.ActiveRow.Selected = True
                End If
                myRow("IsManual") = True    'for auto matlist1. Auto wont delete anything that has been added/modified manually
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.myVueSubCat.mainGrid.myGrid.ActiveRow Is Nothing Then myRow("SubCatId") = DBNull.Value Else myRow("SubCatId") = Me.myVueSubCat.mainGrid.myGrid.ActiveRow.Cells("SubCatId").Value
            Me.Model.ClientParams.Clear()
            Me.Model.ClientParams.Add(New clsSQLParam("@CheckItem", myUtils.cBoolTN(CheckItem.Checked), GetType(Boolean), False))
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (selType = 2 AndAlso myView.mainGrid.myDv.Table.Select.Length = 0) OrElse (selType <> 2) Then
            myVueSubCat.ContextRow = myVueSubCat.mainGrid.ActiveRow
            If Not myRow Is Nothing AndAlso Not myVueSubCat.ContextRow Is Nothing Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@SelType", selType, GetType(Integer), False))
                Params.Add(New clsSQLParam("@PIDUnitID", myUtils.cValTN(myRow("PIDUnitID")), GetType(Integer), False))
                Params.Add(New clsSQLParam("@SubCatID", myUtils.cValTN(myVueSubCat.ContextRow.CellValue("SubCatID")), GetType(Integer), False))
                Params.Add(New clsSQLParam("@ItemIDCSV", myUtils.MakeCSV(Me.myVueItems.mainGrid.myDv.Table.Select, "ItemID"), GetType(Integer), True))
                Params.Add(New clsSQLParam("@ItemVMSIDCSV", myUtils.MakeCSV(Me.myView.mainGrid.myDv.Table.Select, "ItemVMSID"), GetType(Integer), True))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("itemsitemvms", Params)
                If oRet.Success Then
                    Dim f As New frmMatSelect
                    f.ds = oRet.Data
                    If f.PrepForm(Me.myVueSubCat, EnumfrmMode.acAddM, "", "<PARAMS MATHEADID=""" & myRow("matheadid") & """ SubCatID=""" & myRow("SubCatID") & """/>") Then
                        If f.ShowDialog() = DialogResult.OK Then
                            If selType = 2 Then
                                Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(f.myView.mainGrid.myGrid.ActiveRow)
                                Dim rr() As DataRow = Me.myView.mainGrid.myDv.Table.Select("ItemVMSID = " & myUtils.cValTN(r1("ItemVMSID")) & "")
                                If rr.Length = 0 Then
                                    myUtils.CopyOneRow(r1, myView.mainGrid.myDv.Table)
                                End If
                            Else
                                For Each r1 As DataRow In f.myView.mainGrid.myDv.Table.Select("ItemVMSID Not in (" & myUtils.MakeCSV(Me.myView.mainGrid.myDv.Table.Select, "ItemVMSID") & ")  and SysIncl = 1")
                                    myUtils.CopyOneRow(r1, myView.mainGrid.myDv.Table)
                                Next
                            End If

                            Dim r2 As DataRow = win.myWinUtils.DataRowFromGridRow(f.myViewItems.mainGrid.myGrid.ActiveRow)
                            Dim rr1() As DataRow = Me.myVueItems.mainGrid.myDv.Table.Select("ItemID = " & myUtils.cValTN(r2("ItemID")) & "")
                            If rr1.Length = 0 Then
                                myUtils.CopyOneRow(r2, myVueItems.mainGrid.myDv.Table)
                            End If

                            SetSubCatFilterAndVMSLabel()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UltraGridSubCat_BeforeRowDeactivate(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UltraGridSubCat.BeforeRowDeactivate
        If myVueItems.mainGrid.myDv.Count > 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Not IsNothing(myView.mainGrid.myGrid.ActiveRow) Then
            myView.mainGrid.UpdateData()
            myVueItems.mainGrid.UpdateData()

            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
            Dim rr() As DataRow = Me.myView.mainGrid.myDv.Table.Select("ItemID = " & myUtils.cValTN(r1("ItemID")) & "")
            If MsgBox("Are you sure?" & vbCrLf & "Do you want to Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                If rr.Length = 1 Then
                    Dim rr1() As DataRow = Me.myVueItems.mainGrid.myDv.Table.Select("ItemID = " & myUtils.cValTN(r1("ItemID")) & "")
                    r1.Delete()
                    rr1(0).Delete()
                Else
                    r1.Delete()
                End If
                SetSubCatFilterAndVMSLabel()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        If Not r1 Is Nothing Then
            If myUtils.cValTN(r1("PIDUnitID")) > 0 Then
                If myUtils.cValTN(r1("VarNum")) > 0 Then
                    Dim f As New frmETOItem
                    If f.PrepForm(Me.myView, EnumfrmMode.acEditM, myUtils.cValTN(r1("PIDUnitItemVarID")), "<PARAMS ItemId=""" & myUtils.cValTN(r1("ItemId")) & """ PidUnitId=""" & myUtils.cValTN(r1("PidUnitId")) & """/>") Then
                        f.ShowDialog()
                        myUtils.MergeDataRow(f.f2.myRow.Row, r1)
                    End If
                Else
                    Dim f As New frmSpecs2
                    If f.PrepForm(Me.myView, EnumfrmMode.acEditM, myUtils.cValTN(r1("ItemVMSId")), "<PARAMS ItemId=""" & myUtils.cValTN(r1("ItemId")) & """ SubCatID=""" & myUtils.cValTN(r1("SubCatID")) & """ RevNum=""" & myUtils.cValTN(r1("RevNum")) & """ SpecNum=""" & myUtils.cValTN(r1("SpecNum")) & """/>") Then
                        f.ShowDialog()
                        myUtils.MergeDataRow(f.myRow.Row, r1)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UltraGridSubCat_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGridSubCat.AfterSelectChange
        Dim str1 As String = ""
        If Not Me.myVueSubCat.mainGrid.ActiveRow Is Nothing Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.myVueSubCat.mainGrid.myGrid.ActiveRow)
            SetUnitID(r1)
            myVueItems.mainGrid.myDv.RowFilter = "SubCatId=" & myUtils.cValTN(r1("SubCatId"))
            myVueItems.mainGrid.myDv.Sort = "ItemCode"
            If myVueItems.mainGrid.myDv.Count > 0 Then
                Me.myVueItems.mainGrid.myGrid.ActiveRow = Me.myVueItems.mainGrid.myGrid.GetRow(ChildRow.First)
                Me.myVueItems.mainGrid.myGrid.ActiveRow.Selected = True
            End If
            str1 = myAttribBase.ParamWidthString(Me.Controller, myVueItems.mainGrid.myDv.Table.DataSet.Tables("attrib"), "SubCatId", r1("SubCatId"))
            myVueItems.mainGrid.QuickConf("", True, "1-4" & str1, True)
        End If
    End Sub

    Private Sub SetUnitID(r1 As DataRow)
        cm.EndCurrentEdit()
        If Not myUtils.NullNot(r1) Then
            If Not myUtils.NullNot(r1("OrderQtyUnitID")) Then
                myRow("ItemUnitId") = myUtils.cValTN(r1("OrderQtyUnitID"))
            Else
                myRow("ItemUnitId") = myUtils.cValTN(r1("ItemUnitId"))
            End If
            cmb_BaseUnitID.Value = myUtils.cValTN(r1("ItemUnitId"))
            cmb_BaseUnitID2.Value = myUtils.cValTN(r1("ItemUnitId2"))
        End If
    End Sub

    Private Sub SetSubCatFilterAndVMSLabel()
        If myVueItems.mainGrid.myDv.Count > 0 Then
            myVueSubCat.mainGrid.myDv.RowFilter = "SubCatID = " & myVueItems.mainGrid.myDv.Table.Rows(0)("SubCatID") & ""
        Else
            myVueSubCat.mainGrid.myDv.RowFilter = ""
        End If

        If myVueItems.mainGrid.myDv.Table.Select.Length > 0 Then Me.lblItem.Text = myVueItems.mainGrid.myGrid.Rows.Count & " Items" Else Me.lblItem.Text = "Select Item"
        If myView.mainGrid.myDv.Table.Select.Length > 0 Then Me.lblVMS.Text = myView.mainGrid.myGrid.Rows.Count & " Specs" Else Me.lblVMS.Text = "Select Spec"
    End Sub

    Private Sub UltraGridItems_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        If selType <> 3 Then
            Dim gr As clsRow = myVueItems.mainGrid.ActiveRow
            If Not gr Is Nothing Then
                Me.txt_Spec.Text = myUtils.cStrTN(gr.CellValue("MatSpec"))
            End If
        End If
    End Sub

    Private Sub chk_QtyAsReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_QtyAsReq.CheckedChanged
        If myUtils.cBoolTN(Me.chk_QtyAsReq.Checked) Then
            Me.txt_Qty.Text = 0
            Me.txt_Qty.Enabled = False
        Else
            Me.txt_Qty.Enabled = True
        End If
    End Sub

    Private Sub UltraGridItemVMS_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        If (Not e.Cell Is Nothing) Then
            If e.Cell.Value = True Then
                myView.mainGrid.myGrid.UpdateData()
                If myUtils.cStrTN(e.Cell.Row.Cells("SpecMatSpec").Value).Trim.Length > 0 Then Me.txt_Spec.Text = e.Cell.Row.Cells("SpecMatSpec").Value
            End If
        End If
    End Sub

    Private Sub UltraGridItems_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        If selType = 3 Then
            If Me.txt_Spec.Text = "" Then Me.txt_Spec.Text = myUtils.cStrTN(Me.myVueItems.mainGrid.ActiveRow.CellValue("MatSpec"))
        End If
    End Sub

    Private Sub UltraGridItems_AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridItems.AfterRowActivate
        Dim gr As clsRow = myVueItems.mainGrid.ActiveRow
        If Not gr Is Nothing Then
            myView.mainGrid.myDv.RowFilter = "ItemID = " & myUtils.cValTN(gr.CellValue("ItemID")) & ""
        End If
    End Sub
End Class
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmMatHead
    Inherits frmMax
    Dim dicMat As clsCollecString(Of Boolean)
    Dim fTrans As frmDesParamTrans, fParam As frmDesParamFieldList2
    Dim myViewPln As New clsWinView, CodeSys As New clsCodeSystem
    Dim dvRateCol, dvRateCol2, dvCostQtyCol, dvMatCol, dvMatQtyCol, dvMatCol2, dvRemCol, dvMatDep As DataView

    Private Sub InitForm()
        myView.SetGrid(UltraGrid1)
        myViewPln.SetGrid(Me.UltraGrid3)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myWinApp.objAppExtender.InitDesignData(Me.Controller, False)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMatHeadModel = Me.InitData("frmMatHeadModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If myUtils.cBoolTN(dicMat("des")) Then
                fTrans = New frmDesParamTrans
                If fTrans.PrepFormRow(Me) Then
                    fTrans.AddtoTab(Me.UltraTabControl1, "trans", True)
                Else
                    fTrans = Nothing
                    Me.UltraTabControl1.Tabs("trans").Visible = False
                End If
                fParam = New frmDesParamFieldList2
                If fParam.PrepFormRow(Me, "MatHeadId", myFuncs.FormulaFields("MatHeadId")) Then
                    fParam.AddtoTab(Me.UltraTabControl1, "formula", True)
                Else
                    fParam = Nothing
                    Me.UltraTabControl1.Tabs("formula").Visible = False
                End If
                Me.UltraTabControl1.Tabs("auto1").Visible = True
                Me.UltraTabControl1.Tabs("auto2").Visible = True
                If frmMode = EnumfrmMode.acEditM OrElse myUtils.cValTN(Me.CopyIDX) > 0 Then
                    Me.cmb_FixedItemID.Value = myRow("fixeditemid")
                    Me.CodeSys.HandleCombo(Me.cmb_FixedItemID)
                End If
            Else
                Me.UltraTabControl1.Tabs("trans").Visible = False
                Me.UltraTabControl1.Tabs("auto1").Visible = False
                Me.UltraTabControl1.Tabs("auto2").Visible = False
                Me.UltraTabControl1.Tabs("formula").Visible = False
            End If

            HandleDate(myUtils.cDateTN(myRow("OpenedOn"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("SubCat"), , Me.btnDelSub)
            myViewPln.PrepEdit(Me.Model.GridViews("Pln"))

            myWinSQL.AssignCmb(Me.dsCombo, "Heads", "", Me.cmb_HeadTypeID)
            myWinSQL.AssignCmb(Me.dsCombo, "Units", "", Me.cmb_ItemUnitID)
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "DepsMat", "", Me.cmb_matdepid,, 2)
            cmb_SelectionType.ValueList = Me.Model.ValueLists("SelectionType").ComboList

            dicMat = myWinApp.objAppExtender.dicMat
            If myUtils.cBoolTN(dicMat("des")) Then
                myWinSQL.AssignCmb(Me.dsCombo, "Cost", "", Me.cmb_CostingItemID)
                myWinSQL.AssignCmb(Me.dsCombo, "Units", "", Me.cmb_CostingUnitID)

                Me.cmb_NADesParamID.DropDownWidth = Me.cmb_NADesParamID.Width * 2
                myWinSQL.AssignCmb(Me.dsCombo, "PAR", "", Me.cmb_NADesParamID, "<STRWIDTH>0-1-2</STRWIDTH>")

                Me.cmb_RateDesParamID.DropDownWidth = Me.cmb_RateDesParamID.Width * 2
                myWinSQL.AssignCmb(Me.dsCombo, "PARdt", "", Me.cmb_RateDesParamID, "<STRWIDTH>0-1-2</STRWIDTH>")
                For Each cmb As UltraCombo In New UltraCombo() {Me.cmb_CostQtyDesParamID, Me.cmb_CostQtyDesParam2ID, Me.cmb_MatDesParamID, Me.cmb_QtyDesParamID, Me.cmb_QtyDesParam2ID}
                    cmb.DropDownWidth = cmb.Width * 2
                    myWinSQL.AssignCmb(Me.dsCombo, "PARdt", "", cmb, "<STRWIDTH>0-1-2</STRWIDTH>")
                Next

                cmb_HeadNumType.ValueList = Me.Model.ValueLists("HeadNumType").ComboList
                cmb_RemarkTypeCode.ValueList = Me.Model.ValueLists("RemarkTypeCode").ComboList
                cmb_CostRateCode.ValueList = Me.Model.ValueLists("CostRateCode").ComboList
                cmb_ItemSelecType.ValueList = Me.Model.ValueLists("ItemSelecType").ComboList

                cmb_CostQtyCode.ValueList = Me.Model.ValueLists("CostQtyCode").ComboList
                cmb_QtySelecType.ValueList = Me.Model.ValueLists("QtySelecType").ComboList

                dvRateCol = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_RateDesTableColID, , 2)
                dvRateCol2 = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_RateDesTableCol2ID, , 2)
                dvCostQtyCol = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_CostQtyDesTableColID, , 2)
                dvMatCol = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_MatDesTableColID, , 2)
                dvMatCol2 = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_MatDesTableColID2, , 2)
                dvMatQtyCol = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_QtyDesTableColID, , 2)
                dvRemCol = myWinSQL.AssignCmb(Me.dsCombo, "TableCol", "", Me.cmb_RemarkDesTableColID, , 2)

                Me.CodeSys.SetConf(dsCombo.Tables("Items"), Me.cmb_FixedItemID, Me.cmb_ItemName, Me.combo_ItemUnit)

                Me.cmb_ParentHeadID.DropDownWidth = Me.cmb_ParentHeadID.Width * 2
                myWinSQL.AssignCmb(Me.dsCombo, "PARhead", "", Me.cmb_ParentHeadID, "<STRWIDTH>0-1-2</STRWIDTH>")
            End If
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If (fTrans IsNot Nothing) AndAlso (Not fTrans.ValidateData) Then WinFormUtils.AddError(fTrans, "Translation Parameter Errors")
        If (fParam IsNot Nothing) AndAlso (Not fParam.ValidateData) Then WinFormUtils.AddError(fParam, "Field Formula Errors")
        If Me.ValidateData() Then
            If Not fParam Is Nothing Then fParam.VSave()
            If Me.SaveModel() Then
                If Not fTrans Is Nothing Then fTrans.VSave()
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub cmb_RateDesParamID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_RateDesParamID.ValueChanged
        Dim gRow As UltraGridRow
        If Me.FormPrepared Then
            gRow = Me.cmb_RateDesParamID.SelectedRow
            If gRow Is Nothing Then dvRateCol.RowFilter = "0=1" Else dvRateCol.RowFilter = "DesTableId=" & myUtils.cValTN(gRow.Cells("riDesTableId").Value)
            dvRateCol2.RowFilter = dvRateCol.RowFilter
        End If
    End Sub

    Private Sub cmb_CostQtyDesParamID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CostQtyDesParamID.ValueChanged
        Dim gRow As UltraGridRow
        If Me.FormPrepared Then
            gRow = Me.cmb_CostQtyDesParamID.SelectedRow
            If gRow Is Nothing Then dvCostQtyCol.RowFilter = "0=1" Else dvCostQtyCol.RowFilter = "DesTableId=" & myUtils.cValTN(gRow.Cells("riDesTableId").Value)
        End If
    End Sub

    Private Sub cmb_MatDesParamID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_MatDesParamID.ValueChanged
        Dim gRow As UltraGridRow
        If Me.FormPrepared Then
            gRow = Me.cmb_MatDesParamID.SelectedRow
            If gRow Is Nothing Then dvMatCol.RowFilter = "0=1" Else dvMatCol.RowFilter = "DesTableId=" & myUtils.cValTN(gRow.Cells("riDesTableId").Value)
            dvRemCol.RowFilter = dvMatCol.RowFilter
            dvMatCol2.RowFilter = dvMatCol.RowFilter
        End If
    End Sub

    Private Sub cmb_QtyDesParamID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_QtyDesParamID.ValueChanged
        Dim gRow As UltraGridRow
        If Me.FormPrepared Then
            gRow = Me.cmb_QtyDesParamID.SelectedRow
            If gRow Is Nothing Then dvMatQtyCol.RowFilter = "0=1" Else dvMatQtyCol.RowFilter = "DesTableId=" & myUtils.cValTN(gRow.Cells("riDesTableId").Value)
        End If
    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        Dim f As New frmGrid, r1, r2 As DataRow
        Dim Params As New List(Of clsSQLParam)
        Dim Model As clsViewModel = Me.GenerateParamsModel("subcat", Params)
        f.myView.PrepEdit(Model)
        If f.ShowDialog = DialogResult.OK Then
            For Each r1 In f.myView.mainGrid.myDS.Tables(0).Select("sysincl=1")
                If Me.DuplicatesOK(myView.mainGrid, "SubCatId", myUtils.cValTN(r1("SubCatId")), "") = MsgBoxResult.No Then
                    MsgBox("Item Already Present", MsgBoxStyle.Information, myWinApp.Vars("appname"))
                Else
                    r2 = win.myWinUtils.CopyOneGridRow(win.myWinUtils.FindRow(f.myView.mainGrid.myGrid, "SubCatId", myUtils.cValTN(r1("SubCatId"))), MyBase.myView.mainGrid.myDS.Tables(0))
                End If
            Next
        End If
    End Sub

    Private Sub btnAddSeqProc_Click(sender As Object, e As EventArgs) Handles btnAddSeqProc.Click
        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = Me.AdvancedSelect("plnstdseqproc", Params)
        If (Not rr Is Nothing) AndAlso (rr.Length > 0) Then
            For Each r1 As DataRow In rr
                myUtils.CopyOneRow(r1, myViewPln.mainGrid.myDS.Tables(0))
            Next
        End If
    End Sub

    Private Sub btnDelSeqProc_Click(sender As Object, e As EventArgs) Handles btnDelSeqProc.Click
        myViewPln.mainGrid.ButtonAction("del")
    End Sub

    Private Sub dt_OpenedOn_Leave(sender As Object, e As EventArgs) Handles dt_OpenedOn.Leave
        HandleDate(dt_OpenedOn.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class
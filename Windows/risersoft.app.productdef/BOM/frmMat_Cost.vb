Imports risersoft.app.mxform
Public Class frmMat_Cost
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("SubCat"))

            myWinSQL.AssignCmb(Me.dsCombo, "Heads", "", Me.cmb_MatHeadID)
            Me.codesys.SetConf(NewModel.dsCombo.Tables("items"), Me.cmb_ItemID, Me.cmb_ItemName)
            myWinSQL.AssignCmb(Me.dsCombo, "CostingItem", "", Me.cmb_CostingItemID)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMat_CostModel = Me.InitData("frmMat_CostModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If myUtils.cValTN(myRow("ItemID")) > 0 Then
                Me.cmb_ItemID.Value = myUtils.cValTN(myRow("ItemID"))
                codesys.HandleCombo(Me.cmb_ItemID)
            End If

            If myUtils.cValTN(myRow("MatHeadID")) > 0 Then
                Me.cmb_MatHeadID.Value = myRow("MatHeadID")
                Me.Text = Me.GenerateIDOutput("text", myUtils.cValTN(myRow("PidUnitID"))).Description
                myView.mainGrid.ActiveRow = myView.mainGrid.FindRow("SubCatID=" & myUtils.cValTN(myRow("SubCatID")), myView.mainGrid.myDS)
            End If

            Me.HandleManual(myUtils.cBoolTN(myRow("ismanual")))
            Me.FormPrepared = True
        End If
            Return Me.FormPrepared
    End Function
    Protected Friend Sub HandleManual(IsManual As Boolean)
        Me.btnSelect.Enabled = IsManual
        Me.txt_Qty.ReadOnly = (Not IsManual)
        Me.txt_Rate.ReadOnly = (Not IsManual)
    End Sub
    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim gr As clsRow = myView.mainGrid.ActiveRow
        If Not gr Is Nothing Then
            Dim r1 As DataRow = myUtils.DataRowFromGridRow(gr)
            myRow("SubCatId") = myUtils.cValTN(r1(("SubCatId")))
            Select Case myUtils.cValTN(r1("costingtype"))
                Case 2
                    Dim rr() As DataRow = Me.dsCombo.Tables("costingitem").Select("costingitemid=" & myUtils.cValTN(r1("costingitemid")))
                    If rr.Length > 0 Then Me.SelectCostingItem(rr(0))
                Case 1, 3
                    Dim f As New frmGrid
                    ShowFrmGrid(f, r1)
                    If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.SelectCostingItem(myUtils.DataRowFromGridRow(f.myView.ContextRow))
                Case 4
                    Dim f As New frmGrid
                    ShowFrmGrid(f, r1)
                    If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.SelectItem(myUtils.DataRowFromGridRow(f.myView.ContextRow))
            End Select
        End If
    End Sub

    Private Sub ShowFrmGrid(f As frmGrid, r1 As DataRow)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@subcatid", myUtils.cValTN(r1("SubCatId")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@costingtype", myUtils.cValTN(r1("CostingType")), GetType(Integer), False))
        Dim Model As clsViewModel = Me.GenerateParamsModel("costingitems", Params)
        f.myView.PrepEdit(Model)
    End Sub

    Private Sub SelectCostingItem(rCostingItem As DataRow)
        Me.cmb_CostingItemID.Value = rCostingItem("costingitemid")
        Me.txt_Rate.Text = myUtils.cValTN(rCostingItem("purchaseprice"))
        Me.dt_RateDate.Value = rCostingItem("PurchPriceLastUpd")
        Me.cmb_ItemID.Value = DBNull.Value
        codesys.HandleCombo(Me.cmb_ItemID)
    End Sub

    Private Sub SelectItem(rItem As DataRow)
        Me.cmb_CostingItemID.Value = DBNull.Value
        Me.txt_Rate.Text = myUtils.cValTN(rItem("purchaseprice"))
        Me.dt_RateDate.Value = rItem("PurchPriceLastUpd")
        Me.cmb_ItemID.Value = rItem("itemid")
        codesys.HandleCombo(Me.cmb_ItemID)
    End Sub
End Class
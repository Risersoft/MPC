Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxent

Public Class frmIndentItem
    Inherits frmMax
    Friend fMat As frmIndent, fItemSelect As risersoft.app.config.frmItemSelect

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        fItemSelect = New risersoft.app.config.frmItemSelect
        fItemSelect.AddtoTab(Me.UltraTabControl1, "Material", True)
        fItemSelect.TableLayoutPanel2.Visible = False
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_ItemUnitIDEntry)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_ItemUnitID)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_ItemUnitID2)
        myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_OrderRateUnitID)

        fItemSelect.BindModel(NewModel)
        Return True
    End Function

    Public Overloads Function PrepForm(ByVal r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r1) Then
            Me.FormPrepared = True
            fItemSelect.HandleItem()
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()

        cm.EndCurrentEdit()
        If myUtils.NullNot(fItemSelect.cmb_ItemId.Value) Then WinFormUtils.AddError(fItemSelect.cmb_ItemId, "Please Select Item Code", Me.eBag)
        If myUtils.cValTN(txt_QtyEntry.Value) = 0 Then WinFormUtils.AddError(txt_QtyEntry, "Please Enter Quantity")

        If Me.CanSave AndAlso fItemSelect.ValidateData Then
            VSave = True
        End If
    End Function

    Private Sub txt_QtyReqd_Leave(sender As Object, e As EventArgs) Handles txt_QtyEntry.Leave
        fItemSelect.CalculateQty()
    End Sub
End Class
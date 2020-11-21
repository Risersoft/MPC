<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMat_Cost
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initForm()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cmb_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_RateFactorNet = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_QtyFactorNet = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_RateDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_RateFactor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Rate = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Factor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_CostingItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_MatHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_RateFactorMan = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_QtyFactorMan = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_RateFactorNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyFactorNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_RateDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RateFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Rate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Factor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RateFactorMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyFactorMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_ItemName
        '
        Me.cmb_ItemName.DataMember = "items"
        Me.cmb_ItemName.DisplayMember = "ItemName"
        Me.cmb_ItemName.Location = New System.Drawing.Point(77, 79)
        Me.cmb_ItemName.Name = "cmb_ItemName"
        Me.cmb_ItemName.ReadOnly = True
        Me.cmb_ItemName.Size = New System.Drawing.Size(353, 22)
        Me.cmb_ItemName.TabIndex = 4
        Me.cmb_ItemName.ValueMember = "ItemID"
        '
        'cmb_ItemID
        '
        Me.cmb_ItemID.DataMember = "items"
        Me.cmb_ItemID.DisplayMember = "ItemCode"
        Me.cmb_ItemID.Location = New System.Drawing.Point(77, 51)
        Me.cmb_ItemID.Name = "cmb_ItemID"
        Me.cmb_ItemID.ReadOnly = True
        Me.cmb_ItemID.Size = New System.Drawing.Size(160, 22)
        Me.cmb_ItemID.TabIndex = 3
        Me.cmb_ItemID.TabStop = False
        Me.cmb_ItemID.ValueMember = "ItemID"
        '
        'UltraLabel2
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.Location = New System.Drawing.Point(-48, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(119, 21)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Item Name"
        '
        'UltraLabel1
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.Location = New System.Drawing.Point(7, 51)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Item Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 446)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(451, 40)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance9
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(187, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance10
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(275, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance11.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance11
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(363, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(77, 242)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(353, 32)
        Me.txt_Remark.TabIndex = 21
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(15, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(77, 161)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.ReadOnly = True
        Me.txt_Qty.Size = New System.Drawing.Size(75, 21)
        Me.txt_Qty.TabIndex = 7
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(23, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txt_RateFactorMan)
        Me.Panel3.Controls.Add(Me.txt_QtyFactorMan)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txt_RateFactorNet)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txt_QtyFactorNet)
        Me.Panel3.Controls.Add(Me.dt_RateDate)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txt_RateFactor)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txt_Rate)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_Factor)
        Me.Panel3.Controls.Add(Me.cmb_CostingItemID)
        Me.Panel3.Controls.Add(Me.UltraLabel3)
        Me.Panel3.Controls.Add(Me.cmb_MatHeadID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmb_ItemID)
        Me.Panel3.Controls.Add(Me.cmb_ItemName)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_Remark)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.UltraLabel2)
        Me.Panel3.Controls.Add(Me.UltraLabel1)
        Me.Panel3.Controls.Add(Me.txt_Qty)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 295)
        Me.Panel3.TabIndex = 0
        '
        'txt_RateFactorNet
        '
        Me.txt_RateFactorNet.Location = New System.Drawing.Point(380, 188)
        Me.txt_RateFactorNet.Name = "txt_RateFactorNet"
        Me.txt_RateFactorNet.ReadOnly = True
        Me.txt_RateFactorNet.Size = New System.Drawing.Size(50, 21)
        Me.txt_RateFactorNet.TabIndex = 17
        Me.txt_RateFactorNet.Text = "UltraTextEditor8"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(389, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Net"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_QtyFactorNet
        '
        Me.txt_QtyFactorNet.Location = New System.Drawing.Point(380, 161)
        Me.txt_QtyFactorNet.Name = "txt_QtyFactorNet"
        Me.txt_QtyFactorNet.ReadOnly = True
        Me.txt_QtyFactorNet.Size = New System.Drawing.Size(50, 21)
        Me.txt_QtyFactorNet.TabIndex = 11
        Me.txt_QtyFactorNet.Text = "UltraTextEditor8"
        '
        'dt_RateDate
        '
        Me.dt_RateDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_RateDate.Location = New System.Drawing.Point(77, 215)
        Me.dt_RateDate.Name = "dt_RateDate"
        Me.dt_RateDate.NullText = "Not Defined"
        Me.dt_RateDate.ReadOnly = True
        Me.dt_RateDate.Size = New System.Drawing.Size(184, 21)
        Me.dt_RateDate.TabIndex = 19
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(-17, 218)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "Rate Date"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(183, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Factor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RateFactor
        '
        Me.txt_RateFactor.Location = New System.Drawing.Point(237, 188)
        Me.txt_RateFactor.Name = "txt_RateFactor"
        Me.txt_RateFactor.ReadOnly = True
        Me.txt_RateFactor.Size = New System.Drawing.Size(50, 21)
        Me.txt_RateFactor.TabIndex = 15
        Me.txt_RateFactor.Text = "UltraTextEditor8"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(23, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rate"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Rate
        '
        Me.txt_Rate.Location = New System.Drawing.Point(77, 188)
        Me.txt_Rate.Name = "txt_Rate"
        Me.txt_Rate.ReadOnly = True
        Me.txt_Rate.Size = New System.Drawing.Size(75, 21)
        Me.txt_Rate.TabIndex = 13
        Me.txt_Rate.Text = "UltraTextEditor8"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(183, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Factor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Factor
        '
        Me.txt_Factor.Location = New System.Drawing.Point(237, 161)
        Me.txt_Factor.Name = "txt_Factor"
        Me.txt_Factor.ReadOnly = True
        Me.txt_Factor.Size = New System.Drawing.Size(50, 21)
        Me.txt_Factor.TabIndex = 9
        Me.txt_Factor.Text = "UltraTextEditor8"
        '
        'cmb_CostingItemID
        '
        Me.cmb_CostingItemID.DataMember = "heads"
        Me.cmb_CostingItemID.DisplayMember = "HeadName"
        Me.cmb_CostingItemID.Location = New System.Drawing.Point(77, 106)
        Me.cmb_CostingItemID.Name = "cmb_CostingItemID"
        Me.cmb_CostingItemID.ReadOnly = True
        Me.cmb_CostingItemID.Size = New System.Drawing.Size(353, 22)
        Me.cmb_CostingItemID.TabIndex = 5
        Me.cmb_CostingItemID.ValueMember = "matheadid"
        '
        'UltraLabel3
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance12
        Me.UltraLabel3.Location = New System.Drawing.Point(-48, 107)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(119, 21)
        Me.UltraLabel3.TabIndex = 153
        Me.UltraLabel3.Text = "Costing Item"
        '
        'cmb_MatHeadID
        '
        Me.cmb_MatHeadID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_MatHeadID.Location = New System.Drawing.Point(77, 22)
        Me.cmb_MatHeadID.Name = "cmb_MatHeadID"
        Me.cmb_MatHeadID.ReadOnly = True
        Me.cmb_MatHeadID.Size = New System.Drawing.Size(353, 23)
        Me.cmb_MatHeadID.TabIndex = 1
        Me.cmb_MatHeadID.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnSelect)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 119)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(451, 32)
        Me.Panel5.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(375, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(76, 32)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(451, 119)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(245, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Auto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(306, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = "Manual"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_RateFactorMan
        '
        Me.txt_RateFactorMan.Location = New System.Drawing.Point(306, 188)
        Me.txt_RateFactorMan.Name = "txt_RateFactorMan"
        Me.txt_RateFactorMan.Size = New System.Drawing.Size(50, 21)
        Me.txt_RateFactorMan.TabIndex = 156
        Me.txt_RateFactorMan.Text = "UltraTextEditor8"
        '
        'txt_QtyFactorMan
        '
        Me.txt_QtyFactorMan.Location = New System.Drawing.Point(306, 161)
        Me.txt_QtyFactorMan.Name = "txt_QtyFactorMan"
        Me.txt_QtyFactorMan.Size = New System.Drawing.Size(50, 21)
        Me.txt_QtyFactorMan.TabIndex = 155
        Me.txt_QtyFactorMan.Text = "UltraTextEditor8"
        '
        'frmMat_Cost
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Costing Material"
        Me.ClientSize = New System.Drawing.Size(451, 486)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.Name = "frmMat_Cost"
        Me.Text = "Costing Material"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txt_RateFactorNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyFactorNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_RateDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RateFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Rate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Factor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RateFactorMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyFactorMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_RateFactor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Rate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Factor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_CostingItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_MatHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_RateFactorNet As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_QtyFactorNet As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_RateDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_RateFactorMan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_QtyFactorMan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As Label

#End Region
End Class


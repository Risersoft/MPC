<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmItemPlan
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
      
        InitForm()
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_ShelfLife As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSupp As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents btnEditItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_subcatID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UGridML As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_ItemSizeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CtlItemVMS1 As ctlItemVMS2
    Friend WithEvents txt_OldCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_OldName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_ItemCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ItemName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_CostingItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_minOrderQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_PurchasePrice As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_PurchPriceLastUpd As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dt_PurchPriceLastUpd = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_PurchasePrice = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_minOrderQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_CostingItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_OldCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_OldName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_ItemSizeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UGridML = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.txt_ShelfLife = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_subcatID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlItemVMS1 = New risersoft.app.config.ctlItemVMS2()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSupp = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnEditItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddItem = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_ItemCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ItemName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_PurchPriceLastUpd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PurchasePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_minOrderQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OldCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OldName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemSizeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGridML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ShelfLife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_subcatID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGridSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_ItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_minOrderQty)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_CostingItemID)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_OldCode)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_OldName)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ItemSizeID)
        Me.UltraTabPageControl1.Controls.Add(Me.UGridML)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ShelfLife)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_subcatID)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(660, 372)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dt_PurchPriceLastUpd)
        Me.Panel2.Controls.Add(Me.txt_PurchasePrice)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Location = New System.Drawing.Point(0, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 32)
        Me.Panel2.TabIndex = 6
        '
        'dt_PurchPriceLastUpd
        '
        Me.dt_PurchPriceLastUpd.FormatString = "dddd dd MMM yyyy"
        Me.dt_PurchPriceLastUpd.Location = New System.Drawing.Point(464, 8)
        Me.dt_PurchPriceLastUpd.Name = "dt_PurchPriceLastUpd"
        Me.dt_PurchPriceLastUpd.NullText = "Not Defined"
        Me.dt_PurchPriceLastUpd.Size = New System.Drawing.Size(184, 21)
        Me.dt_PurchPriceLastUpd.TabIndex = 3
        '
        'txt_PurchasePrice
        '
        Me.txt_PurchasePrice.Location = New System.Drawing.Point(128, 6)
        Me.txt_PurchasePrice.Name = "txt_PurchasePrice"
        Me.txt_PurchasePrice.Size = New System.Drawing.Size(240, 21)
        Me.txt_PurchasePrice.TabIndex = 1
        Me.txt_PurchasePrice.Text = "UltraTextEditor1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(43, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 14)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Purchase Price"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(388, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 14)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Last Updated"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_minOrderQty
        '
        Me.txt_minOrderQty.Location = New System.Drawing.Point(128, 216)
        Me.txt_minOrderQty.Name = "txt_minOrderQty"
        Me.txt_minOrderQty.Size = New System.Drawing.Size(72, 21)
        Me.txt_minOrderQty.TabIndex = 14
        Me.txt_minOrderQty.Text = "UltraTextEditor8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(25, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Minimum Order Qty"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(58, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Costing Item"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CostingItemID
        '
        Me.cmb_CostingItemID.DataMember = "Items"
        Me.cmb_CostingItemID.DisplayMember = "SubCatName"
        Me.cmb_CostingItemID.Location = New System.Drawing.Point(128, 71)
        Me.cmb_CostingItemID.MaxDropDownItems = 15
        Me.cmb_CostingItemID.Name = "cmb_CostingItemID"
        Me.cmb_CostingItemID.ReadOnly = True
        Me.cmb_CostingItemID.Size = New System.Drawing.Size(376, 22)
        Me.cmb_CostingItemID.TabIndex = 5
        Me.cmb_CostingItemID.Text = "UltraCombo1"
        Me.cmb_CostingItemID.ValueMember = "SubcatID"
        '
        'txt_OldCode
        '
        Me.txt_OldCode.Location = New System.Drawing.Point(128, 144)
        Me.txt_OldCode.Name = "txt_OldCode"
        Me.txt_OldCode.ReadOnly = True
        Me.txt_OldCode.Size = New System.Drawing.Size(240, 21)
        Me.txt_OldCode.TabIndex = 8
        Me.txt_OldCode.Text = "UltraTextEditor1"
        '
        'txt_OldName
        '
        Me.txt_OldName.Location = New System.Drawing.Point(128, 168)
        Me.txt_OldName.Name = "txt_OldName"
        Me.txt_OldName.ReadOnly = True
        Me.txt_OldName.Size = New System.Drawing.Size(376, 21)
        Me.txt_OldName.TabIndex = 10
        Me.txt_OldName.Text = "UltraTextEditor1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(70, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Old Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(72, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Old Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Size for Job Work"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemSizeID
        '
        Me.cmb_ItemSizeID.DataMember = "Items"
        Me.cmb_ItemSizeID.DisplayMember = "SubCatName"
        Me.cmb_ItemSizeID.Location = New System.Drawing.Point(128, 39)
        Me.cmb_ItemSizeID.MaxDropDownItems = 15
        Me.cmb_ItemSizeID.Name = "cmb_ItemSizeID"
        Me.cmb_ItemSizeID.Size = New System.Drawing.Size(376, 22)
        Me.cmb_ItemSizeID.TabIndex = 3
        Me.cmb_ItemSizeID.Text = "UltraCombo1"
        Me.cmb_ItemSizeID.ValueMember = "SubcatID"
        '
        'UGridML
        '
        Me.UGridML.Location = New System.Drawing.Point(128, 243)
        Me.UGridML.Name = "UGridML"
        Me.UGridML.Size = New System.Drawing.Size(520, 120)
        Me.UGridML.TabIndex = 15
        Me.UGridML.Text = "Minimum Levels"
        '
        'txt_ShelfLife
        '
        Me.txt_ShelfLife.Location = New System.Drawing.Point(128, 192)
        Me.txt_ShelfLife.Name = "txt_ShelfLife"
        Me.txt_ShelfLife.ReadOnly = True
        Me.txt_ShelfLife.Size = New System.Drawing.Size(142, 21)
        Me.txt_ShelfLife.TabIndex = 12
        Me.txt_ShelfLife.Text = "UltraTextEditor8"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(70, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Shelf Life"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Sub Category"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_subcatID
        '
        Me.cmb_subcatID.DataMember = "Items"
        Me.cmb_subcatID.DisplayMember = "SubCatName"
        Me.cmb_subcatID.Location = New System.Drawing.Point(128, 7)
        Me.cmb_subcatID.MaxDropDownItems = 15
        Me.cmb_subcatID.Name = "cmb_subcatID"
        Me.cmb_subcatID.ReadOnly = True
        Me.cmb_subcatID.Size = New System.Drawing.Size(376, 22)
        Me.cmb_subcatID.TabIndex = 1
        Me.cmb_subcatID.Text = "UltraCombo1"
        Me.cmb_subcatID.ValueMember = "SubcatID"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.CtlItemVMS1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(660, 372)
        '
        'CtlItemVMS1
        '
        Me.CtlItemVMS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlItemVMS1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlItemVMS1.ItemVMSID = 0
        Me.CtlItemVMS1.Location = New System.Drawing.Point(0, 0)
        Me.CtlItemVMS1.Mode = risersoft.[shared].EnumVMSMode.acItem
        Me.CtlItemVMS1.Name = "CtlItemVMS1"
        Me.CtlItemVMS1.Size = New System.Drawing.Size(660, 372)
        Me.CtlItemVMS1.TabIndex = 0
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGridSupp)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel17)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(660, 372)
        '
        'UltraGridSupp
        '
        Me.UltraGridSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSupp.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSupp.Name = "UltraGridSupp"
        Me.UltraGridSupp.Size = New System.Drawing.Size(660, 324)
        Me.UltraGridSupp.TabIndex = 0
        Me.UltraGridSupp.Text = "Suppliers"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btnEditItem)
        Me.Panel17.Controls.Add(Me.btnDelItem)
        Me.Panel17.Controls.Add(Me.btnAddItem)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 324)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(660, 48)
        Me.Panel17.TabIndex = 1
        '
        'btnEditItem
        '
        Me.btnEditItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditItem.Location = New System.Drawing.Point(464, 16)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(72, 24)
        Me.btnEditItem.TabIndex = 1
        Me.btnEditItem.Text = "Edit"
        '
        'btnDelItem
        '
        Me.btnDelItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelItem.Location = New System.Drawing.Point(368, 16)
        Me.btnDelItem.Name = "btnDelItem"
        Me.btnDelItem.Size = New System.Drawing.Size(70, 24)
        Me.btnDelItem.TabIndex = 0
        Me.btnDelItem.Text = "Delete"
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.Location = New System.Drawing.Point(560, 16)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(72, 24)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.Text = "Add New"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 478)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(664, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(376, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(472, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(568, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 80)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(664, 398)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Item"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "VMS"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Suppliers"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(660, 372)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_ItemCode)
        Me.Panel1.Controls.Add(Me.txt_ItemName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.ComboUnit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 80)
        Me.Panel1.TabIndex = 0
        '
        'txt_ItemCode
        '
        Appearance4.FontData.SizeInPoints = 10.0!
        Me.txt_ItemCode.Appearance = Appearance4
        Me.txt_ItemCode.Location = New System.Drawing.Point(136, 16)
        Me.txt_ItemCode.Name = "txt_ItemCode"
        Me.txt_ItemCode.ReadOnly = True
        Me.txt_ItemCode.Size = New System.Drawing.Size(296, 24)
        Me.txt_ItemCode.TabIndex = 1
        Me.txt_ItemCode.Text = "UltraTextEditor1"
        '
        'txt_ItemName
        '
        Appearance5.FontData.SizeInPoints = 10.0!
        Me.txt_ItemName.Appearance = Appearance5
        Me.txt_ItemName.Location = New System.Drawing.Point(136, 48)
        Me.txt_ItemName.Name = "txt_ItemName"
        Me.txt_ItemName.ReadOnly = True
        Me.txt_ItemName.Size = New System.Drawing.Size(456, 24)
        Me.txt_ItemName.TabIndex = 5
        Me.txt_ItemName.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(475, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(57, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(59, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Item Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit
        '
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit.Appearance = Appearance6
        Me.ComboUnit.DataMember = "Items"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ComboUnit.Location = New System.Drawing.Point(512, 16)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(80, 25)
        Me.ComboUnit.TabIndex = 3
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "SubCatID"
        '
        'frmItemPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Item"
        Me.ClientSize = New System.Drawing.Size(664, 526)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmItemPlan"
        Me.Text = "Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_PurchPriceLastUpd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PurchasePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_minOrderQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OldCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OldName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemSizeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGridML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ShelfLife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_subcatID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGridSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_ItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class


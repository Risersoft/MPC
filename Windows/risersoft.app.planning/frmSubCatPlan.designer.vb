<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSubCatPlan
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_InitialCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SubCatName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_IsStock As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsMacMaint As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsWOSpecific As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_ClassABC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ClassSDE As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_ItemSBHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubCatPlan))
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_ShortName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_ItemSBHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ClassSDE = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_IsStock = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsMacMaint = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsWOSpecific = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_ClassABC = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSupp = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddItem = New Infragistics.Win.Misc.UltraButton()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.txt_PurchaseSpec = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_VendorListHead = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_InitialCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SubCatName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_ShortName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemSBHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ClassSDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsMacMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsWOSpecific, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ClassABC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.txt_PurchaseSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_VendorListHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_InitialCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubCatName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ShortName)
        Me.UltraTabPageControl1.Controls.Add(Me.Label26)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ItemSBHeadID)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ClassSDE)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsStock)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsMacMaint)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsWOSpecific)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ClassABC)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(716, 384)
        '
        'txt_ShortName
        '
        Me.txt_ShortName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ShortName.Location = New System.Drawing.Point(128, 170)
        Me.txt_ShortName.Name = "txt_ShortName"
        Me.txt_ShortName.Size = New System.Drawing.Size(240, 22)
        Me.txt_ShortName.TabIndex = 10
        Me.txt_ShortName.Text = "UltraTextEditor1"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label26.Location = New System.Drawing.Point(15, 170)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 33)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Short Name for Planning reports"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item SB Head"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemSBHeadID
        '
        Me.cmb_ItemSBHeadID.DataMember = "Items"
        Me.cmb_ItemSBHeadID.DisplayMember = "SBHeadName"
        Me.cmb_ItemSBHeadID.Location = New System.Drawing.Point(128, 32)
        Me.cmb_ItemSBHeadID.MaxDropDownItems = 15
        Me.cmb_ItemSBHeadID.Name = "cmb_ItemSBHeadID"
        Me.cmb_ItemSBHeadID.ReadOnly = True
        Me.cmb_ItemSBHeadID.Size = New System.Drawing.Size(376, 22)
        Me.cmb_ItemSBHeadID.TabIndex = 1
        Me.cmb_ItemSBHeadID.Text = "UltraCombo1"
        Me.cmb_ItemSBHeadID.ValueMember = "ItemSBHeadID"
        '
        'cmb_ClassSDE
        '
        ValueListItem1.DataValue = CType(resources.GetObject("ValueListItem1.DataValue"), Object)
        ValueListItem1.DisplayText = "Not Defined"
        ValueListItem2.DataValue = "S"
        ValueListItem2.DisplayText = "Scarce"
        ValueListItem3.DataValue = "D"
        ValueListItem3.DisplayText = "Difficult"
        ValueListItem9.DataValue = "E"
        ValueListItem9.DisplayText = "Easy"
        Me.cmb_ClassSDE.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem9})
        Me.cmb_ClassSDE.LimitToList = True
        Me.cmb_ClassSDE.Location = New System.Drawing.Point(128, 128)
        Me.cmb_ClassSDE.Name = "cmb_ClassSDE"
        Me.cmb_ClassSDE.Size = New System.Drawing.Size(136, 21)
        Me.cmb_ClassSDE.TabIndex = 8
        Me.cmb_ClassSDE.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 128)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "SDE Class"
        '
        'chk_IsStock
        '
        Me.chk_IsStock.Location = New System.Drawing.Point(512, 64)
        Me.chk_IsStock.Name = "chk_IsStock"
        Me.chk_IsStock.Size = New System.Drawing.Size(80, 16)
        Me.chk_IsStock.TabIndex = 4
        Me.chk_IsStock.Text = "Is Stock"
        '
        'chk_IsMacMaint
        '
        Me.chk_IsMacMaint.Location = New System.Drawing.Point(272, 64)
        Me.chk_IsMacMaint.Name = "chk_IsMacMaint"
        Me.chk_IsMacMaint.Size = New System.Drawing.Size(232, 16)
        Me.chk_IsMacMaint.TabIndex = 3
        Me.chk_IsMacMaint.Text = "Is Machinery / Maintenance sub category"
        '
        'chk_IsWOSpecific
        '
        Me.chk_IsWOSpecific.Location = New System.Drawing.Point(128, 64)
        Me.chk_IsWOSpecific.Name = "chk_IsWOSpecific"
        Me.chk_IsWOSpecific.Size = New System.Drawing.Size(136, 16)
        Me.chk_IsWOSpecific.TabIndex = 2
        Me.chk_IsWOSpecific.Text = "Is Work Order Specific"
        '
        'cmb_ClassABC
        '
        ValueListItem10.DataValue = CType(resources.GetObject("ValueListItem10.DataValue"), Object)
        ValueListItem10.DisplayText = "Not Defined"
        ValueListItem6.DataValue = "A"
        ValueListItem6.DisplayText = "Class A"
        ValueListItem7.DataValue = "B"
        ValueListItem7.DisplayText = "Class B"
        ValueListItem8.DataValue = "C"
        ValueListItem8.DisplayText = "Class C"
        Me.cmb_ClassABC.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem10, ValueListItem6, ValueListItem7, ValueListItem8})
        Me.cmb_ClassABC.LimitToList = True
        Me.cmb_ClassABC.Location = New System.Drawing.Point(128, 96)
        Me.cmb_ClassABC.Name = "cmb_ClassABC"
        Me.cmb_ClassABC.Size = New System.Drawing.Size(136, 21)
        Me.cmb_ClassABC.TabIndex = 6
        Me.cmb_ClassABC.Text = "UltraComboEditor1"
        '
        'UltraLabel7
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance2
        Me.UltraLabel7.Location = New System.Drawing.Point(24, 96)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel7.TabIndex = 5
        Me.UltraLabel7.Text = "ABC Class"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridSupp)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel17)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(716, 384)
        '
        'UltraGridSupp
        '
        Me.UltraGridSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSupp.Location = New System.Drawing.Point(0, 99)
        Me.UltraGridSupp.Name = "UltraGridSupp"
        Me.UltraGridSupp.Size = New System.Drawing.Size(716, 237)
        Me.UltraGridSupp.TabIndex = 1
        Me.UltraGridSupp.Text = "Suppliers"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEditItem)
        Me.Panel2.Controls.Add(Me.btnDelItem)
        Me.Panel2.Controls.Add(Me.btnAddItem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 48)
        Me.Panel2.TabIndex = 2
        '
        'btnEditItem
        '
        Me.btnEditItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditItem.Location = New System.Drawing.Point(520, 16)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(72, 24)
        Me.btnEditItem.TabIndex = 1
        Me.btnEditItem.Text = "Edit"
        '
        'btnDelItem
        '
        Me.btnDelItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelItem.Location = New System.Drawing.Point(424, 16)
        Me.btnDelItem.Name = "btnDelItem"
        Me.btnDelItem.Size = New System.Drawing.Size(70, 24)
        Me.btnDelItem.TabIndex = 0
        Me.btnDelItem.Text = "Delete"
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.Location = New System.Drawing.Point(616, 16)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(72, 24)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.Text = "Add New"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.txt_PurchaseSpec)
        Me.Panel17.Controls.Add(Me.Label7)
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Controls.Add(Me.cmb_VendorListHead)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(716, 99)
        Me.Panel17.TabIndex = 0
        '
        'txt_PurchaseSpec
        '
        Me.txt_PurchaseSpec.Location = New System.Drawing.Point(176, 45)
        Me.txt_PurchaseSpec.Multiline = True
        Me.txt_PurchaseSpec.Name = "txt_PurchaseSpec"
        Me.txt_PurchaseSpec.Size = New System.Drawing.Size(462, 32)
        Me.txt_PurchaseSpec.TabIndex = 3
        Me.txt_PurchaseSpec.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(34, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Purchase Specification"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(47, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Vendor List Head"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_VendorListHead
        '
        ValueListItem4.DataValue = False
        ValueListItem4.DisplayText = "Purchase"
        ValueListItem5.DataValue = True
        ValueListItem5.DisplayText = "Job Work"
        Me.cmb_VendorListHead.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5})
        Me.cmb_VendorListHead.Location = New System.Drawing.Point(176, 18)
        Me.cmb_VendorListHead.Name = "cmb_VendorListHead"
        Me.cmb_VendorListHead.Size = New System.Drawing.Size(229, 21)
        Me.cmb_VendorListHead.TabIndex = 1
        Me.cmb_VendorListHead.Text = "UltraComboEditor9"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 494)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(720, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Location = New System.Drawing.Point(432, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Location = New System.Drawing.Point(528, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Location = New System.Drawing.Point(624, 8)
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
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 84)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(720, 410)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Item"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Vendor List"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(716, 384)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_InitialCode)
        Me.Panel1.Controls.Add(Me.txt_SubCatName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.ComboUnit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 84)
        Me.Panel1.TabIndex = 0
        '
        'txt_InitialCode
        '
        Me.txt_InitialCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InitialCode.Location = New System.Drawing.Point(166, 17)
        Me.txt_InitialCode.Name = "txt_InitialCode"
        Me.txt_InitialCode.ReadOnly = True
        Me.txt_InitialCode.Size = New System.Drawing.Size(240, 22)
        Me.txt_InitialCode.TabIndex = 1
        Me.txt_InitialCode.Text = "UltraTextEditor1"
        '
        'txt_SubCatName
        '
        Me.txt_SubCatName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_SubCatName.Location = New System.Drawing.Point(166, 49)
        Me.txt_SubCatName.Name = "txt_SubCatName"
        Me.txt_SubCatName.ReadOnly = True
        Me.txt_SubCatName.Size = New System.Drawing.Size(456, 22)
        Me.txt_SubCatName.TabIndex = 5
        Me.txt_SubCatName.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(510, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Sub Category Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(78, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Initial Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit
        '
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit.Appearance = Appearance6
        Me.ComboUnit.DataMember = "ItemSBHead"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ComboUnit.Location = New System.Drawing.Point(550, 17)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit.TabIndex = 3
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "ItemSbHeadID"
        '
        'frmSubCatPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Item Sub Category"
        Me.ClientSize = New System.Drawing.Size(720, 542)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSubCatPlan"
        Me.Text = "Item Sub Category"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_ShortName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemSBHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ClassSDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsMacMaint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsWOSpecific, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ClassABC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.txt_PurchaseSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_VendorListHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_InitialCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubCatName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_ShortName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEditItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridSupp As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_VendorListHead As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_PurchaseSpec As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label

#End Region
End Class


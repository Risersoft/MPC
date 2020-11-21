Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMat
    Inherits frmMax
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.initForm()
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_MatHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_HeadMore As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGridSubCat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Spec As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_QtyAsReq As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckItem As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridItemVMS As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridBOM As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridItems As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblVMS As System.Windows.Forms.Label
    Friend WithEvents cmb_listindex As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Tag As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_IsManual As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridItems = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.UltraGridItemVMS = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnRemove = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridBOM = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmb_ItemUnitID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_BaseUnitID2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_listindex = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_BaseUnitID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chk_QtyAsReq = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblVMS = New System.Windows.Forms.Label()
        Me.cmb_Tag = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Spec = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraGridSubCat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_pidinfo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_HeadMore = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_MatHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chk_IsManual = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.CheckItem = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridItemVMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemUnitID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_BaseUnitID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_listindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_BaseUnitID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_QtyAsReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Tag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Spec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGridSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_pidinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HeadMore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.chk_IsManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridItems)
        Me.UltraTabPageControl1.Controls.Add(Me.Splitter1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridItemVMS)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(732, 274)
        '
        'UltraGridItems
        '
        Me.UltraGridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridItems.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridItems.Name = "UltraGridItems"
        Me.UltraGridItems.Size = New System.Drawing.Size(732, 101)
        Me.UltraGridItems.TabIndex = 0
        Me.UltraGridItems.Text = "Items"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 101)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(732, 10)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'UltraGridItemVMS
        '
        Me.UltraGridItemVMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGridItemVMS.Location = New System.Drawing.Point(0, 111)
        Me.UltraGridItemVMS.Name = "UltraGridItemVMS"
        Me.UltraGridItemVMS.Size = New System.Drawing.Size(732, 133)
        Me.UltraGridItemVMS.TabIndex = 3
        Me.UltraGridItemVMS.Text = "Item VMS"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnEdit)
        Me.Panel6.Controls.Add(Me.btnAdd)
        Me.Panel6.Controls.Add(Me.btnRemove)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 244)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(732, 30)
        Me.Panel6.TabIndex = 2
        '
        'btnEdit
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnEdit.Appearance = Appearance1
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(528, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 30)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(592, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(662, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 30)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridBOM)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(732, 274)
        '
        'UltraGridBOM
        '
        Me.UltraGridBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBOM.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBOM.Name = "UltraGridBOM"
        Me.UltraGridBOM.Size = New System.Drawing.Size(732, 274)
        Me.UltraGridBOM.TabIndex = 0
        Me.UltraGridBOM.Text = "BOM"
        '
        'cmb_ItemUnitID
        '
        Me.cmb_ItemUnitID.DisplayMember = "UnitName"
        Me.cmb_ItemUnitID.Location = New System.Drawing.Point(415, 72)
        Me.cmb_ItemUnitID.Name = "cmb_ItemUnitID"
        Me.cmb_ItemUnitID.ReadOnly = True
        Me.cmb_ItemUnitID.Size = New System.Drawing.Size(105, 22)
        Me.cmb_ItemUnitID.TabIndex = 10
        Me.cmb_ItemUnitID.TabStop = False
        Me.cmb_ItemUnitID.ValueMember = "ItemUnitID"
        '
        'UltraLabel14
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance18
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(388, 76)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel14.TabIndex = 9
        Me.UltraLabel14.Text = "Unit"
        '
        'UltraLabel5
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance10
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(195, 103)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Base Unit 2"
        '
        'cmb_BaseUnitID2
        '
        Me.cmb_BaseUnitID2.DisplayMember = "UnitName2"
        Me.cmb_BaseUnitID2.Location = New System.Drawing.Point(261, 99)
        Me.cmb_BaseUnitID2.Name = "cmb_BaseUnitID2"
        Me.cmb_BaseUnitID2.ReadOnly = True
        Me.cmb_BaseUnitID2.Size = New System.Drawing.Size(100, 22)
        Me.cmb_BaseUnitID2.TabIndex = 14
        Me.cmb_BaseUnitID2.TabStop = False
        Me.cmb_BaseUnitID2.ValueMember = "itemid"
        '
        'cmb_listindex
        '
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Matlist1"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "Matlist2"
        Me.cmb_listindex.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_listindex.Location = New System.Drawing.Point(415, 100)
        Me.cmb_listindex.Name = "cmb_listindex"
        Me.cmb_listindex.Size = New System.Drawing.Size(105, 21)
        Me.cmb_listindex.TabIndex = 16
        Me.cmb_listindex.Text = "UltraComboEditor1"
        '
        'UltraLabel2
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance19
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(22, 102)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel2.TabIndex = 11
        Me.UltraLabel2.Text = "Base Unit1"
        '
        'lblMake
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance7
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(390, 104)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(22, 14)
        Me.lblMake.TabIndex = 15
        Me.lblMake.Text = "List"
        '
        'cmb_BaseUnitID
        '
        Me.cmb_BaseUnitID.DisplayMember = "unitName"
        Me.cmb_BaseUnitID.Location = New System.Drawing.Point(85, 99)
        Me.cmb_BaseUnitID.Name = "cmb_BaseUnitID"
        Me.cmb_BaseUnitID.ReadOnly = True
        Me.cmb_BaseUnitID.Size = New System.Drawing.Size(99, 22)
        Me.cmb_BaseUnitID.TabIndex = 12
        Me.cmb_BaseUnitID.TabStop = False
        Me.cmb_BaseUnitID.ValueMember = "itemid"
        '
        'chk_QtyAsReq
        '
        Me.chk_QtyAsReq.AutoSize = True
        Me.chk_QtyAsReq.Location = New System.Drawing.Point(85, 73)
        Me.chk_QtyAsReq.Name = "chk_QtyAsReq"
        Me.chk_QtyAsReq.Size = New System.Drawing.Size(83, 17)
        Me.chk_QtyAsReq.TabIndex = 6
        Me.chk_QtyAsReq.Text = "Qty as reqd."
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(261, 73)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(100, 21)
        Me.txt_Qty.TabIndex = 8
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(233, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItem
        '
        Me.lblItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblItem.Location = New System.Drawing.Point(578, 78)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(152, 16)
        Me.lblItem.TabIndex = 17
        Me.lblItem.Text = "Qty"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVMS
        '
        Me.lblVMS.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblVMS.Location = New System.Drawing.Point(578, 105)
        Me.lblVMS.Name = "lblVMS"
        Me.lblVMS.Size = New System.Drawing.Size(152, 16)
        Me.lblVMS.TabIndex = 18
        Me.lblVMS.Text = "Qty"
        Me.lblVMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Tag
        '
        Me.cmb_Tag.Location = New System.Drawing.Point(415, 7)
        Me.cmb_Tag.Name = "cmb_Tag"
        Me.cmb_Tag.Size = New System.Drawing.Size(237, 21)
        Me.cmb_Tag.TabIndex = 3
        Me.cmb_Tag.Text = "UltraComboEditor1"
        '
        'txt_Spec
        '
        Me.txt_Spec.AcceptsReturn = True
        Me.txt_Spec.Location = New System.Drawing.Point(85, 7)
        Me.txt_Spec.Multiline = True
        Me.txt_Spec.Name = "txt_Spec"
        Me.txt_Spec.Size = New System.Drawing.Size(276, 58)
        Me.txt_Spec.TabIndex = 1
        Me.txt_Spec.Text = "UltraTextEditor3"
        '
        'UltraLabel12
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance2
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(388, 10)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel12.TabIndex = 2
        Me.UltraLabel12.Text = "Tag"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matlist1 Spec (Printed in Matlist1)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(415, 31)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(315, 34)
        Me.txt_Remark.TabIndex = 5
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(363, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Remarks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 524)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 96)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(736, 300)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Specifications"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Bill of Material"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(732, 274)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmb_Tag)
        Me.Panel5.Controls.Add(Me.cmb_ItemUnitID)
        Me.Panel5.Controls.Add(Me.lblVMS)
        Me.Panel5.Controls.Add(Me.txt_Spec)
        Me.Panel5.Controls.Add(Me.lblItem)
        Me.Panel5.Controls.Add(Me.UltraLabel14)
        Me.Panel5.Controls.Add(Me.UltraLabel12)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txt_Qty)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.UltraLabel5)
        Me.Panel5.Controls.Add(Me.chk_QtyAsReq)
        Me.Panel5.Controls.Add(Me.txt_Remark)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cmb_BaseUnitID)
        Me.Panel5.Controls.Add(Me.cmb_BaseUnitID2)
        Me.Panel5.Controls.Add(Me.lblMake)
        Me.Panel5.Controls.Add(Me.UltraLabel2)
        Me.Panel5.Controls.Add(Me.cmb_listindex)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 396)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(736, 128)
        Me.Panel5.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraGridSubCat)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 96)
        Me.Panel1.TabIndex = 10
        '
        'UltraGridSubCat
        '
        Me.UltraGridSubCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSubCat.Location = New System.Drawing.Point(352, 0)
        Me.UltraGridSubCat.Name = "UltraGridSubCat"
        Me.UltraGridSubCat.Size = New System.Drawing.Size(384, 96)
        Me.UltraGridSubCat.TabIndex = 0
        Me.UltraGridSubCat.Text = "Sub Category"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_pidinfo)
        Me.Panel3.Controls.Add(Me.txt_HeadMore)
        Me.Panel3.Controls.Add(Me.cmb_MatHeadID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 96)
        Me.Panel3.TabIndex = 0
        '
        'txt_pidinfo
        '
        Me.txt_pidinfo.Location = New System.Drawing.Point(56, 12)
        Me.txt_pidinfo.Name = "txt_pidinfo"
        Me.txt_pidinfo.ReadOnly = True
        Me.txt_pidinfo.Size = New System.Drawing.Size(272, 21)
        Me.txt_pidinfo.TabIndex = 0
        Me.txt_pidinfo.Text = "UltraTextEditor1"
        '
        'txt_HeadMore
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.ItalicAsString = "False"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.FontData.StrikeoutAsString = "False"
        Appearance3.FontData.UnderlineAsString = "False"
        Me.txt_HeadMore.Appearance = Appearance3
        Me.txt_HeadMore.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_HeadMore.Location = New System.Drawing.Point(56, 63)
        Me.txt_HeadMore.Name = "txt_HeadMore"
        Me.txt_HeadMore.Size = New System.Drawing.Size(152, 21)
        Me.txt_HeadMore.TabIndex = 3
        '
        'cmb_MatHeadID
        '
        Me.cmb_MatHeadID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_MatHeadID.Location = New System.Drawing.Point(56, 39)
        Me.cmb_MatHeadID.Name = "cmb_MatHeadID"
        Me.cmb_MatHeadID.ReadOnly = True
        Me.cmb_MatHeadID.Size = New System.Drawing.Size(272, 23)
        Me.cmb_MatHeadID.TabIndex = 2
        Me.cmb_MatHeadID.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(17, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.chk_IsManual)
        Me.Panel4.Controls.Add(Me.CheckItem)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 524)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 42)
        Me.Panel4.TabIndex = 0
        '
        'chk_IsManual
        '
        Me.chk_IsManual.AutoSize = True
        Me.chk_IsManual.Location = New System.Drawing.Point(16, 13)
        Me.chk_IsManual.Name = "chk_IsManual"
        Me.chk_IsManual.Size = New System.Drawing.Size(58, 17)
        Me.chk_IsManual.TabIndex = 0
        Me.chk_IsManual.Text = "Manual"
        '
        'CheckItem
        '
        Me.CheckItem.AutoSize = True
        Me.CheckItem.Checked = True
        Me.CheckItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckItem.Location = New System.Drawing.Point(120, 13)
        Me.CheckItem.Name = "CheckItem"
        Me.CheckItem.Size = New System.Drawing.Size(328, 17)
        Me.CheckItem.TabIndex = 1
        Me.CheckItem.Text = "Update ItemCode Matlist1 spec with spec entered upon Save"
        '
        'btnSave
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance4
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(504, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save and Build BOM"
        '
        'btnCancel
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance5
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(592, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 42)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance6
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(664, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 42)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        '
        'frmMat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Material"
        Me.ClientSize = New System.Drawing.Size(736, 566)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMat"
        Me.Text = "Material"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridItemVMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemUnitID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_BaseUnitID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_listindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_BaseUnitID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_QtyAsReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Tag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Spec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGridSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txt_pidinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HeadMore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.chk_IsManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_pidinfo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnRemove As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_BaseUnitID2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_BaseUnitID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemUnitID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel

#End Region
End Class


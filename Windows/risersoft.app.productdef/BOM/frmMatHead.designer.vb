Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMatHead
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_HeadTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_ItemUnitID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_HeadName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_SelectionType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnDelSub As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_HeadNumType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_HeadCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_HeadNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_OpenedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chk_IsForMatList1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsForCostingMats = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_ForceInMatPlan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsForMatList2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsOld = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddSub = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelSub = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnAddSeqProc = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelSeqProc = New Infragistics.Win.Misc.UltraButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.cmb_ParentHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmb_MatDesTableColID2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_RemarkTypeCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmb_RemarkDesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_QtyDesParam2ID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_QtyDesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_QtySelecType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_MatDesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_MatDesParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_ItemSelecType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.combo_ItemUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_FixedItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_QtyDesParamNA = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_NAParamValue2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_QtyDesParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_NADesParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_NAParamValue1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_FixedQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_CostFactorRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmb_RateDesTableCol2ID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_CostQtyDesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_CostQtyDesParam2ID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_RateDesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_CostQtyDesParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_CostFactor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_CostFixedQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_CostingItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_RateDesParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_CostQtyCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_CostingUnitID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_CostRateCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_SelectionType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_ItemUnitID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_HeadName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_HeadTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.cmb_HeadNumType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HeadCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HeadNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OpenedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsForMatList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsForCostingMats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ForceInMatPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsForMatList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsOld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.cmb_ParentHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.cmb_MatDesTableColID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RemarkTypeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RemarkDesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_QtyDesParam2ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_QtyDesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_QtySelecType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatDesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatDesParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemSelecType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_FixedItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_QtyDesParamNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NAParamValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_QtyDesParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_NADesParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NAParamValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FixedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_CostFactorRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RateDesTableCol2ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostQtyDesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostQtyDesParam2ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RateDesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostQtyDesParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CostFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CostFixedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RateDesParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostQtyCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostingUnitID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CostRateCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_SelectionType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemUnitID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HeadName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_HeadTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.cmb_HeadNumType)
        Me.UltraTabPageControl11.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl11.Controls.Add(Me.Label9)
        Me.UltraTabPageControl11.Controls.Add(Me.Label25)
        Me.UltraTabPageControl11.Controls.Add(Me.txt_HeadCode)
        Me.UltraTabPageControl11.Controls.Add(Me.txt_HeadNum)
        Me.UltraTabPageControl11.Controls.Add(Me.dt_OpenedOn)
        Me.UltraTabPageControl11.Controls.Add(Me.Label28)
        Me.UltraTabPageControl11.Controls.Add(Me.chk_IsForMatList1)
        Me.UltraTabPageControl11.Controls.Add(Me.chk_IsForCostingMats)
        Me.UltraTabPageControl11.Controls.Add(Me.cmb_matdepid)
        Me.UltraTabPageControl11.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl11.Controls.Add(Me.chk_ForceInMatPlan)
        Me.UltraTabPageControl11.Controls.Add(Me.chk_IsForMatList2)
        Me.UltraTabPageControl11.Controls.Add(Me.chk_IsOld)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(804, 372)
        '
        'cmb_HeadNumType
        '
        Me.cmb_HeadNumType.Location = New System.Drawing.Point(151, 254)
        Me.cmb_HeadNumType.Name = "cmb_HeadNumType"
        Me.cmb_HeadNumType.Size = New System.Drawing.Size(272, 21)
        Me.cmb_HeadNumType.TabIndex = 12
        Me.cmb_HeadNumType.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 258)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Head Number Type"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(95, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Code"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(23, 281)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Head Number"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_HeadCode
        '
        Me.txt_HeadCode.Location = New System.Drawing.Point(151, 227)
        Me.txt_HeadCode.Name = "txt_HeadCode"
        Me.txt_HeadCode.Size = New System.Drawing.Size(104, 21)
        Me.txt_HeadCode.TabIndex = 10
        Me.txt_HeadCode.Text = "UltraTextEditor1"
        '
        'txt_HeadNum
        '
        Me.txt_HeadNum.Location = New System.Drawing.Point(151, 281)
        Me.txt_HeadNum.Name = "txt_HeadNum"
        Me.txt_HeadNum.Size = New System.Drawing.Size(48, 21)
        Me.txt_HeadNum.TabIndex = 14
        Me.txt_HeadNum.Text = "UltraTextEditor1"
        '
        'dt_OpenedOn
        '
        Me.dt_OpenedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_OpenedOn.Location = New System.Drawing.Point(151, 29)
        Me.dt_OpenedOn.Name = "dt_OpenedOn"
        Me.dt_OpenedOn.NullText = "Not Defined"
        Me.dt_OpenedOn.Size = New System.Drawing.Size(184, 21)
        Me.dt_OpenedOn.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(57, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Opened On"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_IsForMatList1
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 8.0!
        Appearance2.TextHAlignAsString = "Left"
        Me.chk_IsForMatList1.Appearance = Appearance2
        Me.chk_IsForMatList1.Location = New System.Drawing.Point(151, 72)
        Me.chk_IsForMatList1.Name = "chk_IsForMatList1"
        Me.chk_IsForMatList1.Size = New System.Drawing.Size(104, 16)
        Me.chk_IsForMatList1.TabIndex = 2
        Me.chk_IsForMatList1.Text = "Is For MatList1"
        '
        'chk_IsForCostingMats
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.SizeInPoints = 8.0!
        Appearance3.TextHAlignAsString = "Left"
        Me.chk_IsForCostingMats.Appearance = Appearance3
        Me.chk_IsForCostingMats.Location = New System.Drawing.Point(151, 138)
        Me.chk_IsForCostingMats.Name = "chk_IsForCostingMats"
        Me.chk_IsForCostingMats.Size = New System.Drawing.Size(152, 16)
        Me.chk_IsForCostingMats.TabIndex = 6
        Me.chk_IsForCostingMats.Text = "Is For Costing Material list"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(151, 178)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.Size = New System.Drawing.Size(328, 22)
        Me.cmb_matdepid.TabIndex = 8
        '
        'UltraLabel4
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.Location = New System.Drawing.Point(15, 170)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(128, 32)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "Can be Manufactured by this Internal Department"
        '
        'chk_ForceInMatPlan
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.SizeInPoints = 8.0!
        Appearance5.TextHAlignAsString = "Left"
        Me.chk_ForceInMatPlan.Appearance = Appearance5
        Me.chk_ForceInMatPlan.Location = New System.Drawing.Point(151, 116)
        Me.chk_ForceInMatPlan.Name = "chk_ForceInMatPlan"
        Me.chk_ForceInMatPlan.Size = New System.Drawing.Size(152, 16)
        Me.chk_ForceInMatPlan.TabIndex = 5
        Me.chk_ForceInMatPlan.Text = "Force in Material Planning"
        '
        'chk_IsForMatList2
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.SizeInPoints = 8.0!
        Appearance6.TextHAlignAsString = "Left"
        Me.chk_IsForMatList2.Appearance = Appearance6
        Me.chk_IsForMatList2.Location = New System.Drawing.Point(151, 94)
        Me.chk_IsForMatList2.Name = "chk_IsForMatList2"
        Me.chk_IsForMatList2.Size = New System.Drawing.Size(104, 16)
        Me.chk_IsForMatList2.TabIndex = 3
        Me.chk_IsForMatList2.Text = "Is For MatList2"
        '
        'chk_IsOld
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.SizeInPoints = 8.0!
        Appearance7.TextHAlignAsString = "Left"
        Me.chk_IsOld.Appearance = Appearance7
        Me.chk_IsOld.Location = New System.Drawing.Point(333, 88)
        Me.chk_IsOld.Name = "chk_IsOld"
        Me.chk_IsOld.Size = New System.Drawing.Size(146, 22)
        Me.chk_IsOld.TabIndex = 4
        Me.chk_IsOld.Text = "Is No Longer in use"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(804, 372)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraGrid1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 372)
        Me.Panel3.TabIndex = 8
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(804, 336)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Lots"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAddSub)
        Me.Panel5.Controls.Add(Me.btnDelSub)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 336)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 36)
        Me.Panel5.TabIndex = 1
        '
        'btnAddSub
        '
        Me.btnAddSub.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddSub.Location = New System.Drawing.Point(636, 0)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(84, 36)
        Me.btnAddSub.TabIndex = 0
        Me.btnAddSub.Text = "Add New"
        '
        'btnDelSub
        '
        Me.btnDelSub.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelSub.Location = New System.Drawing.Point(720, 0)
        Me.btnDelSub.Name = "btnDelSub"
        Me.btnDelSub.Size = New System.Drawing.Size(84, 36)
        Me.btnDelSub.TabIndex = 1
        Me.btnDelSub.Text = "Delete"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl9.Controls.Add(Me.Panel12)
        Me.UltraTabPageControl9.Controls.Add(Me.Panel11)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(804, 372)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 54)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(804, 282)
        Me.UltraGrid3.TabIndex = 1
        Me.UltraGrid3.Text = "TF Serials"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnAddSeqProc)
        Me.Panel12.Controls.Add(Me.btnDelSeqProc)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 336)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(804, 36)
        Me.Panel12.TabIndex = 2
        '
        'btnAddSeqProc
        '
        Me.btnAddSeqProc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddSeqProc.Location = New System.Drawing.Point(636, 0)
        Me.btnAddSeqProc.Name = "btnAddSeqProc"
        Me.btnAddSeqProc.Size = New System.Drawing.Size(84, 36)
        Me.btnAddSeqProc.TabIndex = 0
        Me.btnAddSeqProc.Text = "Add New"
        '
        'btnDelSeqProc
        '
        Me.btnDelSeqProc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelSeqProc.Location = New System.Drawing.Point(720, 0)
        Me.btnDelSeqProc.Name = "btnDelSeqProc"
        Me.btnDelSeqProc.Size = New System.Drawing.Size(84, 36)
        Me.btnDelSeqProc.TabIndex = 1
        Me.btnDelSeqProc.Text = "&Delete"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.cmb_ParentHeadID)
        Me.Panel11.Controls.Add(Me.UltraLabel7)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(804, 54)
        Me.Panel11.TabIndex = 0
        '
        'cmb_ParentHeadID
        '
        Me.cmb_ParentHeadID.Location = New System.Drawing.Point(215, 16)
        Me.cmb_ParentHeadID.Name = "cmb_ParentHeadID"
        Me.cmb_ParentHeadID.Size = New System.Drawing.Size(328, 22)
        Me.cmb_ParentHeadID.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance8
        Me.UltraLabel7.Location = New System.Drawing.Point(79, 16)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(128, 24)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Parent Head"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(804, 372)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Label30)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_MatDesTableColID2)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_RemarkTypeCode)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl4.Controls.Add(Me.Label26)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_RemarkDesTableColID)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_QtyDesParam2ID)
        Me.UltraTabPageControl4.Controls.Add(Me.Label24)
        Me.UltraTabPageControl4.Controls.Add(Me.Label23)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_QtyDesTableColID)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_QtySelecType)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl4.Controls.Add(Me.Label22)
        Me.UltraTabPageControl4.Controls.Add(Me.Label20)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_MatDesTableColID)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_MatDesParamID)
        Me.UltraTabPageControl4.Controls.Add(Me.Label21)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_ItemSelecType)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl4.Controls.Add(Me.combo_ItemUnit)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_ItemName)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_FixedItemID)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel13)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel14)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel15)
        Me.UltraTabPageControl4.Controls.Add(Me.chk_QtyDesParamNA)
        Me.UltraTabPageControl4.Controls.Add(Me.Label7)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_NAParamValue2)
        Me.UltraTabPageControl4.Controls.Add(Me.Label8)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_QtyDesParamID)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_NADesParamID)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_NAParamValue1)
        Me.UltraTabPageControl4.Controls.Add(Me.Label16)
        Me.UltraTabPageControl4.Controls.Add(Me.Label15)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_FixedQty)
        Me.UltraTabPageControl4.Controls.Add(Me.Label11)
        Me.UltraTabPageControl4.Controls.Add(Me.Label6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(804, 372)
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(400, 103)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 16)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Value Column 2"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_MatDesTableColID2
        '
        Me.cmb_MatDesTableColID2.Location = New System.Drawing.Point(496, 103)
        Me.cmb_MatDesTableColID2.Name = "cmb_MatDesTableColID2"
        Me.cmb_MatDesTableColID2.Size = New System.Drawing.Size(280, 22)
        Me.cmb_MatDesTableColID2.TabIndex = 10
        Me.cmb_MatDesTableColID2.Text = "UltraCombo4"
        '
        'cmb_RemarkTypeCode
        '
        Me.cmb_RemarkTypeCode.Location = New System.Drawing.Point(105, 303)
        Me.cmb_RemarkTypeCode.Name = "cmb_RemarkTypeCode"
        Me.cmb_RemarkTypeCode.Size = New System.Drawing.Size(192, 21)
        Me.cmb_RemarkTypeCode.TabIndex = 34
        Me.cmb_RemarkTypeCode.Text = "UltraComboEditor1"
        '
        'UltraLabel6
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance9
        Me.UltraLabel6.Location = New System.Drawing.Point(25, 295)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(72, 40)
        Me.UltraLabel6.TabIndex = 33
        Me.UltraLabel6.Text = "Remark Selection Type"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(305, 303)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Remark Column"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_RemarkDesTableColID
        '
        Me.cmb_RemarkDesTableColID.Location = New System.Drawing.Point(401, 303)
        Me.cmb_RemarkDesTableColID.Name = "cmb_RemarkDesTableColID"
        Me.cmb_RemarkDesTableColID.Size = New System.Drawing.Size(280, 22)
        Me.cmb_RemarkDesTableColID.TabIndex = 36
        Me.cmb_RemarkDesTableColID.Text = "UltraCombo4"
        '
        'cmb_QtyDesParam2ID
        '
        Me.cmb_QtyDesParam2ID.DataMember = "Items"
        Me.cmb_QtyDesParam2ID.DisplayMember = "SubCatName"
        Me.cmb_QtyDesParam2ID.Location = New System.Drawing.Point(105, 223)
        Me.cmb_QtyDesParam2ID.MaxDropDownItems = 15
        Me.cmb_QtyDesParam2ID.Name = "cmb_QtyDesParam2ID"
        Me.cmb_QtyDesParam2ID.Size = New System.Drawing.Size(176, 22)
        Me.cmb_QtyDesParam2ID.TabIndex = 25
        Me.cmb_QtyDesParam2ID.Text = "UltraCombo1"
        Me.cmb_QtyDesParam2ID.ValueMember = "SubcatID"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(17, 223)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 32)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Qty Parameter 2 Code"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(297, 191)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 16)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Value Column"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_QtyDesTableColID
        '
        Me.cmb_QtyDesTableColID.Location = New System.Drawing.Point(393, 191)
        Me.cmb_QtyDesTableColID.Name = "cmb_QtyDesTableColID"
        Me.cmb_QtyDesTableColID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_QtyDesTableColID.TabIndex = 23
        Me.cmb_QtyDesTableColID.Text = "UltraCombo4"
        '
        'cmb_QtySelecType
        '
        Me.cmb_QtySelecType.Location = New System.Drawing.Point(105, 159)
        Me.cmb_QtySelecType.Name = "cmb_QtySelecType"
        Me.cmb_QtySelecType.Size = New System.Drawing.Size(312, 21)
        Me.cmb_QtySelecType.TabIndex = 16
        Me.cmb_QtySelecType.Text = "UltraComboEditor1"
        '
        'UltraLabel5
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance10
        Me.UltraLabel5.Location = New System.Drawing.Point(25, 151)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(72, 32)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "Qty Selection Type"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(421, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(375, 21)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Version Selection will be as defined in the sub category of the selected item"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(401, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Value Column"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_MatDesTableColID
        '
        Me.cmb_MatDesTableColID.Location = New System.Drawing.Point(497, 71)
        Me.cmb_MatDesTableColID.Name = "cmb_MatDesTableColID"
        Me.cmb_MatDesTableColID.Size = New System.Drawing.Size(280, 22)
        Me.cmb_MatDesTableColID.TabIndex = 6
        Me.cmb_MatDesTableColID.Text = "UltraCombo4"
        '
        'cmb_MatDesParamID
        '
        Me.cmb_MatDesParamID.DataMember = "Items"
        Me.cmb_MatDesParamID.DisplayMember = "SubCatName"
        Me.cmb_MatDesParamID.Location = New System.Drawing.Point(105, 71)
        Me.cmb_MatDesParamID.MaxDropDownItems = 15
        Me.cmb_MatDesParamID.Name = "cmb_MatDesParamID"
        Me.cmb_MatDesParamID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_MatDesParamID.TabIndex = 4
        Me.cmb_MatDesParamID.Text = "UltraCombo1"
        Me.cmb_MatDesParamID.ValueMember = "SubcatID"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 32)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Material Parameter Code"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemSelecType
        '
        Me.cmb_ItemSelecType.Location = New System.Drawing.Point(105, 39)
        Me.cmb_ItemSelecType.Name = "cmb_ItemSelecType"
        Me.cmb_ItemSelecType.Size = New System.Drawing.Size(312, 21)
        Me.cmb_ItemSelecType.TabIndex = 1
        Me.cmb_ItemSelecType.Text = "UltraComboEditor1"
        '
        'UltraLabel3
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance11
        Me.UltraLabel3.Location = New System.Drawing.Point(17, 31)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 24)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Item Selection Type"
        '
        'combo_ItemUnit
        '
        Me.combo_ItemUnit.DataMember = "items"
        Me.combo_ItemUnit.DisplayMember = "unitName"
        Me.combo_ItemUnit.Location = New System.Drawing.Point(641, 127)
        Me.combo_ItemUnit.Name = "combo_ItemUnit"
        Me.combo_ItemUnit.ReadOnly = True
        Me.combo_ItemUnit.Size = New System.Drawing.Size(120, 22)
        Me.combo_ItemUnit.TabIndex = 14
        Me.combo_ItemUnit.TabStop = False
        Me.combo_ItemUnit.ValueMember = "itemId"
        '
        'cmb_ItemName
        '
        Me.cmb_ItemName.DataMember = "items"
        Me.cmb_ItemName.DisplayMember = "itemName"
        Me.cmb_ItemName.Location = New System.Drawing.Point(105, 127)
        Me.cmb_ItemName.Name = "cmb_ItemName"
        Me.cmb_ItemName.Size = New System.Drawing.Size(456, 22)
        Me.cmb_ItemName.TabIndex = 12
        Me.cmb_ItemName.ValueMember = "itemId"
        '
        'cmb_FixedItemID
        '
        Me.cmb_FixedItemID.DataMember = "items"
        Me.cmb_FixedItemID.DisplayMember = "itemCode"
        Me.cmb_FixedItemID.Location = New System.Drawing.Point(105, 103)
        Me.cmb_FixedItemID.Name = "cmb_FixedItemID"
        Me.cmb_FixedItemID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_FixedItemID.TabIndex = 8
        Me.cmb_FixedItemID.ValueMember = "itemId"
        '
        'UltraLabel13
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance12
        Me.UltraLabel13.Location = New System.Drawing.Point(601, 127)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel13.TabIndex = 13
        Me.UltraLabel13.Text = "Unit"
        '
        'UltraLabel14
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance13
        Me.UltraLabel14.Location = New System.Drawing.Point(33, 127)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel14.TabIndex = 11
        Me.UltraLabel14.Text = "Item Name"
        '
        'UltraLabel15
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel15.Appearance = Appearance14
        Me.UltraLabel15.Location = New System.Drawing.Point(33, 103)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel15.TabIndex = 7
        Me.UltraLabel15.Text = "Item Code"
        '
        'chk_QtyDesParamNA
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.SizeInPoints = 8.0!
        Appearance15.TextHAlignAsString = "Left"
        Me.chk_QtyDesParamNA.Appearance = Appearance15
        Me.chk_QtyDesParamNA.Location = New System.Drawing.Point(593, 159)
        Me.chk_QtyDesParamNA.Name = "chk_QtyDesParamNA"
        Me.chk_QtyDesParamNA.Size = New System.Drawing.Size(168, 24)
        Me.chk_QtyDesParamNA.TabIndex = 19
        Me.chk_QtyDesParamNA.Text = "Discard Material Head if Qty Parameter is not present or 0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 24)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Material Head will be removed if this parameter is not found"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_NAParamValue2
        '
        Appearance16.FontData.SizeInPoints = 8.5!
        Me.txt_NAParamValue2.Appearance = Appearance16
        Me.txt_NAParamValue2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NAParamValue2.Location = New System.Drawing.Point(641, 263)
        Me.txt_NAParamValue2.Name = "txt_NAParamValue2"
        Me.txt_NAParamValue2.Size = New System.Drawing.Size(80, 22)
        Me.txt_NAParamValue2.TabIndex = 32
        Me.txt_NAParamValue2.Text = "UltraTextEditor2"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(553, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 32)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "NA Parameter Value 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_QtyDesParamID
        '
        Me.cmb_QtyDesParamID.DataMember = "Items"
        Me.cmb_QtyDesParamID.DisplayMember = "SubCatName"
        Me.cmb_QtyDesParamID.Location = New System.Drawing.Point(105, 191)
        Me.cmb_QtyDesParamID.MaxDropDownItems = 15
        Me.cmb_QtyDesParamID.Name = "cmb_QtyDesParamID"
        Me.cmb_QtyDesParamID.Size = New System.Drawing.Size(176, 22)
        Me.cmb_QtyDesParamID.TabIndex = 21
        Me.cmb_QtyDesParamID.Text = "UltraCombo1"
        Me.cmb_QtyDesParamID.ValueMember = "SubcatID"
        '
        'cmb_NADesParamID
        '
        Me.cmb_NADesParamID.DataMember = "Items"
        Me.cmb_NADesParamID.DisplayMember = "SubCatName"
        Me.cmb_NADesParamID.Location = New System.Drawing.Point(105, 263)
        Me.cmb_NADesParamID.MaxDropDownItems = 15
        Me.cmb_NADesParamID.Name = "cmb_NADesParamID"
        Me.cmb_NADesParamID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_NADesParamID.TabIndex = 29
        Me.cmb_NADesParamID.Text = "UltraCombo1"
        Me.cmb_NADesParamID.ValueMember = "SubcatID"
        '
        'txt_NAParamValue1
        '
        Appearance17.FontData.SizeInPoints = 8.5!
        Me.txt_NAParamValue1.Appearance = Appearance17
        Me.txt_NAParamValue1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NAParamValue1.Location = New System.Drawing.Point(385, 223)
        Me.txt_NAParamValue1.Name = "txt_NAParamValue1"
        Me.txt_NAParamValue1.Size = New System.Drawing.Size(80, 22)
        Me.txt_NAParamValue1.TabIndex = 27
        Me.txt_NAParamValue1.Text = "UltraTextEditor2"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(297, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 32)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "NA Parameter Value 1"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 32)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Qty Parameter Code"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_FixedQty
        '
        Appearance18.FontData.SizeInPoints = 8.5!
        Me.txt_FixedQty.Appearance = Appearance18
        Me.txt_FixedQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FixedQty.Location = New System.Drawing.Point(513, 159)
        Me.txt_FixedQty.Name = "txt_FixedQty"
        Me.txt_FixedQty.Size = New System.Drawing.Size(72, 22)
        Me.txt_FixedQty.TabIndex = 18
        Me.txt_FixedQty.Text = "UltraTextEditor4"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fixed Qty"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "NA Parameter Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_CostFactorRate)
        Me.UltraTabPageControl2.Controls.Add(Me.Label29)
        Me.UltraTabPageControl2.Controls.Add(Me.Label27)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_RateDesTableCol2ID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label19)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostQtyDesTableColID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostQtyDesParam2ID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label18)
        Me.UltraTabPageControl2.Controls.Add(Me.Label17)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_RateDesTableColID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostQtyDesParamID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label14)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_CostFactor)
        Me.UltraTabPageControl2.Controls.Add(Me.Label13)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_CostFixedQty)
        Me.UltraTabPageControl2.Controls.Add(Me.Label12)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostingItemID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label10)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_RateDesParamID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label1)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostQtyCode)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl2.Controls.Add(Me.Label5)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostingUnitID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_CostRateCode)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(804, 372)
        '
        'txt_CostFactorRate
        '
        Appearance19.FontData.SizeInPoints = 8.5!
        Me.txt_CostFactorRate.Appearance = Appearance19
        Me.txt_CostFactorRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostFactorRate.Location = New System.Drawing.Point(97, 307)
        Me.txt_CostFactorRate.Name = "txt_CostFactorRate"
        Me.txt_CostFactorRate.Size = New System.Drawing.Size(136, 22)
        Me.txt_CostFactorRate.TabIndex = 11
        Me.txt_CostFactorRate.Text = "UltraTextEditor4"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(97, 288)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(124, 16)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Multiplication factor Rate"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(99, 182)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Value Column 2"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_RateDesTableCol2ID
        '
        Me.cmb_RateDesTableCol2ID.Location = New System.Drawing.Point(99, 198)
        Me.cmb_RateDesTableCol2ID.Name = "cmb_RateDesTableCol2ID"
        Me.cmb_RateDesTableCol2ID.Size = New System.Drawing.Size(280, 22)
        Me.cmb_RateDesTableCol2ID.TabIndex = 7
        Me.cmb_RateDesTableCol2ID.Text = "UltraCombo4"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(436, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Value Column"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_CostQtyDesTableColID
        '
        Me.cmb_CostQtyDesTableColID.Location = New System.Drawing.Point(436, 198)
        Me.cmb_CostQtyDesTableColID.Name = "cmb_CostQtyDesTableColID"
        Me.cmb_CostQtyDesTableColID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_CostQtyDesTableColID.TabIndex = 20
        Me.cmb_CostQtyDesTableColID.Text = "UltraCombo4"
        '
        'cmb_CostQtyDesParam2ID
        '
        Me.cmb_CostQtyDesParam2ID.DataMember = "Items"
        Me.cmb_CostQtyDesParam2ID.DisplayMember = "SubCatName"
        Me.cmb_CostQtyDesParam2ID.Location = New System.Drawing.Point(436, 150)
        Me.cmb_CostQtyDesParam2ID.MaxDropDownItems = 15
        Me.cmb_CostQtyDesParam2ID.Name = "cmb_CostQtyDesParam2ID"
        Me.cmb_CostQtyDesParam2ID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_CostQtyDesParam2ID.TabIndex = 18
        Me.cmb_CostQtyDesParam2ID.Text = "UltraCombo1"
        Me.cmb_CostQtyDesParam2ID.ValueMember = "SubcatID"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(436, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Qty Parameter Code 2"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(100, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Value Column"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_RateDesTableColID
        '
        Me.cmb_RateDesTableColID.Location = New System.Drawing.Point(100, 150)
        Me.cmb_RateDesTableColID.Name = "cmb_RateDesTableColID"
        Me.cmb_RateDesTableColID.Size = New System.Drawing.Size(280, 22)
        Me.cmb_RateDesTableColID.TabIndex = 5
        Me.cmb_RateDesTableColID.Text = "UltraCombo4"
        '
        'cmb_CostQtyDesParamID
        '
        Me.cmb_CostQtyDesParamID.DataMember = "Items"
        Me.cmb_CostQtyDesParamID.DisplayMember = "SubCatName"
        Me.cmb_CostQtyDesParamID.Location = New System.Drawing.Point(436, 102)
        Me.cmb_CostQtyDesParamID.MaxDropDownItems = 15
        Me.cmb_CostQtyDesParamID.Name = "cmb_CostQtyDesParamID"
        Me.cmb_CostQtyDesParamID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_CostQtyDesParamID.TabIndex = 16
        Me.cmb_CostQtyDesParamID.Text = "UltraCombo1"
        Me.cmb_CostQtyDesParamID.ValueMember = "SubcatID"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(436, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Qty Parameter Code 1"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_CostFactor
        '
        Appearance20.FontData.SizeInPoints = 8.5!
        Me.txt_CostFactor.Appearance = Appearance20
        Me.txt_CostFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostFactor.Location = New System.Drawing.Point(436, 307)
        Me.txt_CostFactor.Name = "txt_CostFactor"
        Me.txt_CostFactor.Size = New System.Drawing.Size(136, 22)
        Me.txt_CostFactor.TabIndex = 0
        Me.txt_CostFactor.Text = "UltraTextEditor4"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(436, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Multiplication factor Qty"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_CostFixedQty
        '
        Appearance21.FontData.SizeInPoints = 8.5!
        Me.txt_CostFixedQty.Appearance = Appearance21
        Me.txt_CostFixedQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostFixedQty.Location = New System.Drawing.Point(460, 246)
        Me.txt_CostFixedQty.Name = "txt_CostFixedQty"
        Me.txt_CostFixedQty.Size = New System.Drawing.Size(56, 22)
        Me.txt_CostFixedQty.TabIndex = 22
        Me.txt_CostFixedQty.Text = "UltraTextEditor4"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(389, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Fixed Qty"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cmb_CostingItemID
        '
        Me.cmb_CostingItemID.DataMember = "Items"
        Me.cmb_CostingItemID.DisplayMember = "SubCatName"
        Me.cmb_CostingItemID.Location = New System.Drawing.Point(100, 240)
        Me.cmb_CostingItemID.MaxDropDownItems = 15
        Me.cmb_CostingItemID.Name = "cmb_CostingItemID"
        Me.cmb_CostingItemID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_CostingItemID.TabIndex = 9
        Me.cmb_CostingItemID.Text = "UltraCombo2"
        Me.cmb_CostingItemID.ValueMember = "SubcatID"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(100, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fixed Costing Item"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_RateDesParamID
        '
        Me.cmb_RateDesParamID.DataMember = "Items"
        Me.cmb_RateDesParamID.DisplayMember = "SubCatName"
        Me.cmb_RateDesParamID.Location = New System.Drawing.Point(100, 102)
        Me.cmb_RateDesParamID.MaxDropDownItems = 15
        Me.cmb_RateDesParamID.Name = "cmb_RateDesParamID"
        Me.cmb_RateDesParamID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_RateDesParamID.TabIndex = 3
        Me.cmb_RateDesParamID.Text = "UltraCombo1"
        Me.cmb_RateDesParamID.ValueMember = "SubcatID"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rate Parameter Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_CostQtyCode
        '
        Me.cmb_CostQtyCode.Location = New System.Drawing.Point(436, 54)
        Me.cmb_CostQtyCode.Name = "cmb_CostQtyCode"
        Me.cmb_CostQtyCode.Size = New System.Drawing.Size(272, 21)
        Me.cmb_CostQtyCode.TabIndex = 14
        Me.cmb_CostQtyCode.Text = "UltraComboEditor1"
        '
        'UltraLabel2
        '
        Appearance22.TextHAlignAsString = "Left"
        Me.UltraLabel2.Appearance = Appearance22
        Me.UltraLabel2.Location = New System.Drawing.Point(436, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(112, 16)
        Me.UltraLabel2.TabIndex = 13
        Me.UltraLabel2.Text = "Qty Selection Type"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(516, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Costing Unit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CostingUnitID
        '
        Me.cmb_CostingUnitID.Location = New System.Drawing.Point(604, 246)
        Me.cmb_CostingUnitID.Name = "cmb_CostingUnitID"
        Me.cmb_CostingUnitID.Size = New System.Drawing.Size(104, 22)
        Me.cmb_CostingUnitID.TabIndex = 24
        Me.cmb_CostingUnitID.Text = "UltraCombo4"
        '
        'cmb_CostRateCode
        '
        Me.cmb_CostRateCode.Location = New System.Drawing.Point(100, 54)
        Me.cmb_CostRateCode.Name = "cmb_CostRateCode"
        Me.cmb_CostRateCode.Size = New System.Drawing.Size(264, 21)
        Me.cmb_CostRateCode.TabIndex = 1
        Me.cmb_CostRateCode.Text = "UltraComboEditor1"
        '
        'UltraLabel8
        '
        Appearance23.TextHAlignAsString = "Left"
        Me.UltraLabel8.Appearance = Appearance23
        Me.UltraLabel8.Location = New System.Drawing.Point(100, 38)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(136, 16)
        Me.UltraLabel8.TabIndex = 0
        Me.UltraLabel8.Text = "Rate Selection Type"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(804, 372)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 517)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(808, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance24.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance24
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(544, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance25.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance25
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(632, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance26.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance26
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(720, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_SelectionType)
        Me.Panel1.Controls.Add(Me.UltraLabel11)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_ItemUnitID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_HeadName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_HeadTypeID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 119)
        Me.Panel1.TabIndex = 0
        '
        'cmb_SelectionType
        '
        Me.cmb_SelectionType.Location = New System.Drawing.Point(152, 81)
        Me.cmb_SelectionType.Name = "cmb_SelectionType"
        Me.cmb_SelectionType.Size = New System.Drawing.Size(272, 21)
        Me.cmb_SelectionType.TabIndex = 7
        Me.cmb_SelectionType.Text = "UltraComboEditor1"
        '
        'UltraLabel11
        '
        Appearance27.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance27
        Me.UltraLabel11.Location = New System.Drawing.Point(56, 81)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel11.TabIndex = 6
        Me.UltraLabel11.Text = "Selection Type"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(504, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Material List Unit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemUnitID
        '
        Me.cmb_ItemUnitID.Location = New System.Drawing.Point(616, 17)
        Me.cmb_ItemUnitID.Name = "cmb_ItemUnitID"
        Me.cmb_ItemUnitID.Size = New System.Drawing.Size(104, 22)
        Me.cmb_ItemUnitID.TabIndex = 3
        Me.cmb_ItemUnitID.Text = "UltraCombo4"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(48, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Head Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_HeadName
        '
        Me.txt_HeadName.Location = New System.Drawing.Point(152, 49)
        Me.txt_HeadName.Name = "txt_HeadName"
        Me.txt_HeadName.Size = New System.Drawing.Size(392, 21)
        Me.txt_HeadName.TabIndex = 5
        Me.txt_HeadName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(80, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Head Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_HeadTypeID
        '
        Me.cmb_HeadTypeID.Location = New System.Drawing.Point(152, 17)
        Me.cmb_HeadTypeID.Name = "cmb_HeadTypeID"
        Me.cmb_HeadTypeID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_HeadTypeID.TabIndex = 1
        Me.cmb_HeadTypeID.Text = "UltraCombo4"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 119)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(808, 398)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab13.TabPage = Me.UltraTabPageControl11
        UltraTab13.Text = "Basic"
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Item Sub Categories"
        UltraTab11.TabPage = Me.UltraTabPageControl9
        UltraTab11.Text = "Planning"
        UltraTab5.Key = "trans"
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Parameter Translation"
        UltraTab1.Key = "auto2"
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "Auto Matlist1"
        UltraTab6.Key = "auto1"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Auto Costing"
        UltraTab8.Key = "formula"
        UltraTab8.TabPage = Me.UltraTabPageControl5
        UltraTab8.Text = "Formulae"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab13, UltraTab4, UltraTab11, UltraTab5, UltraTab1, UltraTab6, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(804, 372)
        '
        'frmMatHead
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Material Head"
        Me.ClientSize = New System.Drawing.Size(808, 559)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMatHead"
        Me.Text = "Material Head"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        Me.UltraTabPageControl11.PerformLayout()
        CType(Me.cmb_HeadNumType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HeadCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HeadNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OpenedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsForMatList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsForCostingMats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ForceInMatPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsForMatList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsOld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.cmb_ParentHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.cmb_MatDesTableColID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RemarkTypeCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RemarkDesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_QtyDesParam2ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_QtyDesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_QtySelecType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatDesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatDesParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemSelecType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_FixedItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_QtyDesParamNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NAParamValue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_QtyDesParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_NADesParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NAParamValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FixedQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_CostFactorRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RateDesTableCol2ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostQtyDesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostQtyDesParam2ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RateDesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostQtyDesParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CostFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CostFixedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostingItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RateDesParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostQtyCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostingUnitID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CostRateCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_SelectionType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemUnitID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HeadName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_HeadTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_OpenedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmb_ParentHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_IsForMatList1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsForCostingMats As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_ForceInMatPlan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsForMatList2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsOld As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_HeadNumType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_HeadCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_HeadNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmb_MatDesTableColID2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_RemarkTypeCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmb_RemarkDesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_QtyDesParam2ID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_QtyDesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_QtySelecType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmb_MatDesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_MatDesParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_ItemSelecType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents combo_ItemUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_FixedItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_QtyDesParamNA As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_NAParamValue2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_QtyDesParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_NADesParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_NAParamValue1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_FixedQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_CostFactorRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmb_RateDesTableCol2ID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_CostQtyDesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_CostQtyDesParam2ID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_RateDesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_CostQtyDesParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_CostFactor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_CostFixedQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_CostingItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_RateDesParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_CostQtyCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_CostingUnitID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_CostRateCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAddSeqProc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelSeqProc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSub As Infragistics.Win.Misc.UltraButton

#End Region
End Class


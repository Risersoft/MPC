<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmOp
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_OpName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOpID1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOPID2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOpID3 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_SetupTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_VarRunTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_VarRunQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMac As System.Windows.Forms.Label
    Friend WithEvents btnMac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMacGroup As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_AltOpID3 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_AltOpID2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_AltOpID1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOpID6 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOpID5 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevOpID4 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_SortIndex As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridBatching As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnDelBatch As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddBatch As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnRemoveMac As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chk_lockedseq = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_MovetoStdAlt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_opdispoption = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.chk_DoNotOutputRes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_DoNotOutputMac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_MaxWaitTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_MinWaitTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_OverlapPer = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Overlapcount = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnMac = New Infragistics.Win.Misc.UltraButton()
        Me.btnMacGroup = New Infragistics.Win.Misc.UltraButton()
        Me.lblMac = New System.Windows.Forms.Label()
        Me.btnRemoveMac = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmb_PrevOpID1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_PrevOpID4 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_PrevOPID2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmb_PrevOpID3 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_PrevOpID5 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_PrevOpID6 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmb_AltOpID1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_AltOpID2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_AltOpID3 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.txt_SetupTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_FixedRunTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_StepFactor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_MinSplitQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_SplitMacNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_PeriodicRunQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_PeriodicRunTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_VarRunQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_VarRunTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_TearDownTime = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridBatching = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnDelBatch = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddBatch = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_DelayAfter = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_DelayBefore = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SortIndex = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_OpName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.chk_lockedseq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_MovetoStdAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_opdispoption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_DoNotOutputRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_DoNotOutputMac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txt_MaxWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MinWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OverlapPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Overlapcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cmb_PrevOpID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevOpID4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevOPID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevOpID3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevOpID5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevOpID6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cmb_AltOpID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_AltOpID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_AltOpID3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.txt_SetupTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.txt_FixedRunTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StepFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MinSplitQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SplitMacNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PeriodicRunQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PeriodicRunTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VarRunQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VarRunTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.txt_TearDownTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridBatching, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.txt_DelayAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DelayBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_SortIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(725, 401)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chk_lockedseq)
        Me.Panel3.Controls.Add(Me.chk_MovetoStdAlt)
        Me.Panel3.Controls.Add(Me.cmb_opdispoption)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.chk_DoNotOutputRes)
        Me.Panel3.Controls.Add(Me.chk_DoNotOutputMac)
        Me.Panel3.Controls.Add(Me.UltraGroupBox4)
        Me.Panel3.Controls.Add(Me.UltraGroupBox3)
        Me.Panel3.Controls.Add(Me.UltraGroupBox2)
        Me.Panel3.Controls.Add(Me.UltraGroupBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_Remark)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(725, 401)
        Me.Panel3.TabIndex = 0
        '
        'chk_lockedseq
        '
        Me.chk_lockedseq.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_lockedseq.Location = New System.Drawing.Point(542, 169)
        Me.chk_lockedseq.Name = "chk_lockedseq"
        Me.chk_lockedseq.Size = New System.Drawing.Size(170, 25)
        Me.chk_lockedseq.TabIndex = 4
        Me.chk_lockedseq.Text = "Locked Operation Start relative to Previous Operations"
        '
        'chk_MovetoStdAlt
        '
        Me.chk_MovetoStdAlt.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_MovetoStdAlt.Location = New System.Drawing.Point(302, 169)
        Me.chk_MovetoStdAlt.Name = "chk_MovetoStdAlt"
        Me.chk_MovetoStdAlt.Size = New System.Drawing.Size(213, 24)
        Me.chk_MovetoStdAlt.TabIndex = 3
        Me.chk_MovetoStdAlt.Text = "Mark as Alternate Operation"
        '
        'cmb_opdispoption
        '
        ValueListItem1.DataValue = CType(0, Short)
        ValueListItem1.DisplayText = "Sequence Process Only"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Operation Only"
        ValueListItem3.DataValue = CType(0, Short)
        ValueListItem3.DisplayText = "Sequence and Operation"
        Me.cmb_opdispoption.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.cmb_opdispoption.Location = New System.Drawing.Point(518, 324)
        Me.cmb_opdispoption.Name = "cmb_opdispoption"
        Me.cmb_opdispoption.Size = New System.Drawing.Size(177, 21)
        Me.cmb_opdispoption.TabIndex = 9
        Me.cmb_opdispoption.Text = "UltraComboEditor9"
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(430, 323)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(82, 21)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Display Type"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_DoNotOutputRes
        '
        Me.chk_DoNotOutputRes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_DoNotOutputRes.Location = New System.Drawing.Point(261, 322)
        Me.chk_DoNotOutputRes.Name = "chk_DoNotOutputRes"
        Me.chk_DoNotOutputRes.Size = New System.Drawing.Size(152, 24)
        Me.chk_DoNotOutputRes.TabIndex = 7
        Me.chk_DoNotOutputRes.Text = "Do not output Resources"
        '
        'chk_DoNotOutputMac
        '
        Me.chk_DoNotOutputMac.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_DoNotOutputMac.Location = New System.Drawing.Point(103, 323)
        Me.chk_DoNotOutputMac.Name = "chk_DoNotOutputMac"
        Me.chk_DoNotOutputMac.Size = New System.Drawing.Size(152, 21)
        Me.chk_DoNotOutputMac.TabIndex = 6
        Me.chk_DoNotOutputMac.Text = "Do not output Machine"
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.Label28)
        Me.UltraGroupBox4.Controls.Add(Me.txt_MaxWaitTime)
        Me.UltraGroupBox4.Controls.Add(Me.Label29)
        Me.UltraGroupBox4.Controls.Add(Me.Label30)
        Me.UltraGroupBox4.Controls.Add(Me.txt_MinWaitTime)
        Me.UltraGroupBox4.Controls.Add(Me.Label31)
        Me.UltraGroupBox4.Controls.Add(Me.txt_OverlapPer)
        Me.UltraGroupBox4.Controls.Add(Me.txt_Overlapcount)
        Me.UltraGroupBox4.Controls.Add(Me.Label27)
        Me.UltraGroupBox4.Controls.Add(Me.Label25)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(542, 3)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(173, 160)
        Me.UltraGroupBox4.TabIndex = 2
        Me.UltraGroupBox4.Text = "Sequence"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(155, 116)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(16, 16)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "hr"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_MaxWaitTime
        '
        Appearance9.FontData.SizeInPoints = 8.5!
        Me.txt_MaxWaitTime.Appearance = Appearance9
        Me.txt_MaxWaitTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaxWaitTime.Location = New System.Drawing.Point(98, 113)
        Me.txt_MaxWaitTime.Name = "txt_MaxWaitTime"
        Me.txt_MaxWaitTime.Size = New System.Drawing.Size(55, 22)
        Me.txt_MaxWaitTime.TabIndex = 8
        Me.txt_MaxWaitTime.Text = "UltraTextEditor2"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(7, 118)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 17)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Max Wait Time"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(154, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 16)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "hr"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_MinWaitTime
        '
        Appearance10.FontData.SizeInPoints = 8.5!
        Me.txt_MinWaitTime.Appearance = Appearance10
        Me.txt_MinWaitTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MinWaitTime.Location = New System.Drawing.Point(98, 85)
        Me.txt_MinWaitTime.Name = "txt_MinWaitTime"
        Me.txt_MinWaitTime.Size = New System.Drawing.Size(55, 22)
        Me.txt_MinWaitTime.TabIndex = 5
        Me.txt_MinWaitTime.Text = "UltraTextEditor1"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Min Wait Time"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_OverlapPer
        '
        Appearance24.FontData.SizeInPoints = 8.5!
        Me.txt_OverlapPer.Appearance = Appearance24
        Me.txt_OverlapPer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OverlapPer.Location = New System.Drawing.Point(98, 28)
        Me.txt_OverlapPer.Name = "txt_OverlapPer"
        Me.txt_OverlapPer.Size = New System.Drawing.Size(55, 22)
        Me.txt_OverlapPer.TabIndex = 1
        Me.txt_OverlapPer.Text = "UltraTextEditor2"
        '
        'txt_Overlapcount
        '
        Appearance25.FontData.SizeInPoints = 8.5!
        Me.txt_Overlapcount.Appearance = Appearance25
        Me.txt_Overlapcount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Overlapcount.Location = New System.Drawing.Point(98, 56)
        Me.txt_Overlapcount.Name = "txt_Overlapcount"
        Me.txt_Overlapcount.Size = New System.Drawing.Size(55, 22)
        Me.txt_Overlapcount.TabIndex = 3
        Me.txt_Overlapcount.Text = "UltraTextEditor1"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(4, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 19)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Overlap count"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(26, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Overlap %"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.btnMac)
        Me.UltraGroupBox3.Controls.Add(Me.btnMacGroup)
        Me.UltraGroupBox3.Controls.Add(Me.lblMac)
        Me.UltraGroupBox3.Controls.Add(Me.btnRemoveMac)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(50, 214)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(665, 103)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.Text = "Select Machine"
        '
        'btnMac
        '
        Me.btnMac.Location = New System.Drawing.Point(29, 20)
        Me.btnMac.Name = "btnMac"
        Me.btnMac.Size = New System.Drawing.Size(104, 24)
        Me.btnMac.TabIndex = 0
        Me.btnMac.Text = "Machine"
        '
        'btnMacGroup
        '
        Me.btnMacGroup.Location = New System.Drawing.Point(29, 44)
        Me.btnMacGroup.Name = "btnMacGroup"
        Me.btnMacGroup.Size = New System.Drawing.Size(104, 24)
        Me.btnMacGroup.TabIndex = 1
        Me.btnMacGroup.Text = "Machine Group"
        '
        'lblMac
        '
        Me.lblMac.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMac.Location = New System.Drawing.Point(148, 20)
        Me.lblMac.Name = "lblMac"
        Me.lblMac.Size = New System.Drawing.Size(497, 76)
        Me.lblMac.TabIndex = 3
        Me.lblMac.Text = "Machine name here"
        Me.lblMac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemoveMac
        '
        Me.btnRemoveMac.Location = New System.Drawing.Point(29, 72)
        Me.btnRemoveMac.Name = "btnRemoveMac"
        Me.btnRemoveMac.Size = New System.Drawing.Size(104, 24)
        Me.btnRemoveMac.TabIndex = 2
        Me.btnRemoveMac.Text = "Remove Machine"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOpID1)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOpID4)
        Me.UltraGroupBox2.Controls.Add(Me.Label13)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOPID2)
        Me.UltraGroupBox2.Controls.Add(Me.Label21)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOpID3)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOpID5)
        Me.UltraGroupBox2.Controls.Add(Me.Label19)
        Me.UltraGroupBox2.Controls.Add(Me.Label12)
        Me.UltraGroupBox2.Controls.Add(Me.Label20)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_PrevOpID6)
        Me.UltraGroupBox2.Controls.Add(Me.Label3)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(50, 3)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(240, 205)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "Previous Operations"
        '
        'cmb_PrevOpID1
        '
        Me.cmb_PrevOpID1.DataMember = "Items"
        Me.cmb_PrevOpID1.DisplayMember = "SubCatName"
        Me.cmb_PrevOpID1.Location = New System.Drawing.Point(98, 26)
        Me.cmb_PrevOpID1.MaxDropDownItems = 15
        Me.cmb_PrevOpID1.Name = "cmb_PrevOpID1"
        Me.cmb_PrevOpID1.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOpID1.TabIndex = 1
        Me.cmb_PrevOpID1.Text = "UltraCombo1"
        Me.cmb_PrevOpID1.ValueMember = "SubcatID"
        '
        'cmb_PrevOpID4
        '
        Me.cmb_PrevOpID4.DataMember = "Items"
        Me.cmb_PrevOpID4.DisplayMember = "SubCatName"
        Me.cmb_PrevOpID4.Location = New System.Drawing.Point(98, 110)
        Me.cmb_PrevOpID4.MaxDropDownItems = 15
        Me.cmb_PrevOpID4.Name = "cmb_PrevOpID4"
        Me.cmb_PrevOpID4.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOpID4.TabIndex = 7
        Me.cmb_PrevOpID4.Text = "UltraCombo1"
        Me.cmb_PrevOpID4.ValueMember = "SubcatID"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(10, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Previous Op 3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevOPID2
        '
        Me.cmb_PrevOPID2.DataMember = "Items"
        Me.cmb_PrevOPID2.DisplayMember = "SubCatName"
        Me.cmb_PrevOPID2.Location = New System.Drawing.Point(98, 54)
        Me.cmb_PrevOPID2.MaxDropDownItems = 15
        Me.cmb_PrevOPID2.Name = "cmb_PrevOPID2"
        Me.cmb_PrevOPID2.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOPID2.TabIndex = 3
        Me.cmb_PrevOPID2.Text = "UltraCombo1"
        Me.cmb_PrevOPID2.ValueMember = "SubcatID"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(10, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 24)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Previous Op 4"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevOpID3
        '
        Me.cmb_PrevOpID3.DataMember = "Items"
        Me.cmb_PrevOpID3.DisplayMember = "SubCatName"
        Me.cmb_PrevOpID3.Location = New System.Drawing.Point(98, 82)
        Me.cmb_PrevOpID3.MaxDropDownItems = 15
        Me.cmb_PrevOpID3.Name = "cmb_PrevOpID3"
        Me.cmb_PrevOpID3.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOpID3.TabIndex = 5
        Me.cmb_PrevOpID3.Text = "UltraCombo2"
        Me.cmb_PrevOpID3.ValueMember = "SubcatID"
        '
        'cmb_PrevOpID5
        '
        Me.cmb_PrevOpID5.DataMember = "Items"
        Me.cmb_PrevOpID5.DisplayMember = "SubCatName"
        Me.cmb_PrevOpID5.Location = New System.Drawing.Point(98, 138)
        Me.cmb_PrevOpID5.MaxDropDownItems = 15
        Me.cmb_PrevOpID5.Name = "cmb_PrevOpID5"
        Me.cmb_PrevOpID5.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOpID5.TabIndex = 9
        Me.cmb_PrevOpID5.Text = "UltraCombo1"
        Me.cmb_PrevOpID5.ValueMember = "SubcatID"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(10, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 24)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Previous Op 6"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(10, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Previous Op 2"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(10, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 24)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Previous Op 5"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevOpID6
        '
        Me.cmb_PrevOpID6.DataMember = "Items"
        Me.cmb_PrevOpID6.DisplayMember = "SubCatName"
        Me.cmb_PrevOpID6.Location = New System.Drawing.Point(98, 166)
        Me.cmb_PrevOpID6.MaxDropDownItems = 15
        Me.cmb_PrevOpID6.Name = "cmb_PrevOpID6"
        Me.cmb_PrevOpID6.Size = New System.Drawing.Size(136, 22)
        Me.cmb_PrevOpID6.TabIndex = 11
        Me.cmb_PrevOpID6.Text = "UltraCombo2"
        Me.cmb_PrevOpID6.ValueMember = "SubcatID"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Previous Op 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cmb_AltOpID1)
        Me.UltraGroupBox1.Controls.Add(Me.Label17)
        Me.UltraGroupBox1.Controls.Add(Me.cmb_AltOpID2)
        Me.UltraGroupBox1.Controls.Add(Me.Label16)
        Me.UltraGroupBox1.Controls.Add(Me.cmb_AltOpID3)
        Me.UltraGroupBox1.Controls.Add(Me.Label15)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(296, 3)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(240, 160)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Alternate Operations"
        '
        'cmb_AltOpID1
        '
        Me.cmb_AltOpID1.DataMember = "Items"
        Me.cmb_AltOpID1.DisplayMember = "SubCatName"
        Me.cmb_AltOpID1.Location = New System.Drawing.Point(83, 33)
        Me.cmb_AltOpID1.MaxDropDownItems = 15
        Me.cmb_AltOpID1.Name = "cmb_AltOpID1"
        Me.cmb_AltOpID1.Size = New System.Drawing.Size(136, 22)
        Me.cmb_AltOpID1.TabIndex = 1
        Me.cmb_AltOpID1.Text = "UltraCombo1"
        Me.cmb_AltOpID1.ValueMember = "SubcatID"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(3, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 24)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Alternate Op 1"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_AltOpID2
        '
        Me.cmb_AltOpID2.DataMember = "Items"
        Me.cmb_AltOpID2.DisplayMember = "SubCatName"
        Me.cmb_AltOpID2.Location = New System.Drawing.Point(83, 61)
        Me.cmb_AltOpID2.MaxDropDownItems = 15
        Me.cmb_AltOpID2.Name = "cmb_AltOpID2"
        Me.cmb_AltOpID2.Size = New System.Drawing.Size(136, 22)
        Me.cmb_AltOpID2.TabIndex = 3
        Me.cmb_AltOpID2.Text = "UltraCombo1"
        Me.cmb_AltOpID2.ValueMember = "SubcatID"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(3, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Alternate Op 2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_AltOpID3
        '
        Me.cmb_AltOpID3.DataMember = "Items"
        Me.cmb_AltOpID3.DisplayMember = "SubCatName"
        Me.cmb_AltOpID3.Location = New System.Drawing.Point(83, 89)
        Me.cmb_AltOpID3.MaxDropDownItems = 15
        Me.cmb_AltOpID3.Name = "cmb_AltOpID3"
        Me.cmb_AltOpID3.Size = New System.Drawing.Size(136, 22)
        Me.cmb_AltOpID3.TabIndex = 5
        Me.cmb_AltOpID3.Text = "UltraCombo2"
        Me.cmb_AltOpID3.ValueMember = "SubcatID"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(3, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 24)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Alternate Op 3"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Remark"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Appearance18.FontData.SizeInPoints = 8.5!
        Me.txt_Remark.Appearance = Appearance18
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remark.Location = New System.Drawing.Point(103, 352)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(592, 40)
        Me.txt_Remark.TabIndex = 11
        Me.txt_Remark.Text = "UltraTextEditor1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(725, 401)
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_SetupTime)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Label5)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Label6)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(725, 61)
        Me.UltraPanel1.TabIndex = 0
        '
        'txt_SetupTime
        '
        Appearance17.FontData.SizeInPoints = 8.5!
        Me.txt_SetupTime.Appearance = Appearance17
        Me.txt_SetupTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SetupTime.Location = New System.Drawing.Point(103, 14)
        Me.txt_SetupTime.Name = "txt_SetupTime"
        Me.txt_SetupTime.Size = New System.Drawing.Size(72, 22)
        Me.txt_SetupTime.TabIndex = 1
        Me.txt_SetupTime.Text = "UltraTextEditor1"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Setup Time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "hr"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraPanel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(725, 401)
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label40)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_FixedRunTime)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label8)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label7)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label39)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_StepFactor)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label22)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_MinSplitQty)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label26)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_SplitMacNum)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label23)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_PeriodicRunQty)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label4)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label14)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_PeriodicRunTime)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label18)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_VarRunQty)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label11)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label10)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_VarRunTime)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.Label9)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(725, 125)
        Me.UltraPanel2.TabIndex = 0
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(269, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(416, 16)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "Periodic Run Qty and Min Split Qty are related to Lot Qty"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_FixedRunTime
        '
        Appearance16.FontData.SizeInPoints = 8.5!
        Me.txt_FixedRunTime.Appearance = Appearance16
        Me.txt_FixedRunTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FixedRunTime.Location = New System.Drawing.Point(103, 89)
        Me.txt_FixedRunTime.Name = "txt_FixedRunTime"
        Me.txt_FixedRunTime.Size = New System.Drawing.Size(72, 22)
        Me.txt_FixedRunTime.TabIndex = 18
        Me.txt_FixedRunTime.Text = "UltraTextEditor2"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Fixed Run Time"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "hr"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(240, 70)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(445, 16)
        Me.Label39.TabIndex = 16
        Me.Label39.Text = "Note: Operation Var Run Time = Var Run Time / Var Run Qty * Lot Qty * Step Factor" &
    ""
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_StepFactor
        '
        Appearance20.FontData.SizeInPoints = 8.5!
        Me.txt_StepFactor.Appearance = Appearance20
        Me.txt_StepFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StepFactor.Location = New System.Drawing.Point(103, 64)
        Me.txt_StepFactor.Name = "txt_StepFactor"
        Me.txt_StepFactor.Size = New System.Drawing.Size(72, 22)
        Me.txt_StepFactor.TabIndex = 15
        Me.txt_StepFactor.Text = "UltraTextEditor4"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Step Factor"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_MinSplitQty
        '
        Appearance2.FontData.SizeInPoints = 8.5!
        Me.txt_MinSplitQty.Appearance = Appearance2
        Me.txt_MinSplitQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MinSplitQty.Location = New System.Drawing.Point(568, 39)
        Me.txt_MinSplitQty.Name = "txt_MinSplitQty"
        Me.txt_MinSplitQty.Size = New System.Drawing.Size(72, 22)
        Me.txt_MinSplitQty.TabIndex = 13
        Me.txt_MinSplitQty.Text = "UltraTextEditor3"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(438, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(122, 16)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Min Split Qty"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_SplitMacNum
        '
        Appearance3.FontData.SizeInPoints = 8.5!
        Me.txt_SplitMacNum.Appearance = Appearance3
        Me.txt_SplitMacNum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SplitMacNum.Location = New System.Drawing.Point(568, 14)
        Me.txt_SplitMacNum.Name = "txt_SplitMacNum"
        Me.txt_SplitMacNum.Size = New System.Drawing.Size(72, 22)
        Me.txt_SplitMacNum.TabIndex = 7
        Me.txt_SplitMacNum.Text = "UltraTextEditor3"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(435, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(125, 16)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Split across machines"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_PeriodicRunQty
        '
        Appearance14.FontData.SizeInPoints = 8.5!
        Me.txt_PeriodicRunQty.Appearance = Appearance14
        Me.txt_PeriodicRunQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PeriodicRunQty.Location = New System.Drawing.Point(332, 39)
        Me.txt_PeriodicRunQty.Name = "txt_PeriodicRunQty"
        Me.txt_PeriodicRunQty.Size = New System.Drawing.Size(72, 22)
        Me.txt_PeriodicRunQty.TabIndex = 11
        Me.txt_PeriodicRunQty.Text = "UltraTextEditor4"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Periodic Run Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(196, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Periodic Run Time"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_PeriodicRunTime
        '
        Appearance15.FontData.SizeInPoints = 8.5!
        Me.txt_PeriodicRunTime.Appearance = Appearance15
        Me.txt_PeriodicRunTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PeriodicRunTime.Location = New System.Drawing.Point(332, 14)
        Me.txt_PeriodicRunTime.Name = "txt_PeriodicRunTime"
        Me.txt_PeriodicRunTime.Size = New System.Drawing.Size(72, 22)
        Me.txt_PeriodicRunTime.TabIndex = 4
        Me.txt_PeriodicRunTime.Text = "UltraTextEditor3"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(404, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 16)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "hr"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_VarRunQty
        '
        Appearance22.FontData.SizeInPoints = 8.5!
        Me.txt_VarRunQty.Appearance = Appearance22
        Me.txt_VarRunQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_VarRunQty.Location = New System.Drawing.Point(103, 39)
        Me.txt_VarRunQty.Name = "txt_VarRunQty"
        Me.txt_VarRunQty.Size = New System.Drawing.Size(72, 22)
        Me.txt_VarRunQty.TabIndex = 9
        Me.txt_VarRunQty.Text = "UltraTextEditor4"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Var Run Qty"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Var Run Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_VarRunTime
        '
        Appearance21.FontData.SizeInPoints = 8.5!
        Me.txt_VarRunTime.Appearance = Appearance21
        Me.txt_VarRunTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_VarRunTime.Location = New System.Drawing.Point(103, 14)
        Me.txt_VarRunTime.Name = "txt_VarRunTime"
        Me.txt_VarRunTime.Size = New System.Drawing.Size(72, 22)
        Me.txt_VarRunTime.TabIndex = 1
        Me.txt_VarRunTime.Text = "UltraTextEditor3"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(175, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "hr"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraPanel3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(725, 401)
        '
        'UltraPanel3
        '
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Label34)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.txt_TearDownTime)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Label35)
        Me.UltraPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel3.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(725, 61)
        Me.UltraPanel3.TabIndex = 0
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(175, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 16)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "hr"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_TearDownTime
        '
        Appearance1.FontData.SizeInPoints = 8.5!
        Me.txt_TearDownTime.Appearance = Appearance1
        Me.txt_TearDownTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TearDownTime.Location = New System.Drawing.Point(103, 15)
        Me.txt_TearDownTime.Name = "txt_TearDownTime"
        Me.txt_TearDownTime.Size = New System.Drawing.Size(72, 22)
        Me.txt_TearDownTime.TabIndex = 1
        Me.txt_TearDownTime.Text = "UltraTextEditor1"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(-1, 15)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 16)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Tear down Time"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridBatching)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(725, 401)
        '
        'UltraGridBatching
        '
        Me.UltraGridBatching.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBatching.Location = New System.Drawing.Point(295, 0)
        Me.UltraGridBatching.Name = "UltraGridBatching"
        Me.UltraGridBatching.Size = New System.Drawing.Size(430, 359)
        Me.UltraGridBatching.TabIndex = 1
        Me.UltraGridBatching.Text = "Batching"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelBatch)
        Me.Panel7.Controls.Add(Me.btnAddBatch)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(295, 359)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(430, 42)
        Me.Panel7.TabIndex = 2
        '
        'btnDelBatch
        '
        Me.btnDelBatch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelBatch.Location = New System.Drawing.Point(281, 0)
        Me.btnDelBatch.Name = "btnDelBatch"
        Me.btnDelBatch.Size = New System.Drawing.Size(73, 42)
        Me.btnDelBatch.TabIndex = 0
        Me.btnDelBatch.Text = "Delete"
        '
        'btnAddBatch
        '
        Me.btnAddBatch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddBatch.Location = New System.Drawing.Point(354, 0)
        Me.btnAddBatch.Name = "btnAddBatch"
        Me.btnAddBatch.Size = New System.Drawing.Size(76, 42)
        Me.btnAddBatch.TabIndex = 1
        Me.btnAddBatch.Text = "Add New"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGroupBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 401)
        Me.Panel2.TabIndex = 0
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.Label36)
        Me.UltraGroupBox5.Controls.Add(Me.txt_DelayAfter)
        Me.UltraGroupBox5.Controls.Add(Me.Label32)
        Me.UltraGroupBox5.Controls.Add(Me.txt_DelayBefore)
        Me.UltraGroupBox5.Controls.Add(Me.Label33)
        Me.UltraGroupBox5.Controls.Add(Me.Label44)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(6, 18)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(266, 91)
        Me.UltraGroupBox5.TabIndex = 0
        Me.UltraGroupBox5.Text = "Delays"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(227, 26)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 16)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "hr"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_DelayAfter
        '
        Appearance26.FontData.SizeInPoints = 8.5!
        Me.txt_DelayAfter.Appearance = Appearance26
        Me.txt_DelayAfter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DelayAfter.Location = New System.Drawing.Point(151, 51)
        Me.txt_DelayAfter.Name = "txt_DelayAfter"
        Me.txt_DelayAfter.Size = New System.Drawing.Size(72, 22)
        Me.txt_DelayAfter.TabIndex = 4
        Me.txt_DelayAfter.Text = "UltraTextEditor3"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(77, 54)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 16)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Delay After"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_DelayBefore
        '
        Appearance27.FontData.SizeInPoints = 8.5!
        Me.txt_DelayBefore.Appearance = Appearance27
        Me.txt_DelayBefore.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DelayBefore.Location = New System.Drawing.Point(151, 23)
        Me.txt_DelayBefore.Name = "txt_DelayBefore"
        Me.txt_DelayBefore.Size = New System.Drawing.Size(72, 22)
        Me.txt_DelayBefore.TabIndex = 1
        Me.txt_DelayBefore.Text = "UltraTextEditor3"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(63, 26)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 16)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Delay Before"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(225, 54)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(16, 16)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "hr"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(725, 401)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 472)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(729, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance6
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(465, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance7
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(553, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance8
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(641, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_SortIndex)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txt_OpName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 45)
        Me.Panel1.TabIndex = 0
        '
        'txt_SortIndex
        '
        Appearance13.FontData.SizeInPoints = 8.5!
        Me.txt_SortIndex.Appearance = Appearance13
        Me.txt_SortIndex.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SortIndex.Location = New System.Drawing.Point(584, 8)
        Me.txt_SortIndex.Name = "txt_SortIndex"
        Me.txt_SortIndex.Size = New System.Drawing.Size(72, 22)
        Me.txt_SortIndex.TabIndex = 3
        Me.txt_SortIndex.Text = "UltraTextEditor4"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(504, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Sort Index"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_OpName
        '
        Appearance19.FontData.SizeInPoints = 8.5!
        Me.txt_OpName.Appearance = Appearance19
        Me.txt_OpName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OpName.Location = New System.Drawing.Point(104, 8)
        Me.txt_OpName.Name = "txt_OpName"
        Me.txt_OpName.Size = New System.Drawing.Size(248, 22)
        Me.txt_OpName.TabIndex = 1
        Me.txt_OpName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Operation Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 45)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(729, 427)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.Key = "req1"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Setup"
        UltraTab3.Key = "req2"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Run"
        UltraTab4.Key = "req3"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Teardown"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Other"
        UltraTab7.Key = "params"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Parametric"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab7})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(725, 401)
        '
        'frmOp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Routing Operation"
        Me.ClientSize = New System.Drawing.Size(729, 514)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOp"
        Me.Text = "Routing Operation"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.chk_lockedseq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_MovetoStdAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_opdispoption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_DoNotOutputRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_DoNotOutputMac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.txt_MaxWaitTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MinWaitTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OverlapPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Overlapcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cmb_PrevOpID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevOpID4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevOPID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevOpID3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevOpID5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevOpID6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cmb_AltOpID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_AltOpID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_AltOpID3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.txt_SetupTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.PerformLayout()
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.txt_FixedRunTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StepFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MinSplitQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SplitMacNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PeriodicRunQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PeriodicRunTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VarRunQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VarRunTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.txt_TearDownTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridBatching, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.txt_DelayAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DelayBefore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_SortIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_TearDownTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_PeriodicRunQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_PeriodicRunTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_MinSplitQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_SplitMacNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_StepFactor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_FixedRunTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_OverlapPer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Overlapcount As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmb_opdispoption As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents chk_DoNotOutputRes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_DoNotOutputMac As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_MovetoStdAlt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_lockedseq As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_MaxWaitTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_MinWaitTime As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_DelayAfter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_DelayBefore As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label

#End Region
End Class


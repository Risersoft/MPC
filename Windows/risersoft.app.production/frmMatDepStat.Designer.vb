Imports uwg = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMatDepStat
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_depcode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dttodaydate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDelVac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddVac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelComm As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddComm As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnUrgent As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNotUrgent As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid7 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelMac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddMac As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddFut As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelFut As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnDelNCFIR As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnADDNCFIR As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridTac As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridMO As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddVac = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelVac = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelComm = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddComm = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnNotUrgent = New Infragistics.Win.Misc.UltraButton()
        Me.btnUrgent = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnAddMac = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelMac = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridTac = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridMO = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnADDNCFIR = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelNCFIR = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddFut = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelFut = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dttodaydate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_depcode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_depname = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridTac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGridMO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dttodaydate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_depcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_depname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Location = New System.Drawing.Point(328, 224)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(540, 161)
        Me.UltraGrid4.TabIndex = 3
        Me.UltraGrid4.Text = "Type Tests"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAddVac)
        Me.Panel5.Controls.Add(Me.btnDelVac)
        Me.Panel5.Controls.Add(Me.btnDelComm)
        Me.Panel5.Controls.Add(Me.btnAddComm)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(328, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(540, 48)
        Me.Panel5.TabIndex = 2
        '
        'btnAddVac
        '
        Appearance4.FontData.BoldAsString = "False"
        Me.btnAddVac.Appearance = Appearance4
        Me.btnAddVac.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddVac.Location = New System.Drawing.Point(252, 0)
        Me.btnAddVac.Name = "btnAddVac"
        Me.btnAddVac.Size = New System.Drawing.Size(72, 48)
        Me.btnAddVac.TabIndex = 0
        Me.btnAddVac.Text = "Add Vacancy"
        '
        'btnDelVac
        '
        Appearance3.FontData.BoldAsString = "False"
        Me.btnDelVac.Appearance = Appearance3
        Me.btnDelVac.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelVac.Location = New System.Drawing.Point(324, 0)
        Me.btnDelVac.Name = "btnDelVac"
        Me.btnDelVac.Size = New System.Drawing.Size(72, 48)
        Me.btnDelVac.TabIndex = 1
        Me.btnDelVac.Text = "Delete Vacancy"
        '
        'btnDelComm
        '
        Appearance1.FontData.BoldAsString = "False"
        Me.btnDelComm.Appearance = Appearance1
        Me.btnDelComm.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelComm.Location = New System.Drawing.Point(396, 0)
        Me.btnDelComm.Name = "btnDelComm"
        Me.btnDelComm.Size = New System.Drawing.Size(72, 48)
        Me.btnDelComm.TabIndex = 2
        Me.btnDelComm.Text = "Delete Comment"
        '
        'btnAddComm
        '
        Appearance2.FontData.BoldAsString = "False"
        Me.btnAddComm.Appearance = Appearance2
        Me.btnAddComm.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddComm.Location = New System.Drawing.Point(468, 0)
        Me.btnAddComm.Name = "btnAddComm"
        Me.btnAddComm.Size = New System.Drawing.Size(72, 48)
        Me.btnAddComm.TabIndex = 3
        Me.btnAddComm.Text = "Add Comment"
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGrid3.Location = New System.Drawing.Point(328, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(540, 176)
        Me.UltraGrid3.TabIndex = 1
        Me.UltraGrid3.Text = "Type Tests"
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(328, 385)
        Me.UltraGrid2.TabIndex = 0
        Me.UltraGrid2.Text = "Type Tests"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid5.TabIndex = 0
        Me.UltraGrid5.Text = "Type Tests"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnNotUrgent)
        Me.Panel6.Controls.Add(Me.btnUrgent)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 337)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(868, 48)
        Me.Panel6.TabIndex = 1
        '
        'btnNotUrgent
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.btnNotUrgent.Appearance = Appearance6
        Me.btnNotUrgent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNotUrgent.Location = New System.Drawing.Point(724, 0)
        Me.btnNotUrgent.Name = "btnNotUrgent"
        Me.btnNotUrgent.Size = New System.Drawing.Size(72, 48)
        Me.btnNotUrgent.TabIndex = 0
        Me.btnNotUrgent.Text = "Mark as not urgent"
        '
        'btnUrgent
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.btnUrgent.Appearance = Appearance5
        Me.btnUrgent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUrgent.Location = New System.Drawing.Point(796, 0)
        Me.btnUrgent.Name = "btnUrgent"
        Me.btnUrgent.Size = New System.Drawing.Size(72, 48)
        Me.btnUrgent.TabIndex = 1
        Me.btnUrgent.Text = "Mark as Urgent"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid7)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid7
        '
        Me.UltraGrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid7.Name = "UltraGrid7"
        Me.UltraGrid7.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid7.TabIndex = 0
        Me.UltraGrid7.Text = "Type Tests"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnAddMac)
        Me.Panel7.Controls.Add(Me.btnDelMac)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 337)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(868, 48)
        Me.Panel7.TabIndex = 1
        '
        'btnAddMac
        '
        Appearance8.FontData.BoldAsString = "False"
        Me.btnAddMac.Appearance = Appearance8
        Me.btnAddMac.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddMac.Location = New System.Drawing.Point(724, 0)
        Me.btnAddMac.Name = "btnAddMac"
        Me.btnAddMac.Size = New System.Drawing.Size(72, 48)
        Me.btnAddMac.TabIndex = 0
        Me.btnAddMac.Text = "Add New"
        '
        'btnDelMac
        '
        Appearance7.FontData.BoldAsString = "False"
        Me.btnDelMac.Appearance = Appearance7
        Me.btnDelMac.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelMac.Location = New System.Drawing.Point(796, 0)
        Me.btnDelMac.Name = "btnDelMac"
        Me.btnDelMac.Size = New System.Drawing.Size(72, 48)
        Me.btnDelMac.TabIndex = 1
        Me.btnDelMac.Text = "Delete"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridTac)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGridTac
        '
        Me.UltraGridTac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTac.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTac.Name = "UltraGridTac"
        Me.UltraGridTac.Size = New System.Drawing.Size(868, 385)
        Me.UltraGridTac.TabIndex = 0
        Me.UltraGridTac.Text = "Type Tests"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGridMO)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGridMO
        '
        Me.UltraGridMO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridMO.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridMO.Name = "UltraGridMO"
        Me.UltraGridMO.Size = New System.Drawing.Size(868, 385)
        Me.UltraGridMO.TabIndex = 0
        Me.UltraGridMO.Text = "Type Tests"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid6)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid6
        '
        Me.UltraGrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid6.Name = "UltraGrid6"
        Me.UltraGrid6.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid6.TabIndex = 0
        Me.UltraGrid6.Text = "Type Tests"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnADDNCFIR)
        Me.Panel8.Controls.Add(Me.btnDelNCFIR)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 337)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(868, 48)
        Me.Panel8.TabIndex = 1
        '
        'btnADDNCFIR
        '
        Appearance10.FontData.BoldAsString = "False"
        Me.btnADDNCFIR.Appearance = Appearance10
        Me.btnADDNCFIR.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnADDNCFIR.Location = New System.Drawing.Point(724, 0)
        Me.btnADDNCFIR.Name = "btnADDNCFIR"
        Me.btnADDNCFIR.Size = New System.Drawing.Size(72, 48)
        Me.btnADDNCFIR.TabIndex = 0
        Me.btnADDNCFIR.Text = "Add New"
        '
        'btnDelNCFIR
        '
        Appearance9.FontData.BoldAsString = "False"
        Me.btnDelNCFIR.Appearance = Appearance9
        Me.btnDelNCFIR.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelNCFIR.Location = New System.Drawing.Point(796, 0)
        Me.btnDelNCFIR.Name = "btnDelNCFIR"
        Me.btnDelNCFIR.Size = New System.Drawing.Size(72, 48)
        Me.btnDelNCFIR.TabIndex = 1
        Me.btnDelNCFIR.Text = "Delete"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 26)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Type Tests"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnAddFut)
        Me.Panel3.Controls.Add(Me.btnDelFut)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(868, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnAddFut
        '
        Appearance12.FontData.BoldAsString = "False"
        Me.btnAddFut.Appearance = Appearance12
        Me.btnAddFut.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddFut.Location = New System.Drawing.Point(724, 0)
        Me.btnAddFut.Name = "btnAddFut"
        Me.btnAddFut.Size = New System.Drawing.Size(72, 48)
        Me.btnAddFut.TabIndex = 0
        Me.btnAddFut.Text = "Add New"
        '
        'btnDelFut
        '
        Appearance11.FontData.BoldAsString = "False"
        Me.btnDelFut.Appearance = Appearance11
        Me.btnDelFut.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelFut.Location = New System.Drawing.Point(796, 0)
        Me.btnDelFut.Name = "btnDelFut"
        Me.btnDelFut.Size = New System.Drawing.Size(72, 48)
        Me.btnDelFut.TabIndex = 1
        Me.btnDelFut.Text = "Delete"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 550)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.FontData.SizeInPoints = 11.0!
        Me.UltraTabControl1.Appearance = Appearance13
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 136)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(872, 414)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Manpower"
        UltraTab2.Key = "mat"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Material"
        UltraTab3.Key = "mac"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Machine"
        UltraTab4.Key = "tac"
        UltraTab4.TabPage = Me.UltraTabPageControl5
        UltraTab4.Text = "TACTIC Plan"
        UltraTab5.Key = "mo"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "MO Plan"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "NC FIR"
        UltraTab7.TabPage = Me.UltraTabPageControl6
        UltraTab7.Text = "Future plan"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(868, 385)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.dttodaydate)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_depcode)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txt_depname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 136)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance14
        Me.UltraLabel2.Location = New System.Drawing.Point(48, 88)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(120, 16)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Today's Date"
        '
        'dttodaydate
        '
        Me.dttodaydate.FormatString = "dddd dd MMM yyyy"
        Me.dttodaydate.Location = New System.Drawing.Point(176, 88)
        Me.dttodaydate.Name = "dttodaydate"
        Me.dttodaydate.NullText = "Not Defined"
        Me.dttodaydate.ReadOnly = True
        Me.dttodaydate.Size = New System.Drawing.Size(192, 21)
        Me.dttodaydate.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(104, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Code"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_depcode
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.SizeInPoints = 11.0!
        Me.txt_depcode.Appearance = Appearance15
        Me.txt_depcode.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_depcode.Location = New System.Drawing.Point(176, 24)
        Me.txt_depcode.Name = "txt_depcode"
        Me.txt_depcode.ReadOnly = True
        Me.txt_depcode.Size = New System.Drawing.Size(96, 22)
        Me.txt_depcode.TabIndex = 1
        Me.txt_depcode.Text = "UltraTextEditor2"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(32, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 24)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Shop Name"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_depname
        '
        Appearance16.FontData.BoldAsString = "False"
        Appearance16.FontData.SizeInPoints = 11.0!
        Me.txt_depname.Appearance = Appearance16
        Me.txt_depname.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_depname.Location = New System.Drawing.Point(176, 56)
        Me.txt_depname.Name = "txt_depname"
        Me.txt_depname.ReadOnly = True
        Me.txt_depname.Size = New System.Drawing.Size(240, 22)
        Me.txt_depname.TabIndex = 3
        Me.txt_depname.Text = "UltraTextEditor2"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 550)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(872, 40)
        Me.Panel4.TabIndex = 0
        '
        'btnSave
        '
        Appearance17.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance17
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(608, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance18.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance18
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(696, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance19.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance19
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(784, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'frmMatDepStat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Shop Status"
        Me.ClientSize = New System.Drawing.Size(872, 590)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMatDepStat"
        Me.Text = "Shop Status"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridTac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGridMO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dttodaydate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_depcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_depname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_depname As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class


Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdLotRoute
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
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txt_ProcName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_SeqProcName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblDate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlScene = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_ManHoursAct = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_ManHoursBasic = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.dt_UpdateDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_NetPriority = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt_DoneDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_CompleteProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ProdUnitName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_TotalProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SeqProcName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txt_ProcName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControlScene, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlScene.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txt_ManHoursAct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ManHoursBasic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dt_UpdateDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NetPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DoneDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CompleteProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProcName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(128, 1)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(579, 276)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(579, 300)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(579, 300)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControlScene)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(710, 280)
        '
        'UltraTabControlScene
        '
        Me.UltraTabControlScene.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControlScene.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControlScene.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControlScene.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControlScene.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControlScene.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlScene.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlScene.Name = "UltraTabControlScene"
        Appearance6.BorderColor = System.Drawing.Color.Transparent
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.SizeInPoints = 12.0!
        Me.UltraTabControlScene.SelectedTabAppearance = Appearance6
        Me.UltraTabControlScene.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControlScene.Size = New System.Drawing.Size(710, 280)
        Me.UltraTabControlScene.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageSelected
        Me.UltraTabControlScene.TabIndex = 2
        Me.UltraTabControlScene.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "Scene 0"
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Scene 1"
        UltraTab3.TabPage = Me.UltraTabPageControl7
        UltraTab3.Text = "Scene 2"
        Me.UltraTabControlScene.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1, UltraTab3})
        Me.UltraTabControlScene.TabSize = New System.Drawing.Size(0, 125)
        Me.UltraTabControlScene.TabsPerRow = 1
        Me.UltraTabControlScene.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(579, 276)
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl8.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(710, 280)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 54)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(710, 226)
        Me.UltraGrid1.TabIndex = 10
        Me.UltraGrid1.Text = "TF Serials"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txt_ManHoursAct)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.txt_ManHoursBasic)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(710, 54)
        Me.Panel5.TabIndex = 3
        '
        'txt_ManHoursAct
        '
        Appearance5.FontData.SizeInPoints = 8.5!
        Me.txt_ManHoursAct.Appearance = Appearance5
        Me.txt_ManHoursAct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ManHoursAct.Location = New System.Drawing.Point(304, 18)
        Me.txt_ManHoursAct.Name = "txt_ManHoursAct"
        Me.txt_ManHoursAct.ReadOnly = True
        Me.txt_ManHoursAct.Size = New System.Drawing.Size(96, 22)
        Me.txt_ManHoursAct.TabIndex = 139
        Me.txt_ManHoursAct.Text = "UltraTextEditor4"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(255, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 16)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "Actual"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_ManHoursBasic
        '
        Appearance7.FontData.SizeInPoints = 8.5!
        Me.txt_ManHoursBasic.Appearance = Appearance7
        Me.txt_ManHoursBasic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ManHoursBasic.Location = New System.Drawing.Point(147, 18)
        Me.txt_ManHoursBasic.Name = "txt_ManHoursBasic"
        Me.txt_ManHoursBasic.ReadOnly = True
        Me.txt_ManHoursBasic.Size = New System.Drawing.Size(88, 22)
        Me.txt_ManHoursBasic.TabIndex = 137
        Me.txt_ManHoursBasic.Text = "UltraTextEditor4"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 16)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "Man Hours Basic"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dt_UpdateDate)
        Me.UltraTabPageControl3.Controls.Add(Me.Label9)
        Me.UltraTabPageControl3.Controls.Add(Me.Label6)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_NetPriority)
        Me.UltraTabPageControl3.Controls.Add(Me.Label8)
        Me.UltraTabPageControl3.Controls.Add(Me.dt_DoneDate)
        Me.UltraTabPageControl3.Controls.Add(Me.Label11)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_CompleteProd)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(710, 280)
        '
        'dt_UpdateDate
        '
        Me.dt_UpdateDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_UpdateDate.Location = New System.Drawing.Point(154, 60)
        Me.dt_UpdateDate.Name = "dt_UpdateDate"
        Me.dt_UpdateDate.NullText = "Not Defined"
        Me.dt_UpdateDate.ReadOnly = True
        Me.dt_UpdateDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_UpdateDate.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(22, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "UpdateDate"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(61, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Net Priority"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NetPriority
        '
        Me.txt_NetPriority.Location = New System.Drawing.Point(154, 163)
        Me.txt_NetPriority.Name = "txt_NetPriority"
        Me.txt_NetPriority.ReadOnly = True
        Me.txt_NetPriority.Size = New System.Drawing.Size(88, 21)
        Me.txt_NetPriority.TabIndex = 86
        Me.txt_NetPriority.Text = "UltraTextEditor1"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(17, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 17)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Complete Production"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_DoneDate
        '
        Me.dt_DoneDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_DoneDate.Location = New System.Drawing.Point(154, 136)
        Me.dt_DoneDate.Name = "dt_DoneDate"
        Me.dt_DoneDate.NullText = "Not Defined"
        Me.dt_DoneDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_DoneDate.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(74, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 24)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Done Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CompleteProd
        '
        Me.txt_CompleteProd.Location = New System.Drawing.Point(154, 33)
        Me.txt_CompleteProd.Name = "txt_CompleteProd"
        Me.txt_CompleteProd.ReadOnly = True
        Me.txt_CompleteProd.Size = New System.Drawing.Size(88, 21)
        Me.txt_CompleteProd.TabIndex = 84
        Me.txt_CompleteProd.Text = "UltraTextEditor1"
        '
        'txt_ProdUnitName
        '
        Appearance8.FontData.SizeInPoints = 8.5!
        Me.txt_ProdUnitName.Appearance = Appearance8
        Me.txt_ProdUnitName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProdUnitName.Location = New System.Drawing.Point(305, 66)
        Me.txt_ProdUnitName.Name = "txt_ProdUnitName"
        Me.txt_ProdUnitName.ReadOnly = True
        Me.txt_ProdUnitName.Size = New System.Drawing.Size(96, 22)
        Me.txt_ProdUnitName.TabIndex = 133
        Me.txt_ProdUnitName.Text = "UltraTextEditor4"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(253, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Unit"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(52, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Total Prod"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_TotalProd
        '
        Appearance12.FontData.SizeInPoints = 8.5!
        Me.txt_TotalProd.Appearance = Appearance12
        Me.txt_TotalProd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalProd.Location = New System.Drawing.Point(148, 66)
        Me.txt_TotalProd.Name = "txt_TotalProd"
        Me.txt_TotalProd.ReadOnly = True
        Me.txt_TotalProd.Size = New System.Drawing.Size(88, 22)
        Me.txt_TotalProd.TabIndex = 135
        Me.txt_TotalProd.Text = "UltraTextEditor4"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(714, 411)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraTabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(714, 306)
        Me.Panel3.TabIndex = 9
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(714, 306)
        Me.UltraTabControl1.TabIndex = 9
        UltraTab14.TabPage = Me.UltraTabPageControl2
        UltraTab14.Text = "Schedule"
        UltraTab5.TabPage = Me.UltraTabPageControl8
        UltraTab5.Text = "Incentive"
        UltraTab12.TabPage = Me.UltraTabPageControl3
        UltraTab12.Text = "Status"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab14, UltraTab5, UltraTab12})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(710, 280)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_Qty)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_SeqProcName)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.txt_ProdUnitName)
        Me.Panel1.Controls.Add(Me.txt_ProcName)
        Me.Panel1.Controls.Add(Me.txt_TotalProd)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 105)
        Me.Panel1.TabIndex = 0
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(493, 13)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.ReadOnly = True
        Me.txt_Qty.Size = New System.Drawing.Size(88, 21)
        Me.txt_Qty.TabIndex = 33
        Me.txt_Qty.Text = "UltraTextEditor1"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(429, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 16)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "Qty"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Sequence Process Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SeqProcName
        '
        Me.txt_SeqProcName.Location = New System.Drawing.Point(148, 12)
        Me.txt_SeqProcName.Name = "txt_SeqProcName"
        Me.txt_SeqProcName.ReadOnly = True
        Me.txt_SeqProcName.Size = New System.Drawing.Size(253, 21)
        Me.txt_SeqProcName.TabIndex = 30
        Me.txt_SeqProcName.Text = "UltraTextEditor1"
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(52, 42)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(88, 16)
        Me.lblNum.TabIndex = 21
        Me.lblNum.Text = "Process Name"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProcName
        '
        Me.txt_ProcName.Location = New System.Drawing.Point(148, 39)
        Me.txt_ProcName.Name = "txt_ProcName"
        Me.txt_ProcName.ReadOnly = True
        Me.txt_ProcName.Size = New System.Drawing.Size(253, 21)
        Me.txt_ProcName.TabIndex = 20
        Me.txt_ProcName.Text = "UltraTextEditor1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 411)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(714, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(450, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(538, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(626, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'frmProdLotRoute
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Lot Process"
        Me.ClientSize = New System.Drawing.Size(714, 453)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmProdLotRoute"
        Me.Text = "Lot Process"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControlScene, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlScene.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txt_ManHoursAct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ManHoursBasic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.dt_UpdateDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NetPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DoneDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CompleteProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProcName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControlScene As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dt_UpdateDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_NetPriority As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dt_DoneDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_CompleteProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ManHoursAct As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_ManHoursBasic As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_ProdUnitName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel

#End Region
End Class


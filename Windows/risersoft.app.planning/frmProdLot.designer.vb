Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmProdLot
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
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_EDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_SDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_QtyReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_DateReq As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_LotNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_SeqNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_ReadyDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditRouting = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.dt_CycleFinishDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_CycleStartDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_APSPriority = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_SeqNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGanttView1 = New Infragistics.Win.UltraWinGanttView.UltraGanttView()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelTF = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTF = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlRouting = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.dt_DateReq = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_ReadyDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_EDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_SDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_QtyReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txt_LotNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.UltraTabPageControl19.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.dt_CycleFinishDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CycleStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_APSPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SeqNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraTabControlRouting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlRouting.SuspendLayout()
        Me.UltraTabSharedControlsPage5.SuspendLayout()
        CType(Me.dt_DateReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_ReadyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_EDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_SDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LotNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl9.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(128, 1)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(609, 400)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(609, 360)
        Me.UltraGrid1.TabIndex = 9
        Me.UltraGrid1.Text = "TF Serials"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.UltraButton1)
        Me.Panel9.Controls.Add(Me.btnEditRouting)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 360)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(609, 40)
        Me.Panel9.TabIndex = 10
        '
        'UltraButton1
        '
        Me.UltraButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraButton1.Location = New System.Drawing.Point(412, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(122, 40)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Make Release Date same as Start Date"
        '
        'btnEditRouting
        '
        Me.btnEditRouting.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditRouting.Location = New System.Drawing.Point(534, 0)
        Me.btnEditRouting.Name = "btnEditRouting"
        Me.btnEditRouting.Size = New System.Drawing.Size(75, 40)
        Me.btnEditRouting.TabIndex = 2
        Me.btnEditRouting.Text = "Edit"
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(609, 400)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(609, 400)
        Me.UltraGrid3.TabIndex = 7
        Me.UltraGrid3.Text = "Lots"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.dt_CycleFinishDate)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_CycleStartDate)
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_APSPriority)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Remarks)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_SeqNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(609, 400)
        '
        'dt_CycleFinishDate
        '
        Me.dt_CycleFinishDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CycleFinishDate.Location = New System.Drawing.Point(135, 167)
        Me.dt_CycleFinishDate.Name = "dt_CycleFinishDate"
        Me.dt_CycleFinishDate.NullText = "Not Defined"
        Me.dt_CycleFinishDate.ReadOnly = True
        Me.dt_CycleFinishDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_CycleFinishDate.TabIndex = 80
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(3, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Cycle Finish Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CycleStartDate
        '
        Me.dt_CycleStartDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CycleStartDate.Location = New System.Drawing.Point(135, 140)
        Me.dt_CycleStartDate.Name = "dt_CycleStartDate"
        Me.dt_CycleStartDate.NullText = "Not Defined"
        Me.dt_CycleStartDate.ReadOnly = True
        Me.dt_CycleStartDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_CycleStartDate.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(3, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 20)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Cycle Start Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(42, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Priority"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_APSPriority
        '
        Me.txt_APSPriority.Location = New System.Drawing.Point(135, 85)
        Me.txt_APSPriority.Name = "txt_APSPriority"
        Me.txt_APSPriority.ReadOnly = True
        Me.txt_APSPriority.Size = New System.Drawing.Size(88, 21)
        Me.txt_APSPriority.TabIndex = 75
        Me.txt_APSPriority.Text = "UltraTextEditor1"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(42, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Sequence No."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(135, 237)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(456, 32)
        Me.txt_Remarks.TabIndex = 74
        Me.txt_Remarks.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(71, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SeqNum
        '
        Me.txt_SeqNum.Location = New System.Drawing.Point(135, 58)
        Me.txt_SeqNum.Name = "txt_SeqNum"
        Me.txt_SeqNum.Size = New System.Drawing.Size(88, 21)
        Me.txt_SeqNum.TabIndex = 30
        Me.txt_SeqNum.Text = "UltraTextEditor1"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(231, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "(will be taken as 5 if left blank)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGanttView1)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(609, 400)
        '
        'UltraGanttView1
        '
        Me.UltraGanttView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGanttView1.GridAreaWidth = 197
        Me.UltraGanttView1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGanttView1.Name = "UltraGanttView1"
        Me.UltraGanttView1.Size = New System.Drawing.Size(609, 400)
        Me.UltraGanttView1.TabIndex = 11
        Me.UltraGanttView1.Text = "UltraGanttView1"
        Me.UltraGanttView1.VerticalSplitterMinimumResizeWidth = 10
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl10.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(740, 404)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(740, 367)
        Me.UltraGrid2.TabIndex = 9
        Me.UltraGrid2.Text = "TF Serials"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelTF)
        Me.Panel5.Controls.Add(Me.btnAddTF)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 367)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(740, 37)
        Me.Panel5.TabIndex = 11
        '
        'btnDelTF
        '
        Me.btnDelTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelTF.Location = New System.Drawing.Point(592, 0)
        Me.btnDelTF.Name = "btnDelTF"
        Me.btnDelTF.Size = New System.Drawing.Size(73, 37)
        Me.btnDelTF.TabIndex = 3
        Me.btnDelTF.Text = "Delete"
        '
        'btnAddTF
        '
        Me.btnAddTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddTF.Location = New System.Drawing.Point(665, 0)
        Me.btnAddTF.Name = "btnAddTF"
        Me.btnAddTF.Size = New System.Drawing.Size(75, 37)
        Me.btnAddTF.TabIndex = 2
        Me.btnAddTF.Text = "Add New"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraTabControlRouting)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(740, 404)
        '
        'UltraTabControlRouting
        '
        Me.UltraTabControlRouting.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControlRouting.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.UltraTabControlRouting.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControlRouting.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControlRouting.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControlRouting.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControlRouting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlRouting.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlRouting.Name = "UltraTabControlRouting"
        Appearance5.BorderColor = System.Drawing.Color.Transparent
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.SizeInPoints = 12.0!
        Me.UltraTabControlRouting.SelectedTabAppearance = Appearance5
        Me.UltraTabControlRouting.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panel9})
        Me.UltraTabControlRouting.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.UltraTabControlRouting.Size = New System.Drawing.Size(740, 404)
        Me.UltraTabControlRouting.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageSelected
        Me.UltraTabControlRouting.TabIndex = 2
        Me.UltraTabControlRouting.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab19.Key = "proc"
        UltraTab19.TabPage = Me.UltraTabPageControl9
        UltraTab19.Text = "Processes"
        UltraTab20.Key = "op"
        UltraTab20.TabPage = Me.UltraTabPageControl19
        UltraTab20.Text = "Operations"
        UltraTab18.ExcludedSharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panel9})
        UltraTab18.TabPage = Me.UltraTabPageControl1
        UltraTab18.Text = "Stats"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Schedule"
        Me.UltraTabControlRouting.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab19, UltraTab20, UltraTab18, UltraTab1})
        Me.UltraTabControlRouting.TabSize = New System.Drawing.Size(0, 125)
        Me.UltraTabControlRouting.TabsPerRow = 1
        Me.UltraTabControlRouting.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Controls.Add(Me.Panel9)
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(609, 400)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(740, 404)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(128, 1)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(609, 336)
        '
        'dt_DateReq
        '
        Me.dt_DateReq.FormatString = "dddd dd MMM yyyy"
        Me.dt_DateReq.Location = New System.Drawing.Point(80, 56)
        Me.dt_DateReq.Name = "dt_DateReq"
        Me.dt_DateReq.NullText = "Not Defined"
        Me.dt_DateReq.Size = New System.Drawing.Size(192, 21)
        Me.dt_DateReq.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Required By"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 516)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraTabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 430)
        Me.Panel3.TabIndex = 9
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(744, 430)
        Me.UltraTabControl1.TabIndex = 8
        UltraTab10.Key = "ser"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Serial Nos"
        UltraTab5.TabPage = Me.UltraTabPageControl8
        UltraTab5.Text = "Routing"
        UltraTab14.Key = "mat"
        UltraTab14.TabPage = Me.UltraTabPageControl2
        UltraTab14.Text = "Material"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab5, UltraTab14})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(740, 404)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dt_ReadyDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dt_EDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dt_SDate)
        Me.Panel1.Controls.Add(Me.txt_QtyReq)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.dt_DateReq)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_LotNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 86)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(288, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Ready Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ReadyDate
        '
        Me.dt_ReadyDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ReadyDate.Location = New System.Drawing.Point(368, 32)
        Me.dt_ReadyDate.Name = "dt_ReadyDate"
        Me.dt_ReadyDate.NullText = "Not Defined"
        Me.dt_ReadyDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_ReadyDate.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(288, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "End Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_EDate
        '
        Me.dt_EDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_EDate.Location = New System.Drawing.Point(368, 56)
        Me.dt_EDate.Name = "dt_EDate"
        Me.dt_EDate.NullText = "Not Defined"
        Me.dt_EDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_EDate.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(288, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_SDate
        '
        Me.dt_SDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_SDate.Location = New System.Drawing.Point(368, 8)
        Me.dt_SDate.Name = "dt_SDate"
        Me.dt_SDate.NullText = "Not Defined"
        Me.dt_SDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_SDate.TabIndex = 26
        '
        'txt_QtyReq
        '
        Me.txt_QtyReq.Location = New System.Drawing.Point(80, 32)
        Me.txt_QtyReq.Name = "txt_QtyReq"
        Me.txt_QtyReq.Size = New System.Drawing.Size(88, 21)
        Me.txt_QtyReq.TabIndex = 25
        Me.txt_QtyReq.Text = "UltraTextEditor1"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(16, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 24)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Qty Required"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(16, 8)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(56, 16)
        Me.lblNum.TabIndex = 21
        Me.lblNum.Text = "Lot No."
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_LotNum
        '
        Me.txt_LotNum.Location = New System.Drawing.Point(80, 8)
        Me.txt_LotNum.Name = "txt_LotNum"
        Me.txt_LotNum.Size = New System.Drawing.Size(88, 21)
        Me.txt_LotNum.TabIndex = 20
        Me.txt_LotNum.Text = "UltraTextEditor1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 516)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(744, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(480, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(568, 0)
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
        Me.btnOK.Location = New System.Drawing.Point(656, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(740, 340)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageSelected
        Me.UltraTabControl2.TabIndex = 1
        Me.UltraTabControl2.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab15.TabPage = Me.UltraTabPageControl3
        UltraTab15.Text = "Reservations"
        UltraTab16.TabPage = Me.UltraTabPageControl4
        UltraTab16.Text = "PO / LPO"
        UltraTab17.TabPage = Me.UltraTabPageControl5
        UltraTab17.Text = "JWO / MO"
        UltraTab11.TabPage = Me.UltraTabPageControl6
        UltraTab11.Text = "Requisitions"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16, UltraTab17, UltraTab11})
        Me.UltraTabControl2.TabSize = New System.Drawing.Size(0, 125)
        Me.UltraTabControl2.TabsPerRow = 1
        Me.UltraTabControl2.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(609, 336)
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(128, 1)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(609, 336)
        '
        'UltraCalendarInfo1
        '
        Me.UltraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = Me
        Me.UltraCalendarInfo1.DataBindingsForOwners.BindingContextControl = Me
        '
        'frmProdLot
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Lot"
        Me.ClientSize = New System.Drawing.Size(744, 558)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmProdLot"
        Me.Text = "Lot"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.UltraTabPageControl19.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.dt_CycleFinishDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CycleStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_APSPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SeqNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGanttView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraTabControlRouting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlRouting.ResumeLayout(False)
        Me.UltraTabSharedControlsPage5.ResumeLayout(False)
        CType(Me.dt_DateReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_ReadyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_EDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_SDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LotNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControlRouting As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditRouting As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDelTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_APSPriority As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dt_CycleFinishDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dt_CycleStartDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGanttView1 As Infragistics.Win.UltraWinGanttView.UltraGanttView
    Friend WithEvents UltraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo

#End Region
End Class


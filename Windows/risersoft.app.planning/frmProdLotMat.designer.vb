Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdLotMat
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_MRPRunDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnRunMRP = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
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
        Me.dt_DateReq = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_LotNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_MRPRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_ReadyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_EDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_SDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DateReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LotNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(656, 380)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "TF Serials"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dt_MRPRunDate)
        Me.Panel2.Controls.Add(Me.btnRunMRP)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 38)
        Me.Panel2.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Location = New System.Drawing.Point(392, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 38)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(480, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 38)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(31, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last MRP Run"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_MRPRunDate
        '
        Me.dt_MRPRunDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_MRPRunDate.Location = New System.Drawing.Point(145, 8)
        Me.dt_MRPRunDate.Name = "dt_MRPRunDate"
        Me.dt_MRPRunDate.NullText = "Not Defined"
        Me.dt_MRPRunDate.ReadOnly = True
        Me.dt_MRPRunDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_MRPRunDate.TabIndex = 1
        '
        'btnRunMRP
        '
        Me.btnRunMRP.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRunMRP.Location = New System.Drawing.Point(568, 0)
        Me.btnRunMRP.Name = "btnRunMRP"
        Me.btnRunMRP.Size = New System.Drawing.Size(88, 38)
        Me.btnRunMRP.TabIndex = 4
        Me.btnRunMRP.Text = "Run"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(123, 1)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(656, 418)
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid2.TabIndex = 0
        Me.UltraGrid2.Text = "TF Serials"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid3.TabIndex = 0
        Me.UltraGrid3.Text = "TF Serials"
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid5.TabIndex = 0
        Me.UltraGrid5.Text = "TF Serials"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid4.TabIndex = 0
        Me.UltraGrid4.Text = "TF Serials"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid7)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid7
        '
        Me.UltraGrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid7.Name = "UltraGrid7"
        Me.UltraGrid7.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid7.TabIndex = 0
        Me.UltraGrid7.Text = "TF Serials"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid6)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(656, 418)
        '
        'UltraGrid6
        '
        Me.UltraGrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid6.Name = "UltraGrid6"
        Me.UltraGrid6.Size = New System.Drawing.Size(656, 418)
        Me.UltraGrid6.TabIndex = 0
        Me.UltraGrid6.Text = "TF Serials"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 511)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(518, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance5
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(606, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance7
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(694, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
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
        Me.Panel1.Size = New System.Drawing.Size(782, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(398, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ready Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ReadyDate
        '
        Me.dt_ReadyDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ReadyDate.Location = New System.Drawing.Point(478, 37)
        Me.dt_ReadyDate.Name = "dt_ReadyDate"
        Me.dt_ReadyDate.NullText = "Not Defined"
        Me.dt_ReadyDate.ReadOnly = True
        Me.dt_ReadyDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_ReadyDate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(398, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "End Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_EDate
        '
        Me.dt_EDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_EDate.Location = New System.Drawing.Point(478, 61)
        Me.dt_EDate.Name = "dt_EDate"
        Me.dt_EDate.NullText = "Not Defined"
        Me.dt_EDate.ReadOnly = True
        Me.dt_EDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_EDate.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(398, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_SDate
        '
        Me.dt_SDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_SDate.Location = New System.Drawing.Point(478, 13)
        Me.dt_SDate.Name = "dt_SDate"
        Me.dt_SDate.NullText = "Not Defined"
        Me.dt_SDate.ReadOnly = True
        Me.dt_SDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_SDate.TabIndex = 3
        '
        'txt_QtyReq
        '
        Me.txt_QtyReq.Location = New System.Drawing.Point(190, 37)
        Me.txt_QtyReq.Name = "txt_QtyReq"
        Me.txt_QtyReq.ReadOnly = True
        Me.txt_QtyReq.Size = New System.Drawing.Size(88, 21)
        Me.txt_QtyReq.TabIndex = 5
        Me.txt_QtyReq.Text = "UltraTextEditor1"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(126, 37)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 24)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Qty Required"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(126, 13)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(56, 16)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Lot No."
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_DateReq
        '
        Me.dt_DateReq.FormatString = "dddd dd MMM yyyy"
        Me.dt_DateReq.Location = New System.Drawing.Point(190, 61)
        Me.dt_DateReq.Name = "dt_DateReq"
        Me.dt_DateReq.NullText = "Not Defined"
        Me.dt_DateReq.ReadOnly = True
        Me.dt_DateReq.Size = New System.Drawing.Size(192, 21)
        Me.dt_DateReq.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(113, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Required By"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_LotNum
        '
        Me.txt_LotNum.Location = New System.Drawing.Point(190, 13)
        Me.txt_LotNum.Name = "txt_LotNum"
        Me.txt_LotNum.ReadOnly = True
        Me.txt_LotNum.Size = New System.Drawing.Size(88, 21)
        Me.txt_LotNum.TabIndex = 1
        Me.txt_LotNum.Text = "UltraTextEditor1"
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 89)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Appearance6.BorderColor = System.Drawing.Color.Transparent
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.SizeInPoints = 12.0!
        Me.UltraTabControl3.SelectedTabAppearance = Appearance6
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(782, 422)
        Me.UltraTabControl3.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageSelected
        Me.UltraTabControl3.TabIndex = 1
        Me.UltraTabControl3.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Summary"
        UltraTab3.Key = "bom"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Requirements"
        UltraTab6.TabPage = Me.UltraTabPageControl15
        UltraTab6.Text = "Reservations"
        UltraTab7.TabPage = Me.UltraTabPageControl16
        UltraTab7.Text = "PO / LPO"
        UltraTab9.TabPage = Me.UltraTabPageControl18
        UltraTab9.Text = "Purch Req"
        UltraTab8.TabPage = Me.UltraTabPageControl17
        UltraTab8.Text = "MO / JWO"
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "JW Req"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Plan Orders"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3, UltraTab6, UltraTab7, UltraTab9, UltraTab8, UltraTab1, UltraTab4})
        Me.UltraTabControl3.TabSize = New System.Drawing.Size(0, 120)
        Me.UltraTabControl3.TabsPerRow = 1
        Me.UltraTabControl3.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(656, 418)
        '
        'frmProdLotMat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Lot Material Status"
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.UltraTabControl3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmProdLotMat"
        Me.Text = "Lot Material Status"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_MRPRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl17.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_ReadyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_EDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_SDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DateReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LotNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_ReadyDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_EDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_SDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_QtyReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents dt_DateReq As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_LotNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid7 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRunMRP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_MRPRunDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton

#End Region
End Class


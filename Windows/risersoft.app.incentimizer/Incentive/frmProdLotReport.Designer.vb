Imports uwt = Infragistics.Win.UltraWinTabControl
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdLotReport
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlIN = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlNC = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dt_dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_shiftID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_IncenProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_CumuProdOther = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ProgTotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ProgToday = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_CumuPerCent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_CumuProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_TotalProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ProdUnitName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ProdIncType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_PlnProcID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lotnum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_WOInfo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SeqProcName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTabControlIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlIN.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControlNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlNC.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_shiftID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IncenProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CumuProdOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProgTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProgToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CumuPerCent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CumuProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lotnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WOInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(405, 451)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(405, 451)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(405, 451)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(405, 451)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabControlIN)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 1)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(409, 477)
        '
        'UltraTabControlIN
        '
        Me.UltraTabControlIN.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControlIN.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControlIN.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControlIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlIN.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlIN.Name = "UltraTabControlIN"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControlIN.SelectedTabAppearance = Appearance1
        Me.UltraTabControlIN.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControlIN.Size = New System.Drawing.Size(409, 477)
        Me.UltraTabControlIN.TabIndex = 11
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Incen Basic 1"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Incen Basic 2"
        Me.UltraTabControlIN.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(405, 451)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControlNC)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(409, 477)
        '
        'UltraTabControlNC
        '
        Me.UltraTabControlNC.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControlNC.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControlNC.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControlNC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlNC.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlNC.Name = "UltraTabControlNC"
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraTabControlNC.SelectedTabAppearance = Appearance2
        Me.UltraTabControlNC.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControlNC.Size = New System.Drawing.Size(409, 477)
        Me.UltraTabControlNC.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "NC Basic 1"
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "NC Basic 2"
        Me.UltraTabControlNC.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(405, 451)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 499)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 51)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(485, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 51)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(573, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 51)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(661, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 51)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dt_dated)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.cmb_shiftID)
        Me.Panel1.Controls.Add(Me.txt_IncenProd)
        Me.Panel1.Controls.Add(Me.txt_CumuProdOther)
        Me.Panel1.Controls.Add(Me.txt_remark)
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.txt_ProgTotal)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.txt_ProgToday)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_CumuPerCent)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_CumuProd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_TotalProd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_ProdUnitName)
        Me.Panel1.Controls.Add(Me.cmb_ProdIncType)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.cmb_PlnProcID)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_lotnum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_WOInfo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_SeqProcName)
        Me.Panel1.Controls.Add(Me.cmb_matdepid)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 499)
        Me.Panel1.TabIndex = 1
        '
        'dt_dated
        '
        Me.dt_dated.DateTime = New Date(2014, 9, 19, 0, 0, 0, 0)
        Me.dt_dated.FormatString = "dddd dd MMM yyyy"
        Me.dt_dated.Location = New System.Drawing.Point(110, 11)
        Me.dt_dated.Name = "dt_dated"
        Me.dt_dated.NullText = "Not Defined"
        Me.dt_dated.ReadOnly = True
        Me.dt_dated.Size = New System.Drawing.Size(200, 21)
        Me.dt_dated.TabIndex = 5
        Me.dt_dated.Value = New Date(2014, 9, 19, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.Location = New System.Drawing.Point(62, 14)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 17)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Date"
        '
        'cmb_shiftID
        '
        Me.cmb_shiftID.Location = New System.Drawing.Point(110, 94)
        Me.cmb_shiftID.Name = "cmb_shiftID"
        Me.cmb_shiftID.ReadOnly = True
        Me.cmb_shiftID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_shiftID.TabIndex = 7
        '
        'txt_IncenProd
        '
        Me.txt_IncenProd.Location = New System.Drawing.Point(265, 287)
        Me.txt_IncenProd.Name = "txt_IncenProd"
        Me.txt_IncenProd.ReadOnly = True
        Me.txt_IncenProd.Size = New System.Drawing.Size(36, 21)
        Me.txt_IncenProd.TabIndex = 22
        Me.txt_IncenProd.Visible = False
        '
        'txt_CumuProdOther
        '
        Me.txt_CumuProdOther.Location = New System.Drawing.Point(265, 314)
        Me.txt_CumuProdOther.Name = "txt_CumuProdOther"
        Me.txt_CumuProdOther.ReadOnly = True
        Me.txt_CumuProdOther.Size = New System.Drawing.Size(36, 21)
        Me.txt_CumuProdOther.TabIndex = 25
        Me.txt_CumuProdOther.Visible = False
        '
        'txt_remark
        '
        Me.txt_remark.AcceptsReturn = True
        Me.txt_remark.Location = New System.Drawing.Point(110, 431)
        Me.txt_remark.Multiline = True
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(200, 36)
        Me.txt_remark.TabIndex = 31
        '
        'UltraLabel7
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance7
        Me.UltraLabel7.Location = New System.Drawing.Point(54, 434)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel7.TabIndex = 30
        Me.UltraLabel7.Text = "Remark"
        '
        'txt_ProgTotal
        '
        Me.txt_ProgTotal.AcceptsReturn = True
        Me.txt_ProgTotal.Location = New System.Drawing.Point(110, 387)
        Me.txt_ProgTotal.Multiline = True
        Me.txt_ProgTotal.Name = "txt_ProgTotal"
        Me.txt_ProgTotal.Size = New System.Drawing.Size(200, 40)
        Me.txt_ProgTotal.TabIndex = 29
        '
        'UltraLabel6
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance8
        Me.UltraLabel6.Location = New System.Drawing.Point(30, 387)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(72, 40)
        Me.UltraLabel6.TabIndex = 28
        Me.UltraLabel6.Text = "Overall Progress / Whats Left:"
        '
        'txt_ProgToday
        '
        Me.txt_ProgToday.AcceptsReturn = True
        Me.txt_ProgToday.Location = New System.Drawing.Point(110, 341)
        Me.txt_ProgToday.Multiline = True
        Me.txt_ProgToday.Name = "txt_ProgToday"
        Me.txt_ProgToday.Size = New System.Drawing.Size(200, 40)
        Me.txt_ProgToday.TabIndex = 27
        '
        'UltraLabel5
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance9
        Me.UltraLabel5.Location = New System.Drawing.Point(30, 344)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(72, 32)
        Me.UltraLabel5.TabIndex = 26
        Me.UltraLabel5.Text = "Today's Progress:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(32, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total Done %"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CumuPerCent
        '
        Me.txt_CumuPerCent.Location = New System.Drawing.Point(110, 314)
        Me.txt_CumuPerCent.Name = "txt_CumuPerCent"
        Me.txt_CumuPerCent.ReadOnly = True
        Me.txt_CumuPerCent.Size = New System.Drawing.Size(149, 21)
        Me.txt_CumuPerCent.TabIndex = 24
        Me.txt_CumuPerCent.Text = "UltraTextEditor4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(45, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 14)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Total Done"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CumuProd
        '
        Me.txt_CumuProd.Location = New System.Drawing.Point(110, 287)
        Me.txt_CumuProd.Name = "txt_CumuProd"
        Me.txt_CumuProd.ReadOnly = True
        Me.txt_CumuProd.Size = New System.Drawing.Size(149, 21)
        Me.txt_CumuProd.TabIndex = 21
        Me.txt_CumuProd.Text = "UltraTextEditor3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(27, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total Required"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_TotalProd
        '
        Me.txt_TotalProd.Location = New System.Drawing.Point(110, 260)
        Me.txt_TotalProd.Name = "txt_TotalProd"
        Me.txt_TotalProd.ReadOnly = True
        Me.txt_TotalProd.Size = New System.Drawing.Size(149, 21)
        Me.txt_TotalProd.TabIndex = 19
        Me.txt_TotalProd.Text = "UltraTextEditor2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(31, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Incentive Unit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProdUnitName
        '
        Me.txt_ProdUnitName.Location = New System.Drawing.Point(110, 233)
        Me.txt_ProdUnitName.Name = "txt_ProdUnitName"
        Me.txt_ProdUnitName.ReadOnly = True
        Me.txt_ProdUnitName.Size = New System.Drawing.Size(149, 21)
        Me.txt_ProdUnitName.TabIndex = 17
        Me.txt_ProdUnitName.Text = "UltraTextEditor1"
        '
        'cmb_ProdIncType
        '
        Me.cmb_ProdIncType.Location = New System.Drawing.Point(110, 204)
        Me.cmb_ProdIncType.Name = "cmb_ProdIncType"
        Me.cmb_ProdIncType.ReadOnly = True
        Me.cmb_ProdIncType.Size = New System.Drawing.Size(200, 22)
        Me.cmb_ProdIncType.TabIndex = 15
        '
        'UltraLabel4
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance10
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 207)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel4.TabIndex = 14
        Me.UltraLabel4.Text = "Incentive Type"
        '
        'cmb_PlnProcID
        '
        Me.cmb_PlnProcID.Location = New System.Drawing.Point(110, 66)
        Me.cmb_PlnProcID.Name = "cmb_PlnProcID"
        Me.cmb_PlnProcID.ReadOnly = True
        Me.cmb_PlnProcID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_PlnProcID.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance11
        Me.UltraLabel3.Location = New System.Drawing.Point(30, 70)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Process"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(61, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lot No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_lotnum
        '
        Me.txt_lotnum.Location = New System.Drawing.Point(110, 149)
        Me.txt_lotnum.Name = "txt_lotnum"
        Me.txt_lotnum.ReadOnly = True
        Me.txt_lotnum.Size = New System.Drawing.Size(200, 21)
        Me.txt_lotnum.TabIndex = 11
        Me.txt_lotnum.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(39, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Work Order"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_WOInfo
        '
        Me.txt_WOInfo.Location = New System.Drawing.Point(110, 122)
        Me.txt_WOInfo.Name = "txt_WOInfo"
        Me.txt_WOInfo.ReadOnly = True
        Me.txt_WOInfo.Size = New System.Drawing.Size(200, 21)
        Me.txt_WOInfo.TabIndex = 9
        Me.txt_WOInfo.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sequence Process Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SeqProcName
        '
        Me.txt_SeqProcName.Location = New System.Drawing.Point(110, 176)
        Me.txt_SeqProcName.Name = "txt_SeqProcName"
        Me.txt_SeqProcName.ReadOnly = True
        Me.txt_SeqProcName.Size = New System.Drawing.Size(200, 21)
        Me.txt_SeqProcName.TabIndex = 13
        Me.txt_SeqProcName.Text = "UltraTextEditor1"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(110, 38)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.ReadOnly = True
        Me.cmb_matdepid.Size = New System.Drawing.Size(200, 22)
        Me.cmb_matdepid.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance12
        Me.UltraLabel2.Location = New System.Drawing.Point(30, 42)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Department"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(38, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shift"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabControl1
        '
        Appearance13.FontData.SizeInPoints = 10.0!
        Me.UltraTabControl1.Appearance = Appearance13
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(338, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance14.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance14
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(411, 499)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.UltraTabControl1.TabIndex = 10
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.BottomLeft
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Production"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "NC"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(409, 477)
        '
        'frmProdLotReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Lot Process Report"
        Me.ClientSize = New System.Drawing.Size(749, 550)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmProdLotReport"
        Me.Text = "Lot Process Report"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraTabControlIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlIN.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControlNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlNC.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_shiftID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IncenProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CumuProdOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProgTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProgToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CumuPerCent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CumuProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lotnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WOInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_SeqProcName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_lotnum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_WOInfo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_PlnProcID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ProdIncType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ProdUnitName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_CumuPerCent As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_CumuProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ProgToday As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ProgTotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IncenProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_CumuProdOther As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControlIN As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControlNC As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_shiftID As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class


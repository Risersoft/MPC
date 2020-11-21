<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmRouting
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_VarTimeIndex As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraGridop As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_RouteName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnDelOp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddOp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditOp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAlternate As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_IsOld As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridop = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAlternate = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditOp = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelOp = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddOp = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_IsOld = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_VarTimeIndex = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_RouteName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.chk_isDummy = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGridop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_IsOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VarTimeIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RouteName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.chk_isDummy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGridop)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(601, 244)
        '
        'UltraGridop
        '
        Me.UltraGridop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridop.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridop.Name = "UltraGridop"
        Me.UltraGridop.Size = New System.Drawing.Size(601, 196)
        Me.UltraGridop.TabIndex = 0
        Me.UltraGridop.Text = "TF Serials"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAlternate)
        Me.Panel9.Controls.Add(Me.btnEditOp)
        Me.Panel9.Controls.Add(Me.btnDelOp)
        Me.Panel9.Controls.Add(Me.btnAddOp)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 196)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(601, 48)
        Me.Panel9.TabIndex = 1
        '
        'btnAlternate
        '
        Me.btnAlternate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlternate.Enabled = False
        Me.btnAlternate.Location = New System.Drawing.Point(3, 16)
        Me.btnAlternate.Name = "btnAlternate"
        Me.btnAlternate.Size = New System.Drawing.Size(232, 24)
        Me.btnAlternate.TabIndex = 0
        Me.btnAlternate.Text = "Define Alternate operations"
        '
        'btnEditOp
        '
        Me.btnEditOp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditOp.Location = New System.Drawing.Point(421, 16)
        Me.btnEditOp.Name = "btnEditOp"
        Me.btnEditOp.Size = New System.Drawing.Size(76, 24)
        Me.btnEditOp.TabIndex = 2
        Me.btnEditOp.Text = "Edit"
        '
        'btnDelOp
        '
        Me.btnDelOp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelOp.Location = New System.Drawing.Point(341, 16)
        Me.btnDelOp.Name = "btnDelOp"
        Me.btnDelOp.Size = New System.Drawing.Size(73, 24)
        Me.btnDelOp.TabIndex = 1
        Me.btnDelOp.Text = "Delete"
        '
        'btnAddOp
        '
        Me.btnAddOp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddOp.Location = New System.Drawing.Point(509, 16)
        Me.btnAddOp.Name = "btnAddOp"
        Me.btnAddOp.Size = New System.Drawing.Size(75, 24)
        Me.btnAddOp.TabIndex = 3
        Me.btnAddOp.Text = "Add New"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(601, 244)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(601, 244)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 470)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(605, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance8
        Me.btnSave.Location = New System.Drawing.Point(317, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance9
        Me.btnCancel.Location = New System.Drawing.Point(413, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance10
        Me.btnOK.Location = New System.Drawing.Point(509, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_isDummy)
        Me.Panel1.Controls.Add(Me.chk_IsOld)
        Me.Panel1.Controls.Add(Me.cmb_matdepid)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.txt_VarTimeIndex)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_RouteName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 200)
        Me.Panel1.TabIndex = 0
        '
        'chk_IsOld
        '
        Me.chk_IsOld.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_IsOld.Location = New System.Drawing.Point(448, 56)
        Me.chk_IsOld.Name = "chk_IsOld"
        Me.chk_IsOld.Size = New System.Drawing.Size(160, 24)
        Me.chk_IsOld.TabIndex = 4
        Me.chk_IsOld.Text = "Old routing (Parameters not required to be updated)"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(112, 56)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.Size = New System.Drawing.Size(328, 22)
        Me.cmb_matdepid.TabIndex = 3
        '
        'UltraLabel4
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance11
        Me.UltraLabel4.Location = New System.Drawing.Point(32, 56)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Department"
        '
        'txt_VarTimeIndex
        '
        Appearance5.FontData.SizeInPoints = 10.0!
        Me.txt_VarTimeIndex.Appearance = Appearance5
        Me.txt_VarTimeIndex.Location = New System.Drawing.Point(112, 152)
        Me.txt_VarTimeIndex.Name = "txt_VarTimeIndex"
        Me.txt_VarTimeIndex.Size = New System.Drawing.Size(64, 24)
        Me.txt_VarTimeIndex.TabIndex = 8
        Me.txt_VarTimeIndex.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Variable Time Index"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Appearance6.FontData.SizeInPoints = 10.0!
        Me.txt_Remark.Appearance = Appearance6
        Me.txt_Remark.Location = New System.Drawing.Point(112, 88)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(488, 56)
        Me.txt_Remark.TabIndex = 6
        Me.txt_Remark.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Remark"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RouteName
        '
        Appearance7.FontData.SizeInPoints = 10.0!
        Me.txt_RouteName.Appearance = Appearance7
        Me.txt_RouteName.Location = New System.Drawing.Point(112, 24)
        Me.txt_RouteName.Name = "txt_RouteName"
        Me.txt_RouteName.Size = New System.Drawing.Size(488, 24)
        Me.txt_RouteName.TabIndex = 1
        Me.txt_RouteName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Routing Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 200)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(605, 270)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab2.Key = "serial"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Operations"
        UltraTab1.Key = "paramqual"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Qualifying Parameters"
        UltraTab3.Key = "paramfld"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Formulas"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(601, 244)
        '
        'chk_isDummy
        '
        Me.chk_isDummy.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_isDummy.Location = New System.Drawing.Point(230, 155)
        Me.chk_isDummy.Name = "chk_isDummy"
        Me.chk_isDummy.Size = New System.Drawing.Size(108, 24)
        Me.chk_isDummy.TabIndex = 9
        Me.chk_isDummy.Text = "Dummy Routing"
        '
        'frmRouting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Routing"
        Me.ClientSize = New System.Drawing.Size(605, 518)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRouting"
        Me.Text = "Routing"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGridop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chk_IsOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VarTimeIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RouteName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.chk_isDummy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_isDummy As Infragistics.Win.UltraWinEditors.UltraCheckEditor

#End Region
End Class


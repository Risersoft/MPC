Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDUnitLot
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
    Friend WithEvents txt_DescripWO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_inprod As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnAddLot As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditLot As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_IsCompleted As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dt_ProdFileDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chk_InMatPlan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnEditLot = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddLot = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_InMatPlan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.dt_ProdFileDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chk_IsCompleted = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_DescripWO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbl_inprod = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_InMatPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ProdFileDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(778, 399)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraGrid1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 399)
        Me.Panel3.TabIndex = 8
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(778, 357)
        Me.UltraGrid1.TabIndex = 6
        Me.UltraGrid1.Text = "Lots"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnEditLot)
        Me.Panel5.Controls.Add(Me.btnAddLot)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 357)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(778, 42)
        Me.Panel5.TabIndex = 7
        '
        'btnEditLot
        '
        Me.btnEditLot.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditLot.Location = New System.Drawing.Point(626, 0)
        Me.btnEditLot.Name = "btnEditLot"
        Me.btnEditLot.Size = New System.Drawing.Size(76, 42)
        Me.btnEditLot.TabIndex = 4
        Me.btnEditLot.Text = "Edit"
        '
        'btnAddLot
        '
        Me.btnAddLot.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddLot.Location = New System.Drawing.Point(702, 0)
        Me.btnAddLot.Name = "btnAddLot"
        Me.btnAddLot.Size = New System.Drawing.Size(76, 42)
        Me.btnAddLot.TabIndex = 2
        Me.btnAddLot.Text = "Add New"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 505)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 80)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(782, 425)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lots"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(778, 399)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_InMatPlan)
        Me.Panel1.Controls.Add(Me.dt_ProdFileDate)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.chk_IsCompleted)
        Me.Panel1.Controls.Add(Me.txt_DescripWO)
        Me.Panel1.Controls.Add(Me.lbl_inprod)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 80)
        Me.Panel1.TabIndex = 0
        '
        'chk_InMatPlan
        '
        Me.chk_InMatPlan.Location = New System.Drawing.Point(492, 48)
        Me.chk_InMatPlan.Name = "chk_InMatPlan"
        Me.chk_InMatPlan.Size = New System.Drawing.Size(144, 24)
        Me.chk_InMatPlan.TabIndex = 21
        Me.chk_InMatPlan.Text = "In Material Planning"
        '
        'dt_ProdFileDate
        '
        Me.dt_ProdFileDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ProdFileDate.Location = New System.Drawing.Point(128, 48)
        Me.dt_ProdFileDate.Name = "dt_ProdFileDate"
        Me.dt_ProdFileDate.NullText = "Not Defined"
        Me.dt_ProdFileDate.Size = New System.Drawing.Size(232, 21)
        Me.dt_ProdFileDate.TabIndex = 20
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(20, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 14)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Production File Date"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_IsCompleted
        '
        Me.chk_IsCompleted.Location = New System.Drawing.Point(380, 48)
        Me.chk_IsCompleted.Name = "chk_IsCompleted"
        Me.chk_IsCompleted.Size = New System.Drawing.Size(96, 24)
        Me.chk_IsCompleted.TabIndex = 11
        Me.chk_IsCompleted.Text = "Is Completed"
        '
        'txt_DescripWO
        '
        Me.txt_DescripWO.Location = New System.Drawing.Point(128, 16)
        Me.txt_DescripWO.Name = "txt_DescripWO"
        Me.txt_DescripWO.ReadOnly = True
        Me.txt_DescripWO.Size = New System.Drawing.Size(489, 21)
        Me.txt_DescripWO.TabIndex = 9
        '
        'lbl_inprod
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.lbl_inprod.Appearance = Appearance1
        Me.lbl_inprod.AutoSize = True
        Me.lbl_inprod.Location = New System.Drawing.Point(61, 19)
        Me.lbl_inprod.Name = "lbl_inprod"
        Me.lbl_inprod.Size = New System.Drawing.Size(61, 14)
        Me.lbl_inprod.TabIndex = 10
        Me.lbl_inprod.Text = "Description"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Location = New System.Drawing.Point(494, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Location = New System.Drawing.Point(590, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Location = New System.Drawing.Point(686, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'frmPIDUnitLot
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "WO/Code"
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPIDUnitLot"
        Me.Text = "WO/Code"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chk_InMatPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ProdFileDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class


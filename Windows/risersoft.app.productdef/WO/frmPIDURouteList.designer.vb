Imports risersoft.app2.shared

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPIDURouteList
    Inherits frmMax2

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_PlnStdSeqID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btn_ReGenerate = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_Edit = New Infragistics.Win.Misc.UltraButton()
        Me.btn_Delete = New Infragistics.Win.Misc.UltraButton()
        Me.btn_Add = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridRoute = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.cmb_PlnStdSeqID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGridRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnSelect)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.cmb_PlnStdSeqID)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btn_ReGenerate)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(616, 48)
        Me.UltraPanel1.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSelect.Location = New System.Drawing.Point(422, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(97, 48)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        '
        'cmb_PlnStdSeqID
        '
        Me.cmb_PlnStdSeqID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_PlnStdSeqID.DisplayLayout.Appearance = Appearance25
        Me.cmb_PlnStdSeqID.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_PlnStdSeqID.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance98.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance98.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance98.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_PlnStdSeqID.DisplayLayout.GroupByBox.Appearance = Appearance98
        Appearance99.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_PlnStdSeqID.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance99
        Me.cmb_PlnStdSeqID.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance100.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance100.BackColor2 = System.Drawing.SystemColors.Control
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_PlnStdSeqID.DisplayLayout.GroupByBox.PromptAppearance = Appearance100
        Me.cmb_PlnStdSeqID.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb_PlnStdSeqID.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.CellAppearance = Appearance32
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.RowAppearance = Appearance35
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb_PlnStdSeqID.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.cmb_PlnStdSeqID.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb_PlnStdSeqID.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb_PlnStdSeqID.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb_PlnStdSeqID.Location = New System.Drawing.Point(98, 12)
        Me.cmb_PlnStdSeqID.Name = "cmb_PlnStdSeqID"
        Me.cmb_PlnStdSeqID.ReadOnly = True
        Me.cmb_PlnStdSeqID.Size = New System.Drawing.Size(318, 22)
        Me.cmb_PlnStdSeqID.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(71, 22)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Sequence"
        '
        'btn_ReGenerate
        '
        Me.btn_ReGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_ReGenerate.Location = New System.Drawing.Point(519, 0)
        Me.btn_ReGenerate.Name = "btn_ReGenerate"
        Me.btn_ReGenerate.Size = New System.Drawing.Size(97, 48)
        Me.btn_ReGenerate.TabIndex = 3
        Me.btn_ReGenerate.Text = "Re-Generate"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_Edit)
        Me.Panel4.Controls.Add(Me.btn_Delete)
        Me.Panel4.Controls.Add(Me.btn_Add)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 309)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(616, 30)
        Me.Panel4.TabIndex = 2
        '
        'btn_Edit
        '
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Edit.Location = New System.Drawing.Point(382, 0)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(78, 30)
        Me.btn_Edit.TabIndex = 0
        Me.btn_Edit.Text = "Edit"
        '
        'btn_Delete
        '
        Me.btn_Delete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Delete.Location = New System.Drawing.Point(460, 0)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(78, 30)
        Me.btn_Delete.TabIndex = 1
        Me.btn_Delete.Text = "Delete"
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Add.Location = New System.Drawing.Point(538, 0)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(78, 30)
        Me.btn_Add.TabIndex = 2
        Me.btn_Add.Text = "Add New"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 40)
        Me.Panel1.TabIndex = 3
        '
        'btnSave
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(352, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(440, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance9
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(528, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraGridRoute
        '
        Me.UltraGridRoute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRoute.Location = New System.Drawing.Point(0, 48)
        Me.UltraGridRoute.Name = "UltraGridRoute"
        Me.UltraGridRoute.Size = New System.Drawing.Size(616, 261)
        Me.UltraGridRoute.TabIndex = 1
        Me.UltraGridRoute.Text = "UltraGrid1"
        '
        'frmPIDURouteList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Work Order Routing List"
        Me.ClientSize = New System.Drawing.Size(616, 379)
        Me.Controls.Add(Me.UltraGridRoute)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPIDURouteList"
        Me.Text = "Work Order Routing List"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.cmb_PlnStdSeqID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGridRoute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_Edit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Delete As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Add As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_ReGenerate As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_PlnStdSeqID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridRoute As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
End Class

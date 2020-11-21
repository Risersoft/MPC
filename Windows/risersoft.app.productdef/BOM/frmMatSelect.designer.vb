<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatSelect
    Inherits risersoft.shared.win.frmMax

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
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkOldSpec = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridItemVMS = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridItems = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmb_Show = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_MatHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chkOldSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridItemVMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.cmb_Show, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkOldSpec)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 40)
        Me.Panel1.TabIndex = 3
        '
        'chkOldSpec
        '
        Me.chkOldSpec.Location = New System.Drawing.Point(14, 13)
        Me.chkOldSpec.Name = "chkOldSpec"
        Me.chkOldSpec.Size = New System.Drawing.Size(336, 16)
        Me.chkOldSpec.TabIndex = 0
        Me.chkOldSpec.Text = "Do not show Old Versions"
        '
        'btnCancel
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(492, 0)
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
        Me.btnOK.Location = New System.Drawing.Point(580, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraGridItemVMS
        '
        Me.UltraGridItemVMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGridItemVMS.Location = New System.Drawing.Point(0, 246)
        Me.UltraGridItemVMS.Name = "UltraGridItemVMS"
        Me.UltraGridItemVMS.Size = New System.Drawing.Size(668, 185)
        Me.UltraGridItemVMS.TabIndex = 2
        Me.UltraGridItemVMS.Text = "Item VMS"
        '
        'UltraGridItems
        '
        Me.UltraGridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridItems.Location = New System.Drawing.Point(0, 45)
        Me.UltraGridItems.Name = "UltraGridItems"
        Me.UltraGridItems.Size = New System.Drawing.Size(668, 201)
        Me.UltraGridItems.TabIndex = 1
        Me.UltraGridItems.Text = "Items"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmb_Show)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cmb_MatHeadID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(668, 45)
        Me.Panel3.TabIndex = 0
        '
        'cmb_Show
        '
        Me.cmb_Show.Location = New System.Drawing.Point(434, 13)
        Me.cmb_Show.Name = "cmb_Show"
        Me.cmb_Show.Size = New System.Drawing.Size(222, 21)
        Me.cmb_Show.TabIndex = 3
        Me.cmb_Show.Text = "UltraComboEditor1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(393, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Show"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_MatHeadID
        '
        Me.cmb_MatHeadID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_MatHeadID.Location = New System.Drawing.Point(50, 12)
        Me.cmb_MatHeadID.Name = "cmb_MatHeadID"
        Me.cmb_MatHeadID.ReadOnly = True
        Me.cmb_MatHeadID.Size = New System.Drawing.Size(272, 23)
        Me.cmb_MatHeadID.TabIndex = 1
        Me.cmb_MatHeadID.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMatSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Mat Select"
        Me.ClientSize = New System.Drawing.Size(668, 471)
        Me.Controls.Add(Me.UltraGridItems)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UltraGridItemVMS)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMatSelect"
        Me.Text = "Mat Select"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.chkOldSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridItemVMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cmb_Show, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridItemVMS As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridItems As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmb_MatHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Show As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkOldSpec As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class

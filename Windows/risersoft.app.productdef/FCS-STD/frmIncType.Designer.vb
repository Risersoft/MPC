<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncType
    Inherits frmMax

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmb_ProdIncType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_SeparateShifts = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SeparateShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel2
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.Location = New System.Drawing.Point(62, 27)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(40, 18)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Date"
        '
        'dt_dated
        '
        Me.dt_dated.FormatString = "dddd dd MMM yyyy"
        Me.dt_dated.Location = New System.Drawing.Point(104, 23)
        Me.dt_dated.Name = "dt_dated"
        Me.dt_dated.NullText = "Not Defined"
        Me.dt_dated.Size = New System.Drawing.Size(192, 21)
        Me.dt_dated.TabIndex = 5
        '
        'cmb_ProdIncType
        '
        Me.cmb_ProdIncType.Location = New System.Drawing.Point(103, 94)
        Me.cmb_ProdIncType.Name = "cmb_ProdIncType"
        Me.cmb_ProdIncType.Size = New System.Drawing.Size(200, 22)
        Me.cmb_ProdIncType.TabIndex = 13
        '
        'UltraLabel4
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance2
        Me.UltraLabel4.Location = New System.Drawing.Point(15, 97)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(86, 17)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Incentive Type"
        '
        'cmb_SeparateShifts
        '
        ValueListItem5.DataValue = False
        ValueListItem5.DisplayText = "Salary"
        ValueListItem6.DataValue = True
        ValueListItem6.DisplayText = "Wage"
        Me.cmb_SeparateShifts.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.cmb_SeparateShifts.Location = New System.Drawing.Point(104, 57)
        Me.cmb_SeparateShifts.Name = "cmb_SeparateShifts"
        Me.cmb_SeparateShifts.Size = New System.Drawing.Size(88, 21)
        Me.cmb_SeparateShifts.TabIndex = 55
        Me.cmb_SeparateShifts.Text = "UltraCombo1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 14)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Seperate Shifts"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 185)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(395, 52)
        Me.Panel4.TabIndex = 56
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Location = New System.Drawing.Point(187, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 34)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Location = New System.Drawing.Point(283, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 34)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'frmIncType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Incentive Type"
        Me.ClientSize = New System.Drawing.Size(395, 237)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cmb_SeparateShifts)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_ProdIncType)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.dt_dated)
        Me.Name = "frmIncType"
        Me.Text = "Incentive Type"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SeparateShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_ProdIncType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_SeparateShifts As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
End Class

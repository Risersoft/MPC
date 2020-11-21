<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMat_SPHead
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initForm()

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
    Friend WithEvents cmb_MatHeadID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_HeadCode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cmb_MatHeadID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_HeadCode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_ForEachUnit = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_HeadCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ForEachUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_MatHeadID
        '
        Me.cmb_MatHeadID.DataMember = "heads"
        Me.cmb_MatHeadID.DisplayMember = "HeadName"
        Me.cmb_MatHeadID.Location = New System.Drawing.Point(137, 74)
        Me.cmb_MatHeadID.Name = "cmb_MatHeadID"
        Me.cmb_MatHeadID.Size = New System.Drawing.Size(294, 22)
        Me.cmb_MatHeadID.TabIndex = 3
        Me.cmb_MatHeadID.ValueMember = "matheadid"
        '
        'cmb_HeadCode
        '
        Me.cmb_HeadCode.DataMember = "heads"
        Me.cmb_HeadCode.DisplayMember = "headCode"
        Me.cmb_HeadCode.Enabled = False
        Me.cmb_HeadCode.Location = New System.Drawing.Point(137, 46)
        Me.cmb_HeadCode.Name = "cmb_HeadCode"
        Me.cmb_HeadCode.ReadOnly = True
        Me.cmb_HeadCode.Size = New System.Drawing.Size(160, 22)
        Me.cmb_HeadCode.TabIndex = 1
        Me.cmb_HeadCode.TabStop = False
        Me.cmb_HeadCode.ValueMember = "matheadid"
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 75)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(119, 21)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Head Name"
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Location = New System.Drawing.Point(67, 46)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Head Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 279)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(530, 40)
        Me.Panel4.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance5
        Me.btnSave.Location = New System.Drawing.Point(243, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance6
        Me.btnCancel.Location = New System.Drawing.Point(339, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance7
        Me.btnOK.Location = New System.Drawing.Point(435, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(137, 138)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(160, 32)
        Me.txt_Remark.TabIndex = 7
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(75, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(137, 105)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(142, 21)
        Me.txt_Qty.TabIndex = 5
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(83, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_ForEachUnit
        '
        Me.chk_ForEachUnit.Location = New System.Drawing.Point(137, 176)
        Me.chk_ForEachUnit.Name = "chk_ForEachUnit"
        Me.chk_ForEachUnit.Size = New System.Drawing.Size(160, 24)
        Me.chk_ForEachUnit.TabIndex = 8
        Me.chk_ForEachUnit.Text = "For Each Unit"
        '
        'frmMat_SPHead
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Spare Item from Matlist Head"
        Me.ClientSize = New System.Drawing.Size(530, 319)
        Me.Controls.Add(Me.cmb_MatHeadID)
        Me.Controls.Add(Me.chk_ForEachUnit)
        Me.Controls.Add(Me.cmb_HeadCode)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.txt_Qty)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.Name = "frmMat_SPHead"
        Me.Text = "Spare Item from Matlist Head"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatHeadID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_HeadCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ForEachUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_ForEachUnit As Infragistics.Win.UltraWinEditors.UltraCheckEditor

#End Region
End Class


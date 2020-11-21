<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMat_SpItem
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_ItemUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemId As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CtlItemVMS1 As ctlItemVMS2
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_ItemUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemId = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.CtlItemVMS1 = New risersoft.app.config.ctlItemVMS2()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_ForEachUnit = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ForEachUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_ItemUnit)
        Me.Panel2.Controls.Add(Me.cmb_ItemName)
        Me.Panel2.Controls.Add(Me.cmb_ItemId)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(879, 64)
        Me.Panel2.TabIndex = 0
        '
        'cmb_ItemUnit
        '
        Me.cmb_ItemUnit.DataMember = "items"
        Me.cmb_ItemUnit.DisplayMember = "unitName"
        Me.cmb_ItemUnit.Location = New System.Drawing.Point(548, 8)
        Me.cmb_ItemUnit.Name = "cmb_ItemUnit"
        Me.cmb_ItemUnit.ReadOnly = True
        Me.cmb_ItemUnit.Size = New System.Drawing.Size(108, 22)
        Me.cmb_ItemUnit.TabIndex = 3
        Me.cmb_ItemUnit.TabStop = False
        Me.cmb_ItemUnit.ValueMember = "itemId"
        '
        'cmb_ItemName
        '
        Me.cmb_ItemName.DataMember = "items"
        Me.cmb_ItemName.DisplayMember = "itemName"
        Me.cmb_ItemName.Location = New System.Drawing.Point(112, 32)
        Me.cmb_ItemName.Name = "cmb_ItemName"
        Me.cmb_ItemName.Size = New System.Drawing.Size(544, 22)
        Me.cmb_ItemName.TabIndex = 5
        Me.cmb_ItemName.ValueMember = "itemId"
        '
        'cmb_ItemId
        '
        Me.cmb_ItemId.DataMember = "items"
        Me.cmb_ItemId.DisplayMember = "itemCode"
        Me.cmb_ItemId.Location = New System.Drawing.Point(112, 8)
        Me.cmb_ItemId.Name = "cmb_ItemId"
        Me.cmb_ItemId.Size = New System.Drawing.Size(160, 22)
        Me.cmb_ItemId.TabIndex = 1
        Me.cmb_ItemId.ValueMember = "itemId"
        '
        'UltraLabel3
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.Location = New System.Drawing.Point(513, 11)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Unit"
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(48, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Item Name"
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Location = New System.Drawing.Point(48, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Item Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 526)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(879, 40)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance5
        Me.btnSave.Location = New System.Drawing.Point(592, 3)
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
        Me.btnCancel.Location = New System.Drawing.Point(688, 3)
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
        Me.btnOK.Location = New System.Drawing.Point(784, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'CtlItemVMS1
        '
        Me.CtlItemVMS1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtlItemVMS1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlItemVMS1.ItemVMSID = 0
        Me.CtlItemVMS1.Location = New System.Drawing.Point(0, 64)
        Me.CtlItemVMS1.Mode = risersoft.[shared].EnumVMSMode.acItem
        Me.CtlItemVMS1.Name = "CtlItemVMS1"
        Me.CtlItemVMS1.Size = New System.Drawing.Size(656, 462)
        Me.CtlItemVMS1.TabIndex = 1
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(712, 152)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(160, 32)
        Me.txt_Remark.TabIndex = 6
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(661, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(712, 116)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(97, 21)
        Me.txt_Qty.TabIndex = 4
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(685, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_ForEachUnit
        '
        Me.chk_ForEachUnit.AutoSize = True
        Me.chk_ForEachUnit.Location = New System.Drawing.Point(712, 204)
        Me.chk_ForEachUnit.Name = "chk_ForEachUnit"
        Me.chk_ForEachUnit.Size = New System.Drawing.Size(90, 17)
        Me.chk_ForEachUnit.TabIndex = 7
        Me.chk_ForEachUnit.Text = "For Each Unit"
        '
        'frmMat_SpItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Spare Item"
        Me.ClientSize = New System.Drawing.Size(879, 566)
        Me.Controls.Add(Me.chk_ForEachUnit)
        Me.Controls.Add(Me.txt_Qty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CtlItemVMS1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmMat_SpItem"
        Me.Text = "Spare Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemId, System.ComponentModel.ISupportInitialize).EndInit()
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


Imports  Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMatListSp
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
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_FileNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnAddItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_DescripWO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_FileNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnRenumber = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDown = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddHead = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddItem = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelOldNum = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FileNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGrid1)
        Me.Panel2.Controls.Add(Me.UltraGrid2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 467)
        Me.Panel2.TabIndex = 16
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 88)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(565, 339)
        Me.UltraGrid1.TabIndex = 1
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGrid2.Location = New System.Drawing.Point(565, 88)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(323, 339)
        Me.UltraGrid2.TabIndex = 2
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_DescripWO)
        Me.Panel1.Controls.Add(Me.UltraLabel13)
        Me.Panel1.Controls.Add(Me.txt_FileNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 88)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(32, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DescripWO
        '
        Me.txt_DescripWO.Location = New System.Drawing.Point(112, 21)
        Me.txt_DescripWO.Name = "txt_DescripWO"
        Me.txt_DescripWO.ReadOnly = True
        Me.txt_DescripWO.Size = New System.Drawing.Size(460, 21)
        Me.txt_DescripWO.TabIndex = 1
        Me.txt_DescripWO.Text = "UltraTextEditor1"
        '
        'UltraLabel13
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance1
        Me.UltraLabel13.Location = New System.Drawing.Point(32, 48)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel13.TabIndex = 2
        Me.UltraLabel13.Text = "File Number"
        '
        'txt_FileNum
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_FileNum.Appearance = Appearance2
        Me.txt_FileNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_FileNum.Location = New System.Drawing.Point(112, 48)
        Me.txt_FileNum.Name = "txt_FileNum"
        Me.txt_FileNum.ReadOnly = True
        Me.txt_FileNum.Size = New System.Drawing.Size(152, 21)
        Me.txt_FileNum.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnRenumber)
        Me.Panel9.Controls.Add(Me.btnMoveDown)
        Me.Panel9.Controls.Add(Me.btnMoveUp)
        Me.Panel9.Controls.Add(Me.btnCopy)
        Me.Panel9.Controls.Add(Me.btnAddHead)
        Me.Panel9.Controls.Add(Me.btnEdit)
        Me.Panel9.Controls.Add(Me.btnDel)
        Me.Panel9.Controls.Add(Me.btnAddItem)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 427)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(888, 40)
        Me.Panel9.TabIndex = 8
        '
        'btnRenumber
        '
        Me.btnRenumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRenumber.Location = New System.Drawing.Point(298, 0)
        Me.btnRenumber.Name = "btnRenumber"
        Me.btnRenumber.Size = New System.Drawing.Size(79, 40)
        Me.btnRenumber.TabIndex = 4
        Me.btnRenumber.Text = "Renumber"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMoveDown.Location = New System.Drawing.Point(219, 0)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(79, 40)
        Me.btnMoveDown.TabIndex = 3
        Me.btnMoveDown.Text = "Move Down"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMoveUp.Location = New System.Drawing.Point(140, 0)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(79, 40)
        Me.btnMoveUp.TabIndex = 2
        Me.btnMoveUp.Text = "Move Up"
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopy.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCopy.Location = New System.Drawing.Point(561, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(109, 40)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = "Copy Unused Heads From"
        Me.btnCopy.Visible = False
        '
        'btnAddHead
        '
        Me.btnAddHead.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddHead.Location = New System.Drawing.Point(670, 0)
        Me.btnAddHead.Name = "btnAddHead"
        Me.btnAddHead.Size = New System.Drawing.Size(109, 40)
        Me.btnAddHead.TabIndex = 6
        Me.btnAddHead.Text = "Add New Head"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.Location = New System.Drawing.Point(70, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 40)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDel.Location = New System.Drawing.Point(0, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 40)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "Delete"
        '
        'btnAddItem
        '
        Me.btnAddItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddItem.Location = New System.Drawing.Point(779, 0)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(109, 40)
        Me.btnAddItem.TabIndex = 7
        Me.btnAddItem.Text = "Add New Item"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LabelOldNum)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 467)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(888, 48)
        Me.Panel4.TabIndex = 0
        '
        'LabelOldNum
        '
        Me.LabelOldNum.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LabelOldNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOldNum.Location = New System.Drawing.Point(298, 16)
        Me.LabelOldNum.Name = "LabelOldNum"
        Me.LabelOldNum.Size = New System.Drawing.Size(48, 16)
        Me.LabelOldNum.TabIndex = 1
        Me.LabelOldNum.Text = "2"
        Me.LabelOldNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(29, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "No. of Old Versions Selected:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Location = New System.Drawing.Point(600, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Location = New System.Drawing.Point(696, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Location = New System.Drawing.Point(792, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        '
        'frmMatListSp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Material List Spares"
        Me.ClientSize = New System.Drawing.Size(888, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMatListSp"
        Me.Text = "Material List Spares"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FileNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelOldNum As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAddHead As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnRenumber As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveDown As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveUp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_DescripWO As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class


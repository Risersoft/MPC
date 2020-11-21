<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdBasic
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.InitForm()
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
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Persons = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_prodType3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ProdType2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ProdType1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblType1 = New System.Windows.Forms.Label()
        Me.lblType3 = New System.Windows.Forms.Label()
        Me.lblType2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Persons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_prodType3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdType1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Remark)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Persons)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Descrip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(785, 344)
        Me.SplitContainer1.SplitterDistance = 388
        Me.SplitContainer1.TabIndex = 0
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(118, 283)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(240, 56)
        Me.txt_Remark.TabIndex = 6
        Me.txt_Remark.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remark"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Persons
        '
        Me.txt_Persons.Location = New System.Drawing.Point(118, 242)
        Me.txt_Persons.Name = "txt_Persons"
        Me.txt_Persons.Size = New System.Drawing.Size(240, 21)
        Me.txt_Persons.TabIndex = 4
        Me.txt_Persons.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(38, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Persons"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Descrip
        '
        Me.txt_Descrip.Location = New System.Drawing.Point(118, 203)
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.Size = New System.Drawing.Size(240, 21)
        Me.txt_Descrip.TabIndex = 2
        Me.txt_Descrip.Text = "UltraTextEditor1"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(38, 205)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 18)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Description"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_prodType3)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ProdType2)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ProdType1)
        Me.UltraGroupBox1.Controls.Add(Me.lblType1)
        Me.UltraGroupBox1.Controls.Add(Me.lblType3)
        Me.UltraGroupBox1.Controls.Add(Me.lblType2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(3, 13)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(370, 143)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Basic Productions"
        '
        'txt_prodType3
        '
        Me.txt_prodType3.Location = New System.Drawing.Point(115, 105)
        Me.txt_prodType3.Name = "txt_prodType3"
        Me.txt_prodType3.Size = New System.Drawing.Size(240, 21)
        Me.txt_prodType3.TabIndex = 5
        Me.txt_prodType3.Text = "UltraTextEditor1"
        '
        'txt_ProdType2
        '
        Me.txt_ProdType2.Location = New System.Drawing.Point(115, 61)
        Me.txt_ProdType2.Name = "txt_ProdType2"
        Me.txt_ProdType2.Size = New System.Drawing.Size(240, 21)
        Me.txt_ProdType2.TabIndex = 3
        Me.txt_ProdType2.Text = "UltraTextEditor1"
        '
        'txt_ProdType1
        '
        Me.txt_ProdType1.Location = New System.Drawing.Point(115, 19)
        Me.txt_ProdType1.Name = "txt_ProdType1"
        Me.txt_ProdType1.Size = New System.Drawing.Size(240, 21)
        Me.txt_ProdType1.TabIndex = 1
        Me.txt_ProdType1.Text = "UltraTextEditor1"
        '
        'lblType1
        '
        Me.lblType1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType1.Location = New System.Drawing.Point(9, 22)
        Me.lblType1.Name = "lblType1"
        Me.lblType1.Size = New System.Drawing.Size(100, 16)
        Me.lblType1.TabIndex = 0
        Me.lblType1.Text = "Type 1"
        Me.lblType1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType3
        '
        Me.lblType3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType3.Location = New System.Drawing.Point(9, 108)
        Me.lblType3.Name = "lblType3"
        Me.lblType3.Size = New System.Drawing.Size(100, 16)
        Me.lblType3.TabIndex = 4
        Me.lblType3.Text = "Type 3"
        Me.lblType3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType2
        '
        Me.lblType2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType2.Location = New System.Drawing.Point(9, 64)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Size = New System.Drawing.Size(100, 16)
        Me.lblType2.TabIndex = 2
        Me.lblType2.Text = "Type 2"
        Me.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 344)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(785, 42)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance9
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(521, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance10
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(609, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance11.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance11
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(697, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'frmProdBasic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Basic Production"
        Me.ClientSize = New System.Drawing.Size(785, 386)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProdBasic"
        Me.Text = "Basic Production"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Persons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_prodType3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdType1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lblType1 As System.Windows.Forms.Label
    Friend WithEvents lblType3 As System.Windows.Forms.Label
    Friend WithEvents lblType2 As System.Windows.Forms.Label
    Friend WithEvents txt_prodType3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ProdType2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ProdType1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Persons As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton

#End Region
End Class


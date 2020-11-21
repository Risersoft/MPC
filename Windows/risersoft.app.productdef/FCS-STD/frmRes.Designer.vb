<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmRes
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDep As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblArbit As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_ResourceName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ResDescrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmb_infinite As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_shiftid As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblArbit = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_shiftid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmb_infinite = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txt_ResourceName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ResDescrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_shiftid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.cmb_infinite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ResourceName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ResDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(584, 48)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(304, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(392, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(488, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDep)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblCode)
        Me.Panel1.Controls.Add(Me.lblArbit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 120)
        Me.Panel1.TabIndex = 1
        '
        'lblDep
        '
        Me.lblDep.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDep.Location = New System.Drawing.Point(120, 64)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(288, 24)
        Me.lblDep.TabIndex = 5
        Me.lblDep.Text = "Mr Rajendra Prasad"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dep."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(120, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(288, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Mr Rajendra Prasad"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCode.Location = New System.Drawing.Point(120, 16)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(192, 16)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Mr Rajendra Prasad"
        '
        'lblArbit
        '
        Me.lblArbit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArbit.Location = New System.Drawing.Point(64, 16)
        Me.lblArbit.Name = "lblArbit"
        Me.lblArbit.Size = New System.Drawing.Size(48, 16)
        Me.lblArbit.TabIndex = 0
        Me.lblArbit.Text = "Code"
        Me.lblArbit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmb_shiftid)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txt_ResourceName)
        Me.Panel2.Controls.Add(Me.txt_ResDescrip)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 198)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Shift"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_shiftid
        '
        Appearance9.FontData.BoldAsString = "False"
        Me.cmb_shiftid.Appearance = Appearance9
        Me.cmb_shiftid.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_shiftid.Location = New System.Drawing.Point(112, 120)
        Me.cmb_shiftid.Name = "cmb_shiftid"
        Me.cmb_shiftid.Size = New System.Drawing.Size(144, 25)
        Me.cmb_shiftid.TabIndex = 5
        Me.cmb_shiftid.Text = "UltraCombo5"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmb_infinite)
        Me.Panel3.Controls.Add(Me.UltraLabel10)
        Me.Panel3.Controls.Add(Me.txt_qty)
        Me.Panel3.Controls.Add(Me.lblQty)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(584, 48)
        Me.Panel3.TabIndex = 6
        '
        'cmb_infinite
        '
        Appearance4.FontData.SizeInPoints = 10.0!
        Me.cmb_infinite.Appearance = Appearance4
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Finite"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Infinite"
        Me.cmb_infinite.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_infinite.Location = New System.Drawing.Point(112, 12)
        Me.cmb_infinite.Name = "cmb_infinite"
        Me.cmb_infinite.Size = New System.Drawing.Size(160, 24)
        Me.cmb_infinite.TabIndex = 1
        Me.cmb_infinite.Text = "UltraComboEditor1"
        '
        'UltraLabel10
        '
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance5
        Me.UltraLabel10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel10.Location = New System.Drawing.Point(48, 12)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel10.TabIndex = 0
        Me.UltraLabel10.Text = "Loading"
        '
        'txt_qty
        '
        Appearance6.FontData.SizeInPoints = 10.0!
        Me.txt_qty.Appearance = Appearance6
        Me.txt_qty.Location = New System.Drawing.Point(392, 12)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(104, 24)
        Me.txt_qty.TabIndex = 3
        Me.txt_qty.Text = "UltraTextEditor1"
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblQty.Location = New System.Drawing.Point(288, 12)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(96, 24)
        Me.lblQty.TabIndex = 2
        Me.lblQty.Text = "Resource Qty"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ResourceName
        '
        Appearance7.FontData.SizeInPoints = 10.0!
        Me.txt_ResourceName.Appearance = Appearance7
        Me.txt_ResourceName.Location = New System.Drawing.Point(112, 8)
        Me.txt_ResourceName.Name = "txt_ResourceName"
        Me.txt_ResourceName.Size = New System.Drawing.Size(296, 24)
        Me.txt_ResourceName.TabIndex = 1
        Me.txt_ResourceName.Text = "UltraTextEditor1"
        '
        'txt_ResDescrip
        '
        Me.txt_ResDescrip.AcceptsReturn = True
        Appearance8.FontData.SizeInPoints = 10.0!
        Me.txt_ResDescrip.Appearance = Appearance8
        Me.txt_ResDescrip.Location = New System.Drawing.Point(112, 48)
        Me.txt_ResDescrip.Multiline = True
        Me.txt_ResDescrip.Name = "txt_ResDescrip"
        Me.txt_ResDescrip.Size = New System.Drawing.Size(456, 56)
        Me.txt_ResDescrip.TabIndex = 3
        Me.txt_ResDescrip.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(16, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 32)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Resource Name"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Employee Resource"
        Me.ClientSize = New System.Drawing.Size(584, 366)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRes"
        Me.Text = "Employee Resource"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_shiftid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cmb_infinite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ResourceName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ResDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class


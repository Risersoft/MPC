Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmResCrew
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        myView.SetGrid(Me.UltraGridResources)
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridResources As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_isother As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnSelRes As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_ResGroupName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ResGroupDescrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_isother = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ResGroupName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ResGroupDescrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UltraGridResources = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelRes = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_isother, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ResGroupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ResGroupDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 414)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(648, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(360, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(456, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(552, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_isother)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_ResGroupName)
        Me.Panel1.Controls.Add(Me.txt_ResGroupDescrip)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 144)
        Me.Panel1.TabIndex = 0
        '
        'cmb_isother
        '
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Employee"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Other"
        Me.cmb_isother.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_isother.Location = New System.Drawing.Point(152, 48)
        Me.cmb_isother.Name = "cmb_isother"
        Me.cmb_isother.ReadOnly = True
        Me.cmb_isother.Size = New System.Drawing.Size(144, 21)
        Me.cmb_isother.TabIndex = 3
        Me.cmb_isother.Text = "UltraComboEditor9"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(48, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Crew Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ResGroupName
        '
        Appearance4.FontData.SizeInPoints = 10.0!
        Me.txt_ResGroupName.Appearance = Appearance4
        Me.txt_ResGroupName.Location = New System.Drawing.Point(148, 16)
        Me.txt_ResGroupName.Name = "txt_ResGroupName"
        Me.txt_ResGroupName.Size = New System.Drawing.Size(296, 24)
        Me.txt_ResGroupName.TabIndex = 1
        Me.txt_ResGroupName.Text = "UltraTextEditor1"
        '
        'txt_ResGroupDescrip
        '
        Me.txt_ResGroupDescrip.AcceptsReturn = True
        Appearance5.FontData.SizeInPoints = 10.0!
        Me.txt_ResGroupDescrip.Appearance = Appearance5
        Me.txt_ResGroupDescrip.Location = New System.Drawing.Point(148, 80)
        Me.txt_ResGroupDescrip.Multiline = True
        Me.txt_ResGroupDescrip.Name = "txt_ResGroupDescrip"
        Me.txt_ResGroupDescrip.Size = New System.Drawing.Size(456, 56)
        Me.txt_ResGroupDescrip.TabIndex = 5
        Me.txt_ResGroupDescrip.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(44, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(52, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Crew Name"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraGridResources
        '
        Me.UltraGridResources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridResources.Location = New System.Drawing.Point(0, 144)
        Me.UltraGridResources.Name = "UltraGridResources"
        Me.UltraGridResources.Size = New System.Drawing.Size(648, 230)
        Me.UltraGridResources.TabIndex = 1
        Me.UltraGridResources.Text = "Report"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Controls.Add(Me.btnSelRes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 374)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(648, 40)
        Me.Panel3.TabIndex = 2
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(552, 8)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 24)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "&Delete"
        '
        'btnSelRes
        '
        Me.btnSelRes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelRes.Location = New System.Drawing.Point(424, 8)
        Me.btnSelRes.Name = "btnSelRes"
        Me.btnSelRes.Size = New System.Drawing.Size(120, 24)
        Me.btnSelRes.TabIndex = 0
        Me.btnSelRes.Text = "Select Resources"
        '
        'frmResCrew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Resource Crew"
        Me.ClientSize = New System.Drawing.Size(648, 462)
        Me.Controls.Add(Me.UltraGridResources)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmResCrew"
        Me.Text = "Resource Crew"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_isother, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ResGroupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ResGroupDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridResources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class


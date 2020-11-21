Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMacGroup
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        myView.SetGrid(Me.UltraGridMachines)
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
    Friend WithEvents UltraGridMachines As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_PlnMcGroupName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PlnMcGroupDescrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnSelMac As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_PlnMcGroupName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PlnMcGroupDescrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UltraGridMachines = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelMac = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_PlnMcGroupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PlnMcGroupDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridMachines, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(635, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(347, 8)
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
        Me.btnCancel.Location = New System.Drawing.Point(443, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(539, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_PlnMcGroupName)
        Me.Panel1.Controls.Add(Me.txt_PlnMcGroupDescrip)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 120)
        Me.Panel1.TabIndex = 0
        '
        'txt_PlnMcGroupName
        '
        Appearance4.FontData.SizeInPoints = 10.0!
        Me.txt_PlnMcGroupName.Appearance = Appearance4
        Me.txt_PlnMcGroupName.Location = New System.Drawing.Point(148, 16)
        Me.txt_PlnMcGroupName.Name = "txt_PlnMcGroupName"
        Me.txt_PlnMcGroupName.Size = New System.Drawing.Size(296, 24)
        Me.txt_PlnMcGroupName.TabIndex = 1
        Me.txt_PlnMcGroupName.Text = "UltraTextEditor1"
        '
        'txt_PlnMcGroupDescrip
        '
        Me.txt_PlnMcGroupDescrip.AcceptsReturn = True
        Appearance5.FontData.SizeInPoints = 10.0!
        Me.txt_PlnMcGroupDescrip.Appearance = Appearance5
        Me.txt_PlnMcGroupDescrip.Location = New System.Drawing.Point(148, 48)
        Me.txt_PlnMcGroupDescrip.Multiline = True
        Me.txt_PlnMcGroupDescrip.Name = "txt_PlnMcGroupDescrip"
        Me.txt_PlnMcGroupDescrip.Size = New System.Drawing.Size(456, 56)
        Me.txt_PlnMcGroupDescrip.TabIndex = 3
        Me.txt_PlnMcGroupDescrip.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(44, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
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
        Me.Label22.Text = "Group Name"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraGridMachines
        '
        Me.UltraGridMachines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridMachines.Location = New System.Drawing.Point(0, 120)
        Me.UltraGridMachines.Name = "UltraGridMachines"
        Me.UltraGridMachines.Size = New System.Drawing.Size(635, 254)
        Me.UltraGridMachines.TabIndex = 1
        Me.UltraGridMachines.Text = "Report"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Controls.Add(Me.btnSelMac)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 374)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(635, 40)
        Me.Panel3.TabIndex = 2
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(539, 8)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 24)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "&Delete"
        '
        'btnSelMac
        '
        Me.btnSelMac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelMac.Location = New System.Drawing.Point(411, 8)
        Me.btnSelMac.Name = "btnSelMac"
        Me.btnSelMac.Size = New System.Drawing.Size(120, 24)
        Me.btnSelMac.TabIndex = 0
        Me.btnSelMac.Text = "Select Machines"
        '
        'frmMacGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Machine Group"
        Me.ClientSize = New System.Drawing.Size(635, 462)
        Me.Controls.Add(Me.UltraGridMachines)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMacGroup"
        Me.Text = "Machine Group"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_PlnMcGroupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PlnMcGroupDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridMachines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class


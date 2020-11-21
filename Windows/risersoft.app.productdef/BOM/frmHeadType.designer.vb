Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmHeadType
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_PrepGroup = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_HeadType = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Matlist1Title = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_SeparatePrint = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PrepGroupFooter = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_PrepGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_HeadType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Matlist1Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_SeparatePrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PrepGroupFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 281)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(758, 48)
        Me.Panel4.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance18
        Me.btnSave.Location = New System.Drawing.Point(470, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance19.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance19
        Me.btnCancel.Location = New System.Drawing.Point(566, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance20
        Me.btnOK.Location = New System.Drawing.Point(662, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'cmb_PrepGroup
        '
        Me.cmb_PrepGroup.Location = New System.Drawing.Point(151, 129)
        Me.cmb_PrepGroup.Name = "cmb_PrepGroup"
        Me.cmb_PrepGroup.Size = New System.Drawing.Size(272, 21)
        Me.cmb_PrepGroup.TabIndex = 6
        Me.cmb_PrepGroup.Text = "UltraComboEditor1"
        '
        'UltraLabel11
        '
        Appearance27.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance27
        Me.UltraLabel11.Location = New System.Drawing.Point(0, 129)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(143, 16)
        Me.UltraLabel11.TabIndex = 5
        Me.UltraLabel11.Text = "Preparation Group"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(47, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Head Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_HeadType
        '
        Me.txt_HeadType.Location = New System.Drawing.Point(151, 12)
        Me.txt_HeadType.Name = "txt_HeadType"
        Me.txt_HeadType.Size = New System.Drawing.Size(572, 21)
        Me.txt_HeadType.TabIndex = 1
        Me.txt_HeadType.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(47, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Matlist1 Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Matlist1Title
        '
        Me.txt_Matlist1Title.Location = New System.Drawing.Point(151, 52)
        Me.txt_Matlist1Title.Name = "txt_Matlist1Title"
        Me.txt_Matlist1Title.Size = New System.Drawing.Size(572, 21)
        Me.txt_Matlist1Title.TabIndex = 3
        Me.txt_Matlist1Title.Text = "UltraTextEditor1"
        '
        'chk_SeparatePrint
        '
        Appearance26.FontData.BoldAsString = "False"
        Appearance26.FontData.SizeInPoints = 8.0!
        Appearance26.TextHAlignAsString = "Left"
        Me.chk_SeparatePrint.Appearance = Appearance26
        Me.chk_SeparatePrint.Location = New System.Drawing.Point(151, 95)
        Me.chk_SeparatePrint.Name = "chk_SeparatePrint"
        Me.chk_SeparatePrint.Size = New System.Drawing.Size(163, 16)
        Me.chk_SeparatePrint.TabIndex = 4
        Me.chk_SeparatePrint.Text = "Print Separately"
        '
        'UltraLabel1
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.Location = New System.Drawing.Point(63, 185)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 40)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Prepration Group Footer"
        '
        'txt_PrepGroupFooter
        '
        Me.txt_PrepGroupFooter.AcceptsReturn = True
        Appearance24.FontData.BoldAsString = "False"
        Appearance24.FontData.ItalicAsString = "False"
        Appearance24.FontData.Name = "Arial"
        Appearance24.FontData.SizeInPoints = 8.25!
        Appearance24.FontData.StrikeoutAsString = "False"
        Appearance24.FontData.UnderlineAsString = "False"
        Me.txt_PrepGroupFooter.Appearance = Appearance24
        Me.txt_PrepGroupFooter.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PrepGroupFooter.Location = New System.Drawing.Point(151, 182)
        Me.txt_PrepGroupFooter.Multiline = True
        Me.txt_PrepGroupFooter.Name = "txt_PrepGroupFooter"
        Me.txt_PrepGroupFooter.Size = New System.Drawing.Size(572, 40)
        Me.txt_PrepGroupFooter.TabIndex = 8
        '
        'frmHeadType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Head Type"
        Me.ClientSize = New System.Drawing.Size(758, 329)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txt_PrepGroupFooter)
        Me.Controls.Add(Me.chk_SeparatePrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Matlist1Title)
        Me.Controls.Add(Me.cmb_PrepGroup)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_HeadType)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmHeadType"
        Me.Text = "Head Type"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_PrepGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_HeadType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Matlist1Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_SeparatePrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PrepGroupFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_PrepGroup As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_HeadType As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Matlist1Title As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_SeparatePrint As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PrepGroupFooter As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class


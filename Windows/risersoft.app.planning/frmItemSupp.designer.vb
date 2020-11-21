Imports ug = Infragistics.Win.UltraWinGrid
Imports we = Infragistics.Win.UltraWinEditors
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmItemSupp
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
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Rate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_IsApproved As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_VendorID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_perDC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SuppSpecs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Rate = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_IsApproved = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_VendorID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_perDC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_SuppSpecs = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_Rate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_VendorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_perDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SuppSpecs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(536, 48)
        Me.Panel4.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(328, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Location = New System.Drawing.Point(424, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(88, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Rate"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Rate
        '
        Appearance3.FontData.BoldAsString = "False"
        Me.txt_Rate.Appearance = Appearance3
        Me.txt_Rate.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Rate.Location = New System.Drawing.Point(144, 48)
        Me.txt_Rate.Name = "txt_Rate"
        Me.txt_Rate.Size = New System.Drawing.Size(200, 17)
        Me.txt_Rate.TabIndex = 3
        Me.txt_Rate.Text = "UltraTextEditor12"
        '
        'chk_IsApproved
        '
        Me.chk_IsApproved.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_IsApproved.Location = New System.Drawing.Point(368, 48)
        Me.chk_IsApproved.Name = "chk_IsApproved"
        Me.chk_IsApproved.Size = New System.Drawing.Size(144, 32)
        Me.chk_IsApproved.TabIndex = 4
        Me.chk_IsApproved.Text = "Supplier is Approved for this item"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(40, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Vendor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_VendorID
        '
        Appearance4.FontData.BoldAsString = "False"
        Me.cmb_VendorID.Appearance = Appearance4
        Me.cmb_VendorID.Location = New System.Drawing.Point(144, 16)
        Me.cmb_VendorID.Name = "cmb_VendorID"
        Me.cmb_VendorID.Size = New System.Drawing.Size(352, 22)
        Me.cmb_VendorID.TabIndex = 1
        Me.cmb_VendorID.Text = "UltraCombo5"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(72, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "% Discount"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_perDC
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.txt_perDC.Appearance = Appearance5
        Me.txt_perDC.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_perDC.Location = New System.Drawing.Point(144, 72)
        Me.txt_perDC.Name = "txt_perDC"
        Me.txt_perDC.Size = New System.Drawing.Size(72, 17)
        Me.txt_perDC.TabIndex = 6
        Me.txt_perDC.Text = "UltraTextEditor2"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Supplier Specification"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SuppSpecs
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.txt_SuppSpecs.Appearance = Appearance6
        Me.txt_SuppSpecs.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_SuppSpecs.Location = New System.Drawing.Point(144, 96)
        Me.txt_SuppSpecs.Multiline = True
        Me.txt_SuppSpecs.Name = "txt_SuppSpecs"
        Me.txt_SuppSpecs.Size = New System.Drawing.Size(248, 48)
        Me.txt_SuppSpecs.TabIndex = 8
        Me.txt_SuppSpecs.Text = "UltraTextEditor7"
        '
        'frmItemSupp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Supplier Item"
        Me.ClientSize = New System.Drawing.Size(536, 213)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_SuppSpecs)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_perDC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_VendorID)
        Me.Controls.Add(Me.chk_IsApproved)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Rate)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmItemSupp"
        Me.Text = "Supplier Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_Rate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_VendorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_perDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SuppSpecs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
End Class


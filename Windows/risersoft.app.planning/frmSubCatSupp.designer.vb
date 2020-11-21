Imports ug = Infragistics.Win.UltraWinGrid
Imports we = Infragistics.Win.UltraWinEditors
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSubCatSupp
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chk_IsApproved As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_MakeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.chk_IsApproved = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_MakeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_VendorID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Pref = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_RatResponse = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_RatDelivery = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_RatQuality = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_RatPrice = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ProductRange = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_Category = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chk_IsDomestic = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsExport = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.chk_IsApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MakeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_VendorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Pref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmb_RatResponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RatDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RatQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RatPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProductRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsDomestic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 372)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(541, 48)
        Me.Panel4.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Location = New System.Drawing.Point(239, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(333, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Location = New System.Drawing.Point(429, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'chk_IsApproved
        '
        Me.chk_IsApproved.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_IsApproved.Location = New System.Drawing.Point(144, 44)
        Me.chk_IsApproved.Name = "chk_IsApproved"
        Me.chk_IsApproved.Size = New System.Drawing.Size(144, 32)
        Me.chk_IsApproved.TabIndex = 2
        Me.chk_IsApproved.Text = "Supplier is Approved for this item"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(40, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Make"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_MakeID
        '
        Appearance7.FontData.BoldAsString = "False"
        Me.cmb_MakeID.Appearance = Appearance7
        Me.cmb_MakeID.Location = New System.Drawing.Point(144, 16)
        Me.cmb_MakeID.Name = "cmb_MakeID"
        Me.cmb_MakeID.Size = New System.Drawing.Size(352, 22)
        Me.cmb_MakeID.TabIndex = 1
        Me.cmb_MakeID.Text = "UltraCombo5"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 295)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Remarks"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remarks
        '
        Appearance8.FontData.BoldAsString = "False"
        Me.txt_Remarks.Appearance = Appearance8
        Me.txt_Remarks.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Remarks.Location = New System.Drawing.Point(144, 295)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(352, 48)
        Me.txt_Remarks.TabIndex = 14
        Me.txt_Remarks.Text = "UltraTextEditor7"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Supplier (if different from Make)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_VendorID
        '
        Appearance4.FontData.BoldAsString = "False"
        Me.cmb_VendorID.Appearance = Appearance4
        Me.cmb_VendorID.Location = New System.Drawing.Point(144, 82)
        Me.cmb_VendorID.Name = "cmb_VendorID"
        Me.cmb_VendorID.Size = New System.Drawing.Size(352, 22)
        Me.cmb_VendorID.TabIndex = 4
        Me.cmb_VendorID.Text = "UltraCombo5"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(72, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Preference"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Pref
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.txt_Pref.Appearance = Appearance5
        Me.txt_Pref.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Pref.Location = New System.Drawing.Point(144, 131)
        Me.txt_Pref.Name = "txt_Pref"
        Me.txt_Pref.Size = New System.Drawing.Size(72, 17)
        Me.txt_Pref.TabIndex = 6
        Me.txt_Pref.Text = "UltraTextEditor2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb_RatResponse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_RatDelivery)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_RatQuality)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_RatPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 127)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ratings"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(15, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Response"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RatResponse
        '
        ValueListItem4.DataValue = False
        ValueListItem4.DisplayText = "Purchase"
        ValueListItem5.DataValue = True
        ValueListItem5.DisplayText = "Job Work"
        Me.cmb_RatResponse.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5})
        Me.cmb_RatResponse.Location = New System.Drawing.Point(98, 100)
        Me.cmb_RatResponse.Name = "cmb_RatResponse"
        Me.cmb_RatResponse.Size = New System.Drawing.Size(106, 21)
        Me.cmb_RatResponse.TabIndex = 7
        Me.cmb_RatResponse.Text = "UltraComboEditor9"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Delivery"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RatDelivery
        '
        ValueListItem3.DataValue = False
        ValueListItem3.DisplayText = "Purchase"
        ValueListItem6.DataValue = True
        ValueListItem6.DisplayText = "Job Work"
        Me.cmb_RatDelivery.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem6})
        Me.cmb_RatDelivery.Location = New System.Drawing.Point(98, 73)
        Me.cmb_RatDelivery.Name = "cmb_RatDelivery"
        Me.cmb_RatDelivery.Size = New System.Drawing.Size(106, 21)
        Me.cmb_RatDelivery.TabIndex = 5
        Me.cmb_RatDelivery.Text = "UltraComboEditor9"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quality"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RatQuality
        '
        ValueListItem7.DataValue = False
        ValueListItem7.DisplayText = "Purchase"
        ValueListItem8.DataValue = True
        ValueListItem8.DisplayText = "Job Work"
        Me.cmb_RatQuality.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8})
        Me.cmb_RatQuality.Location = New System.Drawing.Point(98, 46)
        Me.cmb_RatQuality.Name = "cmb_RatQuality"
        Me.cmb_RatQuality.Size = New System.Drawing.Size(106, 21)
        Me.cmb_RatQuality.TabIndex = 3
        Me.cmb_RatQuality.Text = "UltraComboEditor9"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(15, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RatPrice
        '
        ValueListItem9.DataValue = False
        ValueListItem9.DisplayText = "Purchase"
        ValueListItem10.DataValue = True
        ValueListItem10.DisplayText = "Job Work"
        Me.cmb_RatPrice.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem9, ValueListItem10})
        Me.cmb_RatPrice.Location = New System.Drawing.Point(98, 19)
        Me.cmb_RatPrice.Name = "cmb_RatPrice"
        Me.cmb_RatPrice.Size = New System.Drawing.Size(106, 21)
        Me.cmb_RatPrice.TabIndex = 1
        Me.cmb_RatPrice.Text = "UltraComboEditor9"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 37)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Product Range for this sub category"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProductRange
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.txt_ProductRange.Appearance = Appearance6
        Me.txt_ProductRange.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_ProductRange.Location = New System.Drawing.Point(144, 241)
        Me.txt_ProductRange.Multiline = True
        Me.txt_ProductRange.Name = "txt_ProductRange"
        Me.txt_ProductRange.Size = New System.Drawing.Size(352, 48)
        Me.txt_ProductRange.TabIndex = 12
        Me.txt_ProductRange.Text = "UltraTextEditor7"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(61, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Category"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Category
        '
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Purchase"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Job Work"
        Me.cmb_Category.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_Category.Location = New System.Drawing.Point(144, 156)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(106, 21)
        Me.cmb_Category.TabIndex = 8
        Me.cmb_Category.Text = "UltraComboEditor9"
        '
        'chk_IsDomestic
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.SizeInPoints = 8.0!
        Me.chk_IsDomestic.Appearance = Appearance9
        Me.chk_IsDomestic.Location = New System.Drawing.Point(144, 186)
        Me.chk_IsDomestic.Name = "chk_IsDomestic"
        Me.chk_IsDomestic.Size = New System.Drawing.Size(101, 16)
        Me.chk_IsDomestic.TabIndex = 9
        Me.chk_IsDomestic.Text = "Domestic"
        '
        'chk_IsExport
        '
        Appearance36.FontData.BoldAsString = "True"
        Appearance36.FontData.SizeInPoints = 8.0!
        Me.chk_IsExport.Appearance = Appearance36
        Me.chk_IsExport.Location = New System.Drawing.Point(144, 210)
        Me.chk_IsExport.Name = "chk_IsExport"
        Me.chk_IsExport.Size = New System.Drawing.Size(101, 16)
        Me.chk_IsExport.TabIndex = 10
        Me.chk_IsExport.Text = "Export"
        '
        'frmSubCatSupp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Supplier Item"
        Me.ClientSize = New System.Drawing.Size(541, 420)
        Me.Controls.Add(Me.chk_IsExport)
        Me.Controls.Add(Me.chk_IsDomestic)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_Category)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_ProductRange)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_Pref)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_VendorID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_MakeID)
        Me.Controls.Add(Me.chk_IsApproved)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSubCatSupp"
        Me.Text = "Supplier Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.chk_IsApproved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MakeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_VendorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Pref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmb_RatResponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RatDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RatQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RatPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProductRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsDomestic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_VendorID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Pref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_RatResponse As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_RatDelivery As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_RatQuality As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_RatPrice As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_ProductRange As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Category As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chk_IsDomestic As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsExport As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton

#End Region
End Class


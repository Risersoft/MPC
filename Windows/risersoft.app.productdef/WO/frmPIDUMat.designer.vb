<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPIDUMat
    ' Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlItemVMS1 = New risersoft.app.config.ctlItemVMS2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_ItemUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ItemId = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_AfterEnd = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_MarginDays = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.cmb_ConsByPIDURouteID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_ProdByPIDURouteID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cmb_AfterEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MarginDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.cmb_ConsByPIDURouteID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdByPIDURouteID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.CtlItemVMS1)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(622, 299)
        '
        'CtlItemVMS1
        '
        Me.CtlItemVMS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlItemVMS1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlItemVMS1.ItemVMSID = 0
        Me.CtlItemVMS1.Location = New System.Drawing.Point(0, 64)
        Me.CtlItemVMS1.Mode = risersoft.[shared].EnumVMSMode.acItem
        Me.CtlItemVMS1.Name = "CtlItemVMS1"
        Me.CtlItemVMS1.Size = New System.Drawing.Size(622, 235)
        Me.CtlItemVMS1.TabIndex = 1
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
        Me.Panel2.Size = New System.Drawing.Size(622, 64)
        Me.Panel2.TabIndex = 0
        '
        'cmb_ItemUnit
        '
        Me.cmb_ItemUnit.DataMember = "items"
        Me.cmb_ItemUnit.DisplayMember = "unitName"
        Me.cmb_ItemUnit.Location = New System.Drawing.Point(439, 8)
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
        Me.cmb_ItemName.Location = New System.Drawing.Point(80, 32)
        Me.cmb_ItemName.Name = "cmb_ItemName"
        Me.cmb_ItemName.Size = New System.Drawing.Size(467, 22)
        Me.cmb_ItemName.TabIndex = 5
        Me.cmb_ItemName.ValueMember = "itemId"
        '
        'cmb_ItemId
        '
        Me.cmb_ItemId.DataMember = "items"
        Me.cmb_ItemId.DisplayMember = "itemCode"
        Me.cmb_ItemId.Location = New System.Drawing.Point(80, 8)
        Me.cmb_ItemId.Name = "cmb_ItemId"
        Me.cmb_ItemId.Size = New System.Drawing.Size(160, 22)
        Me.cmb_ItemId.TabIndex = 1
        Me.cmb_ItemId.ValueMember = "itemId"
        '
        'UltraLabel3
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.Location = New System.Drawing.Point(404, 11)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Unit"
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Item Name"
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Item Code"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_AfterEnd)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel11)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_MarginDays)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Qty)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(622, 299)
        '
        'cmb_AfterEnd
        '
        Me.cmb_AfterEnd.Location = New System.Drawing.Point(125, 85)
        Me.cmb_AfterEnd.Name = "cmb_AfterEnd"
        Me.cmb_AfterEnd.Size = New System.Drawing.Size(272, 21)
        Me.cmb_AfterEnd.TabIndex = 5
        Me.cmb_AfterEnd.Text = "UltraComboEditor1"
        '
        'UltraLabel11
        '
        Appearance27.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance27
        Me.UltraLabel11.Location = New System.Drawing.Point(47, 85)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel11.TabIndex = 4
        Me.UltraLabel11.Text = "Requirement"
        '
        'txt_MarginDays
        '
        Me.txt_MarginDays.Location = New System.Drawing.Point(125, 58)
        Me.txt_MarginDays.Name = "txt_MarginDays"
        Me.txt_MarginDays.Size = New System.Drawing.Size(97, 21)
        Me.txt_MarginDays.TabIndex = 3
        Me.txt_MarginDays.Text = "UltraTextEditor8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(55, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Margin Days"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(125, 31)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(97, 21)
        Me.txt_Qty.TabIndex = 1
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(98, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 40)
        Me.Panel1.TabIndex = 2
        '
        'btnSave
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(362, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(450, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance9
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(538, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 83)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(626, 325)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Material"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Qty"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(622, 299)
        '
        'cmb_ConsByPIDURouteID
        '
        Me.cmb_ConsByPIDURouteID.DataMember = "Items"
        Me.cmb_ConsByPIDURouteID.DisplayMember = "SubCatName"
        Me.cmb_ConsByPIDURouteID.Location = New System.Drawing.Point(159, 12)
        Me.cmb_ConsByPIDURouteID.MaxDropDownItems = 15
        Me.cmb_ConsByPIDURouteID.Name = "cmb_ConsByPIDURouteID"
        Me.cmb_ConsByPIDURouteID.ReadOnly = True
        Me.cmb_ConsByPIDURouteID.Size = New System.Drawing.Size(234, 22)
        Me.cmb_ConsByPIDURouteID.TabIndex = 1
        Me.cmb_ConsByPIDURouteID.Text = "UltraCombo1"
        Me.cmb_ConsByPIDURouteID.ValueMember = "SubcatID"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(65, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Consumed By"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ProdByPIDURouteID
        '
        Me.cmb_ProdByPIDURouteID.DataMember = "Items"
        Me.cmb_ProdByPIDURouteID.DisplayMember = "SubCatName"
        Me.cmb_ProdByPIDURouteID.Location = New System.Drawing.Point(159, 40)
        Me.cmb_ProdByPIDURouteID.MaxDropDownItems = 15
        Me.cmb_ProdByPIDURouteID.Name = "cmb_ProdByPIDURouteID"
        Me.cmb_ProdByPIDURouteID.Size = New System.Drawing.Size(234, 22)
        Me.cmb_ProdByPIDURouteID.TabIndex = 3
        Me.cmb_ProdByPIDURouteID.Text = "UltraCombo1"
        Me.cmb_ProdByPIDURouteID.ValueMember = "SubcatID"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(65, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Produced By"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmb_ConsByPIDURouteID)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.cmb_ProdByPIDURouteID)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(626, 83)
        Me.Panel3.TabIndex = 0
        '
        'frmPIDUMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Work Order Material"
        Me.ClientSize = New System.Drawing.Size(626, 448)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmPIDUMat"
        Me.Text = "Work Order Material"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.cmb_AfterEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MarginDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.cmb_ConsByPIDURouteID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdByPIDURouteID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraCombo2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_ConsByPIDURouteID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_ProdByPIDURouteID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmb_ItemUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemId As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CtlItemVMS1 As ctlItemVMS2
    Friend WithEvents txt_MarginDays As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_AfterEnd As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
End Class

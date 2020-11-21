<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSeqSeqProc
    Inherits frmMax
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitForm()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_PlnProcID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_PrevSeqProcID3 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_PrevSeqProcID2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_PrevSeqProcID1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevSEqProcID6 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevSeqProcID5 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrevSeqProcID4 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_PrevSeqProcID1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_PrevSEqProcID6 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_PrevSeqProcID2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_PrevSeqProcID5 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_PrevSeqProcID3 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_PrevSeqProcID4 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_PlnStdSeqProcID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_PlnProcID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.cmb_PrevSeqProcID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevSEqProcID6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevSeqProcID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevSeqProcID5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevSeqProcID3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PrevSeqProcID4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_PlnStdSeqProcID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSeqProcID1)
        Me.UltraTabPageControl3.Controls.Add(Me.Label5)
        Me.UltraTabPageControl3.Controls.Add(Me.Label3)
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSEqProcID6)
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSeqProcID2)
        Me.UltraTabPageControl3.Controls.Add(Me.Label6)
        Me.UltraTabPageControl3.Controls.Add(Me.Label12)
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSeqProcID5)
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSeqProcID3)
        Me.UltraTabPageControl3.Controls.Add(Me.Label7)
        Me.UltraTabPageControl3.Controls.Add(Me.Label13)
        Me.UltraTabPageControl3.Controls.Add(Me.cmb_PrevSeqProcID4)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(513, 336)
        '
        'cmb_PrevSeqProcID1
        '
        Me.cmb_PrevSeqProcID1.DataMember = "Items"
        Me.cmb_PrevSeqProcID1.DisplayMember = "SubCatName"
        Me.cmb_PrevSeqProcID1.Location = New System.Drawing.Point(147, 29)
        Me.cmb_PrevSeqProcID1.MaxDropDownItems = 15
        Me.cmb_PrevSeqProcID1.Name = "cmb_PrevSeqProcID1"
        Me.cmb_PrevSeqProcID1.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSeqProcID1.TabIndex = 1
        Me.cmb_PrevSeqProcID1.Text = "UltraCombo1"
        Me.cmb_PrevSeqProcID1.ValueMember = "SubcatID"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(54, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Previous Proc 6"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(53, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Previous Proc 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevSEqProcID6
        '
        Me.cmb_PrevSEqProcID6.DataMember = "Items"
        Me.cmb_PrevSEqProcID6.DisplayMember = "SubCatName"
        Me.cmb_PrevSEqProcID6.Location = New System.Drawing.Point(149, 221)
        Me.cmb_PrevSEqProcID6.MaxDropDownItems = 15
        Me.cmb_PrevSEqProcID6.Name = "cmb_PrevSEqProcID6"
        Me.cmb_PrevSEqProcID6.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSEqProcID6.TabIndex = 11
        Me.cmb_PrevSEqProcID6.Text = "UltraCombo2"
        Me.cmb_PrevSEqProcID6.ValueMember = "SubcatID"
        '
        'cmb_PrevSeqProcID2
        '
        Me.cmb_PrevSeqProcID2.DataMember = "Items"
        Me.cmb_PrevSeqProcID2.DisplayMember = "SubCatName"
        Me.cmb_PrevSeqProcID2.Location = New System.Drawing.Point(149, 67)
        Me.cmb_PrevSeqProcID2.MaxDropDownItems = 15
        Me.cmb_PrevSeqProcID2.Name = "cmb_PrevSeqProcID2"
        Me.cmb_PrevSeqProcID2.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSeqProcID2.TabIndex = 3
        Me.cmb_PrevSeqProcID2.Text = "UltraCombo1"
        Me.cmb_PrevSeqProcID2.ValueMember = "SubcatID"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(55, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Previous Proc 5"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(55, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Previous Proc 2"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevSeqProcID5
        '
        Me.cmb_PrevSeqProcID5.DataMember = "Items"
        Me.cmb_PrevSeqProcID5.DisplayMember = "SubCatName"
        Me.cmb_PrevSeqProcID5.Location = New System.Drawing.Point(149, 182)
        Me.cmb_PrevSeqProcID5.MaxDropDownItems = 15
        Me.cmb_PrevSeqProcID5.Name = "cmb_PrevSeqProcID5"
        Me.cmb_PrevSeqProcID5.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSeqProcID5.TabIndex = 9
        Me.cmb_PrevSeqProcID5.Text = "UltraCombo1"
        Me.cmb_PrevSeqProcID5.ValueMember = "SubcatID"
        '
        'cmb_PrevSeqProcID3
        '
        Me.cmb_PrevSeqProcID3.DataMember = "Items"
        Me.cmb_PrevSeqProcID3.DisplayMember = "SubCatName"
        Me.cmb_PrevSeqProcID3.Location = New System.Drawing.Point(149, 106)
        Me.cmb_PrevSeqProcID3.MaxDropDownItems = 15
        Me.cmb_PrevSeqProcID3.Name = "cmb_PrevSeqProcID3"
        Me.cmb_PrevSeqProcID3.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSeqProcID3.TabIndex = 5
        Me.cmb_PrevSeqProcID3.Text = "UltraCombo2"
        Me.cmb_PrevSeqProcID3.ValueMember = "SubcatID"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(54, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Previous Proc 4"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(54, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Previous Proc 3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PrevSeqProcID4
        '
        Me.cmb_PrevSeqProcID4.DataMember = "Items"
        Me.cmb_PrevSeqProcID4.DisplayMember = "SubCatName"
        Me.cmb_PrevSeqProcID4.Location = New System.Drawing.Point(149, 144)
        Me.cmb_PrevSeqProcID4.MaxDropDownItems = 15
        Me.cmb_PrevSeqProcID4.Name = "cmb_PrevSeqProcID4"
        Me.cmb_PrevSeqProcID4.Size = New System.Drawing.Size(234, 22)
        Me.cmb_PrevSeqProcID4.TabIndex = 7
        Me.cmb_PrevSeqProcID4.Text = "UltraCombo1"
        Me.cmb_PrevSeqProcID4.ValueMember = "SubcatID"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 453)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(517, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance9
        Me.btnSave.Location = New System.Drawing.Point(229, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance10
        Me.btnCancel.Location = New System.Drawing.Point(325, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance11
        Me.btnOK.Location = New System.Drawing.Point(421, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmb_PlnStdSeqProcID)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmb_PlnProcID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 91)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sequence Process"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PlnStdSeqProcID
        '
        Me.cmb_PlnStdSeqProcID.DataMember = "Proc"
        Me.cmb_PlnStdSeqProcID.DisplayMember = "SeqProcName"
        Me.cmb_PlnStdSeqProcID.Location = New System.Drawing.Point(117, 14)
        Me.cmb_PlnStdSeqProcID.MaxDropDownItems = 15
        Me.cmb_PlnStdSeqProcID.Name = "cmb_PlnStdSeqProcID"
        Me.cmb_PlnStdSeqProcID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_PlnStdSeqProcID.TabIndex = 1
        Me.cmb_PlnStdSeqProcID.Text = "UltraCombo1"
        Me.cmb_PlnStdSeqProcID.ValueMember = "PlnStdSeqProcID"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(31, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Plan Process"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PlnProcID
        '
        Me.cmb_PlnProcID.DataMember = "Proc"
        Me.cmb_PlnProcID.DisplayMember = "ProcName"
        Me.cmb_PlnProcID.Location = New System.Drawing.Point(117, 42)
        Me.cmb_PlnProcID.MaxDropDownItems = 15
        Me.cmb_PlnProcID.Name = "cmb_PlnProcID"
        Me.cmb_PlnProcID.ReadOnly = True
        Me.cmb_PlnProcID.Size = New System.Drawing.Size(232, 22)
        Me.cmb_PlnProcID.TabIndex = 3
        Me.cmb_PlnProcID.Text = "UltraCombo1"
        Me.cmb_PlnProcID.ValueMember = "PlnStdSeqProcID"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 91)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(517, 362)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Sequence"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(513, 336)
        '
        'frmSeqSeqProc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Add Process to Sequence"
        Me.ClientSize = New System.Drawing.Size(517, 501)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSeqSeqProc"
        Me.Text = "Add Process to Sequence"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.cmb_PrevSeqProcID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevSEqProcID6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevSeqProcID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevSeqProcID5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevSeqProcID3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PrevSeqProcID4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_PlnStdSeqProcID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_PlnStdSeqProcID As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class


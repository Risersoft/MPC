<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmSeqProc
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_SeqProcName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_PlnProcID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridMatCons As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnDelMatHead1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelMatHead1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_InCycleDays As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridMatProd = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelMatHead2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelMatHead2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridMatCons = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDelMatHead1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelMatHead1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_InCycleDays = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_PlnProcID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_SeqProcName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.txt_ShortName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGridMatProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridMatCons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_InCycleDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.txt_ShortName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGridMatProd)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(603, 345)
        '
        'UltraGridMatProd
        '
        Me.UltraGridMatProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridMatProd.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridMatProd.Name = "UltraGridMatProd"
        Me.UltraGridMatProd.Size = New System.Drawing.Size(603, 297)
        Me.UltraGridMatProd.TabIndex = 0
        Me.UltraGridMatProd.Text = "TF Serials"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelMatHead2)
        Me.Panel2.Controls.Add(Me.btnSelMatHead2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 48)
        Me.Panel2.TabIndex = 1
        '
        'btnDelMatHead2
        '
        Me.btnDelMatHead2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelMatHead2.Location = New System.Drawing.Point(519, 16)
        Me.btnDelMatHead2.Name = "btnDelMatHead2"
        Me.btnDelMatHead2.Size = New System.Drawing.Size(70, 24)
        Me.btnDelMatHead2.TabIndex = 1
        Me.btnDelMatHead2.Text = "&Delete"
        '
        'btnSelMatHead2
        '
        Me.btnSelMatHead2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelMatHead2.Location = New System.Drawing.Point(391, 16)
        Me.btnSelMatHead2.Name = "btnSelMatHead2"
        Me.btnSelMatHead2.Size = New System.Drawing.Size(120, 24)
        Me.btnSelMatHead2.TabIndex = 0
        Me.btnSelMatHead2.Text = "Select"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridMatCons)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(603, 345)
        '
        'UltraGridMatCons
        '
        Me.UltraGridMatCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridMatCons.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridMatCons.Name = "UltraGridMatCons"
        Me.UltraGridMatCons.Size = New System.Drawing.Size(603, 297)
        Me.UltraGridMatCons.TabIndex = 0
        Me.UltraGridMatCons.Text = "TF Serials"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnDelMatHead1)
        Me.Panel9.Controls.Add(Me.btnSelMatHead1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 297)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(603, 48)
        Me.Panel9.TabIndex = 1
        '
        'btnDelMatHead1
        '
        Me.btnDelMatHead1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelMatHead1.Location = New System.Drawing.Point(519, 16)
        Me.btnDelMatHead1.Name = "btnDelMatHead1"
        Me.btnDelMatHead1.Size = New System.Drawing.Size(70, 24)
        Me.btnDelMatHead1.TabIndex = 1
        Me.btnDelMatHead1.Text = "&Delete"
        '
        'btnSelMatHead1
        '
        Me.btnSelMatHead1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelMatHead1.Location = New System.Drawing.Point(391, 16)
        Me.btnSelMatHead1.Name = "btnSelMatHead1"
        Me.btnSelMatHead1.Size = New System.Drawing.Size(120, 24)
        Me.btnSelMatHead1.TabIndex = 0
        Me.btnSelMatHead1.Text = "Select"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(603, 345)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(603, 345)
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Appearance1.FontData.SizeInPoints = 8.5!
        Me.txt_Remark.Appearance = Appearance1
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remark.Location = New System.Drawing.Point(117, 98)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(475, 32)
        Me.txt_Remark.TabIndex = 6
        Me.txt_Remark.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Remark"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 540)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(607, 45)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(343, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 45)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(431, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(519, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 45)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_ShortName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chk_InCycleDays)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmb_PlnProcID)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_SeqProcName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 169)
        Me.Panel1.TabIndex = 0
        '
        'chk_InCycleDays
        '
        Me.chk_InCycleDays.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_InCycleDays.Location = New System.Drawing.Point(117, 70)
        Me.chk_InCycleDays.Name = "chk_InCycleDays"
        Me.chk_InCycleDays.Size = New System.Drawing.Size(204, 22)
        Me.chk_InCycleDays.TabIndex = 4
        Me.chk_InCycleDays.Text = "Consider for cycle days calculation"
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
        Me.cmb_PlnProcID.DataMember = "Items"
        Me.cmb_PlnProcID.DisplayMember = "SubCatName"
        Me.cmb_PlnProcID.Location = New System.Drawing.Point(117, 42)
        Me.cmb_PlnProcID.MaxDropDownItems = 15
        Me.cmb_PlnProcID.Name = "cmb_PlnProcID"
        Me.cmb_PlnProcID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_PlnProcID.TabIndex = 3
        Me.cmb_PlnProcID.Text = "UltraCombo1"
        Me.cmb_PlnProcID.ValueMember = "SubcatID"
        '
        'txt_SeqProcName
        '
        Appearance6.FontData.SizeInPoints = 8.5!
        Me.txt_SeqProcName.Appearance = Appearance6
        Me.txt_SeqProcName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeqProcName.Location = New System.Drawing.Point(117, 14)
        Me.txt_SeqProcName.Name = "txt_SeqProcName"
        Me.txt_SeqProcName.Size = New System.Drawing.Size(272, 22)
        Me.txt_SeqProcName.TabIndex = 1
        Me.txt_SeqProcName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sequence Process"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 169)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(607, 371)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Material Produced"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Material Consumed"
        UltraTab1.Key = "paramtrans"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Parameter Translations"
        UltraTab5.Key = "paramfld"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Formula Fields"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab2, UltraTab1, UltraTab5})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(603, 345)
        '
        'txt_ShortName
        '
        Appearance5.FontData.SizeInPoints = 8.5!
        Me.txt_ShortName.Appearance = Appearance5
        Me.txt_ShortName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ShortName.Location = New System.Drawing.Point(117, 139)
        Me.txt_ShortName.Name = "txt_ShortName"
        Me.txt_ShortName.Size = New System.Drawing.Size(272, 22)
        Me.txt_ShortName.TabIndex = 8
        Me.txt_ShortName.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Short Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSeqProc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Sequence Process"
        Me.ClientSize = New System.Drawing.Size(607, 585)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSeqProc"
        Me.Text = "Sequence Process"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGridMatProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridMatCons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chk_InCycleDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SeqProcName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.txt_ShortName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridMatProd As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelMatHead2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelMatHead2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_ShortName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As Label

#End Region
End Class


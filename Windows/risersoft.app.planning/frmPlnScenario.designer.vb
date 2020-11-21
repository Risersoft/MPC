Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPlnScenario
    Inherits frmMax2

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.initForm()

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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_SceneNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_inprod As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPublish = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_MRPRunDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnRunMRP = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_APSRunDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnImport = New Infragistics.Win.Misc.UltraButton()
        Me.btnExport = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SceneName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_SceneNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbl_inprod = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.btnRun = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dt_MRPRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dt_APSRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_SceneName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SceneNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(778, 399)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraGrid1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 399)
        Me.Panel3.TabIndex = 8
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(778, 357)
        Me.UltraGrid1.TabIndex = 6
        Me.UltraGrid1.Text = "Lots"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnPublish)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 357)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(778, 42)
        Me.Panel5.TabIndex = 7
        '
        'btnPublish
        '
        Me.btnPublish.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPublish.Location = New System.Drawing.Point(702, 0)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(76, 42)
        Me.btnPublish.TabIndex = 5
        Me.btnPublish.Text = "Publish"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(778, 399)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(778, 357)
        Me.UltraGrid2.TabIndex = 9
        Me.UltraGrid2.Text = "Lots"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.dt_MRPRunDate)
        Me.Panel6.Controls.Add(Me.btnRunMRP)
        Me.Panel6.Controls.Add(Me.UltraButton2)
        Me.Panel6.Controls.Add(Me.UltraButton3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 357)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(778, 42)
        Me.Panel6.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Last MRP Run"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_MRPRunDate
        '
        Me.dt_MRPRunDate.DateTime = New Date(2015, 5, 8, 0, 0, 0, 0)
        Me.dt_MRPRunDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_MRPRunDate.Location = New System.Drawing.Point(127, 6)
        Me.dt_MRPRunDate.Name = "dt_MRPRunDate"
        Me.dt_MRPRunDate.NullText = "Not Defined"
        Me.dt_MRPRunDate.ReadOnly = True
        Me.dt_MRPRunDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_MRPRunDate.TabIndex = 47
        Me.dt_MRPRunDate.Value = New Date(2015, 5, 8, 0, 0, 0, 0)
        '
        'btnRunMRP
        '
        Me.btnRunMRP.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRunMRP.Location = New System.Drawing.Point(550, 0)
        Me.btnRunMRP.Name = "btnRunMRP"
        Me.btnRunMRP.Size = New System.Drawing.Size(76, 42)
        Me.btnRunMRP.TabIndex = 5
        Me.btnRunMRP.Text = "Run MRP"
        '
        'UltraButton2
        '
        Me.UltraButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraButton2.Location = New System.Drawing.Point(626, 0)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(76, 42)
        Me.UltraButton2.TabIndex = 4
        Me.UltraButton2.Text = "Process Plan Orders"
        '
        'UltraButton3
        '
        Me.UltraButton3.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraButton3.Location = New System.Drawing.Point(702, 0)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(76, 42)
        Me.UltraButton3.TabIndex = 2
        Me.UltraButton3.Text = "Generate Plan Orders"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.RichTextBox1)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(778, 399)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(778, 357)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnRun)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.dt_APSRunDate)
        Me.Panel7.Controls.Add(Me.btnImport)
        Me.Panel7.Controls.Add(Me.btnExport)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 357)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(778, 42)
        Me.Panel7.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Last APS Run"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_APSRunDate
        '
        Me.dt_APSRunDate.DateTime = New Date(2015, 5, 8, 0, 0, 0, 0)
        Me.dt_APSRunDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_APSRunDate.Location = New System.Drawing.Point(127, 10)
        Me.dt_APSRunDate.Name = "dt_APSRunDate"
        Me.dt_APSRunDate.NullText = "Not Defined"
        Me.dt_APSRunDate.ReadOnly = True
        Me.dt_APSRunDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_APSRunDate.TabIndex = 49
        Me.dt_APSRunDate.Value = New Date(2015, 5, 8, 0, 0, 0, 0)
        '
        'btnImport
        '
        Me.btnImport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnImport.Location = New System.Drawing.Point(626, 0)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(76, 42)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.Location = New System.Drawing.Point(702, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(76, 42)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 505)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 80)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(782, 425)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lots"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Material"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "AutoSchedule"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(778, 399)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_SceneName)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.txt_SceneNum)
        Me.Panel1.Controls.Add(Me.lbl_inprod)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 80)
        Me.Panel1.TabIndex = 0
        '
        'txt_SceneName
        '
        Me.txt_SceneName.Location = New System.Drawing.Point(128, 43)
        Me.txt_SceneName.Name = "txt_SceneName"
        Me.txt_SceneName.ReadOnly = True
        Me.txt_SceneName.Size = New System.Drawing.Size(296, 21)
        Me.txt_SceneName.TabIndex = 11
        '
        'UltraLabel1
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(18, 47)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 17)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Scenario Name"
        '
        'txt_SceneNum
        '
        Me.txt_SceneNum.Location = New System.Drawing.Point(128, 16)
        Me.txt_SceneNum.Name = "txt_SceneNum"
        Me.txt_SceneNum.ReadOnly = True
        Me.txt_SceneNum.Size = New System.Drawing.Size(296, 21)
        Me.txt_SceneNum.TabIndex = 9
        '
        'lbl_inprod
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.lbl_inprod.Appearance = Appearance5
        Me.lbl_inprod.Location = New System.Drawing.Point(18, 20)
        Me.lbl_inprod.Name = "lbl_inprod"
        Me.lbl_inprod.Size = New System.Drawing.Size(104, 17)
        Me.lbl_inprod.TabIndex = 10
        Me.lbl_inprod.Text = "Scenario Num"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(518, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 48)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(606, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(694, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 48)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRun.Location = New System.Drawing.Point(550, 0)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(76, 42)
        Me.btnRun.TabIndex = 51
        Me.btnRun.Text = "Run"
        '
        'frmPlnScenario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Scenario"
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPlnScenario"
        Me.Text = "Scenario"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dt_MRPRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dt_APSRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_SceneName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SceneNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_SceneName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnPublish As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnImport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnExport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnRunMRP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_MRPRunDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_APSRunDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnRun As Infragistics.Win.Misc.UltraButton

#End Region
End Class


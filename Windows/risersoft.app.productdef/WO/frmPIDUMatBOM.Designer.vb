<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDUMatBOM
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridBOM = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btn_EditBom = New Infragistics.Win.Misc.UltraButton()
        Me.btn_DelBom = New Infragistics.Win.Misc.UltraButton()
        Me.btn_AddConsBom = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddProd = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridAltBOM1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelAlt = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddAlt = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridItemBOM = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridAltBOM2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelAlt2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddAlt2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.UltraTree2 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.btn_reLoad = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGridAltBOM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridItemBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGridAltBOM2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        CType(Me.UltraTree2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridBOM)
        Me.UltraTabPageControl2.Controls.Add(Me.PanelButtons)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(397, 257)
        '
        'UltraGridBOM
        '
        Me.UltraGridBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBOM.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBOM.Name = "UltraGridBOM"
        Me.UltraGridBOM.Size = New System.Drawing.Size(397, 227)
        Me.UltraGridBOM.TabIndex = 0
        Me.UltraGridBOM.Text = "UltraGrid1"
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.btn_EditBom)
        Me.PanelButtons.Controls.Add(Me.btn_DelBom)
        Me.PanelButtons.Controls.Add(Me.btn_AddConsBom)
        Me.PanelButtons.Controls.Add(Me.btnAddProd)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtons.Location = New System.Drawing.Point(0, 227)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(397, 30)
        Me.PanelButtons.TabIndex = 1
        '
        'btn_EditBom
        '
        Me.btn_EditBom.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_EditBom.Location = New System.Drawing.Point(47, 0)
        Me.btn_EditBom.Name = "btn_EditBom"
        Me.btn_EditBom.Size = New System.Drawing.Size(78, 30)
        Me.btn_EditBom.TabIndex = 0
        Me.btn_EditBom.Text = "Edit"
        '
        'btn_DelBom
        '
        Me.btn_DelBom.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_DelBom.Location = New System.Drawing.Point(125, 0)
        Me.btn_DelBom.Name = "btn_DelBom"
        Me.btn_DelBom.Size = New System.Drawing.Size(78, 30)
        Me.btn_DelBom.TabIndex = 1
        Me.btn_DelBom.Text = "Delete"
        '
        'btn_AddConsBom
        '
        Me.btn_AddConsBom.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_AddConsBom.Location = New System.Drawing.Point(203, 0)
        Me.btn_AddConsBom.Name = "btn_AddConsBom"
        Me.btn_AddConsBom.Size = New System.Drawing.Size(97, 30)
        Me.btn_AddConsBom.TabIndex = 2
        Me.btn_AddConsBom.Text = "Add Consumed"
        '
        'btnAddProd
        '
        Me.btnAddProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddProd.Location = New System.Drawing.Point(300, 0)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(97, 30)
        Me.btnAddProd.TabIndex = 3
        Me.btnAddProd.Text = "Add Produced"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGridAltBOM1)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(397, 257)
        '
        'UltraGridAltBOM1
        '
        Me.UltraGridAltBOM1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridAltBOM1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridAltBOM1.Name = "UltraGridAltBOM1"
        Me.UltraGridAltBOM1.Size = New System.Drawing.Size(397, 221)
        Me.UltraGridAltBOM1.TabIndex = 0
        Me.UltraGridAltBOM1.Text = "UltraGrid2"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelAlt)
        Me.Panel1.Controls.Add(Me.btnAddAlt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 36)
        Me.Panel1.TabIndex = 1
        '
        'btnDelAlt
        '
        Me.btnDelAlt.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelAlt.Location = New System.Drawing.Point(241, 0)
        Me.btnDelAlt.Name = "btnDelAlt"
        Me.btnDelAlt.Size = New System.Drawing.Size(78, 36)
        Me.btnDelAlt.TabIndex = 0
        Me.btnDelAlt.Text = "Delete"
        '
        'btnAddAlt
        '
        Me.btnAddAlt.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddAlt.Location = New System.Drawing.Point(319, 0)
        Me.btnAddAlt.Name = "btnAddAlt"
        Me.btnAddAlt.Size = New System.Drawing.Size(78, 36)
        Me.btnAddAlt.TabIndex = 1
        Me.btnAddAlt.Text = "Add"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridItemBOM)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(397, 257)
        '
        'UltraGridItemBOM
        '
        Me.UltraGridItemBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridItemBOM.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridItemBOM.Name = "UltraGridItemBOM"
        Me.UltraGridItemBOM.Size = New System.Drawing.Size(397, 257)
        Me.UltraGridItemBOM.TabIndex = 0
        Me.UltraGridItemBOM.Text = "UltraGrid3"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGridAltBOM2)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(397, 257)
        '
        'UltraGridAltBOM2
        '
        Me.UltraGridAltBOM2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridAltBOM2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridAltBOM2.Name = "UltraGridAltBOM2"
        Me.UltraGridAltBOM2.Size = New System.Drawing.Size(397, 221)
        Me.UltraGridAltBOM2.TabIndex = 0
        Me.UltraGridAltBOM2.Text = "UltraGrid4"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelAlt2)
        Me.Panel5.Controls.Add(Me.btnAddAlt2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 221)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(397, 36)
        Me.Panel5.TabIndex = 1
        '
        'btnDelAlt2
        '
        Me.btnDelAlt2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelAlt2.Location = New System.Drawing.Point(241, 0)
        Me.btnDelAlt2.Name = "btnDelAlt2"
        Me.btnDelAlt2.Size = New System.Drawing.Size(78, 36)
        Me.btnDelAlt2.TabIndex = 0
        Me.btnDelAlt2.Text = "Delete"
        '
        'btnAddAlt2
        '
        Me.btnAddAlt2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddAlt2.Location = New System.Drawing.Point(319, 0)
        Me.btnAddAlt2.Name = "btnAddAlt2"
        Me.btnAddAlt2.Size = New System.Drawing.Size(78, 36)
        Me.btnAddAlt2.TabIndex = 1
        Me.btnAddAlt2.Text = "Add"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.Splitter1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTree1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(864, 323)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(463, 40)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(401, 283)
        Me.UltraTabControl2.TabIndex = 2
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "BOM"
        UltraTab6.TabPage = Me.UltraTabPageControl3
        UltraTab6.Text = "Alternates"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(397, 257)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel1.Location = New System.Drawing.Point(463, 0)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Padding = New System.Drawing.Size(0, 10)
        Me.UltraLabel1.Size = New System.Drawing.Size(401, 40)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Finished Transformer > "
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(455, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 323)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'UltraTree1
        '
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraTree1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.Size = New System.Drawing.Size(455, 323)
        Me.UltraTree1.TabIndex = 0
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl4.Controls.Add(Me.Splitter2)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTree2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(864, 323)
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(463, 40)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(401, 283)
        Me.UltraTabControl3.TabIndex = 3
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "BOM"
        UltraTab4.TabPage = Me.UltraTabPageControl6
        UltraTab4.Text = "Alternates"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(397, 257)
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel2.Location = New System.Drawing.Point(463, 0)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Padding = New System.Drawing.Size(0, 10)
        Me.UltraLabel2.Size = New System.Drawing.Size(401, 40)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Finished Transformer > "
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(455, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(8, 323)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'UltraTree2
        '
        Me.UltraTree2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraTree2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree2.Name = "UltraTree2"
        Me.UltraTree2.Size = New System.Drawing.Size(455, 323)
        Me.UltraTree2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Controls.Add(Me.btn_reLoad)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 345)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(864, 48)
        Me.Panel4.TabIndex = 18
        '
        'btnSave
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(600, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 48)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(688, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance9
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(776, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 48)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&OK"
        '
        'btn_reLoad
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btn_reLoad.Appearance = Appearance3
        Me.btn_reLoad.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_reLoad.Location = New System.Drawing.Point(0, 0)
        Me.btn_reLoad.Name = "btn_reLoad"
        Me.btn_reLoad.Size = New System.Drawing.Size(88, 48)
        Me.btn_reLoad.TabIndex = 0
        Me.btn_reLoad.Text = "Reload Tree"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(864, 345)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.Key = "procbom"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Process BOM"
        UltraTab2.Key = "matbom"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Material Tree"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(864, 323)
        '
        'frmPIDUMatBOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Material Position"
        Me.ClientSize = New System.Drawing.Size(864, 393)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPIDUMatBOM"
        Me.Text = "Material Position"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGridAltBOM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridItemBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGridAltBOM2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        CType(Me.UltraTree2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents btn_reLoad As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridBOM As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridAltBOM1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridItemBOM As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridAltBOM2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents UltraTree2 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents PanelButtons As System.Windows.Forms.Panel
    Friend WithEvents btn_EditBom As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_DelBom As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_AddConsBom As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelAlt As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddAlt As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDelAlt2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddAlt2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddProd As Infragistics.Win.Misc.UltraButton

#End Region
End Class


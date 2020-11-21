<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdProgress
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelAll = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelProd = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddEmp = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_CumuProdOther = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Prod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbl_inprod = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CumuProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGroupNum = New System.Windows.Forms.Label()
        Me.txt_GroupNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ProdUnitName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_IncenProdTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_BasicProd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_TypeDescrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_TypeNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblprod = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_CumuProdOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CumuProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_GroupNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IncenProdTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BasicProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TypeDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TypeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(446, 381)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 66)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(446, 279)
        Me.UltraGrid1.TabIndex = 1
        Me.UltraGrid1.Text = "Report"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelAll)
        Me.Panel3.Controls.Add(Me.btnDelProd)
        Me.Panel3.Controls.Add(Me.btnAddEmp)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 36)
        Me.Panel3.TabIndex = 0
        '
        'btnDelAll
        '
        Me.btnDelAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelAll.Location = New System.Drawing.Point(234, 0)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(70, 36)
        Me.btnDelAll.TabIndex = 2
        Me.btnDelAll.Text = "&DeleteAll"
        '
        'btnDelProd
        '
        Me.btnDelProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelProd.Location = New System.Drawing.Point(304, 0)
        Me.btnDelProd.Name = "btnDelProd"
        Me.btnDelProd.Size = New System.Drawing.Size(70, 36)
        Me.btnDelProd.TabIndex = 0
        Me.btnDelProd.Text = "&Delete"
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddEmp.Location = New System.Drawing.Point(374, 0)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(72, 36)
        Me.btnAddEmp.TabIndex = 1
        Me.btnAddEmp.Text = "&Add New"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_CumuProdOther)
        Me.Panel1.Controls.Add(Me.txt_Prod)
        Me.Panel1.Controls.Add(Me.lbl_inprod)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.txt_CumuProd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 66)
        Me.Panel1.TabIndex = 0
        '
        'txt_CumuProdOther
        '
        Me.txt_CumuProdOther.Location = New System.Drawing.Point(248, 36)
        Me.txt_CumuProdOther.Name = "txt_CumuProdOther"
        Me.txt_CumuProdOther.ReadOnly = True
        Me.txt_CumuProdOther.Size = New System.Drawing.Size(36, 21)
        Me.txt_CumuProdOther.TabIndex = 4
        Me.txt_CumuProdOther.Visible = False
        '
        'txt_Prod
        '
        Me.txt_Prod.Location = New System.Drawing.Point(138, 9)
        Me.txt_Prod.Name = "txt_Prod"
        Me.txt_Prod.Size = New System.Drawing.Size(104, 21)
        Me.txt_Prod.TabIndex = 1
        '
        'lbl_inprod
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.lbl_inprod.Appearance = Appearance1
        Me.lbl_inprod.AutoSize = True
        Me.lbl_inprod.Location = New System.Drawing.Point(72, 9)
        Me.lbl_inprod.Name = "lbl_inprod"
        Me.lbl_inprod.Size = New System.Drawing.Size(58, 14)
        Me.lbl_inprod.TabIndex = 0
        Me.lbl_inprod.Text = "Production"
        '
        'UltraLabel5
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance2
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(72, 40)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Total Done"
        '
        'txt_CumuProd
        '
        Me.txt_CumuProd.Location = New System.Drawing.Point(138, 36)
        Me.txt_CumuProd.Name = "txt_CumuProd"
        Me.txt_CumuProd.ReadOnly = True
        Me.txt_CumuProd.Size = New System.Drawing.Size(104, 21)
        Me.txt_CumuProd.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblGroupNum)
        Me.Panel2.Controls.Add(Me.txt_GroupNum)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_ProdUnitName)
        Me.Panel2.Controls.Add(Me.txt_IncenProdTot)
        Me.Panel2.Controls.Add(Me.txt_BasicProd)
        Me.Panel2.Controls.Add(Me.txt_TypeDescrip)
        Me.Panel2.Controls.Add(Me.txt_TypeNum)
        Me.Panel2.Controls.Add(Me.UltraLabel4)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.lblprod)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 164)
        Me.Panel2.TabIndex = 0
        '
        'lblGroupNum
        '
        Me.lblGroupNum.AutoSize = True
        Me.lblGroupNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroupNum.Location = New System.Drawing.Point(75, 124)
        Me.lblGroupNum.Name = "lblGroupNum"
        Me.lblGroupNum.Size = New System.Drawing.Size(56, 14)
        Me.lblGroupNum.TabIndex = 10
        Me.lblGroupNum.Text = "Group No."
        Me.lblGroupNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_GroupNum
        '
        Me.txt_GroupNum.Location = New System.Drawing.Point(139, 121)
        Me.txt_GroupNum.Name = "txt_GroupNum"
        Me.txt_GroupNum.Size = New System.Drawing.Size(104, 21)
        Me.txt_GroupNum.TabIndex = 11
        Me.txt_GroupNum.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(268, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unit Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProdUnitName
        '
        Me.txt_ProdUnitName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ProdUnitName.Location = New System.Drawing.Point(329, 67)
        Me.txt_ProdUnitName.Name = "txt_ProdUnitName"
        Me.txt_ProdUnitName.ReadOnly = True
        Me.txt_ProdUnitName.Size = New System.Drawing.Size(93, 21)
        Me.txt_ProdUnitName.TabIndex = 7
        '
        'txt_IncenProdTot
        '
        Me.txt_IncenProdTot.Location = New System.Drawing.Point(139, 94)
        Me.txt_IncenProdTot.Name = "txt_IncenProdTot"
        Me.txt_IncenProdTot.ReadOnly = True
        Me.txt_IncenProdTot.Size = New System.Drawing.Size(104, 21)
        Me.txt_IncenProdTot.TabIndex = 9
        '
        'txt_BasicProd
        '
        Me.txt_BasicProd.Location = New System.Drawing.Point(139, 67)
        Me.txt_BasicProd.Name = "txt_BasicProd"
        Me.txt_BasicProd.ReadOnly = True
        Me.txt_BasicProd.Size = New System.Drawing.Size(104, 21)
        Me.txt_BasicProd.TabIndex = 5
        '
        'txt_TypeDescrip
        '
        Me.txt_TypeDescrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TypeDescrip.Location = New System.Drawing.Point(139, 39)
        Me.txt_TypeDescrip.Name = "txt_TypeDescrip"
        Me.txt_TypeDescrip.ReadOnly = True
        Me.txt_TypeDescrip.Size = New System.Drawing.Size(283, 21)
        Me.txt_TypeDescrip.TabIndex = 3
        '
        'txt_TypeNum
        '
        Me.txt_TypeNum.Location = New System.Drawing.Point(139, 12)
        Me.txt_TypeNum.Name = "txt_TypeNum"
        Me.txt_TypeNum.ReadOnly = True
        Me.txt_TypeNum.Size = New System.Drawing.Size(104, 21)
        Me.txt_TypeNum.TabIndex = 1
        '
        'UltraLabel4
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(36, 97)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(97, 14)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "Total Requirement"
        '
        'UltraLabel3
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(44, 42)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(89, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Type Description"
        '
        'UltraLabel2
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(60, 14)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Type Number"
        '
        'lblprod
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.lblprod.Appearance = Appearance6
        Me.lblprod.AutoSize = True
        Me.lblprod.Location = New System.Drawing.Point(44, 69)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(89, 14)
        Me.lblprod.TabIndex = 4
        Me.lblprod.Text = "Basic Production"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 164)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(446, 381)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl1.TabIndex = 155
        UltraTab5.Key = "prod"
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Work"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(446, 381)
        '
        'frmProdProgress
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Incentive"
        Me.ClientSize = New System.Drawing.Size(446, 545)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmProdProgress"
        Me.Text = "Incentive"
        Me.TopMost = True
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_CumuProdOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CumuProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_GroupNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdUnitName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IncenProdTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BasicProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TypeDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TypeNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblprod As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IncenProdTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_BasicProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_TypeDescrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_TypeNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ProdUnitName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_CumuProdOther As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Prod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_inprod As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CumuProd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelProd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddEmp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblGroupNum As System.Windows.Forms.Label
    Friend WithEvents txt_GroupNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnDelAll As Infragistics.Win.Misc.UltraButton

#End Region
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdContriEmpGrp
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelProd = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddProd = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelNC = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddNC = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_ProdIncType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_shiftID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblGroupNum = New System.Windows.Forms.Label()
        Me.txt_GroupNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_PlnProcID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_shiftID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GroupNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(442, 299)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(442, 263)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Report"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelProd)
        Me.Panel3.Controls.Add(Me.btnAddProd)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 263)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(442, 36)
        Me.Panel3.TabIndex = 0
        '
        'btnDelProd
        '
        Me.btnDelProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelProd.Location = New System.Drawing.Point(300, 0)
        Me.btnDelProd.Name = "btnDelProd"
        Me.btnDelProd.Size = New System.Drawing.Size(70, 36)
        Me.btnDelProd.TabIndex = 0
        Me.btnDelProd.Text = "&Delete"
        '
        'btnAddProd
        '
        Me.btnAddProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddProd.Location = New System.Drawing.Point(370, 0)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(72, 36)
        Me.btnAddProd.TabIndex = 1
        Me.btnAddProd.Text = "&Add New"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(442, 299)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(442, 263)
        Me.UltraGrid2.TabIndex = 0
        Me.UltraGrid2.Text = "Report"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelNC)
        Me.Panel5.Controls.Add(Me.btnAddNC)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 263)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(442, 36)
        Me.Panel5.TabIndex = 1
        '
        'btnDelNC
        '
        Me.btnDelNC.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelNC.Location = New System.Drawing.Point(300, 0)
        Me.btnDelNC.Name = "btnDelNC"
        Me.btnDelNC.Size = New System.Drawing.Size(70, 36)
        Me.btnDelNC.TabIndex = 0
        Me.btnDelNC.Text = "&Delete"
        '
        'btnAddNC
        '
        Me.btnAddNC.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddNC.Location = New System.Drawing.Point(370, 0)
        Me.btnAddNC.Name = "btnAddNC"
        Me.btnAddNC.Size = New System.Drawing.Size(72, 36)
        Me.btnAddNC.TabIndex = 1
        Me.btnAddNC.Text = "&Add New"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_ProdIncType)
        Me.Panel2.Controls.Add(Me.UltraLabel4)
        Me.Panel2.Controls.Add(Me.cmb_shiftID)
        Me.Panel2.Controls.Add(Me.lblGroupNum)
        Me.Panel2.Controls.Add(Me.txt_GroupNum)
        Me.Panel2.Controls.Add(Me.cmb_PlnProcID)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.cmb_matdepid)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.dt_dated)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 181)
        Me.Panel2.TabIndex = 0
        '
        'cmb_ProdIncType
        '
        Me.cmb_ProdIncType.Location = New System.Drawing.Point(127, 149)
        Me.cmb_ProdIncType.Name = "cmb_ProdIncType"
        Me.cmb_ProdIncType.ReadOnly = True
        Me.cmb_ProdIncType.Size = New System.Drawing.Size(200, 22)
        Me.cmb_ProdIncType.TabIndex = 11
        '
        'UltraLabel4
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.Location = New System.Drawing.Point(33, 152)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel4.TabIndex = 10
        Me.UltraLabel4.Text = "Incentive Type"
        '
        'cmb_shiftID
        '
        Me.cmb_shiftID.Location = New System.Drawing.Point(127, 95)
        Me.cmb_shiftID.Name = "cmb_shiftID"
        Me.cmb_shiftID.ReadOnly = True
        Me.cmb_shiftID.Size = New System.Drawing.Size(164, 22)
        Me.cmb_shiftID.TabIndex = 7
        '
        'lblGroupNum
        '
        Me.lblGroupNum.AutoSize = True
        Me.lblGroupNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblGroupNum.Location = New System.Drawing.Point(63, 126)
        Me.lblGroupNum.Name = "lblGroupNum"
        Me.lblGroupNum.Size = New System.Drawing.Size(56, 14)
        Me.lblGroupNum.TabIndex = 8
        Me.lblGroupNum.Text = "Group No."
        Me.lblGroupNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_GroupNum
        '
        Me.txt_GroupNum.Location = New System.Drawing.Point(127, 122)
        Me.txt_GroupNum.Name = "txt_GroupNum"
        Me.txt_GroupNum.ReadOnly = True
        Me.txt_GroupNum.Size = New System.Drawing.Size(164, 21)
        Me.txt_GroupNum.TabIndex = 9
        Me.txt_GroupNum.Text = "UltraTextEditor1"
        '
        'cmb_PlnProcID
        '
        Me.cmb_PlnProcID.Location = New System.Drawing.Point(127, 40)
        Me.cmb_PlnProcID.Name = "cmb_PlnProcID"
        Me.cmb_PlnProcID.ReadOnly = True
        Me.cmb_PlnProcID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_PlnProcID.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance6
        Me.UltraLabel3.Location = New System.Drawing.Point(47, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Process"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(127, 12)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.ReadOnly = True
        Me.cmb_matdepid.Size = New System.Drawing.Size(200, 22)
        Me.cmb_matdepid.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(47, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Department"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(55, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shift"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraLabel1
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.Location = New System.Drawing.Point(79, 71)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 17)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Date"
        '
        'dt_dated
        '
        Me.dt_dated.FormatString = "dddd dd MMM yyyy"
        Me.dt_dated.Location = New System.Drawing.Point(127, 68)
        Me.dt_dated.Name = "dt_dated"
        Me.dt_dated.NullText = "Not Defined"
        Me.dt_dated.ReadOnly = True
        Me.dt_dated.Size = New System.Drawing.Size(200, 21)
        Me.dt_dated.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 506)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(446, 39)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(254, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(318, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 39)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(382, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(64, 39)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 181)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(446, 325)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab5.Key = "prod"
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Production"
        UltraTab6.Key = "nc"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "NC"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(442, 299)
        '
        'frmProdContriEmpGrp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Group Incentive"
        Me.ClientSize = New System.Drawing.Size(446, 545)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmProdContriEmpGrp"
        Me.Text = "Group Incentive"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_ProdIncType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_shiftID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GroupNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PlnProcID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblGroupNum As System.Windows.Forms.Label
    Friend WithEvents txt_GroupNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_PlnProcID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelProd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddProd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDelNC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddNC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_shiftID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ProdIncType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel

#End Region
End Class


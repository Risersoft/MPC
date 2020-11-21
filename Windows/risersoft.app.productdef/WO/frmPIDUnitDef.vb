Imports risersoft.app.mxform
Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxent

Public Class frmPIDUnitDef
    Inherits frmWizMax
    Public fp As frmPIDURouteList, fe As frmPIDUMatListETO, fm As frmMatList1, fb As frmPIDUMatBOM
    Dim objWO As clsWOInfoBase
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        Dim obj As Object, arrDel As New ArrayList, uTab As UltraTab

        Me.SuspendLayout()
        myTables.LoadDataSet(False)
        Me.PanelBtn.Height = Me.PanelBtn.Height * 2 / 3

        fe = New frmPIDUMatListETO
        uTab = fe.AddtoTab(Me.UltraTabControl1, "matlisteto", True)

        fm = New frmMatList1
        uTab = fm.AddtoTab(Me.UltraTabControl1, "matlist", True)

        fp = New frmPIDURouteList
        uTab = fp.AddtoTab(Me.UltraTabControl1, "route", True)

        fb = New frmPIDUMatBOM
        uTab = fb.AddtoTab(Me.UltraTabControl1, "matbom", True)

        Me.InitTabs(Me.UltraTabControl1, "pidunitid", "")
        Me.InitTabKey = "route"
        Me.arrmode.AddRange(New String() {"route"})

        'myXLBasic.QuitExcel()
        Me.ResumeLayout()

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim groupindex As Integer = 0
        Dim cont As Boolean = False
        Me.FormPrepared = False
        Me.strT = "pidu"
        If frmMode = EnumfrmMode.acEditM AndAlso Me.UltraTabControl1.Tabs.Count > 0 Then
            objWO = myPIDU.GenerateWOInfo(Me.Controller, prepIdx)
            If Not objWO.rPIDU Is Nothing Then
                If Me.InitData(objWO.rPIDU, oview, prepIdx) Then
                    Me.Prepmode()
                    Me.FormPrepared = True
                End If
            Else
                MsgBox("Not Found!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        Else
            MsgBox("Cannot Open!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        Return Me.FormPrepared
    End Function

    Protected Overrides Sub OnMakeFTFPanel(vsbl As Boolean)
        Me.Panel1.Visible = vsbl
        If vsbl Then
            Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Default
        Else
            Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        End If

        MyBase.OnMakeFTFPanel(vsbl)
    End Sub
    Public Overrides Function oWO() As clsWOInfoBase
        Return objWO
    End Function
End Class
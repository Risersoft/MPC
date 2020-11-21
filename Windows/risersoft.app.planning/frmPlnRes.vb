Imports System.Windows.Forms
Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform

Public Class frmPlnRes
    Inherits frmMax
    Friend CurrEditRow As DataRow
    Dim PPFinal As Boolean = False, oMasterFICO As New clsMasterDataFICO(Me.Controller)

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGridList)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPlnResModel = Me.InitData("frmPlnResModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            cmb_campusid.Value = myUtils.cValTN(myRow("CampusId"))
            Me.reCalc()
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("PlnRes"))
            myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_campusid)
            myWinSQL.AssignCmb(Me.dsCombo, "ResItemType", "", Me.ComboResItemType)
            Return True
        End If
        Return False
    End Function

    Public Overrides Sub MakeDownLevel()
        Me.PanelSave.Visible = False
        Me.UltraPanel1.Visible = False
        MyBase.MakeDownLevel()
    End Sub

    Protected Friend Sub reCalc()
        'Find UnReserved Stock
        lblUnResStock.Text = Me.GenerateDataOutput("descrip", myRow.Row.Table.DataSet, frmIDX).Description
    End Sub

    Public Overrides Function ValidateData() As Boolean
        Me.InitError()
        If Not CurrEditRow Is Nothing Then


            Dim CompanyID As Integer = Me.Controller.CommonData.GetCompanyIDFromCampus(myUtils.cValTN(myRow("campusid")))
            Dim rPostPeriod As DataRow = oMasterFICO.rPostPeriod(DateTimePicker1.Value)


            If rPostPeriod Is Nothing Then
                WinFormUtils.AddError(Me.cmb_campusid, "Posting Period not available")
            Else
                If (myUtils.cBoolTN(rPostPeriod("IsFinal")) = True OrElse myUtils.cBoolTN(PPFinal) = True) Then WinFormUtils.AddError(DateTimePicker1, "Select Valid Date, Post Period Corresponding to this date is Finalized")
                CurrEditRow("PostPeriodId") = myUtils.cValTN(rPostPeriod("PostPeriodID"))
            End If
            If myUtils.NullNot(Me.ComboResItemType.SelectedRow) Then WinFormUtils.AddError(Me.ComboResItemType, "Please Select Reservation type")
            If myUtils.cValTN(Me.TextBoxQty.Text) = 0 Then WinFormUtils.AddError(Me.TextBoxQty, "Please Enter Qty")
        End If
        Return Me.CanSave

    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAddOp_Click(sender As Object, e As EventArgs) Handles btnAddOp.Click
        CurrEditRow = myView.mainGrid.myDv.Table.NewRow
        fillData()
    End Sub

    Private Sub btnEditLotOp_Click(sender As Object, e As EventArgs) Handles btnEditLotOp.Click
        CurrEditRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        fillData()
    End Sub

    Private Sub btnDelOp_Click(sender As Object, e As EventArgs) Handles btnDelOp.Click
        If Not IsNothing(myView.mainGrid.myGrid.ActiveRow) Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
            If PPStatus(r1) = False Then
                If myUtils.cValTN(r1("MatVouchItemID")) > 0 Then
                    MsgBox("Delete Reserve Item through Material Voucher.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
                Else
                    myView.mainGrid.ButtonAction("Del")
                    CalculateBalance()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        UltraTabControl1.Tabs("List").Selected = True
        CurrEditRow = Nothing
    End Sub

    Protected Friend Function ValidateSubmitData() As Boolean
        Me.InitError()
        If Not IsNothing(CurrEditRow) Then
            If Me.ValidateData Then
                CurrEditRow("Dated") = myUtils.cStrTN(DateTimePicker1.Value)
                CurrEditRow("ResItemType") = myUtils.cStrTN(ComboResItemType.Value)
                CurrEditRow("Qty") = myUtils.cValTN(TextBoxQty.Value)
                If CurrEditRow.RowState = DataRowState.Detached Then myView.mainGrid.myDv.Table.Rows.Add(CurrEditRow)
                CalculateBalance()
            End If
        End If
        Return Me.CanSave
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.ValidateSubmitData() Then
            UltraTabControl1.Tabs("List").Selected = True
            CurrEditRow = Nothing
        End If
    End Sub

    Private Sub fillData()
        If Not IsNothing(CurrEditRow) AndAlso myUtils.cValTN(CurrEditRow("MatVouchItemID")) = 0 Then
            PPStatus(CurrEditRow)

            If myUtils.IsInList(myUtils.cStrTN(CurrEditRow("Dated")), "") Then DateTimePicker1.Value = Now.Date Else DateTimePicker1.Value = myUtils.cStrTN(CurrEditRow("Dated"))
            If myUtils.IsInList(myUtils.cValTN(CurrEditRow("Qty")), 0) Then TextBoxQty.Value = DBNull.Value Else TextBoxQty.Value = myUtils.cValTN(CurrEditRow("Qty"))
            ComboResItemType.Value = myUtils.cStrTN(CurrEditRow("ResItemType"))
            UltraTabControl1.Tabs("Form").Selected = True
        End If
    End Sub

    Private Function PPStatus(r1 As DataRow) As Boolean
        Dim PPFinal As Boolean = False
        Dim rPostPeriod As DataRow = oMasterFICO.rPostPeriod(myUtils.cValTN(r1("PostPeriodID")))
        If Not IsNothing(rPostPeriod) Then
            PPFinal = myUtils.cBoolTN(rPostPeriod("IsFinal"))
        End If
        Return PPFinal
    End Function

    Private Sub CalculateBalance()
        Dim Balance As Decimal = 0

        For Each r1 As DataRow In myView.mainGrid.myDv.Table.Select
            If myUtils.IsInList(myUtils.cStrTN(r1("ResItemType")), "MR", "SR") Then
                r1("Balance") = myUtils.cValTN(Balance) + myUtils.cValTN(r1("Qty"))
            Else
                r1("Balance") = myUtils.cValTN(Balance) - myUtils.cValTN(r1("Qty"))
            End If
            Balance = myUtils.cValTN(r1("Balance"))
        Next
    End Sub
End Class
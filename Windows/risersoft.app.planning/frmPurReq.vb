Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmPurReq
    Inherits frmMax
    Friend fItem As frmPurReqItem
    Dim dvMatDep As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridItemList)

        Me.AddUEGB(Me.UEGB_ItemList, 2, Me.UEGB_ItemDetail.Name)
        Me.AddUEGB(Me.UEGB_ItemDetail, 1, Me.UEGB_ItemList.Name)


        fItem = New frmPurReqItem
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me
        fItem.Enabled = False

        cmb_MatReqType.ReadOnly = True
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPurReqModel = Me.InitData("frmPurReqModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If myUtils.IsInList(myUtils.cStrTN(myRow("MatReqType")), "M") Then
                fItem.btnAddMachine.Visible = True
                fItem.btnAddLots.Visible = False
                fItem.UltraTabControl1.Tabs("LM").Text = "Machine"
                Me.cmb_IsAgainstJWO.ReadOnly = True
                myRow("isagainstjwo") = False
            Else
                fItem.btnAddMachine.Visible = False
                fItem.btnAddLots.Visible = True
                fItem.UltraTabControl1.Tabs("LM").Text = "Lots"
            End If
            HandleDate(myUtils.cDateTN(myRow("MRDate"), DateTime.MinValue))

            If myUtils.cBoolTN(myWinSQL2.ParamValue("@Status", Me.Model.ModelParams)) Then
                btnSave.Enabled = False
                btnOK.Enabled = False
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Items"))
            myWinSQL.AssignCmb(Me.dsCombo, "MatReqType", "", Me.cmb_MatReqType)
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "MatDep", "", Me.cmb_MatDepID,, 2)
            fItem.BindModel(NewModel)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If (myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave) AndAlso Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraGridItemList_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraGridItemList.AfterRowActivate
        Me.InitError()
        myView.mainGrid.myGrid.UpdateData()

        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        fItem.PrepForm(r1)

        fItem.myView.mainGrid.myDv.RowFilter = "MatReqItemID = " & myView.mainGrid.myGrid.ActiveRow.Cells("MatReqItemID").Value
        fItem.Enabled = True
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If myView.mainGrid.myDV.Count = 0 OrElse fItem.VSave Then
            Dim gr As UltraGridRow
            gr = myView.mainGrid.ButtonAction("add")
            fItem.Focus()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("QtyPur").Value) = 0 Then
            myView.mainGrid.ButtonAction("del")
            If myView.mainGrid.myDv.Table.Select.Length = 0 Then
                fItem.Enabled = False
            End If
        Else
            MsgBox("PO Created. Item can't be delete.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub cmb_MatReqType_Leave(sender As Object, e As EventArgs) Handles cmb_MatReqType.Leave, cmb_MatReqType.AfterCloseUp
        fItem.HandleMatReqType(myUtils.cStrTN(cmb_MatReqType.Value), myUtils.cBoolTN(Me.cmb_IsAgainstJWO.Value))
    End Sub

    Private Sub cmb_IsAgainstJWO_Leave(sender As Object, e As EventArgs) Handles cmb_IsAgainstJWO.Leave, cmb_IsAgainstJWO.AfterCloseUp
        fItem.HandleMatReqType(myUtils.cStrTN(cmb_MatReqType.Value), myUtils.cBoolTN(Me.cmb_IsAgainstJWO.Value))
    End Sub

    Private Sub dt_MRDate_Leave(sender As Object, e As EventArgs) Handles dt_MRDate.Leave, dt_MRDate.AfterCloseUp
        HandleDate(dt_MRDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class
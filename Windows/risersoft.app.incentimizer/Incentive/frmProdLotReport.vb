
Imports Infragistics.Win.UltraWinTabControl
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmProdLotReport
    Inherits frmMax
    Dim FormList As New clsCollecString(Of clsCollection(Of Integer, frmProdProgress)), mProc As clsProdReportProc
    Dim dvMatDep As DataView

    Public Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProdLotReportModel = Me.InitData("frmProdLotReportModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Dim utc As UltraTabControl
            Dim dt1 As DataTable = Me.dsForm.Tables("progress")
            FormList.Clear()
            For Each str1 As String In New String() {"IN", "NC"}
                utc = WinFormUtils.getControlFromName("Ultratabcontrol" & str1, Me)
                utc.Tabs.Clear()
                FormList.Add(str1, New clsCollection(Of Integer, frmProdProgress))
                For Each rProdProgress In dt1.Select(myUtils.CombineWhere(False, "worktype='" & str1 & "'", "prodlotreportid=" & myRow("prodlotreportid")), "typenum")
                    Dim f1 As New frmProdProgress
                    Dim uTab2 As UltraTab = f1.AddtoTab(utc, rProdProgress("plnpiduroutebasicid"), True)
                    If f1.PrepForm(myView, rProdProgress) Then
                        uTab2.Text = myUtils.cStrTN(rProdProgress("typedescrip"))
                        FormList(str1).Add(myUtils.cValTN(rProdProgress("plnpiduroutebasicid")), f1)
                    End If
                Next
            Next
            HandleDate(myUtils.cDateTN(myRow("Dated"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            txt_CumuProdOther.Value = myRow("CumuProdOther")
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "deps", "", Me.cmb_matdepid,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "proc", "", Me.cmb_PlnProcID)
            myWinSQL.AssignCmb(Me.dsCombo, "shift", "", Me.cmb_shiftID)
            myWinSQL.AssignCmb(Me.dsCombo, "incentive", "", Me.cmb_ProdIncType)
        End If
        Return True
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        Me.InitError()
        If myUtils.cValTN(txt_CumuProd.Text) > myUtils.cValTN(txt_TotalProd.Text) * 1.05 Then WinFormUtils.AddError(Me.txt_CumuProd, "Quantity Exceeded", Me.eBag)
        For Each worktype As String In FormList.Keys
            For Each f1 As frmProdProgress In FormList(worktype).Values
                If myUtils.cValTN(f1.txt_CumuProd.Text) > myUtils.cValTN(f1.txt_IncenProdTot.Text) * 1.05 Then WinFormUtils.AddError(f1.txt_Prod, "Quantity Exceeded", Me.eBag)
                f1.myView.mainGrid.CheckValid("numhours,worktype", , f1.uTab.Text & " - Progress", , Me.eBag)
            Next
        Next

        If Me.CanSave Then
            cm.EndCurrentEdit()
            For Each worktype As String In FormList.Keys
                For Each f1 As frmProdProgress In FormList(worktype).Values
                    f1.cm.EndCurrentEdit()
                    'Below for totalcontri calculation
                    For Each r1 As DataRow In f1.myView.mainGrid.myDv.Table.Select()
                        r1("matdepid") = myRow("matdepid")
                        r1("dated") = myRow("dated")
                    Next
                Next
            Next

            VSave = False
            If Me.ValidateData() Then
                cm.EndCurrentEdit()
                If Me.SaveModel() Then
                    Me.DoRefresh = True
                    Return True
                Else
                    Me.ShowError()
                End If
            Else
                Me.SetError()
            End If
            Me.Refresh()
        End If

    End Function

    Friend Sub OnIncenProdChanged()
        Dim sum As Decimal = 0

        For Each f1 As frmProdProgress In FormList("IN").Values
            sum = sum + myUtils.cValTN(f1.txt_Prod.Text)
        Next
        Me.txt_IncenProd.Text = sum
        Me.txt_CumuProd.Text = sum + myUtils.cValTN(Me.txt_CumuProdOther.Text)
        If myUtils.cValTN(Me.txt_TotalProd.Text) > 0 Then
            Me.txt_CumuPerCent.Text = Math.Round(myUtils.cValTN(Me.txt_CumuProd.Text) / myUtils.cValTN(Me.txt_TotalProd.Text) * 100, 2)
        Else
            Me.txt_CumuPerCent.Text = 0
        End If
    End Sub

    Private Sub frmProdLotReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.OnIncenProdChanged()
    End Sub

    Private Sub dt_dated_Leave(sender As Object, e As EventArgs) Handles dt_dated.Leave, dt_dated.AfterCloseUp
        HandleDate(dt_dated.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class
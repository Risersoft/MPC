Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxform

Public Class frmPlnResSumm
    Inherits frmMax

    Public Sub initForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPlnResSummModel = Me.InitData("frmPlnResSummModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.UltraTabControl1.Tabs.Clear()
            For Each r1 As DataRow In Me.Model.DatasetCollection("Summ").Tables("Campus").Select("", "DispName")
                Dim f2 As New frmPlnRes

                Dim rr() As DataRow = Me.Model.DatasetCollection("Summ").Tables("Res").Select("CampusId=" & r1("CampusId"))
                If rr.Length > 0 Then
                    f2.PrepForm(oview, EnumfrmMode.acEditM, rr(0)("plnReserveID"))
                Else
                    f2.PrepForm(oview, EnumfrmMode.acAddM, 0, "<PARAMS CAMPUSID=""" & myUtils.cValTN(r1("CampusId")) & """ ItemID =""" & myUtils.cValTN(myRow("ItemID")) & """ PIDUnitID =""" & myUtils.cValTN(myRow("PIDUnitID")) & """ ProdLotID =""" & myUtils.cValTN(myRow("ProdLotID")) & """ VarNum =""" & myUtils.cValTN(myRow("VarNum")) & """/>")
                End If
                Dim utab2 As UltraTab = f2.AddtoTab(Me.UltraTabControl1, r1("CampusId"), True)
                utab2.Text = r1("DispName")
            Next
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        For Each uTab2 As UltraTab In Me.UltraTabControl1.Tabs
            Dim f2 As frmPlnRes = CType(uTab2.TabPage.Controls(0), frmPlnRes)
            If f2.CurrEditRow IsNot Nothing Then WinFormUtils.AddError(f2.lblUnResStock, "Data not submitted", Me.eBag)
        Next
        If Me.CanSave Then
            cm.EndCurrentEdit()
            Dim cont As Boolean = True
            For Each uTab2 As UltraTab In Me.UltraTabControl1.Tabs
                Dim f2 As frmPlnRes = CType(uTab2.TabPage.Controls(0), frmPlnRes)
                If cont Then cont = f2.VSave()
            Next
            VSave = cont
        End If
        Me.Refresh()
    End Function
End Class
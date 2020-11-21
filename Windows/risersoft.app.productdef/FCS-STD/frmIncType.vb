Imports risersoft.shared.Extensions
Imports risersoft.app.mxent

Public Class frmIncType
    Inherits frmMax
    Dim WithEvents ItemCodeSys As New clsCodeSystem
    Friend fMat As frmPlnProc

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        myWinSQL.AssignCmb(fMat.dsCombo, "incentive", "", Me.cmb_ProdIncType)
        Me.cmb_SeparateShifts.ValueList = fMat.Model.ValueLists("SeparateShifts").ComboList
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            PrepForm = True
        End If
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click, btnCancel.Click
        Me.InitError()
        If myUtils.NullNot(Me.cmb_ProdIncType.Value) Then WinFormUtils.AddError(Me.cmb_ProdIncType, "Select a Incentive Type")
        Dim oMasterData As New clsMasterDataFICO(Me.Controller)
        Dim rPP As DataRow = oMasterData.rPostPeriod(myUtils.cValTN(myRow("PostPeriodID")))
        If (rPP IsNot Nothing) AndAlso myUtils.cBoolTN(rPP("IsFinal")) Then
            WinFormUtils.AddError(Me.dt_dated, "The Posting Period is finalized")
        End If
        Dim rPP2 As DataRow = oMasterData.rPostPeriod(Me.dt_dated.Value)
        If (rPP2 Is Nothing) Then
            WinFormUtils.AddError(Me.dt_dated, "No Postperiod can be found")
        Else
            If myUtils.cBoolTN(rPP2("IsFinal")) Then WinFormUtils.AddError(Me.dt_dated, "The Post Period is finalized")
        End If
        If Me.CanSave Then
            cm.EndCurrentEdit()
        End If
        myRow("postperiodid") = rPP2("postperiodid")
        Me.SaveSoftData()
    End Sub

End Class
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmOp
    Inherits frmMax
    Dim fOpReq As New clsCollection(Of Integer, frmOpReq)
    Dim fParam As frmDesParamFieldList, dicMat As clsCollecString(Of Boolean)

    Public Sub InitForm()
        Me.myView.SetGrid(Me.UltraGridBatching)
        dicMat = myWinApp.objAppExtender.dicMat
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        For i As Integer = 1 To 3
            Dim f As New frmOpReq
            f.SRTIndex = i
            fOpReq.Add(i, f)
        Next
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmOpModel = Me.InitData("frmOpModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            'Machine Description
            Me.lblMac.Text = ""
            If frmMode = EnumfrmMode.acEditM Then Me.lblMac.Text = Me.GenerateDataOutput("macinfo", myRow.Row.Table.DataSet, 0).Description

            For Each f As frmOpReq In fOpReq.Values
                If f.PrepForm(Me) Then
                    f.AddtoTab(Me.UltraTabControl1, "req" & f.SRTIndex, True)
                    f.BringToFront()
                End If
            Next
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Dim stdop As Boolean = (myUtils.NullNot(myRow("prodlotroutesceneid")) AndAlso myUtils.NullNot(myRow("plnpidurouteid")))
            If myUtils.cBoolTN(dicMat("des")) AndAlso stdop Then

                fParam = New frmDesParamFieldList
                If fParam.PrepFormRow(Me, "plnopid", myFuncs.FormulaFields("plnopid")) Then
                    fParam.AddtoTab(Me.UltraTabControl1, "params", True)
                Else
                    fParam = Nothing
                    Me.UltraTabControl1.Tabs("params").Visible = False
                End If

            Else
                Me.UltraTabControl1.Tabs("params").Visible = False
            End If

            myView.PrepEdit(Me.Model.GridViews("Lots"), Me.btnAddBatch, Me.btnDelBatch)

            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOpID1)
            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOPID2)
            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOpID3)
            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOpID4)
            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOpID5)
            myWinSQL.AssignCmb(Me.dsCombo, "prevop", "", Me.cmb_PrevOpID6)

            myWinSQL.AssignCmb(Me.dsCombo, "altop", "", Me.cmb_AltOpID1)
            myWinSQL.AssignCmb(Me.dsCombo, "altop", "", Me.cmb_AltOpID2)
            myWinSQL.AssignCmb(Me.dsCombo, "altop", "", Me.cmb_AltOpID3)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If (fParam IsNot Nothing) AndAlso (Not fParam.ValidateData) Then WinFormUtils.AddError(fParam, "Field Formula Errors", Me.eBag)
        If Me.ValidateData Then
            If Not fParam Is Nothing Then fParam.VSave()
            If Me.SaveModel() Then
                For Each f As frmOpReq In fOpReq.Values
                    f.frmIDX = Me.frmIDX
                    f.frmMode = EnumfrmMode.acEditM
                    f.VSave()
                Next
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub btnMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMac.Click
        Dim rr() As DataRow
        Dim Params As New List(Of clsSQLParam)
        rr = Me.AdvancedSelect("machine", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            myRow("plnmcgroupid") = DBNull.Value
            myRow("machineid") = rr(0)("machineid")
            Me.lblMac.Text = "MACHINE = " & rr(0)("mactype") & " - " & rr(0)("macnum")
        End If

    End Sub

    Private Sub btnMacGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMacGroup.Click
        Dim rr() As DataRow
        Dim Params As New List(Of clsSQLParam)
        rr = Me.AdvancedSelect("macgroup", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            myRow("plnmcgroupid") = rr(0)("plnmcgroupid")
            myRow("machineid") = DBNull.Value
            Me.lblMac.Text = "MACHINE GROUP = " & rr(0)("PlnMcGroupName") & " - " & rr(0)("machinelist")
        End If

    End Sub

    Private Sub btnRemoveMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveMac.Click
        myRow("plnmcgroupid") = DBNull.Value
        myRow("machineid") = DBNull.Value
        Me.lblMac.Text = "No Machine / Machine Group Selected"

    End Sub
End Class
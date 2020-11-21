Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmOpReq
    Inherits frmMax
    Dim myVueResGroup, myVueResCrew, myVueResOther As New clsWinView
    Dim fp As frmMax
    Public SRTIndex As Integer
    Public Sub InitForm()

        Me.myView.SetGrid(Me.UltraGridEmpRes)
        Me.myVueResCrew.SetGrid(Me.UltraGridResCrew)
        Me.myVueResGroup.SetGrid(Me.UltraGridResGroup)
        Me.myVueResOther.SetGrid(Me.UltraGridResOther)

    End Sub
    Public Overrides Function PrepForm(frmParent As frmMax) As Boolean
        Me.FormPrepared = False

        Dim strXML As String = "<PARAMS srtindex=""" & SRTIndex & """/>"
        fp = frmParent
        Dim objModel As frmOpReqModel = Me.InitData("frmOpReqModel", frmParent.myView, frmParent.frmMode, frmParent.frmIDX, strXML)
        If Me.BindModel(objModel, frmParent.myView) Then
            'TODO: Enforce MatDepID in PlnRoutingID for PlnRouting or PlnPIDURoute Operation Requirements.
            Me.FormPrepared = True

        End If
        Return Me.FormPrepared

    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("EmpRes"))
            myVueResCrew.PrepEdit(Me.Model.GridViews("ResCrew"))
            myVueResGroup.PrepEdit(Me.Model.GridViews("ResGroup"))
            myVueResOther.PrepEdit(Me.Model.GridViews("ResOther"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.ValidateData Then
            Me.Model.ClientParams.Clear()
            Me.Model.ClientParams.Add(New clsSQLParam("@SRTIndex", Me.SRTIndex, GetType(Integer), False))
            If Me.SaveModel() Then

                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub btnSel_Click(sender As Object, e As EventArgs) Handles btnSel.Click
        Dim rr() As DataRow
        Dim Params As New List(Of clsSQLParam)
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "rescrew"
                rr = Me.AdvancedSelect("rescrew", Params)
                Me.Controller.Data.CopySelectedRows(myVueResCrew.mainGrid.myDS.Tables(0), rr, "plnresourcegroupid", False)
            Case "resgrp"
                rr = Me.AdvancedSelect("resgrp", Params)
                Me.Controller.Data.CopySelectedRows(myVueResGroup.mainGrid.myDS.Tables(0), rr, "plnresourcegroupid", True)
            Case "res1"
                rr = Me.AdvancedSelect("res1", Params)
                Me.Controller.Data.CopySelectedRows(myView.mainGrid.myDS.Tables(0), rr, "plnresourcegroupid", False)
            Case "res2"
                rr = Me.AdvancedSelect("res2", Params)
                Me.Controller.Data.CopySelectedRows(myVueResOther.mainGrid.myDS.Tables(0), rr, "plnresourcegroupid", False)
        End Select
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim oView As clsWinView = Me.oViewFromTabKey(Me.UltraTabControl1.SelectedTab.Key)
        If Not oView Is Nothing Then oView.mainGrid.ButtonAction("del")
    End Sub

    Private Function oViewFromTabKey(str1 As String) As clsWinView
        Dim oView As clsWinView
        Select Case str1.Trim.ToLower
            Case "rescrew"
                oView = myVueResCrew
            Case "resgrp"
                oView = myVueResGroup
            Case "res1"
                oView = myView
            Case "res2"
                oView = myVueResOther
        End Select
        Return oView
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "rescrew"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueResCrew, "edit", GetType(frmResCrew), "plnresourcegroupid", "")
            Case "resgrp"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueResGroup, "edit", GetType(frmResGroup), "plnresourcegroupid", "")
            Case "res1"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmRes), "plnresourceid", "")
            Case "res2"
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueResOther, "edit", GetType(frmRes), "plnresourceid", "")
        End Select
    End Sub
End Class

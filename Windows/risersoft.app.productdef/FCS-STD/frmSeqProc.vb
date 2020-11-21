Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmSeqProc
    Inherits frmMax
    Dim fParamFld As frmDesParamFieldList, fParamTrans As frmDesParamTrans, dicMat As clsCollecString(Of Boolean)
    Dim myVueProd As New clsWinView

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGridMatCons)
        Me.myVueProd.SetGrid(Me.UltraGridMatProd)
        dicMat = myWinApp.objAppExtender.dicMat
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmSeqProcModel = Me.InitData("frmSeqProcModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

        End If
        PrepForm = True
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            If myUtils.cBoolTN(dicMat("des")) Then

                fParamFld = New frmDesParamFieldList
                If fParamFld.PrepFormRow(Me, "plnstdseqprocid", myFuncs.FormulaFields("plnstdseqprocid")) Then
                    fParamFld.AddtoTab(Me.UltraTabControl1, "paramfld", True)
                Else
                    fParamFld = Nothing
                    Me.UltraTabControl1.Tabs("paramfld").Visible = False
                End If

                fParamTrans = New frmDesParamTrans
                If fParamTrans.PrepFormRow(Me) Then
                    fParamTrans.AddtoTab(Me.UltraTabControl1, "paramtrans", True)
                Else
                    fParamTrans = Nothing
                    Me.UltraTabControl1.Tabs("paramtrans").Visible = False
                End If

            Else
                Me.UltraTabControl1.Tabs("paramfld").Visible = False
                Me.UltraTabControl1.Tabs("paramtrans").Visible = False
            End If

            myView.PrepEdit(Me.Model.GridViews("Consumed"))
            myVueProd.PrepEdit(Me.Model.GridViews("Produced"))
            myView.mainGrid.PrepEntSelect("<SYS ID=""matheadid""/>", Me.btnDelMatHead1, Me.btnSelMatHead1)
            myVueProd.mainGrid.PrepEntSelect("<SYS ID=""matheadid""/>", Me.btnDelMatHead2, Me.btnSelMatHead2)

            myWinSQL.AssignCmb(Me.dsCombo, "plnproc", "", Me.cmb_PlnProcID)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If (fParamFld IsNot Nothing) AndAlso (Not fParamFld.ValidateData) Then WinFormUtils.AddError(fParamFld, "Field Formula Errors", Me.eBag)
        If (fParamTrans IsNot Nothing) AndAlso (Not fParamTrans.ValidateData) Then WinFormUtils.AddError(fParamTrans, "Qualifying Parameters Errors", Me.eBag)
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If (Not fParamFld Is Nothing) Then fParamFld.VSave()
            If (Not fParamTrans Is Nothing) Then fParamTrans.VSave()
            If Me.SaveModel() Then
                VSave = True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

End Class
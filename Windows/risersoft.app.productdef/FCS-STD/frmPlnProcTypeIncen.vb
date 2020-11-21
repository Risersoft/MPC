Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared
Imports risersoft.shared.Extensions

Public Class frmPlnProcTypeIncen
    Inherits frmMax
    Dim fParam As frmDesParamQual, dicMat As clsCollecString(Of Boolean)

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.myView.SetGrid(Me.UltraGridBasicProd)
        dicMat = myWinApp.objAppExtender.dicMat
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPlnProcTypeIncenModel = Me.InitData("frmPlnProcTypeIncenModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            If myUtils.cBoolTN(dicMat("des")) Then
                fParam = New frmDesParamQual
                If fParam.PrepFormRow(Me) Then
                    fParam.AddtoTab(Me.UltraTabControl1, "params", True)
                Else
                    fParam = Nothing
                    Me.UltraTabControl1.Tabs("params").Visible = False
                End If
            Else
                Me.UltraTabControl1.Tabs("params").Visible = False
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("BasicProd"))
            myWinSQL.AssignCmb(Me.dsCombo, "plnproc", "", Me.cmb_PlnProcID)

            Me.cmb_typedescrip1.ValueList = Me.Model.ValueLists("typedescrip").ComboList
            Me.cmb_typedescrip2.ValueList = Me.Model.ValueLists("typedescrip").ComboList
            Me.cmb_typedescrip3.ValueList = Me.Model.ValueLists("typedescrip").ComboList

            Me.cmb_ProdUnitName.ValueList = Me.Model.ValueLists("produnitname").ComboList
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If Me.SaveModel() Then
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub RefreshGrid()
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("prodbasic", frmIDX)
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim nr As DataRow
        If frmMode = EnumfrmMode.acEditM OrElse Me.VSave Then
            nr = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmProdBasic), "prodbasicid", "<PARAMS plnproctypeincenid='" & frmIDX & "'/>")
            If (Not nr Is Nothing) Then
                RefreshGrid()
            End If
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("del")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim nr As DataRow
        nr = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmProdBasic), "prodbasicid", "<PARAMS plnproctypeincenid='" & frmIDX & "'/>")
        If (Not nr Is Nothing) Then
            RefreshGrid()
        End If
    End Sub
End Class


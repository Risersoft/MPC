Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmSubCatSupp
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmSubCatSuppModel = Me.InitData("frmSubCatSuppModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Vendor", "", Me.cmb_VendorID)
            myWinSQL.AssignCmb(Me.dsCombo, "Vendor", "", Me.cmb_MakeID)

            Me.cmb_Category.ValueList = Me.Model.ValueLists("Cat").ComboList
            Me.cmb_RatDelivery.ValueList = Me.Model.ValueLists("Rat").ComboList
            Me.cmb_RatPrice.ValueList = Me.Model.ValueLists("Rat").ComboList
            Me.cmb_RatQuality.ValueList = Me.Model.ValueLists("Rat").ComboList
            Me.cmb_RatResponse.ValueList = Me.Model.ValueLists("Rat").ComboList
            Return True
        End If
        Return False
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
End Class
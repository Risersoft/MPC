Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatPosModel
    Inherits clsFormDataModel
    Dim myVueItems As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Supp")
        myVueItems = Me.GetViewModel("ML")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String
        FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from plnListProdLots() where ProdLotID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)


        sql = "select prodlotbomid,parentlotbomid,prodlotid,RequireMO,SeqProcName,MatPC,ItemCode,SpecWrite,ItemName,QtyReqBOM,QtyReqMRP,UnitName,DateReq from plnListProdLotBOM() where prodlotid =" & prepIDX
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        myUtils.AddTable(Me.dsForm, ds, "ProdLotBOM", 0)

        myView.MainGrid.MainConf("showrownumber") = True
        myView.MainGrid.MainConf("defaultgroupon") = "seqprocname"
        myView.MainGrid.MainConf("sortcolsasc") = "seqprocname,matpc desc,prodlotbomid"
        myView.MainGrid.BindGridData(dsForm, 1)
        myView.MainGrid.QuickConf("", True, "2-1-2-2-5-1-1-1-1", , "BOM")

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

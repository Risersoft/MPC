Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPlnResSummModel
    Inherits clsFormDataModel
    Public oSQL As New clsSQLBuilderMM(myContext)

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String, dic As New clsCollecString(Of String)

        FormPrepared = False
        prepIDX = 0
        sql = "Select ItemID, ItemCode, ItemName, PIDUnitID, VarNum, ProdLotID, LotInfo, VarWoInfo from plnListReserve() where 0=1"
        Me.InitData(sql, "ProdLotID,PIDUnitID,ItemID,VarNum,VarWoInfo,LotInfo,ItemCode,ItemName", oView, EnumfrmMode.acAddM, prepIDX, strXML)

        str1 = oSQL.GenerateSQLWhere(myRow.Row, "ItemID,PIDUnitID,VarNum,ProdLotID")
        dic.Add("Campus", "Select Distinct CampusID, DispName from Campus where CampusType in ('CM')")
        dic.Add("Res", "Select * from plnReserve where " & str1)
        Me.AddDataSet("Summ", dic)

        FormPrepared = True
        Return Me.FormPrepared
    End Function
End Class

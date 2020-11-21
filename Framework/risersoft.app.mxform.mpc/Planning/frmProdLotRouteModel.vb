Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdLotRouteModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ProdList")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim dic As New clsCollecString(Of String)
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim sql As String = "select * from plnListProdLotRoute() where scenenum=0 and prodlotrouteid = " & prepIDX
            Me.InitData(sql, "prodlotid", oView, prepMode, prepIDX, strXML)

            dic.Add("route", "select ProdLotRouteSceneID,SceneNum,SceneName from plnListProdLotRoute() where ProdLotRouteSceneID is not null and prodlotrouteid = " & frmIDX & " order by scenenum")
            Me.AddDataSet("route", dic)

            sql = "select ProdProgressID, ProdLotReportID, Dated, ProdIncType, Shift, Prod, ProgToday, Remark from proListProgress() where ProdLotRouteID  = " & frmIDX & " order by dated"
            myView.MainGrid.QuickConf(sql, True, "1-1-1-1-1-2", True, "Progress Reports")
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim LotDescrip As String = " Lot Process for: " & myUtils.cStrTN(myRow("PIDInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "prodlotrouteid", frmIDX)
                myRow("iscompleted") = (Not myUtils.NullNot(myRow("donedate")))
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "select prodlotrouteid,donedate,iscompleted from prodlotroute where 0=1")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(LotDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(LotDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "prodlot"
                Dim oProc As New clsProdLotMRP(myContext)
                oRet = oProc.HandleLotRoutes(frmIDX)
        End Select
        Return oRet
    End Function
End Class

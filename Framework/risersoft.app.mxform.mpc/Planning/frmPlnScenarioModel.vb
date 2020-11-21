Imports risersoft.shared
Imports risersoft.app.mxent
Imports C1.C1Zip
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPlnScenarioModel
    Inherits clsFormDataModel
    Dim myViewMRP As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ProdLot")
        myViewMRP = Me.GetViewModel("MRP")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String, oProc As New clsProdLotMRP(myContext)
        FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from PlnScenario where PlnScenarioID =" & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        Dim dsMRP As DataSet = oProc.GenerateMRPTable("", "", myUtils.cValTN(myRow("SceneNum")))
        myViewMRP.MainGrid.BindGridData(dsMRP, 0)
        myViewMRP.MainGrid.QuickConf("", True, "1-1-1-3-1-0-1-1-1-1-1-1-1-1-1", True)

        myView.MainGrid.MainConf("rhfactor") = 2
        myView.MainGrid.BindGridData(GenerateData("prodlotroute", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-1-1-1-1-1-1", True)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PlnDescrip As String = " Num: " & myRow("SceneNum").ToString & " Name: " & myRow("SceneName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PlnScenarioID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(PlnDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(PlnDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Protected Friend Async Function Export(scenenum As Integer) As Task(Of clsProcOutput)
        Dim foldername As String = myContext.App.objAppExtender.AppDataPath
        Dim str1 As String = System.IO.Path.Combine(foldername, "TACEXP")
        Dim oRet As New clsProcOutput
        If myContext.FTP.RecreateLocalDirectory(str1) Then
            Dim oImpEx As clsSaveDT = New clsExpDT(myContext)
            myContext.CallBack.LogText("Begin Export")
            oImpEx.ImpEx(str1, "01", scenenum)
            myContext.CallBack.LogText("End Export. Begin Upload")
            Dim oFiler As New clsMultiFiler(myContext, "pln")
            oRet.Description = Await oFiler.FileProvider.UploadLocalFolderAsZip(str1, "TACEXP.zip")
            myContext.CallBack.LogText("End Upload")
        End If
        Return oRet
    End Function
    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput, oProc As New clsProdLotMRP(myContext)
        Select Case dataKey.Trim.ToLower
            Case "generate"
                'ID=SceneNum
                oProc.CalcluateMRPTable("", ID)
                oRet.Data = oProc.GenerateMRPTable("", ID)
            Case "export"
                'ID=SceneNum
                oRet = Me.Export(ID).Result
            Case "run"
                'ID=SceneNum
                oRet = Me.Export(ID).Result
                If oRet.Success Then
                    Dim provider As IQueueProvider = myContext.App.objAppExtender.QueueProvider(myContext)
                    Dim report As clsProgressReport = New clsProgressReport
                    AddHandler provider.CallBackRecieved, Sub(msg As clsProgressReport)
                                                              report = msg  'last call will return filename
                                                              myContext.CallBack.LogText(msg.Message)
                                                          End Sub


                    provider.SendMessageAndWait("tactic", oRet.Description)
                    If report.Success AndAlso report.TaskCompleted Then
                        oRet = Me.Import(ID, report.Description).Result
                    End If
                End If
            Case "publish"
                'ID=SceneNum
                Dim oGen As New clsProdLotPln(myContext)
                oGen.PublishAPSSchedule(ID)

            Case "prodlotroute"
                oRet.Data = GenerateData("prodlotroute", myUtils.cValTN(ID))

        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput, sql, str1 As String
        Select Case DataKey.Trim.ToLower
            Case "prodlotroute"
                Dim strs1 As String = "ProdLotID, PIDUnitID, WOInfo, LotNum, QtyReq, SDate, EDate, DateReq"
                str1 = myUtils.CombineWhere(False, "SDate is Not Null", "EDate is Null", "SceneNum=" & ID)
                sql = "Select " & strs1 & ", max(FinishDate) as FinishDate from PlnListProdLotRoute() where " & str1 & " Group by " & strs1 & " order by SDate,LotNum"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select

        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim scenenum As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@scenenum", Params))
            Dim filename As String = myUtils.cStrTN(myContext.SQL.ParamValue("@filename", Params))
            Select Case dataKey.Trim.ToLower
                Case "import"
                    oRet = Me.Import(scenenum, filename).Result
            End Select

        End If

        Return oRet
    End Function

    Protected Friend Async Function Import(scenenum As Integer, filename As String) As Task(Of clsProcOutput)
        Dim oRet As New clsProcOutput
        Dim oFiler As New clsMultiFiler(myContext, "pln")
        Dim foldername As String = myContext.App.objAppExtender.AppDataPath
        Dim str1 As String = Await oFiler.FileProvider.DownloadZipAsLocalFolder(filename, foldername, "TACIMP")
        Dim oImpEx As clsSaveDT = New clsImpDT(myContext)
        oImpEx.ImpEx(str1, "01", scenenum)
        Return oRet
    End Function

End Class

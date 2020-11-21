Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPlnProcModel
    Inherits clsFormDataModel
    Dim myVueShop, myVueIncType, myVueProcType, myVueSeqProc As New clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Routings")
        myVueShop = Me.GetViewModel("VueShop")
        myVueIncType = Me.GetViewModel("IncType")
        myVueProcType = Me.GetViewModel("ProcType")
        myVueSeqProc = Me.GetViewModel("SeqProc")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Dim vlist As New clsValueList
        vlist.Add(False, "Not Required")
        vlist.Add(True, "Required")
        Me.ValueLists.Add("RequireMO", vlist)
        Me.AddLookupField("RequireMO", "RequireMO")

        Dim vlist1 As New clsValueList
        vlist1.Add(True, "Yes")
        vlist1.Add(False, "No")
        Me.ValueLists.Add("SeparateShifts", vlist1)
        Me.AddLookupField("SeparateShifts", "SeparateShifts")

        Dim Sql As String = myFuncsBase.CodeWordSQL("incentive", "inctype", "")
        Me.AddLookupField("ProdIncType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "incentive").TableName)

    End Sub
    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0

        Dim Sql As String = "Select * from plnproc where plnprocid = " & prepIDX
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

        Sql = "Select plnprocinctypeid, plnprocid, postperiodid, Dated, SeparateShifts, ProdIncType from PlnProcIncType where plnProcid = %frmIDX%"
        Me.myVueIncType.MainGrid.QuickConf(Sql, True, "1-1-2", True)
        Dim str1 As String = "<BAND TABLE=""PlnProcIncType"" IDFIELD=""plnprocinctypeid"" INDEX=""0""><COL KEY="" plnprocinctypeid, plnprocid, postperiodid, Dated, SeparateShifts, ProdIncType ""/></BAND>"
        Me.myVueIncType.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""RouteName"" CAPTION=""Routing""/>"
        myView.MainGrid.BindGridData(GenerateData("plnrouting", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-1", True)

        Sql = "Select plnprocshopid, plnprocid, matdepid, DepName, DispName from mmListProcShop() where plnProcid = %frmIDX%"
        myVueShop.MainGrid.MainConf("FORMATXML") = "<COL KEY=""DispName"" CAPTION=""Campus""/>"
        myVueShop.MainGrid.QuickConf(Sql, True, "1-1", True)
        str1 = "<BAND INDEX = ""0"" TABLE = ""plnprocshop"" IDFIELD=""plnprocshopid""><COL KEY ="" plnprocshopid, plnProcid, matdepid""/></BAND>"
        myVueShop.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueProcType.MainGrid.MainConf("FORMATXML") = "<COL KEY=""ProcTypeDescrip"" CAPTION=""Incentive Type""/>"
        myVueProcType.MainGrid.BindGridData(GenerateData("typeincen", frmIDX), 0)
        myVueProcType.MainGrid.QuickConf("", True, "3-1-2-2-2", True)

        myVueSeqProc.MainGrid.MainConf("FORMATXML") = "<COL KEY=""SeqProcName"" CAPTION=""Sequence Process""/><COL KEY=""ProcName"" CAPTION=""Plan Process""/>"
        myVueSeqProc.MainGrid.BindGridData(GenerateData("seqproc", frmIDX), 0)
        myVueSeqProc.MainGrid.QuickConf("", True, "2-3", True)


        Dim oDef As New clsParamDef(myContext)
        oDef.PopulateAttribAssign(Me, "PPR", "plnprocid", frmIDX)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("ProcName")).Trim.Length = 0 Then Me.AddError("ProcName", "Please Enter ProcName")
        If Me.SelectedItem("RequireMO") Is Nothing Then Me.AddError("RequireMO", "Enter Mfg Order")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PlnProcDescrip As String = myRow("ProcName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnprocid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnprocid")
                frmMode = EnumfrmMode.acEditM
                Me.myVueShop.MainGrid.SaveChanges(, "plnprocid=" & frmIDX)
                Me.myVueIncType.MainGrid.SaveChanges(, "plnprocid=" & frmIDX)
                Dim oDef As New clsParamDef(myContext)
                oDef.SaveAttribAssign(Me, "PPR", "plnprocid", frmIDX)


                myContext.Provider.dbConn.CommitTransaction(PlnProcDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(PlnProcDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If

    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput, sql As String, ds As DataSet
        Select Case dataKey.Trim.ToLower
            Case "plnrouting"
                oRet.Data = GenerateData("plnrouting", myUtils.cValTN(ID))

            Case "seqproc"
                oRet.Data = GenerateData("seqproc", myUtils.cValTN(ID))

            Case "typeincen"
                oRet.Data = GenerateData("typeincen", myUtils.cValTN(ID))

            Case "deleteshop"
                sql = "select * from plnlistprodlotroute() where plnprocshopid in (Select plnprocshopid from plnprocshop where plnprocshopid = " & myUtils.cValTN(ID) & ")"
                ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                If ds.Tables(0).Rows.Count > 0 Then
                    oRet.AddError("This Shop Cannot be Deleted as it is in use")
                Else
                    sql = "delete from Plnprocshop where plnprocshopid = " & myUtils.cValTN(ID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                End If

        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "plnrouting"
                Dim sql As String = "Select plnroutingid,plnprocid,RouteName,Remark from PlnRouting where plnProcid = " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "seqproc"
                Dim sql As String = "Select PlnStdSeqProcID, PlnProcID, SeqProcName, Remark from plnListStdSeqProc() where plnprocid= " & ID & " order by plnStdSeqProcID"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "typeincen"
                Dim sql As String = "Select plnproctypeincenid,plnprocid, ProcTypeDescrip, ProdUnitName, TypeDescrip1, TypeDescrip2, TypeDescrip3 from PlnProcTypeIncen where plnprocid= " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "shops"
                    Dim plnProcid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@plnProcid", Params))
                    Dim Str1 As String = "matdepid not in (select matdepid from mmlistprocshop() where plnProcid = " & plnProcid & ")"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""matdepid""/>", True, , "<MODROW><SQLWHERE2>" & Str1 & "</SQLWHERE2></MODROW>")

            End Select
        End If
        Return Model
    End Function

End Class
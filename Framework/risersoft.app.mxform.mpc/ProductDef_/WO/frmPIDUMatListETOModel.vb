Imports risersoft.shared
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDUMatListETOModel
    Inherits clsFormDataModel
    Dim myVueSpec As New clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myVueSpec = Me.GetViewModel("Specs")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from deslistpidunittot() where pidunitid = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.BindGridData(GenerateData("items", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-3-1-3-1-1")

        myVueSpec.MainGrid.BindGridData(GenerateData("specs", frmIDX), 0)
        myVueSpec.MainGrid.QuickConf("", True, "1-3-1-1-2-1-2")

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim ETODescrip As String = myUtils.cStrTN(myRow("PIDInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PidUnitID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PidUnitID")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ETODescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ETODescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "items"
                oRet.Data = GenerateData("items", myUtils.cValTN(frmIDX))
            Case "specs"
                oRet.Data = GenerateData("specs", myUtils.cValTN(frmIDX))

        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim PidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params))
            Dim ItemVMSID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ItemVMSID", Params))
            Dim num As Integer = myFuncs.GiveVMSUsageCount(myContext, ItemVMSID, 0, 0, 0, 0, 0)
            If num = 0 Then
                Select Case dataKey.Trim.ToLower
                    Case "delitems"
                        Dim sql1 As String = "delete from pidunititemvar where ItemVMSID=" & myUtils.cValTN(ItemVMSID)
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                        Dim sql2 As String = "delete from itemvms where ItemVMSID=" & myUtils.cValTN(ItemVMSID)
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql2)
                        oRet.Data = GenerateData("Items", PidUnitID)
                    Case "delspecs"
                        Dim sql As String = "delete from itemvms where ItemVMSID=" & myUtils.cValTN(ItemVMSID)
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                        oRet.Data = GenerateData("Specs", PidUnitID)
                End Select
            Else
                oRet.AddError("This spec version is already in use")
            End If
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "items"
                Dim sql As String = "select pidunititemvarid, pidunitid,ItemVMSID, ItemID, ItemCode, ItemName, VarNum, VarName, SpecNum, RevNum from plnListpidunititemvar() where pidunitid=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "specs"
                Dim sql As String = "select itemvmsid, pidunitid, ItemID, ItemCode, ItemName, SpecNum, RevNum, KanSpecs, Make, SuppSpec from invlistItemVMS() where varnum is null and pidunitid=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "items"
                    Dim strMod As String = "<MODROW><SQLWHERE2>ISETO=1</SQLWHERE2></MODROW>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ITEMID""/>",  , , strMod)
                Case "specs"
                    Dim strMod As String = "<MODROW><SQLWHERE2>SELECTVMSTYPE=2</SQLWHERE2></MODROW>"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ITEMID""/>",  , , strMod)
            End Select
        End If
        Return Model
    End Function
End Class

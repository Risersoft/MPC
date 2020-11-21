Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatList1CopyModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
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
        If prepMode = EnumfrmMode.acEditM Then
            Dim Sql As String = "select * from desListPidUnittot() where PidUnitID = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "Select PidUnitID from PidUnit where PidUnitId = 0"

            Dim dic1 As New clsCollecString(Of String)
            Sql = "select * from matheadtype order by headtype"
            dic1.Add("MatHeadType", Sql)
            Me.AddDataSet("MatHeadType", dic1)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim Str1 As String
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "matlistmathead"
                    Dim matIndex As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@matindex", Params))
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim HeadTypeID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@headtypeid", Params))

                    If matIndex = 2 Then Str1 = " isFormatList2 = 1 " Else Str1 = " isFormatList1 = 1"

                    Dim Sql As String = "select distinct matlistid,matheadid,itemid,Head,ItemCode,Spec,Qty,Remark from deslistmatlist1() where headtypeid=" & HeadTypeID & " and PIDUnitID = " & PIDUnitID & " AND " & Str1
                    Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)

                    Dim Sql1 As String = "select matheadid,HeadName from matheads where " & Str1 & " and HeadTypeID=" & HeadTypeID & " and matheadid not in (select matheadid from matlist1 where PIDUnitID = " & PIDUnitID & ")"
                    Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql1).Tables(0)

                    myUtils.AddTable(oRet.Data, dt, "matlist")
                    myUtils.AddTable(oRet.Data, dt1, "mathead")
            End Select
        End If
        Return oRet
    End Function
End Class

Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatListCostModel
    Inherits clsFormDataModel

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
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim sql As String = "select * from deslistpidunittot() where pidunitid = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "Select pidunitid from pidunit where pidunitid =0"

            Dim dic1 As New clsCollecString(Of String)
            Dim str1 As String = "isNull(isOld,0)=0"
            Dim str2 As String = " isForCostingMats = 1 "
            sql = "select * from MatHeadType where HeadTypeId in (select HeadTypeId from MatHeads where " & myUtils.CombineWhere(False, str1, str2) & ") order by HeadType"
            dic1.Add("matheadtype", sql)
            Me.AddDataSet("matheadtype", dic1)

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
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "mathead"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim HeadTypeID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@headtypeid", Params))
                    Dim str1 As String = "isNull(isOld,0)=0"
                    Dim str2 As String = " isForCostingMats = 1 "
                    Dim str4 As String = "MatHeadId Not in (Select MatHeadId from MatListCost where PidUnitId = " & PIDUnitID & ")"
                    Dim str3 As String = "HeadTypeId=" & HeadTypeID

                    Dim Sql As String = "select MatHeadId,HeadName from MatHeads where " & myUtils.CombineWhere(False, str1, str2, str3, str4)
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oView As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "matlist"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim HeadTypeID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@headtypeid", Params))
                    Dim str3 As String = "HeadTypeId=" & HeadTypeID

                    Dim strtag As String = "<VIEW KEY=""listmatlistcost""><FILTER KEY=""pidu""><VALUE VALUE1=""" & PIDUnitID & """ /></FILTER><MODROW><SQLWHERE2>" & str3 & "</SQLWHERE2><RHFACTOR>2</RHFACTOR><SHOWROWNUMBER>TRUE</SHOWROWNUMBER></MODROW></VIEW>"
                    myContext.Provider.ProcessTag(oView, strtag)
            End Select
        End If
        Return oView
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "delete"
                Try
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "delete from matlistcost where matlistcostid = " & frmIDX)
                Catch ex As Exception
                    Me.AddError("DescripWO", ex.Message)
                End Try
        End Select
        Return oRet
    End Function
End Class

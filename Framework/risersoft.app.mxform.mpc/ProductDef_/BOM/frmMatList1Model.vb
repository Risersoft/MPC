Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatList1Model
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
            Dim sql As String = "select * from deslistpidunittot() where PidUnitId = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "Select PidUnitId from PidUnit where PidUnitId =0"

            Me.DatasetCollection.AddUpd("MatHeadType", Me.GenerateData("matheadtype", 0))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function
    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim dic1 As New clsCollecString(Of String), ds As DataSet
        Select Case DataKey.Trim.ToLower
            Case "matheadtype"
                dic1.Add("MatHeadType", "select * from MatHeadType order by HeadType")
                ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic1)
        End Select
        Return ds
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
                Case "matlistmathead"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim matIndex As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@matindex", Params))
                    Dim HeadTypeID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@headtypeid", Params))

                    Dim Str1, str2 As String
                    Str1 = " ListIndex = " & matIndex
                    If matIndex = 2 Then
                        str2 = " isFormatList2 = 1 "
                    Else
                        str2 = " isFormatList1 = 1 "
                    End If

                    Dim Sql As String = "select distinct sortindex,matlistid,matheadid,itemid,Head,ItemCode,isnull(itemname,Spec) as Spec,Qty,Remark from deslistmatlist1() where headtypeid=" & HeadTypeID & " and pidunitid = " & PIDUnitID & " AND " & Str1 & " order by sortindex"
                    Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)

                    Dim Sql1 As String = "select matheadid,HeadName from matheads where isnull(isold,0)=0 and " & str2 & " and headtypeid=" & HeadTypeID & " and matheadid not in (select matheadid from matlist1 where pidunitid = " & PIDUnitID & ")"
                    Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql1).Tables(0)

                    myUtils.AddTable(oRet.Data, dt, "matlist")
                    myUtils.AddTable(oRet.Data, dt1, "mathead")
                Case "btncopy"
                    Dim RefPIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@refpidunitid", Params))
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim dtMatOrig As DataTable
                    Dim MatHeadIDCSV As String = myContext.SQL.ParamValue("@matheadidcsv", Params)

                    Dim Sql As String = "select * from matlist1 where PidUnitId = " & RefPIDUnitID & " AND MatHeadId in (" & MatHeadIDCSV & ")"
                    dtMatOrig = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)

                    Dim dtMatNew = myUtils.CloneAndCopyRows(dtMatOrig, "", "")
                    myUtils.ChangeAll(dtMatNew.Select(), "PidUnitId=" & PIDUnitID & ",MatListId=null")
                    myContext.Provider.objSQLHelper.SaveResults(dtMatNew, "select * from MatList1 where MatListId=0")

                    For Each r1 As DataRow In dtMatNew.Rows
                        Dim r2 As DataRow = dtMatOrig.Select("MatHeadId=" & myUtils.cValTN(r1("MatHeadId")))(0)
                        Sql = "Insert into MatListVMS(MatListId,ItemVMSId,SpecVMS, OrderNumDescrip) Select " & myUtils.cValTN(r1("MatListId")) & ",ItemVMSId,SpecVMS,OrderNumDescrip from MatListVMS where MatListId = " & myUtils.cValTN(r2("MatListId"))
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                    Next
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "oldhead"
                Dim Sql As String = "select distinct HeadName,itemvmsid,iscurrent from deslistmatlist1() where isnull(iscurrent,0)=0 and pidunitid=" & frmIDX
                Sql = Sql & " union select distinct HeadName,itemvmsid,iscurrent from deslistmatlist1() where  isnull(iscurrent,0)=0 and pidunitid=" & frmIDX
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "delete"
                Try
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "delete from matlist1 where matlistid = " & frmIDX)
                Catch ex As Exception
                    Me.AddError("DescripWO", ex.Message)
                End Try
            Case Else
                oRet.Data = Me.GenerateData(dataKey, frmIDX)
        End Select
        Return oRet
    End Function
End Class

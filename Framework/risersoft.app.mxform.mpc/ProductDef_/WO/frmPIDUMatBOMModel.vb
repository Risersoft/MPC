Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDUMatBOMModel
    Inherits clsFormDataModel
    Dim myVueItemBOM As New clsViewModel, myVueAltBOM1, myVueAltBOM2 As New clsViewModel

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

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Me.InitData("", "", oView, prepMode, prepIDX, strXML)
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim PidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params))
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "matalt"
                    Dim str1 As String = "pidunitid=" & myUtils.cValTN(PidUnitID)
                    Dim str2 As String = str1
                    If myContext.SQL.Exists(Params, "@plnpidurouteid") Then str2 = myUtils.CombineWhere(False, str2, "plnpidurouteid=" & myUtils.cValTN(myContext.SQL.ParamValue("@plnpidurouteid", Params)))
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("mat", "select * from plnListPIDUMatBOM() where " & str2)
                    dic.Add("alt", "select * from plnListPIDUMatBOMAlt() where " & str1)
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)

                Case "delete"
                    Dim PIDUMatBOMAltid As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PIDUMatBOMAltid", Params))
                    Dim sql As String = "delete from PIDUMatBOMAlt where PIDUMatBOMAltid=" & myUtils.cValTN(PIDUMatBOMAltid)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput, myBOM As New clsBOMGeneratorBase(myContext)
        Select Case dataKey.Trim.ToLower
            Case "itemvmsbom"
                oRet.Data = myBOM.GenerateItemVMSBOM(frmIDX, False).DataSet
        End Select
        Return oRet
    End Function

End Class

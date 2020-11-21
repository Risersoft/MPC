Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMatListSpModel
    Inherits clsFormDataModel
    Dim MyViewHead As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Spares")
        MyViewHead = Me.GetViewModel("Heads")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "select * from desListPidUnitTot() where PidUnitId = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "Select PidUnitId from PidUnit where PidUnitId =0"

            myView.MainGrid.MainConf("bansort") = True
            myView.MainGrid.BindGridData(GenerateData("head", frmIDX), 0)
            myView.MainGrid.QuickConf("", True, "1.5-1.5-2-4-1.5-1-2", True)

            MyViewHead.MainGrid.MainConf("ColHeaders") = False
            MyViewHead.MainGrid.BindGridData(GenerateData("spare", frmIDX), 0)
            MyViewHead.MainGrid.QuickConf("", True, "3-2", True, "Unused Heads")
            str1 = "<BAND INDEX=""0"" TABLE=""sospare"" IDFIELD=""sospareID""><COL KEY=""AssemblyName""/></BAND>"""
            MyViewHead.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            FormPrepared = True
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
            Dim MatDescrip As String = " Material List Spares for: " & myUtils.cStrTN(myRow("PIDInfo")) & " for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PidUnitId", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myView.MainGrid.myDS.Tables(0), "Select MatListSpareId,SortIndex from MatListSpare where MatListSpareId=0")
                MyViewHead.MainGrid.SaveChanges()
                myContext.Provider.dbConn.CommitTransaction(MatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MatDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "sparename"
                Dim sql As String = "Select distinct SpareName,ItemVMSId,isCurrent from desListMatListSpare() where isnull(iscurrent,0)=0 and PidUnitId=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "head"
                oRet.Data = GenerateData("head", ID)
            Case "spare"
                oRet.Data = GenerateData("spare", ID)
            Case "delete"
                Dim Sql As String = "Delete from MatListSpare where MatListSpareId = " & ID
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "head"
                Dim sql As String = "select distinct sortindex,matlistspareid,matheadid,sospareid,itemid,SpareName,isnull(ItemCode,HeadCode) as Code,HeadName,isnull(itemname,Spec) as Spec,Qty,Unit,Remark from deslistmatlistspare() where pidunitid = " & myUtils.cValTN(ID) & " order by sortindex,sospareid"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "spare"
                Dim str2 As String = "PidUnitId=" & myUtils.cValTN(ID)
                Dim sql As String = "select SoSpareId,SpareName,AssemblyName from SoSpare where " & str2
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

End Class

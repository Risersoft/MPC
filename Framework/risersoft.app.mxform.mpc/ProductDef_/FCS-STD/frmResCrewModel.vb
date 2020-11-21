Imports risersoft.shared
Imports System.Runtime.Serialization
<DataContract>
Public Class frmResCrewModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Resources")
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
        Dim Sql As String
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "select * from PlnResourceGroup where PlnResourceGroupID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "isother", oView, prepMode, prepIDX, strXML)

        myRow("iscrew") = True

        Sql = "select PlnResourceMemid,PlnResourceGroupid,PlnResourceID,ResourceName,EmpCode,FullName,Designation,DepName,ResDescrip,Qty,Rank from plnlistresource() where PlnResourceGroupID = " & frmIDX
        If myUtils.cBoolTN(myRow("isother")) Then
            myView.MainGrid.QuickConf(Sql, True, "1.25-0-0-0-0-2-1-0", True, "Resources")
            myView.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""PlnResourceMemID"" TABLE=""PlnResourceMem""><COL KEY=""PlnResourceID,PlnResourceGroupID,Qty,Rank""/></BAND>", EnumEditType.acCommandAndEdit)
        Else
            myView.MainGrid.QuickConf(Sql, True, "1.25-0.5-1.5-1-0.75-2-1-0", True, "Resources")
            myView.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""PlnResourceMemID"" TABLE=""PlnResourceMem""><COL KEY=""PlnResourceID,PlnResourceGroupID,Qty,Rank""/></BAND>", EnumEditType.acCommandAndEdit)
        End If

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("ResGroupName")).Trim.Length = 0 Then Me.AddError("ResGroupName", "Enter Crew Name")
        If Me.myView.MainGrid.myDS.Tables(0).Select.Length = 0 Then Me.AddError("", "Select Resources")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim ResCrewDescrip As String = myRow("ResGroupName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PlnResourceGroupid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PlnResourceGroupid")
                myView.MainGrid.SaveChanges(, "Rank=null,PlnResourceGroupid=" & frmIDX)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ResCrewDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(ResCrewDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class


Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmMacGroupModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Machines")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "select * from PlnMcGroup where PlnMcGroupID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "", oView, prepMode, prepIDX, strXML)

        sql = "select * from plnlistmacs() where plnmcgroupid=" & frmIDX
        myView.MainGrid.QuickConf(sql, True, "2-1-1-1.5-1-1-3", True, "Machines")

        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""PLNMCGROUPMACID"" TABLE=""PLNMCGROUPMAC""><COL KEY=""machineid,plnmcgroupid""/></BAND>", EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(Me.myRow("PlnMcGroupName")).Trim.Length = 0 Then Me.AddError("PlnMcGroupName", "Enter Name")
        If Me.myView.MainGrid.myDS.Tables(0).Select.Length = 0 Then Me.AddError("", "Select Machines")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim MacDescrip As String = myRow("PlnMcGroupName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "plnmcgroupid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("plnmcgroupid")
                myView.MainGrid.SaveChanges(, "plnmcgroupid=" & frmIDX)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(MacDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(MacDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class




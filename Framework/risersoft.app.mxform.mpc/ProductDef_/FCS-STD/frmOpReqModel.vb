Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmOpReqModel
    Inherits clsFormDataModel
    Dim myVueResGroup, myVueResCrew, myVueResOther As New clsViewModel
    Public SRTIndex As Integer
    Dim IDField As String = "plnopid"

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("EmpRes")
        myVueResCrew = Me.GetViewModel("ResCrew")
        myVueResGroup = Me.GetViewModel("ResGroup")
        myVueResOther = Me.GetViewModel("ResOther")
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
        Dim Sql As String

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Me.InitData("", "", oView, prepMode, prepIDX, strXML)
        SRTIndex = myUtils.cValTN(Me.vBag("srtindex"))

        Sql = "select plnOpReqID,PlnOPID,SRTIndex,PlnResourceID,ResourceName,EmpCode,FullName,Designation,DepName,Qty from plnlistOpReq() where SRTIndex=" & SRTIndex & " and employeeid is not null and PlnResourceID is not null and " & IDField & "=" & frmIDX
        myView.MainGrid.QuickConf(Sql, True, "1-1-2-1-1-0", True)
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnOpReqID"" TABLE=""plnOpReq""><COL KEY=""plnopid,SRTIndex,PlnResourceID,qty""/></BAND>", EnumEditType.acCommandAndEdit)

        Sql = "select plnOpReqID,PlnOPID,SRTIndex,PlnResourceID,ResourceName,Qty from plnlistOpReq() where SRTIndex=" & SRTIndex & " and employeeid is null and PlnResourceID is not null and " & IDField & "=" & frmIDX
        myVueResOther.MainGrid.QuickConf(Sql, True, "2-1", True)
        myVueResOther.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnOpReqID"" TABLE=""plnOpReq""><COL KEY=""plnopid,SRTIndex,PlnResourceID,qty""/></BAND>", EnumEditType.acCommandAndEdit)

        Sql = "select plnOpReqID,PlnOPID,SRTIndex,PlnResourceGroupID,ResGroupName,Resources,Qty from plnlistOpReq() where SRTIndex=" & SRTIndex & " and iscrew=1 and PlnResourceGroupID is not null and " & IDField & "=" & frmIDX
        myVueResCrew.MainGrid.QuickConf(Sql, True, "1-3-0", True)
        myVueResCrew.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnOpReqID"" TABLE=""plnOpReq""><COL KEY=""plnopid,SRTIndex,PlnResourceGroupID,qty""/></BAND>", EnumEditType.acCommandAndEdit)

        Sql = "select plnOpReqID,PlnOPID,SRTIndex,PlnResourceGroupID,ResGroupName,Resources,Qty from plnlistOpReq() where SRTIndex=" & SRTIndex & " and iscrew=0 and PlnResourceGroupID is not null and " & IDField & "=" & frmIDX
        myVueResGroup.MainGrid.QuickConf(Sql, True, "1-3-1", True)
        myVueResGroup.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""plnOpReqID"" TABLE=""plnOpReq""><COL KEY=""plnopid,SRTIndex,PlnResourceGroupID,qty""/></BAND>", EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("paramcode,paramvalue")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dic As New clsCollecString(Of String), ds As DataSet
        VSave = False
        If Me.Validate Then

            dic.Add("OP", "Select plnopid, OpName from plnop where " & IDField & "  = " & frmIDX)
            ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Dim OPDescrip As String = " Routing Operation Requirements for: " & myUtils.cStrTN(ds.Tables("OP").Rows(0)("OpName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, IDField, frmIDX)
                Dim SrtIndex As Integer = myContext.SQL.ParamValue("@SrtIndex", Me.ClientParams)
                myView.MainGrid.SaveChanges(, IDField & "=" & Me.frmIDX & ",SRTIndex=" & SrtIndex)
                myVueResOther.MainGrid.SaveChanges(, IDField & "=" & Me.frmIDX & ",SRTIndex=" & SrtIndex)
                myVueResCrew.MainGrid.SaveChanges(, IDField & "=" & Me.frmIDX & ",SRTIndex=" & SrtIndex)
                myVueResGroup.MainGrid.SaveChanges(, IDField & "=" & Me.frmIDX & ",SRTIndex=" & SrtIndex)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(OPDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(OPDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "rescrew"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ENT=""RESCREW""/>", True)
                Case "resgrp"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ENT=""RESGROUP""/>", True)
                Case "res1"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ENT=""RESEMP""/>", True)
                Case "res2"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ENT=""RESOTHER""/>", True)
            End Select
        End If
        Return Model
    End Function
End Class


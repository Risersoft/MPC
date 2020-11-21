Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmPIDUnitLotModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Lots")
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
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "Select * from PlnListPIDUnit() where PIDUnitID = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)
            Me.sqlForm = "Select PIDUnitID,DescripWo,ProdFileDate,IsCompleted,InmatPlan from PIDUnit where PIDUnitID =0"

            myView.MainGrid.MainConf("rhfactor") = 2
            myView.MainGrid.BindGridData(GenerateData("prodlot", frmIDX), 0)
            myView.MainGrid.QuickConf("", True, "1-1-1-1-1", True)

            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim LotDescrip As String = myUtils.cStrTN(myRow("PIDInfo")) & ", for: " & myUtils.cStrTN(myRow("DescripWO"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PIDUnitID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(LotDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(LotDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "prodlot"
                oRet.Data = GenerateData("ProdLot", myUtils.cValTN(ID))
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "prodlot"
                Dim sql As String = "Select ProdLotID,PIDUnitID, LotNum, SDate, EDate, DateReq, QtyReq from ProdLots Where PIDUnitID = " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select

        Return oRet.Data
    End Function

End Class

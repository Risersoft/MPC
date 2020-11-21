Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSubCatPlanModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Supp")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim vlist As New clsValueList
        vlist.Add("RM", "Raw Material")
        vlist.Add("FA", "Fittings and Accessories")
        vlist.Add("CI", "Control Items")
        vlist.Add("MM", "Machinery and Maintenance")
        vlist.Add("TI", "Testing Instruments")
        vlist.Add("CON", "Consumables")
        Me.ValueLists.Add("Head", vlist)
        Me.AddLookupField("VendorListHead", "Head")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim Sql As String = "Select * from ItemSubCats where SubCatID = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            Sql = "Select Distinct ItemSbHeadID, SbHeadName, UnitName from invListItemSubCats() where ItemSbHeadID=" & myUtils.cValTN(myRow("ItemSbHeadID")) & " order by SbHeadName"
            Me.AddLookupField("ItemSBHeadID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "ItemSBHead").TableName)

            myContext.Provider.ProcessTag(myView, "<VIEW KEY=""ListSubCatSupp""><FILTER KEY=""SubCat""><VALUE VALUE1=""" & frmIDX & """/></FILTER><MODROW><HIDECOLS>VENDORLISTHEAD,PURCHASESPEC</HIDECOLS></MODROW></VIEW>")

            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim SubCatDescrip As String = " Item SubCategory for:" & myUtils.cStrTN(myRow("SubCatName"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "SubCatID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                myContext.Provider.dbConn.CommitTransaction(SubCatDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(SubCatDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim SubCatID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SubCatID", Params))
            Select Case dataKey.Trim.ToLower
                Case "delete"
                    Dim SubCatSuppID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SubCatSuppID", Params))
                    Dim sql As String = "Delete from ItemSubCatSupp where SubCatSuppID=" & myUtils.cValTN(SubCatSuppID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("op", SubCatID)
                Case "refresh"
                    oRet.Data = GenerateData("op", SubCatID)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "op"
                Dim oView As New clsViewModel(myContext)
                myContext.Provider.ProcessTag(oView, "<VIEW KEY=""ListSubCatSupp""><FILTER KEY=""SubCat""><VALUE VALUE1=""" & myUtils.cValTN(ID) & """/></FILTER></VIEW>")
                oRet.Data = oView.MainGrid.myDS
        End Select
        Return oRet.Data
    End Function
End Class
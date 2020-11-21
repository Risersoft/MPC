Imports ut = Infragistics.Win.UltraWinTree
Imports Infragistics.Win.UltraWinGrid
Imports System.Xml

Imports Infragistics.Win.UltraWinTabControl
Partial Public Class myFuncs
    Public DoRefresh As Boolean = False
   
    Public Sub fncSortCostMatHead(ByRef oView As clsWinView, ByVal matheadid As Integer)
        Dim f As frmSort = New frmSort, rEnt As DataRow, dt1 As DataTable

        rEnt = f.Controller.EntityProvider.sysIDEntRow("<SYS ID=""MATHEADID""/>")
        If (Not rEnt Is Nothing) Then
            f.InitData("", "", oView, EnumfrmMode.acEditM, matheadid)

            dt1 = rEnt.Table.Clone
            rEnt = myUtils.CopyOneRow(rEnt, dt1)
            rEnt("sortgroupfield") = ""
            rEnt("sortfield") = "sortindexcost"
            rEnt("selectviewmodrowxml") = "<SQLWHERE2>isforcostingmats=1 and isnull(isold,0)=0</SQLWHERE2>"
            If f.PrepFormEntRow(rEnt) Then
                f.ShowDialog()
                Me.DoRefresh = True
            End If
        End If


    End Sub
    Public Shared Function FormulaFields(IDField As String) As clsCollecString(Of String)
        Dim dic As New clsCollecString(Of String)
        Select Case IDField.Trim.ToUpper
            Case "PLNSTDSEQPROCID"
                dic.Add("NA", "Not Applicable")
                dic.Add("Qty", "Qty")
                dic.Add("ItemQty", "Item Qty")
                'IncProdType is the total production required for this piduroute.
                dic.Add("IncProdType1", "Prod Type1")
                dic.Add("IncProdType2", "Prod Type2")
                dic.Add("IncProdType3", "Prod Type3")
                'TotalProd  = IncProdType1 + IncProdType2 + IncProdType3
            Case "PLNROUTINGID"
                dic.Add("VarTimeIndex", "Var Time Index")
            Case "PLNOPID"
                dic.Add("VarTimeIndex", "Var Time Index")
                dic.Add("StepFactor", "Step Factor")
                dic.Add("OverLapCount", "Overlap Count")
            Case "MATHEADID"
                dic.Add("MatItem", "Matlist Item")
                dic.Add("MatQty", "Matlist Qty")
                dic.Add("Remark", "Matlist Remark")

                dic.Add("CostingItem", "Costing Item")
                dic.Add("CostFactor", "Costing Factor Qty")
                dic.Add("CostFactorRate", "Costing Factor Rate")
        End Select
        Return dic
    End Function
End Class







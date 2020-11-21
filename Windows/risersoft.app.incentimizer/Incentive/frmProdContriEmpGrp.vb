Imports risersoft.app.mxent

Public Class frmProdContriEmpGrp
    Inherits frmMax
    Dim fp As frmProgReport, mProc As clsProdReportProc
    Dim myVueNC As New clsWinView

    Public Sub InitForm()
        myView.SetGrid(UltraGrid1)
        myVueNC.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean

        Return True
    End Function

    Public Overloads Function PrepForm(oView As clsWinView, r1 As DataRow, oProc As clsProdReportProc) As Boolean
        Dim ds As DataSet

        Me.FormPrepared = False
        If Me.BindData(r1) Then
            pView = oView
            mProc = oProc
            fp = pView.fParentWin
            frmIDX = 0

            If Me.BindModel(Me.pView.fParent.Model) Then
                myWinSQL.AssignCmb(fp.dsCombo, "matdep", "", Me.cmb_matdepid)
                myWinSQL.AssignCmb(fp.dsCombo, "proc", "", Me.cmb_PlnProcID)
                myWinSQL.AssignCmb(fp.dsCombo, "shift", "", Me.cmb_shiftID)
                myWinSQL.AssignCmb(fp.dsCombo, "incentive", "", Me.cmb_ProdIncType)


                Dim dt2 As DataTable = r1.Table.DataSet.Tables("contriempgrp")
                myView.mainGrid.BindView(dt2.DataSet, , dt2.DataSet.Tables.IndexOf(dt2))
                myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "plnprocid=" & myUtils.cValTN(myRow("plnprocid")), Me.Controller.SQL.GenerateSQLWhere(r1, "groupnum"), "worktype='IN'")
                myView.mainGrid.QuickConf("", True, "1-4-2-0-0-3", True, "Employee Contribution")
                myView.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY =""numhours,remark""/></BAND>", , Me.btnDelProd)

                myVueNC.mainGrid.BindView(dt2.DataSet, , dt2.DataSet.Tables.IndexOf(dt2))
                myVueNC.mainGrid.QuickConf("", True, "1-4-2-2-2-3", True, "Employee Contribution")
                myVueNC.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY =""numhours"" CAPTION=""Paid""/><COL KEY=""NumHoursNCRU"" CAPTION=""Unpaid""/><COL KEY=""NumHoursNCP"" CAPTION=""Penalty""/><COL KEY=""remark""/></BAND>", , Me.btnDelNC)
                myVueNC.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "plnprocid=" & myUtils.cValTN(myRow("plnprocid")), Me.Controller.SQL.GenerateSQLWhere(r1, "groupnum"), "worktype='NC'")

                If myView.mainGrid.RowCount = 0 Then
                    ds = fp.Model.DatasetCollection("Ref")
                    For Each r2 As DataRow In Me.Controller.Data.CopySelectedRows(myView.mainGrid.myDv.Table, ds.Tables(0).Select, "employeeid", False)
                        For Each c As DataColumn In myRow.Row.Table.Columns
                            If r2.Table.Columns.Contains(c.ColumnName) Then r2(c.ColumnName) = myRow(c.ColumnName)
                        Next
                        r2("worktype") = "IN"
                    Next
                End If
                Me.FormPrepared = True
            End If
        End If

        Return Me.FormPrepared

    End Function

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Dated", Format(fp.vwDate, "dd-MMM-yyyy"), GetType(DateTime), False))
        Dim str1 As String = myUtils.MakeCSV(myView.mainGrid.myDv.Table.Select(myUtils.CombineWhere(False, "plnprocid=" & myUtils.cValTN(myRow("plnprocid")), Me.Controller.SQL.GenerateSQLWhere(myRow.Row, "groupnum"), "worktype = 'IN'")), "employeeid")
        Params.Add(New clsSQLParam("@empidcsv", str1, GetType(Integer), True))
        Dim rr() As DataRow = fp.AdvancedSelect("contriempgrp", Params)

        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In Me.Controller.Data.CopySelectedRows(myView.mainGrid.myDv.Table, rr, "employeeid", True)
                For Each c As DataColumn In myRow.Row.Table.Columns
                    If r1.Table.Columns.Contains(c.ColumnName) Then r1(c.ColumnName) = myRow(c.ColumnName)
                Next
                r1("worktype") = "IN"
                r1("groupnum") = myRow("groupnum")
            Next
        End If
    End Sub

    Private Sub btnAddNC_Click(sender As Object, e As EventArgs) Handles btnAddNC.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Dated", Format(fp.vwDate, "dd-MMM-yyyy"), GetType(DateTime), False))
        Dim str1 As String = myUtils.MakeCSV(myVueNC.mainGrid.myDv.Table.Select(myUtils.CombineWhere(False, "plnprocid=" & myUtils.cValTN(myRow("plnprocid")), Me.Controller.SQL.GenerateSQLWhere(myRow.Row, "groupnum"), "worktype = 'NC'")), "employeeid")
        Params.Add(New clsSQLParam("@empidcsv", str1, GetType(Integer), True))
        Dim rr() As DataRow = fp.AdvancedSelect("contriempgrp", Params)

        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In Me.Controller.Data.CopySelectedRows(myVueNC.mainGrid.myDv.Table, rr, "employeeid", True)
                For Each c As DataColumn In myRow.Row.Table.Columns
                    If r1.Table.Columns.Contains(c.ColumnName) Then r1(c.ColumnName) = myRow(c.ColumnName)
                Next
                r1("worktype") = "NC"
                r1("groupnum") = myRow("groupnum")
            Next
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
    
        Me.InitError()
        myView.mainGrid.CheckValid("numhours,worktype")
        VSave = False
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If fp.SaveModel() Then
                Return True
            Else
                fp.ShowError()
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

End Class

Imports risersoft.app.mxent

Public Class frmProdProgress
    Inherits frmMax
    Dim fp As frmProdLotReport

    Public Sub InitForm()
        myView.SetGrid(UltraGrid1)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        Return True
    End Function
    Public Overloads Function PrepForm(oView As clsWinView, r1 As DataRow) As Boolean
        Dim ds As DataSet

        Me.FormPrepared = False
        If Me.BindData(r1) Then
            pView = oView
            fp = pView.fParentWin
            frmIDX = myRow("prodprogressid")

            If Me.BindModel(Me.pView.fParent.Model) Then
                Dim dt2 As DataTable = r1.Table.DataSet.Tables("contriempind")

                myView.mainGrid.BindView(dt2.DataSet, , dt2.DataSet.Tables.IndexOf(dt2))
                If myUtils.IsInList(myRow("worktype"), "NC") Then
                    myView.mainGrid.QuickConf("", True, "1-4-2-2-2-3", True, "Employee Contribution")
                    myView.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY =""numhours"" CAPTION=""Paid""/><COL KEY=""NumHoursNCRU"" CAPTION=""Unpaid""/><COL KEY=""NumHoursNCP"" CAPTION=""Penalty""/><COL KEY =""remark""/></BAND>", , Me.btnDelProd)
                Else
                    myView.mainGrid.QuickConf("", True, "1-4-2-0-0-3", True, "Employee Contribution")
                    myView.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY =""numhours,remark""/></BAND>", , Me.btnDelProd)
                End If
                myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "prodprogressid=" & frmIDX)

                Dim arr() As String = Split(myUtils.cStrTN(fp.myRow("prodinctype")), "-")
                Dim hasgroup As Boolean = myUtils.IsInList(arr(0), "GR", "OG")
                Me.lblGroupNum.Enabled = hasgroup
                Me.txt_GroupNum.Enabled = hasgroup
                If myUtils.NullNot(myRow("groupnum")) OrElse (Not hasgroup) Then myRow("groupnum") = 1 'in case prodinctype is changed mid way.

                If myUtils.IsInList(arr(0), "OA", "OG") Then
                    Me.btnAddEmp.Enabled = False
                ElseIf r1.RowState = DataRowState.Added Then

                    ds = fp.Model.DatasetCollection("contriempindref").Copy
                    myUtils.ChangeAll(ds.Tables(0).Select, "prodprogressid=" & frmIDX)
                    Me.Controller.Data.CopySelectedRows(myView.mainGrid.myDv.Table, ds.Tables(0).Select, "employeeid", False)

                End If
                Me.FormPrepared = True
            End If
        End If

        Return Me.FormPrepared

    End Function

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Dated", Format(fp.myRow("dated"), "dd-MMM-yyyy"), GetType(DateTime), False))
        Params.Add(New clsSQLParam("@empidcsv", myUtils.MakeCSV(myView.mainGrid.myDv.Table.Select("prodprogressid=" & frmIDX), "employeeid"), GetType(Integer), True))
        Dim rr() As DataRow = fp.AdvancedSelect("addemp", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            For Each r1 As DataRow In Me.Controller.Data.CopySelectedRows(myView.mainGrid.myDv.Table, rr, "employeeid", True)
                r1("worktype") = "IN"
                r1("prodprogressid") = frmIDX
            Next
        End If
    End Sub

    Private Sub txt_Prod_ValueChanged(sender As Object, e As EventArgs) Handles txt_Prod.ValueChanged
        If Me.FormPrepared Then
            Me.reCalc()
            fp.OnIncenProdChanged()
        End If
    End Sub

    Private Sub frmProdProgress_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.reCalc()
    End Sub
    Private Sub reCalc()
        Me.txt_CumuProd.Text = myUtils.cValTN(Me.txt_CumuProdOther.Text) + myUtils.cValTN(Me.txt_Prod.Text)
    End Sub

    Private Sub btnDelAll_Click(sender As Object, e As EventArgs) Handles btnDelAll.Click
        If MsgBox("Are you sure ?" & vbCrLf & "Do you want to Delete All Data ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myUtils.DeleteRows(myView.mainGrid.myDv.Table.Select(myView.mainGrid.myDv.RowFilter))
        End If
    End Sub

End Class
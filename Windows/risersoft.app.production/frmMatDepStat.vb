Imports uwg = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Public Class frmMatDepStat
    Inherits frmMax
    Dim myVueAbsent, myVueVac, myVueComm, myVuePendInd, myVueMacTools, myVueFuture, myVueNCFIR, myVueTAC, myVueMO As New clsWinView

    Public Sub initForm()

        myVueAbsent.SetGrid(Me.UltraGrid2)
        myVueVac.SetGrid(Me.UltraGrid3)
        myVueComm.SetGrid(Me.UltraGrid4)
        myVuePendInd.SetGrid(Me.UltraGrid5)
        myVueMacTools.SetGrid(Me.UltraGrid7)
        myVueFuture.SetGrid(Me.UltraGrid1)
        myVueNCFIR.SetGrid(Me.UltraGrid6)
        myVueTAC.SetGrid(Me.UltraGridTac)
        myVueMO.SetGrid(Me.UltraGridMO)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If myWinApp.Model.MyEmpID > 0 Then
            Dim objModel As frmMatDepStatModel = Me.InitData("frmMatDepStatModel", oView, prepMode, prepIDX, strXML)
            If Me.BindModel(objModel, oView) Then

            End If
            Me.dttodaydate.Value = Format(Now, "dd-MMM-yyyy")
            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean

        If MyBase.BindModel(NewModel, oView) Then
            myVueAbsent.PrepEdit(Me.Model.GridViews("Absent"))
            myVueAbsent.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("EmpCode", False, False)
            myVueVac.PrepEdit(Me.Model.GridViews("Vac"), Me.btnAddVac, )
            myVueComm.PrepEdit(Me.Model.GridViews("Comm"))
            myVuePendInd.PrepEdit(Me.Model.GridViews("PendInd"))
            For Each grow As uwg.UltraGridRow In myVuePendInd.mainGrid.myGrid.Rows
                colorizeurginditem(grow)
            Next
            myVueMacTools.PrepEdit(Me.Model.GridViews("MacTools"), Me.btnAddMac, Me.btnDelMac)
            myVueFuture.PrepEdit(Me.Model.GridViews("Future"), Me.btnAddFut, Me.btnDelFut)
            myVueNCFIR.PrepEdit(Me.Model.GridViews("NCFIR"))
            For Each gRow As uwg.UltraGridRow In myVueNCFIR.mainGrid.myGrid.Rows
                gRow.Cells("ncdate").Activation = uwg.Activation.NoEdit
                gRow.Cells("ProdSerialID").Activation = uwg.Activation.NoEdit
            Next
            myVueTAC.PrepEdit(Me.Model.GridViews("TAC"))
            myVueMO.PrepEdit(Me.Model.GridViews("MO"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()

    End Function

    Private Sub btnDelVac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelVac.Click
        If Not myVueVac.mainGrid.myGrid.ActiveRow Is Nothing Then
            If myUtils.cStrTN(myVueVac.mainGrid.myGrid.ActiveRow.Cells("vaccode").Value).Trim.Length = 0 Then
                myVueVac.mainGrid.ButtonAction("del")
            Else
                MsgBox("This vacancy has been taken up by Personnel department. Pl contact them for removal", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnUrgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUrgent.Click
        If Not myVuePendInd.mainGrid.myGrid.ActiveRow Is Nothing Then
            myVuePendInd.mainGrid.myGrid.ActiveRow.Cells("isurgent").Value = True
            myVuePendInd.mainGrid.myGrid.UpdateData()
            colorizeurginditem(myVuePendInd.mainGrid.myGrid.ActiveRow)
        End If

    End Sub

    Private Sub btnNotUrgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotUrgent.Click
        If Not myVuePendInd.mainGrid.myGrid.ActiveRow Is Nothing Then
            myVuePendInd.mainGrid.myGrid.ActiveRow.Cells("isurgent").Value = False
            myVuePendInd.mainGrid.myGrid.UpdateData()
            colorizeurginditem(myVuePendInd.mainGrid.myGrid.ActiveRow)
        End If
    End Sub
    Private Sub colorizeurginditem(ByVal gRow As uwg.UltraGridRow)

        If myUtils.cBoolTN(gRow.Cells("isurgent").Value) Then
            gRow.Appearance.BackColor = System.Drawing.Color.Red
        Else
            gRow.Appearance.BackColor = Nothing
        End If
    End Sub

    Private Sub btnADDNCFIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADDNCFIR.Click
        Dim rr() As DataRow, gRow As uwg.UltraGridRow, vList As Infragistics.Win.ValueList

        rr = Me.Controller.AdvancedSelect("<SYS ID=""pidunitid""/>", False)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            gRow = myVueNCFIR.mainGrid.myGrid.DisplayLayout.Bands(0).AddNew()
            gRow.Cells("pidunitid").Value = rr(0)("pidunitid")
            gRow.Cells("WOInfo").Value = rr(0)("WOInfo")
            gRow.Cells("partyname").Value = rr(0)("netname")
            gRow.Cells("DescripWO").Value = rr(0)("DescripWO")

            vList = myWinUtils.PerCellVlistsql(gRow.Cells("ProdSerialID"), "select ProdSerialID,ProdSerialNum from plnListProdSerial() where PIDUnitID=" & myUtils.cValTN(rr(0)("pidunitid")) & " order by ProdSerialNum")

            myVueNCFIR.mainGrid.myGrid.UpdateData()
        End If

    End Sub

    Private Sub btnDelNCFIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelNCFIR.Click
        If Not myVueNCFIR.mainGrid.myGrid.ActiveRow Is Nothing Then
            If Format(myVueNCFIR.mainGrid.myGrid.ActiveRow.Cells("ncdate").Value, "dd-MMM-yyyy") = Format(Now, "dd-MMM-yyyy") Then
                myVueNCFIR.mainGrid.ButtonAction("del")
            Else
                MsgBox("This Comment cannot be deleted by You. Pl contact Quality department for removal", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub
End Class
Imports risersoft.app.mxform
Imports risersoft.shared.portable
Imports  Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Public Class frmMatList1Copy
    Inherits frmMax
    Friend fBag As New clsConf, matindex As Integer

    Public Sub initForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String, r As DataRow
        Dim uTab As UltraTab, f As frmMatList1Tab

        Me.FormPrepared = False
        Dim objModel As frmMatList1CopyModel = Me.InitData("frmMatList1CopyModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If prepMode = EnumfrmMode.acEditM Then
                Me.Text = myUtils.cStrTN(myRow("PidInfo"))
                Me.UltraTabControl1.Tabs.Clear()
                Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize

                Dim dt As DataTable = Me.Model.DatasetCollection("matheadtype").Tables(0)
                fBag.Clear()
                For Each r In dt.Rows
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@matindex", myUtils.cValTN(matindex), GetType(Integer), False))
                    Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(frmIDX), GetType(Integer), False))
                    Params.Add(New clsSQLParam("@headtypeid", myUtils.cValTN(r("HeadTypeId")), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("matlistmathead", Params)
                    If oRet.Success Then
                        f = New frmMatList1Tab
                        uTab = Me.UltraTabControl1.Tabs.Add()
                        uTab.Key = myUtils.cValTN(r("headtypeid")) : uTab.Text = Replace(r("headtype"), "&", "&&")
                        f.Visible = True : f.TopLevel = False : f.Dock = DockStyle.Fill
                        f.FormBorderStyle = FormBorderStyle.None
                        fBag.Add(myUtils.cValTN(r("headtypeid")), f)

                        f.myView.mainGrid.MainConf("RHFACTOR") = 2 : f.myView.mainGrid.MainConf("HeadFACTOR") = 2.1
                        f.myView.myMode = EnumViewMode.acSelectM : f.myView.MultiSelect = True
                        f.myView.mainGrid.BindView(oRet.Data, , 0)
                        f.myView.mainGrid.QuickConf("", True, "1.5-1-4-1.5-2", True)

                        f.myHead.mainGrid.MainConf("ColHeaders") = False
                        f.myHead.mainGrid.BindView(oRet.Data, , 1)
                        f.myHead.mainGrid.QuickConf("", True, "1", True, "Unused Heads")

                        uTab.TabPage.Controls.Add(f)
                    End If
                Next
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
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

    Private Sub btnSelHeadAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelHeadAll.Click
        Dim fTab As frmMatList1Tab
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)
        myUtils.ChangeAll(fTab.myView.mainGrid.myDv.Table.Select, "sysincl=1")
        fTab.myView.mainGrid.HighlightRows()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Dim fTab As frmMatList1Tab

        For Each de In Me.fBag
            fTab = CType(de.Value, frmMatList1Tab)
            myUtils.ChangeAll(fTab.myView.mainGrid.myDv.Table.Select, "sysincl=1")
            fTab.myView.mainGrid.HighlightRows()
        Next de
    End Sub

    Private Sub btnHeadUnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeadUnSelect.Click
        Dim fTab As frmMatList1Tab
        Dim c As Integer = CInt(myUtils.cValTN(Me.UltraTabControl1.SelectedTab.Key))
        fTab = fBag(c)

        myUtils.ChangeAll(fTab.myView.mainGrid.myDv.Table.Select, "sysincl=0")
        fTab.myView.mainGrid.HighlightRows()
    End Sub

    Private Sub btnUnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnSelectAll.Click
        Dim fTab As frmMatList1Tab

        For Each de In Me.fBag
            fTab = CType(de.Value, frmMatList1Tab)
            myUtils.ChangeAll(fTab.myView.mainGrid.myDv.Table.Select, "sysincl=0")
            fTab.myView.mainGrid.HighlightRows()
        Next de
    End Sub
End Class
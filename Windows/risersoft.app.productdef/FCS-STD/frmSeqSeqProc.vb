Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.shared

Public Class frmSeqSeqProc
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim dv As DataView

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmSeqSeqProcModel = Me.InitData("frmSeqSeqProcModel", oView, prepMode, prepIDX, strXML)

        If Me.BindModel(objModel, oView) Then
            codesys.SetConf(Me.dsCombo.Tables("plnliststdseqproc()"), Me.cmb_PlnStdSeqProcID, Me.cmb_PlnProcID)
            If frmMode = EnumfrmMode.acEditM Then
                Me.cmb_PlnStdSeqProcID.Value = myRow("plnstdseqprocid")
                Me.codesys.HandleCombo(Me.cmb_PlnStdSeqProcID, EnumWantEvent.acForceEvent)
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            dv = myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSeqProcID1, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSeqProcID2, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSeqProcID3, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSeqProcID4, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSeqProcID5, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "seqproc", "", Me.cmb_PrevSEqProcID6, , 1)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData Then
            If Me.SaveModel() Then
                Return True
            End If
            Me.Refresh()
        Else
            Me.SetError()
        End If
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        dv.RowFilter = "plnstdseqprocid <>" & myUtils.cValTN(Me.cmb_PlnStdSeqProcID.Value)
    End Sub
End Class


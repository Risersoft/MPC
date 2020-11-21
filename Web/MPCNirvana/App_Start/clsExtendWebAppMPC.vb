Imports risersoft.app
Imports risersoft.app.mxform
Imports risersoft.app.mxform.gst
Imports risersoft.app.mxform.mpc
Imports risersoft.shared
Imports risersoft.shared.cloud
Imports risersoft.shared.web
Imports risersoft.shared.web.mvc

Public Class clsExtendWebAppMPC
    Inherits clsExtendWebAppBase


    Public Overrides Function NewDBName() As String
        Return "mxnirvanadb"
    End Function


    Public Overrides Function ProgramCode() As String
        Return "mxmpc"
    End Function

    Public Overrides Function ProgramName() As String
        Return "MPCNirvana"

    End Function

    Public Overrides Function StartupAppCode() As String
        Return "nmpc"
    End Function

    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmProdLotModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function

    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        If dicReportModelProvider Is Nothing Then
            dicReportModelProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicReportModelProvider, GetType(reports.erp.invReportDataProvider).Assembly, GetType(clsReportDataProviderBase))
        End If
        Return dicReportModelProvider

    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function


    Public Overrides Function HelpSite() As String
        Throw New NotImplementedException()
    End Function
End Class

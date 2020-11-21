Imports System.Net
Imports System.Security.Claims
Imports System.Web.Helpers
Imports System.Web.Hosting
Imports System.Web.Http
Imports System.Web.Optimization
Imports AutoMapper
Imports risersoft.API.GSTN
Imports risersoft.app.mxform.gst
Imports risersoft.shared.web
Imports risersoft.shared.web.mvc
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        Dim oApp = New clsMvcWebApp(New clsExtendWebAppMPC)
        GlobalWeb.myWebApp = oApp
        HostingEnvironment.RegisterVirtualPathProvider(oApp.fncVirutalPathProvider())

        'myFuncs2.InitializeMapper()
        ControllerBuilder.Current.SetControllerFactory(GetType(MyControllerFactory))
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier
        GSTNConstants.base_path = Server.MapPath("/bin/")
        Try
            GSTNConstants.publicip = New WebClient().DownloadString("http://ipinfo.io/ip").Trim
        Catch ex As Exception
            GSTNConstants.publicip = "11.10.1.1"

        End Try
    End Sub
End Class

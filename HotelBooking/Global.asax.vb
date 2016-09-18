Imports System.Web.Optimization
<Assembly: log4net.Config.XmlConfigurator(Watch:=True)> 
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
        Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsNothing(Session) And Not IsNothing(ConstantsForCommon.SessionParam.SessionUserId) Then
            Logger.LogUserLogoutOnSessionEnd(Session(ConstantsForCommon.SessionParam.SessionUserId), Session(ConstantsForCommon.SessionParam.SessionId), "-", "-")
            Session.Remove(ConstantsForCommon.SessionParam.SessionUserId)
            Session.Remove(ConstantsForCommon.SessionParam.SessionUserName)
            Session.Remove(ConstantsForCommon.SessionParam.SessionUserPass)
            Session.Remove(ConstantsForCommon.SessionParam.SessionExpFlg)
            Session.Remove(ConstantsForCommon.SessionParam.SessionId)
        End If
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class

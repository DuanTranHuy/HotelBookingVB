Imports System.Web.Mvc

Namespace Controllers
    Public Class UserProfileController
        Inherits Controller

        ' GET: UserProfile
        Function Index() As ActionResult
            Return View()
        End Function
                Public Function UserProfile(returnUrl As String) As ActionResult
            ViewBag.ReturnUrl = returnUrl
            Return View()
        End Function
    End Class
End Namespace
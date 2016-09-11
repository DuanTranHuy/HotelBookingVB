Imports System.Web.Mvc

Namespace Controllers
    Public Class ErrorScreenController
        Inherits Controller

        ' GET: ErrorScreen
        Function Index() As ActionResult
            Return View()
        End Function
        Public Function ErrorScreen(returnUrl As String) As ActionResult
            ViewData!ReturnUrl = returnUrl
            Return View()
        End Function
    End Class
End Namespace
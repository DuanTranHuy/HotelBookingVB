Imports System.Web.Mvc

Namespace Controllers
    Public Class AccountController
        Inherits Controller

        ' GET: Account
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
Imports System.Web.Mvc
Imports Entities
Imports Repositories

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function
        '
        ' GET: /Account/Login
        <AllowAnonymous>
        Public Function Login(returnUrl As String) As ActionResult
            ViewData!ReturnUrl = returnUrl
            Return View()
        End Function
        ''' <remarks></remarks>
        <HttpPost(), ActionName(ConstantsForCommon.ScreenName.Login)>
        Function Login(ByVal username As String, ByVal password As String) As JsonResult
            Dim obj As New StatusObjForJsonResult
            Dim repo As New LoginRepository()
            Dim functionname As String = CommonInfo.mdfPgm(ConstantsForCommon.ScreenId.Login)
            Try
                'Input check
                '2.2 [8.Error Check Processing],No1
                If String.IsNullOrWhiteSpace(username) Then
                    obj.Status = 1
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM001)
                    Return Json(obj)
                End If
                '2.2 [8.Error Check Processing],No2
                If String.IsNullOrWhiteSpace(password) Then
                    obj.Status = 2
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM002)
                    Return Json(obj)
                End If
                If CommonInfo.IsValidEmailFormat(username) = False Then
                    Dim cword As New Login()
                    cword = repo.Login(username)
                    If cword Is Nothing Then
                        obj.Status = 1
                        obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM003)
                        Return Json(obj)
                    End If
                    If cword.Password <> password Then
                        obj.Status = 2
                        obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM004)
                        Return Json(obj)
                    End If
                End If
            Catch ex As Exception
                Logger.LogException(ex)
                obj.Status = 0
                obj.RedirectTo = Url.Action(ConstantsForCommon.ErrorParam.SystemErrors, ConstantsForCommon.ErrorParam.Errors)
            End Try
            obj.Status = 0
            obj.RedirectTo = Url.Action("", "")
            Return Json(obj)
        End Function
    End Class
End Namespace
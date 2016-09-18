Imports System.Web.Mvc
Imports Entities
Imports Repositories

Namespace Controllers
    Public Class SignUpController
        Inherits Controller
        ' GET: SignUp
        Function Index() As ActionResult
            Return View()
        End Function
        ' GET: SignUp
        <AllowAnonymous>
        Public Function SignUp(returnUrl As String) As ActionResult
            ViewData!ReturnUrl = returnUrl
            Return View()
        End Function
        ''' <remarks></remarks>
        <HttpPost(), ActionName(ConstantsForCommon.ScreenName.SignUp)>
        Function SignUp(ByVal userName As String, ByVal email As String, ByVal confirmEmail As String, ByVal password As String,
                        ByVal confirmPassword As String) As JsonResult
            Dim obj As New StatusObjForJsonResult
            Dim repo As New SignUpRepository()
            Dim ctdWks As String = CommonInfo.ctdWks()
            Dim actFlg As String = CommonInfo.actFlg()
            Dim ctdPgm As String = CommonInfo.mdfPgm(ConstantsForCommon.ScreenName.SignUp)
            Dim isExistAccount As Integer
            Dim isExistEmail As Integer

            Try
                'Input check
                '2.2 [8.Error Check Processing],No1
                If String.IsNullOrWhiteSpace(userName) Then
                    obj.Status = 1
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM001)
                    Return Json(obj)
                End If
                '2.2 [8.Error Check Processing],No2
                If String.IsNullOrWhiteSpace(email) Then
                    obj.Status = 2
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM002)
                    Return Json(obj)
                End If
                If CommonInfo.IsValidEmailFormat(email) = False Then
                    obj.Status = 2
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM003)
                    Return Json(obj)
                End If
                '2.2 [8.Error Check Processing],No3
                If String.IsNullOrWhiteSpace(confirmEmail) Then
                    obj.Status = 3
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM004)
                    Return Json(obj)
                End If
                If email <> confirmEmail Then
                    obj.Status = 3
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM005)
                    Return Json(obj)
                End If
                '2.2 [8.Error Check Processing],No4
                If String.IsNullOrWhiteSpace(password) Then
                    obj.Status = 4
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM006)
                    Return Json(obj)
                End If
                '2.2 [8.Error Check Processing],No5
                If String.IsNullOrWhiteSpace(confirmPassword) Then
                    obj.Status = 5
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM007)
                    Return Json(obj)
                End If
                If password <> confirmPassword Then
                    obj.Status = 5
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM008)
                    Return Json(obj)
                End If
                isExistAccount = repo.CheckExistAccount(userName)

                If isExistAccount <> 0 Then
                    obj.Status = 1
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM009)
                    Return Json(obj)
                End If

                isExistEmail = repo.CheckExistEmail(email)
                If isExistEmail <> 0 Then
                    obj.Status = 2
                    obj.Message = Util.GetMessageFromResource(ConstantsForCommon.SignUpM010)
                    Return Json(obj)
                End If

                Dim cword As Boolean
                cword = repo.SignUp(actFlg, ctdWks, ctdPgm, userName, email, CommonInfo.Md5(password))
                If cword = False Then
                    obj.Status = 0
                    obj.RedirectTo = Url.Action(ConstantsForCommon.ErrorParam.Errors, ConstantsForCommon.ErrorParam.SystemErrors)
                    Return Json(obj)
                End If

 
            Catch ex As Exception
                Logger.LogException(ex)
                obj.Status = 0
                obj.RedirectTo = Url.Action(ConstantsForCommon.ErrorParam.Errors, ConstantsForCommon.ErrorParam.SystemErrors)
            End Try
            obj.Status = 0
            obj.RedirectTo = Url.Action(ConstantsForCommon.ScreenName.Home, ConstantsForCommon.HomeParam.Home)
            Return Json(obj)
        End Function
    End Class
End Namespace
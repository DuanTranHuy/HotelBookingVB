Imports System.Web.Mvc
Imports Entities
Imports Repositories
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security

    <Authorize>
    Public Class LoginController
        Inherits Controller
        Private _signInManager As ApplicationSignInManager
        Private _userManager As ApplicationUserManager
        Public Property UserManager() As ApplicationUserManager
            Get
                Return If(_userManager, HttpContext.GetOwinContext().GetUserManager(Of ApplicationUserManager)())
            End Get
   
            Private Set
                _userManager = Value
            End Set
        End Property
            Public Function Authorize() As ActionResult
        Dim claims = New ClaimsPrincipal(User).Claims.ToArray()
        Dim identity = New ClaimsIdentity(claims, "Bearer")
        AuthenticationManager.SignIn(identity)
        Return New EmptyResult()
    End Function
            Public Property SignInManager() As ApplicationSignInManager
        Get
            Return If(_signInManager, HttpContext.GetOwinContext().[Get](Of ApplicationSignInManager)())
        End Get
        Private Set
            _signInManager = value
        End Set
    End Property
        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

    ' GET: /Account/Login
    <AllowAnonymous>
    Public Function Login(returnUrl As String) As ActionResult
        ViewBag.ReturnUrl = returnUrl
        Return View()
    End Function
        <HttpPost(), ActionName(ConstantsForCommon.ScreenName.Login)>
        Function UserInfo(ByVal username As String, ByVal password As String) As ActionResult
            ViewBag.ShowHeader = False

            Return View()
        End Function
        ''' <remarks></remarks>
        <HttpPost(), ActionName(ConstantsForCommon.ScreenName.Login)>
        Function Login(ByVal username As String, ByVal password As String) As JsonResult
            Dim obj As New StatusObjForJsonResult
            Dim repo As New LoginRepository()
            Dim functionname As String = CommonInfo.mdfPgm(ConstantsForCommon.ScreenId.Login)
            Dim sessionId As String = String.Empty
            If IsNothing(Session(ConstantsForCommon.SessionParam.SessionId)) Then
                sessionId = Web.HttpContext.Current.Session.SessionID
            End If
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
                    Dim user As New Login()
                    user = repo.Login(username)
                    If user Is Nothing Then
                        obj.Status = 1
                        obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM003)
                        Return Json(obj)
                    End If
                    If user.Password <> CommonInfo.Md5(password) Then
                        obj.Status = 2
                        obj.Message = Util.GetMessageFromResource(ConstantsForCommon.LoginM004)
                        Return Json(obj)
                    End If
                    Logger.LogUserLogin(user.Id, sessionId, CommonInfo.GetPCName(), CommonInfo.mdfWks())
                    Session.Add(ConstantsForCommon.SessionParam.SessionUserId, user.Id)
                    Session.Add(ConstantsForCommon.SessionParam.SessionUserName, username)
                    Session.Add(ConstantsForCommon.SessionParam.SessionUserPass, password)
                    Session.Add(ConstantsForCommon.SessionParam.SessionFullName, user.FullName)
                    Session.Add(ConstantsForCommon.SessionParam.SessionId, sessionId)
                End If

            Catch ex As Exception
                Logger.LogException(ex)
                obj.Status = 0
                obj.RedirectTo = Url.Action(ConstantsForCommon.ErrorParam.SystemErrors, ConstantsForCommon.ErrorParam.Errors)
            End Try
            obj.Status = 0
            obj.RedirectTo = Url.Action(ConstantsForCommon.ScreenName.Home, ConstantsForCommon.HomeParam.Home)
            Return Json(obj)
        End Function
        ''' <summary>
        ''' Log out
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function LogOut() As ActionResult
            Try
                Logger.LogUserLogout(Session(ConstantsForCommon.SessionParam.SessionUserId), Session(ConstantsForCommon.SessionParam.SessionId), CommonInfo.GetPCName(), CommonInfo.mdfWks())
            Catch ex As Exception
                Logger.LogException(ex)
            Finally
                Util.RemoveSessionHbs(True)
            End Try
            Return Redirect(Request.Url.ToString())
        End Function

            '
    ' POST: /Account/ExternalLogin
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Function ExternalLogin(provider As String, returnUrl As String) As ActionResult
        ' Request a redirect to the external login provider
        Return New ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Login", New With {
            .ReturnUrl = returnUrl
        }))
    End Function
        '
    ' GET: /Account/ExternalLoginCallback
    <AllowAnonymous>
    Public Async Function ExternalLoginCallback(returnUrl As String) As Task(Of ActionResult)
        Dim identity = AuthenticationManager.GetExternalIdentity(DefaultAuthenticationTypes.ExternalCookie)
        Dim accessToken = identity.FindFirstValue("FacebookAccessToken")
        Dim loginInfo = Await  AuthenticationManager.GetExternalLoginInfoAsync()
        Dim repo As New LoginRepository()
            Dim functionname As String = CommonInfo.mdfPgm(ConstantsForCommon.ScreenId.Login)
            Dim sessionId As String = String.Empty
            If IsNothing(Session(ConstantsForCommon.SessionParam.SessionId)) Then
                sessionId = Web.HttpContext.Current.Session.SessionID
            End If
        Logger.LogUserLogin(loginInfo.Login.ProviderKey, sessionId, CommonInfo.GetPCName(), CommonInfo.mdfWks())
        Session.Add(ConstantsForCommon.SessionParam.SessionUserId, loginInfo.Login.ProviderKey)
        Session.Add(ConstantsForCommon.SessionParam.SessionUserName, loginInfo.DefaultUserName)
        Session.Add(ConstantsForCommon.SessionParam.SessionUserPass, accessToken)
        Session.Add(ConstantsForCommon.SessionParam.SessionFullName, identity.Name)
        Session.Add(ConstantsForCommon.SessionParam.SessionId, sessionId)
        If loginInfo Is Nothing Then
            Return RedirectToAction("Login")
        End If

        ' Sign in the user with this external login provider if the user already has a login
        Dim result = Await SignInManager.ExternalSignInAsync(loginInfo, isPersistent:=False)
        Select Case result
            Case SignInStatus.Success
                Return RedirectToLocal(returnUrl)
            Case Else
                ' If the user does not have an account, then prompt the user to create an account
                ViewBag.ReturnUrl = returnUrl
                ViewBag.LoginProvider = loginInfo.Login.LoginProvider
                Return View("ExternalLoginConfirmation", New ExternalLoginConfirmationViewModel() With {
                    .Email = loginInfo.Email
                })
        End Select
        
                

    End Function


    ' POST: /Account/LogOff
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Function LogOff() As ActionResult
        AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie)
        Return Redirect(Request.Url.ToString())
    End Function

    '
    ' GET: /Account/ExternalLoginFailure
    <AllowAnonymous>
    Public Function ExternalLoginFailure() As ActionResult
        Return View()
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If _userManager IsNot Nothing Then
                _userManager.Dispose()
                _userManager = Nothing
            End If
            If _signInManager IsNot Nothing Then
                _signInManager.Dispose()
                _signInManager = Nothing
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub
#Region "Helpers"
    ' Used for XSRF protection when adding external logins
    Private Const XsrfKey As String = "XsrfId"

    Private ReadOnly Property AuthenticationManager() As IAuthenticationManager
        Get
            Return HttpContext.GetOwinContext().Authentication
        End Get
    End Property

    Private Sub AddErrors(result As IdentityResult)
        For Each [error] In result.Errors
            ModelState.AddModelError("", [error])
        Next
    End Sub

    Private Function RedirectToLocal(returnUrl As String) As ActionResult
        If Url.IsLocalUrl(returnUrl) Then
            Return Redirect(returnUrl)
        End If
        Return RedirectToAction("Home", "Home")
    End Function

    Friend Class ChallengeResult
        Inherits HttpUnauthorizedResult
        Public Sub New(provider As String, redirectUri As String)
            Me.New(provider, redirectUri, Nothing)
        End Sub

        Public Sub New(provider As String, redirect As String, user As String)
            LoginProvider = provider
            RedirectUri = redirect
            UserId = user
        End Sub

        Public Property LoginProvider As String
        Public Property RedirectUri As String
        Public Property UserId As String

        Public Overrides Sub ExecuteResult(context As ControllerContext)
            Dim properties = New AuthenticationProperties() With {
                .RedirectUri = RedirectUri
            }
            If UserId IsNot Nothing Then
                properties.Dictionary(XsrfKey) = UserId
            End If
            context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider)
        End Sub

    End Class
#End Region
    End Class

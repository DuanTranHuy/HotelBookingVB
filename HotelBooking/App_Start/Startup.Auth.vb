Imports System.Net.Http
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.Facebook
Imports Microsoft.Owin.Security.Google
Imports Owin

Partial Public Class Startup
    ' For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' Configure the db context, user manager and signin manager to use a single instance per request
        app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)
        app.CreatePerOwinContext(Of ApplicationSignInManager)(AddressOf ApplicationSignInManager.Create)

        ' Enable the application to use a cookie to store information for the signed in user
        ' and to use a cookie to temporarily store inforation about a user logging in with a third party login provider
        ' Configure the sign in cookie
        ' OnValidateIdentity enables the application to validate the security stamp when the user logs in.
        ' This is a security feature which is used when you change a password or add an external login to your account.
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .Provider = New CookieAuthenticationProvider() With {
                .OnValidateIdentity = SecurityStampValidator.OnValidateIdentity(Of ApplicationUserManager, ApplicationUser)(
                    validateInterval:=TimeSpan.FromMinutes(30),
                    regenerateIdentity:=Function(manager, user) user.GenerateUserIdentityAsync(manager))},
            .LoginPath = New PathString("/Login/Login")})

        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
        app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5))

        ' Enables the application to remember the second login verification factor such as phone or email.
        ' Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
        ' This is similar to the RememberMe option when you log in.
        app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie)

        ' Uncomment the following lines to enable logging in with third party login providers
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:="794245959861-1qi3r089uiigbdl0a2kcao5b40t7246u.apps.googleusercontent.com",
        '    clientSecret:="Ck9xvA0FeW5GFE57pkC2allJ")

        'app.UseTwitterAuthentication(
        '   consumerKey:="",
        '   consumerSecret:="")

        Dim facebookOptions = New FacebookAuthenticationOptions()
        facebookOptions.AppId = "1667139900267838"
        facebookOptions.AppSecret = "a09c95760deb56af5bdfac48f39d88e9"
        facebookOptions.Scope.Add("email")
        facebookOptions.Scope.Add("public_profile")
        facebookOptions.BackchannelHttpHandler = New FacebookBackChannelHandler()
        facebookOptions.UserInformationEndpoint = "https://graph.facebook.com/v2.4/me?fields=id,name,email,first_name,last_name"
        facebookOptions.Provider = New FacebookAuthenticationProvider() With {
            .OnAuthenticated = Function(context)
                                   context.Identity.AddClaim(New System.Security.Claims.Claim("FacebookAccessToken", context.AccessToken))
                                   Return Task.FromResult(0)
                               End Function
        }
        app.UseFacebookAuthentication(facebookOptions)


        Dim googleOptions = New GoogleOAuth2AuthenticationOptions()
        googleOptions.ClientId = "794245959861-1qi3r089uiigbdl0a2kcao5b40t7246u.apps.googleusercontent.com"
        googleOptions.ClientSecret = "Ck9xvA0FeW5GFE57pkC2allJ"
        googleOptions.CallbackPath = New PathString("/oauth-redirect/google")
        googleOptions.Provider = New GoogleOAuth2AuthenticationProvider() With {
            .OnAuthenticated = Function(context)
                                   context.Identity.AddClaim(New System.Security.Claims.Claim("GoogleAccessToken", context.AccessToken))
                                   Return Task.FromResult(0)
                               End Function
        }

        app.UseGoogleAuthentication(googleOptions)
    End Sub
    Public Class FacebookBackChannelHandler
        Inherits HttpClientHandler
        Protected Overrides Function SendAsync(request As HttpRequestMessage, cancellationToken As System.Threading.CancellationToken) As System.Threading.Tasks.Task(Of HttpResponseMessage)
            If Not request.RequestUri.AbsolutePath.Contains("/oauth") Then
                request.RequestUri = New Uri(request.RequestUri.AbsoluteUri.Replace("?access_token", "&access_token"))
            End If

            Return MyBase.SendAsync(request, cancellationToken)
        End Function
    End Class
    Const XmlSchemaString As String = "http://www.w3.org/2001/XMLSchema#string"
End Class

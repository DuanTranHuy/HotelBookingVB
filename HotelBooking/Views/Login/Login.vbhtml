@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    ViewBag.Title = "Login"
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Travel Agency - HTML5 Booking template</title>

    <!-- Bootstrap -->
    <link href="~/Content/HBThemes/dist/css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/assets/css/custom.css" rel="stylesheet" media="screen">

    <!-- Animo css-->
    <link href="~/Content/HBThemes/plugins/animo/animate+animo.css" rel="stylesheet" media="screen">

    <link href="~/Content/HBThemes/examples/carousel/carousel.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="assets/js/html5shiv.js"></script>
      <script src="assets/js/respond.min.js"></script>
    <![endif]-->
    <!-- Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Lato:400,100,100italic,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:700,400,300,300italic' rel='stylesheet' type='text/css'>
    <!-- Font-Awesome -->
    <link rel="stylesheet" type="text/css" href="assets/css/font-awesome.css" media="screen" />
    <!--[if lt IE 7]><link rel="stylesheet" type="text/css" href="assets/css/font-awesome-ie7.css" media="screen" /><![endif]-->
    <!-- Load jQuery -->
    <script src="~/Content/HBThemes/assets/js/jquery.v2.0.3.js"></script>




</head>
<body>

    <!-- 100% Width & Height container  -->

    <div Class="login-fullwidith">

        <!-- Login Wrap  -->
        <div Class="login-wrap">
            <img src = "images/logo.png" Class="login-img" alt="logo" /><br />
            <div Class="login-c1">
                <div Class="cpadding50">
                    <input type = "text" Class="form-control logpadding" id="txtUsername" placeholder="Username">
                    <Label id = "lbl_username_fail" Class="label-error"></label>
                    <br />
                    <input type = "text" Class="form-control logpadding" id="txtPassword" placeholder="Password">
                    <Label id = "lbl_password_fail" Class="label-error"></label>
                    <br />
                </div>
            </div>
            <div Class="login-c2">
                <div Class="logmargfix">
                    <div Class="chpadding50">
                        <div Class="alignbottom">
                            <Button Class="btn-search4" type="submit" id="btnLogin">Submit</button>
                        </div>

                        <div id = "fb-root" ></div>
                                    <div Class="alignbottom2">
                            <div Class="checkbox">
                                <Label>
                                            <input type = "checkbox" > Remember
                                </label>
                            </div>
                            <div Class="fb-login-button" data-max-rows="4" data-size="xlarge" data-show-faces="false" data-auto-logout-link="true"></div>
                            @Using Html.BeginForm("ExternalLogin", "Login", New With {.ReturnUrl = "/"}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                                @Html.AntiForgeryToken()
                                @<div id="socialLoginList">
                                    <p>
                                        @For Each p As AuthenticationDescription In loginProviders
                                            @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Log in using your @p.Caption account">@p.AuthenticationType</button>
                                        Next
                                    </p>
                                </div>
                            End Using
                        </div>
                    </div>
                </div>
            </div>
            <div class="login-c3">
                <div class="left"><a href="#" class="whitelink"><span></span>Website</a></div>
                <div class="right"><a href="#" class="whitelink">Lost password?</a></div>
            </div>
        </div>
        <!-- End of Login Wrap  -->

    </div>
    End Using
    <!-- End of Container  -->
    <!-- Javascript  -->
    <script src="~/Content/HBThemes/assets/js/initialize-loginpage.js"></script>
    <script src="~/Content/HBThemes/assets/js/jquery.easing.js"></script>
    <!-- Load Animo -->
    <script src="~/Content/HBThemes/plugins/animo/animo.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            //$.ajaxSetup({ cache: true });
            //(function (d, s, id) {
            //    var js, fjs = d.getElementsByTagName(s)[0];
            //    if (d.getElementById(id)) return;
            //    js = d.createElement(s); js.id = id;
            //    js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.7&appId=1667139900267838";
            //    fjs.parentNode.insertBefore(js, fjs);
            //}(document, 'script', 'facebook-jssdk'));

            $(function () {
                $("#txtUsername").focus();

            });
        });
        
            $(document).keypress(function (event) {
                var keycode = (event.keyCode ? event.keyCode : event.which);
                if (keycode == '13') {
                    if (Validate()) {
                        Login();
                    } else {
                        return false;
                    }
                }
            });
            // Kết quả từ FB.getLoginStatus().
            //function statusChangeCallback(response) {
            //    if (response.status === 'connected') {
                    @*window.location = '@Url.Action("Home", "Home")';*@
                    //console.log(response.authResponse.accessToken);
                    _i();
            //    } else if (response.status === 'not_authorized') {
            //        // Người dùng đăng nhập từ một địa chỉ khác.
            //        document.getElementById('status').innerHTML = 'Please log ' +
            //          'into this app.';
            //    }
            //}

            @*function _login() {
                FB.login(function (response) {
                    // Xử lý các kết quả
                    if (response.status === 'connected') {
                        _i();
                    }
                }, { scope: 'public_profile,email' });
            }

            // Điền kết quả vào textbox
            function _i() {
                FB.api('/me', function (response) {
                    document.getElementById("txtUsername").value = response.id;
                    document.getElementById("inputLname").value = response.last_name;
                    document.getElementById("inputEmail").value = response.email;
                    var accessToken = response.id;
                    $.ajax({
                        type: "POST",
                        url: "@Url.Action("GetAccessToken")",
                        data: {
                            accessToken: accessToken
                    },
                    dataType: "Json",
                    success: function (res) {
                        switch (res.Status) {
                            case 1:
                                $('#lbl_username_fail').text(res.Message);
                                $('#txtUsername').focus();
                                break;
                            case 2:
                                $('#lbl_password_fail').text(res.Message);
                                $('#txtPassword').focus();
                                break;
                            case 0:
                                window.location.href = res.RedirectTo;
                                break;
                        }
                    }
                })
                });
            }
            window.fbAsyncInit = function () {
                FB.init({
                    appId: '1667139900267838', // APP ID ứng dụng của bạn
                    cookie: true,  // Kích hoạt cookies

                    xfbml: true,  // plugins xã hội
                    version: 'v2.5' // Sử dụng version 2.1
                });

                // Xử lý hàm callback
                FB.getLoginStatus(function (response) {
                    statusChangeCallback(response);
                });

            };*@

            $('#btnLogin').click(function () {
                if (Validate()) {
                    Login();
                } else {

                    return false;
                }
            });
            function Validate() {
                var username = $('#txtUsername').val();
                var password = $('#txtPassword').val();
                $('#lbl_username_fail').text("");
                $('#lbl_password_fail').text("");
                if (username == "") {
                    $('.login-wrap').animo({ animation: 'tada' });
                    $('#lbl_username_fail').text("Vui lòng nhập tên đăng nhập");
                    $('#txtUsername').focus();
                    return false;
                } else if (password == "") {
                    $('.login-wrap').animo({ animation: 'tada' });
                    $('#errorMessage').text("");
                    $('#lbl_password_fail').text("Vui lòng nhập mật khẩu");
                    $('#txtPassword').focus();
                    return false;
                }
                return true;
            }
            function Login() {
                var username = $('#txtUsername').val();
                var password = $('#txtPassword').val();
                $('#lbl_username_fail').text("");
                $('#lbl_password_fail').text("");
                $.ajax({
                    type: "POST",
                    url: "@Url.Action("Login")",
                    data: {
                        username: username,
                        password: password
                    },
                    dataType: "Json",
                    success: function (res) {
                        switch (res.Status) {
                            case 1:
                                $('#lbl_username_fail').text(res.Message);
                                $('#txtUsername').focus();
                                break;
                            case 2:
                                $('#lbl_password_fail').text(res.Message);
                                $('#txtPassword').focus();
                                break;
                            case 0:
                                window.location.href = res.RedirectTo;
                                break;
                        }
                    }
                })
            }
    </script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="~/Content/HBThemes/dist/js/bootstrap.min.js"></script>

</body>
</html>

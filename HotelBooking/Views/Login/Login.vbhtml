@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    ViewBag.Title = "Login"
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
    Dim check As String = ViewBag.error
End Code

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng nhập</title>

    <!-- Bootstrap -->
    <link href="~/Content/HBThemes/dist/css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/assets/css/custom.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/font-awesome/css/bootstrap-social.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/font-awesome/css/font-awesome.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/font-awesome/css/font-awesome.min.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/font-awesome/css/social-buttons.css" rel="stylesheet" media="screen">
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
        @*<div Class="login-wrap">
                <img src = "images/logo.png" Class="login-img" alt="logo" /><br />

                <div Class="login-c1">
                    <div Class="cpadding50">
                        <input type = "text" Class="form-control logpadding" id="txtUsername" placeholder="Username">
                        <Label id = "lbl_username_fail" Class="label-error" ></label>
                        @If TempData("Message") IsNot Nothing Then
                        @<p id = "errorMessage" Class="label-error">Email này đã đăng kí</p>
                        End IF

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
            </div>*@
        <!-- End of Login Wrap  -->
        <!--NhatNH ADD-->
        <div class="container">
            <div id="loginbox" style="margin-top:50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <div class="panel-title">Đăng nhập</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px"><a href="#">Quên mật khẩu?</a></div>
                    </div>

                    <div style="padding-top:30px" class="panel-body">

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>

                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <input id="txtUsername" type="text" class="form-control" name="username" value="" placeholder="Tên đăng nhập">
                        </div>
                        <Label id="lbl_username_fail" Class="label-error"></Label>

                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <input id="txtPassword" type="password" class="form-control" name="password" placeholder="Mật khẩu">
                        </div>
                        <Label id="lbl_password_fail" Class="label-error"></Label>

                        <div style="margin-top:10px" class="form-group">
                            <!-- Button -->

                            <div class="col-sm-12 controls">
                                <button id="btnLogin" type="submit" class="btn btn-success">ĐĂNG NHẬP</button>
                            </div>
                        </div>
                        <p>Hoặc</p>
                        @Using Html.BeginForm("ExternalLogin", "Login", New With {.ReturnUrl = "/"}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                            @Html.AntiForgeryToken()
                            @<div id="socialLoginList">
                                <p class="center">
                                    @For Each p As AuthenticationDescription In loginProviders
                                        If p.AuthenticationType.Equals("Facebook") Then
                                            @<Button Class="btn btn-social btn-facebook" name="provider" value="Facebook">
                                                <span Class="fa fa-facebook"></span> Đăng nhập với Facebook
                                            </Button>
                                            Else If p.AuthenticationType.Equals("Google") Then
                                            @<Button Class="btn btn-social btn-google-plus" name="provider" value="Google">
                                                <span Class="fa fa-google-plus"></span> Đăng nhập với Google
                                            </Button>
                                        End If
                                    Next
                                </p>
                            </div>
                        End Using
                        @If TempData("Message") IsNot Nothing Then
                            @<p id="errorMessage" Class="label-error">Email này đã đăng kí</p>
                        End IF
                        <br />
                        <div class="form-group">
                            <div class="col-md-12 control">
                                <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%">
                                    Bạn chưa có tài khoản!
                                    <a style="color:blue" href="@Url.Action("SignUp", "SignUp")" onClick="$('#loginbox').hide(); $('#signupbox').show()">
                                        Đăng ký tại đây
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!--NhatNH end-->

                    </div>
                    @*End Using*@
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

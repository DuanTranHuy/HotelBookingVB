@Code
    ViewBag.Title = "SignUp"
End Code

<!DOCTYPE html>
<html class="hide-sidebar ls-bottom-footer" lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Đăng kí</title>
    <!-- Vendor CSS BUNDLE
      Includes styling for all of the 3rd party libraries used with this module, such as Bootstrap, Font Awesome and others.
      TIP: Using bundles will improve performance by reducing the number of network requests the client needs to make when loading the page. -->
    <link href="~/Content/HBThemes/css/vendor/all.css" rel="stylesheet" />
    <!-- Vendor CSS Standalone Libraries
          NOTE: Some of these may have been customized (for example, Bootstrap).
          See: src/less/themes/{theme_name}/vendor/ directory -->
    <!-- <link href="css/vendor/bootstrap.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/font-awesome.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/picto.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/material-design-iconic-font.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/datepicker3.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/jquery.minicolors.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/railscasts.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/owl.carousel.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/slick.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/daterangepicker-bs3.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/jquery.bootstrap-touchspin.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/select2.css" rel="stylesheet"> -->
    <!-- <link href="css/vendor/jquery.countdown.css" rel="stylesheet"> -->
    <!-- APP CSS BUNDLE [css/app/app.css]
    INCLUDES:
        - The APP CSS CORE styling required by the "html" module, also available with main.css - see below;
        - The APP CSS STANDALONE modules required by the "html" module;
    NOTE:
        - This bundle may NOT include ALL of the available APP CSS STANDALONE modules;
          It was optimised to load only what is actually used by the "html" module;
          Other APP CSS STANDALONE modules may be available in addition to what's included with this bundle.
          See src/less/themes/html/app.less
    TIP:
        - Using bundles will improve performance by greatly reducing the number of network requests the client needs to make when loading the page. -->
    <link href="~/Content/HBThemes/css/app/app.css" rel="stylesheet" />
    <!-- App CSS CORE
    This variant is to be used when loading the separate styling modules -->
    <!-- <link href="css/app/main.css" rel="stylesheet"> -->
    <!-- App CSS Standalone Modules
      As a convenience, we provide the entire UI framework broke down in separate modules
      Some of the standalone modules may have not been used with the current theme/module
      but ALL modules are 100% compatible -->
    <!-- <link href="css/app/essentials.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/material.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/layout.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/sidebar.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/sidebar-skins.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/navbar.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/messages.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/media.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/charts.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/maps.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/colors-alerts.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/colors-background.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/colors-buttons.css" rel="stylesheet" /> -->
    <!-- <link href="css/app/colors-text.css" rel="stylesheet" /> -->
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries
    WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!-- If you don't need support for Internet Explorer <= 8 you can safely remove these -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body class="login">
    <div id="content">
        <div class="container-fluid">
            <div class="lock-container">
                <div class="panel panel-default text-center paper-shadow" data-z="0.5">
                    <img src="~/Content/HBThemes/images/logo2.png" class="login-img" alt="logo" /><br />
                    <h1 class="text-display-1">Tạo tài khoản</h1>
                    <div class="panel-body">
                        <!-- Signup -->
                        <form role="form" action="index.html">
                            <div class="form-group">
                                <div class="form-control-material">
                                    <input id="txtUserName" type="text" class="form-control" placeholder="">
                                    <label for="firstName">Tên đăng nhập</label>
                                </div>
                            </div>
                            <label id="lblUserNameFail" class="label-error"></label>
                            <div class="form-group">
                                <div class="form-control-material">
                                    <input id="txtEmail" type="text" class="form-control" placeholder="">
                                    <label for="lastName">Địa chỉ Email</label>
                                </div>
                            </div>
                            <label id="lblEmailFail" class="label-error"></label>
                            <div class="form-group">
                                <div class="form-control-material">
                                    <input id="txtConfirmEmail" type="text" class="form-control" placeholder="">
                                    <label for="email">Nhập lại địa chỉ Email</label>                                    
                                </div>
                            </div>
                            <label id="lblConfirmEmailFail" class="label-error"></label>
                            <div class="form-group">
                                <div class="form-control-material">
                                    <input id="txtPassword" type="password" class="form-control" placeholder="">
                                    <label for="password">Mật khẩu</label>                                  
                                </div>
                            </div>
                            <label id="lblPasswordFail" class="label-error"></label>
                            <div class="form-group">
                                <div class="form-control-material">
                                    <input id="txtConfirmPassword" type="password" class="form-control" placeholder="">
                                    <label for="confirmPassword">Nhập lại mật khẩu</label>                                  
                                </div>
                            </div>
                            <label id="lblConfirmPasswordFail" class="label-error"></label>
                            <div class="form-group text-center">
                                <div class="checkbox">
                                    <input type="checkbox" id="agree"/>
                                    <label for="agree">* Tôi đồng ý với các <a href="#">Điều khoản &amp; Điều kiện!</a></label>
                                </div>
                            </div>
                            <div class="text-center">
                                <button class="btn btn-primary" type="submit" id="btnSignUp" onclick="errorMessage()">Đăng kí ngay</button>
                                @*<a href="website-student-dashboard.html" class="btn btn-primary">Đăng kí ngay</a>*@
                            </div>
                            <div class="form-group">
                                <label>Hoặc đăng kí nhanh với</label>
                                <a href="#" class="social1b"><img src="~/Content/HBThemes/images/icon-facebook.png" alt="" /></a>
                                <a href="#" class="social3b"><img src="~/Content/HBThemes/images/icon-gplus.png" alt="" /></a>
                            </div>
                        </form>
                        <!-- End Signup -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Footer -->
    <footer class="footer">
        <strong>Hotel Booking</strong> v1.1.0 &copy; Copyright 2016
    </footer>
    <!-- Footer -->
    <!-- Inline Script for colors and config objects; used by various external scripts; -->
    <script>
        var colors = {
            "danger-color": "#e74c3c",
            "success-color": "#81b53e",
            "warning-color": "#f0ad4e",
            "inverse-color": "#2c3e50",
            "info-color": "#2d7cb5",
            "default-color": "#6e7882",
            "default-light-color": "#cfd9db",
            "purple-color": "#9D8AC7",
            "mustard-color": "#d4d171",
            "lightred-color": "#e15258",
            "body-bg": "#f6f6f6"
        };
        var config = {
            theme: "html",
            skins: {
                "default": {
                    "primary-color": "#42a5f5"
                }
            }
        };
    </script>

    <!-- Logical -->
    <script src="~/Content/HBThemes/js/vendor/all.js"></script>
    <script src="~/Content/HBThemes/js/app/app.js"></script>
    <script type="text/javascript">

        // Focus in txtUserName
        $(document).ready(function () {

            $(function () {
                $("#txtUserName").focus();
            });
        });

        // Process Keypress event
        $(document).keypress(function (event) {
            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '13') {
                if (Validate()) {
                    SignUp();
                } else {
                    return false;
                }
            }
        });

        $('#btnSignUp').click(function () {
            if (Validate()) {
                SignUp();
            } else {
                function errorMessage() {
                }
                return false;
            }
        });
        function Validate() {
            var userName = $('#txtUserName').val();
            var email = $('#txtEmail').val();
            var confirmEmail = $('#txtConfirmEmail').val();
            var password = $('#txtPassword').val();
            var confirmPassword = $('#txtConfirmPassword').val();
            $('#lblUserNameFail').text("");
            $('#lblEmailFail').text("");
            $('#lblConfirmEmailFail').text("");
            $('#lblPasswordFail').text("");
            $('#lblConfirmPasswordFail').text("");

            if (userName == "") {
                $('#lblUserNameFail').text("Vui lòng nhập tên đăng nhập");
                $('#txtUsername').focus();
                return false;
            } 

            else if (email == "") {
                $('#lblEmailFail').text("Vui lòng nhập địa chỉ Email");
                $('#txtEmail').focus();
                return false;
            }
            else if (confirmEmail == "") {
                $('#lblConfirmEmailFail').text("Vui lòng nhập lại địa chỉ Email");
                $('#txtConfirmEmail').focus();
                return false;
            }
            else if (password == "") {
                $('#lblPasswordFail').text("Vui lòng nhập mật khẩu");
                $('#txtPassword').focus();
                return false;
            }
            else if (confirmPassword == "") {
                $('#lblConfirmPasswordFail').text("Vui lòng nhập lại mật khẩu");
                $('#txtConfirmPassword').focus();
                return false;
            }
            return true;
        }
        function SignUp() {
            var userName = $('#txtUserName').val();
            var email = $('#txtEmail').val();
            var confirmEmail = $('#txtConfirmEmail').val();
            var password = $('#txtPassword').val();
            var confirmPassword = $('#txtConfirmPassword').val();
            $('#lblUserNameFail').text("");
            $('#lblEmailFail').text("");
            $('#lblConfirmEmailFail').text("");
            $('#lblPasswordFail').text("");
            $('#lblConfirmPasswordFail').text("");
            $.ajax({
                type: "POST",
                url: "@Url.Action("SignUp")",
                data: {
                    userName: userName,
                    email: email,
                    confirmEmail: confirmEmail,
                    password: password,
                    confirmPassword: confirmPassword
                },
                dataType: "Json",
                success: function (res) {
                    switch (res.Status) {
                        case 1:
                            $('#lblUserNameFail').text(res.Message);
                            $('#txtUsername').focus();
                            break;
                        case 2:
                            $('#lblEmailFail').text(res.Message);
                            $('#txtEmail').focus();
                            break;
                        case 3:
                            $('#lblConfirmEmailFail').text(res.Message);
                            $('#txtConfirmEmail').focus();
                            break;
                        case 4:
                            $('#lblPasswordFail').text(res.Message);
                            $('#txtPassword').focus();
                            break;
                        case 5:
                            $('#lblConfirmPasswordFail').text(res.Message);
                            $('#txtConfirmPassword').focus();
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

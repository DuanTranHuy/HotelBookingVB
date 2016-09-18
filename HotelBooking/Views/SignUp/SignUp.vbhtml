@Code
    ViewBag.Title = "SignUp"
End Code

<!DOCTYPE html>
<html class="hide-sidebar ls-bottom-footer" lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng kí</title>
    <link href="~/Content/HBThemes/dist/css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/assets/css/custom.css" rel="stylesheet" media="screen">

    <link src="~/Content/HBThemes/css/vendor/all.css" rel="stylesheet" /> 
    <link src="~/Content/HBThemes/css/app/app.css" rel="stylesheet" />
    <script src="~/Content/HBThemes/assets/js/jquery.v2.0.3.js"></script>
</head>
<body>

        <div class="container">
            <div class="row main">
                <div class="main-login main-center">
                    <img src="~/Content/HBThemes/images/logo2.png" class="login-img" alt="logo" /><br />
                    <h1 class="text-display-1">Tạo tài khoản</h1>
                        <!-- Signup -->
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
                                <button class="btn btn-primary" type="submit" id="btnSignUp">Đăng kí ngay</button>                      
                            </div>
                            <div class="form-group">
                                <label>Hoặc đăng kí nhanh với</label>
                                <button id="btnFacebook" class="social1b"><img src="~/Content/HBThemes/images/icon-facebook.png" alt="" /></button>
                                <a href="#" class="social3b"><img src="~/Content/HBThemes/images/icon-gplus.png" alt="" /></a>
                            </div>
                        <!-- End Signup -->
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
    <script type="text/javascript">
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

                return false;
            }
        });
        function isValidEmailAddress(emailAddress) {
            var regex = /^([a-zA-Z0-9_.+-])+\@@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            return regex.test(emailAddress);
        };
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
            else if (!isValidEmailAddress(email)){
                $('#lblEmailFail').text("Địa chỉ Email không đúng định dạng");
                $('#txtEmail').focus();
                return false;
            }

            else if (confirmEmail == "") {
                $('#lblConfirmEmailFail').text("Vui lòng nhập lại địa chỉ Email");
                $('#txtConfirmEmail').focus();
                return false;
            }
            else if (confirmEmail != email) {
                $('#lblConfirmEmailFail').text("Xác nhận địa chỉ email không giống với email");
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
            else if (password != confirmPassword) {
                $('#lblConfirmPasswordFail').text("Xác nhận mật khẩu không trùng với mật khẩu");
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
                            $('#txtUserName').focus();
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

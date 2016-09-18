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
    <style>
        body {
            background-image: url('/Content/HBThemes/images/sign-up-background.jpg');
        }
    </style>

</head>
<body>

        <div class="container">
                <div class="row">
                    <div class="col-md-6 col-md-offset-3">
                        <div class="text-center" style="margin-top: 1cm">
                            <img src="~/Content/HBThemes/images/logo2.png" class="login-img" alt="logo" /><br />
                        </div>
                        <h1 class="text-display-1 text-center" style="color: lavender">Tạo tài khoản</h1>
                        <!-- Signup -->
                        <div class="form-group">
                            <div class="form-control-material">
                                <input id="txtUserName" type="text" class="form-control input-tp" placeholder="Tên đăng nhập">
                            </div>
                            <label id="lblUserNameFail" class="label-error"></label>
                        </div>
                        <div class="form-group">
                            <div class="form-control-material">
                                <input id="txtEmail" type="text" class="form-control input-tp" placeholder="Địa chỉ Email">
                            </div>
                            <label id="lblEmailFail" class="label-error"></label>
                        </div>
                        <div class="form-group">
                            <div class="form-control-material">
                                <input id="txtConfirmEmail" type="text" class="form-control input-tp" placeholder="Nhập lại địa chỉ Email">
                            </div>
                            <label id="lblConfirmEmailFail" class="label-error"></label>
                        </div>
                        <div class="form-group">
                            <div class="form-control-material">
                                <input id="txtPassword" type="password" class="form-control input-tp" placeholder="Mật khẩu">
                            </div>
                            <label id="lblPasswordFail" class="label-error"></label>
                        </div>
                        <div class="form-group">
                            <div class="form-control-material">
                                <input id="txtConfirmPassword" type="password" class="form-control input-tp" placeholder="Nhập lại mật khẩu">
                            </div>
                            <label id="lblConfirmPasswordFail" class="label-error"></label>
                        </div>
                        <div class="form-group">
                            <div class="text-center">
                                <label style="color: darkgray; font-size: 11.5px">* Chọn đăng ký là bạn đã đồng ý với các <a style="color: indianred" href="#">Điều khoản dịch vụ</a> của chúng tôi.</label>
                            </div>
                        </div>
                        <div class="text-center">
                            <button class="btn btn-primary" type="submit" id="btnSignUp" style="width:300px">Đăng kí ngay</button>
                        </div>
                        <br />
                        <div class="form-group">
                            <label style="color: lavender">Hoặc đăng kí nhanh với</label>
                            <a href="#" class="social1b"><img src="~/Content/HBThemes/images/facebook.png" alt="" /></a>
                            <a href="#" class="social3b"><img src="~/Content/HBThemes/images/google-plus.png" alt="" /></a>
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

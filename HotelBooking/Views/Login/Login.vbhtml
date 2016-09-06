﻿@Code
    ViewBag.Title = "Login"
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
    <div class="login-fullwidith">

        <!-- Login Wrap  -->
        <div class="login-wrap">
            <img src="images/logo.png" class="login-img" alt="logo" /><br />
            <div class="login-c1">
                <div class="cpadding50">
                    <input type="text" class="form-control logpadding" id="txtUsername" placeholder="Username">                           
                    <label id="lbl_username_fail" class="label-error"></label>
                    <br />
                    <input type="text" class="form-control logpadding" id="txtPassword" placeholder="Password">
                    <label id="lbl_password_fail" class="label-error"></label>
                    <br />
                </div>
            </div>
            <div class="login-c2">
                <div class="logmargfix">
                    <div class="chpadding50">
                        <div class="alignbottom">
                            <button class="btn-search4" type="submit" id="btnSubmit" onclick="errorMessage()">Submit</button>
                        </div>
                        <div class="alignbottom2">
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox">Remember
                                </label>
                            </div>
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
    <!-- End of Container  -->
    <!-- Javascript  -->
    <script src="~/Content/HBThemes/assets/js/initialize-loginpage.js"></script>
    <script src="~/Content/HBThemes/assets/js/jquery.easing.js"></script>
    <!-- Load Animo -->
    <script src="~/Content/HBThemes/plugins/animo/animo.js"></script>
    <script type="text/javascript">

          $(document).ready(function () {

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

          $('#btnSubmit').click(function () {
              if (Validate()) {
                  Login();
              } else {
                  function errorMessage() {
                      $('.login-wrap').animo({ animation: 'tada' });
                  }
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
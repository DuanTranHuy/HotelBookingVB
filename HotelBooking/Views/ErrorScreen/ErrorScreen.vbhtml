﻿@Code
    ViewData("Title") = "ErrorScreen"
End Code

<!DOCTYPE html>
<html>

<head>
    <!-- Bootstrap -->
    <link href="~/Content/HBThemes/dist/css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/assets/css/custom.css" rel="stylesheet" media="screen">
    <link href="~/Content/HBThemes/examples/starter-template/starter-template.css" rel="stylesheet" media="screen">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <style>
        body {
              background-image: url('/Content/HBThemes/images/error-screen.png');
        }
    </style>
</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="starter-template">
                    <h1>
                        Oops!
                    </h1>
                    <div class="error-details">
                        Xin lỗi, đã có lỗi xảy ra trong quá trình thực hiện yêu cầu của bạn.
                    </div>
                    <div class="media">
                        <a href="@Url.Action("Home", "Home")"class="btn btn-primary btn-lg">
                            <span class="glyphicon glyphicon-home"></span>
                            Quay về trang chủ
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>


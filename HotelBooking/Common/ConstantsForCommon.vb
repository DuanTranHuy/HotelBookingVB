﻿Public Class ConstantsForCommon
    'Tham số cho các hàm common
    Public Const PathOfResource As String = "HotelBooking.Resources"
    Public Const RegexLowerCase As String = "[a-z]"
    Public Const RegexUpperCase As String = "[A-Z]"
    Public Const RegexNumericInput As String = "[0-9]"
    Public Const Minus As String = "-"
    Public Const RemoteHost As String = "REMOTE_HOST"
    Public Const HttpXForward As String = "HTTP_X_FORWARDED_FOR"
    Public Const RemoteAddr As String = "REMOTE_ADDR"
    Public Const RegexEmail AS String ="^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
    Public Class CommonsTitleName

        Public Const Login As String = "SYS010 - Login"
        Public Const SignUp As String = "SYS011 - SignUp"

    End Class

    Public Class CommonsPageTitleName

        Public Const SYS010 As String = "Login - HotelBookingSystem"


    End Class

    'Kết thúc phần tham số cho các hàm common

    'ID màn hình
    Public Class ScreenId
        Public Const Login As String = "Login"
        Public Const SignUp As String = "SignUp"
        
    End Class
    'ID màn hình

    'Tên màn hình
    Public Class ScreenName
        Public Const Login As String = "Login"
        Public Const SignUp As String = "SignUp"
        
    End Class
    'Tên màn hình

    'Tham số đầu vào 
    Public Class ErrorParam
        Public Const SystemErrors As String = "SystemError"
        Public Const Errors As String = "Error"
    End Class
    Public Class LogParam
        Public Const Logout As String = "Logout"
        Public Const Login As String = "Login"
    End Class
    Public Class SessionParam
        Public Const SessionUserName As String = "USERNAME"
        Public Const SessionUserPass As String = "USERPASS"
        Public Const SessionId As String = "SESSIONID"
        Public Const SessionUserId As String = "USERID"
        Public Const SessionFullName As String = "FULLNAME"
        Public Const SessionExpFlg As String = "EXP_FLG"
        Public Const SessionAddOrDeleteRow As String = "ADD_OR_DELETEROW"
        Public Const SessionDeleteAll As String = "DELETE_ALL"
        Public Const SessionPathFileImportPart As String = "PATH_FILE_IMPORT_PART"
    End Class
    Public Class OutPutParameter
        Public Const AcceptFlg = "1"
        Public Const NotAcceptFlg = "0"
    End Class

    'Message cho màn hình Login.
    Public Const LoginM001 = "LOGIN_M001"
    Public Const LoginM002 = "LOGIN_M002"
    Public Const LoginM003 = "LOGIN_M003"
    Public Const LoginM004 = "LOGIN_M004"
     'Message cho màn hình SignUp.
    Public Const SignUpM001 = "SIGNUP_M001"
    Public Const SignUpM002 = "SIGNUP_M002"
    Public Const SignUpM003 = "SIGNUP_M003"
    Public Const SignUpM004 = "SIGNUP_M004"
    Public Const SignUpM005 = "SIGNUP_M005"
    Public Const SignUpM006 = "SIGNUP_M006"
    Public Const SignUpM007 = "SIGNUP_M007"
    'Kết thúc phần message cho màn hình SYS011, SYS012, SYS013, SYS014.



End Class

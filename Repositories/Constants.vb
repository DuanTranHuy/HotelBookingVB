Namespace DB.Common

    Public Class Constants
        'The below code is C# example
        '/// <summary>
        '/// SQL Query ID
        '/// </summary>
        Public Const SqlQueryId As String = "SQlQuery_id"

        '/// <summary>
        '/// SQL QueryData
        '/// </summary>
        Public Const SqlQueryData As String = "SQlQuery_data"

        '/// <summary>
        '/// Path xml
        '/// </summary>
        Public Const PathXml As String = "path"

        '/// <summary>
        '/// write data type same update, delete, insert log
        '/// </summary>
        Public Const Data As String = "Data"

        '/// <summary>
        '/// SQL ID 
        '/// </summary>
        Public Const SqlId As String = "SQLID"

        '/// <summary>
        '/// Path xml when file read 
        '/// </summary>
        Public Const PathXmlQuery As String = "\Repositories\Queries\"

        '/// <summary>
        '/// Extension xml
        '/// </summary>
        Public Const ExtXml As String = ".xml"
        'public const string ExtXml = ".xml";

        '/// <summary>
        '/// Common File
        '/// </summary>
        Public Const CommonFile As String = "COMMON"


        ''' <summary>
        ''' Enum for UserRepository
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum UserColumns
            ExpFlg = 0
            UserId = 1
            Email = 2
            Password = 3
        End Enum


        Public Const DateTimeFormatForDisplay = "dd/MM/yyyy HH:mm"
        Public Class Common
            Public Const CMN_003 As String = "CMN_003"
            Public Const CMN_002 As String = "CMN_002"
            Public Const CMN_001 As String = "CMN_001"
            Public Const COMMON As String = "COMMON"
        End Class
        Public Class Login
            Public Const Login_03 As String = "Login_03"
            Public Const Login_02 As String = "Login_02"
            Public Const Login_01 As String = "Login_01"
            Public Const Login As String = "Login"
        End Class
        Public Const ExternalLogin As String = "ExternalLogin"
        Public Class SignUp
            Public Const SignUp As String = "SignUp"
            Public Const SignUp_01 As String = "SignUp_01"
            Public Const SignUp_02 As String = "SignUp_02"
            Public Const SignUp_03 As String = "SignUp_03"
                        Public Const SignUp_04 As String = "SignUp_04"
        End Class

    End Class

End Namespace
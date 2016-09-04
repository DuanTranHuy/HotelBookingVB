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
            FullName = 2
            Email = 3
            Password = 4
        End Enum

        Public Enum UserCountColumns
            CountUserId = 0
        End Enum

        Public Enum GetFunctionAccessColumns
            UserId = 0
            FunctionId = 1
            CFlg = 2
            RFlg = 3
            UFlg = 4
            DFlg = 5
        End Enum

        Public Enum GetFileOfType
            Value = 0
        End Enum
        Public Enum GetAttachFolder
            Value = 0
        End Enum

        Public Enum GetPermissionFlag
            PermissionFlg = 0
        End Enum


        Public Enum GetMasterCode
            MasterCode = 0
        End Enum

        Public Enum GetMakerType
            MakerType = 0
        End Enum

        Public Const DateTimeFormatForDisplay = "dd/MM/yyyy HH:mm"
        Public Class Login
            Public Const Login_01 As String = "Login_01"
            Public Const Login As String = "Login"
        End Class

    End Class

End Namespace
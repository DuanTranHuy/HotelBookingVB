Public Class Util

    ''' <summary>
    ''' Lấy thông tin message từ cấu hình hệ thống
    ''' </summary>
    ''' <param name="messageId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetMessageFromResource(ByVal messageId As String) As String
        Dim resourceManager = New Resources.ResourceManager(ConstantsForCommon.PathOfResource, System.Reflection.Assembly.GetExecutingAssembly)
        Return resourceManager.GetString(MessageId)
    End Function
        Public Shared Function GetMessageFromResource(ByVal messageId As String, ByVal replaceString As String) As String
        If String.IsNullOrEmpty(replaceString) = False Then
            Dim resourceManager = New Resources.ResourceManager(ConstantsForCommon.PathOfResource, System.Reflection.Assembly.GetExecutingAssembly)
        Return String.Format(resourceManager.GetString(messageId), replaceString)
        End If
        Return Nothing
    End Function
    Public Shared Sub SetSessionInfo(ByRef sessionId As String, ByRef sessionUserId As ULong, ByRef sessionUserName As String, ByRef sessionUserPass As String)
        sessionId = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionId)
        sessionUserId = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserId)
        sessionUserName = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserName)
        sessionUserPass = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserPass)
    End Sub
    ''' <summary>
    ''' Xóa session của hệ thống
    ''' </summary>
    ''' <param name="RemoveSessionLogOut">Tham số khi xóa các session đăng xuất hệ thống</param>
    ''' <remarks></remarks>
    Public Shared Sub RemoveSessionHbs(Optional ByVal removeSessionLogOut As Boolean = True)
        Try
            'Xóa các session khởi tạo khi đăng nhập
            If removeSessionLogOut Then
                HttpContext.Current.Session.Remove(ConstantsForCommon.SessionParam.SessionUserId)
                HttpContext.Current.Session.Remove(ConstantsForCommon.SessionParam.SessionUserName)
                HttpContext.Current.Session.Remove(ConstantsForCommon.SessionParam.SessionUserPass)
                HttpContext.Current.Session.Remove(ConstantsForCommon.SessionParam.SessionExpFlg)
                HttpContext.Current.Session.Remove(ConstantsForCommon.SessionParam.SessionId)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
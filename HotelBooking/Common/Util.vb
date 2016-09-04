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
    Public Shared Sub SetSessionInfo(ByRef sessionId As String, ByRef sessionUserId As ULong, ByRef sessionUserName As String, ByRef sessionUserPass As String)
        sessionId = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionId)
        sessionUserId = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserId)
        sessionUserName = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserName)
        sessionUserPass = HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserPass)
    End Sub
End Class
Public Class Header
        ''' <summary>
    ''' Lấy giá trị cho lời chào hệ thống
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetWelcomeMessage() As String
        Dim welcomeMessage As String = Util.GetMessageFromResource(ConstantsForCommon.WelcomeMessage, HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionFullName))
        Return welcomeMessage
    End Function
End Class

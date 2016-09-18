Imports Repositories

Public Class Logger

    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    ''' <summary>
    ''' Lưu lại thông tin người dùng đăng nhập hệ thống
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="SessionID"></param>
    ''' <param name="ComputerName"></param>
    ''' <param name="IpAdress"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogUserLogin(ByVal UserID As ULong, ByVal SessionID As String, ByVal ComputerName As String, ByVal IpAdress As String)
        Dim repo As New CommonRepository()
        repo.LogUserLogin(UserID, SessionID, ComputerName, IpAdress)
    End Sub
    ''' <summary>
    ''' Lưu lại thông tin người dùng khi đăng xuất
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="SessionID"></param>
    ''' <param name="ComputerName"></param>
    ''' <param name="IpAdress"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogUserLogout(ByVal UserID As ULong, ByVal SessionID As String, ByVal ComputerName As String, ByVal IpAdress As String)
        Dim repo As New CommonRepository()
        repo.LogUserLogOut(UserID, SessionID, ComputerName, IpAdress)
    End Sub
    ''' <summary>
    ''' Lưu lại thông tin người dùng khi đăng xuất (trong trường hợp bị ngắt kết nối)
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="SessionID"></param>
    ''' <param name="ComputerName"></param>
    ''' <param name="IpAdress"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogUserLogoutOnSessionEnd(ByVal UserID As ULong, ByVal SessionID As String, ByVal ComputerName As String, ByVal IpAdress As String)
        Dim repo As New CommonRepository()
        repo.LogUserLogoutOnSessionEnd(UserID, SessionID, ComputerName, IpAdress)
    End Sub
    ''' <summary>
    ''' Lưu thông tin đặc biệt
    ''' </summary>
    ''' <param name="ctdUsr"></param>
    ''' <param name="ctdWks"></param>
    ''' <param name="ctdPgm"></param>
    ''' <param name="userId"></param>
    ''' <param name="userName"></param>
    ''' <param name="computerName"></param>
    ''' <param name="ipAdress"></param>
    ''' <param name="act"></param>
    ''' <param name="sql"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogUserActivity(ByVal ctdUsr As ULong, ByVal ctdWks As String, ByVal ctdPgm As String, ByVal userId As ULong, ByVal userName As String,
                        ByVal computerName As String, ByVal ipAdress As String, ByVal act As String, ByVal sql As String)
        Dim repo As New CommonRepository()
        repo.LogUserActivity(ctdUsr, ctdWks, ctdPgm, userId, userName, computerName, ipAdress, act, sql)
    End Sub
    ''' <summary>
    ''' Lưu thông tin người dùng truy cập màn hình
    ''' </summary>
    ''' <param name="userId"></param>
    ''' <param name="userName"></param>
    ''' <param name="screenCode"></param>
    ''' <param name="screenName"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogVisitedScreen(ByVal userId As ULong, ByVal userName As String, ByVal screenCode As String, ByVal screenName As String)
        Dim repo As New CommonRepository()
        repo.LogVisitedScreen(userId, userName, screenCode, screenName)
    End Sub
    ''' <summary>
    ''' Lưu thông tin lỗi của hệ thống
    ''' </summary>
    ''' <param name="ex"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogException(ex As Exception)
        log.Error(ex.Message)
        log.Error(ex.StackTrace)
    End Sub

    ''' <summary>
    ''' Lưu lại các thao tác của user
    ''' </summary>
    ''' <param name="ctdUsr"></param>
    ''' <param name="ctdWks"></param>
    ''' <param name="ctdPgm"></param>
    ''' <param name="userId"></param>
    ''' <param name="userName"></param>
    ''' <param name="computerName"></param>
    ''' <param name="ipAdress"></param>
    ''' <param name="act"></param>
    ''' <param name="sqlList"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogUserActivities(ByVal ctdUsr As ULong, ByVal ctdWks As String, ByVal ctdPgm As String, ByVal userId As ULong, ByVal userName As String,
                        ByVal computerName As String, ByVal ipAdress As String, ByVal act As String, ByVal sqlList As List(Of String))
        If Not IsNothing(sqlList) And sqlList.LongCount > 0 Then
            Dim repo As New CommonRepository()
            repo.LogUserActivities(ctdUsr, ctdWks, ctdPgm, userId, userName, computerName, ipAdress, act, sqlList)
        End If
    End Sub
    ''' <summary>
    ''' Ghi lại thao tác đặc biệt
    ''' </summary>
    ''' <param name="operation">Tên thao tác</param>
    ''' <param name="key">Dữ liệu chịu tác động</param>
    ''' <param name="author">Người thực hiện</param>
    ''' <param name="reason">Lý do</param>
    ''' <remarks></remarks>
    Public Shared Sub LogSpecialOperation(ByVal operation As String, ByVal key As String, ByVal author As String, ByVal reason As String)
        Dim repo As New CommonRepository()
        repo.LogSpecialOperation(operation, key, author, reason)
    End Sub

    '''' <summary>
    '''' Ghi lại thao tác đặc biệt với nhiều keys
    '''' </summary>
    '''' <param name="operation">Tên thao tác</param>
    '''' <param name="keys">Dữ liệu chịu tác động</param>
    '''' <param name="author">Người thực hiện</param>
    '''' <param name="reason">Lý do</param>
    '''' <remarks></remarks>
    'Public Shared Sub LogSpecialOperationForKeys(ByVal operation As String, ByVal keys As List(Of ULong), ByVal author As String, ByVal reason As String)
    '    If Not IsNothing(keys) And keys.LongCount > 0 Then
    '        Dim repo As New CommonRepository()
    '        repo.LogSpecialOperationForKeys(operation, keys, author, reason)
    '    End If
    'End Sub


End Class

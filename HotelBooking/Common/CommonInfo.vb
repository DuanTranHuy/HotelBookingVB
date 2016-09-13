Imports System.Net
Imports System.Net.Sockets

Public Class CommonInfo

    ''' <summary>
    ''' Lấy PC Name của máy trạm
    ''' </summary>
    ''' <returns>PC Name của máy trạm</returns>
    ''' <remarks></remarks>
    Public Shared Function GetPCName() As String
        Dim host As IPHostEntry
        Dim pcName As String = ConstantsForCommon.Minus
        Try
            host = Dns.GetHostEntry(HttpContext.Current.Request.ServerVariables.Item(ConstantsForCommon.RemoteHost))
            pcName = host.HostName
            If String.IsNullOrWhiteSpace(pcName) Then
                pcName = ConstantsForCommon.Minus
            End If
        Catch ex As Exception
            pcName = ConstantsForCommon.Minus
            Logger.LogException(ex)
        End Try
        Return pcName
    End Function
    ''' <summary>
    ''' Lấy địa chỉ IP của máy trạm
    ''' </summary>
    ''' <returns>Địa chỉ IP máy trạm</returns>
    ''' <remarks></remarks>
    Public Shared Function mdfWks() As String
        Dim strIPAddress As String = String.Empty
        Try
            strIPAddress = HttpContext.Current.Request.ServerVariables(ConstantsForCommon.HttpXForward)
            If strIPAddress Is Nothing OrElse strIPAddress.Equals(String.Empty) Then
                strIPAddress = HttpContext.Current.Request.ServerVariables(ConstantsForCommon.RemoteAddr)
            End If
            If String.IsNullOrWhiteSpace(strIPAddress) Then
                strIPAddress = ConstantsForCommon.Minus
            End If
        Catch ex As Exception
            strIPAddress = ConstantsForCommon.Minus
            Logger.LogException(ex)
        End Try
        Return strIPAddress
    End Function
    ''' <summary>
    ''' Lấy địa chỉ IP của máy trạm
    ''' </summary>
    ''' <returns>Địa chỉ IP máy trạm</returns>
    ''' <remarks></remarks>
    Public Shared Function ctdWks() As String
        Return mdfWks()
    End Function
    ''' <summary>
    ''' Lấy tên của màn hình tương ứng
    ''' </summary>
    ''' <param name="FunctionCode">Mã của màn hình</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mdfPgm(ByVal FunctionCode As String) As String
        Dim functionId As String = FunctionCode
        Select Case functionId
            Case ConstantsForCommon.ScreenId.Login
                Return ConstantsForCommon.CommonsTitleName.Login

        End Select
        Select Case functionId
            Case ConstantsForCommon.ScreenId.SignUp
                Return ConstantsForCommon.CommonsTitleName.SignUp

        End Select
        Return String.Empty
    End Function
    ''' <summary>
    ''' Lấy tên của màn hình tương ứng
    ''' </summary>
    ''' <param name="FunctionCode">Mã của màn hình</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ctdPgm(ByVal FunctionCode) As String
        Return mdfPgm(FunctionCode)
    End Function
    ''' <summary>
    ''' Lấy ID người dùng
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ctdUsr() As ULong
        Return HttpContext.Current.Session(ConstantsForCommon.SessionParam.SessionUserId)
    End Function
    ''' <summary>
    ''' Lấy ID người dùng
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function mdfUsr() As ULong
        Return ctdUsr()
    End Function
    ''' <summary>
    ''' Lấy giá trị Actual Flag
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function actFlg() As String
        Return ConstantsForCommon.OutPutParameter.AcceptFlg
    End Function
    ''' <summary>
    ''' Kiểm tra Email format
    ''' </summary>
    ''' <param name="s"></param>
    ''' <returns></returns>
    Public Shared Function IsValidEmailFormat(ByVal s As String) As Boolean
    Return Regex.IsMatch(s, ConstantsForCommon.RegexEmail)
    End Function
End Class

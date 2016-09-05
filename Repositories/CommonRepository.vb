Imports Entities
Imports System.Data.SqlClient
Imports Repositories.DB.Common
Imports Repositories

Public Class CommonRepository
    Implements ICommonRepository
    Dim ReadOnly _conn As New SqlConnection(My.Settings.ConnectionString)
        Private Class Parameters
        Public Class CmdParameters
            Public Const UserId As String = ":userId"
            Public Const UserName As String = ":userName"
            Public Const Password As String = ":password"
            Public Const SessionId As String = ":sessionId"
            Public Const FunctionCode As String = ":functionCode"
            Public Const PcName As String = ":pcName"
            Public Const PcIp As String = ":pcIp"
            Public Const ActCode As String = ":actcode"
            Public Const ScreenCode As String = ":screenCode"
            Public Const ScreenName As String = ":screenName"
            Public Const CtdUsr As String = ":ctdUsr"
            Public Const CtdWks As String = ":ctdWks"
            Public Const CtdPgm As String = ":ctdPgm"
            Public Const Act As String = ":act"
            Public Const SqlString As String = ":sql"
            Public Const Operation As String = ":operation"
            Public Const Key As String = ":key"
            Public Const Author As String = ":operator"
            Public Const Reason As String = ":reason"
            Public Const RecordId As String = ":recordId"
            Public Const errorHeadId As String = ":errorHeadId"
            Public Const oldStatus As String = ":oldStatus"
            Public Const newStatus As String = ":newStatus"
        End Class

        Public Class OutPutParameter
            Public Const AcceptFlg = "1"
            Public Const NotAcceptFlg = "0"
        End Class
    End Class
    Public Sub LogSpecialOperation(operation As String, key As String, author As String, reason As String) Implements ICommonRepository.LogSpecialOperation
        Throw New NotImplementedException()
    End Sub

    Public Sub LogUserActivities(ctdUsr As String, ctdWks As String, ctdPgm As String, userId As ULong, userName As String, computerName As String, ipAdress As String, act As String, sqlList As List(Of String)) Implements ICommonRepository.LogUserActivities
        Throw New NotImplementedException()
    End Sub

    Public Sub LogUserActivity(ctdUsr As String, ctdWks As String, ctdPgm As String, userId As ULong, userName As String, computerName As String, ipAdress As String, act As String, sql As String) Implements ICommonRepository.LogUserActivity
        Throw New NotImplementedException()
    End Sub

    Public Sub LogUserLogin(userId As ULong, session As String, computerName As String, ipAdress As String) Implements ICommonRepository.LogUserLogin
        Throw New NotImplementedException()
    End Sub

    Public Sub LogUserLogOut(userId As ULong, session As String, computerName As String, ipAdress As String) Implements ICommonRepository.LogUserLogOut
        '    Dim common As New Commons()
        '    Dim xmlReader As New XMLQueryReader
        '    Try
        '        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.InputParameters.CMN004, Constants.CommonFile)

        '        Dim cmd As SqlCommand = New SqlCommand()
        '        cmd.Connection = _conn
        '        cmd.CommandText = sqlQuery
        '        cmd.CommandType = CommandType.Text
        '        If _conn.State = ConnectionState.Closed Then
        '            _conn.Open()
        '        End If

        '        Dim puserId As SqlParameter
        '        puserId = New SqlParameter()
        '        puserId.Direction = ParameterDirection.Input
        '        puserId.SqlDbType = SqlDbType.Int
        '        puserId.ParameterName = Parameters.CmdParameters.UserId
        '        puserId.Value = userId
        '        cmd.Parameters.Add(puserId)

        '        Dim pSession As SqlParameter
        '        pSession = New SqlParameter()
        '        pSession.Direction = ParameterDirection.Input
        '        pSession.SqlDbType = SqlDbType.NChar
        '        pSession.ParameterName = Parameters.CmdParameters.SessionId
        '        pSession.Value = session
        '        cmd.Parameters.Add(pSession)

        '        Dim pPcIP As SqlParameter
        '        pPcIP = New SqlParameter()
        '        pPcIP.Direction = ParameterDirection.Input
        '        pPcIP.SqlDbType = SqlDbType.NChar
        '        pPcIP.ParameterName = Parameters.CmdParameters.PcIp
        '        pPcIP.Value = ipAdress
        '        cmd.Parameters.Add(pPcIP)

        '        cmd.ExecuteNonQuery()
        '    Catch ex As Exception
        '        Throw ex
        '    Finally
        '        _conn.Close()
        '    End Try
    End Sub

    Public Sub LogVisitedScreen(userId As ULong, userName As String, screenCode As String, screenName As String) Implements ICommonRepository.LogVisitedScreen
        Throw New NotImplementedException()
    End Sub
End Class

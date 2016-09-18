Imports Entities
Imports System.Data.SqlClient
Imports Repositories.DB.Common

Public Class LoginRepository
    Implements ILoginRepository
    Dim ReadOnly _conn As New SqlConnection(My.Settings.ConnectionString)
    Public Class Parameters
        Public Class Login
            Public Const UserName As String = "@userName"
        End Class
    End Class
    Public Function Login(ByVal userName As String) As Login Implements ILoginRepository.Login
        Dim user As New Login
        Dim dr As SqlDataReader = Nothing
        Dim xmlReader As New XMLQueryReader
        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.Login.Login_01, Constants.Login.Login)
        Dim cmd As SqlCommand = New SqlCommand()

        Try
            cmd.Connection = _conn
            cmd.CommandText = sqlQuery
            cmd.CommandType = CommandType.Text
          
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If

            Dim pUsername As SqlParameter
            pUsername = New SqlParameter()
            pUsername.Direction = ParameterDirection.Input
            pUsername.SqlDbType = SqlDbType.Varchar
            pUsername.ParameterName = Parameters.Login.UserName
            pUsername.Value = userName
            cmd.Parameters.Add(pUsername)


            dr = cmd.ExecuteReader()

            If dr.Read Then
                user.ExpFlg = dr.GetBoolean(Constants.UserColumns.ExpFlg)
                user.Id = dr.GetDecimal(Constants.UserColumns.UserId)
                user.Email = dr.GetString(Constants.UserColumns.Email)
                user.Password = dr.GetString(Constants.UserColumns.Password)
            Else
                user = Nothing
            End If
            dr = Nothing
        Catch ex As Exception
            Throw ex
            _conn.Close()
        Finally
            If Not IsNothing(dr) Then
                dr.Close()
            End If
            _conn.Close()
        End Try
        Return user
    End Function
End Class

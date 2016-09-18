Imports System.Data.SqlClient
Imports Entities
Imports Microsoft.VisualBasic.ApplicationServices
Imports Repositories.DB.Common

Public Class SignUpRepository
    Implements ISignUpRepository
    ReadOnly _conn As New SqlConnection(My.Settings.ConnectionString)
    Public Class Parameters
        Public Class SignUp
            Public Const AcceptFlag As String = "@AcceptFlag"
            Public Const CreatedMachine As String = "@CreatedMachine"
            Public Const CreatedProgram As String = "@CreatedProgram"
            Public Const UserName As String = "@UserName"
            Public Const Email As String = "@Email"
            Public Const Password As String = "@Password"
            Public Const FullName As String = "@FullName"
        End Class
    End Class
    Public Function SignUp(ByVal acceptFlag As String, ByVal createdMachine As String, ByVal createdProgram As String,
                           ByVal userName As String, ByVal email As String,
                           ByVal password As String) As Boolean Implements ISignUpRepository.SignUp
        Dim retval As Boolean = False
        Dim dataReader As SqlDataReader = Nothing
        Dim xmlReader As New XMLQueryReader
        Dim actFlg As Boolean = True
        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.SignUp.SignUp_01, Constants.SignUp.SignUp)
        Dim sqlCommand As SqlCommand = New SqlCommand()

        Try
            sqlCommand.Connection = _conn
            sqlCommand.CommandText = sqlQuery
            sqlCommand.CommandType = CommandType.Text

            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If

            Dim paraAcceptFlag As SqlParameter
            paraAcceptFlag = New SqlParameter()
            paraAcceptFlag.Direction = ParameterDirection.Input
            paraAcceptFlag.SqlDbType = SqlDbType.Bit
            paraAcceptFlag.ParameterName = Parameters.SignUp.AcceptFlag
            paraAcceptFlag.Value = actFlg
            sqlCommand.Parameters.Add(paraAcceptFlag)

            Dim paraCreatedMachine As SqlParameter
            paraCreatedMachine = New SqlParameter()
            paraCreatedMachine.Direction = ParameterDirection.Input
            paraCreatedMachine.SqlDbType = SqlDbType.VarChar
            paraCreatedMachine.ParameterName = Parameters.SignUp.CreatedMachine
            paraCreatedMachine.Value = createdMachine
            sqlCommand.Parameters.Add(paraCreatedMachine)

            Dim paraCreatedProgram As SqlParameter
            paraCreatedProgram = New SqlParameter()
            paraCreatedProgram.Direction = ParameterDirection.Input
            paraCreatedProgram.SqlDbType = SqlDbType.VarChar
            paraCreatedProgram.ParameterName = Parameters.SignUp.CreatedProgram
            paraCreatedProgram.Value = createdProgram
            sqlCommand.Parameters.Add(paraCreatedProgram)

            Dim paraUsername As SqlParameter
            paraUsername = New SqlParameter()
            paraUsername.Direction = ParameterDirection.Input
            paraUsername.SqlDbType = SqlDbType.VarChar
            paraUsername.ParameterName = Parameters.SignUp.UserName
            paraUsername.Value = userName
            sqlCommand.Parameters.Add(paraUsername)

            Dim paraEmail As SqlParameter
            paraEmail = New SqlParameter()
            paraEmail.Direction = ParameterDirection.Input
            paraEmail.SqlDbType = SqlDbType.VarChar
            paraEmail.ParameterName = Parameters.SignUp.Email
            paraEmail.Value = email
            sqlCommand.Parameters.Add(paraEmail)

            Dim paraPassword As SqlParameter
            paraPassword = New SqlParameter()
            paraPassword.Direction = ParameterDirection.Input
            paraPassword.SqlDbType = SqlDbType.VarChar
            paraPassword.ParameterName = Parameters.SignUp.Password
            paraPassword.Value = password
            sqlCommand.Parameters.Add(paraPassword)


            Dim result As Integer = sqlCommand.ExecuteNonQuery()
            If (result = 1) Then
                retval = True
            Else
                retval = False
            End If
        Catch exception As Exception
            retval = False
            Throw
        Finally
            _conn.Close()
        End Try
        Return retval
    End Function
     Public Function SignUpViaSocial(ByVal acceptFlag As String, ByVal createdMachine As String, ByVal createdProgram As String,
                           ByVal userName As String, ByVal email As String,
                           ByVal fullName As String,ByVal password As String) As Boolean Implements ISignUpRepository.SignUpViaSocial
        Dim retval As Boolean = False
        Dim dataReader As SqlDataReader = Nothing
        Dim xmlReader As New XMLQueryReader
        Dim actFlg As Boolean = True
        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.SignUp.SignUp_04, Constants.SignUp.SignUp)
        Dim sqlCommand As SqlCommand = New SqlCommand()

        Try
            sqlCommand.Connection = _conn
            sqlCommand.CommandText = sqlQuery
            sqlCommand.CommandType = CommandType.Text

            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If

            Dim paraAcceptFlag As SqlParameter
            paraAcceptFlag = New SqlParameter()
            paraAcceptFlag.Direction = ParameterDirection.Input
            paraAcceptFlag.SqlDbType = SqlDbType.Bit
            paraAcceptFlag.ParameterName = Parameters.SignUp.AcceptFlag
            paraAcceptFlag.Value = actFlg
            sqlCommand.Parameters.Add(paraAcceptFlag)

            Dim paraCreatedMachine As SqlParameter
            paraCreatedMachine = New SqlParameter()
            paraCreatedMachine.Direction = ParameterDirection.Input
            paraCreatedMachine.SqlDbType = SqlDbType.VarChar
            paraCreatedMachine.ParameterName = Parameters.SignUp.CreatedMachine
            paraCreatedMachine.Value = createdMachine
            sqlCommand.Parameters.Add(paraCreatedMachine)

            Dim paraCreatedProgram As SqlParameter
            paraCreatedProgram = New SqlParameter()
            paraCreatedProgram.Direction = ParameterDirection.Input
            paraCreatedProgram.SqlDbType = SqlDbType.VarChar
            paraCreatedProgram.ParameterName = Parameters.SignUp.CreatedProgram
            paraCreatedProgram.Value = createdProgram
            sqlCommand.Parameters.Add(paraCreatedProgram)

            Dim paraUsername As SqlParameter
            paraUsername = New SqlParameter()
            paraUsername.Direction = ParameterDirection.Input
            paraUsername.SqlDbType = SqlDbType.VarChar
            paraUsername.ParameterName = Parameters.SignUp.UserName
            paraUsername.Value = userName
            sqlCommand.Parameters.Add(paraUsername)

            Dim paraEmail As SqlParameter
            paraEmail = New SqlParameter()
            paraEmail.Direction = ParameterDirection.Input
            paraEmail.SqlDbType = SqlDbType.VarChar
            paraEmail.ParameterName = Parameters.SignUp.Email
            paraEmail.Value = email
            sqlCommand.Parameters.Add(paraEmail)

             Dim paraFullName As SqlParameter
            paraFullName = New SqlParameter()
            paraFullName.Direction = ParameterDirection.Input
            paraFullName.SqlDbType = SqlDbType.VarChar
            paraFullName.ParameterName = Parameters.SignUp.FullName
            paraFullName.Value = fullName
            sqlCommand.Parameters.Add(paraFullName)

            Dim paraPassword As SqlParameter
            paraPassword = New SqlParameter()
            paraPassword.Direction = ParameterDirection.Input
            paraPassword.SqlDbType = SqlDbType.VarChar
            paraPassword.ParameterName = Parameters.SignUp.Password
            paraPassword.Value = password
            sqlCommand.Parameters.Add(paraPassword)


            Dim result As Integer = sqlCommand.ExecuteNonQuery()
            If (result = 1) Then
                retval = True
            Else
                retval = False
            End If
        Catch exception As Exception
            retval = False
            Throw
        Finally
            _conn.Close()
        End Try
        Return retval
    End Function

    Public Function CheckExistAccount(ByVal userName As String) As Integer Implements ISignUpRepository.CheckExistAccount
        Dim xmlReader As New XMLQueryReader
        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.SignUp.SignUp_02, Constants.SignUp.SignUp)
        Dim cmd As SqlCommand = New SqlCommand()
        Dim count As Integer
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
            pUsername.SqlDbType = SqlDbType.VarChar
            pUsername.ParameterName = Parameters.SignUp.UserName
            pUsername.Value = userName
            cmd.Parameters.Add(pUsername)

            count = cmd.ExecuteScalar()


        Catch ex As Exception
            _conn.Close()
            Throw ex


        End Try
        Return count
    End Function

    Public Function CheckExistEmail(ByVal email As String) As Integer Implements ISignUpRepository.CheckExistEmail
        Dim count As Integer
        Dim xmlReader As New XMLQueryReader
        Dim sqlQuery As String = xmlReader.GetSqlQuery(Constants.SignUp.SignUp_03, Constants.SignUp.SignUp)
        Dim sqlCommand As SqlCommand = New SqlCommand()
        Dim dr As SqlDataReader = Nothing
        Try
            sqlCommand.Connection = _conn
            sqlCommand.CommandText = sqlQuery
            sqlCommand.CommandType = CommandType.Text

            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If

            Dim pEmail As SqlParameter
            pEmail = New SqlParameter()
            pEmail.Direction = ParameterDirection.Input
            pEmail.SqlDbType = SqlDbType.VarChar
            pEmail.ParameterName = Parameters.SignUp.Email
            pEmail.Value = email
            sqlCommand.Parameters.Add(pEmail)

            count = sqlCommand.ExecuteScalar()


        Catch ex As Exception
            _conn.Close()
            Throw ex


        End Try
        Return count
    End Function
End Class

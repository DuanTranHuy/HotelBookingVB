Imports Entities

Public Interface ILoginRepository

    Function Login(ByVal userName As String) As Login
    Function CheckExistEmail(ByVal email As String) As Integer
    Function CheckExistAccount(ByVal userName As String) As Integer
End Interface
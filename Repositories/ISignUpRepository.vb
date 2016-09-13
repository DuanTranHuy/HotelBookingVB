Imports Entities

Public Interface ISignUpRepository

    Function SignUp(ByVal acceptFlag As String, ByVal createdMachine As String, ByVal createdProgram As String, 
                    ByVal userName As String, ByVal email As String, ByVal password As String) As Boolean
    Function CheckExistAccount(ByVal userName As String) As Boolean

End Interface
''' <summary>
''' Record for storing a client record in the common database
''' </summary>
Public NotInheritable Class SignUp
    Implements IKeyedEntity(Of Integer)
    Public Property Id As Integer Implements IKeyedEntity(Of Integer).Id
    Public Property AcceptFlag() As String
    Public Property CreatedMachine() As String
    Public Property CreatedProgram() As String
    Public Property CreatedDate() As String
    Public Property UserName() As String
    Public Property Email() As String
    Public Property Password() As String
    Public Property IsExistAccount() As Boolean 
    Public Property IsExistEmail() As Boolean 
End Class
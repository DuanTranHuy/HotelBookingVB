''' <summary>
''' Record for storing a client record in the common database
''' </summary>
Public NotInheritable Class Login
    Implements IKeyedEntity(Of Integer)

    Public Sub User()

    End Sub

    Public Property Id As Integer Implements IKeyedEntity(Of Integer).Id
    Public Property Email() As String
    Public Property FullName() As String
    Public Property UserName() As String
    Public Property Password() As String
    Public Property ExpFlg() As String

End Class
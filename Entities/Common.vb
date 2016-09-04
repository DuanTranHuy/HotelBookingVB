''' <summary>
''' Record for storing a client record in the common database
''' </summary>
Public NotInheritable Class Commons
    Implements IKeyedEntity(Of ULong)

    Public Property Id As ULong Implements IKeyedEntity(Of ULong).Id
    Public Property UserName() As String
    Public Property Password() As String
    Public Property ExpFlg() As String
    Public Property FunctionId() As ULong
    Public Property CFlg() As String
    Public Property RFlg() As String
    Public Property UFlg() As String
    Public Property DFlg() As String
    Public Property Email() As String

End Class
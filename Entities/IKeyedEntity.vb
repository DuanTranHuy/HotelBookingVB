''' <summary>
''' Interface defining any item we can store in a repository and can identify by 
''' an unique key
''' </summary>
''' <remarks>
''' This interface is typed so we can make type-safe code for retrieving the entity
''' (don't pass in an integer if the entity is keyed by string etc.)
''' </remarks>
Public Interface IKeyedEntity(Of TKeyType)

    ''' <summary>
    ''' Get the key to find the entity by
    ''' </summary>
    Property Id As TKeyType

End Interface
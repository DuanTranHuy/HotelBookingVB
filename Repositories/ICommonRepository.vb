Imports Entities
Public Interface ICommonRepository
    Sub LogUserLogin(ByVal userId As ULong, ByVal session As String, ByVal computerName As String, ByVal ipAdress As String)

    Sub LogUserLogOut(ByVal userId As ULong, ByVal session As String, ByVal computerName As String, ByVal ipAdress As String)
    Sub LogVisitedScreen(ByVal userId As ULong, ByVal userName As String, ByVal screenCode As String, ByVal screenName As String)
     Sub LogUserActivity(ByVal ctdUsr As String, ByVal ctdWks As String, ByVal ctdPgm As String, ByVal userId As ULong, ByVal userName As String, _
                        ByVal computerName As String, ByVal ipAdress As String, ByVal act As String, ByVal sql As String)
    Sub LogSpecialOperation(ByVal operation As String, ByVal key As String, ByVal author As String, ByVal reason As String)

    Sub LogUserActivities(ByVal ctdUsr As String, ByVal ctdWks As String, ByVal ctdPgm As String, ByVal userId As ULong, ByVal userName As String, _
                        ByVal computerName As String, ByVal ipAdress As String, ByVal act As String, ByVal sqlList As List(Of String))
End Interface

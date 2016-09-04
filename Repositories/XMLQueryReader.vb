Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Runtime.Remoting.Contexts
Imports System.Web
Imports System.Xml

Namespace DB.Common
    Public Class XMLQueryReader
        ''' <summary>
        ''' Get SQL Query From File XML
        ''' </summary>
        ''' <param name="id">ID SQL</param>
        ''' <returns>SQL Command</returns>
        Public Function GetSqlQuery(id As String, screenCode As String) As String

            Dim fileName As String = screenCode + Constants.ExtXml
            If id.ToLower().Contains(Constants.CommonFile) Then
                fileName = id.Substring(0, 8) + Constants.ExtXml
            End If
            Dim path = HttpContext.Current.Server.MapPath("~")
  
            Dim pathFile = Directory.GetParent(Directory.GetParent(path).FullName).FullName + Constants.PathXmlQuery + fileName
            Dim xmlFile As XmlReader = XmlReader.Create(pathFile, New XmlReaderSettings())
            Try
                Dim queryResult As String = String.Empty
                Dim ds As DataSet = New DataSet()
                ds.ReadXml(xmlFile)
                Dim countRow As Integer = ds.Tables(0).Rows().Count - 1
                For i As Integer = 0 To countRow
                    Dim idRow As String = ds.Tables(0).Rows(i)(Constants.SqlQueryId).ToString().Trim()
                    If idRow.Equals(id) Then
                        queryResult = ds.Tables(0).Rows(i)(Constants.SqlQueryData).ToString()
                    End If
                Next
                Return queryResult.Replace("\n", " ")

            Catch ex As Exception
                Throw ex
                Return String.Empty
            Finally
                xmlFile.Close()
            End Try

        End Function
    End Class
End Namespace


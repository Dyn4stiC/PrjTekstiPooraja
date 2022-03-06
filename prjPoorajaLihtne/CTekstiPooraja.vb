Public Class CTekstiPooraja

    Public Function PooraFunktsiooniga(ByVal strTekst As String) As String
        Dim strVastus As String = ""
        For Each c In strTekst
            strVastus = c & strVastus
        Next
        Return strVastus
    End Function


End Class

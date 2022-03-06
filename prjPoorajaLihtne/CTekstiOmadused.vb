Public Class CTekstiOmadused
    Private _strToodeldavTekst As String
    Private _strTahedNumbrid As String
    Private _intTaishaalikuteArv As Integer
    Private _boolPalindroom As Boolean


    Property palindroom As Boolean
        Get
            Return _boolPalindroom
        End Get
        Set(value As Boolean)
            _boolPalindroom = palindroom
        End Set
    End Property

    Property intTaishaalikuteArv As Integer
        Get
            Return _intTaishaalikuteArv
        End Get
        Set
            _intTaishaalikuteArv = Value
        End Set
    End Property

    Public ReadOnly Property strTahedNumbrid As String
        Get
            Return _strTahedNumbrid
        End Get
    End Property


    Public Sub New(ByVal str As String)
        _strToodeldavTekst = str
        LahendaString()
    End Sub


    Private Sub LahendaString()
        _strTahedNumbrid = JarjestaTahemargidNumbrid(_strToodeldavTekst)
        _boolPalindroom = KontrolliPalindroom(_strToodeldavTekst)
        LoeTaishaalikuteArv(_strToodeldavTekst)
    End Sub

    ' otsib üles vaid tähemärgid, ignoreerides kõike muud.
    Public Function JarjestaTahemargidNumbrid(ByVal str As String) As String
        Dim vastus As String = ""
        Dim tahemargid As String = ""
        Dim numbrid As String = ""
        For Each ch In str
            If Char.IsLetter(ch) Then
                tahemargid += ch
            ElseIf Char.IsNumber(ch) Then
                numbrid += ch
            End If
        Next

        If tahemargid.Length = 0 And numbrid.Length = 0 Then
            vastus = "Puuduvad tähed ja numbrid"
        Else
            vastus = tahemargid + numbrid
        End If
        Return vastus
    End Function


    Public Sub LoeTaishaalikuteArv(ByVal strTekst As String)
        Dim kogus As Integer = 0
        Dim referents As String = "aeiou"
        For Each c In strTekst
            If referents.IndexOf(Char.ToLower(c)) <> -1 Then
                kogus += 1
            End If
        Next
        _intTaishaalikuteArv = kogus
    End Sub


    Public Function KontrolliPalindroom(ByVal strTekst As String) As Boolean
        If strTekst = "" Then
            Return False
        End If
        If strTekst = StrReverse(strTekst) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

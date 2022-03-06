Public Class EkraaniVorm
    Private Sub btnPoora_Click(sender As Object, e As EventArgs) Handles btnPoora.Click
        Dim pooraja As New CTekstiPooraja
        txtPooratudTekst.Text = pooraja.PooraFunktsiooniga(txtSisendTekst.Text)

        Dim omadusteLeidja As New CTekstiOmadused(txtSisendTekst.Text)
        txtTaishaalikuid.Text = omadusteLeidja.intTaishaalikuteArv
        txtPalindroom.Text = PalindroomVastus(omadusteLeidja.KontrolliPalindroom(txtSisendTekst.Text))
        txtTahemargid.Text = omadusteLeidja.strTahedNumbrid

    End Sub

    public Function PalindroomVastus(vastus As Boolean) As String
        If vastus Then
            return "Jah"
        Else
            return "Ei"
        End If
    End Function

End Class

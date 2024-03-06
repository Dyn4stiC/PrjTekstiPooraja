Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PrjTekstiOmadused

<TestClass()> Public Class CEkraaniVormTest

    <DataRow("aba", "Jah")>
    <DataRow("pxjlkis", "Ei")>
    <DataTestMethod()> Public Sub PalindroomVastus_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.EkraaniVorm
        Dim omadusteLeidja As New CTekstiOmadused(sisend)
        Dim vastus = testija.PalindroomVastus(omadusteLeidja.KontrolliPalindroom(sisend))
        Assert.AreEqual(oodatavVastus, vastus)
    End Sub
End Class
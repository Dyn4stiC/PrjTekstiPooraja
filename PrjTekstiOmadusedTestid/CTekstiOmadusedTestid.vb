Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiOmadusedTestid

    <DataRow("aba", 2)>
    <DataRow("pxjlkis", 1)>
    <DataRow("pxjlkis", 1)>
    <DataRow("ttt", 0)>
    <DataRow("aaa", 3)>
    <DataRow("abcddd", 1)>
    <DataRow("aEiOxX", 4)>
    <DataTestMethod()> Public Sub LoeTaishaalikuteArv_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.intTaishaalikuteArv
        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

    <TestMethod()>
    Public Sub KontrolliPaliondroom_SonaAnna_VastusToene()
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused("anna")
        Dim vastus = testija.boolPalindroom
        Assert.IsTrue(vastus)
    End Sub

    <TestMethod()>
    Public Sub KontrolliPaliondroom_SonaAnnb_VastusVaar()
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused("annb")
        Dim vastus = testija.boolPalindroom
        Assert.IsFalse(vastus)
    End Sub

    <TestMethod()>
    Public Sub KontrolliPaliondroom_SonaTyhik_VastusVaar()
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused("")
        Dim vastus = testija.boolPalindroom
        Assert.IsFalse(vastus)
    End Sub

    <DataRow("aba", "aba")>
    <DataRow("", "Puuduvad tähed ja numbrid")>
    <DataRow("a1b2c3", "abc123")>
    <DataTestMethod()> Public Sub JarjestaTahemargidNumbrid_AndmepohineTest(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus As String
        vastus = testija.JarjestaTahemargidNumbrid(sisend)
        Assert.AreEqual(oodatavVastus, vastus)
    End Sub
End Class
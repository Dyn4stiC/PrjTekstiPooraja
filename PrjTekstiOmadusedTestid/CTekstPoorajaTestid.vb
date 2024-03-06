Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstPoorajaTestid

    <TestMethod()> Public Sub PooraFunktsiooniga_YksSona_VastusPooratudSona()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("abcxyz")
        Assert.AreEqual(vastus, "zyxcba")
    End Sub

End Class
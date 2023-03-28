Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WindowsApp3

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()

        Dim w As New WindowsApp3.Student
        Dim expected As String
        expected = "HIHowie" '期望值



        Dim actual As String = w.talk("Howie")

        Assert.AreEqual(expected, actual)
    End Sub

End Class
Public Class Student
    Dim Name As String

    Dim Grade As Integer



    Public Function talk() As String

        Return "HI"
    End Function

    Public Function talk(Name As String) As String
        Me.Name = Name

        Return "HI" + Name
    End Function


End Class

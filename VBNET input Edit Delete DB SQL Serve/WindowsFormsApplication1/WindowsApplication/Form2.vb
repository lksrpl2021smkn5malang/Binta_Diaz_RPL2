Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num As Integer
        Dim Array(5) As String

        For num = 0 To 5
            Array(num) = InputBox("Enter the customer name", "Enter Name")

            ListBox1.Items.Add(Array(num))
        Next
    End Sub
End Class
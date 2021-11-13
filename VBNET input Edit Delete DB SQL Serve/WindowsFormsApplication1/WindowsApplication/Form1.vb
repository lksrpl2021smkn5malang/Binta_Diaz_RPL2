Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Array As String()
        Array = New String() {1, 2, 3}
        MsgBox(Array.Length)
    End Sub
End Class

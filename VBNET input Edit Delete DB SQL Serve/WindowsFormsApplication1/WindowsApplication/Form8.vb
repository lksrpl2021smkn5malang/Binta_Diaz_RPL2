Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sum(5, 6)
    End Sub

    Sub sum(a As Single, b As Single)
        MsgBox("sum=" & a + b)
    End Sub
End Class
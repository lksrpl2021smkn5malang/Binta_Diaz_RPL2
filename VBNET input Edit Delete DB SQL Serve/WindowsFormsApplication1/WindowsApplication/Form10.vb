Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TextBox2.Text = Math.Abs(Val(TextBox1.Text))
        TextBox2.Text = Math.Exp(Val(TextBox1.Text))
    End Sub
End Class
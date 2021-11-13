Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tcolor As String
        If RadioButton1.Checked Then
            Tcolor = "Red Color"
            TextBox1.ForeColor = Color.Red
        ElseIf RadioButton3.Checked Then
            Tcolor = "Green Color"
            TextBox1.ForeColor = Color.Green
        Else
            Tcolor = "Yellow Color"
            TextBox1.ForeColor = Color.Yellow

        End If

        TextBox1.Text = Tcolor
    End Sub
End Class
Public Class Form9
    Private Function BMI(Height As Single, Weight As Single) As Double
        BMI = Weight / Height ^ 2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Single, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        TextBox3.Text = BMI(h, w)

    End Sub
End Class
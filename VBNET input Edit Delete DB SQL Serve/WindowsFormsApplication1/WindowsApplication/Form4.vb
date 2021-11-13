Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myNumber As Integer
        myNumber = TxtNum.Text
        If myNumber > 100 Then
            MsgBox(” Congratulation! You win a lucky prize”)
        Else
            MsgBox(” Sorry, You did not win any prize”)
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
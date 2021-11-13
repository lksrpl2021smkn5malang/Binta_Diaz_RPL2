Public Class Form15
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        TxtErrMsg.Visible = False

        Dim firstNum, secondNum, answer As Double

        Try
            firstNum = TxtNum1.Text
            secondNum = TxtNum2.Text
            answer = firstNum / secondNum
            TxtAnswer.Text = answer
        Catch ex As Exception

            TxtAnswer.Text = "Error"
            TxtErrMsg.Visible = True
            TxtErrMsg.Text = "One of the entries is not a number! Try again!"

        End Try
    End Sub

    Private Sub BtnCalculate_MouseHover(sender As Object, e As EventArgs) Handles BtnCalculate.MouseHover

    End Sub
End Class
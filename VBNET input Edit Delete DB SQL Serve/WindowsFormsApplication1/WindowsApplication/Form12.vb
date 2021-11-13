Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const LX As Integer = 100
        Const BN As Integer = 500
        Const SD As Integer = 200
        Const HD As Integer = 80
        Const AM As Integer = 150
        Dim sum As Integer
        If CheckBox1.Checked = True Then
            sum += LX
        End If

        If CheckBox2.Checked = True Then
            sum += BN
        End If

        If CheckBox3.Checked = True Then
            sum += SD
        End If

        If CheckBox4.Checked = True Then
            sum += HD
        End If

        If CheckBox5.Checked = True Then
            sum += AM
        End If
        TextBox1.Text = sum.ToString("c")

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
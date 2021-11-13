Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Counter As Integer
        For Counter = 1 To 10
            ListBox1.Items.Add(Counter)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum, n As Integer

        ListBox1.Items.Add(“n” & vbTab & “Sum”)
        ListBox1.Items.Add(“———————-”)
        Do
            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)
            If n = 10 Then
                Exit Do
            End If
        Loop

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum, n As Integer
        ListBox1.Items.Add("n" & vbTab & "sum")
        ListBox1.Items.Add("———————-")

        While n <> 10

            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)

        End While
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
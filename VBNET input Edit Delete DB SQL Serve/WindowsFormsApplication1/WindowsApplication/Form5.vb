Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai As Integer
        Dim Predikat As String

        Nilai = TxtNilai.Text
        If Nilai >= 80 And Nilai <= 100 Then
            Predikat = "A"
        ElseIf Nilai >= 60 And Nilai < 80 Then
            Predikat = "B"
        ElseIf Nilai >= 40 And Nilai < 60 Then
            Predikat = "C"

        Else
            Nilai = "Out of Range"
        End If
        MsgBox("Predikat Anda adalah " & Predikat)
    End Sub
End Class
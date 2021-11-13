Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Predikat As String
        Predikat = TxtPredikat.Text
        Select Case Predikat
            Case "A"
                MsgBox("Baik Sekali")
            Case "B"
                MsgBox("Baik")
            Case "C"
                MsgBox("Cukup")
            Case Else
                MsgBox("Gagal")
        End Select
    End Sub
End Class
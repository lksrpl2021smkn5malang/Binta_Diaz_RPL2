Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String
        nama = TextBox1.Text
        TextBox2.Text = "Nama Anda adalah " + nama

        Dim tanggal As Date
        MsgBox(tanggal.ToShortDateString & " " & tanggal.ToShortTimeString, , "Message")

        Dim strTanggal As String = Today
        Dim strWaktu As String = Now
        MsgBox("Tanggal : " & strTanggal & vbCrLf &
               "Saat Ini: " & strWaktu, , "Message")

        Dim YourName As String = "Binta"
        Dim MyMsg As String
        MyMsg = "Happy Birthday!"
        MsgBox(MyMsg & YourName)
    End Sub
End Class
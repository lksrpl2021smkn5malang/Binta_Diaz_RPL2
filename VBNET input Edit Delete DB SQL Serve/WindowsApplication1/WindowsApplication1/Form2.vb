Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nil1, nil2, hasil As Integer
        nil1 = Val(txtNilai1.Text)
        nil2 = Val(txtNilai2.Text)
        hasil = nil1 * nil2
        txtHasil.Text = hasil
        MsgBox("Hasil penjumlahan = " & hasil)
        Label3.Text = hasil
    End Sub
End Class
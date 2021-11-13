Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str1 = "Visual ", str2 = "Basic ", str3 = "2015", str As String
        str = str1 + str2 + str3
        MsgBox(str)

        Dim MyText As String
        MyText = "Good Morning"
        MsgBox(Len(MyText))

        Dim Text As String
        Text = "Visual Basic 2015"
        MsgBox(Microsoft.VisualBasic.Right(Text, 4))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")
        LblPhrase.Text = myPhrase
        LblExtract.Text = Mid(myPhrase, 2, 6)
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "data source=DESKTOP-9T0N366\SQLEXPRESS;initial catalog=DB_APLIKASI;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from TB_MAHASISWA", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TB_MAHASISWA")
        DataGridView1.DataSource = (Ds.Tables("TB_MAHASISWA"))
        ComboBox1.Text = ""
        ComboBox1.Items.Add("Pria")
        ComboBox1.Items.Add("Wanita")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Dim InputData As String = "insert into TB_MAHASISWA values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Cmd = New SqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diinput")
        Call KondisiAwal()
    End Sub
End Class
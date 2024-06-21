Imports System.Data.Odbc
Public Class Form_Login
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=dbfancell"
        con.Open()

    End Sub
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.UseSystemPasswordChar = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Exclamation, "Isi Username dan Password")

        ElseIf TextBox1.Text = "AT8983" And TextBox2.Text = "101077" Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
            FormMenu.Show()
            Me.Hide()
        Else
            MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
            Call Bersih()
            TextBox1.Focus()
        End If

    End Sub

    Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
        TextBox2.Focus()
    End Sub

    Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Username dan Password tidak boleh kosong", MsgBoxStyle.Exclamation, "Isi Username dan Password")

            ElseIf TextBox1.Text = "AT8983" And TextBox2.Text = "101077" Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
                FormMenu.Show()
                Me.Hide()
            Else
                MsgBox("Kombinasi Username dan Password Salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
                Call Bersih()
                TextBox1.Focus()
            End If
        End If
    End Sub
End Class
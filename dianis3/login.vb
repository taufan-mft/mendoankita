Public Class login
    Public Shared username, password, id As String

    Dim winny As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txtPassword.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim cek As String = "Select * From pegawai Where us= '" & txtUserName.Text & "' and pa = '" & txtPassword.Text & "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)


        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            username = txtUserName.Text
            password = txtPassword.Text

            While DM.Read

                'MsgBox(DM.GetString(0))
                Label3.Text = DM.GetString(0)
            End While

            id = Label3.Text


            Dim box As New pegawai()
            Dim box2 As New Form1()
            box2.Show()
            box.Show()


        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            'Me.Show()
        End If

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksiDB()

    End Sub
End Class
Public Class showtime
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDShowtime, MetroTextBox1)
        clearForm(txtIDShowtime, MetroTextBox1)
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub showtime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''MetroDateTime1.CustomFormat = "HH:mm"
        ''MetroDateTime1.Format = DateTimePickerFormat.Custom
        '' MetroDateTime1.CustomFormat = "HH:mm"
        ''MetroDateTime1.ShowUpDown = True

        Dim cek As String = "Select judul_film from film"
        CMD = New OleDb.OleDbCommand(cek, Conn)


        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            While DM.Read

                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                MetroComboBox1.Items.Add(DM.GetString(0))

            End While
        End If
        cek = "Select nama_audi from auditorium"
        CMD = New OleDb.OleDbCommand(cek, Conn)


        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            While DM.Read

                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                MetroComboBox2.Items.Add(DM.GetString(0))

            End While
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        MetroLabel5.Text = retrieveID(MetroComboBox1.SelectedItem.ToString, "film", "ID_film", "judul_film")
    End Sub
End Class
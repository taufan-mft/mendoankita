Public Class showtime
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDShowtime, MetroTextBox1)
        clearForm(txtIDShowtime, MetroTextBox1)
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ''     showtoBox(e.RowIndex, DataGridView1, PictureBox1, MetroLabel6, txtFoto, txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
        txtIDShowtime.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        MetroComboBox1.SelectedIndex = MetroComboBox1.FindString(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        MetroComboBox2.SelectedIndex = MetroComboBox2.FindString(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        MetroTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        ''  btnSave.Enabled = False
        ''btnInput.Enabled = False
        txtIDShowtime.Enabled = False
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
        tampilkanData("select ID_showtime, judul_film, nama_audi, jam_tayang from (showtime INNER JOIN film ON showtime.ID_film=film.ID_film) INNER JOIN auditorium ON showtime.ID_auditorium = auditorium.ID_auditorium ", DataGridView1)
        tampilkanData("select * from seat", DataGridView1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtIDShowtime, MetroTextBox1) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            Dim winny As Boolean = checkDuplicate("showtime", "ID_showtime", txtIDShowtime.Text)
            If winny = True Then
                MsgBox("weh duploikat")
            Else
                simpanData("showtime", txtIDShowtime.Text, retrieveID(MetroComboBox1.SelectedItem.ToString, "film", "ID_film", "judul_film"), retrieveID(MetroComboBox2.SelectedItem.ToString, "auditorium", "ID_auditorium", "nama_audi"), MetroTextBox1.Text)
                Dim char2 As String
                tampilkanData("select ID_showtime, judul_film, nama_audi, jam_tayang from (showtime INNER JOIN film ON showtime.ID_film=film.ID_film) INNER JOIN auditorium ON showtime.ID_auditorium = auditorium.ID_auditorium ", DataGridView1)
                For index As Integer = 1 To 3
                    Select Case index
                        Case 1
                            char2 = "A"
                        Case 2
                            char2 = "B"
                        Case 3
                            char2 = "C"
                    End Select
                    For index2 As Integer = 1 To 20
                        simpanData("seat", GetRandom(1, 400), retrieveID(MetroComboBox2.SelectedItem.ToString, "auditorium", "ID_auditorium", "nama_audi"), "0", txtIDShowtime.Text, char2, index2)
                    Next
                Next


            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        MetroLabel5.Text = retrieveID(MetroComboBox1.SelectedItem.ToString, "film", "ID_film", "judul_film")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtIDShowtime, MetroTextBox1) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            updateData("showtime", "ID_showtime", txtIDShowtime.Text, "ID_film", retrieveID(MetroComboBox1.SelectedItem.ToString, "film", "ID_film", "judul_film"), "ID_auditorium", retrieveID(MetroComboBox2.SelectedItem.ToString, "auditorium", "ID_auditorium", "nama_audi"), "jam_tayang", MetroTextBox1.Text)
            tampilkanData("select ID_showtime, judul_film, nama_audi, jam_tayang from (showtime INNER JOIN film ON showtime.ID_film=film.ID_film) INNER JOIN auditorium ON showtime.ID_auditorium = auditorium.ID_auditorium", DataGridView1)
            'clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
            'matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapusData("showtime", "ID_showtime", txtIDShowtime.Text)
    End Sub
End Class
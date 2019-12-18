Public Class transaksi
    Dim idFilm As String
    Dim grandtotal As Integer = 0
    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        Dim winny As String

        idFilm = MetroComboBox1.SelectedItem.ToString
        txtJudulFilm.Text = idFilm
        idFilm = retrieveID(idFilm, "film", "ID_film", "judul_film")
        Dim cek As String = "select jam_tayang from showtime where ID_film = '" + idFilm + "'"
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

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged
        Dim winny As String
        Dim ra23i As String

        winny = MetroComboBox2.SelectedItem.ToString
        winny = retrieveID(winny, idFilm, "showtime", "ID_showtime", "jam_tayang", "ID_film")
        ra23i = retrieveID(MetroComboBox1.SelectedItem.ToString, "film", "ID_film", "judul_film")
        Dim cek As String = "select baris, kolom from seat where ID_showtime = '" + winny + "' and is_occupied = '0'"
        CMD = New OleDb.OleDbCommand(cek, Conn)


        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            While DM.Read

                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                MetroComboBox3.Items.Add(DM.GetString(0) + DM.GetString(1))

            End While
        End If
        ra23i = retrieveID(winny, "showtime", "ID_auditorium", "ID_showtime")
        cek = "select nama_audi, harga_kursi from auditorium where ID_auditorium = '" + ra23i + "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)


        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            While DM.Read

                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                txtAuditorium.Text = DM.GetString(0)
                MetroLabel6.Text = DM.GetString(1)

            End While
        End If
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        DataGridView1.Rows.Add(New String() {MetroComboBox1.SelectedItem.ToString, MetroComboBox2.SelectedItem.ToString, MetroComboBox3.SelectedItem.ToString})
        MetroComboBox3.Items.Remove(MetroComboBox3.SelectedItem)
        MetroComboBox3.Update()
        MetroComboBox1.Enabled = False
        MetroComboBox2.Enabled = False
        grandtotal = grandtotal + Int(MetroLabel6.Text)
        txtGrandtotal.Text = grandtotal.ToString
    End Sub
End Class
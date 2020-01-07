Public Class transaksi
    Dim idFilm As String
    Dim grandtotal As Integer = 0
    Dim banyakBaris As Integer = 0
    'Dim winny As String
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    Public winny As String
    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cek As String = "Select judul_film from film"
        CMD = New OleDb.OleDbCommand(cek, Conn)
        txtKode.Text = GetRandom(1, 25000).ToString
        txtIDpeg.Text = login.id
        DM = CMD.ExecuteReader()

        If DM.HasRows = True Then

            'MsgBox("Dianis")
            While DM.Read

                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                MetroComboBox1.Items.Add(DM.GetString(0))

            End While
        End If
        Try
            PictureBox1.Image = QR_Generator.Encode(txtKode.Text)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub rai()
        txtKode.Text = GetRandom(1, 25000).ToString
        Try
            PictureBox1.Image = QR_Generator.Encode(txtKode.Text)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

        MetroComboBox2.Items.Clear()
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

    Public Sub loadGrid()
        Dim harga As Integer

        For index As Integer = 0 To seat.selectedSeats.Length - 1
            If (seat.selectedSeats(index) <> Nothing) Then
                DataGridView1.Rows.Add(New String() {MetroComboBox1.SelectedItem.ToString, MetroComboBox2.SelectedItem.ToString, seat.selectedSeats(index)})
            End If
        Next
        harga = (DataGridView1.Rows.Count) * CInt(MetroLabel6.Text)
        txtGrandtotal.Text = harga.ToString
        banyakBaris = DataGridView1.Rows.Count
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        DataGridView1.Rows.Add(New String() {MetroComboBox1.SelectedItem.ToString, MetroComboBox2.SelectedItem.ToString, MetroComboBox3.SelectedItem.ToString})
        MetroComboBox3.Items.Remove(MetroComboBox3.SelectedItem)
        MetroComboBox3.Update()
        MetroComboBox1.Enabled = False
        MetroComboBox2.Enabled = False
        '' MetroLabel10.Text = DataGridView1.Rows.Count

        '' MetroLabel10.Text = banyakBaris
        grandtotal = grandtotal + Int(MetroLabel6.Text)
        txtGrandtotal.Text = grandtotal.ToString
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim baris As String
        Dim kolom As String
        Dim idSeat As String
        simpanData("transaksi", txtKode.Text, txtIDpeg.Text, winny, banyakBaris.ToString, Date.Now.ToString, txtGrandtotal.Text)
        For index2 As Integer = 0 To banyakBaris - 1
            baris = DataGridView1.Rows(index2).Cells(2).Value
            baris = baris.Substring(0, 1)
            kolom = DataGridView1.Rows(index2).Cells(2).Value
            If (kolom.Length) = 2 Then
                kolom = kolom.Substring(1, 1)
            End If

            If (kolom.Length) = 3 Then
                kolom = kolom.Substring(1, 2)
            End If

            idSeat = retrieveID(baris, kolom, "seat", "ID_seat", "baris", "kolom")
            updateData("seat", "ID_seat", idSeat, "is_occupied", "1")
            Dim yog As Integer
            While True
                yog = GetRandom(1, 6000)
                If (checkDuplicate("tiket", "ID_tiket", yog.ToString) = False) Then
                    Exit While
                End If
            End While

            simpanData("tiket", yog.ToString, winny, idSeat, Date.Now.ToString, txtKode.Text)
        Next

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim kursi As New seat()
        kursi.Show()
    End Sub
End Class
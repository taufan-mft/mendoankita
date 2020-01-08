Public Class pegawai
    Dim OpenFileDialog1 As New OpenFileDialog
    Public Shared winnyName As String
    Dim statusCari As Boolean = True
    Private Sub pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'koneksiDB()
        txtKelaminPeg.Hide()
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtNamaPeg, txtNoHPPeg)
        tampilkanData("SELECT * FROM pegawai", DataGridView1)
        If (login.id <> "") Then
            ' Dim nomer As Integer
            'nomer = Integer.Parse(login.id) - 1
            'showtoBox(nomer, DataGridView1, PictureBox1, MetroLabel6, txtFoto, txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
            'MetroLabel8.Text = DataGridView1.Rows(nomer).Cells(1).Value
            winnyName = login.id
        End If
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg, txtPassword, txtUsername)
        clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        btnSave.Enabled = True
        btnInput.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtNamaPeg, txtNoHPPeg) = True) Then
            MsgBox("Jangan kosong")
        Else
            Dim winny As Boolean = checkDuplicate("pegawai", "ID_pegawai", txtIDPeg.Text)
            If winny = True Then
                MsgBox("weh duploikat")
            Else
                txtKelaminPeg.Text = Cbxkelamin.SelectedItem.ToString
                txtJabatanPeg.Text = cbxjabatan.SelectedItem.ToString
                simpanData("pegawai", txtIDPeg.Text, txtNamaPeg.Text, txtAlamatPeg.Text, txtNoHPPeg.Text, txtKelaminPeg.Text, txtJabatanPeg.Text, txtUsername.Text, txtPassword.Text, txtFoto.Text, Date1.Value.ToString)
                tampilkanData("SELECT * FROM pegawai", DataGridView1)
            End If
        End If
    End Sub

    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        showtoBox(e.RowIndex, DataGridView1, PictureBox1, MetroLabel6, txtFoto, Cbxkelamin, cbxjabatan, txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
        nyalainForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)

        btnSave.Enabled = False
        btnInput.Enabled = False
        txtIDPeg.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg) = True) Then
            MsgBox("Jangan kosong")
        Else

            updateData("pegawai", "ID_pegawai", txtIDPeg.Text, "namapegawai", txtNamaPeg.Text, "alamat", txtAlamatPeg.Text, "nomorhp", txtNoHPPeg.Text,
                       "jeniskelamin", Cbxkelamin.SelectedItem.ToString, "jabatan", cbxjabatan.SelectedItem.ToString, "foto", txtFoto.Text, "tanggal_lahir", Date1.Text)
            tampilkanData("SELECT * FROM pegawai", DataGridView1)
            clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
            matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        End If
    End Sub

    Private Sub txtBrowse_Click(sender As Object, e As EventArgs) Handles txtBrowse.Click
        Try
            OpenFileDialog1.Filter = " Image File (*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif"

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
                txtFoto.Text = OpenFileDialog1.FileName

            End If

        Catch ex As Exception
            Throw New ApplicationException("Gambar Gagal Masuk")

        End Try

        'OpenFileDialog1.Filter = " Image File (*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif"         'OpenFileDialog1.RestoreDirectory = True         'OpenFileDialog1.ShowDialog()         'If OpenFileDialog1.FileName = "" Then Exit Sub         'PictureBox1.ImageLocation = OpenFileDialog1.FileName         'txtnamaphotokaryawan.Text = OpenFileDialog1.FileName 

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapusData("pegawai", "ID_Pegawai", txtIDPeg.Text)
        tampilkanData("SELECT * FROM pegawai", DataGridView1)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        nyalainForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        Dim pegawai = InputBox("Woi anjeng, masukin ID pegawai!")

        Try
            DS.Tables(0).PrimaryKey = New DataColumn() {DS.Tables(0).Columns("ID_Pegawai")}
            Dim row As DataRow
            row = DS.Tables(0).Rows.Find(pegawai)
            txtNamaPeg.Text = row("namapegawai")
            txtAlamatPeg.Text = row("alamat")
            txtKelaminPeg.Text = row("jeniskelamin")
            txtNoHPPeg.Text = row("nomorhp")
            txtJabatanPeg.Text = row("jabatan")
            txtFoto.Text = row("foto")

            Refresh()
            MsgBox(txtNamaPeg.Text)
            Refresh()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCariDGV_Click(sender As Object, e As EventArgs) Handles btnCariDGV.Click
        If (statusCari) Then
            cariDGV(DataGridView1, "pegawai", "ID_pegawai", "namapegawai", "alamat", txtCariDGV.Text)
            btnCariDGV.Text = "Reset"
            statusCari = False
        Else
            tampilkanData("SELECT * FROM pegawai", DataGridView1)
            btnCariDGV.Text = "Cari"
            txtCariDGV.Text = ""
            statusCari = True
        End If
    End Sub

    Private Sub Date1_ValueChanged(sender As Object, e As EventArgs) Handles Date1.ValueChanged
        Dim umur, bulan, hari, tl, ts As Integer
        tl = Year(Date1.Value)
        ts = Year(Now)
        umur = ts - tl
        bulan = DateDiff(DateInterval.Month, CDate(Date1.Value), CDate(Now))
        hari = DateDiff(DateInterval.Day, CDate(Date1.Value), CDate(Now))
        Select Case bulan

            Case 0 To 6 : txtumur.Text = 1
            Case 7 To 12 : txtumur.Text = 2
            Case 13 To 18 : txtumur.Text = 3
            Case 19 To 24 : txtumur.Text = 4
            Case 25 To 30 : txtumur.Text = 5
            Case 31 To 36 : txtumur.Text = 6
            Case 36 To 42 : txtumur.Text = 7

        End Select
        txtumur.Text = umur.ToString
    End Sub

    Private Sub txtumur_Click(sender As Object, e As EventArgs) Handles txtumur.Click

    End Sub
End Class
Public Class pegawai
    Dim OpenFileDialog1 As New OpenFileDialog
    Private Sub pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksiDB()
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        tampilkanData("SELECT * FROM pegawai", DataGridView1)
        If (login.id <> "") Then
            Dim nomer As Integer
            nomer = Integer.Parse(login.id) - 1
            showtoBox(nomer, DataGridView1, PictureBox1, MetroLabel6, txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
        End If
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        btnSave.Enabled = True
        btnInput.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            Dim winny As Boolean = checkDuplicate("pegawai", "ID_pegawai", txtIDPeg.Text)
            If winny = True Then
                MsgBox("weh duploikat")
            Else
                simpanData("pegawai", txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
                tampilkanData("SELECT * FROM pegawai", DataGridView1)
            End If
        End If
    End Sub

    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        showtoBox(e.RowIndex, DataGridView1, PictureBox1, MetroLabel6, txtIDPeg, txtNamaPeg, txtAlamatPeg, txtNoHPPeg, txtKelaminPeg, txtJabatanPeg)
        nyalainForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)

        btnSave.Enabled = False
        btnInput.Enabled = False
        txtIDPeg.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            updateData("pegawai", "ID_pegawai", txtIDPeg.Text, "namapegawai", txtNamaPeg.Text, "alamat", txtAlamatPeg.Text, "nomorhp", txtNoHPPeg.Text,
                       "jeniskelamin", txtKelaminPeg.Text, "jabatan", txtJabatanPeg.Text, "us", login.username, "pa", login.password, "foto", txtFoto.Text)
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

End Class
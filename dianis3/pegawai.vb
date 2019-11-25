Public Class pegawai
    Private Sub pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matiForm(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg)
        tampilkanData("SELECT * FROM pegawai", DataGridView1)
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

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtAlamatPeg, txtIDPeg, txtJabatanPeg, txtKelaminPeg, txtNamaPeg, txtNoHPPeg) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            MsgBox("Weh ga kosong")
        End If
    End Sub
End Class
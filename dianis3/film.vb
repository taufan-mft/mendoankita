Public Class film
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
        clearForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
    End Sub

    Private Sub film_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matiForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
        tampilkanData("SELECT * FROM film", DataGridView1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            Dim winny As Boolean = checkDuplicate("film", "ID_film", txtIDFilm.Text)
            If winny = True Then
                MsgBox("weh duploikat")
            Else
                simpanData("film", txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
                tampilkanData("SELECT * FROM film", DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            updateData("film", "ID_film", txtIDFilm.Text, "judul_film", txtJudulFilm.Text, "genre_film", txtGenreFilm.Text, "rating", txtRatingFilm.Text)
            tampilkanData("SELECT * FROM film", DataGridView1)
            clearForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
            matiForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (checkEmpty(txtIDFilm) = True) Then
            MsgBox("Tidak ada data yang dipilih.")
        ElseIf MessageBox.Show("Yakin ga?", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            hapusData("film", "ID_film", txtIDFilm.Text)
            tampilkanData("SELECT * FROM film", DataGridView1)

        End If
    End Sub
End Class
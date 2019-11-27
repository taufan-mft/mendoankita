Public Class film
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
        clearForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
    End Sub

    Private Sub film_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        matiForm(txtIDFilm, txtJudulFilm, txtGenreFilm, txtRatingFilm)
        tampilkanData("SELECT * FROM film", DataGridView1)
    End Sub
End Class
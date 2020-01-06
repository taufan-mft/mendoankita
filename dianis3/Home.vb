Public Class home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksiDB()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Dim dian As New pegawai()
        dian.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim dian As New film()
        dian.Show()
    End Sub

    Private Sub btnFnb_Click(sender As Object, e As EventArgs)
        Dim dian As New foodAndBeverages()
        dian.Show()
    End Sub

    Private Sub btnShowTIme_Click(sender As Object, e As EventArgs)
        Dim showtime As New showtime()
        showtime.Show()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        Dim raisa As New audi()
        raisa.Show()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Dim rai As New transaksi()
        rai.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        pegawai.Show()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        pegawai.Show()

    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        film.Show()

    End Sub

    Private Sub ShowtimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowtimeToolStripMenuItem.Click
        showtime.Show()

    End Sub

    Private Sub FnBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FnBToolStripMenuItem.Click
        foodAndBeverages.Show()


    End Sub

    Private Sub AuditoriumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditoriumToolStripMenuItem.Click
        audi.Show()

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        transaksi.Show()
    End Sub

    Private Sub DataTranskaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTranskaksiToolStripMenuItem.Click
        crlaporanfnb.Show()
    End Sub
    Private Sub DataFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataFilmToolStripMenuItem.Click
        crlaporanpegawai.Show()
    End Sub
    Private Sub DataFilmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataFilmToolStripMenuItem1.Click
        crlaporanfilm.Show()
    End Sub
    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click

    End Sub
    Private Sub DataTransaksiFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiFilmToolStripMenuItem.Click

    End Sub
    Private Sub TiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiketToolStripMenuItem.Click
        crlaporantiket.Show()

    End Sub
End Class

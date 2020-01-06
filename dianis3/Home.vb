Public Class Form1
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

    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDataToolStripMenuItem.Click
        resetData.Show()
    End Sub

    Private Sub SeatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeatToolStripMenuItem.Click
        seat.Show()
    End Sub
End Class

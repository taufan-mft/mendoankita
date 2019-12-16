Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksiDB()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim dian As New pegawai()
        dian.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim dian As New film()
        dian.Show()
    End Sub

    Private Sub btnFnb_Click(sender As Object, e As EventArgs) Handles btnFnb.Click
        Dim dian As New foodAndBeverages()
        dian.Show()
    End Sub

    Private Sub btnShowTIme_Click(sender As Object, e As EventArgs) Handles btnShowTIme.Click
        Dim showtime As New showtime()
        showtime.Show()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim raisa As New audi()
        raisa.Show()
    End Sub
End Class

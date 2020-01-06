Public Class resetData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hapusData("seat")
    End Sub

    Private Sub resetData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hapusData("film")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hapusData("showtime")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hapusData("tiket")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hapusData("transaksi")
    End Sub
End Class
Public Class Cetaktiket
    Private Sub btncetaknota_Click(sender As Object, e As EventArgs) Handles btncetaknota.Click
        cetaknota.CrystalReportNota1.SetParameterValue("id", transaksi.txtKode.Text)

        cetaknota.Show()
    End Sub
End Class
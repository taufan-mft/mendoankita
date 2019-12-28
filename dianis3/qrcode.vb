Imports MessagingToolkit.Barcode.BarcodeDecoder
Imports MessagingToolkit.QRCode.Codec


Public Class qrcode
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PictureBox1.Image = QR_Generator.Encode(TextBox1.Text)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox2.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = TextBox1.Text
        Try
            PictureBox1.Image = BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, TextBox1.Text)

            'PictureBox2.Image = New Bitmap(BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.ISBN, TextBox2.Text)) 

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OPD As New OpenFileDialog
        OPD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If OPD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox2.Load(OPD.FileName)
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result

        Try
            result = Scanner.Decode(New Bitmap(PictureBox2.Image))
            MsgBox(result.Text)
            TextBox2.Text = result.Text
        Catch ex As Exception

        End Try
    End Sub
End Class
Imports MessagingToolkit.QRCode.Codec
Imports WebCam_Capture
Public Class webreader
    WithEvents Mywebcam As WebCamCapture
    Dim Reader As QRCodeDecoder

    Private Sub StartWebCam()
        Try
            StopWebcam()
            Mywebcam = New WebCamCapture
            Mywebcam.Start(0)
            Mywebcam.Start(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartWebCam()
        TextBox1.Clear()
    End Sub
End Class
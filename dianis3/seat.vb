﻿Imports MetroFramework.Controls
Public Class seat
    Public idShowtime As String = "9"
    Public Shared selectedSeats(20) As String
    Dim indexseat As String = 0
    Private Sub seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As Button = Nothing
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                btn = DirectCast(ctrl, Button)
                If (btn.Name <> "Button61") And (btn.Name <> "Button62") Then
                    AddHandler btn.Click, AddressOf Me.Button_Click   ' From answer by Reed.
                End If
            End If
        Next
        idShowtime = transaksi.winny
        loadSeat(idShowtime, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10,
Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20,
Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30,
Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40,
Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50,
Button51, Button52, Button53, Button54, Button55, Button56, Button57, Button58, Button59, Button60)
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Handle your Button clicks here
        Dim saya As String = ""
        Dim selectedBtn As Button = sender

        selectedSeats(indexseat) = selectedBtn.Text
        Label3.Text = selectedSeats.ToString
        indexseat = indexseat + 1
        selectedBtn.Enabled = False
        For i As Integer = 0 To selectedSeats.Length - 1

            If (selectedSeats(i) <> Nothing) Then
                saya = saya + selectedSeats(i) + " "
            End If
        Next
        Label3.Text = saya
    End Sub

    Sub loadSeat(id As String, ParamArray var() As Button)
        Dim Index As Integer = 0
        ' Dim raisa As String = "select kolom from seat where ID_showtime = '1' order by baris ASC, IIf ([kolom] = '1', 1, IIf ([kolom] = '2', 2, IIf ([kolom] = '3', 3, IIf ([kolom] = '4', 4, IIf ([kolom] = '5', 5, IIf ([kolom] = '6', 6, IIf ([kolom] = '7', 7, IIf ([kolom] = '8', 8, IIf ([kolom] = '9, 9, IIf ([kolom] = '10', 10, IIf ([kolom] = '11', 11, IIf ([kolom] = '12', 12, IIf ([kolom] = '13', 13, IIf ([kolom] = '14', 14, IIf ([kolom] = '15', 15, IIf ([kolom] = '16', 16, IIf ([kolom] = '17', 17, IIf ([kolom] = '18', 18, IIf ([kolom] = '19', 19, IIf ([kolom] = '20', 20, 21 ))))))))))))))))))))"
        Dim raisa As String = "select is_occupied from seat where ID_showtime = '" + id + "' order by baris ASC, CInt(kolom) ASC"
        Dim sql As String = "insert into " + " values("
        ' For i As Integer = 0 To UBound(var, 1)
        'If i <> UBound(var, 1) Then
        ' sql = sql + "'" + var(i).Text + "',"
        '    Else
        'sql = sql + "'" + var(i).Text + "')"
        ' End If

        ' Next
        CMD = New OleDb.OleDbCommand(raisa, Conn)
        DM = CMD.ExecuteReader()
        While DM.HasRows
            While DM.Read

                'MsgBox(DM.GetString(0))
                If (DM.GetString(0) = "1") Then
                    var(Index).Enabled = False
                End If
                Index = Index + 1
                ' MsgBox(DM.GetString(0))
            End While

            DM.NextResult()
        End While
        ' MsgBox("BERHAASIL")
        'matiForm(var)
        'clearForm(var)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        enableButton(Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10,
Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20,
Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30,
Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40,
Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50,
Button51, Button52, Button53, Button54, Button55, Button56, Button57, Button58, Button59, Button60)
        loadSeat(idShowtime, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10,
Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20,
Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30,
Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40,
Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50,
Button51, Button52, Button53, Button54, Button55, Button56, Button57, Button58, Button59, Button60)

        For i As Integer = 0 To selectedSeats.Length - 1
            selectedSeats(i) = Nothing
        Next
        Label3.Text = ""
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        Me.WindowState = FormWindowState.Minimized
        transaksi.loadGrid()
    End Sub
End Class
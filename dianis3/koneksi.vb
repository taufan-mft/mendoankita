
'Ditulis oleh @taufan_mft, bagian dari TopanLabs.com
'Ini adalah module tempat koneksi, sekaligus tempat fungsi yang sekiranya akan digunakan berulang kali
Imports System.Data.OleDb
Imports MetroFramework.Controls

Module koneksi
    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DM As OleDbDataReader

    Sub koneksiDB()
        Try
            Conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source = bioskopkita.accdb")
            Conn.Open()
            'MsgBox("Mantap pan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'fungsi untuk mendisable (matikan) textbox, kita cukup masukan textboxnya sebagai argumen.
    'Menggunakan paramarray jadi jumlah tak terbatas
    'Jika tidak menggunakan MetroUI, ganti MetroTextBox menjadi TextBox

    Sub matiForm(ParamArray var() As MetroTextBox)
        For i As Integer = 0 To UBound(var, 1)
            var(i).Enabled = False
        Next i


    End Sub

    'fungsi untuk nyalain textbox, kita cukup masukan textboxnya sebagai argumen.
    'Menggunakan paramarray jadi jumlah tak terbatas
    'Jika tidak menggunakan MetroUI, ganti MetroTextBox menjadi TextBox
    Sub nyalainForm(ParamArray var() As MetroTextBox)
        For i As Integer = 0 To UBound(var, 1)
            var(i).Enabled = True
        Next
    End Sub

    'fungsi untuk clear textbox, kita cukup masukan textboxnya sebagai argumen.
    'Menggunakan paramarray jadi jumlah tak terbatas
    'Jika tidak menggunakan MetroUI, ganti MetroTextBox menjadi TextBox
    Sub clearForm(ParamArray var() As MetroTextBox)
        For i As Integer = 0 To UBound(var, 1)
            var(i).Clear()
        Next
    End Sub

    Sub enableButton(ParamArray winny() As MetroButton)
        For i As Integer = 0 To UBound(winny, 1)
            winny(i).Enabled = True
        Next
    End Sub

    Sub disableButton(ParamArray winny() As MetroButton)
        For i As Integer = 0 To UBound(winny, 1)
            winny(i).Enabled = False
        Next
    End Sub

    'fungsi untuk menampilkan data, kita cukup masukan query SQL serta DataGridView yang dituju sebagai argumen.

    Sub tampilkanData(sequel As String, DGV As DataGridView)
        DA = New OleDb.OleDbDataAdapter(sequel, Conn)
        DS = New DataSet
        DA.Fill(DS)

        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub

    'fungsi untuk cek apakah TextBox nya kosong. Menggunakan paramarray jadi jumlah argumen tak terbatas.
    'ubah MetroTextBox menjadi TextBox jika tidak menggunakan MetroUI
    'Akan menghasilkan True jika ada yang kosong, dan False jika terisi semua
    Function checkEmpty(ParamArray var() As MetroTextBox) As Boolean
        Dim nomor As Integer = 0
        For i As Integer = 0 To UBound(var, 1)
            If (var(i).Text = "") Then
                nomor += 1
            End If
        Next
        If (nomor > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    'fungsi untuk cek duplikat d database
    Function checkDuplicate(namatabel As String, namaid As String, idkonten As String)
        Dim sequel As String
        sequel = "select * from " + namatabel + " where " + namaid + " = '" + idkonten + "'"
        CMD = New OleDb.OleDbCommand(sequel, Conn)

        DM = CMD.ExecuteReader()
        DM.Read()

        If Not DM.HasRows Then
            Return False
        Else
            Return True
        End If

    End Function

    Sub simpanData(namatabel As String, ParamArray var() As MetroTextBox)
        Dim sql As String = "insert into " + namatabel + " values("
        For i As Integer = 0 To UBound(var, 1)
            If i <> UBound(var, 1) Then
                sql = sql + "'" + var(i).Text + "',"
            Else
                sql = sql + "'" + var(i).Text + "')"
            End If

        Next
        CMD = New OleDb.OleDbCommand(sql, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("BERHAASIL")
        matiForm(var)
        clearForm(var)

    End Sub

    Sub updateData(namatabel As String, namaid As String, id As String, ParamArray var() As String)
        Dim sql As String
        sql = "update " + namatabel + " set "
        For i As Integer = 0 To UBound(var, 1) Step 2
            If i <> (UBound(var, 1) - 1) Then
                sql = sql + var(i) + " ='" + var(i + 1) + "', "

            Else
                sql = sql + var(i) + " ='" + var(i + 1) + "'"
            End If
        Next
        sql = sql + " where " + namaid + " = '" + id + "'"

            CMD = New OleDbCommand(sql, Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update berhasil")


    End Sub

    Sub showtoBox(row As Integer, DGV As DataGridView, pb As PictureBox, debug As MetroLabel, txtFoto As MetroTextBox, ParamArray var() As MetroTextBox)
        On Error Resume Next
        For i As Integer = 0 To UBound(var, 1)

            If (i = (UBound(var, 1))) Then
                Dim direck As String = DGV.Rows(row).Cells(i + 3).Value
                var(i).Text = DGV.Rows(row).Cells(i).Value
                'debug.Text = direck
                pb.Image = New Bitmap(direck)
                login.username = DGV.Rows(row).Cells(6).Value
                login.password = DGV.Rows(row).Cells(7).Value
                txtFoto.Text = DGV.Rows(row).Cells(8).Value
            Else
                var(i).Text = DGV.Rows(row).Cells(i).Value
            End If
        Next
    End Sub
    Sub showtoBox(row As Integer, DGV As DataGridView, ParamArray var() As MetroTextBox)
        On Error Resume Next
        For i As Integer = 0 To UBound(var, 1)


            var(i).Text = DGV.Rows(row).Cells(i).Value

        Next
    End Sub

    Sub hapusData(namatabel As String, namaid As String, id As String)
        Dim sql As String
        sql = "DELETE FROM " + namatabel + " WHERE " + namaid + " ='" + id + "'"
        CMD = New OleDb.OleDbCommand(sql, Conn)
        DM = CMD.ExecuteReader
        MsgBox("Data terhapus.")
    End Sub
End Module


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

    Sub simpanData(namatabel As String, ParamArray var() As String)
        Dim sql As String = "insert into " + namatabel + " values("
        For i As Integer = 0 To UBound(var, 1)
            If i <> UBound(var, 1) Then
                sql = sql + "'" + var(i) + "',"
            Else
                sql = sql + "'" + var(i) + "')"
            End If

        Next
        CMD = New OleDb.OleDbCommand(sql, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("BERHAASIL")
        'matiForm(var)
        'clearForm(var)

    End Sub
    'fungsi untuk edit(update) data yang sudah tersimpan
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

    'fungsi untuk memunculkan data ke GridView serta foto ke picture box
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

    'fungsi untuk menampilkan disertai combobox di pegawai
    Sub showtoBox(row As Integer, DGV As DataGridView, pb As PictureBox, debug As MetroLabel, txtFoto As MetroTextBox, txtKelamin As MetroComboBox, txtJabatanlagi As MetroComboBox, ParamArray var() As MetroTextBox)
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
                txtKelamin.SelectedItem = DGV.Rows(row).Cells(4).Value
                txtJabatanlagi.SelectedItem = DGV.Rows(row).Cells(5).Value

            End If
        Next
    End Sub

    'fungsi untuk memunculkan data ke GridView tapi tanpa picture box
    Sub showtoBox(row As Integer, DGV As DataGridView, ParamArray var() As MetroTextBox)
        On Error Resume Next
        For i As Integer = 0 To UBound(var, 1)


            var(i).Text = DGV.Rows(row).Cells(i).Value

        Next
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As String
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max).ToString
    End Function

    'fungsi untuk hapus data, berdasarkan ID
    Sub hapusData(namatabel As String, namaid As String, id As String)
        Dim sql As String
        sql = "DELETE FROM " + namatabel + " WHERE " + namaid + " ='" + id + "'"
        CMD = New OleDb.OleDbCommand(sql, Conn)
        DM = CMD.ExecuteReader
        MsgBox("Data terhapus.")
    End Sub

    'fungsi untuk mencari ID suatu data dari suatu tabel untuk kemudian di masukan (referensikan) di tabel lain
    Function retrieveID(value As String, tabel As String, namakolID As String, namakolValue As String)
        Dim sql As String = "Select " + namakolID + " from " + tabel + " where " + namakolValue + " = '" + value + "'"
        CMD = New OleDb.OleDbCommand(sql, Conn)
        Dim hasil As String = "raisa"
        DM = CMD.ExecuteReader()
        If DM.HasRows = True Then
            'MsgBox("Dianis")
            While DM.Read
                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                hasil = DM.GetString(0)

            End While
        End If
        Return hasil
    End Function
    Function retrieveID(value As String, value2 As String, tabel As String, namakolID As String, namakolValue As String, namakolVal2 As String)
        Dim sql As String = "Select " + namakolID + " from " + tabel + " where " + namakolValue + " = '" + value + "' and " + namakolVal2 + " = '" + value2 + "'"
        CMD = New OleDb.OleDbCommand(sql, Conn)
        Dim hasil As String = "raisa"
        DM = CMD.ExecuteReader()
        If DM.HasRows = True Then
            'MsgBox("Dianis")
            While DM.Read
                'MsgBox(DM.GetString(0))
                ''Label3.Text = DM.GetString(0)
                hasil = DM.GetString(0)

            End While
        End If
        Return hasil
    End Function

    Sub cariDGV(DGV As DataGridView, namatabel As String, namakol1 As String, namakol2 As String, namakol3 As String, value1 As String)
        Dim raisani As String
        raisani = "SELECT * FROM " & namatabel & " WHERE " & namakol1 & " like '%" & value1.Replace("'", "''") & "%' or " & namakol2 & " like '%" & value1.Replace("'", "''") & "%' or " & namakol3 & " like '%" & value1.Replace("'", "''") & "%' "
        DA = New OleDb.OleDbDataAdapter(raisani, Conn)
        DS = New DataSet
        Dim SRT As New DataTable
        SRT.Clear()
        DA.Fill(SRT)
        DGV.DataSource = SRT
    End Sub
End Module


Imports System.Data.OleDb
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
            MsgBox("Mantap pan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub matiForm(ParamArray var() As TextBox)
        For i As Integer = 0 To UBound(var, 1)
            var(i).Enabled = False
        Next i


    End Sub

    Sub nyalainForm(ParamArray var() As TextBox)
        For i As Integer = 0 To UBound(var, 1)
            var(i).Enabled = True
        Next
    End Sub

    Sub clearForm(ParamArray var() As TextBox)
        For i As Integer = 0 To UBound(var, i)
            var(i).Clear()
        Next
    End Sub
End Module

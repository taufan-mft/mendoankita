﻿
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
End Module

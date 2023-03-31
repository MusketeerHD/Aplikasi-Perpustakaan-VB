Imports System.Data.OleDb

Module Module1
    Public cmd As OleDbCommand
    Public conn As OleDbConnection
    Public rd As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet

    Sub koneksi()
        conn = New OleDbConnection("provider=Microsoft.Jet.oledb.4.0;data source=db_pustaka.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module

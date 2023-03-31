Imports System.Data.OleDb
Public Class Form_Buku
    Sub out_buku()
        cmd = New OleDbCommand("select * from tbl_buku", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7), rd(8), rd(9))
        Loop
    End Sub
    Private Sub Form_Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call out_buku()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Call out_buku()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("select * from tbl_buku where judul like '%" & TextBox1.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7), rd(8), rd(9))
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_InpuBuku.ShowDialog()

    End Sub
End Class
Imports System.Data.OleDb
Public Class Form_Data_Anggota
    Sub out_data()
        cmd = New OleDbCommand("select * from tbl_anggota", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("select * from tbl_anggota where nama_anggota like '%" & TextBox1.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop

    End Sub

    Private Sub Form_Data_Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call out_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Call out_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_InputAnggota.ShowDialog()
    End Sub
End Class
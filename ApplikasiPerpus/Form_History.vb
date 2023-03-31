Imports System.Data.OleDb

Public Class Form_History
    Sub tampil_history()
        cmd = New OleDbCommand("select * from Query_pinjam where keterangan='Dipinjam'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd.Item("id_pinjam"), rd.Item("tanggal_pinjam"), rd.Item("id_anggota"), rd.Item("nama_anggota"), rd.Item("id_buku"), rd.Item("judul"), rd.Item("jumlah_pinjam"))
        Loop
    End Sub
    Private Sub Form_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_history()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from Query_pinjam where nama_anggota like '%" & TextBox1.Text & "%' and keterangan='Dipinjam'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd.Item("id_pinjam"), rd.Item("tanggal_pinjam"), rd.Item("id_anggota"), rd.Item("nama_anggota"), rd.Item("id_buku"), rd.Item("judul"), rd.Item("jumlah_pinjam"))
        Loop
    End Sub
End Class
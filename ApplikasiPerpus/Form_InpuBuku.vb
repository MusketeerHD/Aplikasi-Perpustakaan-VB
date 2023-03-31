Imports System.Data.OleDb

Public Class Form_InpuBuku
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form_InpuBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call clear()
        Dim year As Integer = 1900
        Dim rak As String = "Rak"
        For i As Integer = 0 To 100
            year += 1
            ComboBox1.Items.Add(year)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("Data belum lengkap di isi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                ' simpan atau tambahin data buku
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_buku values('" & TextBox1.Text &
                                       "','" & TextBox2.Text &
                                       "','" & TextBox3.Text &
                                       "','" & TextBox4.Text &
                                       "','" & TextBox5.Text &
                                       "','" & ComboBox1.Text &
                                       "','" & TextBox6.Text &
                                       "','" & ComboBox2.Text &
                                       "','" & DateTimePicker1.Text &
                                       "','" & TextBox7.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                Call Form_Buku.out_buku()
                MessageBox.Show("Data berhasil di save !!")
                Call clear()

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("judul")
            TextBox3.Text = rd.Item("pengarang")
            TextBox4.Text = rd.Item("penerbit")
            TextBox5.Text = rd.Item("kategori")
            ComboBox1.Text = rd.Item("tahun")
            TextBox6.Text = rd.Item("stok")
            ComboBox2.Text = rd.Item("lokasi")
            DateTimePicker1.Text = rd.Item("tanggal_masuk")
            TextBox7.Text = rd.Item("harga_buku")
            Button1.Enabled = False
            Button2.Enabled = True
            Button4.Enabled = True
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Focus()
            Button1.Enabled = True
            Button2.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Edit Buku
        Call koneksi()
        cmd = New OleDbCommand("update tbl_buku set judul='" & TextBox2.Text &
                               "', pengarang='" & TextBox3.Text &
                               "', penerbit='" & TextBox4.Text &
                               "', kategori='" & TextBox5.Text &
                               "', tahun='" & ComboBox1.Text &
                               "', stok='" & TextBox6.Text &
                               "', lokasi='" & ComboBox2.Text &
                               "', tanggal_masuk='" & DateTimePicker1.Text &
                                "', harga_buku='" & TextBox7.Text &
                               "' where id_buku='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Call Form_Buku.out_buku()
        MessageBox.Show("Data berhasil di Edit !!")
        Call clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Delete Buku
        If MessageBox.Show("Apakah anda yakin ingin menghapus Buku Tersebut ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("Delete from tbl_buku where id_buku='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Call Form_Buku.out_buku()
            MessageBox.Show("Buku berhasil di Delete !!")
            Call clear()
        End If
    End Sub
End Class
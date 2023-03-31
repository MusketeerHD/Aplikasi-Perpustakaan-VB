Imports System.Data.OleDb

Public Class Form_InputAnggota
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form_InputAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Data belum lengkap di isi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_anggota where id_anggota = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                ' simpan atau tambahin data anggota
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_anggota values('" & TextBox1.Text &
                                       "','" & TextBox2.Text &
                                       "','" & TextBox3.Text &
                                       "','" & TextBox4.Text &
                                       "','" & TextBox5.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                Call Form_Data_Anggota.out_data()
                MessageBox.Show("Data berhasil di save !!")
                Call clear()

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota = '" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("nama_anggota")
            TextBox3.Text = rd.Item("alamat")
            TextBox4.Text = rd.Item("telpon")
            TextBox5.Text = rd.Item("email")
            Button1.Enabled = False
            Button2.Enabled = True
            Button4.Enabled = True
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            Button1.Enabled = True
            Button2.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Delete data
        If MessageBox.Show("Apakah anda yakin ingin menghapus data berikut ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("Delete from tbl_anggota where id_anggota='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Call Form_Data_Anggota.out_data()
            MessageBox.Show("Data berhasil di Delete !!")
            Call clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Edit data
        Call koneksi()
        cmd = New OleDbCommand("update tbl_anggota set nama_anggota='" & TextBox2.Text &
                               "', alamat='" & TextBox3.Text &
                               "', telpon='" & TextBox4.Text &
                               "', email='" & TextBox5.Text &
                               "' where id_anggota='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Call Form_Data_Anggota.out_data()
        MessageBox.Show("Data berhasil di Edit !!")
        Call clear()
    End Sub
End Class
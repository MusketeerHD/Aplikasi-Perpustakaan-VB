Imports System.Data.OleDb
Public Class Form_User
    Sub out_user()
        cmd = New OleDbCommand("select * from tbl_user", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call out_user()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Data belum lengkap di isi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where id_user = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                ' simpan atau tambahin data anggota
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_user values('" & TextBox1.Text &
                                       "','" & TextBox2.Text &
                                       "','" & TextBox3.Text &
                                       "','" & TextBox4.Text &
                                       "','" & ComboBox1.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                Call out_user()
                MessageBox.Show("Data berhasil di save !!")
                Call clear()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_user where id_user = '" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("nama_user")
            TextBox3.Text = rd.Item("user_name")
            TextBox4.Text = rd.Item("pwd")
            ComboBox1.Text = rd.Item("level_user")
            Button1.Enabled = False
            Button2.Enabled = True
            Button4.Enabled = True
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = ""
            Button1.Enabled = True
            Button2.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Edit user
        Call koneksi()
        cmd = New OleDbCommand("update tbl_user set nama_user='" & TextBox2.Text &
                               "', user_name='" & TextBox3.Text &
                               "', pwd='" & TextBox4.Text &
                               "', level_user='" & ComboBox1.Text &
                               "' where id_user='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        Call out_user()
        MessageBox.Show("User berhasil di Edit !!")
        Call clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Delete User
        If MessageBox.Show("Apakah anda yakin ingin menghapus data berikut ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("Delete from tbl_user where id_user='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Call out_user()
            MessageBox.Show("Data berhasil di Delete !!")
            Call clear()
        End If
    End Sub
End Class
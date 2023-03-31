Imports System.Data.OleDb

Public Class Form_Peminjaman
    Sub id_pinjam_automate()
        cmd = New OleDbCommand("select id_pinjam from tbl_pinjam order by id_pinjam desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows = True Then
            txt_idpinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(rd.Item("id_pinjam"), 3, 6) = Format(Today, "yyMMdd") Then
                txt_idpinjam.Text = "PJ" + Format(Microsoft.VisualBasic.Right(rd.Item("id_pinjam"), 8) + 1, "00")
            Else
                txt_idpinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub clear()
        txt_idanggota.Clear()
        txt_nama.Clear()
        txt_pernahpinjam.Text = "0"
        txt_pinjamansekarang.Text = "0"
        txt_total.Text = "0"
        txt_idbuku.Clear()
        txt_judul.Clear()
        txt_penerbit.Clear()
        txt_pengarang.Clear()
        txt_tahun.Clear()
        txt_kategori.Clear()
        txt_jumlah.Text = "1"
        txt_idanggota.Focus()
        dgv1.Rows.Clear()
    End Sub
    Sub clearTransaksi()
        txt_idbuku.Clear()
        txt_judul.Clear()
        txt_penerbit.Clear()
        txt_pengarang.Clear()
        txt_tahun.Clear()
        txt_kategori.Clear()
        txt_jumlah.Text = "1"
        txt_idbuku.Focus()
    End Sub
    Sub setting()
        cmd = New OleDbCommand("select * from tbl_pengaturan where id='1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_bataspinjaman.Text = rd.Item("batas_buku")
        End If
    End Sub
    Private Sub Form_Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call setting()
        Call id_pinjam_automate()
        Call clear()
        Call clearTransaksi()
        txt_tanggal.Text = Format(Today, "MM/dd/yyyy")
        dgv1.ReadOnly = True
        dgv1.Rows.Clear()
        dgv2.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()

    End Sub

    Private Sub txt_idanggota_TextChanged(sender As Object, e As EventArgs) Handles txt_idanggota.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota='" & txt_idanggota.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_nama.Text = rd.Item("nama_anggota")
            ' nampilin data buku yang pernah atau sedang di pakai oleh anggota
            da = New OleDbDataAdapter("select tbl_pinjam_detail.id_pinjam, tbl_pinjam_detail.id_buku, tbl_buku.judul, pengarang, penerbit from tbl_pinjam_detail,tbl_pinjam,tbl_buku where tbl_pinjam_detail.id_pinjam=tbl_pinjam.id_pinjam and tbl_buku.id_buku=tbl_pinjam_detail.id_buku and tbl_pinjam.id_anggota='" & txt_idanggota.Text & "' and tbl_pinjam_detail.keterangan='Dipinjam'", conn) ' untuk menampilkan data tampa coloumnya
            ds = New DataSet
            da.Fill(ds)
            dgv2.DataSource = ds.Tables(0)
            dgv2.ReadOnly = True
            dgv2.Columns(0).HeaderText = "ID Pinjam"
            dgv2.Columns(1).HeaderText = "ID Buku"
            dgv2.Columns(2).HeaderText = "Judul Buku"
            txt_pernahpinjam.Text = dgv2.RowCount - 1
            ' menampilkan batas jumlah pinjaman
            If Val(txt_pernahpinjam.Text) >= Val(txt_bataspinjaman.Text) Then
                MessageBox.Show("Pinjaman Sudah Maximal, Mahasiswa Tidak di perbolehkan untuk meminjam buku")
                dgv1.Rows.Clear()
                Call clear()
                Call clearTransaksi()
                txt_idanggota.Focus()

            End If
        Else
            txt_nama.Clear()
            txt_pernahpinjam.Text = "0"
            txt_jumlah.Text = "1"
            txt_pinjamansekarang.Text = "0"
        End If
    End Sub

    Private Sub txt_idbuku_TextChanged(sender As Object, e As EventArgs) Handles txt_idbuku.TextChanged

    End Sub

    Private Sub txt_idbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idbuku.KeyPress
        If e.KeyChar = Chr(13) Then ' Chr(13) itu sama dengan enter
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & txt_idbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txt_judul.Text = rd.Item("judul")
                txt_pengarang.Text = rd.Item("pengarang")
                txt_penerbit.Text = rd.Item("penerbit")
                txt_kategori.Text = rd.Item("kategori")
                txt_tahun.Text = rd.Item("tahun")
                txt_jumlah.Text = 1
                txt_jumlah.Focus()
                If Val(rd.Item("stok")) = 0 Then
                    MessageBox.Show("Stok buku kosong")
                    Call clearTransaksi()

                End If
            Else
                MessageBox.Show("Kode buku tersebut belum terdaftar di system !!")
                Call clearTransaksi()
            End If
        End If
    End Sub

    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged
        If Val(txt_jumlah.Text) > 1 Or Val(txt_jumlah.Text) < 1 Then
            MessageBox.Show("Anggota hanya boleh meminjam 1 buku")
            txt_jumlah.Text = 1
        End If
    End Sub

    Private Sub txt_jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah.KeyPress
        If e.KeyChar = Chr(13) Then ' Chr(13) itu sama dengan enter
            If txt_idanggota.Text = "" Or txt_nama.Text = "" Then
                MessageBox.Show("Pilih isi data anggota dulu")
                Exit Sub
            End If
            If Val(txt_total.Text) >= Val(txt_bataspinjaman.Text) Then
                MessageBox.Show("Pinjaman sudah Maximal !!")
                Call clearTransaksi()
                Exit Sub
            End If
            Dim baris1 As Integer = dgv1.RowCount - 1
            Dim id_buku As String = txt_idbuku.Text

            ' Mencegah pinjaman buku kedua kalinya ketika masih meminjam buku tersebut
            cmd = New OleDbCommand("select id_buku from tbl_pinjam_detail,tbl_pinjam,tbl_anggota where tbl_pinjam.id_pinjam=tbl_pinjam_detail.id_pinjam and tbl_pinjam.id_anggota=tbl_anggota.id_anggota and tbl_pinjam_detail.id_buku='" & id_buku & "'and tbl_pinjam.id_anggota='" & txt_idanggota.Text & "'and tbl_pinjam_detail.keterangan='Dipinjam'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MessageBox.Show("Buku ini sedang di pinjam")
                Exit Sub
            End If

            ' menampilkan data buku yang di masukan ke dalam daftar pinjam
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & txt_idbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                dgv1.Rows.Add(txt_idbuku.Text, txt_judul.Text, txt_pengarang.Text, txt_penerbit.Text, txt_kategori.Text, txt_tahun.Text, txt_jumlah.Text)
                Call clearTransaksi()

                ' mencegah peminjaman buku yang sama
                For barisatas As Integer = 0 To dgv1.RowCount - 1
                    For barisbawah As Integer = barisatas + 1 To dgv1.RowCount - 1
                        If dgv1.Rows(barisbawah).Cells(0).Value = dgv1.Rows(barisatas).Cells(0).Value Then
                            MessageBox.Show("Buku ini sudah ada dalam transaksi")
                            dgv1.Rows.RemoveAt(barisbawah)
                            Exit Sub
                        End If
                    Next
                Next
            End If
            ' Menghitung jumlah buku yang di pinjam lalu masuk ke daftar pinjam
            txt_pinjamansekarang.Text = dgv1.RowCount - 1
            ' 
            txt_total.Text = Val(txt_pinjamansekarang.Text) + Val(txt_pernahpinjam.Text)
        End If
        Call clearTransaksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_idanggota.Text = "" Or txt_nama.Text = "" Or txt_pinjamansekarang.Text = 0 Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub ' biar berhenti
        End If
        ' Menyimpan data transaksi ke tbl_pinjam
        cmd = New OleDbCommand("insert into tbl_pinjam values('" & txt_idpinjam.Text &
                               "','" & txt_tanggal.Text &
                               "','" & txt_idanggota.Text &
                               "')", conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To dgv1.RowCount - 2
            ' Menyimpan data tbl_pinjam_detail
            cmd = New OleDbCommand("insert into tbl_pinjam_detail values('" & txt_idpinjam.Text & "','" & dgv1.Rows(baris).Cells(0).Value & "','Dipinjam','1')", conn)
            cmd.ExecuteNonQuery()
            ' mengurang stok buku
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                cmd = New OleDbCommand("update tbl_buku set stok='" & rd.Item("stok") - 1 & "' where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
            End If
        Next

        MessageBox.Show("Peminjaman Berhasil di simpan")
        Call clear()
        Call clearTransaksi()
        Call id_pinjam_automate()
        dgv1.Rows.Clear()
        dgv2.Columns.Clear()
    End Sub
End Class
Imports System.Data.OleDb

Public Class Form_Pengembalian
    Sub clear_pengembalian()
        txt_idbuku.Clear()
        txt_judul.Clear()
        txt_tglpinjam.Clear()
        txt_idpinjam.Clear()
        txt_denda.Clear()
        txt_lamaPinjam.Clear()
        txt_terlambat.Clear()
        cb_hilang.Text = ""
        cb_rusak.Text = ""
        txt_idbuku.Focus()

    End Sub
    Sub clear_anggota()
        txt_idanggota.Clear()
        txt_nama.Clear()
        txt_alamat.Clear()
        txt_telp.Clear()
        txt_idanggota.Focus()
    End Sub
    Sub setting()
        cmd = New OleDbCommand("select * from tbl_pengaturan where id='1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_bataspinjaman.Text = rd.Item("batas_buku")
            txt_dendaperhari.Text = rd.Item("denda_hari")
            txt_dendarusak.Text = rd.Item("denda_rusak")
        End If
    End Sub
    Sub id_otomatis()
        cmd = New OleDbCommand("select id_kembali from tbl_kembali order by id_kembali desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows = True Then
            txt_idkembali.Text = "KB" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(rd.Item("id_kembali"), 3, 6) = Format(Today, "yyMMdd") Then
                txt_idkembali.Text = "KB" + Format(Microsoft.VisualBasic.Right(rd.Item("id_kembali"), 8) + 1, "00")
            Else
                txt_idkembali.Text = "KB" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub hitung_total_denda()
        Dim hitung As Double
        For baris As Integer = 0 To dgv1.RowCount - 1
            hitung += dgv1.Rows(baris).Cells(8).Value
        Next
        txt_totalDenda.Text = hitung

    End Sub
    Private Sub Form_Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call setting()
        Call clear_pengembalian()
        txt_idanggota.Clear()
        txt_nama.Clear()
        txt_idanggota.Focus()
        Call id_otomatis()
        txt_tanggal.Text = Format(Today, "MM/dd/yyyy") ' add tanggal
        Call clear_anggota()
        Call hitung_total_denda()
        txt_dibayar.Text = 0
        txt_kembalian.Text = 0

    End Sub

    Private Sub txt_idanggota_TextChanged(sender As Object, e As EventArgs) Handles txt_idanggota.TextChanged
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota='" & txt_idanggota.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_nama.Text = rd.Item("nama_anggota")
            txt_alamat.Text = rd.Item("alamat")
            txt_telp.Text = rd.Item("telpon")
        Else
            txt_nama.Clear()
            txt_alamat.Clear()
            txt_telp.Clear()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call hitung_total_denda()
        Call clear_anggota()
        Call clear_pengembalian()
        dgv1.Rows.Clear()
        txt_dibayar.Clear()
        txt_totalDenda.Clear()
        txt_kembalian.Clear()
        txt_dibayar.Text = 0
        txt_kembalian.Text = 0
    End Sub

    Private Sub txt_idbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from Query_pinjam where id_anggota='" & txt_idanggota.Text & "'and id_buku='" & txt_idbuku.Text & "'and keterangan='Dipinjam'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txt_judul.Text = rd.Item("judul")
                txt_tglpinjam.Text = Format(DateValue(rd.Item("tanggal_pinjam")), "MM/dd/yyyy") ' masukin format date
                ' menghitung lama pinjam
                Dim tgl1 As Date
                tgl1 = Format(DateValue(rd.Item("tanggal_pinjam")), "MM/dd/yyyy")
                If txt_tglpinjam.Text = Format(Today, "MM/dd/yyyy") Then
                    txt_lamaPinjam.Text = 1
                Else
                    txt_lamaPinjam.Text = DateAndTime.DateDiff(DateInterval.Day, tgl1, Today()) ' perbedaan antara kedua tanggal
                End If
                ' mencari denda penembalian buku
                If Val(txt_lamaPinjam.Text) <= Val(txt_bataspinjaman.Text) Then
                    txt_terlambat.Text = 0
                    txt_denda.Text = 0
                Else
                    txt_terlambat.Text = Val(txt_lamaPinjam.Text) - Val(txt_bataspinjaman.Text)
                    txt_denda.Text = Val(txt_dendaperhari.Text) * Val(txt_terlambat.Text)
                End If
                txt_idpinjam.Text = rd.Item("id_pinjam")
                cb_hilang.Text = "Tidak"
                cb_rusak.Text = "Tidak Rusak"
                cb_rusak.Focus()
            Else
                MessageBox.Show("Mahasiswa ini tidak pernah meminjam buku ini !!")
                Call clear_pengembalian()
            End If
        End If
    End Sub

    Private Sub cb_rusak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rusak.SelectedIndexChanged
        If cb_rusak.Text = "Rusak" Then
            cb_hilang.Text = "Tidak"
            txt_denda.Text = Val(txt_dendaperhari.Text) * Val(txt_terlambat.Text) + Val(txt_dendarusak.Text)
        Else
            txt_denda.Text = Val(txt_dendaperhari.Text) * Val(txt_terlambat.Text)
        End If
    End Sub

    Private Sub cb_hilang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_hilang.SelectedIndexChanged
        If cb_hilang.Text = "Ya" Then
            cb_rusak.Text = "Tidak Rusak"
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & txt_idbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txt_denda.Text = (Val(txt_dendaperhari.Text) * Val(txt_terlambat.Text)) + Val(rd.Item("harga_buku"))
            Else
                txt_denda.Text = (Val(txt_dendaperhari.Text) * Val(txt_terlambat.Text))
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_idanggota.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Then
            MessageBox.Show("data anggota belum di isi !!")
        ElseIf txt_idbuku.Text = "" Or txt_judul.Text = "" Then
            MessageBox.Show("Data buku belum di isi")
        Else
            dgv1.Rows.Add(txt_idbuku.Text, txt_judul.Text, txt_tglpinjam.Text, txt_idpinjam.Text, txt_lamaPinjam.Text, txt_terlambat.Text, cb_rusak.Text, cb_hilang.Text, txt_denda.Text)
            For baris_atas As Integer = 0 To dgv1.RowCount - 1
                For baris_bawah As Integer = baris_atas + 1 To dgv1.RowCount - 1
                    If dgv1.Rows(baris_bawah).Cells(0).Value = dgv1.Rows(baris_atas).Cells(0).Value Then
                        MessageBox.Show("Buku sedang dalam proses pengembalian !!!")
                        dgv1.Rows.RemoveAt(baris_bawah)
                        Exit Sub
                    End If
                Next
            Next
            Call clear_pengembalian()
            Call hitung_total_denda()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_idanggota.Text = "" Or txt_nama.Text = "" Or dgv1.RowCount - 1 = 0 Then
            MessageBox.Show("Transaksikan belum lengkap, Cek pengembalian buku dan Pembayaran denda !!")
        ElseIf Val(txt_dibayar.Text) < Val(txt_totalDenda.Text) Then
            MessageBox.Show("Pembayaran masih kurang")
        ElseIf txt_dibayar.Text = "" Then
            MessageBox.Show("Inputan kosong")
        Else
            cmd = New OleDbCommand("insert into tbl_kembali values('" & txt_idkembali.Text &
                                   "','" & txt_tanggal.Text &
                                   "','" & txt_idanggota.Text &
                                   "','" & txt_totalDenda.Text &
                                   "','" & txt_dibayar.Text &
                                   "','" & txt_kembalian.Text &
                                   "')", conn)
            cmd.ExecuteNonQuery()
            For baris As Integer = 0 To dgv1.RowCount - 2
                ' menyimpan data ke tbl_kembali_detail
                cmd = New OleDbCommand("insert into tbl_kembali_detail values('" & txt_idkembali.Text &
                                   "','" & dgv1.Rows(baris).Cells(0).Value &
                                   "','" & dgv1.Rows(baris).Cells(4).Value &
                                   "','" & dgv1.Rows(baris).Cells(5).Value &
                                   "','" & dgv1.Rows(baris).Cells(6).Value &
                                   "','" & dgv1.Rows(baris).Cells(7).Value &
                                   "','" & dgv1.Rows(baris).Cells(8).Value &
                                   "','1')", conn)
                cmd.ExecuteNonQuery()
                'menambahkan kembali stok dari buku yang di kembalikan
                cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    If dgv1.Rows(baris).Cells(6).Value = "Tidak Rusak" Then
                        cmd = New OleDbCommand("update tbl_buku set stok='" & rd.Item("stok") + 1 & "' where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
                        cmd.ExecuteNonQuery()

                    End If
                End If
                ' mengubah keterangan tbl_pinjam_detail
                cmd = New OleDbCommand("select * from tbl_pinjam_detail where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "' and id_pinjam='" & dgv1.Rows(baris).Cells(3).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    If dgv1.Rows(baris).Cells(7).Value = "Ya" Then
                        cmd = New OleDbCommand("update tbl_pinjam_detail set keterangan='Hilang' where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "' and id_pinjam='" & dgv1.Rows(baris).Cells(3).Value & "'", conn)
                        cmd.ExecuteNonQuery()
                    Else
                        cmd = New OleDbCommand("update tbl_pinjam_detail set keterangan='Dikembalikan' where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "' and id_pinjam='" & dgv1.Rows(baris).Cells(3).Value & "'", conn)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next

            MessageBox.Show("data pengembalian berhasil di input")
            Call clear_anggota()
            Call clear_pengembalian()
            Call hitung_total_denda()
            Call id_otomatis()
            txt_dibayar.Clear()
            dgv1.Rows.Clear()

        End If
    End Sub

    Private Sub txt_dibayar_TextChanged(sender As Object, e As EventArgs) Handles txt_dibayar.TextChanged
        Try
            txt_kembalian.Text = Val(txt_dibayar.Text) - Val(txt_totalDenda.Text)
        Catch ex As Exception
            txt_kembalian.Text = 0
        End Try
    End Sub

    Private Sub txt_idbuku_TextChanged(sender As Object, e As EventArgs) Handles txt_idbuku.TextChanged

    End Sub
End Class
Public Class Form_Menu_Utama
    Private Sub PengembalianBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianBukuToolStripMenuItem.Click
        Form_Pengembalian.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Data_Anggota.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        Form_Data_Anggota.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Buku.ShowDialog()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Form_Buku.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_KatalogBuku.ShowDialog()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        Form_KatalogBuku.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_User.ShowDialog()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Form_User.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_Peminjaman.ShowDialog()
    End Sub

    Private Sub PeminjamanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanBukuToolStripMenuItem.Click
        Form_Peminjaman.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form_Pengembalian.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form_History.ShowDialog()
    End Sub
End Class
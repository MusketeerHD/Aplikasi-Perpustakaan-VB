<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Peminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_bataspinjaman = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_pinjamansekarang = New System.Windows.Forms.TextBox()
        Me.txt_pernahpinjam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_idpinjam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_tahun = New System.Windows.Forms.TextBox()
        Me.txt_kategori = New System.Windows.Forms.TextBox()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.txt_idbuku = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Peminjaman Buku"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.ApplikasiPerpus.My.Resources.Resources.logoheader
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_bataspinjaman)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.txt_pinjamansekarang)
        Me.GroupBox2.Controls.Add(Me.txt_pernahpinjam)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_nama)
        Me.GroupBox2.Controls.Add(Me.txt_idanggota)
        Me.GroupBox2.Controls.Add(Me.txt_tanggal)
        Me.GroupBox2.Controls.Add(Me.txt_idpinjam)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1060, 161)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi Peminjaman"
        '
        'txt_bataspinjaman
        '
        Me.txt_bataspinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bataspinjaman.Location = New System.Drawing.Point(420, 129)
        Me.txt_bataspinjaman.Name = "txt_bataspinjaman"
        Me.txt_bataspinjaman.ReadOnly = True
        Me.txt_bataspinjaman.Size = New System.Drawing.Size(160, 26)
        Me.txt_bataspinjaman.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(315, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Batas"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(420, 96)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(160, 26)
        Me.txt_total.TabIndex = 13
        '
        'txt_pinjamansekarang
        '
        Me.txt_pinjamansekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pinjamansekarang.Location = New System.Drawing.Point(420, 65)
        Me.txt_pinjamansekarang.Name = "txt_pinjamansekarang"
        Me.txt_pinjamansekarang.ReadOnly = True
        Me.txt_pinjamansekarang.Size = New System.Drawing.Size(160, 26)
        Me.txt_pinjamansekarang.TabIndex = 12
        '
        'txt_pernahpinjam
        '
        Me.txt_pernahpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pernahpinjam.Location = New System.Drawing.Point(420, 33)
        Me.txt_pernahpinjam.Name = "txt_pernahpinjam"
        Me.txt_pernahpinjam.ReadOnly = True
        Me.txt_pernahpinjam.Size = New System.Drawing.Size(160, 26)
        Me.txt_pernahpinjam.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(315, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(315, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Pinjaman"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(315, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Pernah"
        '
        'txt_nama
        '
        Me.txt_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.Location = New System.Drawing.Point(117, 128)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(160, 26)
        Me.txt_nama.TabIndex = 7
        '
        'txt_idanggota
        '
        Me.txt_idanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idanggota.Location = New System.Drawing.Point(117, 96)
        Me.txt_idanggota.Name = "txt_idanggota"
        Me.txt_idanggota.Size = New System.Drawing.Size(160, 26)
        Me.txt_idanggota.TabIndex = 6
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tanggal.Location = New System.Drawing.Point(117, 65)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.ReadOnly = True
        Me.txt_tanggal.Size = New System.Drawing.Size(160, 26)
        Me.txt_tanggal.TabIndex = 5
        '
        'txt_idpinjam
        '
        Me.txt_idpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idpinjam.Location = New System.Drawing.Point(117, 33)
        Me.txt_idpinjam.Name = "txt_idpinjam"
        Me.txt_idpinjam.ReadOnly = True
        Me.txt_idpinjam.Size = New System.Drawing.Size(160, 26)
        Me.txt_idpinjam.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID Anggota"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Pinjam"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_jumlah)
        Me.GroupBox3.Controls.Add(Me.txt_tahun)
        Me.GroupBox3.Controls.Add(Me.txt_kategori)
        Me.GroupBox3.Controls.Add(Me.txt_penerbit)
        Me.GroupBox3.Controls.Add(Me.txt_pengarang)
        Me.GroupBox3.Controls.Add(Me.txt_judul)
        Me.GroupBox3.Controls.Add(Me.txt_idbuku)
        Me.GroupBox3.Controls.Add(Me.dgv1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1060, 218)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Transaksi"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlah.Location = New System.Drawing.Point(993, 20)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(64, 26)
        Me.txt_jumlah.TabIndex = 11
        '
        'txt_tahun
        '
        Me.txt_tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tahun.Location = New System.Drawing.Point(894, 20)
        Me.txt_tahun.Name = "txt_tahun"
        Me.txt_tahun.ReadOnly = True
        Me.txt_tahun.Size = New System.Drawing.Size(99, 26)
        Me.txt_tahun.TabIndex = 10
        '
        'txt_kategori
        '
        Me.txt_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kategori.Location = New System.Drawing.Point(795, 20)
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.ReadOnly = True
        Me.txt_kategori.Size = New System.Drawing.Size(99, 26)
        Me.txt_kategori.TabIndex = 9
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_penerbit.Location = New System.Drawing.Point(593, 20)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.ReadOnly = True
        Me.txt_penerbit.Size = New System.Drawing.Size(202, 26)
        Me.txt_penerbit.TabIndex = 8
        '
        'txt_pengarang
        '
        Me.txt_pengarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pengarang.Location = New System.Drawing.Point(390, 20)
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.ReadOnly = True
        Me.txt_pengarang.Size = New System.Drawing.Size(207, 26)
        Me.txt_pengarang.TabIndex = 7
        '
        'txt_judul
        '
        Me.txt_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_judul.Location = New System.Drawing.Point(142, 20)
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.ReadOnly = True
        Me.txt_judul.Size = New System.Drawing.Size(251, 26)
        Me.txt_judul.TabIndex = 6
        '
        'txt_idbuku
        '
        Me.txt_idbuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idbuku.Location = New System.Drawing.Point(43, 20)
        Me.txt_idbuku.Name = "txt_idbuku"
        Me.txt_idbuku.Size = New System.Drawing.Size(102, 26)
        Me.txt_idbuku.TabIndex = 5
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv1.Location = New System.Drawing.Point(3, 52)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(1054, 163)
        Me.dgv1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Buku"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Judul"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pengarang"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Penerbit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Kategori"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tahun"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Jumlah"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 60
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 483)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1060, 104)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proses"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(130, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(256, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 40)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgv2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 587)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1060, 173)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sedang Dipinjam"
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(3, 18)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.Size = New System.Drawing.Size(1054, 152)
        Me.dgv2.TabIndex = 0
        '
        'Form_Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 857)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Peminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Peminjaman"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_pinjamansekarang As TextBox
    Friend WithEvents txt_pernahpinjam As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_idanggota As TextBox
    Friend WithEvents txt_tanggal As TextBox
    Friend WithEvents txt_idpinjam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents txt_tahun As TextBox
    Friend WithEvents txt_kategori As TextBox
    Friend WithEvents txt_penerbit As TextBox
    Friend WithEvents txt_pengarang As TextBox
    Friend WithEvents txt_judul As TextBox
    Friend WithEvents txt_idbuku As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txt_bataspinjaman As TextBox
    Friend WithEvents Label9 As Label
End Class

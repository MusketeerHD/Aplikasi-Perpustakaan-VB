<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pengembalian
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
        Me.txt_telp = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_idkembali = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_hilang = New System.Windows.Forms.ComboBox()
        Me.cb_rusak = New System.Windows.Forms.ComboBox()
        Me.txt_denda = New System.Windows.Forms.TextBox()
        Me.txt_terlambat = New System.Windows.Forms.TextBox()
        Me.txt_lamaPinjam = New System.Windows.Forms.TextBox()
        Me.txt_idpinjam = New System.Windows.Forms.TextBox()
        Me.txt_tglpinjam = New System.Windows.Forms.TextBox()
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
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_totalDenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_dibayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_kembalian = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_bataspinjaman = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_dendaperhari = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_dendarusak = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1275, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pengembalian Buku"
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
        Me.GroupBox2.Controls.Add(Me.txt_telp)
        Me.GroupBox2.Controls.Add(Me.txt_alamat)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_nama)
        Me.GroupBox2.Controls.Add(Me.txt_idanggota)
        Me.GroupBox2.Controls.Add(Me.txt_tanggal)
        Me.GroupBox2.Controls.Add(Me.txt_idkembali)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1275, 107)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi Pengembalian"
        '
        'txt_telp
        '
        Me.txt_telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telp.Location = New System.Drawing.Point(688, 65)
        Me.txt_telp.Name = "txt_telp"
        Me.txt_telp.ReadOnly = True
        Me.txt_telp.Size = New System.Drawing.Size(160, 26)
        Me.txt_telp.TabIndex = 11
        '
        'txt_alamat
        '
        Me.txt_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamat.Location = New System.Drawing.Point(688, 33)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.ReadOnly = True
        Me.txt_alamat.Size = New System.Drawing.Size(160, 26)
        Me.txt_alamat.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(583, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "No Telp."
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(583, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 22)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Alamat"
        '
        'txt_nama
        '
        Me.txt_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.Location = New System.Drawing.Point(400, 65)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(160, 26)
        Me.txt_nama.TabIndex = 7
        '
        'txt_idanggota
        '
        Me.txt_idanggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idanggota.Location = New System.Drawing.Point(400, 33)
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
        'txt_idkembali
        '
        Me.txt_idkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idkembali.Location = New System.Drawing.Point(117, 33)
        Me.txt_idkembali.Name = "txt_idkembali"
        Me.txt_idkembali.ReadOnly = True
        Me.txt_idkembali.Size = New System.Drawing.Size(160, 26)
        Me.txt_idkembali.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(295, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(295, 33)
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
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Kembali"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cb_hilang)
        Me.GroupBox3.Controls.Add(Me.cb_rusak)
        Me.GroupBox3.Controls.Add(Me.txt_denda)
        Me.GroupBox3.Controls.Add(Me.txt_terlambat)
        Me.GroupBox3.Controls.Add(Me.txt_lamaPinjam)
        Me.GroupBox3.Controls.Add(Me.txt_idpinjam)
        Me.GroupBox3.Controls.Add(Me.txt_tglpinjam)
        Me.GroupBox3.Controls.Add(Me.txt_judul)
        Me.GroupBox3.Controls.Add(Me.txt_idbuku)
        Me.GroupBox3.Controls.Add(Me.dgv1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1275, 273)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Transaksi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1217, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cb_hilang
        '
        Me.cb_hilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_hilang.FormattingEnabled = True
        Me.cb_hilang.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.cb_hilang.Location = New System.Drawing.Point(984, 20)
        Me.cb_hilang.Name = "cb_hilang"
        Me.cb_hilang.Size = New System.Drawing.Size(99, 26)
        Me.cb_hilang.TabIndex = 14
        '
        'cb_rusak
        '
        Me.cb_rusak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_rusak.FormattingEnabled = True
        Me.cb_rusak.Items.AddRange(New Object() {"Rusak", "Tidak Rusak"})
        Me.cb_rusak.Location = New System.Drawing.Point(885, 20)
        Me.cb_rusak.Name = "cb_rusak"
        Me.cb_rusak.Size = New System.Drawing.Size(99, 26)
        Me.cb_rusak.TabIndex = 13
        '
        'txt_denda
        '
        Me.txt_denda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_denda.Location = New System.Drawing.Point(1081, 20)
        Me.txt_denda.Name = "txt_denda"
        Me.txt_denda.ReadOnly = True
        Me.txt_denda.Size = New System.Drawing.Size(133, 26)
        Me.txt_denda.TabIndex = 12
        '
        'txt_terlambat
        '
        Me.txt_terlambat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terlambat.Location = New System.Drawing.Point(754, 20)
        Me.txt_terlambat.Name = "txt_terlambat"
        Me.txt_terlambat.ReadOnly = True
        Me.txt_terlambat.Size = New System.Drawing.Size(131, 26)
        Me.txt_terlambat.TabIndex = 10
        '
        'txt_lamaPinjam
        '
        Me.txt_lamaPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lamaPinjam.Location = New System.Drawing.Point(625, 20)
        Me.txt_lamaPinjam.Name = "txt_lamaPinjam"
        Me.txt_lamaPinjam.ReadOnly = True
        Me.txt_lamaPinjam.Size = New System.Drawing.Size(129, 26)
        Me.txt_lamaPinjam.TabIndex = 9
        '
        'txt_idpinjam
        '
        Me.txt_idpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idpinjam.Location = New System.Drawing.Point(525, 20)
        Me.txt_idpinjam.Name = "txt_idpinjam"
        Me.txt_idpinjam.ReadOnly = True
        Me.txt_idpinjam.Size = New System.Drawing.Size(101, 26)
        Me.txt_idpinjam.TabIndex = 8
        '
        'txt_tglpinjam
        '
        Me.txt_tglpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tglpinjam.Location = New System.Drawing.Point(390, 20)
        Me.txt_tglpinjam.Name = "txt_tglpinjam"
        Me.txt_tglpinjam.ReadOnly = True
        Me.txt_tglpinjam.Size = New System.Drawing.Size(138, 26)
        Me.txt_tglpinjam.TabIndex = 7
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
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv1.Location = New System.Drawing.Point(3, 52)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(1269, 218)
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
        Me.Column3.HeaderText = "Tanggal Pinjam"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID Pinjam"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Lama Pinjam"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.HeaderText = "Terlambat"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.HeaderText = "Kondisi"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Hilang"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Denda"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 130
        '
        'txt_totalDenda
        '
        Me.txt_totalDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalDenda.Location = New System.Drawing.Point(1054, 490)
        Me.txt_totalDenda.Name = "txt_totalDenda"
        Me.txt_totalDenda.ReadOnly = True
        Me.txt_totalDenda.Size = New System.Drawing.Size(216, 29)
        Me.txt_totalDenda.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(926, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Denda"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(926, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dibayar"
        '
        'txt_dibayar
        '
        Me.txt_dibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dibayar.Location = New System.Drawing.Point(1054, 525)
        Me.txt_dibayar.Name = "txt_dibayar"
        Me.txt_dibayar.Size = New System.Drawing.Size(216, 29)
        Me.txt_dibayar.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(926, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kembalian"
        '
        'txt_kembalian
        '
        Me.txt_kembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kembalian.Location = New System.Drawing.Point(1054, 560)
        Me.txt_kembalian.Name = "txt_kembalian"
        Me.txt_kembalian.ReadOnly = True
        Me.txt_kembalian.Size = New System.Drawing.Size(216, 29)
        Me.txt_kembalian.TabIndex = 12
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(130, 494)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(102, 40)
        Me.btn_clear.TabIndex = 21
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(256, 494)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(102, 40)
        Me.btn_close.TabIndex = 20
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(11, 494)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(102, 40)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_bataspinjaman
        '
        Me.txt_bataspinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bataspinjaman.Location = New System.Drawing.Point(725, 494)
        Me.txt_bataspinjaman.Name = "txt_bataspinjaman"
        Me.txt_bataspinjaman.ReadOnly = True
        Me.txt_bataspinjaman.Size = New System.Drawing.Size(160, 26)
        Me.txt_bataspinjaman.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(605, 494)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 22)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Batas Pinjam"
        '
        'txt_dendaperhari
        '
        Me.txt_dendaperhari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dendaperhari.Location = New System.Drawing.Point(725, 526)
        Me.txt_dendaperhari.Name = "txt_dendaperhari"
        Me.txt_dendaperhari.ReadOnly = True
        Me.txt_dendaperhari.Size = New System.Drawing.Size(160, 26)
        Me.txt_dendaperhari.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(605, 526)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Denda / hari"
        '
        'txt_dendarusak
        '
        Me.txt_dendarusak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dendarusak.Location = New System.Drawing.Point(725, 558)
        Me.txt_dendarusak.Name = "txt_dendarusak"
        Me.txt_dendarusak.ReadOnly = True
        Me.txt_dendarusak.Size = New System.Drawing.Size(160, 26)
        Me.txt_dendarusak.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(605, 558)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 22)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Denda Rusak"
        '
        'Form_Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 687)
        Me.Controls.Add(Me.txt_dendarusak)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_dendaperhari)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_bataspinjaman)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_kembalian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_dibayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_totalDenda)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Pengembalian"
        Me.Text = "Form_Pengembalian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_idanggota As TextBox
    Friend WithEvents txt_tanggal As TextBox
    Friend WithEvents txt_idkembali As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_denda As TextBox
    Friend WithEvents txt_terlambat As TextBox
    Friend WithEvents txt_lamaPinjam As TextBox
    Friend WithEvents txt_idpinjam As TextBox
    Friend WithEvents txt_tglpinjam As TextBox
    Friend WithEvents txt_judul As TextBox
    Friend WithEvents txt_idbuku As TextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents cb_hilang As ComboBox
    Friend WithEvents cb_rusak As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_totalDenda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_dibayar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_kembalian As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_telp As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_bataspinjaman As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_dendaperhari As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_dendarusak As TextBox
    Friend WithEvents Label13 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtJudulFilm = New MetroFramework.Controls.MetroLabel()
        Me.txtAuditorium = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.showtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtGrandtotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.txtKode = New MetroFramework.Controls.MetroLabel()
        Me.txtIDpeg = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(10, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Kode transaksi:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(10, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Judul film:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(10, 128)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Showtime:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(10, 163)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Seat:"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(103, 93)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(193, 29)
        Me.MetroComboBox1.TabIndex = 4
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Location = New System.Drawing.Point(103, 128)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(193, 29)
        Me.MetroComboBox2.TabIndex = 5
        Me.MetroComboBox2.UseSelectable = True
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FormattingEnabled = True
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Location = New System.Drawing.Point(103, 163)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(193, 29)
        Me.MetroComboBox3.TabIndex = 6
        Me.MetroComboBox3.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(336, 14)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Judul film:"
        '
        'txtJudulFilm
        '
        Me.txtJudulFilm.AutoSize = True
        Me.txtJudulFilm.Location = New System.Drawing.Point(410, 14)
        Me.txtJudulFilm.Name = "txtJudulFilm"
        Me.txtJudulFilm.Size = New System.Drawing.Size(68, 19)
        Me.txtJudulFilm.TabIndex = 8
        Me.txtJudulFilm.Text = "Judul film:"
        '
        'txtAuditorium
        '
        Me.txtAuditorium.AutoSize = True
        Me.txtAuditorium.Location = New System.Drawing.Point(410, 44)
        Me.txtAuditorium.Name = "txtAuditorium"
        Me.txtAuditorium.Size = New System.Drawing.Size(68, 19)
        Me.txtAuditorium.TabIndex = 10
        Me.txtAuditorium.Text = "Judul film:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(336, 44)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel7.TabIndex = 9
        Me.MetroLabel7.Text = "Auditorium:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(410, 75)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel6.TabIndex = 12
        Me.MetroLabel6.Text = "Judul film:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(336, 75)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel8.TabIndex = 11
        Me.MetroLabel8.Text = "Harga kursi:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(318, 113)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(86, 34)
        Me.MetroButton1.TabIndex = 13
        Me.MetroButton1.Text = "Add"
        Me.MetroButton1.UseSelectable = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.judul, Me.showtime, Me.seat})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(767, 208)
        Me.DataGridView1.TabIndex = 14
        '
        'judul
        '
        Me.judul.HeaderText = "Judul Film"
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        '
        'showtime
        '
        Me.showtime.HeaderText = "Showtime"
        Me.showtime.Name = "showtime"
        Me.showtime.ReadOnly = True
        '
        'seat
        '
        Me.seat.HeaderText = "seat"
        Me.seat.Name = "seat"
        Me.seat.ReadOnly = True
        '
        'txtGrandtotal
        '
        Me.txtGrandtotal.AutoSize = True
        Me.txtGrandtotal.Location = New System.Drawing.Point(592, 14)
        Me.txtGrandtotal.Name = "txtGrandtotal"
        Me.txtGrandtotal.Size = New System.Drawing.Size(78, 19)
        Me.txtGrandtotal.TabIndex = 16
        Me.txtGrandtotal.Text = "Grand total:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(518, 14)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel10.TabIndex = 15
        Me.MetroLabel10.Text = "Grand total:"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(318, 163)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(86, 34)
        Me.MetroButton2.TabIndex = 17
        Me.MetroButton2.Text = "Save Trx"
        Me.MetroButton2.UseSelectable = True
        '
        'txtKode
        '
        Me.txtKode.AutoSize = True
        Me.txtKode.Location = New System.Drawing.Point(111, 60)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(29, 19)
        Me.txtKode.TabIndex = 18
        Me.txtKode.Text = "rab"
        '
        'txtIDpeg
        '
        Me.txtIDpeg.AutoSize = True
        Me.txtIDpeg.Location = New System.Drawing.Point(247, 60)
        Me.txtIDpeg.Name = "txtIDpeg"
        Me.txtIDpeg.Size = New System.Drawing.Size(29, 19)
        Me.txtIDpeg.TabIndex = 20
        Me.txtIDpeg.Text = "rab"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(146, 60)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "ID Pegawai:"
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIDpeg)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.txtGrandtotal)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txtAuditorium)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtJudulFilm)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroComboBox3)
        Me.Controls.Add(Me.MetroComboBox2)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "transaksi"
        Me.Text = "transaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtJudulFilm As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAuditorium As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents showtime As DataGridViewTextBoxColumn
    Friend WithEvents seat As DataGridViewTextBoxColumn
    Friend WithEvents txtGrandtotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtKode As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIDpeg As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
End Class

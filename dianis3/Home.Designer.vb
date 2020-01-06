<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowtimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FnBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataFilmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTranskaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaFnBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(701, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegawaiToolStripMenuItem, Me.FilmToolStripMenuItem, Me.ShowtimeToolStripMenuItem, Me.FnBToolStripMenuItem, Me.AuditoriumToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PegawaiToolStripMenuItem.Text = "Pegawai"
        '
        'FilmToolStripMenuItem
        '
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FilmToolStripMenuItem.Text = "Film"
        '
        'ShowtimeToolStripMenuItem
        '
        Me.ShowtimeToolStripMenuItem.Name = "ShowtimeToolStripMenuItem"
        Me.ShowtimeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowtimeToolStripMenuItem.Text = "Showtime"
        '
        'FnBToolStripMenuItem
        '
        Me.FnBToolStripMenuItem.Name = "FnBToolStripMenuItem"
        Me.FnBToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FnBToolStripMenuItem.Text = "FnB"
        '
        'AuditoriumToolStripMenuItem
        '
        Me.AuditoriumToolStripMenuItem.Name = "AuditoriumToolStripMenuItem"
        Me.AuditoriumToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AuditoriumToolStripMenuItem.Text = "Auditorium"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataFilmToolStripMenuItem, Me.DataFilmToolStripMenuItem1, Me.DataTranskaksiToolStripMenuItem, Me.DataToolStripMenuItem, Me.DataTransaksiFilmToolStripMenuItem, Me.TiketToolStripMenuItem, Me.NotaFnBToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataFilmToolStripMenuItem
        '
        Me.DataFilmToolStripMenuItem.Name = "DataFilmToolStripMenuItem"
        Me.DataFilmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataFilmToolStripMenuItem.Text = "Data Pegawai"
        '
        'DataFilmToolStripMenuItem1
        '
        Me.DataFilmToolStripMenuItem1.Name = "DataFilmToolStripMenuItem1"
        Me.DataFilmToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataFilmToolStripMenuItem1.Text = "Data Film Baru"
        '
        'DataTranskaksiToolStripMenuItem
        '
        Me.DataTranskaksiToolStripMenuItem.Name = "DataTranskaksiToolStripMenuItem"
        Me.DataTranskaksiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataTranskaksiToolStripMenuItem.Text = "Data FnB Baru"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataToolStripMenuItem.Text = "Data Trx FnB"
        '
        'DataTransaksiFilmToolStripMenuItem
        '
        Me.DataTransaksiFilmToolStripMenuItem.Name = "DataTransaksiFilmToolStripMenuItem"
        Me.DataTransaksiFilmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataTransaksiFilmToolStripMenuItem.Text = "Data Transaksi Film"
        '
        'TiketToolStripMenuItem
        '
        Me.TiketToolStripMenuItem.Name = "TiketToolStripMenuItem"
        Me.TiketToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiketToolStripMenuItem.Text = "Tiket"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'NotaFnBToolStripMenuItem
        '
        Me.NotaFnBToolStripMenuItem.Name = "NotaFnBToolStripMenuItem"
        Me.NotaFnBToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NotaFnBToolStripMenuItem.Text = "Nota FnB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 403)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowtimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FnBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditoriumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataFilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataFilmToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataTranskaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiFilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotaFnBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class

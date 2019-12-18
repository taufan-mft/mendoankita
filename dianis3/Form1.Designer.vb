<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowtimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FnBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
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
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 470)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class

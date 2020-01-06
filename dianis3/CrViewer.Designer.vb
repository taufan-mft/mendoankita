<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crviewer
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportPegawai1 = New dianis3.CrystalReportPegawai()
        Me.CrystalReportAudio1 = New dianis3.CrystalReportAudio()
        Me.CrystalReportFilm1 = New dianis3.CrystalReportFilm()
        Me.CrystalReportFnb1 = New dianis3.CrystalReportFnb()
        Me.CrystalReportTiket1 = New dianis3.CrystalReportTiket()
        Me.CrystalReportPegawai2 = New dianis3.CrystalReportPegawai()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReportPegawai2
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(760, 370)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'crviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "crviewer"
        Me.Text = "crviewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportPegawai1 As CrystalReportPegawai
    Friend WithEvents CrystalReportAudio1 As CrystalReportAudio
    Friend WithEvents CrystalReportFilm1 As CrystalReportFilm
    Friend WithEvents CrystalReportTiket1 As CrystalReportTiket
    Friend WithEvents CrystalReportFnb1 As CrystalReportFnb
    Friend WithEvents CrystalReportPegawai2 As CrystalReportPegawai
End Class

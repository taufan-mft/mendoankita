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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(35, 98)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(97, 50)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "Pegawai"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(171, 98)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(97, 50)
        Me.MetroButton2.TabIndex = 1
        Me.MetroButton2.Text = "Film"
        Me.MetroButton2.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 470)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class

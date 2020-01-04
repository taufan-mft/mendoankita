<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class film
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnInput = New MetroFramework.Controls.MetroButton()
        Me.txtGenreFilm = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtRatingFilm = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtJudulFilm = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtIDFilm = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(471, 201)
        Me.DataGridView1.TabIndex = 37
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(419, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(253, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(334, 160)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(419, 122)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(334, 122)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(253, 122)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 31
        Me.btnInput.Text = "Input"
        Me.btnInput.UseSelectable = True
        '
        'txtGenreFilm
        '
        '
        '
        '
        Me.txtGenreFilm.CustomButton.Image = Nothing
        Me.txtGenreFilm.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.txtGenreFilm.CustomButton.Name = ""
        Me.txtGenreFilm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGenreFilm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGenreFilm.CustomButton.TabIndex = 1
        Me.txtGenreFilm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGenreFilm.CustomButton.UseSelectable = True
        Me.txtGenreFilm.CustomButton.Visible = False
        Me.txtGenreFilm.Lines = New String(-1) {}
        Me.txtGenreFilm.Location = New System.Drawing.Point(110, 136)
        Me.txtGenreFilm.MaxLength = 32767
        Me.txtGenreFilm.Name = "txtGenreFilm"
        Me.txtGenreFilm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenreFilm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGenreFilm.SelectedText = ""
        Me.txtGenreFilm.SelectionLength = 0
        Me.txtGenreFilm.SelectionStart = 0
        Me.txtGenreFilm.ShortcutsEnabled = True
        Me.txtGenreFilm.Size = New System.Drawing.Size(126, 23)
        Me.txtGenreFilm.TabIndex = 26
        Me.txtGenreFilm.UseSelectable = True
        Me.txtGenreFilm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGenreFilm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel3.TabIndex = 25
        Me.MetroLabel3.Text = "Genre:"
        '
        'txtRatingFilm
        '
        '
        '
        '
        Me.txtRatingFilm.CustomButton.Image = Nothing
        Me.txtRatingFilm.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.txtRatingFilm.CustomButton.Name = ""
        Me.txtRatingFilm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRatingFilm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRatingFilm.CustomButton.TabIndex = 1
        Me.txtRatingFilm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRatingFilm.CustomButton.UseSelectable = True
        Me.txtRatingFilm.CustomButton.Visible = False
        Me.txtRatingFilm.Lines = New String(-1) {}
        Me.txtRatingFilm.Location = New System.Drawing.Point(110, 165)
        Me.txtRatingFilm.MaxLength = 32767
        Me.txtRatingFilm.Name = "txtRatingFilm"
        Me.txtRatingFilm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRatingFilm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRatingFilm.SelectedText = ""
        Me.txtRatingFilm.SelectionLength = 0
        Me.txtRatingFilm.SelectionStart = 0
        Me.txtRatingFilm.ShortcutsEnabled = True
        Me.txtRatingFilm.Size = New System.Drawing.Size(126, 23)
        Me.txtRatingFilm.TabIndex = 24
        Me.txtRatingFilm.UseSelectable = True
        Me.txtRatingFilm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRatingFilm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 165)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel4.TabIndex = 23
        Me.MetroLabel4.Text = "Rating:"
        '
        'txtJudulFilm
        '
        '
        '
        '
        Me.txtJudulFilm.CustomButton.Image = Nothing
        Me.txtJudulFilm.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.txtJudulFilm.CustomButton.Name = ""
        Me.txtJudulFilm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtJudulFilm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtJudulFilm.CustomButton.TabIndex = 1
        Me.txtJudulFilm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtJudulFilm.CustomButton.UseSelectable = True
        Me.txtJudulFilm.CustomButton.Visible = False
        Me.txtJudulFilm.Lines = New String(-1) {}
        Me.txtJudulFilm.Location = New System.Drawing.Point(110, 107)
        Me.txtJudulFilm.MaxLength = 32767
        Me.txtJudulFilm.Name = "txtJudulFilm"
        Me.txtJudulFilm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJudulFilm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtJudulFilm.SelectedText = ""
        Me.txtJudulFilm.SelectionLength = 0
        Me.txtJudulFilm.SelectionStart = 0
        Me.txtJudulFilm.ShortcutsEnabled = True
        Me.txtJudulFilm.Size = New System.Drawing.Size(126, 23)
        Me.txtJudulFilm.TabIndex = 22
        Me.txtJudulFilm.UseSelectable = True
        Me.txtJudulFilm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtJudulFilm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 107)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel2.TabIndex = 21
        Me.MetroLabel2.Text = "Judul film:"
        '
        'txtIDFilm
        '
        '
        '
        '
        Me.txtIDFilm.CustomButton.Image = Nothing
        Me.txtIDFilm.CustomButton.Location = New System.Drawing.Point(104, 1)
        Me.txtIDFilm.CustomButton.Name = ""
        Me.txtIDFilm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIDFilm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIDFilm.CustomButton.TabIndex = 1
        Me.txtIDFilm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIDFilm.CustomButton.UseSelectable = True
        Me.txtIDFilm.CustomButton.Visible = False
        Me.txtIDFilm.Lines = New String(-1) {}
        Me.txtIDFilm.Location = New System.Drawing.Point(110, 78)
        Me.txtIDFilm.MaxLength = 32767
        Me.txtIDFilm.Name = "txtIDFilm"
        Me.txtIDFilm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDFilm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDFilm.SelectedText = ""
        Me.txtIDFilm.SelectionLength = 0
        Me.txtIDFilm.SelectionStart = 0
        Me.txtIDFilm.ShortcutsEnabled = True
        Me.txtIDFilm.Size = New System.Drawing.Size(126, 23)
        Me.txtIDFilm.TabIndex = 20
        Me.txtIDFilm.UseSelectable = True
        Me.txtIDFilm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIDFilm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 78)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 19
        Me.MetroLabel1.Text = "ID Film:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(443, 12)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(51, 25)
        Me.MetroLabel8.TabIndex = 39
        Me.MetroLabel8.Text = "Halo,"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(398, 12)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(51, 25)
        Me.MetroLabel7.TabIndex = 38
        Me.MetroLabel7.Text = "Halo,"
        '
        'film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 439)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtGenreFilm)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtRatingFilm)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtJudulFilm)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtIDFilm)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "film"
        Me.Text = "film"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInput As MetroFramework.Controls.MetroButton
    Friend WithEvents txtGenreFilm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtRatingFilm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtJudulFilm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIDFilm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
End Class

Public Class audi
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        clearForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        btnInput.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb) = True) Then
            MsgBox("Jangan kosong rai.")
        Else
            Dim winny As Boolean = checkDuplicate("fnb", "ID_FnB", txtIDAudi.Text)
            If winny = True Then
                MsgBox("Jangan duplikat om.")
            Else
                simpanData("fnb", txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
                tampilkanData("SELECT * FROM film", DataGridView1)
            End If
        End If
        btnInput.Enabled = True
        btnSave.Enabled = False
    End Sub
    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        showtoBox(e.RowIndex, DataGridView1, txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        nyalainForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)

        btnSave.Enabled = False
        btnInput.Enabled = False
        txtIDAudi.Enabled = False
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb) = True) Then
            MsgBox("Jangan kosong rai.")
        Else
            'TODO NEED ATTTENTION HERE
            updateData("auditorium", "ID_auditorium", txtIDAudi.Text, "nama_audi", txtNamaAudi.Text, "kelas_audi", txtKelasAudi.Text, "harga_kursi", txtJenisFnb.Text)
            tampilkanData("SELECT * FROM auditorium", DataGridView1)
            clearForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
            matiForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
            btnInput.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapusData("fnb", "ID_FnB", txtIDAudi.Text)
        tampilkanData("select * from film", DataGridView1)
        clearForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        matiForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        enableButton(btnInput)
        disableButton(btnEdit, btnDelete)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        matiForm(txtIDAudi, txtNamaAudi, txtKelasAudi, txtJenisFnb)
        enableButton(btnInput)
        disableButton(btnEdit, btnDelete, btnSave)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub audi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkanData("SELECT * FROM auditorium", DataGridView1)
    End Sub
End Class
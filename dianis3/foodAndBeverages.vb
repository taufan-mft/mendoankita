Public Class foodAndBeverages


    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nyalainForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        clearForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        btnInput.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub foodAndBeverages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksiDB()
        matiForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        tampilkanData("select * from fnb", DataGridView1)
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        showtoBox(e.RowIndex, DataGridView1, txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        nyalainForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)

        btnSave.Enabled = False
        btnInput.Enabled = False
        txtIDFnb.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (checkEmpty(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            Dim winny As Boolean = checkDuplicate("fnb", "ID_FnB", txtIDFnb.Text)
            If winny = True Then
                MsgBox("weh duploikat")
            Else
                simpanData("fnb", txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
                tampilkanData("SELECT * FROM fnb", DataGridView1)
            End If
        End If
        btnInput.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (checkEmpty(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb) = True) Then
            MsgBox("Jangan kosong ra")
        Else
            updateData("fnb", "ID_FnB", txtIDFnb.Text, "nama_fnb", txtNamaFnb.Text, "harga", txtHargaFnb.Text, "jenis", txtJenisFnb.Text)
            tampilkanData("SELECT * FROM fnb", DataGridView1)
            clearForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
            matiForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
            btnInput.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapusData("fnb", "ID_FnB", txtIDFnb.Text)
        tampilkanData("select * from fnb", DataGridView1)
        clearForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        matiForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        enableButton(btnInput)
        disableButton(btnEdit, btnDelete)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        matiForm(txtIDFnb, txtNamaFnb, txtHargaFnb, txtJenisFnb)
        enableButton(btnInput)
        disableButton(btnEdit, btnDelete, btnSave)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
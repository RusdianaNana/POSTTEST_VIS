Public Class FormFilm

    Private Sub Kosong()
        txtKodeFilm.Clear()
        txtJudulFilm.Clear()
        txtGenre.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeFilm.Focus()
    End Sub

    Private Sub TampilData()
        dgvFilm.DataSource = GetAllFilm()
    End Sub

    Private Sub FormFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiFilm(ErrorProvider1, txtKodeFilm, txtJudulFilm, txtGenre) Then Exit Sub

        Dim kode As String = txtKodeFilm.Text.Trim()
        Dim judul As String = txtJudulFilm.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Film sudah ada", "Peringatan")
            txtKodeFilm.Focus()
            Exit Sub
        End If

        If SimpanFilm(kode, judul, genre) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahFilm(txtKodeFilm.Text, txtJudulFilm.Text, txtGenre.Text) Then
            MessageBox.Show("Data berhasil diubah", "Informasi")
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Peringatan")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeFilm.Text = "" Then
            MessageBox.Show("Pilih data dulu", "Peringatan")
            Exit Sub
        End If

        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            If HapusFilm(txtKodeFilm.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvFilm.DataSource = SearchFilm(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFilm.CellClick
        If e.RowIndex >= 0 Then
            txtKodeFilm.Text = dgvFilm.Rows(e.RowIndex).Cells("kodeFilm").Value.ToString()
            txtJudulFilm.Text = dgvFilm.Rows(e.RowIndex).Cells("judulFilm").Value.ToString()
            txtGenre.Text = dgvFilm.Rows(e.RowIndex).Cells("genre").Value.ToString()
        End If
    End Sub
End Class
Public Class FormFilm

    ' =========================
    ' TAMPIL DATA
    ' =========================
    Private Sub TampilData()
        dgvFilm.DataSource = GetAllFilm()
    End Sub

    ' =========================
    ' KOSONGKAN INPUT
    ' =========================
    Private Sub Kosong()
        txtKodeFilm.Clear()
        txtJudulFilm.Clear()
        txtGenre.Clear()
    End Sub

    ' =========================
    ' SAAT FORM LOAD
    ' =========================
    Private Sub FormFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    ' =========================
    ' KLIK DATA GRID
    ' =========================
    Private Sub dgvFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFilm.CellClick
        If e.RowIndex >= 0 Then
            txtKodeFilm.Text = dgvFilm.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtJudulFilm.Text = dgvFilm.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtGenre.Text = dgvFilm.Rows(e.RowIndex).Cells(2).Value.ToString()
        End If
    End Sub

    ' =========================
    ' BUTTON SIMPAN (NON AKTIF DULU)
    ' =========================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        MessageBox.Show("Fitur simpan belum diaktifkan")
    End Sub

    ' =========================
    ' BUTTON UBAH
    ' =========================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        MessageBox.Show("Fitur ubah belum diaktifkan")
    End Sub

    ' =========================
    ' BUTTON HAPUS
    ' =========================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        MessageBox.Show("Fitur hapus belum diaktifkan")
    End Sub

    ' =========================
    ' BUTTON RESET
    ' =========================
    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        Kosong()
    End Sub

End Class
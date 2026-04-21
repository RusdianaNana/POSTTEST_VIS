Public Class FormMenu

    'Saat form pertama kali dibuka
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tidak wajib isi apa-apa (sesuai modul)
    End Sub

    'Tombol ke FormFilm
    Private Sub btnFilm_Click(sender As Object, e As EventArgs) Handles btnFilm.Click
        FormFilm.Show()
        Me.Hide() 'biar menu hilang (opsional tapi bagus)
    End Sub

    'Tombol keluar aplikasi
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
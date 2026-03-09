Public Class Form1
    Public judul As String
    Public genre As String
    Public index As Integer
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtJudul.Text
        genre = txtGenre.Text
        If judul = "" And genre = "" Then
            MessageBox.Show("Judul dan Genre Harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapus.Text
        If judul <> "" Then
            For i As Integer = 0 To jumlahBuku - 1
                If daftarBuku(i, 0).ToLower = judul.ToLower Then
                    index = i
                    hapusBuku(index)
                    tampilkanData()
                    Exit Sub
                End If
            Next
            MessageBox.Show("Judul buku tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub tampilkanData()
        lstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
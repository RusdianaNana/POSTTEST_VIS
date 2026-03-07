Public Class Form1
    Private Function formatBuku(judul As String, genre As String) As String
        Return judul & " (" & genre & ")"
    End Function
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi")
        Else

            tambahBuku(judul, genre)
            tampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()

        End If

    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String = txtHapus.Text
        If judul = "" Then
            MessageBox.Show("Masukkan judul buku")
            Exit Sub
        End If
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).Contains(judul) Then
                daftarBuku(i) = ""
                MessageBox.Show("Buku berhasil dihapus")
                tampilkanData()
                Exit For

            End If

        Next

        txtHapus.Clear()

    End Sub
    Private Sub tampilkanData()
        lstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i) <> "" Then
                lstBuku.Items.Add(daftarBuku(i))
            End If

        Next

    End Sub

End Class
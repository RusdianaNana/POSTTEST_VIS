Public Module ModuleBuku

    Public daftarBuku(99) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(judul As String, genre As String)

        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
            jumlahBuku += 1
        End If

    End Sub

End Module
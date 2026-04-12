Imports MySqlConnector

Module DataModule

    Public Function GetAllFilm() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeFilm, judulFilm, genre FROM tbfilm ORDER BY kodeFilm ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchFilm(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeFilm, judulFilm, genre FROM tbfilm " &
                "WHERE kodeFilm LIKE @keyword OR judulFilm LIKE @keyword OR genre LIKE @keyword " &
                "ORDER BY kodeFilm ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbfilm WHERE kodeFilm=@kodeFilm"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeFilm", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message)
            Return True
        End Try
    End Function

    Public Function SimpanFilm(kode As String, judul As String, genre As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbfilm (kodeFilm, judulFilm, genre) VALUES (@kodeFilm,@judulFilm,@genre)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeFilm", kode)
                    cmd.Parameters.AddWithValue("@judulFilm", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahFilm(kode As String, judul As String, genre As String) As Boolean
        Try
            Dim query As String = "UPDATE tbfilm SET judulFilm=@judulFilm, genre=@genre WHERE kodeFilm=@kodeFilm"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeFilm", kode)
                    cmd.Parameters.AddWithValue("@judulFilm", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusFilm(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbfilm WHERE kodeFilm=@kodeFilm"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeFilm", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message)
            Return False
        End Try
    End Function

End Module
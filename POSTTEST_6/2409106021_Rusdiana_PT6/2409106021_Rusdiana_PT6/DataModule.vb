Imports MySql.Data.MySqlClient

Module DataModule

    Public conn As MySqlConnection

    Public Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=komunitas_db")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Function GetAllFilm() As DataTable
        Call Koneksi()

        Dim da As New MySqlDataAdapter("SELECT * FROM tbbuku", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        Return dt
    End Function
End Module
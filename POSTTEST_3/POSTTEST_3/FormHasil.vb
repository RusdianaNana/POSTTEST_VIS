Public Class FormHasil
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = "Nama : " & DataModule.Nama
        lblUmur.Text = "Umur : " & DataModule.Umur
        lblTelepon.Text = "Telepon : " & DataModule.Telepon
        lblAlamat.Text = "Alamat : " & DataModule.Alamat
        lblGender.Text = "Jenis Kelamin : " & DataModule.JK
        lblTanggal.Text = "Tanggal Lahir : " & DataModule.Tglahir
        lblHobby.Text = "Hobby : " & DataModule.Hobi
        picFoto.Image = Image.FromFile(DataModule.Foto)

    End Sub

End Class
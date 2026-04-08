Public Class FormKartu

    Public Sub TampilData(nama As String, id As String, komunitas As String, hp As String, hobby As String)

        lblNama.Text = nama
        lblID.Text = id
        lblKomunitas.Text = komunitas
        lblHP.Text = hp
        lblHobby.Text = hobby

        PictureBox1.Image = FormInput.PictureBox1.Image

    End Sub

End Class
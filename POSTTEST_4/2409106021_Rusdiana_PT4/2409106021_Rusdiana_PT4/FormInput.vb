Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TabData

        cmbKomunitas.Items.Clear()
        cmbKomunitas.Items.Add("Culers Indonesia")
        cmbKomunitas.Items.Add("Barca Esports")
        cmbKomunitas.Items.Add("La Masia Academy")
        cmbKomunitas.Items.Add("Barca Media & Content")
        cmbKomunitas.Items.Add("Barca Futsal Team")
        cmbKomunitas.Items.Add("Barca Creative Design")
        cmbKomunitas.Items.Add("Barca IT & Programming")
        cmbKomunitas.Items.Add("Barca Social Community")

        cmbKomunitas.SelectedIndex = 0
    End Sub

    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            valid = False
        End If

        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            valid = False
        End If

        If cmbKomunitas.Text = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, "Nomor tidak valid")
            valid = False
        End If

        Return valid
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbNoHP_Leave(sender As Object, e As EventArgs) Handles mtbNoHP.Leave
        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, "Format salah")
        Else
            ErrorProvider1.SetError(mtbNoHP, "")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If ValidasiInput() = False Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then

            Dim hobby As String = ""

            If cbFutsal.Checked Then hobby &= "Futsal, "
            If cbMusik.Checked Then hobby &= "Musik, "
            If cbCoding.Checked Then hobby &= "Coding, "
            If cbDesain.Checked Then hobby &= "Desain, "
            If cbEditing.Checked Then hobby &= "Editing, "
            If cbGaming.Checked Then hobby &= "Gaming, "
            If cbMembaca.Checked Then hobby &= "Membaca, "
            If cbTraveling.Checked Then hobby &= "Traveling, "

            FormKartu.TampilData(txtNama.Text, txtID.Text, cmbKomunitas.Text, mtbNoHP.Text, hobby)
            FormKartu.Show()

        End If

    End Sub

End Class
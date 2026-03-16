Imports System.IO
Public Class FormCetak
	Dim grupHobby() As CheckBox
	Dim grupGender() As RadioButton
	Private Function CekData() As Boolean

		grupHobby = {cbMembaca, cbMusik, cbGame, cbOlahraga, cbTraveling, cbMemasak, cbFotografi, cbMenulis, cbCoding, cbFilm}
		grupGender = {rbLaki, rbPerempuan}

		If Not ValidationModule.ValidasiTextBox(txtNama, "Nama tidak boleh kosong") Then Return False
		If Not ValidationModule.ValidasiTextBox(txtUmur, "Umur tidak boleh kosong") Then Return False
		If Not ValidationModule.ValidasiTextBox(txtTelepon, "Nomor telepon tidak boleh kosong") Then Return False
		If Not ValidationModule.ValidasiTextBox(txtAlamat, "Alamat tidak boleh kosong") Then Return False
		If Not ValidationModule.ValidasiRadioButton(grupGender, "Pilih jenis kelamin") Then Return False
		If Not ValidationModule.ValidasiCheckBox(grupHobby, "Pilih minimal 1 hobby") Then Return False
		If Not ValidationModule.ValidasiPictureBox(picFoto, "Foto tidak boleh kosong") Then Return False
		Return True

	End Function
	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
		If CekData() Then

			grupHobby = {cbMembaca, cbMusik, cbGame, cbOlahraga, cbTraveling, cbMemasak, cbFotografi, cbMenulis, cbCoding, cbFilm}
			grupGender = {rbLaki, rbPerempuan}

			Dim hobiSelected As String = DataModule.GetSelectedCheckBox(grupHobby)
			Dim genderSelected As String = DataModule.GetSelectedRadioButton(grupGender)

			DataModule.Nama = txtNama.Text
			DataModule.Umur = txtUmur.Text
			DataModule.Telepon = txtTelepon.Text
			DataModule.Alamat = txtAlamat.Text
			DataModule.JK = genderSelected
			DataModule.Hobi = hobiSelected
			DataModule.Tglahir = dtTanggalLahir.Value

			FormHasil.Show()

		End If

	End Sub



	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

		Dim openFileDialog As New OpenFileDialog

		openFileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg"

		If openFileDialog.ShowDialog = DialogResult.OK Then

			DataModule.Foto = openFileDialog.FileName
			picFoto.Image = Image.FromFile(DataModule.Foto)

		End If

	End Sub



	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub

	Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

	Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

End Class
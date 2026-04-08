Public Class Form1

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click

        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        SaveFileDialog1.Title = "Simpan Data"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim data As String =
                FormInput.txtNama.Text & "," &
                FormInput.txtID.Text & "," &
                FormInput.cmbKomunitas.Text & "," &
                FormInput.mtbNoHP.Text

            IO.File.WriteAllText(SaveFileDialog1.FileName, data)
            MessageBox.Show("Data berhasil disimpan")

        End If

    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka Data"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim isi As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            Dim data() As String = isi.Split(","c)

            FormInput.txtNama.Text = data(0)
            FormInput.txtID.Text = data(1)
            FormInput.cmbKomunitas.Text = data(2)
            FormInput.mtbNoHP.Text = data(3)

        End If

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

End Class
Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim input As String = txtIPS.Text.Replace(",", ".")
        Dim ip As Double

        If Double.TryParse(input, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, ip) Then
            totalIP += ip
            jumlahSemester += 1
            Dim ipk As Double = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            If ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            Else
                lblPredikat.Text = "Sangat Memuaskan"
            End If

            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Input yg anda masukkan harus angka!")
        End If

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"
    End Sub

End Class
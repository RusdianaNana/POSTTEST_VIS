<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        txtNama = New TextBox()
        lblUmur = New Label()
        txtUmur = New TextBox()
        lblTelpon = New Label()
        txtTelepon = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        lblTanggal = New Label()
        dtTanggalLahir = New DateTimePicker()
        grpGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        cbFilm = New CheckBox()
        cbMenulis = New CheckBox()
        cbCoding = New CheckBox()
        cbFotografi = New CheckBox()
        cbMemasak = New CheckBox()
        cbTraveling = New CheckBox()
        cbOlahraga = New CheckBox()
        cbGame = New CheckBox()
        cbMusik = New CheckBox()
        cbMembaca = New CheckBox()
        btnCetak = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpGender.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(91, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(634, 45)
        lblJudul.TabIndex = 0
        lblJudul.Text = "FORM PEMBUATAN KARTU KOMUNITAS"
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(34, 81)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(185, 172)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 1
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(50, 279)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(150, 30)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(273, 81)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(423, 81)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 31)
        txtNama.TabIndex = 4
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(273, 129)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 5
        lblUmur.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(423, 123)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(200, 31)
        txtUmur.TabIndex = 6
        ' 
        ' lblTelpon
        ' 
        lblTelpon.AutoSize = True
        lblTelpon.Location = New Point(241, 175)
        lblTelpon.Name = "lblTelpon"
        lblTelpon.Size = New Size(126, 25)
        lblTelpon.TabIndex = 7
        lblTelpon.Text = "Nomor Telpon"
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(423, 169)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(200, 31)
        txtTelepon.TabIndex = 8
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(264, 221)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 9
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(423, 218)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 60)
        txtAlamat.TabIndex = 10
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(252, 285)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(115, 25)
        lblTanggal.TabIndex = 11
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' dtTanggalLahir
        ' 
        dtTanggalLahir.Location = New Point(423, 285)
        dtTanggalLahir.Name = "dtTanggalLahir"
        dtTanggalLahir.Size = New Size(300, 31)
        dtTanggalLahir.TabIndex = 12
        ' 
        ' grpGender
        ' 
        grpGender.Controls.Add(rbPerempuan)
        grpGender.Controls.Add(rbLaki)
        grpGender.Location = New Point(50, 340)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(350, 80)
        grpGender.TabIndex = 13
        grpGender.TabStop = False
        grpGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(178, 30)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 14
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(12, 30)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(114, 29)
        rbLaki.TabIndex = 14
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(cbFilm)
        grpHobby.Controls.Add(cbMenulis)
        grpHobby.Controls.Add(cbCoding)
        grpHobby.Controls.Add(cbFotografi)
        grpHobby.Controls.Add(cbMemasak)
        grpHobby.Controls.Add(cbTraveling)
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbGame)
        grpHobby.Controls.Add(cbMusik)
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Location = New Point(50, 430)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(700, 120)
        grpHobby.TabIndex = 14
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbFilm
        ' 
        cbFilm.AutoSize = True
        cbFilm.Location = New Point(436, 73)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(137, 29)
        cbFilm.TabIndex = 9
        cbFilm.Text = "Nonton Film"
        cbFilm.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(239, 73)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(99, 29)
        cbMenulis.TabIndex = 8
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(344, 73)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 29)
        cbCoding.TabIndex = 7
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(132, 73)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(111, 29)
        cbFotografi.TabIndex = 6
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(20, 70)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(114, 29)
        cbMemasak.TabIndex = 5
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(420, 30)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(107, 29)
        cbTraveling.TabIndex = 4
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(310, 30)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(110, 29)
        cbOlahraga.TabIndex = 3
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(220, 30)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(84, 29)
        cbGame.TabIndex = 2
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(132, 30)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(85, 29)
        cbMusik.TabIndex = 1
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(20, 30)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(116, 29)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LightGreen
        btnCetak.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(452, 359)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(216, 40)
        btnCetak.TabIndex = 15
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(778, 544)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpGender)
        Controls.Add(dtTanggalLahir)
        Controls.Add(lblTanggal)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(lblTelpon)
        Controls.Add(txtUmur)
        Controls.Add(lblUmur)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Controls.Add(lblJudul)
        Name = "FormCetak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Cetak Kartu Komunitas"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblTelpon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents dtTanggalLahir As DateTimePicker
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents btnCetak As Button

End Class

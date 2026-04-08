<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        TabData = New TabPage()
        cmbKomunitas = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        txtID = New TextBox()
        tabKontak = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbNoHP = New MaskedTextBox()
        tabProfil = New TabPage()
        btnSimpan = New RadioButton()
        grpPeran = New GroupBox()
        cbTraveling = New CheckBox()
        cbMembaca = New CheckBox()
        cbEditing = New CheckBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbMusik = New CheckBox()
        cbDesain = New CheckBox()
        cbFutsal = New CheckBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        txtNama = New TextBox()
        TabControl1.SuspendLayout()
        TabData.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabData)
        TabControl1.Controls.Add(tabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(584, 339)
        TabControl1.TabIndex = 0
        ' 
        ' TabData
        ' 
        TabData.Controls.Add(txtNama)
        TabData.Controls.Add(cmbKomunitas)
        TabData.Controls.Add(RadioButton1)
        TabData.Controls.Add(RadioButton2)
        TabData.Controls.Add(DateTimePicker1)
        TabData.Controls.Add(txtID)
        TabData.Location = New Point(4, 34)
        TabData.Name = "TabData"
        TabData.Padding = New Padding(3)
        TabData.Size = New Size(576, 301)
        TabData.TabIndex = 0
        TabData.Text = "Data Utama"
        TabData.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Culers Indonesia (Fans Barca)", "", "Barca Esports", "", "La Masia Academy", "", "Barca Media & Content", "", "Barca Futsal Team", "", "Barca Creative Design", "", "Barca IT & Programming", "", "Barca Social Community"})
        cmbKomunitas.Location = New Point(6, 176)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(182, 33)
        cmbKomunitas.TabIndex = 11
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(144, 226)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(126, 29)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.Text = "Perempuan"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 226)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(100, 29)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Laki-laki"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(6, 124)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(6, 69)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Anggota"
        txtID.Size = New Size(150, 31)
        txtID.TabIndex = 7
        ' 
        ' tabKontak
        ' 
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(mtbNoHP)
        tabKontak.Location = New Point(4, 34)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(576, 301)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(218, 50)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(150, 31)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(34, 50)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 1
        ' 
        ' mtbNoHP
        ' 
        mtbNoHP.Location = New Point(129, 107)
        mtbNoHP.Mask = "0000-0000-0000"
        mtbNoHP.Name = "mtbNoHP"
        mtbNoHP.Size = New Size(150, 31)
        mtbNoHP.TabIndex = 0
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(btnSimpan)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(PictureBox1)
        tabProfil.Location = New Point(4, 34)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(576, 301)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSize = True
        btnSimpan.Location = New Point(17, 236)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(181, 29)
        btnSimpan.TabIndex = 3
        btnSimpan.TabStop = True
        btnSimpan.Text = "Simpan dan Cetak"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(cbTraveling)
        grpPeran.Controls.Add(cbMembaca)
        grpPeran.Controls.Add(cbEditing)
        grpPeran.Controls.Add(cbGaming)
        grpPeran.Controls.Add(cbCoding)
        grpPeran.Controls.Add(cbMusik)
        grpPeran.Controls.Add(cbDesain)
        grpPeran.Controls.Add(cbFutsal)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Location = New Point(237, 22)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(300, 257)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran"
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(172, 196)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(107, 29)
        cbTraveling.TabIndex = 10
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(37, 196)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(116, 29)
        cbMembaca.TabIndex = 9
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbEditing
        ' 
        cbEditing.AutoSize = True
        cbEditing.Location = New Point(172, 161)
        cbEditing.Name = "cbEditing"
        cbEditing.Size = New Size(93, 29)
        cbEditing.TabIndex = 8
        cbEditing.Text = "Editing"
        cbEditing.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(37, 161)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(100, 29)
        cbGaming.TabIndex = 7
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(172, 89)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 29)
        cbCoding.TabIndex = 6
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(37, 124)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(85, 29)
        cbMusik.TabIndex = 5
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbDesain
        ' 
        cbDesain.AutoSize = True
        cbDesain.Location = New Point(172, 124)
        cbDesain.Name = "cbDesain"
        cbDesain.Size = New Size(91, 29)
        cbDesain.TabIndex = 4
        cbDesain.Text = "Desain"
        cbDesain.UseVisualStyleBackColor = True
        ' 
        ' cbFutsal
        ' 
        cbFutsal.AutoSize = True
        cbFutsal.Location = New Point(37, 89)
        cbFutsal.Name = "cbFutsal"
        cbFutsal.Size = New Size(84, 29)
        cbFutsal.TabIndex = 3
        cbFutsal.Text = "Futsal"
        cbFutsal.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(210, 30)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(90, 29)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(93, 30)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(107, 29)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 30)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(81, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(44, 178)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(17, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 137)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(6, 22)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan Nama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 12
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "Input Data"
        TabControl1.ResumeLayout(False)
        TabData.ResumeLayout(False)
        TabData.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabData As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbNoHP As MaskedTextBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbFutsal As CheckBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbDesain As CheckBox
    Friend WithEvents btnSimpan As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtNama As TextBox
End Class

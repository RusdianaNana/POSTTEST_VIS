<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilm
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
        lblKode = New Label()
        txtKodeFilm = New TextBox()
        lblJudulFilm = New Label()
        txtJudulFilm = New TextBox()
        txtGenre = New TextBox()
        lblGenre = New Label()
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvFilm = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvFilm, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(259, 33)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(96, 25)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Film"
        ' 
        ' txtKodeFilm
        ' 
        txtKodeFilm.Location = New Point(468, 33)
        txtKodeFilm.Name = "txtKodeFilm"
        txtKodeFilm.Size = New Size(165, 31)
        txtKodeFilm.TabIndex = 1
        ' 
        ' lblJudulFilm
        ' 
        lblJudulFilm.AutoSize = True
        lblJudulFilm.Location = New Point(259, 88)
        lblJudulFilm.Name = "lblJudulFilm"
        lblJudulFilm.Size = New Size(98, 25)
        lblJudulFilm.TabIndex = 2
        lblJudulFilm.Text = "Judul Film"
        ' 
        ' txtJudulFilm
        ' 
        txtJudulFilm.Location = New Point(468, 88)
        txtJudulFilm.Name = "txtJudulFilm"
        txtJudulFilm.Size = New Size(165, 31)
        txtJudulFilm.TabIndex = 3
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(468, 138)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(165, 31)
        txtGenre.TabIndex = 4
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(259, 138)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(63, 25)
        lblGenre.TabIndex = 5
        lblGenre.Text = "Genre"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(259, 192)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(85, 25)
        lblSearch.TabIndex = 6
        lblSearch.Text = "Cari Film"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(468, 192)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(165, 31)
        txtSearch.TabIndex = 7
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Blue
        btnSimpan.Location = New Point(50, 248)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(123, 34)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Red
        btnUbah.Location = New Point(275, 248)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(123, 34)
        btnUbah.TabIndex = 9
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkRed
        btnHapus.Location = New Point(480, 248)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(123, 34)
        btnHapus.TabIndex = 10
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Gray
        btnBatal.Location = New Point(685, 248)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(123, 34)
        btnBatal.TabIndex = 11
        btnBatal.Text = "RESET"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvFilm
        ' 
        dgvFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFilm.Location = New Point(237, 304)
        dgvFilm.Name = "dgvFilm"
        dgvFilm.RowHeadersWidth = 62
        dgvFilm.Size = New Size(396, 225)
        dgvFilm.TabIndex = 12
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormFilm
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkBlue
        ClientSize = New Size(880, 541)
        Controls.Add(dgvFilm)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(lblGenre)
        Controls.Add(txtGenre)
        Controls.Add(txtJudulFilm)
        Controls.Add(lblJudulFilm)
        Controls.Add(txtKodeFilm)
        Controls.Add(lblKode)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Name = "FormFilm"
        Text = "DATA FILM BIOSKOP"
        CType(dgvFilm, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents txtKodeFilm As TextBox
    Friend WithEvents lblJudulFilm As Label
    Friend WithEvents txtJudulFilm As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvFilm As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class

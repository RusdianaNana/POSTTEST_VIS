<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        picFoto = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblGender = New Label()
        lblTanggal = New Label()
        Label1 = New Label()
        lblHobby = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(20, 50)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(120, 120)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(160, 50)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(160, 80)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(65, 25)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur :"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(160, 110)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(73, 25)
        lblTelepon.TabIndex = 3
        lblTelepon.Text = "Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(160, 140)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(77, 25)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat :"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(160, 170)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(125, 25)
        lblGender.TabIndex = 5
        lblGender.Text = "Jenis Kelamin :"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(160, 200)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(124, 25)
        lblTanggal.TabIndex = 6
        lblTanggal.Text = "Tanggal Lahir :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(336, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 7
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(161, 234)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(76, 25)
        lblHobby.TabIndex = 8
        lblHobby.Text = "Hobby :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Brown
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(778, 47)
        Panel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(263, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(326, 45)
        Label2.TabIndex = 0
        Label2.Text = "KARTU KOMUNITAS"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Crimson
        Panel2.Location = New Point(-33, 306)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(824, 150)
        Panel2.TabIndex = 10
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(778, 344)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblHobby)
        Controls.Add(Label1)
        Controls.Add(lblTanggal)
        Controls.Add(lblGender)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picFoto)
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        panelHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblJudul = New Label()
        panelMain = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblHobby = New Label()
        lblHP = New Label()
        lblKomunitas = New Label()
        lblID = New Label()
        lblNama = New Label()
        panelHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelMain.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(165), CByte(0), CByte(68))
        panelHeader.Controls.Add(PictureBox2)
        panelHeader.Controls.Add(lblJudul)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(800, 60)
        panelHeader.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(651, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(137, 75)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Showcard Gothic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(616, 44)
        lblJudul.TabIndex = 0
        lblJudul.Text = "FC BARCELONA COMMUNITY CARD"
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.FromArgb(CByte(10), CByte(31), CByte(68))
        panelMain.Controls.Add(Panel1)
        panelMain.Controls.Add(PictureBox1)
        panelMain.Controls.Add(lblHobby)
        panelMain.Controls.Add(lblHP)
        panelMain.Controls.Add(lblKomunitas)
        panelMain.Controls.Add(lblID)
        panelMain.Controls.Add(lblNama)
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(0, 60)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(800, 390)
        panelMain.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.Location = New Point(12, 272)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(759, 2)
        Panel1.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(145, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(232, 207)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.ForeColor = Color.Brown
        lblHobby.Location = New Point(455, 216)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(76, 25)
        lblHobby.TabIndex = 10
        lblHobby.Text = "Hobby :"
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.ForeColor = Color.Brown
        lblHP.Location = New Point(455, 175)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(73, 25)
        lblHP.TabIndex = 9
        lblHP.Text = "No HP :"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.ForeColor = Color.Brown
        lblKomunitas.Location = New Point(455, 130)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(100, 25)
        lblKomunitas.TabIndex = 8
        lblKomunitas.Text = "Komunitas:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.Brown
        lblID.Location = New Point(455, 95)
        lblID.Name = "lblID"
        lblID.Size = New Size(39, 25)
        lblID.TabIndex = 7
        lblID.Text = "ID :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = Color.Brown
        lblNama.Location = New Point(455, 48)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama :"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        Name = "FormKartu"
        Text = "FormKartu"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class

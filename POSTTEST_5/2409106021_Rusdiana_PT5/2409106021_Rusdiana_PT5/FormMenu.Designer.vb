<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        btnFilm = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(263, 89)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(279, 45)
        lblJudul.TabIndex = 0
        lblJudul.Text = "SISTEM BIOSKOP"
        ' 
        ' btnFilm
        ' 
        btnFilm.BackColor = Color.DarkBlue
        btnFilm.ForeColor = Color.White
        btnFilm.Location = New Point(288, 175)
        btnFilm.Name = "btnFilm"
        btnFilm.Size = New Size(200, 40)
        btnFilm.TabIndex = 1
        btnFilm.Text = "KELOLA DATA FILM"
        btnFilm.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.DarkRed
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(288, 269)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(200, 40)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "KELUAR"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnFilm)
        Controls.Add(lblJudul)
        Name = "FormMenu"
        Text = "MENU BIOSKOP "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnFilm As Button
    Friend WithEvents btnKeluar As Button

End Class

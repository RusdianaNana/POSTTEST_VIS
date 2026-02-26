<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        txtIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label2 = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(140, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(313, 115)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(232, 31)
        txtIPS.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(433, 185)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(313, 185)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 4
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(313, 238)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(232, 31)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(313, 314)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(19, 25)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class

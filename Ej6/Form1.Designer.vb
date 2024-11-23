<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblEspecie = New Label()
        lblTipo = New Label()
        cboEspecie = New ComboBox()
        cboRaza = New ComboBox()
        PictureBox1 = New PictureBox()
        lblPictBox = New Label()
        btnVerificar = New Button()
        btnExit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblEspecie
        ' 
        lblEspecie.AutoSize = True
        lblEspecie.Location = New Point(78, 28)
        lblEspecie.Name = "lblEspecie"
        lblEspecie.Size = New Size(59, 20)
        lblEspecie.TabIndex = 0
        lblEspecie.Text = "Especie"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Location = New Point(386, 28)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(41, 20)
        lblTipo.TabIndex = 1
        lblTipo.Text = "Raza"
        ' 
        ' cboEspecie
        ' 
        cboEspecie.AllowDrop = True
        cboEspecie.FormattingEnabled = True
        cboEspecie.Items.AddRange(New Object() {"Pez", "Perro", "Gato"})
        cboEspecie.Location = New Point(78, 52)
        cboEspecie.Name = "cboEspecie"
        cboEspecie.Size = New Size(151, 28)
        cboEspecie.TabIndex = 2
        ' 
        ' cboRaza
        ' 
        cboRaza.FormattingEnabled = True
        cboRaza.Location = New Point(372, 52)
        cboRaza.Name = "cboRaza"
        cboRaza.Size = New Size(151, 28)
        cboRaza.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Pez_ScarusTaeniopterus
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(78, 158)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(445, 265)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' lblPictBox
        ' 
        lblPictBox.AutoSize = True
        lblPictBox.Location = New Point(78, 135)
        lblPictBox.Name = "lblPictBox"
        lblPictBox.Size = New Size(128, 20)
        lblPictBox.TabIndex = 5
        lblPictBox.Text = "Has seleccionado:"
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(606, 158)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(94, 29)
        btnVerificar.TabIndex = 6
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(606, 207)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnVerificar)
        Controls.Add(lblPictBox)
        Controls.Add(PictureBox1)
        Controls.Add(cboRaza)
        Controls.Add(cboEspecie)
        Controls.Add(lblTipo)
        Controls.Add(lblEspecie)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEspecie As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboEspecie As ComboBox
    Friend WithEvents cboRaza As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPictBox As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnExit As Button

End Class

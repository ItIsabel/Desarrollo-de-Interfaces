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
        btnAbrirImagen = New Button()
        PictureBox1 = New PictureBox()
        btnGuardarImagen = New Button()
        btnGuardarTexto = New Button()
        TextBox1 = New TextBox()
        TextBoxRuta = New TextBox()
        btnAbrirRuta = New Button()
        ListArchivos = New ListBox()
        ListDirectorios = New ListBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        btnAbrirTexto = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAbrirImagen
        ' 
        btnAbrirImagen.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        btnAbrirImagen.BackgroundImage = My.Resources.Resources.boton
        btnAbrirImagen.BackgroundImageLayout = ImageLayout.Stretch
        btnAbrirImagen.FlatAppearance.BorderSize = 0
        btnAbrirImagen.FlatStyle = FlatStyle.Flat
        btnAbrirImagen.Font = New Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbrirImagen.ForeColor = SystemColors.ButtonHighlight
        btnAbrirImagen.Location = New Point(12, 184)
        btnAbrirImagen.Name = "btnAbrirImagen"
        btnAbrirImagen.Size = New Size(186, 60)
        btnAbrirImagen.TabIndex = 0
        btnAbrirImagen.Text = "Abrir Imagen"
        btnAbrirImagen.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(15, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(393, 166)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnGuardarImagen
        ' 
        btnGuardarImagen.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        btnGuardarImagen.BackgroundImage = My.Resources.Resources.boton
        btnGuardarImagen.BackgroundImageLayout = ImageLayout.Stretch
        btnGuardarImagen.FlatAppearance.BorderSize = 0
        btnGuardarImagen.FlatStyle = FlatStyle.Flat
        btnGuardarImagen.Font = New Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarImagen.ForeColor = SystemColors.ButtonHighlight
        btnGuardarImagen.Location = New Point(221, 184)
        btnGuardarImagen.Name = "btnGuardarImagen"
        btnGuardarImagen.Size = New Size(187, 60)
        btnGuardarImagen.TabIndex = 2
        btnGuardarImagen.Text = "Guardar Imagen"
        btnGuardarImagen.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarTexto
        ' 
        btnGuardarTexto.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        btnGuardarTexto.BackgroundImage = My.Resources.Resources.boton
        btnGuardarTexto.BackgroundImageLayout = ImageLayout.Stretch
        btnGuardarTexto.FlatAppearance.BorderSize = 0
        btnGuardarTexto.FlatStyle = FlatStyle.Flat
        btnGuardarTexto.Font = New Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarTexto.ForeColor = SystemColors.ButtonHighlight
        btnGuardarTexto.Location = New Point(221, 368)
        btnGuardarTexto.Name = "btnGuardarTexto"
        btnGuardarTexto.Size = New Size(187, 61)
        btnGuardarTexto.TabIndex = 3
        btnGuardarTexto.Text = "Guardar texto"
        btnGuardarTexto.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(15, 249)
        TextBox1.Margin = New Padding(6)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "introduce el texto a guardar"
        TextBox1.Size = New Size(393, 120)
        TextBox1.TabIndex = 4
        ' 
        ' TextBoxRuta
        ' 
        TextBoxRuta.Location = New Point(428, 17)
        TextBoxRuta.Name = "TextBoxRuta"
        TextBoxRuta.PlaceholderText = "introduce aqui tu ruta"
        TextBoxRuta.Size = New Size(360, 27)
        TextBoxRuta.TabIndex = 5
        TextBoxRuta.Tag = ""
        ' 
        ' btnAbrirRuta
        ' 
        btnAbrirRuta.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        btnAbrirRuta.BackgroundImage = My.Resources.Resources.boton
        btnAbrirRuta.BackgroundImageLayout = ImageLayout.Stretch
        btnAbrirRuta.FlatAppearance.BorderSize = 0
        btnAbrirRuta.FlatStyle = FlatStyle.Flat
        btnAbrirRuta.Font = New Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbrirRuta.ForeColor = SystemColors.ButtonHighlight
        btnAbrirRuta.Location = New Point(428, 41)
        btnAbrirRuta.Name = "btnAbrirRuta"
        btnAbrirRuta.Size = New Size(360, 78)
        btnAbrirRuta.TabIndex = 6
        btnAbrirRuta.Text = "Abrir Ruta"
        btnAbrirRuta.UseVisualStyleBackColor = False
        ' 
        ' ListArchivos
        ' 
        ListArchivos.FormattingEnabled = True
        ListArchivos.Location = New Point(611, 125)
        ListArchivos.Name = "ListArchivos"
        ListArchivos.Size = New Size(177, 304)
        ListArchivos.TabIndex = 7
        ' 
        ' ListDirectorios
        ' 
        ListDirectorios.FormattingEnabled = True
        ListDirectorios.Location = New Point(428, 125)
        ListDirectorios.Name = "ListDirectorios"
        ListDirectorios.Size = New Size(177, 304)
        ListDirectorios.TabIndex = 8
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btnAbrirTexto
        ' 
        btnAbrirTexto.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        btnAbrirTexto.BackgroundImage = My.Resources.Resources.boton
        btnAbrirTexto.BackgroundImageLayout = ImageLayout.Stretch
        btnAbrirTexto.FlatAppearance.BorderSize = 0
        btnAbrirTexto.FlatStyle = FlatStyle.Flat
        btnAbrirTexto.Font = New Font("Dubai Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbrirTexto.ForeColor = SystemColors.ButtonHighlight
        btnAbrirTexto.Location = New Point(12, 369)
        btnAbrirTexto.Name = "btnAbrirTexto"
        btnAbrirTexto.Size = New Size(186, 60)
        btnAbrirTexto.TabIndex = 9
        btnAbrirTexto.Text = "Abrir Texto"
        btnAbrirTexto.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnAbrirTexto)
        Controls.Add(ListDirectorios)
        Controls.Add(ListArchivos)
        Controls.Add(btnGuardarTexto)
        Controls.Add(btnAbrirImagen)
        Controls.Add(btnAbrirRuta)
        Controls.Add(TextBoxRuta)
        Controls.Add(TextBox1)
        Controls.Add(btnGuardarImagen)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAbrirImagen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGuardarImagen As Button
    Friend WithEvents btnGuardarTexto As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxRuta As TextBox
    Friend WithEvents btnAbrirRuta As Button
    Friend WithEvents ListArchivos As ListBox
    Friend WithEvents ListDirectorios As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnAbrirTexto As Button

End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelMenu = New Panel()
        PanelGaleria = New Panel()
        btnVideo = New Button()
        btnMultimedia = New Button()
        btnArchivo = New Button()
        btnGaleria = New Button()
        PanelArchivo = New Panel()
        btnImportar = New Button()
        btnGuardar = New Button()
        btnBuscar = New Button()
        Label1 = New Label()
        PanelBar = New Panel()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        PanelHijo = New Panel()
        Panel3 = New Panel()
        btnMinimiza = New Button()
        btnMaximiza = New Button()
        btnSalir = New Button()
        PanelMenu.SuspendLayout()
        PanelGaleria.SuspendLayout()
        PanelArchivo.SuspendLayout()
        PanelBar.SuspendLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        PanelHijo.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        PanelMenu.Controls.Add(PanelGaleria)
        PanelMenu.Controls.Add(btnArchivo)
        PanelMenu.Controls.Add(btnGaleria)
        PanelMenu.Controls.Add(PanelArchivo)
        PanelMenu.Controls.Add(Label1)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(162, 469)
        PanelMenu.TabIndex = 0
        ' 
        ' PanelGaleria
        ' 
        PanelGaleria.Controls.Add(btnVideo)
        PanelGaleria.Controls.Add(btnMultimedia)
        PanelGaleria.Location = New Point(1, 304)
        PanelGaleria.Name = "PanelGaleria"
        PanelGaleria.Size = New Size(161, 146)
        PanelGaleria.TabIndex = 3
        ' 
        ' btnVideo
        ' 
        btnVideo.BackgroundImage = CType(resources.GetObject("btnVideo.BackgroundImage"), Image)
        btnVideo.BackgroundImageLayout = ImageLayout.Stretch
        btnVideo.FlatStyle = FlatStyle.Flat
        btnVideo.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnVideo.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnVideo.Location = New Point(19, 47)
        btnVideo.Name = "btnVideo"
        btnVideo.Size = New Size(142, 36)
        btnVideo.TabIndex = 3
        btnVideo.Text = "Videos"
        btnVideo.UseVisualStyleBackColor = True
        ' 
        ' btnMultimedia
        ' 
        btnMultimedia.BackgroundImage = CType(resources.GetObject("btnMultimedia.BackgroundImage"), Image)
        btnMultimedia.BackgroundImageLayout = ImageLayout.Stretch
        btnMultimedia.FlatStyle = FlatStyle.Flat
        btnMultimedia.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnMultimedia.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnMultimedia.Location = New Point(19, 5)
        btnMultimedia.Name = "btnMultimedia"
        btnMultimedia.Size = New Size(142, 36)
        btnMultimedia.TabIndex = 2
        btnMultimedia.Text = "Fotos"
        btnMultimedia.UseVisualStyleBackColor = True
        ' 
        ' btnArchivo
        ' 
        btnArchivo.BackgroundImage = CType(resources.GetObject("btnArchivo.BackgroundImage"), Image)
        btnArchivo.BackgroundImageLayout = ImageLayout.Stretch
        btnArchivo.FlatStyle = FlatStyle.Flat
        btnArchivo.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnArchivo.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnArchivo.Location = New Point(3, 42)
        btnArchivo.Name = "btnArchivo"
        btnArchivo.Size = New Size(151, 46)
        btnArchivo.TabIndex = 0
        btnArchivo.Text = "Archivo"
        btnArchivo.UseVisualStyleBackColor = True
        ' 
        ' btnGaleria
        ' 
        btnGaleria.BackgroundImage = CType(resources.GetObject("btnGaleria.BackgroundImage"), Image)
        btnGaleria.BackgroundImageLayout = ImageLayout.Stretch
        btnGaleria.FlatStyle = FlatStyle.Flat
        btnGaleria.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGaleria.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnGaleria.Location = New Point(3, 257)
        btnGaleria.Name = "btnGaleria"
        btnGaleria.Size = New Size(151, 46)
        btnGaleria.TabIndex = 1
        btnGaleria.Text = "Galeria"
        btnGaleria.UseVisualStyleBackColor = True
        ' 
        ' PanelArchivo
        ' 
        PanelArchivo.Controls.Add(btnImportar)
        PanelArchivo.Controls.Add(btnGuardar)
        PanelArchivo.Controls.Add(btnBuscar)
        PanelArchivo.Location = New Point(1, 88)
        PanelArchivo.Name = "PanelArchivo"
        PanelArchivo.Size = New Size(161, 163)
        PanelArchivo.TabIndex = 2
        ' 
        ' btnImportar
        ' 
        btnImportar.BackgroundImage = CType(resources.GetObject("btnImportar.BackgroundImage"), Image)
        btnImportar.BackgroundImageLayout = ImageLayout.Stretch
        btnImportar.FlatStyle = FlatStyle.Flat
        btnImportar.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnImportar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnImportar.Location = New Point(16, 90)
        btnImportar.Name = "btnImportar"
        btnImportar.Size = New Size(142, 36)
        btnImportar.TabIndex = 3
        btnImportar.Text = "Importar"
        btnImportar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), Image)
        btnGuardar.BackgroundImageLayout = ImageLayout.Stretch
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnGuardar.Location = New Point(19, 48)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(142, 36)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), Image)
        btnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Brush Script MT", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnBuscar.Location = New Point(16, 6)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(142, 36)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Chiller", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(171), CByte(51), CByte(255))
        Label1.Location = New Point(8, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 39)
        Label1.TabIndex = 1
        Label1.Text = "Melodia Pro"
        ' 
        ' PanelBar
        ' 
        PanelBar.BackColor = Color.FromArgb(CByte(171), CByte(51), CByte(255))
        PanelBar.Controls.Add(AxWindowsMediaPlayer1)
        PanelBar.Dock = DockStyle.Bottom
        PanelBar.Location = New Point(162, 381)
        PanelBar.Name = "PanelBar"
        PanelBar.Size = New Size(703, 88)
        PanelBar.TabIndex = 1
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(28, 22)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(644, 54)
        AxWindowsMediaPlayer1.TabIndex = 0
        ' 
        ' PanelHijo
        ' 
        PanelHijo.BackgroundImage = CType(resources.GetObject("PanelHijo.BackgroundImage"), Image)
        PanelHijo.BackgroundImageLayout = ImageLayout.Stretch
        PanelHijo.Controls.Add(Panel3)
        PanelHijo.Dock = DockStyle.Fill
        PanelHijo.Location = New Point(162, 0)
        PanelHijo.Name = "PanelHijo"
        PanelHijo.Size = New Size(703, 469)
        PanelHijo.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(232), CByte(92), CByte(252))
        Panel3.Controls.Add(btnMinimiza)
        Panel3.Controls.Add(btnMaximiza)
        Panel3.Controls.Add(btnSalir)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(703, 35)
        Panel3.TabIndex = 2
        ' 
        ' btnMinimiza
        ' 
        btnMinimiza.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimiza.BackColor = Color.FromArgb(CByte(171), CByte(51), CByte(255))
        btnMinimiza.FlatStyle = FlatStyle.Flat
        btnMinimiza.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimiza.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnMinimiza.Location = New Point(604, 3)
        btnMinimiza.Name = "btnMinimiza"
        btnMinimiza.Size = New Size(25, 29)
        btnMinimiza.TabIndex = 2
        btnMinimiza.Text = "-"
        btnMinimiza.UseVisualStyleBackColor = False
        ' 
        ' btnMaximiza
        ' 
        btnMaximiza.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximiza.BackColor = Color.FromArgb(CByte(171), CByte(51), CByte(255))
        btnMaximiza.FlatStyle = FlatStyle.Flat
        btnMaximiza.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMaximiza.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnMaximiza.Location = New Point(635, 3)
        btnMaximiza.Name = "btnMaximiza"
        btnMaximiza.Size = New Size(25, 29)
        btnMaximiza.TabIndex = 1
        btnMaximiza.Text = "▢"
        btnMaximiza.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(171), CByte(51), CByte(255))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnSalir.Location = New Point(666, 3)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(25, 29)
        btnSalir.TabIndex = 0
        btnSalir.Text = "X"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 469)
        Controls.Add(PanelBar)
        Controls.Add(PanelHijo)
        Controls.Add(PanelMenu)
        Name = "Form1"
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        PanelGaleria.ResumeLayout(False)
        PanelArchivo.ResumeLayout(False)
        PanelBar.ResumeLayout(False)
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        PanelHijo.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBar As Panel
    Friend WithEvents PanelHijo As Panel
    Friend WithEvents btnArchivo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelArchivo As Panel
    Friend WithEvents PanelGaleria As Panel
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVideo As Button
    Friend WithEvents btnMultimedia As Button
    Friend WithEvents btnGaleria As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMinimiza As Button
    Friend WithEvents btnMaximiza As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer

End Class

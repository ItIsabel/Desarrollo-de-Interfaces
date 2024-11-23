<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPpal))
        PanelInicio = New Panel()
        btnMinimize = New Button()
        btnMaximize = New Button()
        btnExit = New Button()
        Label1 = New Label()
        PanelSubmenu = New Panel()
        btnConfirmacion = New FontAwesome.Sharp.IconButton()
        btnEnvio = New FontAwesome.Sharp.IconButton()
        btnSeleccion = New FontAwesome.Sharp.IconButton()
        btnCustomizacion = New FontAwesome.Sharp.IconButton()
        PanelHijo = New Panel()
        PanelInicio.SuspendLayout()
        PanelSubmenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelInicio
        ' 
        PanelInicio.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        PanelInicio.Controls.Add(btnMinimize)
        PanelInicio.Controls.Add(btnMaximize)
        PanelInicio.Controls.Add(btnExit)
        PanelInicio.Controls.Add(Label1)
        PanelInicio.Dock = DockStyle.Top
        PanelInicio.Location = New Point(0, 0)
        PanelInicio.Name = "PanelInicio"
        PanelInicio.Size = New Size(917, 44)
        PanelInicio.TabIndex = 0
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.FromArgb(CByte(44), CByte(159), CByte(163))
        btnMinimize.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = SystemColors.ButtonFace
        btnMinimize.Location = New Point(779, 5)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(38, 29)
        btnMinimize.TabIndex = 3
        btnMinimize.Text = "-"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.BackColor = Color.FromArgb(CByte(44), CByte(159), CByte(163))
        btnMaximize.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMaximize.ForeColor = SystemColors.ButtonFace
        btnMaximize.Location = New Point(823, 5)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(38, 29)
        btnMaximize.TabIndex = 2
        btnMaximize.Text = "▢"
        btnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.BackColor = Color.FromArgb(CByte(44), CByte(159), CByte(163))
        btnExit.ForeColor = SystemColors.ButtonFace
        btnExit.Location = New Point(867, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(38, 29)
        btnExit.TabIndex = 1
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(159), CByte(163))
        Label1.Location = New Point(305, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 37)
        Label1.TabIndex = 0
        Label1.Text = "COOK N EAT"
        ' 
        ' PanelSubmenu
        ' 
        PanelSubmenu.BackColor = Color.FromArgb(CByte(255), CByte(136), CByte(38))
        PanelSubmenu.Controls.Add(btnConfirmacion)
        PanelSubmenu.Controls.Add(btnEnvio)
        PanelSubmenu.Controls.Add(btnSeleccion)
        PanelSubmenu.Controls.Add(btnCustomizacion)
        PanelSubmenu.Dock = DockStyle.Top
        PanelSubmenu.Location = New Point(0, 44)
        PanelSubmenu.Name = "PanelSubmenu"
        PanelSubmenu.Size = New Size(917, 40)
        PanelSubmenu.TabIndex = 1
        ' 
        ' btnConfirmacion
        ' 
        btnConfirmacion.BackColor = Color.FromArgb(CByte(255), CByte(136), CByte(38))
        btnConfirmacion.FlatStyle = FlatStyle.Flat
        btnConfirmacion.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmacion.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnConfirmacion.IconChar = FontAwesome.Sharp.IconChar.FileContract
        btnConfirmacion.IconColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnConfirmacion.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnConfirmacion.IconSize = 30
        btnConfirmacion.ImageAlign = ContentAlignment.MiddleLeft
        btnConfirmacion.Location = New Point(602, 0)
        btnConfirmacion.Margin = New Padding(0)
        btnConfirmacion.Name = "btnConfirmacion"
        btnConfirmacion.Size = New Size(215, 40)
        btnConfirmacion.TabIndex = 3
        btnConfirmacion.Text = "Confirmacion"
        btnConfirmacion.UseVisualStyleBackColor = False
        ' 
        ' btnEnvio
        ' 
        btnEnvio.BackColor = Color.FromArgb(CByte(255), CByte(136), CByte(38))
        btnEnvio.FlatStyle = FlatStyle.Flat
        btnEnvio.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnvio.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnEnvio.IconChar = FontAwesome.Sharp.IconChar.Truck
        btnEnvio.IconColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnEnvio.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEnvio.IconSize = 30
        btnEnvio.ImageAlign = ContentAlignment.MiddleLeft
        btnEnvio.Location = New Point(401, 0)
        btnEnvio.Margin = New Padding(0)
        btnEnvio.Name = "btnEnvio"
        btnEnvio.Size = New Size(201, 40)
        btnEnvio.TabIndex = 2
        btnEnvio.Text = "Envio"
        btnEnvio.UseVisualStyleBackColor = False
        ' 
        ' btnSeleccion
        ' 
        btnSeleccion.BackColor = Color.FromArgb(CByte(255), CByte(136), CByte(38))
        btnSeleccion.FlatStyle = FlatStyle.Flat
        btnSeleccion.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSeleccion.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnSeleccion.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        btnSeleccion.IconColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnSeleccion.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSeleccion.IconSize = 30
        btnSeleccion.ImageAlign = ContentAlignment.MiddleLeft
        btnSeleccion.Location = New Point(3, 0)
        btnSeleccion.Margin = New Padding(0)
        btnSeleccion.Name = "btnSeleccion"
        btnSeleccion.Size = New Size(192, 40)
        btnSeleccion.TabIndex = 0
        btnSeleccion.Text = "Seleccion"
        btnSeleccion.UseVisualStyleBackColor = False
        ' 
        ' btnCustomizacion
        ' 
        btnCustomizacion.BackColor = Color.FromArgb(CByte(255), CByte(136), CByte(38))
        btnCustomizacion.FlatStyle = FlatStyle.Flat
        btnCustomizacion.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustomizacion.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnCustomizacion.IconChar = FontAwesome.Sharp.IconChar.Play
        btnCustomizacion.IconColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnCustomizacion.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCustomizacion.IconSize = 30
        btnCustomizacion.ImageAlign = ContentAlignment.MiddleLeft
        btnCustomizacion.Location = New Point(195, 0)
        btnCustomizacion.Margin = New Padding(0)
        btnCustomizacion.Name = "btnCustomizacion"
        btnCustomizacion.Size = New Size(206, 40)
        btnCustomizacion.TabIndex = 1
        btnCustomizacion.Text = "Customizacion"
        btnCustomizacion.UseVisualStyleBackColor = False
        ' 
        ' PanelHijo
        ' 
        PanelHijo.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        PanelHijo.BackgroundImage = CType(resources.GetObject("PanelHijo.BackgroundImage"), Image)
        PanelHijo.BackgroundImageLayout = ImageLayout.Center
        PanelHijo.Dock = DockStyle.Fill
        PanelHijo.Location = New Point(0, 84)
        PanelHijo.Name = "PanelHijo"
        PanelHijo.Size = New Size(917, 425)
        PanelHijo.TabIndex = 2
        ' 
        ' FormPpal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 509)
        Controls.Add(PanelHijo)
        Controls.Add(PanelSubmenu)
        Controls.Add(PanelInicio)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPpal"
        Text = " "
        PanelInicio.ResumeLayout(False)
        PanelInicio.PerformLayout()
        PanelSubmenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelInicio As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PanelSubmenu As Panel
    Friend WithEvents btnSeleccion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEnvio As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomizacion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConfirmacion As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelHijo As Panel

End Class

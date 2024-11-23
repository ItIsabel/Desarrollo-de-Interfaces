<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.pbColor = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCursiva = New System.Windows.Forms.Label()
        Me.lblNegrita = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFuentes = New System.Windows.Forms.ComboBox()
        Me.MenuStripMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripMenu.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.AutoSize = True
        Me.PanelTitulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(801, 39)
        Me.PanelTitulo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(64, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(134, 20)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Block de notas"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.Location = New System.Drawing.Point(674, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 33)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.Text = "-"
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(755, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 33)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Location = New System.Drawing.Point(715, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(34, 33)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoSize = True
        Me.PanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.pbColor)
        Me.PanelMenu.Controls.Add(Me.Label4)
        Me.PanelMenu.Controls.Add(Me.txtSize)
        Me.PanelMenu.Controls.Add(Me.lblSize)
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.lblCursiva)
        Me.PanelMenu.Controls.Add(Me.lblNegrita)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.cbFuentes)
        Me.PanelMenu.Controls.Add(Me.MenuStripMenu)
        Me.PanelMenu.Location = New System.Drawing.Point(-1, 38)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(549, 35)
        Me.PanelMenu.TabIndex = 1
        '
        'pbColor
        '
        Me.pbColor.Location = New System.Drawing.Point(518, 6)
        Me.pbColor.Name = "pbColor"
        Me.pbColor.Size = New System.Drawing.Size(28, 24)
        Me.pbColor.TabIndex = 9
        Me.pbColor.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(501, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(1)
        Me.Label4.Size = New System.Drawing.Size(2, 18)
        Me.Label4.TabIndex = 8
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(467, 6)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(28, 22)
        Me.txtSize.TabIndex = 7
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(400, 13)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(61, 16)
        Me.lblSize.TabIndex = 6
        Me.lblSize.Text = "Tamaño:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(391, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(1)
        Me.Label3.Size = New System.Drawing.Size(2, 18)
        Me.Label3.TabIndex = 5
        '
        'lblCursiva
        '
        Me.lblCursiva.AutoSize = True
        Me.lblCursiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursiva.Location = New System.Drawing.Point(369, 11)
        Me.lblCursiva.Name = "lblCursiva"
        Me.lblCursiva.Size = New System.Drawing.Size(15, 16)
        Me.lblCursiva.TabIndex = 4
        Me.lblCursiva.Text = "K"
        '
        'lblNegrita
        '
        Me.lblNegrita.AllowDrop = True
        Me.lblNegrita.AutoSize = True
        Me.lblNegrita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNegrita.Location = New System.Drawing.Point(335, 10)
        Me.lblNegrita.Name = "lblNegrita"
        Me.lblNegrita.Size = New System.Drawing.Size(18, 16)
        Me.lblNegrita.TabIndex = 3
        Me.lblNegrita.Text = "N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(327, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(1)
        Me.Label2.Size = New System.Drawing.Size(2, 18)
        Me.Label2.TabIndex = 2
        '
        'cbFuentes
        '
        Me.cbFuentes.FormattingEnabled = True
        Me.cbFuentes.Location = New System.Drawing.Point(188, 8)
        Me.cbFuentes.Name = "cbFuentes"
        Me.cbFuentes.Size = New System.Drawing.Size(121, 24)
        Me.cbFuentes.TabIndex = 1
        '
        'MenuStripMenu
        '
        Me.MenuStripMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripArchivo, Me.ToolStripMenuItem1})
        Me.MenuStripMenu.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMenu.Name = "MenuStripMenu"
        Me.MenuStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStripMenu.Size = New System.Drawing.Size(549, 30)
        Me.MenuStripMenu.TabIndex = 0
        Me.MenuStripMenu.Text = "MenuStrip1"
        '
        'ToolStripArchivo
        '
        Me.ToolStripArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripArchivo.Name = "ToolStripArchivo"
        Me.ToolStripArchivo.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripArchivo.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripMenuItem1.Text = "Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'PanelBottom
        '
        Me.PanelBottom.AutoSize = True
        Me.PanelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelBottom.Controls.Add(Me.TrackBar1)
        Me.PanelBottom.Controls.Add(Me.lblPorcentaje)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 391)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(801, 80)
        Me.PanelBottom.TabIndex = 3
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(620, 12)
        Me.TrackBar1.Maximum = 9
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(169, 56)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 1
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblPorcentaje.Location = New System.Drawing.Point(574, 27)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(40, 16)
        Me.lblPorcentaje.TabIndex = 0
        Me.lblPorcentaje.Text = "100%"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 82)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(776, 270)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 471)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStripMenu
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripMenu.ResumeLayout(False)
        Me.MenuStripMenu.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStripMenu As MenuStrip
    Friend WithEvents ToolStripArchivo As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNegrita As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFuentes As ComboBox
    Friend WithEvents lblCursiva As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbColor As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents TrackBar1 As TrackBar
End Class

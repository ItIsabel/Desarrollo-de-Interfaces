<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.btnFAQ = New FontAwesome.Sharp.IconButton()
        Me.btnContacto = New FontAwesome.Sharp.IconButton()
        Me.btnDesarrollo = New FontAwesome.Sharp.IconButton()
        Me.btnEducacion = New FontAwesome.Sharp.IconButton()
        Me.iconbtn_Productos = New FontAwesome.Sharp.IconButton()
        Me.Iconbtn_Lactancia = New FontAwesome.Sharp.IconButton()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1132, 47)
        Me.PanelTitleBar.TabIndex = 1
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 44
        Me.IconCurrentForm.Location = New System.Drawing.Point(71, 3)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(60, 44)
        Me.IconCurrentForm.TabIndex = 4
        Me.IconCurrentForm.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(137, 7)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(66, 34)
        Me.lblFormTitle.TabIndex = 3
        Me.lblFormTitle.Text = "Home"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(1088, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnMaximize.Location = New System.Drawing.Point(1050, 9)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(32, 30)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.Text = "🔲" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(1012, 9)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 30)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackgroundImage = CType(resources.GetObject("PanelDesktop.BackgroundImage"), System.Drawing.Image)
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(200, 3, 3, 3)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1132, 589)
        Me.PanelDesktop.TabIndex = 1
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelMenu.Controls.Add(Me.imgHome)
        Me.PanelMenu.Controls.Add(Me.btnFAQ)
        Me.PanelMenu.Controls.Add(Me.btnContacto)
        Me.PanelMenu.Controls.Add(Me.btnDesarrollo)
        Me.PanelMenu.Controls.Add(Me.btnEducacion)
        Me.PanelMenu.Controls.Add(Me.iconbtn_Productos)
        Me.PanelMenu.Controls.Add(Me.Iconbtn_Lactancia)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(199, 589)
        Me.PanelMenu.TabIndex = 3
        '
        'imgHome
        '
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(3, 3)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(193, 142)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgHome.TabIndex = 3
        Me.imgHome.TabStop = False
        '
        'btnFAQ
        '
        Me.btnFAQ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFAQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFAQ.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFAQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnFAQ.IconChar = FontAwesome.Sharp.IconChar.Question
        Me.btnFAQ.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnFAQ.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFAQ.IconSize = 45
        Me.btnFAQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFAQ.Location = New System.Drawing.Point(3, 521)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnFAQ.Size = New System.Drawing.Size(196, 68)
        Me.btnFAQ.TabIndex = 6
        Me.btnFAQ.Text = "FAQ"
        Me.btnFAQ.UseVisualStyleBackColor = False
        '
        'btnContacto
        '
        Me.btnContacto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnContacto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContacto.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnContacto.IconChar = FontAwesome.Sharp.IconChar.Phone
        Me.btnContacto.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnContacto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnContacto.IconSize = 40
        Me.btnContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContacto.Location = New System.Drawing.Point(3, 444)
        Me.btnContacto.Name = "btnContacto"
        Me.btnContacto.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnContacto.Size = New System.Drawing.Size(196, 68)
        Me.btnContacto.TabIndex = 5
        Me.btnContacto.Text = "Contacto"
        Me.btnContacto.UseVisualStyleBackColor = False
        '
        'btnDesarrollo
        '
        Me.btnDesarrollo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesarrollo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnDesarrollo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDesarrollo.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesarrollo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDesarrollo.IconChar = FontAwesome.Sharp.IconChar.Person
        Me.btnDesarrollo.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDesarrollo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDesarrollo.IconSize = 40
        Me.btnDesarrollo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesarrollo.Location = New System.Drawing.Point(3, 370)
        Me.btnDesarrollo.Name = "btnDesarrollo"
        Me.btnDesarrollo.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDesarrollo.Size = New System.Drawing.Size(196, 68)
        Me.btnDesarrollo.TabIndex = 4
        Me.btnDesarrollo.Text = "Desarrollo"
        Me.btnDesarrollo.UseVisualStyleBackColor = False
        '
        'btnEducacion
        '
        Me.btnEducacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEducacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnEducacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEducacion.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEducacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEducacion.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnEducacion.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEducacion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEducacion.IconSize = 38
        Me.btnEducacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEducacion.Location = New System.Drawing.Point(3, 296)
        Me.btnEducacion.Name = "btnEducacion"
        Me.btnEducacion.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnEducacion.Size = New System.Drawing.Size(196, 68)
        Me.btnEducacion.TabIndex = 2
        Me.btnEducacion.Text = "Educacion"
        Me.btnEducacion.UseVisualStyleBackColor = False
        '
        'iconbtn_Productos
        '
        Me.iconbtn_Productos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconbtn_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.iconbtn_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconbtn_Productos.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconbtn_Productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.iconbtn_Productos.IconChar = FontAwesome.Sharp.IconChar.BabyCarriage
        Me.iconbtn_Productos.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.iconbtn_Productos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconbtn_Productos.IconSize = 40
        Me.iconbtn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconbtn_Productos.Location = New System.Drawing.Point(3, 222)
        Me.iconbtn_Productos.Name = "iconbtn_Productos"
        Me.iconbtn_Productos.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.iconbtn_Productos.Size = New System.Drawing.Size(196, 68)
        Me.iconbtn_Productos.TabIndex = 1
        Me.iconbtn_Productos.Text = "Productos"
        Me.iconbtn_Productos.UseVisualStyleBackColor = False
        '
        'Iconbtn_Lactancia
        '
        Me.Iconbtn_Lactancia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Iconbtn_Lactancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Iconbtn_Lactancia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Iconbtn_Lactancia.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iconbtn_Lactancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Iconbtn_Lactancia.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding
        Me.Iconbtn_Lactancia.IconColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Iconbtn_Lactancia.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconbtn_Lactancia.IconSize = 45
        Me.Iconbtn_Lactancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Iconbtn_Lactancia.Location = New System.Drawing.Point(3, 148)
        Me.Iconbtn_Lactancia.Name = "Iconbtn_Lactancia"
        Me.Iconbtn_Lactancia.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Iconbtn_Lactancia.Size = New System.Drawing.Size(196, 68)
        Me.Iconbtn_Lactancia.TabIndex = 0
        Me.Iconbtn_Lactancia.Text = "Lactancia"
        Me.Iconbtn_Lactancia.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1132, 589)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Iconbtn_Lactancia As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEducacion As FontAwesome.Sharp.IconButton
    Friend WithEvents iconbtn_Productos As FontAwesome.Sharp.IconButton
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnContacto As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDesarrollo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFAQ As FontAwesome.Sharp.IconButton
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
End Class

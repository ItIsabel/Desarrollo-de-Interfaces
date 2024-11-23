<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHijoSeleccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHijoSeleccion))
        pctHamburg = New PictureBox()
        lblEnvio = New Label()
        pctPatatas = New PictureBox()
        pctNugets = New PictureBox()
        btnMasHamburg = New Button()
        btnMasPatata = New Button()
        btnMasNuget = New Button()
        btnMenosHamburg = New Button()
        btnMenosPatata = New Button()
        btnMenosNuget = New Button()
        Panel1 = New Panel()
        lblNuget = New Label()
        lblPatata = New Label()
        lblHamburguesa = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(pctHamburg, ComponentModel.ISupportInitialize).BeginInit()
        CType(pctPatatas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pctNugets, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pctHamburg
        ' 
        pctHamburg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pctHamburg.Image = CType(resources.GetObject("pctHamburg.Image"), Image)
        pctHamburg.Location = New Point(12, 17)
        pctHamburg.Name = "pctHamburg"
        pctHamburg.Size = New Size(219, 113)
        pctHamburg.SizeMode = PictureBoxSizeMode.StretchImage
        pctHamburg.TabIndex = 0
        pctHamburg.TabStop = False
        ' 
        ' lblEnvio
        ' 
        lblEnvio.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblEnvio.AutoSize = True
        lblEnvio.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEnvio.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        lblEnvio.Location = New Point(294, 80)
        lblEnvio.Name = "lblEnvio"
        lblEnvio.Size = New Size(294, 29)
        lblEnvio.TabIndex = 9
        lblEnvio.Text = "Dinos qué te apetece:"
        lblEnvio.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pctPatatas
        ' 
        pctPatatas.Anchor = AnchorStyles.Bottom
        pctPatatas.BackgroundImageLayout = ImageLayout.Zoom
        pctPatatas.Image = CType(resources.GetObject("pctPatatas.Image"), Image)
        pctPatatas.Location = New Point(325, 16)
        pctPatatas.Margin = New Padding(6)
        pctPatatas.Name = "pctPatatas"
        pctPatatas.Size = New Size(217, 114)
        pctPatatas.SizeMode = PictureBoxSizeMode.StretchImage
        pctPatatas.TabIndex = 10
        pctPatatas.TabStop = False
        ' 
        ' pctNugets
        ' 
        pctNugets.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        pctNugets.Image = CType(resources.GetObject("pctNugets.Image"), Image)
        pctNugets.Location = New Point(634, 16)
        pctNugets.Name = "pctNugets"
        pctNugets.Size = New Size(211, 114)
        pctNugets.SizeMode = PictureBoxSizeMode.StretchImage
        pctNugets.TabIndex = 11
        pctNugets.TabStop = False
        ' 
        ' btnMasHamburg
        ' 
        btnMasHamburg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnMasHamburg.BackgroundImage = CType(resources.GetObject("btnMasHamburg.BackgroundImage"), Image)
        btnMasHamburg.BackgroundImageLayout = ImageLayout.Stretch
        btnMasHamburg.FlatStyle = FlatStyle.Flat
        btnMasHamburg.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMasHamburg.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMasHamburg.Location = New Point(185, 130)
        btnMasHamburg.Name = "btnMasHamburg"
        btnMasHamburg.Size = New Size(46, 44)
        btnMasHamburg.TabIndex = 14
        btnMasHamburg.Text = "+"
        btnMasHamburg.UseVisualStyleBackColor = True
        ' 
        ' btnMasPatata
        ' 
        btnMasPatata.Anchor = AnchorStyles.Bottom
        btnMasPatata.BackgroundImage = CType(resources.GetObject("btnMasPatata.BackgroundImage"), Image)
        btnMasPatata.BackgroundImageLayout = ImageLayout.Stretch
        btnMasPatata.FlatStyle = FlatStyle.Flat
        btnMasPatata.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMasPatata.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMasPatata.Location = New Point(494, 130)
        btnMasPatata.Name = "btnMasPatata"
        btnMasPatata.Size = New Size(48, 44)
        btnMasPatata.TabIndex = 15
        btnMasPatata.Text = "+"
        btnMasPatata.UseVisualStyleBackColor = True
        ' 
        ' btnMasNuget
        ' 
        btnMasNuget.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnMasNuget.BackgroundImage = CType(resources.GetObject("btnMasNuget.BackgroundImage"), Image)
        btnMasNuget.BackgroundImageLayout = ImageLayout.Stretch
        btnMasNuget.FlatStyle = FlatStyle.Flat
        btnMasNuget.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMasNuget.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMasNuget.Location = New Point(797, 130)
        btnMasNuget.Name = "btnMasNuget"
        btnMasNuget.Size = New Size(48, 41)
        btnMasNuget.TabIndex = 16
        btnMasNuget.Text = "+"
        btnMasNuget.UseVisualStyleBackColor = True
        ' 
        ' btnMenosHamburg
        ' 
        btnMenosHamburg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnMenosHamburg.BackgroundImage = CType(resources.GetObject("btnMenosHamburg.BackgroundImage"), Image)
        btnMenosHamburg.BackgroundImageLayout = ImageLayout.Stretch
        btnMenosHamburg.FlatStyle = FlatStyle.Flat
        btnMenosHamburg.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenosHamburg.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMenosHamburg.Location = New Point(131, 130)
        btnMenosHamburg.Name = "btnMenosHamburg"
        btnMenosHamburg.Size = New Size(48, 44)
        btnMenosHamburg.TabIndex = 17
        btnMenosHamburg.Text = "-"
        btnMenosHamburg.TextAlign = ContentAlignment.TopCenter
        btnMenosHamburg.UseVisualStyleBackColor = True
        ' 
        ' btnMenosPatata
        ' 
        btnMenosPatata.Anchor = AnchorStyles.Bottom
        btnMenosPatata.AutoSize = True
        btnMenosPatata.BackgroundImage = CType(resources.GetObject("btnMenosPatata.BackgroundImage"), Image)
        btnMenosPatata.BackgroundImageLayout = ImageLayout.Stretch
        btnMenosPatata.FlatStyle = FlatStyle.Flat
        btnMenosPatata.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenosPatata.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMenosPatata.Location = New Point(441, 130)
        btnMenosPatata.Name = "btnMenosPatata"
        btnMenosPatata.Padding = New Padding(3)
        btnMenosPatata.Size = New Size(47, 44)
        btnMenosPatata.TabIndex = 18
        btnMenosPatata.Text = "-"
        btnMenosPatata.TextAlign = ContentAlignment.TopCenter
        btnMenosPatata.UseVisualStyleBackColor = True
        ' 
        ' btnMenosNuget
        ' 
        btnMenosNuget.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnMenosNuget.BackgroundImage = CType(resources.GetObject("btnMenosNuget.BackgroundImage"), Image)
        btnMenosNuget.BackgroundImageLayout = ImageLayout.Stretch
        btnMenosNuget.FlatStyle = FlatStyle.Flat
        btnMenosNuget.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenosNuget.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnMenosNuget.Location = New Point(748, 130)
        btnMenosNuget.Name = "btnMenosNuget"
        btnMenosNuget.Size = New Size(43, 41)
        btnMenosNuget.TabIndex = 19
        btnMenosNuget.Text = "-"
        btnMenosNuget.TextAlign = ContentAlignment.TopCenter
        btnMenosNuget.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblNuget)
        Panel1.Controls.Add(lblPatata)
        Panel1.Controls.Add(lblHamburguesa)
        Panel1.Controls.Add(btnMenosNuget)
        Panel1.Controls.Add(btnMenosHamburg)
        Panel1.Controls.Add(btnMasHamburg)
        Panel1.Controls.Add(btnMenosPatata)
        Panel1.Controls.Add(btnMasPatata)
        Panel1.Controls.Add(btnMasNuget)
        Panel1.Controls.Add(pctNugets)
        Panel1.Controls.Add(pctPatatas)
        Panel1.Controls.Add(pctHamburg)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(857, 177)
        Panel1.TabIndex = 22
        ' 
        ' lblNuget
        ' 
        lblNuget.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblNuget.AutoSize = True
        lblNuget.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        lblNuget.Location = New Point(634, 141)
        lblNuget.Name = "lblNuget"
        lblNuget.Size = New Size(72, 21)
        lblNuget.TabIndex = 22
        lblNuget.Text = "Label3"
        ' 
        ' lblPatata
        ' 
        lblPatata.Anchor = AnchorStyles.Bottom
        lblPatata.AutoSize = True
        lblPatata.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        lblPatata.Location = New Point(325, 145)
        lblPatata.Name = "lblPatata"
        lblPatata.Size = New Size(72, 21)
        lblPatata.TabIndex = 21
        lblPatata.Text = "Label2"
        ' 
        ' lblHamburguesa
        ' 
        lblHamburguesa.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHamburguesa.AutoSize = True
        lblHamburguesa.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        lblHamburguesa.Location = New Point(12, 143)
        lblHamburguesa.Name = "lblHamburguesa"
        lblHamburguesa.Size = New Size(71, 21)
        lblHamburguesa.TabIndex = 20
        lblHamburguesa.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblEnvio)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 112)
        Panel2.TabIndex = 23
        ' 
        ' Panel3
        ' 
        Panel3.AutoSize = True
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 289)
        Panel3.MinimumSize = New Size(782, 74)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(857, 74)
        Panel3.TabIndex = 24
        ' 
        ' FormHijoSeleccion
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ClientSize = New Size(857, 363)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Name = "FormHijoSeleccion"
        Text = "Form1"
        CType(pctHamburg, ComponentModel.ISupportInitialize).EndInit()
        CType(pctPatatas, ComponentModel.ISupportInitialize).EndInit()
        CType(pctNugets, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pctHamburg As PictureBox
    Friend WithEvents lblEnvio As Label
    Friend WithEvents pctPatatas As PictureBox
    Friend WithEvents pctNugets As PictureBox
    Friend WithEvents btnMasHamburg As Button
    Friend WithEvents btnMasPatata As Button
    Friend WithEvents btnMasNuget As Button
    Friend WithEvents btnMenosHamburg As Button
    Friend WithEvents btnMenosPatata As Button
    Friend WithEvents btnMenosNuget As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNuget As Label
    Friend WithEvents lblPatata As Label
    Friend WithEvents lblHamburguesa As Label
End Class

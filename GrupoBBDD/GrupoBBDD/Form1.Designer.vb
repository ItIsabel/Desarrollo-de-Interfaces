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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panelbtm = New System.Windows.Forms.Panel()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.Panelppal = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtInteresesR = New System.Windows.Forms.TextBox()
        Me.txtTelefonoR = New System.Windows.Forms.TextBox()
        Me.txtApellidosR = New System.Windows.Forms.TextBox()
        Me.txtNombreR = New System.Windows.Forms.TextBox()
        Me.lblIntereses = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAlias = New System.Windows.Forms.Label()
        Me.txtAliasR = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnBuscarA = New System.Windows.Forms.Button()
        Me.txtInteresesA = New System.Windows.Forms.TextBox()
        Me.txtTelefonoA = New System.Windows.Forms.TextBox()
        Me.txtApellidosA = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAliasA = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBuscarE = New System.Windows.Forms.Button()
        Me.txtInteresesE = New System.Windows.Forms.TextBox()
        Me.txtTelefonoE = New System.Windows.Forms.TextBox()
        Me.txtApellidosE = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAliasE = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet1 = New GrupoBBDD.ClientesDataSet1()
        Me.GrupoTableAdapter = New GrupoBBDD.ClientesDataSet1TableAdapters.GrupoTableAdapter()
        Me.PanelTop.SuspendLayout()
        Me.Panelbtm.SuspendLayout()
        Me.Panelppal.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnMinimize)
        Me.PanelTop.Controls.Add(Me.btnMaximize)
        Me.PanelTop.Controls.Add(Me.btnExit)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 48)
        Me.PanelTop.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(683, 10)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(31, 32)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaximize.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMaximize.Location = New System.Drawing.Point(720, 10)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(31, 32)
        Me.btnMaximize.TabIndex = 2
        Me.btnMaximize.Text = "🔲"
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(758, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 32)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(236, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro en el grupo"
        '
        'Panelbtm
        '
        Me.Panelbtm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panelbtm.Controls.Add(Me.btnAccion)
        Me.Panelbtm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtm.Location = New System.Drawing.Point(0, 393)
        Me.Panelbtm.Name = "Panelbtm"
        Me.Panelbtm.Size = New System.Drawing.Size(800, 57)
        Me.Panelbtm.TabIndex = 1
        '
        'btnAccion
        '
        Me.btnAccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccion.Location = New System.Drawing.Point(150, 6)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(447, 39)
        Me.btnAccion.TabIndex = 31
        Me.btnAccion.UseVisualStyleBackColor = False
        '
        'Panelppal
        '
        Me.Panelppal.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panelppal.Controls.Add(Me.TabControl1)
        Me.Panelppal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelppal.Location = New System.Drawing.Point(0, 48)
        Me.Panelppal.Name = "Panelppal"
        Me.Panelppal.Size = New System.Drawing.Size(800, 345)
        Me.Panelppal.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabControl1.ItemSize = New System.Drawing.Size(55, 35)
        Me.TabControl1.Location = New System.Drawing.Point(20, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(20)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(30, 5)
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 305)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.txtInteresesR)
        Me.TabPage3.Controls.Add(Me.txtTelefonoR)
        Me.TabPage3.Controls.Add(Me.txtApellidosR)
        Me.TabPage3.Controls.Add(Me.txtNombreR)
        Me.TabPage3.Controls.Add(Me.lblIntereses)
        Me.TabPage3.Controls.Add(Me.lblApellidos)
        Me.TabPage3.Controls.Add(Me.lblTelefono)
        Me.TabPage3.Controls.Add(Me.lblNombre)
        Me.TabPage3.Controls.Add(Me.lblAlias)
        Me.TabPage3.Controls.Add(Me.txtAliasR)
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(10)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(19)
        Me.TabPage3.Size = New System.Drawing.Size(752, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registrar"
        Me.TabPage3.ToolTipText = "Introduce los datos de una persona"
        '
        'txtInteresesR
        '
        Me.txtInteresesR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInteresesR.Location = New System.Drawing.Point(217, 210)
        Me.txtInteresesR.Multiline = True
        Me.txtInteresesR.Name = "txtInteresesR"
        Me.txtInteresesR.Size = New System.Drawing.Size(346, 39)
        Me.txtInteresesR.TabIndex = 9
        '
        'txtTelefonoR
        '
        Me.txtTelefonoR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefonoR.Location = New System.Drawing.Point(217, 165)
        Me.txtTelefonoR.Name = "txtTelefonoR"
        Me.txtTelefonoR.Size = New System.Drawing.Size(346, 30)
        Me.txtTelefonoR.TabIndex = 8
        '
        'txtApellidosR
        '
        Me.txtApellidosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidosR.Location = New System.Drawing.Point(217, 115)
        Me.txtApellidosR.Name = "txtApellidosR"
        Me.txtApellidosR.Size = New System.Drawing.Size(346, 30)
        Me.txtApellidosR.TabIndex = 7
        '
        'txtNombreR
        '
        Me.txtNombreR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreR.Location = New System.Drawing.Point(217, 64)
        Me.txtNombreR.Name = "txtNombreR"
        Me.txtNombreR.Size = New System.Drawing.Size(346, 30)
        Me.txtNombreR.TabIndex = 6
        '
        'lblIntereses
        '
        Me.lblIntereses.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIntereses.AutoSize = True
        Me.lblIntereses.Location = New System.Drawing.Point(118, 216)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Size = New System.Drawing.Size(80, 22)
        Me.lblIntereses.TabIndex = 5
        Me.lblIntereses.Text = "Intereses"
        '
        'lblApellidos
        '
        Me.lblApellidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(116, 118)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(89, 22)
        Me.lblApellidos.TabIndex = 4
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(119, 168)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 22)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(124, 70)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(74, 22)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblAlias
        '
        Me.lblAlias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Location = New System.Drawing.Point(143, 21)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(53, 22)
        Me.lblAlias.TabIndex = 1
        Me.lblAlias.Text = "Alias"
        '
        'txtAliasR
        '
        Me.txtAliasR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAliasR.Location = New System.Drawing.Point(217, 18)
        Me.txtAliasR.Name = "txtAliasR"
        Me.txtAliasR.Size = New System.Drawing.Size(346, 30)
        Me.txtAliasR.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnBuscarA)
        Me.TabPage4.Controls.Add(Me.txtInteresesA)
        Me.TabPage4.Controls.Add(Me.txtTelefonoA)
        Me.TabPage4.Controls.Add(Me.txtApellidosA)
        Me.TabPage4.Controls.Add(Me.txtNombreA)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.txtAliasA)
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage4.Size = New System.Drawing.Size(752, 262)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Actualizar"
        Me.TabPage4.ToolTipText = "Modifica los datos de una persona"
        '
        'btnBuscarA
        '
        Me.btnBuscarA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarA.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarA.Location = New System.Drawing.Point(433, 18)
        Me.btnBuscarA.Name = "btnBuscarA"
        Me.btnBuscarA.Size = New System.Drawing.Size(131, 29)
        Me.btnBuscarA.TabIndex = 31
        Me.btnBuscarA.Text = "Buscar"
        Me.btnBuscarA.UseVisualStyleBackColor = False
        '
        'txtInteresesA
        '
        Me.txtInteresesA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInteresesA.Location = New System.Drawing.Point(218, 210)
        Me.txtInteresesA.Multiline = True
        Me.txtInteresesA.Name = "txtInteresesA"
        Me.txtInteresesA.Size = New System.Drawing.Size(346, 39)
        Me.txtInteresesA.TabIndex = 19
        '
        'txtTelefonoA
        '
        Me.txtTelefonoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefonoA.Location = New System.Drawing.Point(218, 165)
        Me.txtTelefonoA.Name = "txtTelefonoA"
        Me.txtTelefonoA.Size = New System.Drawing.Size(346, 30)
        Me.txtTelefonoA.TabIndex = 18
        '
        'txtApellidosA
        '
        Me.txtApellidosA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidosA.Location = New System.Drawing.Point(218, 115)
        Me.txtApellidosA.Name = "txtApellidosA"
        Me.txtApellidosA.Size = New System.Drawing.Size(346, 30)
        Me.txtApellidosA.TabIndex = 17
        '
        'txtNombreA
        '
        Me.txtNombreA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreA.Location = New System.Drawing.Point(218, 64)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(346, 30)
        Me.txtNombreA.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Intereses"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alias"
        '
        'txtAliasA
        '
        Me.txtAliasA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAliasA.Location = New System.Drawing.Point(218, 18)
        Me.txtAliasA.Margin = New System.Windows.Forms.Padding(3, 3, 16, 3)
        Me.txtAliasA.Name = "txtAliasA"
        Me.txtAliasA.Size = New System.Drawing.Size(183, 30)
        Me.txtAliasA.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnBuscarE)
        Me.TabPage1.Controls.Add(Me.txtInteresesE)
        Me.TabPage1.Controls.Add(Me.txtTelefonoE)
        Me.TabPage1.Controls.Add(Me.txtApellidosE)
        Me.TabPage1.Controls.Add(Me.txtNombreE)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtAliasE)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage1.Size = New System.Drawing.Size(752, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Eliminar"
        Me.TabPage1.ToolTipText = "Borra a una persona"
        '
        'btnBuscarE
        '
        Me.btnBuscarE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarE.Location = New System.Drawing.Point(430, 18)
        Me.btnBuscarE.Name = "btnBuscarE"
        Me.btnBuscarE.Size = New System.Drawing.Size(131, 29)
        Me.btnBuscarE.TabIndex = 30
        Me.btnBuscarE.Text = "Buscar"
        Me.btnBuscarE.UseVisualStyleBackColor = False
        '
        'txtInteresesE
        '
        Me.txtInteresesE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInteresesE.Location = New System.Drawing.Point(215, 210)
        Me.txtInteresesE.Multiline = True
        Me.txtInteresesE.Name = "txtInteresesE"
        Me.txtInteresesE.Size = New System.Drawing.Size(346, 39)
        Me.txtInteresesE.TabIndex = 29
        '
        'txtTelefonoE
        '
        Me.txtTelefonoE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefonoE.Location = New System.Drawing.Point(215, 165)
        Me.txtTelefonoE.Name = "txtTelefonoE"
        Me.txtTelefonoE.Size = New System.Drawing.Size(346, 30)
        Me.txtTelefonoE.TabIndex = 28
        '
        'txtApellidosE
        '
        Me.txtApellidosE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidosE.Location = New System.Drawing.Point(215, 115)
        Me.txtApellidosE.Name = "txtApellidosE"
        Me.txtApellidosE.Size = New System.Drawing.Size(346, 30)
        Me.txtApellidosE.TabIndex = 27
        '
        'txtNombreE
        '
        Me.txtNombreE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreE.Location = New System.Drawing.Point(215, 64)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(346, 30)
        Me.txtNombreE.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Intereses"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Apellidos"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(122, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 22)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(141, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 22)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Alias"
        '
        'txtAliasE
        '
        Me.txtAliasE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAliasE.Location = New System.Drawing.Point(215, 18)
        Me.txtAliasE.Name = "txtAliasE"
        Me.txtAliasE.Size = New System.Drawing.Size(179, 30)
        Me.txtAliasE.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage2.Size = New System.Drawing.Size(752, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos"
        Me.TabPage2.ToolTipText = "Muestra los datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AliasDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.InteresesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GrupoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(728, 238)
        Me.DataGridView1.TabIndex = 0
        '
        'AliasDataGridViewTextBoxColumn
        '
        Me.AliasDataGridViewTextBoxColumn.DataPropertyName = "Alias"
        Me.AliasDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.AliasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AliasDataGridViewTextBoxColumn.Name = "AliasDataGridViewTextBoxColumn"
        Me.AliasDataGridViewTextBoxColumn.ReadOnly = True
        Me.AliasDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'InteresesDataGridViewTextBoxColumn
        '
        Me.InteresesDataGridViewTextBoxColumn.DataPropertyName = "intereses"
        Me.InteresesDataGridViewTextBoxColumn.HeaderText = "intereses"
        Me.InteresesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InteresesDataGridViewTextBoxColumn.Name = "InteresesDataGridViewTextBoxColumn"
        Me.InteresesDataGridViewTextBoxColumn.ReadOnly = True
        Me.InteresesDataGridViewTextBoxColumn.Width = 125
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.ClientesDataSet1
        '
        'ClientesDataSet1
        '
        Me.ClientesDataSet1.DataSetName = "ClientesDataSet1"
        Me.ClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panelppal)
        Me.Controls.Add(Me.Panelbtm)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.Panelbtm.ResumeLayout(False)
        Me.Panelppal.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Panelbtm As Panel
    Friend WithEvents Panelppal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtAliasR As TextBox
    Friend WithEvents txtInteresesR As TextBox
    Friend WithEvents txtTelefonoR As TextBox
    Friend WithEvents txtApellidosR As TextBox
    Friend WithEvents txtNombreR As TextBox
    Friend WithEvents lblIntereses As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAlias As Label
    Friend WithEvents txtInteresesA As TextBox
    Friend WithEvents txtTelefonoA As TextBox
    Friend WithEvents txtApellidosA As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAliasA As TextBox
    Friend WithEvents txtInteresesE As TextBox
    Friend WithEvents txtTelefonoE As TextBox
    Friend WithEvents txtApellidosE As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAliasE As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientesDataSet1 As ClientesDataSet1
    Friend WithEvents GrupoBindingSource As BindingSource
    Friend WithEvents GrupoTableAdapter As ClientesDataSet1TableAdapters.GrupoTableAdapter
    Friend WithEvents AliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InteresesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAccion As Button
    Friend WithEvents btnBuscarE As Button
    Friend WithEvents btnBuscarA As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnExit As Button
End Class

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtUsuarioI = New System.Windows.Forms.Label()
        Me.txtUsr = New System.Windows.Forms.Label()
        Me.SaldoActualI = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscarI = New System.Windows.Forms.Button()
        Me.txtDineroI = New System.Windows.Forms.TextBox()
        Me.txtIdI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtUsrR = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SaldoActualR = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscarR = New System.Windows.Forms.Button()
        Me.txtDineroR = New System.Windows.Forms.TextBox()
        Me.txtIdR = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnBuscarE = New System.Windows.Forms.Button()
        Me.txtIdE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaldoE = New System.Windows.Forms.TextBox()
        Me.txtFechaE = New System.Windows.Forms.TextBox()
        Me.txtUsrE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet11 = New BancoEj6.ClientesDataSet1()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientesDataSet1 = New BancoEj6.ClientesDataSet()
        Me.BancoTableAdapter2 = New BancoEj6.ClientesDataSetTableAdapters.BancoTableAdapter()
        Me.BancoTableAdapter = New BancoEj6.ClientesDataSet1TableAdapters.BancoTableAdapter()
        Me.CrystalReport41 = New BancoEj6.CrystalReport4()
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(677, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 32)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaximize.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(716, 6)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(33, 32)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.Text = "❑"
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(180, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Reem Kufi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(229, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplicación CajaMadrid"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(755, 6)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 32)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAccion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 58)
        Me.Panel2.TabIndex = 1
        '
        'btnAccion
        '
        Me.btnAccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAccion.Location = New System.Drawing.Point(198, 18)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(378, 28)
        Me.btnAccion.TabIndex = 0
        Me.btnAccion.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Panel3.Controls.Add(Me.tabs)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 348)
        Me.Panel3.TabIndex = 2
        '
        'tabs
        '
        Me.tabs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage5)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.Controls.Add(Me.TabPage4)
        Me.tabs.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabs.Location = New System.Drawing.Point(30, 31)
        Me.tabs.Name = "tabs"
        Me.tabs.Padding = New System.Drawing.Point(25, 3)
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(740, 283)
        Me.tabs.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.txtSaldoInicial)
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(732, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoInicial.BackColor = System.Drawing.Color.White
        Me.txtSaldoInicial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSaldoInicial.Location = New System.Drawing.Point(231, 120)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(370, 30)
        Me.txtSaldoInicial.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtUsuario.Location = New System.Drawing.Point(231, 52)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(370, 30)
        Me.txtUsuario.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Saldo inicial"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.txtUsuarioI)
        Me.TabPage2.Controls.Add(Me.txtUsr)
        Me.TabPage2.Controls.Add(Me.SaldoActualI)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.btnBuscarI)
        Me.TabPage2.Controls.Add(Me.txtDineroI)
        Me.TabPage2.Controls.Add(Me.txtIdI)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(732, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingresar dinero"
        '
        'txtUsuarioI
        '
        Me.txtUsuarioI.AutoSize = True
        Me.txtUsuarioI.Location = New System.Drawing.Point(252, 104)
        Me.txtUsuarioI.Name = "txtUsuarioI"
        Me.txtUsuarioI.Size = New System.Drawing.Size(48, 27)
        Me.txtUsuarioI.TabIndex = 19
        Me.txtUsuarioI.Text = "____"
        '
        'txtUsr
        '
        Me.txtUsr.AutoSize = True
        Me.txtUsr.Location = New System.Drawing.Point(97, 104)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(67, 27)
        Me.txtUsr.TabIndex = 18
        Me.txtUsr.Text = "Usuario"
        '
        'SaldoActualI
        '
        Me.SaldoActualI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaldoActualI.AutoSize = True
        Me.SaldoActualI.Location = New System.Drawing.Point(579, 104)
        Me.SaldoActualI.Name = "SaldoActualI"
        Me.SaldoActualI.Size = New System.Drawing.Size(48, 27)
        Me.SaldoActualI.TabIndex = 17
        Me.SaldoActualI.Text = "____"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(428, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 27)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Saldo Actual"
        '
        'btnBuscarI
        '
        Me.btnBuscarI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarI.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnBuscarI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarI.Font = New System.Drawing.Font("Reem Kufi", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarI.Location = New System.Drawing.Point(478, 56)
        Me.btnBuscarI.Name = "btnBuscarI"
        Me.btnBuscarI.Size = New System.Drawing.Size(149, 28)
        Me.btnBuscarI.TabIndex = 15
        Me.btnBuscarI.Text = "Buscar"
        Me.btnBuscarI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarI.UseVisualStyleBackColor = False
        '
        'txtDineroI
        '
        Me.txtDineroI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDineroI.BackColor = System.Drawing.Color.White
        Me.txtDineroI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDineroI.Location = New System.Drawing.Point(257, 154)
        Me.txtDineroI.Name = "txtDineroI"
        Me.txtDineroI.Size = New System.Drawing.Size(370, 30)
        Me.txtDineroI.TabIndex = 11
        '
        'txtIdI
        '
        Me.txtIdI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdI.BackColor = System.Drawing.Color.White
        Me.txtIdI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtIdI.Location = New System.Drawing.Point(257, 54)
        Me.txtIdI.Name = "txtIdI"
        Me.txtIdI.Size = New System.Drawing.Size(207, 30)
        Me.txtIdI.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Importe a ingresar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Identificador"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage5.Controls.Add(Me.txtUsrR)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.SaldoActualR)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.btnBuscarR)
        Me.TabPage5.Controls.Add(Me.txtDineroR)
        Me.TabPage5.Controls.Add(Me.txtIdR)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 36)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(732, 243)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Retirar dinero"
        '
        'txtUsrR
        '
        Me.txtUsrR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsrR.AutoSize = True
        Me.txtUsrR.Location = New System.Drawing.Point(256, 109)
        Me.txtUsrR.Name = "txtUsrR"
        Me.txtUsrR.Size = New System.Drawing.Size(48, 27)
        Me.txtUsrR.TabIndex = 26
        Me.txtUsrR.Text = "____"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(101, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 27)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Usuario"
        '
        'SaldoActualR
        '
        Me.SaldoActualR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaldoActualR.AutoSize = True
        Me.SaldoActualR.Location = New System.Drawing.Point(583, 109)
        Me.SaldoActualR.Name = "SaldoActualR"
        Me.SaldoActualR.Size = New System.Drawing.Size(48, 27)
        Me.SaldoActualR.TabIndex = 24
        Me.SaldoActualR.Text = "____"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Saldo Actual"
        '
        'btnBuscarR
        '
        Me.btnBuscarR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarR.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnBuscarR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarR.Font = New System.Drawing.Font("Reem Kufi", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarR.Location = New System.Drawing.Point(482, 58)
        Me.btnBuscarR.Name = "btnBuscarR"
        Me.btnBuscarR.Size = New System.Drawing.Size(149, 28)
        Me.btnBuscarR.TabIndex = 22
        Me.btnBuscarR.Text = "Buscar"
        Me.btnBuscarR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarR.UseVisualStyleBackColor = False
        '
        'txtDineroR
        '
        Me.txtDineroR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDineroR.BackColor = System.Drawing.Color.White
        Me.txtDineroR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDineroR.Location = New System.Drawing.Point(261, 156)
        Me.txtDineroR.Name = "txtDineroR"
        Me.txtDineroR.Size = New System.Drawing.Size(370, 30)
        Me.txtDineroR.TabIndex = 21
        '
        'txtIdR
        '
        Me.txtIdR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdR.BackColor = System.Drawing.Color.White
        Me.txtIdR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtIdR.Location = New System.Drawing.Point(261, 56)
        Me.txtIdR.Name = "txtIdR"
        Me.txtIdR.Size = New System.Drawing.Size(207, 30)
        Me.txtIdR.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label14.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(101, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 27)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Importe a retirar"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label15.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(101, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 27)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Identificador"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage3.Controls.Add(Me.btnBuscarE)
        Me.TabPage3.Controls.Add(Me.txtIdE)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtSaldoE)
        Me.TabPage3.Controls.Add(Me.txtFechaE)
        Me.TabPage3.Controls.Add(Me.txtUsrE)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(732, 243)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Eiminar cuenta"
        '
        'btnBuscarE
        '
        Me.btnBuscarE.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarE.Font = New System.Drawing.Font("Reem Kufi", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarE.Location = New System.Drawing.Point(461, 19)
        Me.btnBuscarE.Name = "btnBuscarE"
        Me.btnBuscarE.Size = New System.Drawing.Size(149, 28)
        Me.btnBuscarE.TabIndex = 14
        Me.btnBuscarE.Text = "Buscar"
        Me.btnBuscarE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarE.UseVisualStyleBackColor = False
        '
        'txtIdE
        '
        Me.txtIdE.BackColor = System.Drawing.Color.White
        Me.txtIdE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtIdE.Location = New System.Drawing.Point(240, 20)
        Me.txtIdE.Name = "txtIdE"
        Me.txtIdE.Size = New System.Drawing.Size(201, 30)
        Me.txtIdE.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label12.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(129, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 27)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Identificador"
        '
        'txtSaldoE
        '
        Me.txtSaldoE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoE.BackColor = System.Drawing.Color.White
        Me.txtSaldoE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtSaldoE.Location = New System.Drawing.Point(240, 190)
        Me.txtSaldoE.Name = "txtSaldoE"
        Me.txtSaldoE.Size = New System.Drawing.Size(370, 30)
        Me.txtSaldoE.TabIndex = 11
        '
        'txtFechaE
        '
        Me.txtFechaE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaE.BackColor = System.Drawing.Color.White
        Me.txtFechaE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFechaE.Location = New System.Drawing.Point(240, 129)
        Me.txtFechaE.Name = "txtFechaE"
        Me.txtFechaE.Size = New System.Drawing.Size(370, 30)
        Me.txtFechaE.TabIndex = 10
        '
        'txtUsrE
        '
        Me.txtUsrE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsrE.BackColor = System.Drawing.Color.White
        Me.txtUsrE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtUsrE.Location = New System.Drawing.Point(240, 75)
        Me.txtUsrE.Name = "txtUsrE"
        Me.txtUsrE.Size = New System.Drawing.Size(370, 30)
        Me.txtUsrE.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label9.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(129, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Saldo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(129, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 27)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Fecha de alta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label11.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(129, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 27)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Usuario"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(732, 243)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Mostrar cuentas"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Reem Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUserDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.MoneyDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.BancoBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(732, 243)
        Me.DataGridView3.TabIndex = 2
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataMember = "Banco"
        Me.BancoBindingSource.DataSource = Me.ClientesDataSet11
        '
        'ClientesDataSet11
        '
        Me.ClientesDataSet11.DataSetName = "ClientesDataSet1"
        Me.ClientesDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView2.ColumnHeadersHeight = 29
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(732, 243)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.ClientesDataSet1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(732, 243)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientesDataSet1
        '
        Me.ClientesDataSet1.DataSetName = "ClientesDataSet"
        Me.ClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancoTableAdapter2
        '
        Me.BancoTableAdapter2.ClearBeforeFill = True
        '
        'BancoTableAdapter
        '
        Me.BancoTableAdapter.ClearBeforeFill = True
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "idUser"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IdUserDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "Identificador"
        Me.IdUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUserDataGridViewTextBoxColumn.Width = 125
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "user"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.UserDataGridViewTextBoxColumn.HeaderText = "Nombre "
        Me.UserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserDataGridViewTextBoxColumn.Width = 125
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FechaAltaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "fecha de Alta"
        Me.FechaAltaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAltaDataGridViewTextBoxColumn.Width = 125
        '
        'MoneyDataGridViewTextBoxColumn
        '
        Me.MoneyDataGridViewTextBoxColumn.DataPropertyName = "money"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MoneyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.MoneyDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.MoneyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MoneyDataGridViewTextBoxColumn.Name = "MoneyDataGridViewTextBoxColumn"
        Me.MoneyDataGridViewTextBoxColumn.ReadOnly = True
        Me.MoneyDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnAccion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtDineroI As TextBox
    Friend WithEvents txtIdI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnBuscarE As Button
    Friend WithEvents txtIdE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSaldoE As TextBox
    Friend WithEvents txtFechaE As TextBox
    Friend WithEvents txtUsrE As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ClientesDataSet1 As ClientesDataSet
    Friend WithEvents BancoTableAdapter2 As ClientesDataSetTableAdapters.BancoTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaldoActualI As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBuscarI As Button
    Friend WithEvents SaldoActualR As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscarR As Button
    Friend WithEvents txtDineroR As TextBox
    Friend WithEvents txtIdR As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtUsr As Label
    Friend WithEvents txtUsuarioI As Label
    Friend WithEvents txtUsrR As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CrystalReport41 As CrystalReport4
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ClientesDataSet11 As ClientesDataSet1
    Friend WithEvents BancoBindingSource As BindingSource
    Friend WithEvents BancoTableAdapter As ClientesDataSet1TableAdapters.BancoTableAdapter
    Friend WithEvents IdUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

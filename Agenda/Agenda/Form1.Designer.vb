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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.dtePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblCumple = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.AgendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet = New Agenda.ClientesDataSet()
        Me.AgendaTableAdapter = New Agenda.ClientesDataSetTableAdapters.AgendaTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CumpleanosColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.dtePicker)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.lblDNI)
        Me.GroupBox1.Controls.Add(Me.lblCumple)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(40, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Contacto"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(96, 116)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(695, 28)
        Me.txtDireccion.TabIndex = 10
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(6, 116)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(85, 22)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Direccion"
        '
        'dtePicker
        '
        Me.dtePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePicker.CalendarForeColor = System.Drawing.Color.Green
        Me.dtePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtePicker.CalendarTitleForeColor = System.Drawing.Color.Green
        Me.dtePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.dtePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePicker.Location = New System.Drawing.Point(542, 31)
        Me.dtePicker.Name = "dtePicker"
        Me.dtePicker.Size = New System.Drawing.Size(249, 28)
        Me.dtePicker.TabIndex = 8
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(542, 76)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(249, 28)
        Me.txtDni.TabIndex = 7
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(401, 82)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(40, 22)
        Me.lblDNI.TabIndex = 6
        Me.lblDNI.Text = "DNI"
        '
        'lblCumple
        '
        Me.lblCumple.AutoSize = True
        Me.lblCumple.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCumple.Location = New System.Drawing.Point(401, 37)
        Me.lblCumple.Name = "lblCumple"
        Me.lblCumple.Size = New System.Drawing.Size(110, 22)
        Me.lblCumple.TabIndex = 5
        Me.lblCumple.Text = "Cumpleaños"
        '
        'txtTelefono
        '
        Me.txtTelefono.ForeColor = System.Drawing.Color.Green
        Me.txtTelefono.Location = New System.Drawing.Point(96, 76)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(255, 28)
        Me.txtTelefono.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.Color.Green
        Me.txtNombre.Location = New System.Drawing.Point(96, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 28)
        Me.txtNombre.TabIndex = 3
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(6, 76)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(81, 22)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Telefono"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(6, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreColumn, Me.TelefonoColumn, Me.DireccionColumn, Me.CumpleanosColumn, Me.DNIColumn})
        Me.dgvDatos.DataSource = Me.AgendaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.GridColor = System.Drawing.Color.ForestGreen
        Me.dgvDatos.Location = New System.Drawing.Point(41, 309)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.Size = New System.Drawing.Size(815, 223)
        Me.dgvDatos.TabIndex = 1
        '
        'AgendaBindingSource
        '
        Me.AgendaBindingSource.DataMember = "Agenda"
        Me.AgendaBindingSource.DataSource = Me.ClientesDataSet
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "ClientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgendaTableAdapter
        '
        Me.AgendaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 39)
        Me.Panel1.TabIndex = 2
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Green
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(769, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 31)
        Me.btnMinimize.TabIndex = 9
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Green
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Location = New System.Drawing.Point(810, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(35, 31)
        Me.btnMaximize.TabIndex = 8
        Me.btnMaximize.Text = "🔲"
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Green
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(851, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Green
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(183, 203)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 34)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(327, 203)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(116, 34)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Green
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(468, 203)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(116, 34)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Green
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(611, 203)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(116, 34)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.GroupBox1)
        Me.PanelDatos.Controls.Add(Me.dgvDatos)
        Me.PanelDatos.Controls.Add(Me.btnModificar)
        Me.PanelDatos.Controls.Add(Me.btnGuardar)
        Me.PanelDatos.Controls.Add(Me.btnAgregar)
        Me.PanelDatos.Controls.Add(Me.btnEliminar)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatos.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(889, 564)
        Me.PanelDatos.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(35, 309)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(851, 229)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de contactos"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "Nombre"
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.MinimumWidth = 6
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.Width = 125
        '
        'TelefonoColumn
        '
        Me.TelefonoColumn.DataPropertyName = "Telefono"
        Me.TelefonoColumn.HeaderText = "Telefono"
        Me.TelefonoColumn.MinimumWidth = 6
        Me.TelefonoColumn.Name = "TelefonoColumn"
        Me.TelefonoColumn.Width = 125
        '
        'DireccionColumn
        '
        Me.DireccionColumn.DataPropertyName = "Direccion"
        Me.DireccionColumn.HeaderText = "Direccion"
        Me.DireccionColumn.MinimumWidth = 6
        Me.DireccionColumn.Name = "DireccionColumn"
        Me.DireccionColumn.Width = 125
        '
        'CumpleanosColumn
        '
        Me.CumpleanosColumn.DataPropertyName = "Cumpleaños"
        Me.CumpleanosColumn.HeaderText = "Cumpleaños"
        Me.CumpleanosColumn.MinimumWidth = 6
        Me.CumpleanosColumn.Name = "CumpleanosColumn"
        Me.CumpleanosColumn.Width = 125
        '
        'DNIColumn
        '
        Me.DNIColumn.DataPropertyName = "DNI"
        Me.DNIColumn.HeaderText = "DNI"
        Me.DNIColumn.MinimumWidth = 6
        Me.DNIColumn.Name = "DNIColumn"
        Me.DNIColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 564)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents ClientesDataSet As ClientesDataSet
    Friend WithEvents AgendaBindingSource As BindingSource
    Friend WithEvents AgendaTableAdapter As ClientesDataSetTableAdapters.AgendaTableAdapter
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCumple As Label
    Friend WithEvents dtePicker As DateTimePicker
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents NombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As DataGridViewTextBoxColumn
    Friend WithEvents CumpleanosColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIColumn As DataGridViewTextBoxColumn
End Class

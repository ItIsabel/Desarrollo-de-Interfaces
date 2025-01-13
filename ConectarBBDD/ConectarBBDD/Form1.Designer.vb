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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerNombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerGeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerCorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerFechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet1 = New ConectarBBDD.ClientesDataSet()
        Me.PersonasTableAdapter = New ConectarBBDD.ClientesDataSetTableAdapters.PersonasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS PGothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonaDataGridViewTextBoxColumn, Me.PerIdentificacionDataGridViewTextBoxColumn, Me.PerNombresDataGridViewTextBoxColumn, Me.PerApellidosDataGridViewTextBoxColumn, Me.PerGeneroDataGridViewTextBoxColumn, Me.PerCorreoDataGridViewTextBoxColumn, Me.PerFechaNacimientoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonasBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS PGothic", 7.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(22, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS PGothic", 7.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(692, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'IdPersonaDataGridViewTextBoxColumn
        '
        Me.IdPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.IdPersonaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdPersonaDataGridViewTextBoxColumn.HeaderText = "Clave Primaria"
        Me.IdPersonaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPersonaDataGridViewTextBoxColumn.Name = "IdPersonaDataGridViewTextBoxColumn"
        Me.IdPersonaDataGridViewTextBoxColumn.Width = 125
        '
        'PerIdentificacionDataGridViewTextBoxColumn
        '
        Me.PerIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "perIdentificacion"
        Me.PerIdentificacionDataGridViewTextBoxColumn.HeaderText = "Numero de Personal"
        Me.PerIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerIdentificacionDataGridViewTextBoxColumn.Name = "PerIdentificacionDataGridViewTextBoxColumn"
        Me.PerIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'PerNombresDataGridViewTextBoxColumn
        '
        Me.PerNombresDataGridViewTextBoxColumn.DataPropertyName = "perNombres"
        Me.PerNombresDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PerNombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerNombresDataGridViewTextBoxColumn.Name = "PerNombresDataGridViewTextBoxColumn"
        Me.PerNombresDataGridViewTextBoxColumn.Width = 125
        '
        'PerApellidosDataGridViewTextBoxColumn
        '
        Me.PerApellidosDataGridViewTextBoxColumn.DataPropertyName = "perApellidos"
        Me.PerApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.PerApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerApellidosDataGridViewTextBoxColumn.Name = "PerApellidosDataGridViewTextBoxColumn"
        Me.PerApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'PerGeneroDataGridViewTextBoxColumn
        '
        Me.PerGeneroDataGridViewTextBoxColumn.DataPropertyName = "perGenero"
        Me.PerGeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.PerGeneroDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerGeneroDataGridViewTextBoxColumn.Name = "PerGeneroDataGridViewTextBoxColumn"
        Me.PerGeneroDataGridViewTextBoxColumn.Width = 125
        '
        'PerCorreoDataGridViewTextBoxColumn
        '
        Me.PerCorreoDataGridViewTextBoxColumn.DataPropertyName = "perCorreo"
        Me.PerCorreoDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.PerCorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerCorreoDataGridViewTextBoxColumn.Name = "PerCorreoDataGridViewTextBoxColumn"
        Me.PerCorreoDataGridViewTextBoxColumn.Width = 125
        '
        'PerFechaNacimientoDataGridViewTextBoxColumn
        '
        Me.PerFechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "perFechaNacimiento"
        Me.PerFechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento"
        Me.PerFechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PerFechaNacimientoDataGridViewTextBoxColumn.Name = "PerFechaNacimientoDataGridViewTextBoxColumn"
        Me.PerFechaNacimientoDataGridViewTextBoxColumn.Width = 125
        '
        'PersonasBindingSource
        '
        Me.PersonasBindingSource.DataMember = "Personas"
        Me.PersonasBindingSource.DataSource = Me.ClientesDataSet1
        '
        'ClientesDataSet1
        '
        Me.ClientesDataSet1.DataSetName = "ClientesDataSet1"
        Me.ClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonasTableAdapter
        '
        Me.PersonasTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 31)
        Me.Panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientesDataSet1 As ClientesDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As ClientesDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdPersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerNombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerGeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerCorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerFechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class

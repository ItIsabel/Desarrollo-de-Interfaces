<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatos
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
        lblNombre = New Label()
        lblTlf = New Label()
        lblFecha = New Label()
        txtNombre = New TextBox()
        txtTlf = New TextBox()
        Calendario = New MonthCalendar()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(42, 131)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(64, 20)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre"
        ' 
        ' lblTlf
        ' 
        lblTlf.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblTlf.AutoSize = True
        lblTlf.Location = New Point(42, 227)
        lblTlf.Name = "lblTlf"
        lblTlf.Size = New Size(67, 20)
        lblTlf.TabIndex = 1
        lblTlf.Text = "Telefono"
        ' 
        ' lblFecha
        ' 
        lblFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(528, 71)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(121, 20)
        lblFecha.TabIndex = 2
        lblFecha.Text = "Fecha del evento"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtNombre.Location = New Point(136, 131)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(292, 27)
        txtNombre.TabIndex = 3
        ' 
        ' txtTlf
        ' 
        txtTlf.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtTlf.Location = New Point(136, 227)
        txtTlf.Name = "txtTlf"
        txtTlf.Size = New Size(292, 27)
        txtTlf.TabIndex = 4
        ' 
        ' Calendario
        ' 
        Calendario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Calendario.Location = New Point(517, 100)
        Calendario.Name = "Calendario"
        Calendario.TabIndex = 7
        ' 
        ' FormDatos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        ClientSize = New Size(782, 399)
        Controls.Add(Calendario)
        Controls.Add(txtTlf)
        Controls.Add(txtNombre)
        Controls.Add(lblFecha)
        Controls.Add(lblTlf)
        Controls.Add(lblNombre)
        Name = "FormDatos"
        Text = "Datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTlf As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents Calendario As MonthCalendar
End Class

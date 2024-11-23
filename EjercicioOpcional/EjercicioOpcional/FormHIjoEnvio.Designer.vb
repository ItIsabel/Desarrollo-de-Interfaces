<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHIjoEnvio
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
        lblApellido = New Label()
        Label1 = New Label()
        txtNombre = New TextBox()
        txtTlf = New TextBox()
        txtDireccion = New TextBox()
        btnBorrar = New Button()
        btnPedir = New Button()
        lblEnvio = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        lblNombre.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        lblNombre.Location = New Point(97, 105)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(86, 21)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        lblApellido.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        lblApellido.Location = New Point(97, 150)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(99, 21)
        lblApellido.TabIndex = 1
        lblApellido.Text = "Telefono"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label1.Location = New Point(97, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 21)
        Label1.TabIndex = 2
        Label1.Text = "Direccion"
        ' 
        ' txtNombre
        ' 
        txtNombre.AcceptsReturn = True
        txtNombre.Location = New Point(238, 105)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(454, 27)
        txtNombre.TabIndex = 3
        ' 
        ' txtTlf
        ' 
        txtTlf.Location = New Point(238, 150)
        txtTlf.Name = "txtTlf"
        txtTlf.Size = New Size(454, 27)
        txtTlf.TabIndex = 4
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(238, 196)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(454, 27)
        txtDireccion.TabIndex = 5
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnBorrar.Location = New Point(97, 247)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(108, 53)
        btnBorrar.TabIndex = 6
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnPedir
        ' 
        btnPedir.BackColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        btnPedir.FlatStyle = FlatStyle.Flat
        btnPedir.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPedir.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnPedir.Location = New Point(530, 247)
        btnPedir.Name = "btnPedir"
        btnPedir.Size = New Size(162, 53)
        btnPedir.TabIndex = 7
        btnPedir.Text = "Confirmar direccion"
        btnPedir.UseVisualStyleBackColor = False
        ' 
        ' lblEnvio
        ' 
        lblEnvio.AutoSize = True
        lblEnvio.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEnvio.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        lblEnvio.Location = New Point(97, 46)
        lblEnvio.Name = "lblEnvio"
        lblEnvio.Size = New Size(384, 29)
        lblEnvio.TabIndex = 8
        lblEnvio.Text = "Dinos dónde te lo llevamos:"
        ' 
        ' FormHIjoEnvio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ClientSize = New Size(782, 359)
        Controls.Add(lblEnvio)
        Controls.Add(btnPedir)
        Controls.Add(btnBorrar)
        Controls.Add(txtDireccion)
        Controls.Add(txtTlf)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Controls.Add(lblApellido)
        Controls.Add(lblNombre)
        Name = "FormHIjoEnvio"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnPedir As Button
    Friend WithEvents lblEnvio As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

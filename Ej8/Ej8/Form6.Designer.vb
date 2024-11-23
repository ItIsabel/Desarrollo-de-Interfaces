<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContacto
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
        Me.btnContacto = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lbltlf = New System.Windows.Forms.Label()
        Me.lblContactar = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContacto
        '
        Me.btnContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContacto.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnContacto.Location = New System.Drawing.Point(508, 331)
        Me.btnContacto.Name = "btnContacto"
        Me.btnContacto.Size = New System.Drawing.Size(165, 43)
        Me.btnContacto.TabIndex = 0
        Me.btnContacto.Text = "¡Contactadme!"
        Me.btnContacto.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(18, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(18, 77)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(73, 16)
        Me.lblApellidos.TabIndex = 2
        Me.lblApellidos.Text = "Apellidos"
        '
        'lbltlf
        '
        Me.lbltlf.AutoSize = True
        Me.lbltlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltlf.Location = New System.Drawing.Point(18, 111)
        Me.lbltlf.Name = "lbltlf"
        Me.lbltlf.Size = New System.Drawing.Size(69, 16)
        Me.lbltlf.TabIndex = 3
        Me.lbltlf.Text = "Telefono"
        '
        'lblContactar
        '
        Me.lblContactar.AutoSize = True
        Me.lblContactar.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblContactar.Location = New System.Drawing.Point(34, 70)
        Me.lblContactar.Name = "lblContactar"
        Me.lblContactar.Size = New System.Drawing.Size(844, 46)
        Me.lblContactar.TabIndex = 4
        Me.lblContactar.Text = "Dejanos tus datos y te contactaremos..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtMail)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.txtTlf)
        Me.Panel1.Controls.Add(Me.lblApellidos)
        Me.Panel1.Controls.Add(Me.lbltlf)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Location = New System.Drawing.Point(213, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 187)
        Me.Panel1.TabIndex = 5
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(98, 139)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(312, 22)
        Me.txtMail.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "E-mail"
        '
        'txtTlf
        '
        Me.txtTlf.Location = New System.Drawing.Point(98, 105)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(312, 22)
        Me.txtTlf.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(98, 71)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(312, 22)
        Me.txtApellido.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(98, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(312, 22)
        Me.txtNombre.TabIndex = 0
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrar.Location = New System.Drawing.Point(311, 331)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(167, 43)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'FormContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 495)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblContactar)
        Me.Controls.Add(Me.btnContacto)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Name = "FormContacto"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContacto As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lbltlf As Label
    Friend WithEvents lblContactar As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnBorrar As Button
End Class

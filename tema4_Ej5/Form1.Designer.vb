<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNombre = New Label()
        lblformMediasPuri = New Label()
        lblTlf = New Label()
        lblDir = New Label()
        lblPedido = New Label()
        txtNombre = New TextBox()
        txtTlf = New TextBox()
        txtAddress = New TextBox()
        txtPedido = New TextBox()
        btnPedido = New Button()
        btnLimpiarPedido = New Button()
        btnSalir = New Button()
        ListBox1 = New ListBox()
        lblListBox = New Label()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(71, 114)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(64, 20)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre"
        ' 
        ' lblformMediasPuri
        ' 
        lblformMediasPuri.AutoSize = True
        lblformMediasPuri.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblformMediasPuri.ForeColor = Color.RosyBrown
        lblformMediasPuri.Location = New Point(96, 28)
        lblformMediasPuri.Name = "lblformMediasPuri"
        lblformMediasPuri.Size = New Size(236, 54)
        lblformMediasPuri.TabIndex = 1
        lblformMediasPuri.Text = "Medias Puri"
        ' 
        ' lblTlf
        ' 
        lblTlf.AutoSize = True
        lblTlf.Location = New Point(71, 163)
        lblTlf.Name = "lblTlf"
        lblTlf.Size = New Size(67, 20)
        lblTlf.TabIndex = 2
        lblTlf.Text = "Telefono"
        ' 
        ' lblDir
        ' 
        lblDir.AutoSize = True
        lblDir.Location = New Point(71, 213)
        lblDir.Name = "lblDir"
        lblDir.Size = New Size(72, 20)
        lblDir.TabIndex = 3
        lblDir.Text = "Direccion"
        ' 
        ' lblPedido
        ' 
        lblPedido.AutoSize = True
        lblPedido.Location = New Point(71, 261)
        lblPedido.Name = "lblPedido"
        lblPedido.Size = New Size(55, 20)
        lblPedido.TabIndex = 4
        lblPedido.Text = "Pedido"
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.PeachPuff
        txtNombre.Location = New Point(152, 107)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(223, 27)
        txtNombre.TabIndex = 5
        ' 
        ' txtTlf
        ' 
        txtTlf.BackColor = Color.PeachPuff
        txtTlf.Location = New Point(152, 156)
        txtTlf.Name = "txtTlf"
        txtTlf.Size = New Size(223, 27)
        txtTlf.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.PeachPuff
        txtAddress.Location = New Point(152, 206)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(223, 27)
        txtAddress.TabIndex = 10
        ' 
        ' txtPedido
        ' 
        txtPedido.BackColor = Color.PeachPuff
        txtPedido.Location = New Point(152, 254)
        txtPedido.Name = "txtPedido"
        txtPedido.Size = New Size(223, 27)
        txtPedido.TabIndex = 11
        ' 
        ' btnPedido
        ' 
        btnPedido.BackColor = Color.RosyBrown
        btnPedido.Cursor = Cursors.Hand
        btnPedido.FlatStyle = FlatStyle.Popup
        btnPedido.ForeColor = SystemColors.ButtonHighlight
        btnPedido.Location = New Point(69, 305)
        btnPedido.Name = "btnPedido"
        btnPedido.Size = New Size(141, 35)
        btnPedido.TabIndex = 12
        btnPedido.Text = "Pedido"
        btnPedido.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiarPedido
        ' 
        btnLimpiarPedido.BackColor = Color.RosyBrown
        btnLimpiarPedido.Cursor = Cursors.Hand
        btnLimpiarPedido.FlatStyle = FlatStyle.Popup
        btnLimpiarPedido.ForeColor = SystemColors.ButtonHighlight
        btnLimpiarPedido.Location = New Point(69, 363)
        btnLimpiarPedido.Name = "btnLimpiarPedido"
        btnLimpiarPedido.Size = New Size(141, 35)
        btnLimpiarPedido.TabIndex = 13
        btnLimpiarPedido.Text = "Limpiar pedido"
        btnLimpiarPedido.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.RosyBrown
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatStyle = FlatStyle.Popup
        btnSalir.ForeColor = SystemColors.ButtonHighlight
        btnSalir.Location = New Point(234, 363)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(141, 35)
        btnSalir.TabIndex = 14
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(434, 138)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(231, 224)
        ListBox1.TabIndex = 15
        ' 
        ' lblListBox
        ' 
        lblListBox.AutoSize = True
        lblListBox.Location = New Point(434, 107)
        lblListBox.Name = "lblListBox"
        lblListBox.Size = New Size(80, 20)
        lblListBox.TabIndex = 16
        lblListBox.Text = "Tu pedido:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(800, 450)
        Controls.Add(lblListBox)
        Controls.Add(ListBox1)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiarPedido)
        Controls.Add(btnPedido)
        Controls.Add(txtPedido)
        Controls.Add(txtAddress)
        Controls.Add(txtTlf)
        Controls.Add(txtNombre)
        Controls.Add(lblPedido)
        Controls.Add(lblDir)
        Controls.Add(lblTlf)
        Controls.Add(lblformMediasPuri)
        Controls.Add(lblNombre)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblformMediasPuri As Label
    Friend WithEvents lblTlf As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents btnPedido As Button
    Friend WithEvents btnLimpiarPedido As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblListBox As Label

End Class

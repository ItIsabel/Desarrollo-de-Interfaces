<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHijoConfirmacion
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
        TextBoxPedido = New TextBox()
        Label1 = New Label()
        TextBoxDireccion = New TextBox()
        btnPedir = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxPedido
        ' 
        TextBoxPedido.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        TextBoxPedido.Location = New Point(25, 117)
        TextBoxPedido.Multiline = True
        TextBoxPedido.Name = "TextBoxPedido"
        TextBoxPedido.Size = New Size(341, 162)
        TextBoxPedido.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label1.Location = New Point(25, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 29)
        Label1.TabIndex = 3
        Label1.Text = "tu pedido:"
        ' 
        ' TextBoxDireccion
        ' 
        TextBoxDireccion.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        TextBoxDireccion.Location = New Point(398, 117)
        TextBoxDireccion.Multiline = True
        TextBoxDireccion.Name = "TextBoxDireccion"
        TextBoxDireccion.Size = New Size(357, 162)
        TextBoxDireccion.TabIndex = 4
        ' 
        ' btnPedir
        ' 
        btnPedir.BackColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        btnPedir.FlatStyle = FlatStyle.Flat
        btnPedir.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPedir.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnPedir.Location = New Point(593, 294)
        btnPedir.Name = "btnPedir"
        btnPedir.Size = New Size(162, 53)
        btnPedir.TabIndex = 8
        btnPedir.Text = "Hacer Pedido"
        btnPedir.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label2.Location = New Point(398, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 29)
        Label2.TabIndex = 9
        Label2.Text = "tu dirección:"
        ' 
        ' FormHijoConfirmacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ClientSize = New Size(782, 359)
        Controls.Add(Label2)
        Controls.Add(btnPedir)
        Controls.Add(TextBoxDireccion)
        Controls.Add(Label1)
        Controls.Add(TextBoxPedido)
        Name = "FormHijoConfirmacion"
        Text = "FormHijoConfirmacion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents btnPedir As Button
    Friend WithEvents Label2 As Label
End Class

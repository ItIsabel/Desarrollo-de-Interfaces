<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmar
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
        txtPeticion = New TextBox()
        btnAbrir = New Button()
        btnSalvar = New Button()
        SuspendLayout()
        ' 
        ' txtPeticion
        ' 
        txtPeticion.BackColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        txtPeticion.Location = New Point(12, 40)
        txtPeticion.Multiline = True
        txtPeticion.Name = "txtPeticion"
        txtPeticion.Size = New Size(740, 163)
        txtPeticion.TabIndex = 0
        ' 
        ' btnAbrir
        ' 
        btnAbrir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAbrir.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnAbrir.FlatStyle = FlatStyle.Flat
        btnAbrir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAbrir.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnAbrir.Location = New Point(12, 234)
        btnAbrir.Margin = New Padding(0)
        btnAbrir.Name = "btnAbrir"
        btnAbrir.Size = New Size(216, 42)
        btnAbrir.TabIndex = 9
        btnAbrir.Text = "Abrir una peticion"
        btnAbrir.UseVisualStyleBackColor = False
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSalvar.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnSalvar.FlatStyle = FlatStyle.Flat
        btnSalvar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalvar.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnSalvar.Location = New Point(498, 234)
        btnSalvar.Margin = New Padding(0)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(254, 42)
        btnSalvar.TabIndex = 10
        btnSalvar.Text = "Guardar peticion"
        btnSalvar.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        ClientSize = New Size(782, 311)
        Controls.Add(btnSalvar)
        Controls.Add(btnAbrir)
        Controls.Add(txtPeticion)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPeticion As TextBox
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnSalvar As Button
End Class

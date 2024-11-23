<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuardar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGuardar))
        btnAbrir = New Button()
        btnGuardar = New Button()
        ListBoxGuardar = New ListBox()
        SuspendLayout()
        ' 
        ' btnAbrir
        ' 
        btnAbrir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAbrir.BackgroundImage = CType(resources.GetObject("btnAbrir.BackgroundImage"), Image)
        btnAbrir.BackgroundImageLayout = ImageLayout.Stretch
        btnAbrir.FlatStyle = FlatStyle.Flat
        btnAbrir.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnAbrir.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnAbrir.Location = New Point(57, 275)
        btnAbrir.Margin = New Padding(0)
        btnAbrir.Name = "btnAbrir"
        btnAbrir.Size = New Size(132, 56)
        btnAbrir.TabIndex = 0
        btnAbrir.Text = "Abrir"
        btnAbrir.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), Image)
        btnGuardar.BackgroundImageLayout = ImageLayout.Stretch
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnGuardar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnGuardar.Location = New Point(472, 275)
        btnGuardar.Margin = New Padding(0)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(132, 56)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' ListBoxGuardar
        ' 
        ListBoxGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxGuardar.BackColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        ListBoxGuardar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        ListBoxGuardar.FormattingEnabled = True
        ListBoxGuardar.ItemHeight = 25
        ListBoxGuardar.Location = New Point(57, 50)
        ListBoxGuardar.Name = "ListBoxGuardar"
        ListBoxGuardar.Size = New Size(547, 204)
        ListBoxGuardar.TabIndex = 2
        ' 
        ' FormGuardar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(685, 422)
        Controls.Add(ListBoxGuardar)
        Controls.Add(btnGuardar)
        Controls.Add(btnAbrir)
        DoubleBuffered = True
        Name = "FormGuardar"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ListBoxGuardar As ListBox
End Class

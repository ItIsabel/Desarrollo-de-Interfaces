<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportar))
        ListBoxImportar = New ListBox()
        btnImportar = New Button()
        SuspendLayout()
        ' 
        ' ListBoxImportar
        ' 
        ListBoxImportar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxImportar.BackColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        ListBoxImportar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        ListBoxImportar.FormattingEnabled = True
        ListBoxImportar.ItemHeight = 25
        ListBoxImportar.Location = New Point(32, 136)
        ListBoxImportar.Name = "ListBoxImportar"
        ListBoxImportar.Size = New Size(617, 154)
        ListBoxImportar.TabIndex = 0
        ' 
        ' btnImportar
        ' 
        btnImportar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnImportar.BackgroundImage = CType(resources.GetObject("btnImportar.BackgroundImage"), Image)
        btnImportar.BackgroundImageLayout = ImageLayout.Stretch
        btnImportar.FlatStyle = FlatStyle.Flat
        btnImportar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnImportar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnImportar.Location = New Point(547, 247)
        btnImportar.Name = "btnImportar"
        btnImportar.Size = New Size(102, 43)
        btnImportar.TabIndex = 2
        btnImportar.Text = "Importar"
        btnImportar.UseVisualStyleBackColor = True
        ' 
        ' FormImportar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(685, 422)
        Controls.Add(btnImportar)
        Controls.Add(ListBoxImportar)
        DoubleBuffered = True
        Name = "FormImportar"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBoxImportar As ListBox
    Friend WithEvents btnImportar As Button
End Class

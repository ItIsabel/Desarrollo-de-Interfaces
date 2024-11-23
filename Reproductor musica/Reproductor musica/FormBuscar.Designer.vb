<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscar))
        ListBoxBuscar = New ListBox()
        btnBuscar = New Button()
        SuspendLayout()
        ' 
        ' ListBoxBuscar
        ' 
        ListBoxBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxBuscar.BackColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        ListBoxBuscar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        ListBoxBuscar.FormattingEnabled = True
        ListBoxBuscar.ItemHeight = 25
        ListBoxBuscar.Location = New Point(21, 99)
        ListBoxBuscar.Name = "ListBoxBuscar"
        ListBoxBuscar.Size = New Size(635, 204)
        ListBoxBuscar.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), Image)
        btnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Brush Script MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        btnBuscar.ForeColor = Color.FromArgb(CByte(248), CByte(204), CByte(223))
        btnBuscar.Location = New Point(553, 260)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 43)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' FormBuscar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(685, 422)
        Controls.Add(btnBuscar)
        Controls.Add(ListBoxBuscar)
        DoubleBuffered = True
        Name = "FormBuscar"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBoxBuscar As ListBox
    Friend WithEvents btnBuscar As Button
End Class

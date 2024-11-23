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
        btnIniciar = New Button()
        SuspendLayout()
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Font = New Font("Segoe UI", 40F)
        btnIniciar.ForeColor = SystemColors.Highlight
        btnIniciar.Location = New Point(188, 143)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(432, 153)
        btnIniciar.TabIndex = 0
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIniciar)
        ImeMode = ImeMode.Disable
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnIniciar As Button

End Class

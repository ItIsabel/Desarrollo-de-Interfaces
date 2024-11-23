<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnMouseHover = New Button()
        btnMouseDown = New Button()
        btnMouseEnter = New Button()
        btnMouseUp = New Button()
        btnMouseWheel = New Button()
        btnMouseMove = New Button()
        btnKeyPress = New Button()
        btnInicio = New Button()
        SuspendLayout()
        ' 
        ' btnMouseHover
        ' 
        btnMouseHover.Location = New Point(478, 77)
        btnMouseHover.Name = "btnMouseHover"
        btnMouseHover.Size = New Size(130, 73)
        btnMouseHover.TabIndex = 1
        btnMouseHover.Text = "MouseHover y MouseLeave"
        btnMouseHover.UseVisualStyleBackColor = True
        ' 
        ' btnMouseDown
        ' 
        btnMouseDown.Location = New Point(332, 77)
        btnMouseDown.Name = "btnMouseDown"
        btnMouseDown.Size = New Size(127, 73)
        btnMouseDown.TabIndex = 2
        btnMouseDown.Text = "MouseDown"
        btnMouseDown.UseVisualStyleBackColor = True
        ' 
        ' btnMouseEnter
        ' 
        btnMouseEnter.Location = New Point(179, 77)
        btnMouseEnter.Name = "btnMouseEnter"
        btnMouseEnter.Size = New Size(127, 73)
        btnMouseEnter.TabIndex = 3
        btnMouseEnter.Text = "MouseEnter"
        btnMouseEnter.UseVisualStyleBackColor = True
        ' 
        ' btnMouseUp
        ' 
        btnMouseUp.Location = New Point(179, 156)
        btnMouseUp.Name = "btnMouseUp"
        btnMouseUp.Size = New Size(127, 57)
        btnMouseUp.TabIndex = 4
        btnMouseUp.Text = "MouseUp"
        btnMouseUp.UseVisualStyleBackColor = True
        ' 
        ' btnMouseWheel
        ' 
        btnMouseWheel.Location = New Point(478, 156)
        btnMouseWheel.Name = "btnMouseWheel"
        btnMouseWheel.Size = New Size(130, 57)
        btnMouseWheel.TabIndex = 5
        btnMouseWheel.Text = "MouseWheel"
        btnMouseWheel.UseVisualStyleBackColor = True
        ' 
        ' btnMouseMove
        ' 
        btnMouseMove.Location = New Point(332, 156)
        btnMouseMove.Name = "btnMouseMove"
        btnMouseMove.Size = New Size(127, 57)
        btnMouseMove.TabIndex = 6
        btnMouseMove.Text = "MouseMove"
        btnMouseMove.UseVisualStyleBackColor = True
        ' 
        ' btnKeyPress
        ' 
        btnKeyPress.Location = New Point(179, 219)
        btnKeyPress.Name = "btnKeyPress"
        btnKeyPress.Size = New Size(127, 55)
        btnKeyPress.TabIndex = 7
        btnKeyPress.Text = "KeyPress"
        btnKeyPress.UseVisualStyleBackColor = True
        ' 
        ' btnInicio
        ' 
        btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnInicio.BackgroundImageLayout = ImageLayout.Stretch
        btnInicio.Cursor = Cursors.IBeam
        btnInicio.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnInicio.Image = My.Resources.Resources.Captura_de_pantalla_2024_09_30_212416
        btnInicio.Location = New Point(478, 219)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(130, 55)
        btnInicio.TabIndex = 8
        btnInicio.Text = "Ir a Inicio"
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnInicio)
        Controls.Add(btnKeyPress)
        Controls.Add(btnMouseMove)
        Controls.Add(btnMouseWheel)
        Controls.Add(btnMouseUp)
        Controls.Add(btnMouseEnter)
        Controls.Add(btnMouseDown)
        Controls.Add(btnMouseHover)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMouseHover As Button
    Friend WithEvents btnMouseDown As Button
    Friend WithEvents btnMouseEnter As Button
    Friend WithEvents btnMouseUp As Button
    Friend WithEvents btnMouseWheel As Button
    Friend WithEvents btnMouseMove As Button
    Friend WithEvents btnKeyPress As Button
    Friend WithEvents btnInicio As Button
End Class

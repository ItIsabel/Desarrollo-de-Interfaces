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
        btnSumar = New Button()
        Restar = New Button()
        btnExit = New Button()
        btnMultiplicar = New Button()
        btnDividir = New Button()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        lblNum1 = New Label()
        lblNum2 = New Label()
        btnClear = New Button()
        txtResultado = New TextBox()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' btnSumar
        ' 
        btnSumar.Location = New Point(556, 68)
        btnSumar.Name = "btnSumar"
        btnSumar.Size = New Size(94, 29)
        btnSumar.TabIndex = 0
        btnSumar.Text = "Sumar"
        btnSumar.UseVisualStyleBackColor = True
        ' 
        ' Restar
        ' 
        Restar.Location = New Point(556, 113)
        Restar.Name = "Restar"
        Restar.Size = New Size(94, 29)
        Restar.TabIndex = 1
        Restar.Text = "Restar"
        Restar.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(556, 294)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 2
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicar
        ' 
        btnMultiplicar.Location = New Point(556, 159)
        btnMultiplicar.Name = "btnMultiplicar"
        btnMultiplicar.Size = New Size(94, 29)
        btnMultiplicar.TabIndex = 3
        btnMultiplicar.Text = "Multiplicar"
        btnMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' btnDividir
        ' 
        btnDividir.Location = New Point(556, 209)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(94, 29)
        btnDividir.TabIndex = 4
        btnDividir.Text = "Dividir"
        btnDividir.UseVisualStyleBackColor = True
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(293, 91)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(125, 27)
        txtNum1.TabIndex = 5
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(293, 161)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(125, 27)
        txtNum2.TabIndex = 6
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Location = New Point(293, 68)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(68, 20)
        lblNum1.TabIndex = 7
        lblNum1.Text = "numero1"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Location = New Point(293, 137)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(72, 20)
        lblNum2.TabIndex = 8
        lblNum2.Text = "numero 2"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(293, 194)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 9
        btnClear.Text = "Borrar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(293, 294)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(125, 27)
        txtResultado.TabIndex = 10
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(289, 265)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(75, 20)
        lblResult.TabIndex = 11
        lblResult.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(txtResultado)
        Controls.Add(btnClear)
        Controls.Add(lblNum2)
        Controls.Add(lblNum1)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(btnDividir)
        Controls.Add(btnMultiplicar)
        Controls.Add(btnExit)
        Controls.Add(Restar)
        Controls.Add(btnSumar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSumar As Button
    Friend WithEvents Restar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResult As Label

End Class

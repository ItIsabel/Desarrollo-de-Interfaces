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
        grpClaseTrabajador = New GroupBox()
        btnTecnico = New RadioButton()
        rbtnAdministrativo = New RadioButton()
        rbtnObrero = New RadioButton()
        btnProfesional = New RadioButton()
        grpSindicato = New GroupBox()
        rbtnNo = New RadioButton()
        rbtnSi = New RadioButton()
        grpAnos = New GroupBox()
        rbtnmas10 = New RadioButton()
        rbtn5y10 = New RadioButton()
        rbmenos5 = New RadioButton()
        lblNum = New Label()
        NumHijs = New NumericUpDown()
        btnCalcular = New Button()
        btnClear = New Button()
        btnSalir = New Button()
        grpClaseTrabajador.SuspendLayout()
        grpSindicato.SuspendLayout()
        grpAnos.SuspendLayout()
        CType(NumHijs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpClaseTrabajador
        ' 
        grpClaseTrabajador.Controls.Add(btnTecnico)
        grpClaseTrabajador.Controls.Add(rbtnAdministrativo)
        grpClaseTrabajador.Controls.Add(rbtnObrero)
        grpClaseTrabajador.Location = New Point(42, 92)
        grpClaseTrabajador.Margin = New Padding(3, 4, 3, 4)
        grpClaseTrabajador.Name = "grpClaseTrabajador"
        grpClaseTrabajador.Padding = New Padding(3, 4, 3, 4)
        grpClaseTrabajador.Size = New Size(226, 155)
        grpClaseTrabajador.TabIndex = 0
        grpClaseTrabajador.TabStop = False
        grpClaseTrabajador.Text = "Clase de Trabajador"
        ' 
        ' btnTecnico
        ' 
        btnTecnico.AutoSize = True
        btnTecnico.Location = New Point(30, 91)
        btnTecnico.Margin = New Padding(3, 4, 3, 4)
        btnTecnico.Name = "btnTecnico"
        btnTecnico.Size = New Size(80, 24)
        btnTecnico.TabIndex = 2
        btnTecnico.TabStop = True
        btnTecnico.Text = "Tecnico"
        btnTecnico.UseVisualStyleBackColor = True
        ' 
        ' rbtnAdministrativo
        ' 
        rbtnAdministrativo.AutoSize = True
        rbtnAdministrativo.Location = New Point(30, 57)
        rbtnAdministrativo.Margin = New Padding(3, 4, 3, 4)
        rbtnAdministrativo.Name = "rbtnAdministrativo"
        rbtnAdministrativo.Size = New Size(127, 24)
        rbtnAdministrativo.TabIndex = 1
        rbtnAdministrativo.TabStop = True
        rbtnAdministrativo.Text = "Administrativo"
        rbtnAdministrativo.UseVisualStyleBackColor = True
        ' 
        ' rbtnObrero
        ' 
        rbtnObrero.AutoSize = True
        rbtnObrero.Location = New Point(30, 24)
        rbtnObrero.Margin = New Padding(3, 4, 3, 4)
        rbtnObrero.Name = "rbtnObrero"
        rbtnObrero.Size = New Size(77, 24)
        rbtnObrero.TabIndex = 0
        rbtnObrero.TabStop = True
        rbtnObrero.Text = "Obrero"
        rbtnObrero.UseVisualStyleBackColor = True
        ' 
        ' btnProfesional
        ' 
        btnProfesional.AutoSize = True
        btnProfesional.Location = New Point(72, 216)
        btnProfesional.Margin = New Padding(3, 4, 3, 4)
        btnProfesional.Name = "btnProfesional"
        btnProfesional.Size = New Size(104, 24)
        btnProfesional.TabIndex = 3
        btnProfesional.TabStop = True
        btnProfesional.Text = "Profesional"
        btnProfesional.UseVisualStyleBackColor = True
        ' 
        ' grpSindicato
        ' 
        grpSindicato.Controls.Add(rbtnNo)
        grpSindicato.Controls.Add(rbtnSi)
        grpSindicato.Location = New Point(331, 102)
        grpSindicato.Margin = New Padding(3, 4, 3, 4)
        grpSindicato.Name = "grpSindicato"
        grpSindicato.Padding = New Padding(3, 4, 3, 4)
        grpSindicato.Size = New Size(229, 145)
        grpSindicato.TabIndex = 4
        grpSindicato.TabStop = False
        grpSindicato.Text = "Inscrito en un Sindicato"
        ' 
        ' rbtnNo
        ' 
        rbtnNo.AutoSize = True
        rbtnNo.Location = New Point(23, 68)
        rbtnNo.Margin = New Padding(3, 4, 3, 4)
        rbtnNo.Name = "rbtnNo"
        rbtnNo.Size = New Size(50, 24)
        rbtnNo.TabIndex = 1
        rbtnNo.TabStop = True
        rbtnNo.Text = "No"
        rbtnNo.UseVisualStyleBackColor = True
        ' 
        ' rbtnSi
        ' 
        rbtnSi.AutoSize = True
        rbtnSi.Location = New Point(23, 35)
        rbtnSi.Margin = New Padding(3, 4, 3, 4)
        rbtnSi.Name = "rbtnSi"
        rbtnSi.Size = New Size(42, 24)
        rbtnSi.TabIndex = 0
        rbtnSi.TabStop = True
        rbtnSi.Text = "Si"
        rbtnSi.UseVisualStyleBackColor = True
        ' 
        ' grpAnos
        ' 
        grpAnos.Controls.Add(rbtnmas10)
        grpAnos.Controls.Add(rbtn5y10)
        grpAnos.Controls.Add(rbmenos5)
        grpAnos.Location = New Point(623, 102)
        grpAnos.Margin = New Padding(3, 4, 3, 4)
        grpAnos.Name = "grpAnos"
        grpAnos.Padding = New Padding(3, 4, 3, 4)
        grpAnos.Size = New Size(229, 145)
        grpAnos.TabIndex = 5
        grpAnos.TabStop = False
        grpAnos.Text = "Años de servicio"
        ' 
        ' rbtnmas10
        ' 
        rbtnmas10.AutoSize = True
        rbtnmas10.Location = New Point(0, 113)
        rbtnmas10.Margin = New Padding(3, 4, 3, 4)
        rbtnmas10.Name = "rbtnmas10"
        rbtnmas10.Size = New Size(98, 24)
        rbtnmas10.TabIndex = 2
        rbtnmas10.TabStop = True
        rbtnmas10.Text = "mas de 10"
        rbtnmas10.UseVisualStyleBackColor = True
        ' 
        ' rbtn5y10
        ' 
        rbtn5y10.AutoSize = True
        rbtn5y10.Location = New Point(0, 68)
        rbtn5y10.Margin = New Padding(3, 4, 3, 4)
        rbtn5y10.Name = "rbtn5y10"
        rbtn5y10.Size = New Size(107, 24)
        rbtn5y10.TabIndex = 1
        rbtn5y10.TabStop = True
        rbtn5y10.Text = "entre 5 y 10"
        rbtn5y10.UseVisualStyleBackColor = True
        ' 
        ' rbmenos5
        ' 
        rbmenos5.AutoSize = True
        rbmenos5.Location = New Point(0, 28)
        rbmenos5.Margin = New Padding(3, 4, 3, 4)
        rbmenos5.Name = "rbmenos5"
        rbmenos5.Size = New Size(107, 24)
        rbmenos5.TabIndex = 0
        rbmenos5.TabStop = True
        rbmenos5.Text = "menos de 5"
        rbmenos5.UseVisualStyleBackColor = True
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.Location = New Point(42, 318)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(119, 20)
        lblNum.TabIndex = 6
        lblNum.Text = "Numero de hijos"
        ' 
        ' NumHijs
        ' 
        NumHijs.Location = New Point(183, 311)
        NumHijs.Name = "NumHijs"
        NumHijs.Size = New Size(85, 27)
        NumHijs.TabIndex = 7
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(489, 447)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(94, 29)
        btnCalcular.TabIndex = 8
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(623, 447)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 9
        btnClear.Text = "Limpiar"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(758, 447)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 10
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(914, 600)
        Controls.Add(btnSalir)
        Controls.Add(btnClear)
        Controls.Add(btnCalcular)
        Controls.Add(NumHijs)
        Controls.Add(lblNum)
        Controls.Add(grpAnos)
        Controls.Add(grpSindicato)
        Controls.Add(btnProfesional)
        Controls.Add(grpClaseTrabajador)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        grpClaseTrabajador.ResumeLayout(False)
        grpClaseTrabajador.PerformLayout()
        grpSindicato.ResumeLayout(False)
        grpSindicato.PerformLayout()
        grpAnos.ResumeLayout(False)
        grpAnos.PerformLayout()
        CType(NumHijs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpClaseTrabajador As GroupBox
    Friend WithEvents rbtnObrero As RadioButton
    Friend WithEvents btnTecnico As RadioButton
    Friend WithEvents rbtnAdministrativo As RadioButton
    Friend WithEvents btnProfesional As RadioButton
    Friend WithEvents grpSindicato As GroupBox
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents grpAnos As GroupBox
    Friend WithEvents rbtnmas10 As RadioButton
    Friend WithEvents rbtn5y10 As RadioButton
    Friend WithEvents rbmenos5 As RadioButton
    Friend WithEvents lblNum As Label
    Friend WithEvents NumHijs As NumericUpDown
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSalir As Button

End Class

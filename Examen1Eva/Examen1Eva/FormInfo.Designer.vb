<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfo
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
        Panel1 = New Panel()
        grpTipoEvento = New GroupBox()
        rbCongreso = New RadioButton()
        rbJornada = New RadioButton()
        rbBanquete = New RadioButton()
        Panel2 = New Panel()
        Panel3 = New Panel()
        grpBanquete = New GroupBox()
        numComensalesMesa = New NumericUpDown()
        lblComensalesMesa = New Label()
        rbMesaRectangular = New RadioButton()
        rbMesaRedonda = New RadioButton()
        grpCongreso = New GroupBox()
        chkHabitaciones = New CheckBox()
        numJornadas = New NumericUpDown()
        lblJornadas = New Label()
        cmbCocina = New ComboBox()
        lblCocina = New Label()
        numPersonas = New NumericUpDown()
        lblPersonas = New Label()
        Panel1.SuspendLayout()
        grpTipoEvento.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        grpBanquete.SuspendLayout()
        CType(numComensalesMesa, ComponentModel.ISupportInitialize).BeginInit()
        grpCongreso.SuspendLayout()
        CType(numJornadas, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPersonas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(grpTipoEvento)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 311)
        Panel1.TabIndex = 0
        ' 
        ' grpTipoEvento
        ' 
        grpTipoEvento.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        grpTipoEvento.Controls.Add(rbCongreso)
        grpTipoEvento.Controls.Add(rbJornada)
        grpTipoEvento.Controls.Add(rbBanquete)
        grpTipoEvento.Location = New Point(12, 60)
        grpTipoEvento.Name = "grpTipoEvento"
        grpTipoEvento.Size = New Size(212, 165)
        grpTipoEvento.TabIndex = 0
        grpTipoEvento.TabStop = False
        grpTipoEvento.Text = "Tipo de Evento"
        ' 
        ' rbCongreso
        ' 
        rbCongreso.AutoSize = True
        rbCongreso.Location = New Point(41, 100)
        rbCongreso.Name = "rbCongreso"
        rbCongreso.Size = New Size(93, 24)
        rbCongreso.TabIndex = 2
        rbCongreso.TabStop = True
        rbCongreso.Text = "Congreso"
        rbCongreso.UseVisualStyleBackColor = True
        ' 
        ' rbJornada
        ' 
        rbJornada.AutoSize = True
        rbJornada.Location = New Point(41, 70)
        rbJornada.Name = "rbJornada"
        rbJornada.Size = New Size(82, 24)
        rbJornada.TabIndex = 1
        rbJornada.TabStop = True
        rbJornada.Text = "Jornada"
        rbJornada.UseVisualStyleBackColor = True
        ' 
        ' rbBanquete
        ' 
        rbBanquete.AutoSize = True
        rbBanquete.Location = New Point(41, 40)
        rbBanquete.Name = "rbBanquete"
        rbBanquete.Size = New Size(93, 24)
        rbBanquete.TabIndex = 0
        rbBanquete.TabStop = True
        rbBanquete.Text = "Banquete"
        rbBanquete.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(250, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(532, 311)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(grpBanquete)
        Panel3.Controls.Add(grpCongreso)
        Panel3.Controls.Add(cmbCocina)
        Panel3.Controls.Add(lblCocina)
        Panel3.Controls.Add(numPersonas)
        Panel3.Controls.Add(lblPersonas)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(532, 311)
        Panel3.TabIndex = 0
        ' 
        ' grpBanquete
        ' 
        grpBanquete.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        grpBanquete.Controls.Add(numComensalesMesa)
        grpBanquete.Controls.Add(lblComensalesMesa)
        grpBanquete.Controls.Add(rbMesaRectangular)
        grpBanquete.Controls.Add(rbMesaRedonda)
        grpBanquete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpBanquete.Location = New Point(263, 127)
        grpBanquete.Name = "grpBanquete"
        grpBanquete.Size = New Size(264, 181)
        grpBanquete.TabIndex = 5
        grpBanquete.TabStop = False
        grpBanquete.Text = "Detalles del Banquete"
        ' 
        ' numComensalesMesa
        ' 
        numComensalesMesa.Location = New Point(166, 101)
        numComensalesMesa.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        numComensalesMesa.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numComensalesMesa.Name = "numComensalesMesa"
        numComensalesMesa.Size = New Size(52, 27)
        numComensalesMesa.TabIndex = 3
        numComensalesMesa.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblComensalesMesa
        ' 
        lblComensalesMesa.AutoSize = True
        lblComensalesMesa.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblComensalesMesa.Location = New Point(6, 103)
        lblComensalesMesa.Name = "lblComensalesMesa"
        lblComensalesMesa.Size = New Size(154, 20)
        lblComensalesMesa.TabIndex = 2
        lblComensalesMesa.Text = "Comensales por mesa"
        ' 
        ' rbMesaRectangular
        ' 
        rbMesaRectangular.AutoSize = True
        rbMesaRectangular.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbMesaRectangular.Location = New Point(6, 63)
        rbMesaRectangular.Name = "rbMesaRectangular"
        rbMesaRectangular.Size = New Size(148, 24)
        rbMesaRectangular.TabIndex = 1
        rbMesaRectangular.TabStop = True
        rbMesaRectangular.Text = "Mesa Rectangular"
        rbMesaRectangular.UseVisualStyleBackColor = True
        ' 
        ' rbMesaRedonda
        ' 
        rbMesaRedonda.AutoSize = True
        rbMesaRedonda.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbMesaRedonda.Location = New Point(6, 33)
        rbMesaRedonda.Name = "rbMesaRedonda"
        rbMesaRedonda.Size = New Size(129, 24)
        rbMesaRedonda.TabIndex = 0
        rbMesaRedonda.TabStop = True
        rbMesaRedonda.Text = "Mesa Redonda"
        rbMesaRedonda.UseVisualStyleBackColor = True
        ' 
        ' grpCongreso
        ' 
        grpCongreso.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        grpCongreso.Controls.Add(chkHabitaciones)
        grpCongreso.Controls.Add(numJornadas)
        grpCongreso.Controls.Add(lblJornadas)
        grpCongreso.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCongreso.Location = New Point(6, 130)
        grpCongreso.Name = "grpCongreso"
        grpCongreso.Size = New Size(251, 169)
        grpCongreso.TabIndex = 4
        grpCongreso.TabStop = False
        grpCongreso.Text = "Detalles del Congreso"
        ' 
        ' chkHabitaciones
        ' 
        chkHabitaciones.AutoSize = True
        chkHabitaciones.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkHabitaciones.Location = New Point(6, 71)
        chkHabitaciones.Name = "chkHabitaciones"
        chkHabitaciones.Size = New Size(178, 24)
        chkHabitaciones.TabIndex = 2
        chkHabitaciones.Text = "Requiere habitaciones"
        chkHabitaciones.UseVisualStyleBackColor = True
        ' 
        ' numJornadas
        ' 
        numJornadas.Location = New Point(160, 35)
        numJornadas.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        numJornadas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numJornadas.Name = "numJornadas"
        numJornadas.Size = New Size(54, 27)
        numJornadas.TabIndex = 1
        numJornadas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblJornadas
        ' 
        lblJornadas.AutoSize = True
        lblJornadas.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJornadas.Location = New Point(6, 42)
        lblJornadas.Name = "lblJornadas"
        lblJornadas.Size = New Size(148, 20)
        lblJornadas.TabIndex = 0
        lblJornadas.Text = "Número de jornadas:"
        ' 
        ' cmbCocina
        ' 
        cmbCocina.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCocina.FormattingEnabled = True
        cmbCocina.Location = New Point(251, 77)
        cmbCocina.Name = "cmbCocina"
        cmbCocina.Size = New Size(151, 28)
        cmbCocina.TabIndex = 3
        ' 
        ' lblCocina
        ' 
        lblCocina.AutoSize = True
        lblCocina.Location = New Point(70, 80)
        lblCocina.Name = "lblCocina"
        lblCocina.Size = New Size(109, 20)
        lblCocina.TabIndex = 2
        lblCocina.Text = "Tipo de Cocina"
        ' 
        ' numPersonas
        ' 
        numPersonas.Location = New Point(251, 34)
        numPersonas.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        numPersonas.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        numPersonas.Name = "numPersonas"
        numPersonas.Size = New Size(151, 27)
        numPersonas.TabIndex = 1
        numPersonas.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' lblPersonas
        ' 
        lblPersonas.AutoSize = True
        lblPersonas.Location = New Point(70, 36)
        lblPersonas.Name = "lblPersonas"
        lblPersonas.Size = New Size(150, 20)
        lblPersonas.TabIndex = 0
        lblPersonas.Text = "Número de personas:"
        ' 
        ' FormInfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        ClientSize = New Size(782, 311)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormInfo"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        grpTipoEvento.ResumeLayout(False)
        grpTipoEvento.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        grpBanquete.ResumeLayout(False)
        grpBanquete.PerformLayout()
        CType(numComensalesMesa, ComponentModel.ISupportInitialize).EndInit()
        grpCongreso.ResumeLayout(False)
        grpCongreso.PerformLayout()
        CType(numJornadas, ComponentModel.ISupportInitialize).EndInit()
        CType(numPersonas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpTipoEvento As GroupBox
    Friend WithEvents rbBanquete As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rbCongreso As RadioButton
    Friend WithEvents rbJornada As RadioButton
    Friend WithEvents lblPersonas As Label
    Friend WithEvents numPersonas As NumericUpDown
    Friend WithEvents cmbCocina As ComboBox
    Friend WithEvents lblCocina As Label
    Friend WithEvents grpCongreso As GroupBox
    Friend WithEvents numJornadas As NumericUpDown
    Friend WithEvents lblJornadas As Label
    Friend WithEvents chkHabitaciones As CheckBox
    Friend WithEvents grpBanquete As GroupBox
    Friend WithEvents lblComensalesMesa As Label
    Friend WithEvents rbMesaRectangular As RadioButton
    Friend WithEvents rbMesaRedonda As RadioButton
    Friend WithEvents numComensalesMesa As NumericUpDown
End Class

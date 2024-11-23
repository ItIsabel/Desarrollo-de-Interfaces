<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHijoCustomizacion
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
        PanelCustom = New Panel()
        LabelCustomTitulo = New Label()
        Panel1 = New Panel()
        PanelHam2 = New Panel()
        Label2 = New Label()
        ListBoxHam2 = New CheckedListBox()
        PanelHam3 = New Panel()
        Label3 = New Label()
        ListBoxHam3 = New CheckedListBox()
        PanelHam1 = New Panel()
        ListBoxHam1 = New CheckedListBox()
        Label1 = New Label()
        Panel2 = New Panel()
        btnConfirmar = New Button()
        PanelCustom.SuspendLayout()
        Panel1.SuspendLayout()
        PanelHam2.SuspendLayout()
        PanelHam3.SuspendLayout()
        PanelHam1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelCustom
        ' 
        PanelCustom.Controls.Add(LabelCustomTitulo)
        PanelCustom.Dock = DockStyle.Top
        PanelCustom.Location = New Point(0, 0)
        PanelCustom.Name = "PanelCustom"
        PanelCustom.Size = New Size(857, 114)
        PanelCustom.TabIndex = 6
        ' 
        ' LabelCustomTitulo
        ' 
        LabelCustomTitulo.AutoSize = True
        LabelCustomTitulo.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        LabelCustomTitulo.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        LabelCustomTitulo.Location = New Point(25, 65)
        LabelCustomTitulo.Name = "LabelCustomTitulo"
        LabelCustomTitulo.Size = New Size(240, 29)
        LabelCustomTitulo.TabIndex = 4
        LabelCustomTitulo.Text = "lblcustomtitulo"
        LabelCustomTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PanelHam2)
        Panel1.Controls.Add(PanelHam3)
        Panel1.Controls.Add(PanelHam1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(857, 249)
        Panel1.TabIndex = 7
        ' 
        ' PanelHam2
        ' 
        PanelHam2.Controls.Add(Label2)
        PanelHam2.Controls.Add(ListBoxHam2)
        PanelHam2.Dock = DockStyle.Fill
        PanelHam2.Location = New Point(282, 0)
        PanelHam2.Name = "PanelHam2"
        PanelHam2.Size = New Size(277, 172)
        PanelHam2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label2.Location = New Point(6, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 29)
        Label2.TabIndex = 8
        Label2.Text = "hamburguesa 2"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListBoxHam2
        ' 
        ListBoxHam2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxHam2.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ListBoxHam2.FormattingEnabled = True
        ListBoxHam2.Location = New Point(6, 55)
        ListBoxHam2.Name = "ListBoxHam2"
        ListBoxHam2.Size = New Size(254, 114)
        ListBoxHam2.TabIndex = 7
        ' 
        ' PanelHam3
        ' 
        PanelHam3.Controls.Add(Label3)
        PanelHam3.Controls.Add(ListBoxHam3)
        PanelHam3.Dock = DockStyle.Right
        PanelHam3.Location = New Point(559, 0)
        PanelHam3.Name = "PanelHam3"
        PanelHam3.Size = New Size(298, 172)
        PanelHam3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label3.Location = New Point(16, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 29)
        Label3.TabIndex = 8
        Label3.Text = "hamburguesa 3"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListBoxHam3
        ' 
        ListBoxHam3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxHam3.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ListBoxHam3.FormattingEnabled = True
        ListBoxHam3.Location = New Point(16, 55)
        ListBoxHam3.Name = "ListBoxHam3"
        ListBoxHam3.Size = New Size(248, 114)
        ListBoxHam3.TabIndex = 7
        ' 
        ' PanelHam1
        ' 
        PanelHam1.Controls.Add(ListBoxHam1)
        PanelHam1.Controls.Add(Label1)
        PanelHam1.Dock = DockStyle.Left
        PanelHam1.Location = New Point(0, 0)
        PanelHam1.Name = "PanelHam1"
        PanelHam1.Size = New Size(282, 172)
        PanelHam1.TabIndex = 2
        ' 
        ' ListBoxHam1
        ' 
        ListBoxHam1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBoxHam1.BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ListBoxHam1.FormattingEnabled = True
        ListBoxHam1.Location = New Point(25, 52)
        ListBoxHam1.Name = "ListBoxHam1"
        ListBoxHam1.Size = New Size(233, 114)
        ListBoxHam1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        Label1.Location = New Point(25, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 29)
        Label1.TabIndex = 5
        Label1.Text = "hamburguesa 1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnConfirmar)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 172)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 77)
        Panel2.TabIndex = 1
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.BackColor = Color.FromArgb(CByte(240), CByte(56), CByte(19))
        btnConfirmar.FlatStyle = FlatStyle.Flat
        btnConfirmar.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Bold)
        btnConfirmar.ForeColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        btnConfirmar.Location = New Point(650, 12)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(195, 53)
        btnConfirmar.TabIndex = 7
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = False
        ' 
        ' FormHijoCustomizacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        ClientSize = New Size(857, 363)
        Controls.Add(Panel1)
        Controls.Add(PanelCustom)
        Name = "FormHijoCustomizacion"
        Text = "Form1"
        PanelCustom.ResumeLayout(False)
        PanelCustom.PerformLayout()
        Panel1.ResumeLayout(False)
        PanelHam2.ResumeLayout(False)
        PanelHam2.PerformLayout()
        PanelHam3.ResumeLayout(False)
        PanelHam3.PerformLayout()
        PanelHam1.ResumeLayout(False)
        PanelHam1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelCustom As Panel
    Friend WithEvents LabelCustomTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents PanelHam2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxHam2 As CheckedListBox
    Friend WithEvents PanelHam3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxHam3 As CheckedListBox
    Friend WithEvents PanelHam1 As Panel
    Friend WithEvents ListBoxHam1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class

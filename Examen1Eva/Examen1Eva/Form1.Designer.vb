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
        components = New ComponentModel.Container()
        PanelMain = New Panel()
        Label2 = New Label()
        btnExit = New Button()
        btnMaximize = New Button()
        btnMinimize = New Button()
        PanelMenu = New Panel()
        btnConfirmar = New Button()
        btnInfo = New Button()
        btnDatos = New Button()
        Label1 = New Label()
        PanelHijo = New Panel()
        ToolTip1 = New ToolTip(components)
        PanelMain.SuspendLayout()
        PanelMenu.SuspendLayout()
        PanelHijo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(140), CByte(170), CByte(162))
        PanelMain.Controls.Add(Label2)
        PanelMain.Controls.Add(btnExit)
        PanelMain.Controls.Add(btnMaximize)
        PanelMain.Controls.Add(btnMinimize)
        PanelMain.Dock = DockStyle.Top
        PanelMain.Location = New Point(0, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(800, 49)
        PanelMain.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 16.2F)
        Label2.ForeColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        Label2.Location = New Point(223, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 35)
        Label2.TabIndex = 3
        Label2.Text = "BK "
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnExit.Location = New Point(752, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(36, 37)
        btnExit.TabIndex = 2
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnMaximize.Location = New Point(705, 3)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(36, 37)
        btnMaximize.TabIndex = 1
        btnMaximize.Text = "🔲"
        btnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnMinimize.Location = New Point(663, 3)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(36, 37)
        btnMinimize.TabIndex = 0
        btnMinimize.Text = "-"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Controls.Add(btnConfirmar)
        PanelMenu.Controls.Add(btnInfo)
        PanelMenu.Controls.Add(btnDatos)
        PanelMenu.Dock = DockStyle.Top
        PanelMenu.Location = New Point(0, 49)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(800, 43)
        PanelMenu.TabIndex = 1
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConfirmar.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnConfirmar.FlatStyle = FlatStyle.Flat
        btnConfirmar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmar.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnConfirmar.Location = New Point(302, 0)
        btnConfirmar.Margin = New Padding(0)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(151, 42)
        btnConfirmar.TabIndex = 5
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = False
        ' 
        ' btnInfo
        ' 
        btnInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInfo.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnInfo.FlatStyle = FlatStyle.Flat
        btnInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInfo.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnInfo.Location = New Point(151, 0)
        btnInfo.Margin = New Padding(0)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(151, 42)
        btnInfo.TabIndex = 4
        btnInfo.Text = "+ info"
        btnInfo.UseVisualStyleBackColor = False
        ' 
        ' btnDatos
        ' 
        btnDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDatos.BackColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        btnDatos.FlatStyle = FlatStyle.Flat
        btnDatos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDatos.ForeColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        btnDatos.Location = New Point(0, 0)
        btnDatos.Margin = New Padding(0)
        btnDatos.Name = "btnDatos"
        btnDatos.Size = New Size(151, 42)
        btnDatos.TabIndex = 3
        btnDatos.Text = "Datos"
        btnDatos.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(68), CByte(135), CByte(143))
        Label1.Location = New Point(178, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(452, 35)
        Label1.TabIndex = 2
        Label1.Text = "Haz tu reserva con nosotros"
        ' 
        ' PanelHijo
        ' 
        PanelHijo.Controls.Add(Label1)
        PanelHijo.Dock = DockStyle.Fill
        PanelHijo.Location = New Point(0, 92)
        PanelHijo.Name = "PanelHijo"
        PanelHijo.Size = New Size(800, 358)
        PanelHijo.TabIndex = 3
        ' 
        ' ToolTip1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(233), CByte(202))
        ClientSize = New Size(800, 450)
        Controls.Add(PanelHijo)
        Controls.Add(PanelMenu)
        Controls.Add(PanelMain)
        Name = "Form1"
        Text = "Form1"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        PanelMenu.ResumeLayout(False)
        PanelHijo.ResumeLayout(False)
        PanelHijo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDatos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelHijo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnConfirmar As Button

End Class

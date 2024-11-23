Imports FontAwesome.Sharp
Imports System.Runtime.InteropServices
Imports System.Xml
Public Class Form1

    ' Campos
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor
    Public Sub New()
        ' Esta llamada es requerida por el diseñador.
        Try
            InitializeComponent()
        Catch ex As Exception

        End Try
        ' Agregue cualquier inicialización después de la llamada InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 49)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Formulario principal
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub
    'Métodos
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(32, 231, 171)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(27, 193, 143)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Abrir un solo formulario
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub

    'Eventos
    'Reset
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    'Menu buttons Clics
    Private Sub Iconbtn_Lactancia_Click(sender As Object, e As EventArgs) Handles Iconbtn_Lactancia.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormLactancia)
    End Sub

    Private Sub iconbtn_Productos_Click(sender As Object, e As EventArgs) Handles iconbtn_Productos.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormProductos)
    End Sub

    Private Sub btnEducacion_Click(sender As Object, e As EventArgs) Handles btnEducacion.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormEducacion)
    End Sub

    Private Sub btnDesarrollo_Click(sender As Object, e As EventArgs) Handles btnDesarrollo.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormDesarrolo)
    End Sub

    Private Sub btnContacto_Click(sender As Object, e As EventArgs) Handles btnContacto.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormContacto)
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnFAQ.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        OpenChildForm(New FormAyuda)
    End Sub


    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Close-Maximize-Minimize
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Eliminar borde transparente en estado maximizado
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Public Structure RGBColors
        Public Shared colorOscuro As Color = Color.FromArgb(56, 75, 66)
        Public Shared colorSelec As Color = Color.FromArgb(32, 231, 171)
        Public Shared colorClaro As Color = Color.FromArgb(27, 193, 143)
    End Structure
End Class

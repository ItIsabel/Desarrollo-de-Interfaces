Imports FontAwesome.Sharp


Public Class FormPpal
    Private currentBtn As IconButton

    'metodos'
    Private Sub OcultarSubMenu()
        PanelSubmenu.Visible = False
    End Sub
    Private Sub MostrarSubMenu()
        PanelSubmenu.Visible = True
    End Sub

    'Gestion de botones superiores panel inicio
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'gestion paneles hijos
    Private FormularioActual As Form = Nothing

    Private Sub abrirformularioshijos(formularioHijo As Form)
        If Not FormularioActual Is Nothing Then
            FormularioActual.Close()
        End If

        FormularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        PanelHijo.Controls.Add(formularioHijo)
        PanelHijo.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub

    Private Sub btnCustomizacion_Click(sender As Object, e As EventArgs) Handles btnCustomizacion.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormHijoCustomizacion)
        MostrarSubMenu()

    End Sub

    Private Sub btnEnvio_Click(sender As Object, e As EventArgs) Handles btnEnvio.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormHIjoEnvio)
        MostrarSubMenu()

    End Sub
    Private Sub btnSeleccion_Click(sender As Object, e As EventArgs) Handles btnSeleccion.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormHijoSeleccion)
        MostrarSubMenu()

    End Sub
    Private Sub btnConfirmacion_Click(sender As Object, e As EventArgs) Handles btnConfirmacion.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormHijoConfirmacion)
        MostrarSubMenu()

    End Sub

    Public Structure RGBColors
        Public Shared colorOscuro As Color = Color.FromArgb(56, 75, 66)
        Public Shared colormedio As Color = Color.FromArgb(240, 56, 19)
        Public Shared colorNaranja As Color = Color.FromArgb(255, 136, 38)
        Public Shared colorClaro As Color = Color.FromArgb(255, 185, 20)
        Public Shared colorContraste As Color = Color.FromArgb(44, 159, 163)

    End Structure

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = RGBColors.colorContraste
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = RGBColors.colorNaranja
            currentBtn.ForeColor = RGBColors.colorClaro
            currentBtn.IconColor = RGBColors.colorClaro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
    End Sub


End Class

Public Class Form1
    Dim miToolTip As New ToolTip
    Private currentBtn As Button


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miToolTip.SetToolTip(btnDatos, "Dinos tus datos y la fecha")
        miToolTip.SetToolTip(btnInfo, "Indicanos mas detalles sobre el evento")
        miToolTip.SetToolTip(btnConfirmar, "Aqui aparecen todos los datos")

        ' Configuración opcional del tooltip
        miToolTip.AutoPopDelay = 5000    ' Tiempo que permanece visible (5 segundos)
        miToolTip.InitialDelay = 1000    ' Retraso inicial antes de mostrar
        miToolTip.ReshowDelay = 500      ' Retraso antes de mostrar de nuevo
        miToolTip.ShowAlways = True      ' Mostrar siempre, incluso si la ventana no está activa
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


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

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

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = RGBColors.colorContraste
            currentBtn.ForeColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = RGBColors.colorOscuro
            currentBtn.ForeColor = RGBColors.colorClaro
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub MostrarSubMenu()
        PanelMenu.Visible = True
    End Sub
    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormDatos)
    End Sub


    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormInfo)
        MostrarSubMenu()

    End Sub


    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ActivateButton(sender, RGBColors.colorOscuro)
        abrirformularioshijos(New FormConfirmar)
        MostrarSubMenu()
    End Sub

    Public Structure RGBColors
        Public Shared colorOscuro As Color = Color.FromArgb(68, 135, 143)
        Public Shared colorSelec As Color = Color.FromArgb(140, 170, 162)
        Public Shared colorClaro As Color = Color.FromArgb(205, 233, 202)
        Public Shared colorContraste As Color = Color.FromArgb(255, 133, 145)

    End Structure
End Class

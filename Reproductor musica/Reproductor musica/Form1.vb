Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
    End Sub

    'Método para ocultar los submenús
    Private Sub OcultarSubMenu()
        PanelArchivo.Visible = False
        PanelGaleria.Visible = False
    End Sub

    Private Sub MostrarSubMenu(submenu As Panel) 'Como todos los submenús son paneles creamos un parámetro de tipo panel
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private FormularioActual As Form = Nothing 'Creamos una variable de valor nulo para albergar el formulario que se abre

    Private Sub abrirformularioshijos(formularioHijo As Form) 'Creamos un parámetro que es de tipo formulario
        If Not FormularioActual Is Nothing Then
            FormularioActual.Close()
        End If
        FormularioActual = formularioHijo 'Guardamos en la variable el formulario hijo
        formularioHijo.TopLevel = False 'El formulario no es de nivel superior, se comportará como un control
        formularioHijo.FormBorderStyle = FormBorderStyle.None 'Quitamos el borde del formulario
        formularioHijo.Dock = DockStyle.Fill
        PanelHijo.Controls.Add(formularioHijo) 'Añadimos la lista de controles al panel contenedor
        PanelHijo.Tag = formularioHijo 'Asociamos el formulario con el panel contenedor
        formularioHijo.BringToFront() 'Llevamos al formulario al frente, ya que hemos puesto unaimagen
        formularioHijo.Show() 'Mostramos el formulario hijo

    End Sub

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        MostrarSubMenu(PanelArchivo)
    End Sub

    Private Sub btnGaleria_Click(sender As Object, e As EventArgs) Handles btnGaleria.Click
        MostrarSubMenu(PanelGaleria)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrirformularioshijos(New FormBuscar)
        OcultarSubMenu()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        abrirformularioshijos(New FormGuardar)
        OcultarSubMenu()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        abrirformularioshijos(New FormImportar)
        OcultarSubMenu()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        OcultarSubMenu()
        End
    End Sub

    Private Sub btnFotos_Click(sender As Object, e As EventArgs) Handles btnMultimedia.Click
        OcultarSubMenu()
    End Sub

    Private Sub btnVideo_Click(sender As Object, e As EventArgs) Handles btnVideo.Click
        OcultarSubMenu()
    End Sub

    Private Sub btnMultimedia_Click(sender As Object, e As EventArgs) Handles btnMultimedia.Click
        OcultarSubMenu()
    End Sub

    Private Sub btnMaximiza_Click(sender As Object, e As EventArgs) Handles btnMaximiza.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimiza_Click(sender As Object, e As EventArgs) Handles btnMinimiza.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class



Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Microsoft.Win32

Public Class FormHIjoEnvio
    Private Sub btnPedir_Click(sender As Object, e As EventArgs) Handles btnPedir.Click
        If txtNombre.Text = "" Or txtTlf.Text = "" Or txtDireccion.Text = "" Or txtTlf.Text = "" Then
            MessageBox.Show("Por favor, introduce todos los datos para que podamos entregarte tu pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡Gracias!" + vbCrLf + "Por favor, pasa a la pestaña de confirmacion para confirmar tu pedido", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ModuloInfonumProd.Direccion = "Nombre" + txtNombre.Text + vbCrLf + "telefono" + txtTlf.Text + vbCrLf + "Direccion" + txtDireccion.Text

        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNombre.Clear()
        txtTlf.Clear()
        txtDireccion.Clear()
    End Sub

    Private Sub FormHIjoEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloInfonumProd.Direccion = ""

    End Sub
End Class


Imports System.Globalization

Public Class FormDatos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        ' Aquí puedes agregar el código para guardar los datos
        Dim nombre = txtNombre.Text
        Dim telefono = txtTlf.Text
        Dim fechaSeleccionada = Calendario.SelectionStart

        MessageBox.Show("Datos guardados: " & vbCrLf &
                       "Nombre: " & nombre & vbCrLf &
                       "Teléfono: " & telefono & vbCrLf &
                       "Fecha: " & fechaSeleccionada.ToString("dd/MM/yyyy"))
    End Sub
End Class
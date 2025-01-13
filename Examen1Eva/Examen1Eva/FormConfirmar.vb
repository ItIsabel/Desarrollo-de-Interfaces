Public Class FormConfirmar
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.GuardarDatosEvento(FormInfo)
        txtPeticion.Text = Module1.ObtenerResumenEvento

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            ' Crear o sobreescribir el archivo
            Using writer As New System.IO.StreamWriter("peticion_evento.txt")
                writer.Write(txtPeticion.Text)
            End Using
            MessageBox.Show("Petición guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la petición: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            ' Verificar si existe el archivo
            If System.IO.File.Exists("peticion_evento.txt") Then
                ' Leer el archivo
                Using reader As New System.IO.StreamReader("peticion_evento.txt")
                    txtPeticion.Text = reader.ReadToEnd()
                End Using
                MessageBox.Show("Petición recuperada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No hay petición guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al recuperar la petición: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
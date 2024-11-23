Public Class FormBuscar
    Dim ofd As New OpenFileDialog
    Dim ruta As String
    Private Sub abrir()
        Try
            ' Configura múltiples filtros y extensiones comunes de audio
            ofd.Filter = "Archivos de Audio|*.mp3;*.wav;*.wma;*.m4a|MP3|*.mp3|WAV|*.wav|WMA|*.wma|M4A|*.m4a|Todos los archivos|*.*"
            ofd.Title = "Seleccionar archivo de audio"

            If ofd.ShowDialog() = DialogResult.OK Then
                ruta = ofd.FileName

                ' Verifica que el archivo existe
                If System.IO.File.Exists(ruta) Then
                    Form1.AxWindowsMediaPlayer1.URL = ruta
                    Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()

                    ' Evita duplicados en el ListBox
                    If Not ListBoxBuscar.Items.Contains(ruta) Then
                        ListBoxBuscar.Items.Add(ruta)
                    End If
                Else
                    MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al abrir el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrir()
    End Sub

    Private Sub ListBoxBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBuscar.SelectedIndexChanged

    End Sub
End Class
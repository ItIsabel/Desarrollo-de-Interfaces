Public Class FormGuardar
    Dim ofd As New OpenFileDialog
    Dim ruta As String
    Sub abrir()
        ofd.Filter = "Musica en MP3 | *.mp3;"
        If ofd.ShowDialog = DialogResult.OK Then
            ruta = ofd.FileName
            Form1.AxWindowsMediaPlayer1.URL = ruta
            Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
            ListBoxGuardar.Items.Add(ruta)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo de texto | *.txt"
        If save.ShowDialog = DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(save.FileName)
            For Each item In ListBoxGuardar.Items
                sw.WriteLine(item.ToString)
            Next
            sw.Close()
        End If
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        abrir()
    End Sub
End Class
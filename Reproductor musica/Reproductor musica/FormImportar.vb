Public Class FormImportar
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim stRuta As String = ""
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text (*.Text*.txt|*.Text;*.txt|Todos los archivos(*.*)|*.*)"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
            If .ShowDialog = DialogResult.OK Then
                stRuta = .FileName
            End If
        End With
        Dim sr As New System.IO.StreamReader(stRuta)
            While Not sr.EndOfStream
                ListBoxImportar.Items.Add(sr.ReadLine())
            End While
            sr.Close()
End Sub

    Private Sub ListBoxImportar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxImportar.SelectedIndexChanged
        Form1.AxWindowsMediaPlayer1.URL = ListBoxImportar.SelectedItem.ToString
        Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

End Class
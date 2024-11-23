Imports System.IO
Public Class Form1

    Private Sub btnAbrirImagen_Click(sender As Object, e As EventArgs) Handles btnAbrirImagen.Click
        OpenFileDialog1.Title = "Seleccione un archivo" ' Título del cuadro de diálogo
        OpenFileDialog1.FileName = "" ' Archivo por defecto
        OpenFileDialog1.InitialDirectory = "c:\" ' Directorio que abre por defecto
        OpenFileDialog1.Filter = "Archivos de imagen | *.jpg; *.png; *.gif | Otros | *.*" ' Tipos de archivos que filtra

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then ' si el cuadro de diálogo le damos a ok
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName) ' La imagen del picturebox la tome de la ruta que le va a pasar el cuadro de diálogo
        End If
    End Sub

    Private Sub btnGuardarImagen_Click(sender As Object, e As EventArgs) Handles btnGuardarImagen.Click
        SaveFileDialog1.CreatePrompt = True ' Pregunta si quieres guardar la imagen
        SaveFileDialog1.FileName = "" ' No especificamos ningún nombre
        SaveFileDialog1.Filter = "Archivos de imagen | *.jpg; *.png; *.gif"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName) ' especificamos la ruta elegida en el savefiledialog
        End If
    End Sub

    Private Sub btnAbrirTexto_Click(sender As Object, e As EventArgs) Handles btnAbrirTexto.Click
        OpenFileDialog1.Title = "Seleccione un archivo" ' Título del cuadro de diálogo
        OpenFileDialog1.FileName = "" ' Archivo por defecto
        OpenFileDialog1.InitialDirectory = "c:\" ' Directorio que abre por defecto
        OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" ' Tipos de archivos que filtra

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then ' si el cuadro de diálogo le damos a ok
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName) ' pasamos el contenido del textbox al Openfiledialog
        End If
    End Sub

    Private Sub btnGuardarTexto_Click(sender As Object, e As EventArgs) Handles btnGuardarTexto.Click
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Documento word (*.doc)|*.doc|Documento plano (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2 ' Documento word sería el index 1 y Documento plano sería index 2

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text) ' Pasamos el contenido del textbox al savefiledialog
        End If
    End Sub

    Private Sub btnAbrirRuta_Click(sender As Object, e As EventArgs) Handles btnAbrirRuta.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxRuta.Text = FolderBrowserDialog1.SelectedPath

            For Each folder As String In Directory.GetDirectories(TextBoxRuta.Text)
                ListDirectorios.Items.Add(folder) ' La ruta de cada carpeta
            Next
        End If
    End Sub

    Private Sub ListDirectorios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDirectorios.SelectedIndexChanged
        Dim directorio As New DirectoryInfo(ListDirectorios.SelectedItem.ToString) ' Declaramos una variable para contener el directorio
        Dim nombreArchivo As FileInfo() = directorio.GetFiles ' Declaramos una variable para contener el nombre del archivo

        ' Limpiamos el listArchivos
        For i As Integer = 0 To ListArchivos.Items.Count - 1
            ListArchivos.Items.RemoveAt(ListArchivos.Items.Count - 1)
        Next

        ' Llenamos el listArchivos
        For Each file As FileInfo In nombreArchivo
            ListArchivos.Items.Add(file.Name)
        Next
    End Sub
End Class

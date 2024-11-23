Imports System.Windows.Forms

Public Class Form1
    Dim max As Boolean = False
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If max = False Then
            WindowState = FormWindowState.Maximized
            max = True
        Else
            WindowState = FormWindowState.Normal
            max = False
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Cuando abrimos el formulario hará lo siguiente
        Try
            cbFuentes.Items.Clear() 'Borra todo los item que tenga el comboBox
            For Each fuentes As FontFamily In FontFamily.Families ' Instalar las fuentes que tenemos en nuestro pc
                Dim tipo As String ' las fuentes se guardan en la variable tipo
                tipo = fuentes.Name
                cbFuentes.Items.Add(tipo) 'Va añadir las fuentes en el comboBox
            Next
            'Try
            cbFuentes.Text = "Calibri" 'Fuente por defecto
            pbColor.BackColor = Color.Black

        Catch ex As Exception
            cbFuentes.SelectedItem = 0 'Si da error que coloque la primera
        End Try
        ' Catch ex As Exception
        ' End Try
    End Sub

    Private Sub cbFuentes_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cbFuentes.DrawItem
        'Se produce cuando cambia la apariencia de un control

        e.DrawBackground() 'Proporciona datos para el DrawItemevento.

        'Este código sirve para que cada elemento del cmboBox tenga un estilo diferente, si es calibri que sea calibri...
        Dim texto As String = cbFuentes.Items(e.Index).ToString
        Dim fon As New Font(texto, e.Font.Size)
        e.Graphics.DrawString(texto, fon, New SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2)
        e.DrawFocusRectangle()
    End Sub

    Private Sub cbFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuentes.SelectedIndexChanged
        If negrita = True Then
            RichTextBox1.SelectionFont = New Font(cbFuentes.SelectedItem.ToString, Int(txtSize.Text), FontStyle.Bold)
        Else
            RichTextBox1.SelectionFont = New Font(cbFuentes.SelectedItem.ToString, Int(txtSize.Text), FontStyle.Regular)
        End If
    End Sub

    Dim negrita As Boolean = False 'En inicio deshabilitadas
    Dim cursiva As Boolean = False

    Private Sub lblNegrita_Click(sender As Object, e As EventArgs) Handles lblNegrita.Click

        If negrita = False Then
            'cuando seleccionamos un texto solo le apliquemos ese estilo de fuente
            RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Bold)
            lblNegrita.ForeColor = Color.Chocolate
            negrita = True
        Else
            RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Regular)
            lblNegrita.ForeColor = Color.Black
            negrita = False
        End If

    End Sub

    Private Sub lblCursiva_Click(sender As Object, e As EventArgs) Handles lblCursiva.Click
        Try
            If cursiva = True Then
                RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Italic)
                lblCursiva.ForeColor = Color.Chocolate
                cursiva = False
            Else
                RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Regular)
                lblCursiva.ForeColor = Color.Black
                cursiva = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSize_TextChanged(sender As Object, e As EventArgs) Handles txtSize.TextChanged
        Try
            If negrita = True Then
                RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Bold)
            Else
                RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pbColor_Click(sender As Object, e As EventArgs) Handles pbColor.Click
        Try
            Dim dig As ColorDialog = New ColorDialog 'en la variable dig se almacenará el color que se ha elegido
            dig.Color = RichTextBox1.SelectionColor

            If dig.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionColor = dig.Color

                pbColor.BackColor = dig.Color
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        lblPorcentaje.Text = TrackBar1.Value * 100 & "%"
        RichTextBox1.ZoomFactor = TrackBar1.Value
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog
        Dim MyStreamReader As System.IO.StreamReader
        Open.Filter = "text (*.txt)|*.txt|All Files(*.*)|*.*"
        Open.CheckFileExists = True
        Open.Title = "Abrir como"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            MyStreamReader = System.IO.File.OpenText(Open.FileName)
            RichTextBox1.Text = MyStreamReader.ReadToEnd()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Dim MyStreamWriter As System.IO.StreamWriter 'variable tipo escritura
        save.Filter = "text (*.txt)|*.txt|Html (*.html*)|*.html|php(*.php*)|*.php*|All Files(*.*)|*.*"
        save.CheckFileExists = False
        save.Title = "Guardar como"
        save.ShowDialog(Me)
        Try
            MyStreamWriter = System.IO.File.AppendText(save.FileName)
            MyStreamWriter.Write(RichTextBox1.Text)
            MyStreamWriter.Flush()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Dim estado As Integer = 0
    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        Try
            cbFuentes.Text = RichTextBox1.SelectionFont.Name
            txtSize.Text = RichTextBox1.SelectionFont.Size
            estado = RichTextBox1.SelectionFont.Style
            If estado = 0 Then
                lblNegrita.ForeColor = Color.Black
                lblCursiva.ForeColor = Color.Black
            ElseIf estado = 1 Then
                lblNegrita.ForeColor = Color.Orange
                lblCursiva.ForeColor = Color.Black
            ElseIf estado = 2 Then
                lblNegrita.ForeColor = Color.Black
                lblCursiva.ForeColor = Color.Orange

            End If
            pbColor.BackColor = RichTextBox1.SelectionColor
        Catch ex As Exception

        End Try
    End Sub

End Class

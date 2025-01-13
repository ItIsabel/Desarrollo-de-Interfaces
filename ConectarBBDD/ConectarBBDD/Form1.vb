Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet1.Personas' Puede moverla o quitarla según sea necesario.
        Me.PersonasTableAdapter.Fill(Me.ClientesDataSet1.Personas)

    End Sub
    Public Structure RGBColors
        Public Shared colorOscuro As Color = Color.FromArgb(13, 19, 33)
        Public Shared colorSelec As Color = Color.FromArgb(197, 216, 109)
        Public Shared colorClaro As Color = Color.FromArgb(255, 237, 223)
        Public Shared colorMedio As Color = Color.FromArgb(134, 97, 92)
    End Structure

End Class

Public Class Form2
    Private Sub btnMouseEnter_Enter(sender As Object, e As EventArgs) Handles btnMouseEnter.Enter
        btnMouseEnter.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnMouseDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMouseDown.MouseDown
        btnMouseDown.BackgroundImage = Image.FromFile("C:\Users\isabe\source\repos\Ej_4\Resources\Captura de pantalla 2024-09-30 212416.png")

    End Sub

    Private Sub btnMouseHover_MouseHover(sender As Object, e As EventArgs) Handles btnMouseHover.MouseHover
        btnMouseHover.Text = "Esto es hover"
    End Sub

    Private Sub btnMouseHover_Leave(sender As Object, e As EventArgs) Handles btnMouseHover.Leave
        btnMouseHover.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnMouseUp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMouseUp.MouseUp
        btnMouseUp.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnMouseMove_Move(sender As Object, e As EventArgs) Handles btnMouseMove.Move
        btnMouseMove.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnMouseWheel_MouseWheel(sender As Object, e As MouseEventArgs) Handles btnMouseWheel.MouseWheel
        btnMouseWheel.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnKeyPress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnKeyPress.KeyPress
        btnKeyPress.BackColor = Color.AliceBlue
    End Sub
End Class
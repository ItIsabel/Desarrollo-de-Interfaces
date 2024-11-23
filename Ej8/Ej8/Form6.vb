Public Class FormContacto
    Private Sub btnContacto_Click(sender As Object, e As EventArgs) Handles btnContacto.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtMail.Text = "" Or txtTlf.Text = "" Then
            MessageBox.Show("Por favor, introduce todos los datos para que podamos contactarte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Sus datos han sido enviados y pronto será contactado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNombre.Clear()
        txtApellido.Clear()
        txtMail.Clear()
        txtTlf.Clear()
    End Sub
End Class
Public Class Form1
    Dim ruta = My.Computer.FileSystem.CurrentDirectory & "\pedido.txt"
    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        ListBox1.Items.Add(txtNombre.Text)
        ListBox1.Items.Add(txtTlf.Text)
        ListBox1.Items.Add(txtAddress.Text)
        ListBox1.Items.Add(txtPedido.Text)

        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Nombre: " & txtNombre.Text & " Teléfono: " & txtTlf.Text & " Dirección: " & txtAddress.Text & " Pedido: " & txtPedido.Text & vbCrLf, True)
        MessageBox.Show("Información del pedido guardado")
    End Sub
    Private Sub btnLimpiarPedido_Click(sender As Object, e As EventArgs) Handles btnLimpiarPedido.Click
        txtNombre.Clear()
        txtTlf.Clear()
        txtAddress.Clear()
        txtPedido.Clear()
        ListBox1.Items.Clear()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

End Class

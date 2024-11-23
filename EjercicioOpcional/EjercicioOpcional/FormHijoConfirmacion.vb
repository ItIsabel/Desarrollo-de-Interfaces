Public Class FormHijoConfirmacion
    Private Sub FormHijoConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPedido.Text = ModuloInfonumProd.PedidoToString
        TextBoxDireccion.Text = ModuloInfonumProd.Direccion


    End Sub


End Class
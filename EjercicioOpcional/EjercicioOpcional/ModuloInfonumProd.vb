Module ModuloInfonumProd
    Public nHamburguesas As String
    Public nNugets As String
    Public nPatatas As String
    Public Direccion As String
    Public Pedido As New List(Of Hamburguesa)  '


    Public Function PedidoToString() As String
        Dim resumenPedido As New System.Text.StringBuilder()
        resumenPedido.AppendLine("---------------------------")

        For i As Integer = 0 To ModuloInfonumProd.Pedido.Count - 1
            resumenPedido.AppendLine(ModuloInfonumProd.Pedido(i).ToString)
        Next
        If ModuloInfonumProd.nPatatas <> 0 Then
            resumenPedido.AppendLine(ModuloInfonumProd.nPatatas + "x Patatas")
        End If
        If ModuloInfonumProd.nNugets <> 0 Then
            resumenPedido.AppendLine(ModuloInfonumProd.nNugets + "x Nugets")
        End If
        resumenPedido.AppendLine("---------------------------")
        Return resumenPedido.ToString

    End Function
End Module

Public Class FormHijoCustomizacion
    Private Sub FormHijoCustomizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializar los CheckedListBox con los ingredientes
        InicializarListBox(ListBoxHam1)
        InicializarListBox(ListBoxHam2)
        InicializarListBox(ListBoxHam3)
        ModuloInfonumProd.Pedido.Clear()

        'Customizar las hamburguesas
        If (ModuloInfonumProd.nHamburguesas <> 0) Then
            Select Case ModuloInfonumProd.nHamburguesas
                Case 1
                    LabelCustomTitulo.Text = "Customiza tu hamburguesa"
                    PanelHam2.Visible = False
                    PanelHam3.Visible = False
                Case 2
                    LabelCustomTitulo.Text = "Customiza tus 2 hamburguesas"
                    PanelHam3.Visible = False
                Case 3
                    LabelCustomTitulo.Text = "Customiza tus 3 hamburguesas"
                Case Else
                    LabelCustomTitulo.Text = "Lo sentimos, no hay hamburguesas para customizar"
                    PanelHam1.Visible = False
                    PanelHam2.Visible = False
                    PanelHam3.Visible = False
            End Select
        Else 'Si no se han elegido hamburguesas en el apartado anterior
            LabelCustomTitulo.Text = "Lo sentimos, no hay hamburguesas para customizar"
            PanelHam1.Visible = False
            PanelHam2.Visible = False
            PanelHam3.Visible = False
        End If

    End Sub

    ' Función para inicializar el ListBox con los ingredientes
    Private Sub InicializarListBox(listBox As CheckedListBox)
        listBox.Items.Clear() ' Limpiar items existentes
        listBox.Items.AddRange({"Queso", "Lechuga", "Tomate", "Pepinillo", "Mostaza"})
    End Sub

    'Función que devuelve una hamburguesa con la elección de los ingredientes
    Private Function CrearHamburguesa(listBox As CheckedListBox, id As Integer) As Hamburguesa
        Dim Ham = New Hamburguesa(id)
        For i As Integer = 0 To listBox.CheckedItems.Count - 1
            Ham.Ingredientes.Add(listBox.CheckedItems(i).ToString())
        Next
        Return Ham
    End Function

    ' Botón o evento para confirmar la selección
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Select Case ModuloInfonumProd.nHamburguesas
            Case 1
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam1, 1))
            Case 2
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam1, 1))
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam2, 2))
            Case 3
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam1, 1))
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam2, 2))
                ModuloInfonumProd.Pedido.Add(CrearHamburguesa(ListBoxHam3, 3))
        End Select

        ' Verificar que se hayan creado correctamente
        If ModuloInfonumProd.Pedido.Count > 0 Then
            MessageBox.Show("Pedido customizado con éxito!, por favor dinos dónde te lo mandamos en el botón Envio")
            ' Aquí puedes agregar código para cerrar el form o pasar al siguiente paso
        Else
            MessageBox.Show("Error al crear el pedido. Por favor, intente nuevamente.")
        End If
    End Sub
End Class
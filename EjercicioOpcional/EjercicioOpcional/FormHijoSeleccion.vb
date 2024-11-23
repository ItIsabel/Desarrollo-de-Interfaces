Imports System.Linq.Expressions

Public Class FormHijoSeleccion
    Private Sub FormHijoSeleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el valor del label (opcional)
        lblHamburguesa.Text = "0"
        lblNuget.Text = "0"
        lblPatata.Text = "0"
        ModuloInfonumProd.nHamburguesas = 0
        ModuloInfonumProd.nPatatas = 0
        ModuloInfonumProd.nNugets = 0
        ModuloInfonumProd.Pedido.Clear()

    End Sub
    ' Incrementa el valor del label en 1
    Private Sub btnMasHamburg_Click(sender As Object, e As EventArgs) Handles btnMasHamburg.Click
        Dim valorActual As Integer = Integer.Parse(lblHamburguesa.Text)
        If (valorActual < 3) Then
            valorActual += 1
            lblHamburguesa.Text = valorActual.ToString()
            GuardarValor(lblHamburguesa)
        Else MessageBox.Show("Cantidad máxima por pedido: 3", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnMasPatata_Click(sender As Object, e As EventArgs) Handles btnMasPatata.Click
        Dim valorActual As Integer = Integer.Parse(lblPatata.Text)
        If (valorActual < 2) Then
            valorActual += 1
            lblPatata.Text = valorActual.ToString()
            GuardarValor(lblPatata)
        Else MessageBox.Show("Cantidad máxima por pedido: 2", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnMasNuget_Click(sender As Object, e As EventArgs) Handles btnMasNuget.Click
        Dim valorActual As Integer = Integer.Parse(lblNuget.Text)
        If (valorActual < 2) Then
            valorActual += 1
            lblNuget.Text = valorActual.ToString()
            GuardarValor(lblNuget)
        Else MessageBox.Show("Cantidad máxima por pedido: 2", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    ' Decrementa el valor del label en 1
    Private Sub btnMenosHamburg_Click(sender As Object, e As EventArgs) Handles btnMenosHamburg.Click
        Dim valorActual As Integer = Integer.Parse(lblHamburguesa.Text)
        If (valorActual > 0) Then
            valorActual -= 1
            lblHamburguesa.Text = valorActual.ToString()
            GuardarValor(lblHamburguesa)
        Else MessageBox.Show("No puede haber menos de 0", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMenosPatata_Click(sender As Object, e As EventArgs) Handles btnMenosPatata.Click
        Dim valorActual As Integer = Integer.Parse(lblPatata.Text)
        If (valorActual > 0) Then
            valorActual -= 1
            lblPatata.Text = valorActual.ToString()
            GuardarValor(lblPatata)
        Else MessageBox.Show("No puede haber menos de 0", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMenosNuget_Click(sender As Object, e As EventArgs) Handles btnMenosNuget.Click
        Dim valorActual As Integer = Integer.Parse(lblNuget.Text)
        If (valorActual > 0) Then
            valorActual -= 1
            lblNuget.Text = valorActual.ToString()
            GuardarValor(lblNuget)
        Else MessageBox.Show("No puede haber menos de 0", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub GuardarValor(etiqueta As Label)
        Select Case etiqueta.Name
            Case "lblHamburguesa"
                ModuloInfonumProd.nHamburguesas = lblHamburguesa.Text
            Case "lblPatata"
                ModuloInfonumProd.nPatatas = lblPatata.Text
            Case "lblNuget"
                ModuloInfonumProd.nNugets = lblNuget.Text
        End Select
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
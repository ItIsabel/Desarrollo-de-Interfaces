Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum2.Clear()
        txtNum1.Clear()
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        txtResultado.Text = FunSumar(Int(txtNum1.Text), Int(txtNum2.Text))

    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click
        txtResultado.Text = FunRestar(Int(txtNum1.Text), Int(txtNum2.Text))

    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        txtResultado.Text = FunMultiplicar(Int(txtNum1.Text), Int(txtNum2.Text))
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        txtResultado.Text = FunDividir(Int(txtNum1.Text), Int(txtNum2.Text))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class

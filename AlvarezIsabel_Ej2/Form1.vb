Public Class Form1
    Private Sub iniciar_Initizalize(sender As Object, e As EventArgs)
        rbtnSi.Checked = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbtnObrero.Checked = True
        rbtnNo.Checked = True
        rbmenos5.Checked = True
        NumHijs.Value = 0

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        ' También es posible End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim desglose As String
        Dim salario As Integer

        desglose = ""

        If rbtnObrero.Checked Then
            desglose &= "Tu salario base como obrero es 800€" & vbNewLine
            salario += 800
        ElseIf rbtnAdministrativo.Checked Then
            desglose &= "Tu salario base como administrativo es 900€" & vbNewLine
            salario += 900
        ElseIf btnTecnico.Checked Then
            desglose &= "Tu salario base como técnico es 1000€" & vbNewLine
            salario += 1000
        ElseIf btnProfesional.Checked Then
            desglose &= "Tu salario base como profesional es 1200€" & vbNewLine
            salario += 1200
        End If

        If rbtnSi.Checked Then
            desglose &= "Tienes un complemento por afiliación sindical de 50€ " & vbNewLine
            salario += 50
        End If

        If rbtn5y10.Checked Then
            desglose &= "Por tu antigüedad entre 5-10 años cobras un complemento de 100€" & vbNewLine
            salario += 100
        ElseIf rbtnmas10.Checked Then
            desglose &= "Por tu antigüedad superior a 10 años cobras un complemento de 200€" & vbNewLine
            salario += 200
        End If

        If NumHijs.Value > 0 Then
            Dim desgloseHijos As String
            Dim complementoHijos As Integer
            complementoHijos = 100 * NumHijs.Value
            salario += complementoHijos
            desgloseHijos = "Tienes un complemento de " & complementoHijos & "€ por tener " & NumHijs.Value & " hijos."
            desglose &= desgloseHijos
        End If

        MsgBox(desglose & vbNewLine & "salario = " & salario & "€")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class

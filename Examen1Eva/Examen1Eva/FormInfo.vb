Public Class FormInfo
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCocina.Items.AddRange({"Bufé", "Carta", "Pedir cita con el chef", "No precisa"})
        cmbCocina.SelectedIndex = 0

        grpCongreso.Visible = False
        grpBanquete.Visible = False

        AddHandler rbBanquete.CheckedChanged, AddressOf BanqueteCheckedChanged
        AddHandler rbJornada.CheckedChanged, AddressOf JornadaCheckedChanged
        AddHandler rbCongreso.CheckedChanged, AddressOf CongresoCheckedChanged


    End Sub

    Private Sub BanqueteCheckedChanged(sender As Object, e As EventArgs)
        grpBanquete.Visible = rbBanquete.Checked
        grpCongreso.Visible = False
    End Sub

    Private Sub JornadaCheckedChanged(sender As Object, e As EventArgs)
        grpBanquete.Visible = False
        grpCongreso.Visible = False
    End Sub

    Private Sub CongresoCheckedChanged(sender As Object, e As EventArgs)
        grpBanquete.Visible = False
        grpCongreso.Visible = rbCongreso.Checked

    End Sub
End Class
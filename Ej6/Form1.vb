Public Class Form1

    Dim selecEspecie
    Dim selectRaza
    Private Sub cboEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecie.SelectedIndexChanged
        cboRaza.Items.Clear()
        selecEspecie = cboEspecie.SelectedItem
        If selecEspecie = "Pez" Then
            cboRaza.Items.Add("Betta Splendens")
            cboRaza.Items.Add("Pomacanthus Annularis")
            cboRaza.Items.Add("Scarus Taeniopterus")
        ElseIf selecEspecie = "Gato" Then
            cboRaza.Items.Add("Siames")
            cboRaza.Items.Add("Sphynx")
            cboRaza.Items.Add("Maine Coon")
        ElseIf selecEspecie = "Perro" Then
            cboRaza.Items.Add("Shiba")
            cboRaza.Items.Add("Maltipoo")
            cboRaza.Items.Add("San Bernardo")
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRaza.Items.Clear()
        PictureBox1.BackgroundImage = Nothing




    End Sub

    Private Sub cboRaza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRaza.SelectedIndexChanged
        selectRaza = cboRaza.SelectedItem
        Select Case selectRaza
            Case "Betta Splendens"
                PictureBox1.Image = My.Resources.Pez_BettaSplendens
            Case "Pomacanthus Annularis"
                PictureBox1.Image = My.Resources.Pez_PomacanthusAnnularis
            Case "Scarus Taeniopterus"
                PictureBox1.Image = My.Resources.Pez_ScarusTaeniopterus
            Case "Siames"
                PictureBox1.Image = My.Resources.Gato_Siames
            Case "Sphynx"
                PictureBox1.Image = My.Resources.Gato_Sphynxjfif
            Case "Maine Coon"
                PictureBox1.Image = My.Resources.Gato_MaineCoon
            Case "Shiba"
                PictureBox1.Image = My.Resources.Perro_Shiba
            Case "Maltipoo"
                PictureBox1.Image = My.Resources.Perro_Maltipoo
            Case "San Bernardo"
                PictureBox1.Image = My.Resources.Perro_SanBernardo
        End Select
    End Sub


    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If (selectRaza = "") Then
            MsgBox("Error, selecciona una raza")
        Else
            MsgBox("El " + selectRaza + " es de la especie " + selecEspecie)
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub cboEspecie_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEspecie.SelectedValueChanged
        cboRaza.SelectedItem = Nothing
        cboRaza.Items.Clear()
        selectRaza = ""
        PictureBox1.Image = Nothing



    End Sub
End Class

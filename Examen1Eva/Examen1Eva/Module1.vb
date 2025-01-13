Module Module1
    Public Structure DatosEvento
        Public TipoEvento As String
        Public NumeroPersonas As Integer
        Public TipoCocina As String
        ' Datos específicos de Banquete
        Public TipoMesa As String
        Public ComensalesPorMesa As Integer
        ' Datos específicos de Congreso
        Public NumeroJornadas As Integer
        Public RequiereHabitaciones As Boolean
    End Structure

    ' Variable global para almacenar el evento actual
    Public EventoActual As DatosEvento

    ' Función para guardar los datos del formulario
    Public Function GuardarDatosEvento(form As FormInfo) As Boolean
        Try
            ' Determinar tipo de evento
            If form.rbBanquete.Checked Then
                EventoActual.TipoEvento = "Banquete"
                ' Guardar datos específicos de banquete
                If form.rbMesaRedonda.Checked Then
                    EventoActual.TipoMesa = "Redonda"
                ElseIf form.rbMesaRectangular.Checked Then
                    EventoActual.TipoMesa = "Rectangular"
                End If
                EventoActual.ComensalesPorMesa = form.numComensalesMesa.Value
            ElseIf form.rbCongreso.Checked Then
                EventoActual.TipoEvento = "Congreso"
                ' Guardar datos específicos de congreso
                EventoActual.NumeroJornadas = form.numJornadas.Value
                EventoActual.RequiereHabitaciones = form.chkHabitaciones.Checked
            Else
                EventoActual.TipoEvento = "Jornada"
            End If

            ' Guardar datos comunes
            EventoActual.NumeroPersonas = form.numPersonas.Value
            EventoActual.TipoCocina = form.cmbCocina.SelectedItem

            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ObtenerResumenEvento() As String
        Dim resumen As New System.Text.StringBuilder()

        resumen.AppendLine("RESUMEN DEL EVENTO")
        resumen.AppendLine("------------------")
        resumen.AppendLine($"Tipo de evento: {EventoActual.TipoEvento}")
        resumen.AppendLine($"Número de personas: {EventoActual.NumeroPersonas}")


        Select Case EventoActual.TipoEvento
            Case "Banquete"
                resumen.AppendLine($"Tipo de mesa: {EventoActual.TipoMesa}")
                resumen.AppendLine($"Comensales por mesa: {EventoActual.ComensalesPorMesa}")

            Case "Congreso"
                resumen.AppendLine($"Número de jornadas: {EventoActual.NumeroJornadas}")
                resumen.AppendLine($"Requiere habitaciones: {If(EventoActual.RequiereHabitaciones, "Sí", "No")}")
        End Select

        resumen.AppendLine()

        Return resumen.ToString()
    End Function

End Module

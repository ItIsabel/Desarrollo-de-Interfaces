Public Class FormAyuda
    Private Sub CargarPreguntasFrecuentes()
        ' Sección Lactancia
        ListBox1.Items.Add("=== SECCIÓN: LACTANCIA ===")
        ListBox1.Items.Add("¿Cómo sé si mi bebé está recibiendo suficiente leche materna?")
        ListBox1.Items.Add("¿Qué debo hacer si mis pezones se agrietan durante la lactancia?")
        ListBox1.Items.Add("¿Puedo seguir amamantando si estoy enferma?")
        ListBox1.Items.Add("¿Cuál es la mejor posición para amamantar a mi bebé?")
        ListBox1.Items.Add("¿Cómo puedo aumentar mi producción de leche materna?")
        ListBox1.Items.Add("")

        ' Sección Productos
        ListBox1.Items.Add("=== SECCIÓN: PRODUCTOS ===")
        ListBox1.Items.Add("¿Cómo puedo estar segura de que los productos que venden son seguros para mi bebé?")
        ListBox1.Items.Add("¿Ofrecen envío a domicilio? ¿Cuánto tiempo tarda la entrega?")
        ListBox1.Items.Add("¿Cuáles son las formas de pago disponibles?")
        ListBox1.Items.Add("¿Tienen alguna política de devolución o cambio?")
        ListBox1.Items.Add("¿Ofrecen descuentos o promociones especiales?")
        ListBox1.Items.Add("")

        ' Sección Educación
        ListBox1.Items.Add("=== SECCIÓN: EDUCACIÓN ===")
        ListBox1.Items.Add("¿Qué tipo de contenido educativo ofrecen para los padres primerizos?")
        ListBox1.Items.Add("¿Hay algún programa de seguimiento del desarrollo del bebé?")
        ListBox1.Items.Add("¿Cómo puedo acceder al contenido educativo? ¿Es necesario registrarse?")
        ListBox1.Items.Add("¿Ofrecen asesoramiento personalizado para padres?")
        ListBox1.Items.Add("")

        ' Sección Desarrollo
        ListBox1.Items.Add("=== SECCIÓN: DESARROLLO ===")
        ListBox1.Items.Add("¿Cuáles son los hitos del desarrollo que debo esperar en mi bebé?")
        ListBox1.Items.Add("¿Cómo puedo estimular el desarrollo de mi bebé en casa?")
        ListBox1.Items.Add("¿Qué debo hacer si mi bebé no alcanza los hitos esperados?")
        ListBox1.Items.Add("¿Ofrecen actividades o juegos para estimular el desarrollo de mi bebé?")

        ' Opcional: Seleccionar el primer elemento
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub


    ' Método principal que puedes llamar desde un botón o al cargar el formulario
    Private Sub CargarPreguntas()
        CargarPreguntasFrecuentes()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Obtener el texto seleccionado
        Dim preguntaSeleccionada As String = ListBox1.SelectedItem.ToString()

        ' No mostrar respuesta para los separadores de sección
        If preguntaSeleccionada.StartsWith("===") OrElse String.IsNullOrEmpty(preguntaSeleccionada) Then
            Return
        End If

        ' Obtener y mostrar la respuesta correspondiente
        Dim respuesta As String = ObtenerRespuesta(preguntaSeleccionada)
        MessageBox.Show(respuesta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ObtenerRespuesta(pregunta As String) As String
        Select Case pregunta
        ' Sección: Lactancia
            Case "¿Cómo sé si mi bebé está recibiendo suficiente leche materna?"
                Return "Tu bebé está recibiendo suficiente leche si:" & vbCrLf & vbCrLf &
                       "• Tiene de 6 a 8 pañales mojados al día" & vbCrLf &
                       "• Aumenta de peso constantemente" & vbCrLf &
                       "• Se muestra satisfecho después de alimentarse" & vbCrLf &
                       "• Tiene un color saludable y está activo" & vbCrLf &
                       "• Las sesiones de alimentación duran entre 10-30 minutos"

            Case "¿Qué debo hacer si mis pezones se agrietan durante la lactancia?"
                Return "Para tratar y prevenir los pezones agrietados:" & vbCrLf & vbCrLf &
                       "• Asegura una correcta posición del bebé al amamantar" & vbCrLf &
                       "• Aplica un poco de tu leche materna en los pezones después de amamantar" & vbCrLf &
                       "• Usa compresas de hidrogel específicas para lactancia" & vbCrLf &
                       "• Mantén los pezones secos y permite que respiren" & vbCrLf &
                       "• Consulta con un especialista en lactancia si el problema persiste"

            Case "¿Puedo seguir amamantando si estoy enferma?"
                Return "En general, sí puedes seguir amamantando cuando estás enferma:" & vbCrLf & vbCrLf &
                       "• La mayoría de las enfermedades comunes no se transmiten por la leche materna" & vbCrLf &
                       "• Tu leche contiene anticuerpos que protegen al bebé" & vbCrLf &
                       "• Consulta con tu médico sobre medicamentos seguros durante la lactancia" & vbCrLf &
                       "• Usa mascarilla si tienes una enfermedad respiratoria" & vbCrLf &
                       "• Mantén una buena higiene de manos"

            Case "¿Cuál es la mejor posición para amamantar a mi bebé?"
                Return "Las mejores posiciones para amamantar son:" & vbCrLf & vbCrLf &
                       "• Posición cuna: La más común, sosteniendo al bebé horizontal frente a ti" & vbCrLf &
                       "• Posición acostada: Ideal para alimentaciones nocturnas" & vbCrLf &
                       "• Posición fútbol americano: Útil después de una cesárea" & vbCrLf &
                       "• Lo más importante es que ambos estén cómodos" & vbCrLf &
                       "• El bebé debe estar bien alineado y cerca de ti"

            Case "¿Cómo puedo aumentar mi producción de leche materna?"
                Return "Para aumentar la producción de leche:" & vbCrLf & vbCrLf &
                       "• Amamanta con más frecuencia" & vbCrLf &
                       "• Asegura un buen agarre del bebé" & vbCrLf &
                       "• Mantente bien hidratada" & vbCrLf &
                       "• Descansa lo suficiente" & vbCrLf &
                       "• Considera el uso de un extractor de leche" & vbCrLf &
                       "• Consulta con un especialista en lactancia si necesitas ayuda"

        ' Sección: Productos
            Case "¿Cómo puedo estar segura de que los productos que venden son seguros para mi bebé?"
                Return "Nuestros productos son seguros porque:" & vbCrLf & vbCrLf &
                       "• Cumplen con todas las normativas de seguridad" & vbCrLf &
                       "• Son sometidos a rigurosos controles de calidad" & vbCrLf &
                       "• Trabajamos solo con marcas certificadas" & vbCrLf &
                       "• Incluyen garantía y certificaciones" & vbCrLf &
                       "• Actualizamos constantemente nuestros estándares de seguridad"

            Case "¿Ofrecen envío a domicilio? ¿Cuánto tiempo tarda la entrega?"
                Return "Sobre nuestro servicio de envío:" & vbCrLf & vbCrLf &
                       "• Sí, realizamos envíos a todo el país" & vbCrLf &
                       "• Tiempo estimado: 2-5 días hábiles" & vbCrLf &
                       "• Envío express disponible en ciertas zonas" & vbCrLf &
                       "• Seguimiento en tiempo real de tu pedido" & vbCrLf &
                       "• Entrega gratuita en compras superiores a $50"

            Case "¿Cuáles son las formas de pago disponibles?"
                Return "Aceptamos los siguientes medios de pago:" & vbCrLf & vbCrLf &
                       "• Tarjetas de crédito y débito" & vbCrLf &
                       "• PayPal" & vbCrLf &
                       "• Transferencia bancaria" & vbCrLf &
                       "• Pago en efectivo en puntos autorizados" & vbCrLf &
                       "• Pagos en cuotas sin interés con tarjetas seleccionadas"

            Case "¿Tienen alguna política de devolución o cambio?"
                Return "Nuestra política de devolución incluye:" & vbCrLf & vbCrLf &
                       "• 30 días para devoluciones" & vbCrLf &
                       "• El producto debe estar sin usar y en su empaque original" & vbCrLf &
                       "• Reembolso completo o cambio por otro producto" & vbCrLf &
                       "• Devolución gratuita en caso de productos defectuosos" & vbCrLf &
                       "• Proceso simple y rápido"

            Case "¿Ofrecen descuentos o promociones especiales?"
                Return "Nuestras ofertas y promociones:" & vbCrLf & vbCrLf &
                       "• Descuentos mensuales en productos seleccionados" & vbCrLf &
                       "• Programa de puntos para clientes frecuentes" & vbCrLf &
                       "• Ofertas especiales en fechas señaladas" & vbCrLf &
                       "• Newsletter con promociones exclusivas" & vbCrLf &
                       "• Descuentos por primera compra"

        ' Sección: Educación
            Case "¿Qué tipo de contenido educativo ofrecen para los padres primerizos?"
                Return "Nuestro contenido educativo incluye:" & vbCrLf & vbCrLf &
                       "• Guías paso a paso sobre cuidados básicos" & vbCrLf &
                       "• Videos instructivos" & vbCrLf &
                       "• Webinars con especialistas" & vbCrLf &
                       "• Artículos actualizados sobre crianza" & vbCrLf &
                       "• Recursos descargables y checklist"

            Case "¿Hay algún programa de seguimiento del desarrollo del bebé?"
                Return "Nuestro programa de seguimiento incluye:" & vbCrLf & vbCrLf &
                       "• App para registro de hitos del desarrollo" & vbCrLf &
                       "• Alertas personalizadas" & vbCrLf &
                       "• Consejos específicos según la edad" & vbCrLf &
                       "• Evaluaciones mensuales" & vbCrLf &
                       "• Conexión con especialistas cuando sea necesario"

            Case "¿Cómo puedo acceder al contenido educativo? ¿Es necesario registrarse?"
                Return "Para acceder al contenido educativo:" & vbCrLf & vbCrLf &
                       "• Registro gratuito en nuestra plataforma" & vbCrLf &
                       "• Acceso inmediato al contenido básico" & vbCrLf &
                       "• Contenido premium disponible por suscripción" & vbCrLf &
                       "• App móvil disponible" & vbCrLf &
                       "• Sincronización entre dispositivos"

            Case "¿Ofrecen asesoramiento personalizado para padres?"
                Return "Nuestro asesoramiento personalizado incluye:" & vbCrLf & vbCrLf &
                       "• Consultas online con especialistas" & vbCrLf &
                       "• Chat 24/7 para dudas urgentes" & vbCrLf &
                       "• Planes personalizados de crianza" & vbCrLf &
                       "• Seguimiento continuo" & vbCrLf &
                       "• Primera consulta gratuita"

        ' Sección: Desarrollo
            Case "¿Cuáles son los hitos del desarrollo que debo esperar en mi bebé?"
                Return "Hitos principales del desarrollo:" & vbCrLf & vbCrLf &
                       "• 0-3 meses: Sostiene la cabeza, sonríe, sigue objetos" & vbCrLf &
                       "• 3-6 meses: Se sienta con apoyo, balbucea, agarra objetos" & vbCrLf &
                       "• 6-9 meses: Gatea, dice primeras palabras, come sólidos" & vbCrLf &
                       "• 9-12 meses: Primeros pasos, más palabras, señala objetos" & vbCrLf &
                       "• Recuerda que cada bebé se desarrolla a su propio ritmo"

            Case "¿Cómo puedo estimular el desarrollo de mi bebé en casa?"
                Return "Actividades para estimular el desarrollo:" & vbCrLf & vbCrLf &
                       "• Tiempo boca abajo supervisado" & vbCrLf &
                       "• Juegos de esconder y encontrar objetos" & vbCrLf &
                       "• Lectura diaria de cuentos" & vbCrLf &
                       "• Canciones y juegos musicales" & vbCrLf &
                       "• Actividades sensoriales seguras"

            Case "¿Qué debo hacer si mi bebé no alcanza los hitos esperados?"
                Return "Si notas retrasos en el desarrollo:" & vbCrLf & vbCrLf &
                       "• Consulta con el pediatra" & vbCrLf &
                       "• Registra tus observaciones" & vbCrLf &
                       "• Considera una evaluación del desarrollo" & vbCrLf &
                       "• No compares con otros bebés" & vbCrLf &
                       "• La intervención temprana es clave"

            Case "¿Ofrecen actividades o juegos para estimular el desarrollo de mi bebé?"
                Return "Actividades y juegos disponibles:" & vbCrLf & vbCrLf &
                       "• Kit de estimulación por edades" & vbCrLf &
                       "• Guías de juegos semanales" & vbCrLf &
                       "• Videos demostrativos" & vbCrLf &
                       "• Materiales descargables" & vbCrLf &
                       "• Talleres online de estimulación temprana"

            Case Else
                Return "Lo sentimos, no se encontró una respuesta específica para esta pregunta. Por favor, contacta con nosotros."
        End Select
    End Function

    Private Sub FormAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPreguntas()
    End Sub
End Class
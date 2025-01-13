Imports System.IO


Public Class Form1
    'Declaramos variables globales
    Dim nombre, telefono, direccion, dni As String
    Dim fecha As Date
    Dim validadosCampos, dniValidado As Boolean
    Dim filaActual As Integer

    'Cuando se cargue el formulario, cargaremos los datos del fichero datos.txt en el grid de datos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = Nothing
        Try
            'Declaración de variables
            Dim ficheroDatos As StreamReader
            Dim rutaArchivo As String = "./datos.txt"

            'Verificamos si el archivo existe
            If Not File.Exists(rutaArchivo) Then
                'Si no existe, lo creamos vacío
                Using sw As StreamWriter = File.CreateText(rutaArchivo)
                End Using
            End If

            'Le asignamos el fichero físico y reservamos su espacio en memoria
            ficheroDatos = New StreamReader(rutaArchivo)

            'Mientras no se llegue al final del stream de datos
            While Not ficheroDatos.EndOfStream
                'Leemos línea del Stream
                Dim linea As String = ficheroDatos.ReadLine
                Dim dato As String() = linea.Split(New Char() {";"})
                dgvDatos.Rows.Add(dato)
            End While

            'Cerramos el StreamReader
            ficheroDatos.Close()

        Catch ex As Exception
            MessageBox.Show("Error al procesar el archivo: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Asignamos valores a las variables globales con lo que la persona usuaria ha introducido en los campos de texto
        nombre = txtNombre.Text
        fecha = dtePicker.Value.ToShortDateString()
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        dni = txtDni.Text
        'Validamos que los campos no estén vacíos
        validadosCampos = validarCampos(nombre, fecha, telefono, direccion, dni)

        'Si los campos están correctos
        If validadosCampos = True Then
            'Comprobamos si el DNI es distinto del que se tenía introducido en el registro
            If dni <> dgvDatos.Rows(filaActual).Cells("DNIColumn").Value Then
                dniValidado = validarDNI(dni)
            End If

            'Si el dni ha pasado el filtro
            If dniValidado = True Then
                'Incluimos los campos en un registro del grid
                dgvDatos.Rows.Add(nombre, telefono, direccion, fecha, dni)
                MsgBox("Se agregó el nuevo contacto correctamente", MsgBoxStyle.Information, "Información del sistema") 'Mensaje indicando que se agregó correctamente el registro
                limpiar() 'Limpiamos los campos de texto

            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim pregunta As String
        pregunta = MsgBox("¿Estás seguro/a que deseas eliminar este contacto", MsgBoxStyle.YesNo, "Información del sistema") 'Mensaje para confirmación
        If pregunta = vbYes Then
            filaActual = dgvDatos.CurrentRow.Index 'Recuperamos la fila que se ha seleccionado
            dgvDatos.Rows.Remove(dgvDatos.Rows(filaActual)) 'Eliminamos el registro
            MsgBox("El contacto se ha eliminado", MsgBoxStyle.Information, "Información del sistema") 'Mensaje de confirmación
            ActivarBotones() 'Volvemos a habilitar los botones
            limpiar() 'Limpiamos los campos de texto
        End If

    End Sub


    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        filaActual = dgvDatos.CurrentRow.Index
        txtNombre.Text = dgvDatos.Rows(filaActual).Cells("NombreColumn").Value
        dtePicker.Value = DateTime.Parse(dgvDatos.Rows(filaActual).Cells("CumpleanosColumn").Value)
        txtTelefono.Text = dgvDatos.Rows(filaActual).Cells("TelefonoColumn").Value
        txtDireccion.Text = dgvDatos.Rows(filaActual).Cells("DireccionColumn").Value
        txtDni.Text = dgvDatos.Rows(filaActual).Cells("DNIColumn").Value
        DesactivarBotones()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Asignamos valores a las variables globales
        nombre = txtNombre.Text
        fecha = dtePicker.Value
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        dni = txtDni.Text

        'Validamos que los campos no estén vacíos
        validadosCampos = validarCampos(nombre, fecha, telefono, direccion, dni)

        'Obtenemos la fila actual
        filaActual = dgvDatos.CurrentRow.Index

        dniValidado = True 'Por si no llega a entrar en la condición siguiente

        'Si los campos estaban correctos
        If validadosCampos = True Then
            'Comprobamos si la fecha es distinta de la que se tenía introducida
            If dni <> dgvDatos.Rows(filaActual).Cells("DNIColumn").Value Then
                dniValidado = validarDNI(dni)
            End If

            'Si el DNI ha pasado el filtro
            If dniValidado = True Then
                'Modificamos los campos del registro
                dgvDatos.Rows(filaActual).Cells("NombreColumn").Value = nombre
                dgvDatos.Rows(filaActual).Cells("CumpleanosColumn").Value = fecha.ToShortDateString()
                dgvDatos.Rows(filaActual).Cells("TelefonoColumn").Value = telefono
                dgvDatos.Rows(filaActual).Cells("DireccionColumn").Value = direccion
                dgvDatos.Rows(filaActual).Cells("DNIColumn").Value = dni
                MsgBox("El contacto se ha modificado", MsgBoxStyle.Information, "Información del sistema")
                ActivarBotones()
                limpiar()
            End If
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        GuardarDatos()

    End Sub


    'FUNCIONES
    Function validarCampos(parnombre As String, parfecha As Date, partelefono As String, pardireccion As String, parDNI As String) As Boolean
        'Si algún campo está vacío se le enviará alerta y errorProvider
        If parnombre = "" Then
            MsgBox("Debe introducir un nombre para el contacto", MsgBoxStyle.Critical, "Información")
            ErrorProvider1.SetError(txtNombre, "Introduzca un nombre para el contacto")
            validadosCampos = False
        ElseIf parfecha = Nothing Then
            MsgBox("Debe seleccionar una fecha para el contacto", MsgBoxStyle.Critical, "Información")
            ErrorProvider1.SetError(dtePicker, "Seleccione una fecha para el contacto")
            validadosCampos = False
        ElseIf partelefono = "" Then
            MsgBox("Debe introducir un teléfono para el contacto", MsgBoxStyle.Critical, "Información")
            ErrorProvider1.SetError(txtTelefono, "Introduzca un teléfono para el contacto")
            validadosCampos = False
        ElseIf pardireccion = "" Then
            MsgBox("Debe introducir una dirección para el contacto", MsgBoxStyle.Critical, "Información")
            ErrorProvider1.SetError(txtDireccion, "Introduzca una dirección para el contacto")
            validadosCampos = False
        Else
            validadosCampos = True
            ErrorProvider1.SetError(txtNombre, "")
            ErrorProvider1.SetError(dtePicker, "")
            ErrorProvider1.SetError(txtTelefono, "")
            ErrorProvider1.SetError(txtDireccion, "")
        End If

        Return validadosCampos
    End Function

    'Función para validar DNI
    Function validarDNI(parDNI As String) As Boolean

        'Inicializamos variable a true
        dniValidado = True

        'Recorremos cada registro del grid
        For i = 0 To dgvDatos.RowCount - 1

            'Si ya existiera dicho DNI
            If parDNI = dgvDatos.Rows(i).Cells("DNIColumn").Value Then

                MsgBox("Ya existe un usuario con el DNI introducido", MsgBoxStyle.Critical, "Información") 'Alerta con el error
                ErrorProvider1.SetError(txtDni, "Ingrese otro DNI") 'Icono error en campo de texto
                dniValidado = False 'Cambiamos el valor a false para indicar que no fue validado
                Exit For 'Salimos del For, no hace falta continuar validando

            Else
                ErrorProvider1.SetError(txtDni, "") 'Se deja la información en blanco para que el icono no aparezca
                dniValidado = True 'Se da valor True pues el dni fue validado

            End If

        Next

        'Retornamos el valor de dniValidado
        Return dniValidado

    End Function

    'METODOS
    'Método para deshabilitar los botones
    Private Sub DesactivarBotones()
        btnAgregar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    'Método para habilitar los botones
    Private Sub ActivarBotones()
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub limpiar()
        txtNombre.Clear()
        dtePicker.Value = DateTime.Now
        txtTelefono.Clear()
        txtDireccion.Clear()
        txtDni.Clear()
    End Sub

    'Método para escribir los registros en el fichero de datos
    Private Sub GuardarDatos()

        'Creamos una instancia de StreamWriter
        Dim ficheroDatos As StreamWriter 'Variable para escribir en el fichero Datos
        Dim linea As String 'Variable para recoger línea del stream de datos
        ficheroDatos = New StreamWriter(".\datos.txt") 'Asignamos la ubicación del fichero sobre el que vamos a escribir

        'Recorremos el grid y vamos pintando cada campo de cada registro separándolo con ;
        With dgvDatos
            For i = 0 To .RowCount - 1
                linea = .Rows(i).Cells("NombreColumn").Value & ";" &
                        .Rows(i).Cells("CumpleanosColumn").Value & ";" &
                        .Rows(i).Cells("TelefonoColumn").Value & ";" &
                        .Rows(i).Cells("DireccionColumn").Value & ";" &
                        .Rows(i).Cells("DNIColumn").Value & ";"
                ficheroDatos.WriteLine(linea)
            Next
            MsgBox("Los datos se han guardado correctamente", MsgBoxStyle.Information, "Información del sistema") 'Mensaje de confirmación
        End With

        'Cerramos streamWriter
        ficheroDatos.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class


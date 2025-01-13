Imports System.Data.SqlClient

Public Class Form1
    ' Connection string as a class-level variable to avoid repetition
    Private ReadOnly connectionString As String = "Data Source=LAPTOP-S037DJFK\SQLEXPRESS;Initial Catalog=CLientes;Integrated Security=True"
    Dim cn As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initial button text
        UpdateButtonText()

        ' Load initial data
        Me.GrupoTableAdapter.Fill(Me.ClientesDataSet1.Grupo)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        UpdateButtonText()
    End Sub

    Private Sub UpdateButtonText()
        ' Update button text based on current tab
        Select Case TabControl1.SelectedIndex
            Case 0 ' Registro tab
                btnAccion.Visible = True
                btnAccion.Text = "Registrar"
            Case 1 ' Actualización tab
                btnAccion.Visible = True
                btnAccion.Text = "Modificar"
            Case 2 ' Eliminación tab
                btnAccion.Visible = True
                btnAccion.Text = "Eliminar"
            Case 3 ' Datos tab
                btnAccion.Visible = False

        End Select
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Using cn As New SqlConnection(connectionString)
            Try
                Select Case TabControl1.SelectedIndex
                    Case 0 ' Registro
                        RegisterStudent(cn)
                    Case 1 ' Actualización
                        UpdateStudent(cn)
                    Case 2 ' Eliminación
                        DeleteStudent(cn)
                    Case 3 ' datos 
                End Select
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub RegisterStudent(cn As SqlConnection)
        Dim cmd As New SqlCommand("INSERT INTO Grupo VALUES(@Alias, @nombre, @apellidos, @telefono, @intereses)", cn)

        With cmd.Parameters
            .AddWithValue("@Alias", txtAliasR.Text)
            .AddWithValue("@nombre", txtNombreR.Text)
            .AddWithValue("@apellidos", txtApellidosR.Text)
            .AddWithValue("@telefono", txtTelefonoR.Text)
            .AddWithValue("@intereses", txtInteresesR.Text)
        End With

        cn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro completado exitosamente")
        cn.Close()
        ClearRegistrationFields()
    End Sub

    Private Sub btnBuscarE_Click(sender As Object, e As EventArgs) Handles btnBuscarE.Click
        'Recuperación de datos
        cn.Open()
        Dim cmd As New SqlCommand("select * from Grupo where Alias=@Alias", cn)
        cmd.Parameters.AddWithValue("@Alias", txtAliasE.Text)

        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            txtNombreE.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtApellidosE.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtTelefonoE.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtInteresesE.Text = ds.Tables("datos").Rows(0).Item(4).ToString
        Else
            MsgBox("No existe el usuario")
        End If
        cn.Close()
    End Sub

    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs) Handles btnBuscarA.Click
        cn.Open()
        'Recuperación de datos
        Dim cmd As New SqlCommand("select * from Grupo where Alias=@Alias", cn)
        cmd.Parameters.AddWithValue("@Alias", txtAliasA.Text)

        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            txtNombreA.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtApellidosA.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtTelefonoA.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtInteresesA.Text = ds.Tables("datos").Rows(0).Item(4).ToString
        Else
            MsgBox("No existe el usuario")
        End If
        cn.Close()
    End Sub

    Private Sub RecuperarDatos(cn As SqlConnection)
        cn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Grupo", cn)
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        ' Limpia el DataSet antes de llenarlo
        ds.Clear()

        ' Llena el DataSet
        adaptador.Fill(ds, "Grupo")

        ' Asigna los datos al DataGridView
        DataGridView1.DataSource = ds.Tables("Grupo")
        cn.Close()
    End Sub

    Private Sub SearchStudent(cn As SqlConnection)
        cn.Open()
        Dim adapter As New SqlDataAdapter("SELECT * FROM Grupo WHERE Alias = @Alias", cn)
        adapter.SelectCommand.Parameters.AddWithValue("@Alias", txtAliasA.Text)

        Dim ds As New DataSet
        adapter.Fill(ds, "Grupo")

        If ds.Tables("Grupo").Rows.Count > 0 Then
            With ds.Tables("Grupo").Rows(0)
                txtNombreA.Text = .Item("NOMBRE").ToString()
                txtApellidosA.Text = .Item("APELLIDOS").ToString()
                txtTelefonoA.Text = .Item("TELEFONO").ToString()
                txtInteresesA.Text = .Item("INTERESES").ToString()
            End With
        Else
            MessageBox.Show("No se encontró el estudiante")
            ClearUpdateFields()
        End If
        cn.Close()
    End Sub


    Private Sub UpdateStudent(cn As SqlConnection)
        cn.Open()
        Dim cmd As New SqlCommand("UPDATE Grupo SET NOMBRE=@Nombre, APELLIDOS=@apellidos, TELEFONO=@telefono, INTERESES=@intereses WHERE ALIAS=@Alias", cn)

        With cmd.Parameters
            .AddWithValue("@Alias", txtAliasA.Text)
            .AddWithValue("@nombre", txtNombreA.Text)
            .AddWithValue("@apellidos", txtApellidosA.Text)
            .AddWithValue("@telefono", Convert.ToInt64(txtTelefonoA.Text))
            .AddWithValue("@intereses", txtInteresesA.Text)
        End With

        cn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Actualización completada exitosamente")
        ClearUpdateFields()
        cn.Close()
    End Sub


    Private Sub DeleteStudent(cn As SqlConnection)

        Dim cmd As New SqlCommand("DELETE FROM Grupo WHERE Alias = @Alias", cn)
        cmd.Parameters.AddWithValue("@Alias", txtAliasE.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Eliminación completada exitosamente")
        ClearDeletionFields()
        cn.Close()
    End Sub

    Private Sub ClearRegistrationFields()
        txtAliasR.Clear()
        txtNombreR.Clear()
        txtApellidosR.Clear()
        txtInteresesR.Clear()
        txtTelefonoR.Clear()
    End Sub

    Private Sub ClearUpdateFields()
        txtAliasA.Clear()
        txtNombreA.Clear()
        txtApellidosA.Clear()
        txtInteresesA.Clear()
        txtTelefonoA.Clear()
    End Sub

    Private Sub ClearDeletionFields()
        txtAliasE.Clear()
        txtNombreE.Clear()
        txtApellidosE.Clear()
        txtInteresesE.Clear()
        txtTelefonoE.Clear()
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
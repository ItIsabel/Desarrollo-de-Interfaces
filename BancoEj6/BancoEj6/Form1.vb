Imports System.Data.SqlClient

Public Class Form1
    ' Connection string as a class-level variable to avoid repetition
    Private ReadOnly connectionString As String = "Data Source=LAPTOP-S037DJFK\SQLEXPRESS;Initial Catalog=Clientes;Integrated Security=True;Encrypt=False"
    Dim cn As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet11.Banco' Puede moverla o quitarla según sea necesario.
        Me.BancoTableAdapter.Fill(Me.ClientesDataSet11.Banco)

        ' Initial button text
        UpdateButtonText()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabs.SelectedIndexChanged
        UpdateButtonText()
    End Sub

    Private Sub UpdateButtonText()
        ' Update button text based on current tab
        Select Case tabs.SelectedIndex
            Case 0 ' Registro tab
                btnAccion.Visible = True
                btnAccion.Text = "Registrar cuenta"
            Case 1 ' Ingresar Dinero tab
                btnAccion.Visible = True
                btnAccion.Text = "Ingresar dinero"
            Case 2 ' Retirar Dinero tab
                btnAccion.Visible = True
                btnAccion.Text = "Retirar dinero"
            Case 3 ' Eliminar cuenta tab
                btnAccion.Visible = True
                btnAccion.Text = "Eliminar cuenta"
            Case 4 ' Mostrar cuentas tab
                btnAccion.Visible = True
                btnAccion.Text = "Crear Informe"
                Me.BancoTableAdapter.Fill(Me.ClientesDataSet11.Banco)
        End Select
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Using cn As New SqlConnection(connectionString)
            Try
                Select Case tabs.SelectedIndex
                    Case 0 ' Registro
                        RegisterBankUser(cn)
                    Case 1 ' Ingreso
                        IngresarBankAcount(cn)
                    Case 2 ' Retirada
                        RetirarBankAcount(cn)
                    Case 3 ' Eliminación
                        DeleteBankAcount(cn)
                    Case 4 ' Abrir crystal reports
                        Me.Hide()
                        Form2.Show()
                End Select
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Sub RegisterBankUser(cn As SqlConnection)
        Dim cmd As New SqlCommand("INSERT INTO dbo.Banco ([user], fechaAlta, money) VALUES (@user, @fechaAlta, @money)", cn)
        With cmd.Parameters
            .AddWithValue("@user", txtUsuario.Text)
            .AddWithValue("@fechaAlta", DateTime.Today)
            .AddWithValue("@money", Decimal.Parse(txtSaldoInicial.Text))
        End With
        cn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Usuario registrado exitosamente")
        cn.Close()
        ClearIngresarFields()
    End Sub
    Private Sub btnBuscarI_Click(sender As Object, e As EventArgs) Handles btnBuscarI.Click
        'Recuperación de datos
        cn.Open()
        Dim cmd As New SqlCommand("select * from Banco where idUser=@idUsr", cn)
        cmd.Parameters.AddWithValue("@idUsr", txtIdI.Text)

        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Banco")

        If ds.Tables("Banco").Rows.Count > 0 Then
            txtUsuarioI.Text = ds.Tables("Banco").Rows(0).Item(1).ToString
            SaldoActualI.Text = ds.Tables("Banco").Rows(0).Item(3).ToString
        Else
            MsgBox("No existe el usuario")
        End If
        cn.Close()
    End Sub
    Private Sub btnBuscarR_Click(sender As Object, e As EventArgs) Handles btnBuscarR.Click
        'Recuperación de datos
        cn.Open()
        Dim cmd As New SqlCommand("select * from Banco where idUser=@idUsr", cn)
        cmd.Parameters.AddWithValue("@idUsr", txtIdR.Text)

        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Banco")

        If ds.Tables("Banco").Rows.Count > 0 Then
            txtUsrR.Text = ds.Tables("Banco").Rows(0).Item(1).ToString
            SaldoActualR.Text = ds.Tables("Banco").Rows(0).Item(3).ToString
        Else
            MsgBox("No existe el usuario")
        End If
        cn.Close()
    End Sub
    Private Sub btnBuscarE_Click(sender As Object, e As EventArgs) Handles btnBuscarE.Click
        'Recuperación de datos
        cn.Open()
        Dim cmd As New SqlCommand("select * from Banco where idUser=@idUsr", cn)
        cmd.Parameters.AddWithValue("@idUsr", txtIdE.Text)

        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adaptador.Fill(ds, "Banco")

        If ds.Tables("Banco").Rows.Count > 0 Then
            txtUsrE.Text = ds.Tables("Banco").Rows(0).Item(1).ToString
            txtFechaE.Text = ds.Tables("Banco").Rows(0).Item(2).ToString
            txtSaldoE.Text = ds.Tables("Banco").Rows(0).Item(3).ToString
        Else
            MsgBox("No existe el usuario")
        End If
        cn.Close()
    End Sub


    Private Sub RecuperarDatos(cn As SqlConnection)
        cn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Banco", cn)
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        ' Limpia el DataSet antes de llenarlo
        ds.Clear()

        ' Llena el DataSet
        adaptador.Fill(ds, "Banco")

        ' Asigna los datos al DataGridView
        DataGridView1.DataSource = ds.Tables("Banco")
        cn.Close()
    End Sub

    Private Sub IngresarBankAcount(cn As SqlConnection)
        Try
            ' Validate input before processing
            Dim inputAmount As Double
            If Not Double.TryParse(txtDineroI.Text.Replace(",", "."), inputAmount) Then
                MessageBox.Show("Por favor ingrese un monto válido")
                Return
            End If

            ' Define commands outside of connection scope
            Dim selectCmd As New SqlCommand("SELECT ISNULL(money, 0) FROM dbo.Banco WHERE idUser = @idUser", cn)
            selectCmd.Parameters.AddWithValue("@idUser", txtIdI.Text)

            Dim currentMoney As Double = 0

            ' Use Using blocks for proper resource disposal
            Using cn
                cn.Open()

                ' Get current balance
                Dim result = selectCmd.ExecuteScalar()
                If result IsNot Nothing Then
                    currentMoney = Convert.ToDouble(result)
                End If

                ' Update UI with current balance
                SaldoActualI.Text = currentMoney.ToString("F0")

                ' Calculate new balance
                Dim newMoney As Double = currentMoney + inputAmount

                ' Update balance in database
                Dim updateCmd As New SqlCommand("UPDATE dbo.Banco SET money = @money WHERE idUser = @idUser", cn)
                updateCmd.Parameters.Add("@money", SqlDbType.Decimal).Value = newMoney
                updateCmd.Parameters.AddWithValue("@idUser", txtIdI.Text)

                Dim rowsAffected = updateCmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Depósito realizado con éxito")
                Else
                    MessageBox.Show("No se encontró la cuenta especificada")
                End If
            End Using

        Catch ex As SqlException
            MessageBox.Show("Error de base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        cn.Close()
        ClearIngresarFields()
    End Sub

    Private Sub RetirarBankAcount(cn As SqlConnection)
        ' Primero hacemos SELECT para obtener el saldo actual
        Dim currentMoney As Decimal
        Dim selectCmd As New SqlCommand("SELECT money FROM dbo.Banco WHERE idUser = @idUser", cn)
        selectCmd.Parameters.AddWithValue("@idUser", txtIdR.Text)

        cn.Open()
        currentMoney = Convert.ToDecimal(selectCmd.ExecuteScalar())
        SaldoActualR.Text = currentMoney

        ' Verificamos que haya saldo suficiente
        Dim withdrawAmount As Decimal = Convert.ToDecimal(txtDineroR.Text)
        If currentMoney < withdrawAmount Then
            MessageBox.Show("Saldo insuficiente")
            cn.Close()
            Return
        End If

        ' Calculamos el nuevo saldo restando el retiro
        Dim newMoney As Decimal = currentMoney - withdrawAmount

        ' Hacemos UPDATE con el nuevo saldo
        Dim updateCmd As New SqlCommand("UPDATE dbo.Banco SET money = @money WHERE idUser = @idUser", cn)
        With updateCmd.Parameters
            .AddWithValue("@money", newMoney.ToString)
            .AddWithValue("@idUser", txtIdR.Text)
        End With

        updateCmd.ExecuteNonQuery()
        MessageBox.Show("Retiro realizado exitosamente. Nuevo saldo: " & newMoney.ToString("C"))
        cn.Close()
        ClearRetirarFields()
    End Sub

    Private Sub DeleteBankAcount(cn As SqlConnection)
        Dim cmd As New SqlCommand("DELETE FROM Banco WHERE idUser = @idUser", cn)
        cmd.Parameters.AddWithValue("@idUser", txtIdE.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Eliminación completada exitosamente")
        ClearDeletionFields()
        cn.Close()
    End Sub

    Private Sub ClearIngresarFields()
        txtIdI.Clear()
        txtDineroI.Clear()
        SaldoActualI.Text = "_____"
        txtUsuarioI.Text = "_____"
    End Sub

    Private Sub ClearRetirarFields()
        txtIdR.Clear()
        txtDineroR.Clear()
        SaldoActualR.Text = "_____"
        txtUsrR.Text = "_____"
    End Sub

    Private Sub ClearDeletionFields()
        txtIdE.Clear()
        txtUsrE.Clear()
        txtFechaE.Clear()
        txtSaldoE.Clear()
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

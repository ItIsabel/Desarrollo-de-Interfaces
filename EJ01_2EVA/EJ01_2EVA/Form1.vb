Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Private conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            conexion.Open()
            MsgBox("Se ha realizado correctamente la conexión")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class

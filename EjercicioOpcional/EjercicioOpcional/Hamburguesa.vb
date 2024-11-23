Imports System.Runtime.CompilerServices

Public Class Hamburguesa
    Public Property Ingredientes As New List(Of String)
    Public Property id As Integer

    ' Inicialización en el constructor
    Public Sub New(id As Integer)
        Me.id = id
    End Sub

    Public Function ToString() As String
        Dim Resumen As New System.Text.StringBuilder()
        ' Encabezado
        Resumen.AppendLine($"Hamburguesa #{id}")
        ' Ingredientes
        If Ingredientes.Count > 0 Then
            Resumen.AppendLine("INGREDIENTES:")
            For i As Integer = 0 To Ingredientes.Count - 1
                Resumen.AppendLine($"{i + 1}. {Ingredientes(i)}")
            Next
        Else
            Resumen.AppendLine("Hamburguesa básica sin ingredientes adicionales")
        End If

        Return Resumen.ToString()
    End Function
End Class

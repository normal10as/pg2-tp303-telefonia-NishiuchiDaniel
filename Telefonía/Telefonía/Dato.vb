Public Class Dato
    Inherits Plan

    Public Sub New(credito As UInteger, precio As Decimal)
        Me.Credito = credito
        Me.Precio = precio
        consumo = 0
    End Sub

    Public Overrides Function getDisponible() As UInteger
        Return Credito / Precio - consumo / 1000000
    End Function

    Public Overrides Sub NuevoConsumo(valor As UInteger)
        valor = valor * 1000000
        consumo += valor
    End Sub


    Public Overrides Function ToString() As String
        Return getDisponible() & " Mbytes"
    End Function
End Class

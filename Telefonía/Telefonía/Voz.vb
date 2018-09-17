Public Class Voz
    Inherits Plan

    Public Sub New(credito As UInteger, precio As Decimal)
        Me.Credito = credito
        Me.Precio = precio
        consumo = 0
    End Sub

    Public Overrides Function getDisponible() As UInteger
        Return Credito / Precio - consumo
    End Function

    Public Overrides Function ToString() As String
        Return getDisponible() & " Minutos"
    End Function

End Class

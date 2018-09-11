Public MustInherit Class Plan

    Private _credito As UInteger
    Private _precio As Decimal
    Protected consumo As UInteger

    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Overridable Sub NuevoConsumo(valor As UInteger)
        consumo += valor
    End Sub

    Public MustOverride Function getDisponible() As UInteger


End Class

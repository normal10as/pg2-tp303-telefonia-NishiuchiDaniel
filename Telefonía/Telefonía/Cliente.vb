Public Class Cliente

    Private _cuenta As UInteger

    Public Sub New()
        Me.Cuenta = 0
    End Sub

    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property


End Class

Public Class Empresa
    Inherits Cliente

    Private _razonSocial As String
    Private _cuit As String


    Public Sub New(RazonSocial As String, Cuit As String)
        Me.RazonSocial = RazonSocial
        Me.Cuit = Cuit
    End Sub

    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = ComprobarLargoCadena(value, 80)
        End Set
    End Property

    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = ComprobarLargoCadena(value, 13)
        End Set
    End Property

    Private Function ComprobarLargoCadena(cadena As String, largo As UShort) As String
        If cadena.Length < largo Then
            Return cadena
        Else
            Return "Caracteres excedidos"
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "Razon Social: " & RazonSocial & " Cuenta: " & Cuenta
    End Function

End Class

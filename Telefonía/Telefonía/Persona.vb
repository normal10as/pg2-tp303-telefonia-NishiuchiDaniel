Public Class Persona
    Inherits Cliente

    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger

    Public Sub New(Apellido As String, Nombre As String, Documento As UInteger)
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Documento = Documento
    End Sub

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = ComprobarLargoCadena(value, 30)
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = ComprobarLargoCadena(value, 50)
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Private Function ComprobarLargoCadena(cadena As String, longitud As UShort) As String
        If cadena.Length < longitud Then
            Return cadena
        Else
            Return "Caracteres Excedidos"
        End If

    End Function

    Public Overrides Function ToString() As String
        Return "Apellido: " & Apellido & " Nombre: " & Nombre & " Cuenta: " & Cuenta
    End Function
End Class

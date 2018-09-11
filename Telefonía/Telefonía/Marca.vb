Public Class Marca
    Private _nombre As String

    Public Sub New(Nombre As String)
        Me.Nombre = Nombre
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Nombre: " & Nombre
    End Function

End Class

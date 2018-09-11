Public Class Equipo

    Private _serie As String
    Private marca As String
    Private modelo As String
    Private fecha As Date

    Public Sub New(Marca As String, Modelo As String, Serie As String)
        Me.marca = Marca
        Me.modelo = Modelo
        Me.Serie = Serie
    End Sub

    Public ReadOnly Property FechaVenta As Date
        Get
            Return Me.fecha
        End Get
    End Property


    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = ComprobarLargoCadena(value, 15)
        End Set
    End Property

    Public Sub vender(Fecha As Date)
        Me.fecha = Fecha
    End Sub

    Private Function ComprobarLargoCadena(Cadena As String, Largo As UShort) As String
        If Cadena.Length < Largo Then
            Return Cadena
        Else
            Return ""
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "Serie: " & Serie
    End Function

End Class

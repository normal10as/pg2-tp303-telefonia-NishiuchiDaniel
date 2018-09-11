Public Class Linea

    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String

    Public Sub New(CodigoArea As UShort, Numero As UInteger)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
    End Sub

    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property

    Public Sub suspender()
        _estado = "Suspendida"
    End Sub

    Public Sub reactivar()
        _estado = "Activada"
    End Sub

    Public Overrides Function ToString() As String
        If Estado = "Activada" Then
            Return "Codigo Area: " & CodigoArea & " - Numero: " & Numero
        Else
            Return "Codigo Area: " & CodigoArea & " - Numero: " & Numero & " Suspendida"
        End If
    End Function

End Class

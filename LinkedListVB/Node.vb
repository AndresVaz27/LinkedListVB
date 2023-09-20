Public Class Node
    Private dato_ As Integer
    Private name_ As String
    Private siguiente_ As Node

    Public Property Dato As Integer
        Get
            Return dato_
        End Get
        Set(ByVal value As Integer)
            dato_ = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return name_
        End Get
        Set(ByVal value As String)
            name_ = value
        End Set
    End Property

    Public Property Siguiente As Node
        Get
            Return siguiente_
        End Get
        Set(ByVal value As Node)
            siguiente_ = value
        End Set
    End Property

    Public Sub New()
        Dato = 0
        Name = ""
        Siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer)
        Me.Dato = d
        Name = ""
        Siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer, ByVal n As String, ByVal s As Node)
        Me.Dato = d
        Me.Name = n
        Me.Siguiente = s
    End Sub

    Public Overridable Function ToString2() As String
        Return dato.ToString() & " " & name
    End Function
End Class

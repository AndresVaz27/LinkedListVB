Public Class LinkedList
    Inherits Node
    Private head_ As Node

    Public Function ToArray() As String()
        Dim result As String() = New String(Count() - 1) {}
        Dim index = 0
        Dim node As Node = head_

        While node IsNot Nothing
            result(index) = node.Dato.ToString()
            node = node.Siguiente
        End While

        Return result
    End Function

    Public Property Head As Node
        Get
            Return head_
        End Get
        Set(ByVal value As Node)
            head_ = value
        End Set
    End Property

    Public Sub New()
        head_ = Nothing
    End Sub

    Public Sub Add(ByVal NewNode As Node)
        If head_ Is Nothing Then
            head_ = NewNode
            Return
        End If

        If NewNode.Dato < Head.Dato Then
            NewNode.Siguiente = Head
            Head = NewNode
            Return
        End If

        Dim h As Node = head_

        While h.Siguiente IsNot Nothing

            If NewNode.Dato < h.Siguiente.Dato Then
                Exit While
            End If

            h = h.Siguiente
        End While

        NewNode.Siguiente = h.Siguiente
        h.Siguiente = NewNode
    End Sub

    Public Sub Remove(ByVal dat As Integer)
        If Head Is Nothing Then
            Return
        End If

        If Head.Dato = dat Then
            Head = Head.Siguiente
            Return
        End If

        Dim h As Node = Head

        While h.Siguiente IsNot Nothing

            If h.Siguiente.Dato = dat Then
                Exit While
            End If

            h = h.Siguiente
        End While

        If h.Siguiente IsNot Nothing Then
            h.Siguiente = h.Siguiente.Siguiente
        End If
    End Sub

    Public Function Exist(ByVal dat As Integer) As Boolean
        If Head Is Nothing Then
            Return False
        End If

        If Head.Dato = dat Then
            Return True
        End If

        Dim h As Node = Head

        While h.Siguiente IsNot Nothing

            If h.Siguiente.Dato >= dat Then
                Exit While
            End If

            h = h.Siguiente
        End While

        If h.Siguiente IsNot Nothing AndAlso h.Siguiente.Dato = dat Then
            Return True
        End If

        Return False
    End Function

    Public Function IsEmpty() As Boolean
        Return head_ Is Nothing
    End Function

    Public Function Count() As Integer
        Dim c As Integer = 0
        Dim h As Node = head_

        While h IsNot Nothing
            c += 1
            h = h.Siguiente
        End While

        Return c
    End Function

    Public Overrides Function ToString2() As String
        Dim h As Node = head_
        Dim r As String = ""

        While h IsNot Nothing
            r += h.ToString2() + Name & " "
            h = h.Siguiente
        End While

        Return r
    End Function
End Class

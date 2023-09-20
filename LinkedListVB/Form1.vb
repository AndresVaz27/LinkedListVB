Imports System.Text.Json

Public Class Form1
    Dim List1 As LinkedList
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        List1 = New LinkedList
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Label1.Text = String.Empty
        Dim data As Integer = Integer.Parse(txtDato.Text)

        If List1.Exist(data) Then
            MessageBox.Show("El nodo ya existe")
            txtDato.Clear()
            Return
        End If
        Dim MiNodo As Node = New Node()
        MiNodo.Dato = data
        MiNodo.Name = txtName.Text
        List1.Add(MiNodo)
        Label1.Text = List1.ToString2()
        txtDato.Clear()
        txtDato.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As Integer = Integer.Parse(txtDato.Text)
        List1.Remove(b)
        Label1.Text = List1.ToString2()
        txtDato.Clear()
        txtDato.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim length As Integer = Integer.Parse(txtNumNodos.Text)

        For i As Integer = 0 To length - 1
            Dim newnode As Node = New Node()
            newnode.Dato = i + 1
            newnode.Name = "test" & (i + 1)
            List1.Add(newnode)
        Next

        Label1.Text = List1.ToString2()
    End Sub
End Class

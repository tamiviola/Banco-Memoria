Public Class ClienteBLL

    Private Shared instancia As ClienteBLL = Nothing
    Private Sub New()

    End Sub

    Public Shared Function ObtenerInstancia() As ClienteBLL
        If instancia Is Nothing Then
            instancia = New ClienteBLL
        End If
        Return instancia
    End Function

    Private Shared listaClientes As New List(Of EE.Cliente)

    Public Sub Crear(ByVal c As EE.Cliente)
        listaClientes.Add(c)
    End Sub

    Public Sub Baja(ByVal c As EE.Cliente)
        listaClientes.Remove(c)
    End Sub

    Public Function ConsultarPorId(ByVal id As Integer) As EE.Cliente
        For Each c As EE.Cliente In listaClientes
            If id = c.Id Then
                Return c
            End If
        Next
        Return Nothing
    End Function

    Public Function Listar() As List(Of EE.Cliente)
        Return listaClientes
    End Function

    Public Sub Editar(ByVal c As EE.Cliente)
        Baja(c)
        Crear(c)
    End Sub

End Class

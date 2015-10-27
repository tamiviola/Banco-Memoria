Public Class CuentaBancariaBLL

    Private Shared instancia As CuentaBancariaBLL = Nothing

    Private Sub New()

    End Sub

    Public Shared Function ObtenerInstancia() As CuentaBancariaBLL
        If instancia Is Nothing Then
            instancia = New CuentaBancariaBLL
        End If
        Return instancia
    End Function

    Private Shared listaCuentasBancarias As New List(Of EE.CuentaBancaria)

    Public Sub Crear(ByVal cuenta As EE.CuentaBancaria)
        listaCuentasBancarias.Add(cuenta)
    End Sub

    Public Sub Baja(ByVal cuenta As EE.CuentaBancaria)
        listaCuentasBancarias.Remove(cuenta)
    End Sub

    Public Sub Editar(ByVal cuenta As EE.CuentaBancaria)
        Baja(cuenta)
        Crear(cuenta)
    End Sub

    Public Function ConsultarPorId(ByVal id As Integer) As EE.CuentaBancaria
        For Each c As EE.CuentaBancaria In listaCuentasBancarias
            If c.Id = id Then
                Return c
            End If
        Next
        Return Nothing
    End Function

    Public Function Listar() As List(Of EE.CuentaBancaria)
        Return listaCuentasBancarias
    End Function

    Public Sub Depositar(ByVal id As Integer, ByVal monto As Double)
        For Each c As EE.CuentaBancaria In listaCuentasBancarias
            If c.Id = id Then
                c.Depositar(monto)
            End If
        Next
    End Sub

    Public Sub Extraer(ByVal id As Integer, ByVal monto As Double)
        For Each c As EE.CuentaBancaria In listaCuentasBancarias
            If c.Id = id Then
                c.Extraer(monto)
            End If
        Next
    End Sub

    Public Sub Transferir(ByVal idOrigen As Integer, ByVal idDestino As Integer, ByVal monto As Double)
        For Each c As EE.CuentaBancaria In listaCuentasBancarias
            If c.Id = idOrigen Then
                For Each c2 As EE.CuentaBancaria In listaCuentasBancarias
                    If c2.Id = idDestino Then
                        c.Transferir(c2, monto)
                    End If
                Next
            End If
        Next

    End Sub
End Class

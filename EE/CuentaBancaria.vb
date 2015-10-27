﻿Public MustInherit Class CuentaBancaria

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property

    Private vSaldo As Double
    Public Property Saldo() As Double
        Get
            Return vSaldo
        End Get
        Set(ByVal value As Double)
            vSaldo = value
        End Set
    End Property

    Private vListaClientes As New List(Of Cliente)
    Public Property ListaClientes() As List(Of Cliente)
        Get
            Return vListaClientes
        End Get
        Set(ByVal value As List(Of Cliente))
            vListaClientes = value
        End Set
    End Property

    Public Sub Depositar(ByVal monto As Double)
        Me.Saldo = Me.Saldo + monto
    End Sub

    Public MustOverride Sub Extraer(ByVal monto As Double)

    Public MustOverride Sub Transferir(ByVal cuentaDestino As EE.CuentaBancaria, ByVal monto As Double)

End Class

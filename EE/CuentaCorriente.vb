Public Class CuentaCorriente
    Inherits CuentaBancaria

    Private vDescubierto As Double = 1000
    Public Property Descubierto() As Double
        Get
            Return vDescubierto
        End Get
        Set(ByVal value As Double)
            vDescubierto = value
        End Set
    End Property

    Public Overrides Sub Extraer(monto As Double)
        If Me.Saldo + Me.Descubierto >= monto Then
            Me.Saldo = Me.Saldo - monto
        End If
    End Sub

    Public Overrides Sub Transferir(cuentaDestino As CuentaBancaria, monto As Double)
        If Me.Saldo + Me.Descubierto >= monto Then
            Me.Saldo = Me.Saldo - monto
            cuentaDestino.Saldo = cuentaDestino.Saldo + monto
        End If
    End Sub
End Class

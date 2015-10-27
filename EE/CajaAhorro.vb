Public Class CajaAhorro
    Inherits CuentaBancaria

    Public Overrides Sub Extraer(monto As Double)
        If Me.Saldo >= monto Then
            Me.Saldo = Me.Saldo - monto
        End If
    End Sub

    Public Overrides Sub Transferir(cuentaDestino As CuentaBancaria, monto As Double)
        Dim cantidadCienes As Integer = Convert.ToInt32(monto / 100)
        Dim intereses As Double = cantidadCienes * 0.01
        If Me.Saldo >= monto Then
            Me.Saldo = Me.Saldo - monto - intereses
            cuentaDestino.Saldo = cuentaDestino.Saldo + monto
        End If
    End Sub
End Class

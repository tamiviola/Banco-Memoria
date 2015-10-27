Public Class Cliente

    Private vId As Integer
    Public Property Id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property


    Private vNombre As String
    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Private vApellido As String
    Public Property Apellido() As String
        Get
            Return vApellido
        End Get
        Set(ByVal value As String)
            vApellido = value
        End Set
    End Property

    Private vDireccion As String
    Public Property Direccion() As String
        Get
            Return vDireccion
        End Get
        Set(ByVal value As String)
            vDireccion = value
        End Set
    End Property

    Private vTelefono As New Telefono
    Public Property Telefono() As Telefono
        Get
            Return vTelefono
        End Get
        Set(ByVal value As Telefono)
            vTelefono = value
        End Set
    End Property

    Private vListaCuentasBancarias As New List(Of EE.CuentaBancaria)
    Public Property ListaCuentasBancarias() As List(Of EE.CuentaBancaria)
        Get
            Return vListaCuentasBancarias
        End Get
        Set(ByVal value As List(Of EE.CuentaBancaria))
            vListaCuentasBancarias = value
        End Set
    End Property

End Class

Public Class CuentaController
    Inherits System.Web.Mvc.Controller

    Private vBLL As BLL.CuentaBancariaBLL
    Private vCBLL As BLL.ClienteBLL

    Sub New()
        Me.vCBLL = BLL.ClienteBLL.ObtenerInstancia
        Me.vBLL = BLL.CuentaBancariaBLL.ObtenerInstancia
    End Sub

    ' GET: /Cuenta
    Function Index() As ActionResult
        Dim vLista As List(Of EE.CuentaBancaria) = Me.vBLL.Listar()
        Return View(vLista)
    End Function

    ' GET: /Cuenta/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' GET: /Cuenta/Create
    Function Crear() As ActionResult
        ViewBag.Clientes = Me.vCBLL.Listar()
        Return View()
    End Function

    ' POST: /Cuenta/Create
    <HttpPost()>
    Function Crear(ByVal form As FormCollection) As ActionResult
        Dim clientesSelecionados As String = form.Item("ClientesSeleccionados")
        If clientesSelecionados <> "" And clientesSelecionados IsNot Nothing Then
            Dim listaClientesString As List(Of String) = clientesSelecionados.Split(","c).ToList()
            Dim tipo As String = form.Item("Tipo")

            Dim cuenta As EE.CuentaBancaria
            If tipo = "Caja Ahorro" Then
                cuenta = New EE.CajaAhorro
            Else
                cuenta = New EE.CuentaCorriente
            End If
            cuenta.Id = form.Item("Id")
            For Each s As String In listaClientesString
                Dim c As New EE.Cliente
                c.Id = Convert.ToInt16(s)
                cuenta.ListaCLientes.Add(c)
            Next
            Me.vBLL.Crear(cuenta)
            Return RedirectToAction("Index")
        End If
        ViewBag.Clientes = Me.vCBLL.Listar()
        Return View()
    End Function

    Function Depositar() As ActionResult
        Return View()
    End Function

    <HttpPost()>
    Function Depositar(ByVal id As Integer, ByVal model As DepositarViewModel) As ActionResult
        If ModelState.IsValid Then
            Me.vbll.Depositar(id, model.Monto)
            Return RedirectToAction("Index")
        End If

        Return View(model)
    End Function

    Function Extraer() As ActionResult
        Return View()
    End Function

    <HttpPost()>
    Function Extraer(ByVal id As Integer, ByVal model As DepositarViewModel) As ActionResult
        If ModelState.IsValid Then
            Me.vbll.Extraer(id, model.Monto)
            Return RedirectToAction("Index")
        End If

        Return View(model)
    End Function

    Function Transferir() As ActionResult
        ViewBag.Cuentas = Me.vbll.Listar()
        Return View()
    End Function

    <HttpPost()>
    Function Transferir(ByVal id As Integer, ByVal model As TransferirViewModel) As ActionResult
        If ModelState.IsValid Then
            Me.vbll.Transferir(id, model.DestinoId, model.Monto)
            Return RedirectToAction("Index")
        End If
        ViewBag.Cuentas = Me.vbll.Listar()
        Return View(model)
    End Function

    ' GET: /Cuenta/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Cuenta/Edit/5
    <HttpPost()>
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add update logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    ' GET: /Cuenta/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Cuenta/Delete/5
    <HttpPost()>
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add delete logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class
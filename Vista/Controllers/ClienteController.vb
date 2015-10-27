Public Class ClienteController
    Inherits System.Web.Mvc.Controller

    Private vBLL As BLL.ClienteBLL

    Sub New()
        Me.vBLL = BLL.ClienteBLL.ObtenerInstancia
    End Sub

    ' GET: /Cliente
    Function Index() As ActionResult
        Dim vLista As List(Of EE.Cliente) = Me.vBLL.Listar()
        Return View(vLista)
    End Function

    ' GET: /Cliente/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' GET: /Cliente/Create
    Function Crear() As ActionResult
        Return View()
    End Function

    ' POST: /Cliente/Create
    <HttpPost()>
    Function Crear(ByVal c As EE.Cliente) As ActionResult
        If ModelState.IsValid Then
            Me.vBLL.Crear(c)
            Return RedirectToAction("Index")
        End If
        Return View(c)
    End Function

    ' GET: /Cliente/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Cliente/Edit/5
    <HttpPost()>
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add update logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    ' GET: /Cliente/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Cliente/Delete/5
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
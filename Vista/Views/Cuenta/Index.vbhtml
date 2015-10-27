@ModelType IEnumerable(Of EE.CuentaBancaria)

<h2>Index</h2>

<p>
    @Html.ActionLink("Crear nueva cuenta", "Crear")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Id)
        </th>
        <th>
            Tipo
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Saldo)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
             <td>
                 @Html.DisplayFor(Function(modelItem) item.Id)
             </td>
             <td>
                 @Code
                 If item.GetType() = GetType(EE.CajaAhorro) Then
                 @: Caja de ahorro   
                 Else
                 @: Cuenta corriente
                 End If
                 End Code
             </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Saldo)
            </td>
            <td>
                @Html.ActionLink("Depositar", "Depositar", New With {.id = item.Id}) |
                @Html.ActionLink("Extraer", "Extraer", New With {.id = item.Id}) |
                @Html.ActionLink("Transferir", "Transferir", New With {.id = item.Id}) |
                @Html.ActionLink("Editar", "Edit", New With {.id = item.Id}) |
                @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>

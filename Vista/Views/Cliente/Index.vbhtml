@ModelType IEnumerable(Of EE.Cliente)

<h2>Index</h2>

<p>
    @Html.ActionLink("Crear Nuevo", "Crear")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono.Tipo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono.Numero)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Apellido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Direccion)
        </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.Telefono.Tipo)
         </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.Telefono.Numero)
         </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>

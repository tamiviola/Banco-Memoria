@ModelType EE.CuentaBancaria

<h2>Crear</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>CuentaBancaria</h4>
        <hr />
        @Html.ValidationSummary(True)

        <label>Id</label>
        <input type="text" name="Id" />
        <label>Tipo</label>

        <select name="Tipo">
            <option value="Caja Ahorro">
                Caja Ahorro
            </option>
            <option value="Cuenta Corriente">
                Cuenta Corriente
            </option>
        </select>

        <label>Clientes</label>
        <select name="ClientesSeleccionados" multiple="multiple">
            @For Each c As EE.Cliente In ViewBag.Clientes
                @<option value="@c.Id">
                    @c.Nombre @c.Apellido
                </option>
            Next
        </select>

        <div class="form-group">
            <br />
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Crear" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    <br />
    @Html.ActionLink("Volver a la lista", "Index")
</div>

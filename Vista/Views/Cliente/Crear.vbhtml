@ModelType EE.Cliente

<h2>Crear</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Cliente</h4>
        <hr />
        @Html.ValidationSummary(True)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Id)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Id)
                @Html.ValidationMessageFor(Function(model) model.Id)
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Nombre)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Nombre)
                @Html.ValidationMessageFor(Function(model) model.Nombre)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Apellido)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Apellido)
                @Html.ValidationMessageFor(Function(model) model.Apellido)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Direccion)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Direccion)
                @Html.ValidationMessageFor(Function(model) model.Direccion)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Telefono.Tipo)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Telefono.Tipo)
                @Html.ValidationMessageFor(Function(model) model.Telefono.Tipo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Telefono.Numero)
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Telefono.Numero)
                @Html.ValidationMessageFor(Function(model) model.Telefono.Numero)
            </div>
        </div>

        <div class="form-group">
            <br />
            <div>
                <input type="submit" value="Crear" />
            </div>
        </div>
    </div>
End Using

<div>
    <br />
    @Html.ActionLink("Volver a la lista", "Index")
</div>

@ModelType DepositarViewModel

<h2>Extraer</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>DepositarViewModel</h4>
        <hr />
        @Html.ValidationSummary(True)
        <label>Monto</label>
        @Html.TextBoxFor(Function(model) model.Monto)
        <div class="form-group">
            <div>
                <input type="submit" value="Crear"/>
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Volver a la lista", "Index")
</div>



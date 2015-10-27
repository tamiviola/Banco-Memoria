@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>_Layout</title>
</head>
<body>
    <div>
        <ul>
            <li>
                @Html.ActionLink("Clientes", "Index", "Cliente")
            </li>
            <li>
                @Html.ActionLink("Cuentas", "Index", "Cuenta")
            </li>
        </ul>
    </div>
    @RenderBody()
</body>
</html>

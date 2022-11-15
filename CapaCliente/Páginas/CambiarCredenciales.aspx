<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarCredenciales.aspx.cs" Inherits="CapaCliente.Páginas.CambiarCredenciales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cambiar credenciales</title>
    <link rel="stylesheet" href="https://bootswatch.com/4/darkly/bootstrap.min.css">
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="AgregarProductoNuevo.aspx">Administrar Productos</asp:HyperLink>
        </div>
        <p>
            Identificación&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control me-sm-2" ID="txt_ID" runat="server" Width="163px"></asp:TextBox>
        </p>
        <p>
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control me-sm-2" ID="txt_Nombre" runat="server" Width="161px"></asp:TextBox>
        </p>
        <p>
            Apellidos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control me-sm-2" ID="txt_Apellidos" runat="server"  Width="170px" OnTextChanged="txt_Apellidos_TextChanged"></asp:TextBox>
        </p>
        <p>
            Contraseña&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control me-sm-2" ID="txt_Clave" runat="server" Width="170px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button class="btn btn-primary" ID="btn_Cambiar" runat="server" OnClick="btn_Cambiar_Click" Text="Cambiar Credenciales" />
        </p>
    </form>
        </center>
</body>
</html>

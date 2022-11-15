<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="CapaCliente.Páginas.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Crear usuario nuevo</title>
    <link rel="stylesheet" href="https://bootswatch.com/4/darkly/bootstrap.min.css">
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            Ingrese los datos para la creacion de su usuario<br />
            <br />
            <br />
            <br />
            Identificacion&nbsp;&nbsp;
            <asp:TextBox ID="txt_ID" runat="server" Width="169px" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Nombre" runat="server" Width="168px" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            Apellidos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Apellidos" runat="server" Width="168px" MaxLength="50" OnTextChanged="txt_Apellidos_TextChanged"></asp:TextBox>
            <br />
            Contraseña&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblClave" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <div>
               <asp:Button class="btn btn-primary" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" style="width: 68px" />
        &nbsp;&nbsp;&nbsp;
               <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Login.aspx">LogIn</asp:HyperLink>
        </div>
    </form>
       </center>
</body>
</html>

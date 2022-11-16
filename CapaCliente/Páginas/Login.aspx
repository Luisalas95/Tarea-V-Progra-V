<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaCliente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="https://bootswatch.com/4/darkly/bootstrap.min.css">
         <link rel="stylesheet" href="../CSS/Estilos_Login.css"/>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            Inicio de Sesion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="lbl_UsuarioNuevo" runat="server" NavigateUrl="CrearUsuario.aspx">Crear Usuario Nuevo </asp:HyperLink>

        </div>
        <p >
          Usuario&nbsp;&nbsp;
            <input id="txt_Usuario2" type="text" required="required" runat="server" maxlength="20" class="form-control me-sm-2"   width="12px" />
        </p>
        <p>
              Contraseña&nbsp;&nbsp;

          <input id="txt_Clave2" type="password" required="required" runat="server" maxlength="20" class="form-control me-sm-2"  width="180px" />

        </p>
       
        <div style="margin-left: 80px">
            <asp:Button class="btn btn-primary" ID="btn_IniciarSesion" runat="server" OnClick="btn_IniciarSesion_Click" Text="Iniciar Sesion" />
            
       </div>
        <p style="margin-left: 80px">
            &nbsp;</p>
    </form>
        </center>
</body>

</html>

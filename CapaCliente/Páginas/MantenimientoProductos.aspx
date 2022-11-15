<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoProductos.aspx.cs" Inherits="CapaCliente.Páginas.MantenimientoProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link rel="stylesheet" href="../CSS/Estilos.css"/>
    <title>Mantenimiento de Productos</title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
       
            <h2>Mantenimiento de Productos</h2>
            <br />
            <br />
              <label>Codigo Producto</label>
             <input readonly type="number" id="txt_codigoproduct"  runat="server" />   
          <!--  <asp:TextBox  ID="txt_CodigoProducto" runat="server"  MaxLength="25" Width="163px"></asp:TextBox> --> 
     
            <br />
             <label>Nombre Producto</label>
           <input type="text" id="txt_Nomb"  placeholder="Nombre Producto" runat="server" maxlength="30"/>

            <br />
             <label>Existencias</label>
           <input type="number" id="txt_existencia"  placeholder="Existencias" runat="server" />
            <br />
           <label>Ubicación Bodega</label>
           <input type="text" id="txt_UbicacionBodega"  placeholder="Ubicacion" runat="server" maxlength="20"/>

            <br />
            <br />
            <asp:Button ID="Btnactualizar" runat="server" Text="Actualizar" OnClick="Btnactualizar_Click" />
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" />
        </div>
           <br />
            <br />
        <div>
        



        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarProductoNuevo.aspx.cs" Inherits="CapaCliente.Páginas.AgregarProductoNuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="../CSS/Estilos.css"/>
    
    <title>Ingreso Productos</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous"/>

</head>


<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ingrese los datos del nuevo Producto</h2>
            <h2>&nbsp;</h2>
 
            <br />
            <br />
              <label>Codigo Producto</label>
             <input type="number" id="txt_codigoproduct"  placeholder="Codigo Producto" runat="server" required="required"/>   
          <!--  <asp:TextBox  ID="txt_CodigoProducto" runat="server"  MaxLength="25" Width="163px"></asp:TextBox> --> 
     
            <br />
             <label>Nombre Producto</label>
           <input type="text" id="txt_Nomb"  placeholder="Nombre Producto" runat="server" required="required" maxlength="30"/>

            <br />
             <label>Existencias</label>
           <input type="number" id="txt_existencia"  placeholder="Existencias" runat="server" required="required"/>
            <br />
           <label>Ubicación Bodega</label>
           <input type="text" id="txt_UbicacionBodega"  placeholder="Ubicacion" runat="server" required="required" maxlength="20"/>

            <br />
            <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
            <asp:Button ID="btn_GuardarProduc" runat="server" Text="Guardar Producto" OnClick="btn_GuardarProduc_Click" />
        </div>
           <br />
            <br />
        <div>
            <asp:GridView ID="GridViewProductos" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="563px" DataKeyNames="CodigoProducto" OnSelectedIndexChanged="GridViewProductos_SelectedIndexChanged1">
                 <Columns>
                <asp:CommandField HeaderText="Selección" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Font-Size="Smaller" HorizontalAlign="Center" VerticalAlign="Middle" Width="10px" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

            </asp:GridView>

        </div>

    </form>

  
    <asp:DropDownList ID="DropDownList1" runat="server" Visible="false"></asp:DropDownList>
   

</body>
</html>

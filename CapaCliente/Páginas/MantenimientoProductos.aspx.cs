using ConsumeApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CapaCliente.Páginas
{
    public partial class MantenimientoProductos : System.Web.UI.Page
    {
     //   private Productos ProductoNegocios = new Productos();
       // private Producto Producto1 = new Producto();
     

        protected void Page_Load(object sender, EventArgs e)
        {
             String CodigoProducto = Request.QueryString["CodigoP"];
            int CodigoProductoEntero = int.Parse(Request.QueryString["CodigoP"]);
            txt_codigoproduct.Value = CodigoProducto;






        }

        protected void Btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
         //       Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
           //     Producto1.NombreProducto = txt_Nomb.Value;
             // /  Producto1.Existencias = float.Parse(txt_existencia.Value);
              // / Producto1.BodegaUbicacion = txt_UbicacionBodega.Value;
               // ProductoNegocios.CrudProductos(2,Producto1);
                Response.Write("<script> alert('Se actualizo de forma correcta por favor regrese a la pantalla anterior')  </script> ");
                txt_codigoproduct.Value = "";
                txt_Nomb.Value = "";
                txt_UbicacionBodega.Value = "";
                txt_existencia.Value = "";

            }
            catch (Exception)
            {

                Response.Write("<script> alert('Error al actualizar')  </script> ");
            }


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
              
             /*   Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                Producto1.NombreProducto = "";
                Producto1.Existencias = 0;
                Producto1.BodegaUbicacion = "";
                ProductoNegocios.CrudProductos(3, Producto1);
               */ Response.Write("<script> alert('Se elimino de forma correcta por favor regrese a la pantalla anterior')  </script> ");
                txt_codigoproduct.Value = "";
                txt_Nomb.Value = "";
                txt_UbicacionBodega.Value = "";
                txt_existencia.Value = "";

            }
            catch (Exception)
            {

                Response.Write("<script> alert('Error al eliminar')  </script> ");
            }

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductoNuevo.aspx");
        }
    }
}
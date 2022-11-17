using Antlr.Runtime;
using ConsumeApis;
using ConsumeApis.APIS;
using QuickType2;
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
      // private Productos ProductoNegocios = new Productos();
       private Producto Producto1 = new Producto();
        private ApiProductos apiproduc = new ApiProductos();
        public  string tokens; 
        protected void Page_Load(object sender, EventArgs e)
        {
            tokens = Request.QueryString["Token"];
            if (!Page.IsPostBack)
            {
                string CodigoProducto = Request.QueryString["CodigoP"];
                string NombreProducto = Request.QueryString["NomProduct"];
                string Existencia = Request.QueryString["Existenc"];
                string Bodega = Request.QueryString["Bodeg"];
                txt_codigoproduct.Value = CodigoProducto;
                txt_Nomb.Value = NombreProducto;
                txt_existencia.Value = Existencia;
                txt_UbicacionBodega.Value = Bodega;
            }






        }

        protected void Btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {



                Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                Producto1.NombreProducto = txt_Nomb.Value;
               Producto1.Existencias = int.Parse(txt_existencia.Value);
              Producto1.BodegaUbicacion = txt_UbicacionBodega.Value;
              string codigorespuesta =  apiproduc.ActulizarProducto(Producto1, tokens);

                switch (codigorespuesta)
                {
                    case "204":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "alert", "alert('" + "El producto se actualizo con exito" + "')", true);

                        break;

                    case "401":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "confirm", "confirm('" + "Finalizo la sesion" + "')", true);

                        Response.Redirect("Login.aspx");
                        break;

                    case "500":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "alert", "alert('" + "error de servidor" + "')", true);

                        break;





                    default:
                        break;
                }



            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(),
                                           "alert", "alert('" + ex.Message + "')", true);
            }


        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigorespuesta = apiproduc.EliminarProducto(txt_codigoproduct.Value, tokens);
              
                switch (codigorespuesta)
                {
                    case "201":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "alert", "alert('" + "El producto se elimino con exito" + "')", true);
                        txt_codigoproduct.Value = "";
                        txt_Nomb.Value = "";
                        txt_existencia.Value = "";
                        txt_UbicacionBodega.Value = "";
                        break;

                    case "401":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "alert", "alert('" + "Finalizo la sesion" + "')", true);

                        Response.Redirect("Login.aspx");
                        break;

                    case "500":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                        "alert", "alert('" + "error de servidor" + "')", true);

                        break;





                    default:
                        break;
                }



            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(),
                                             "alert", "alert('" + ex.Message + "')", true);
            }

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductoNuevo.aspx?Token=" + tokens);
        }
    }
}
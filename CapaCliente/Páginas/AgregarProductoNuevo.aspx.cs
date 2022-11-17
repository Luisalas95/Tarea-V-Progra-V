using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsumeApis;
using Swashbuckle.Swagger;
using QuickType2;
using System.Security.Cryptography.X509Certificates;
using ConsumeApis.APIS;
using Antlr.Runtime;

namespace CapaCliente.Páginas
{
    public partial class AgregarProductoNuevo : System.Web.UI.Page
    {
        public ApiProductos ApiProduc = new ApiProductos();
        public  string tokens;




        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // if (!Page.IsPostBack)
               // {
                    tokens = Request.QueryString["Token"];
             
                List<Producto> NuevaLista = new List<Producto>();
                    NuevaLista = ApiProduc.ListarTodosProductos(tokens);

                    if (NuevaLista == null)
                    {

                        string msg = "Problemas para cargar los datos verifue su tokens";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                       "alert",
                       "alert('" + msg + "')", true);

                    }
                    else
                    {

                        GridViewProductos.DataSource = NuevaLista;
                        GridViewProductos.DataBind();

                    }



               // }





            }
            catch (Exception ex)
            {

                string msg = ex.Message;
                ScriptManager.RegisterStartupScript(this, GetType(),
               "alert",
               "alert('" + msg + "')", true);
            }

  


        }

        protected void btn_GuardarProduc_Click(object sender, EventArgs e)
        {
            try
            {
                Producto NuevoProducto = new Producto();
                NuevoProducto.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                NuevoProducto.NombreProducto = txt_Nomb.Value;
                NuevoProducto.BodegaUbicacion = txt_UbicacionBodega.Value;
                NuevoProducto.Existencias = int.Parse(txt_existencia.Value);
                String codigoresulta = ApiProduc.InsertaProducto(NuevoProducto, tokens);

                 switch (codigoresulta)
                {
                    case "201":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                       "alert",
                       "alert('" + "Se agrego con exito" + "')", true);
                        txt_codigoproduct.Value = "";
                        txt_Nomb.Value = "";
                        txt_UbicacionBodega.Value = "";
                        txt_existencia.Value = "";
                        List<Producto> NuevaLista = new List<Producto>();
                        NuevaLista = ApiProduc.ListarTodosProductos(tokens);
                        GridViewProductos.DataSource = NuevaLista;
                        GridViewProductos.DataBind();

                        break;
                    case "409":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                        "alert",
                        "alert('" + "El producto que esta intentando registrar ya existe" + "')", true);
                        break;

                    case "500":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                        "alert",
                        "alert('" + "Error de servidor" + "')", true);
                        break;

                    case "401":

                        ScriptManager.RegisterStartupScript(this, GetType(),
                        "alert",
                        "alert('" + "Se vencio la sesion" + "')", true);
                       
                        break;

                    default:

                        ScriptManager.RegisterStartupScript(this, GetType(),
                          "alert",
                          "alert('" + codigoresulta + "')", true);

                        break;
                }




            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(),
                                                           "alert", "alert('" + ex.Message + "')", true);
            }



        }

     

        protected void GridViewProductos_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = GridViewProductos.SelectedRow;
                int CodigoProducto = Convert.ToInt32(GridViewProductos.DataKeys[row.RowIndex].Value);
                List<Producto> NuevaLista = new List<Producto>();
                NuevaLista = ApiProduc.ListarTodosProductos(tokens);
                string NombreProducto= "";
                string Bodega ="";
                long Existencias =0;
                foreach (var item in NuevaLista)
                {
                    if (item.CodigoProducto == CodigoProducto)
                    {
                        NombreProducto = item.NombreProducto;
                        Bodega = item.BodegaUbicacion;
                        Existencias = item.Existencias;

                    }
                }

                  Response.Redirect("MantenimientoProductos.aspx?CodigoP=" + CodigoProducto
                   + "&NomProduct=" + NombreProducto + "&Existenc=" + Existencias + "&Bodeg=" + Bodega + "&Token=" + tokens);

            
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(),
                                                           "alert", "alert('" + ex.Message + "')", true);
            }

        }
    }
}
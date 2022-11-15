using ConsumeApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaCliente.Páginas
{
    public partial class CambiarCredenciales : System.Web.UI.Page
    {
        string ClaveNueva = "";
        string Clave = "";
        string ClaveEncriptada = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Cambiar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txt_ID.Text;
                int result = Int32.Parse(usuario);
                string clave = txt_Clave.Text;
                string Apellidos = txt_Apellidos.Text;
                string Nombre = txt_Nombre.Text;

               
                Response.Write("<script>alert('Datos Actualizados')</script>");
            }
            catch
            {
                Response.Write("<script>alert('Error al actualizar datos, intente de nuevo')</script>");
            }

        }

        protected void txt_Apellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
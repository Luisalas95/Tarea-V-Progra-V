using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Http.Results;
using CapaDatos;
using ConsumeApis.Clases;
using ConsumeApis.APIS;


namespace CapaCliente.Páginas
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
           

        }

        protected void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {

           

           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
              //  Encriptar EncriptaClave = new Encriptar();
                GeneraClave NuevaClave = new GeneraClave(); 
                ApiLogin ConsuemApi = new ApiLogin();
                string ClaveNueva = "";
                string Clave = "";
                string ClaveEncriptada = "";
                ClaveNueva = GeneraClave.ClaveGenerada(Clave);
               // ClaveEncriptada = EncriptaClave.GetSHA256(ClaveNueva);
                Usuarios nuevoUsario = new Usuarios();
                nuevoUsario.Identificacion = txt_ID.Text;
                nuevoUsario.Nombre = txt_Nombre.Text;
                nuevoUsario.Apellidos = txt_Apellidos.Text;
                nuevoUsario.Password = ClaveNueva;
                string codigoRespuesta = ConsuemApi.CrearUsuario(nuevoUsario);
                if (codigoRespuesta == "201")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(),
                    "alert", "alert('" + "El usuario se creo de manera exitosa su clave es " + ClaveNueva+ "')", true);
                    lblClave.Text = ClaveNueva;
                    txt_Apellidos.Text = "";
                    txt_Nombre.Text = "";
                    txt_ID.Text = "";
                    txt_ID.Text = "";
                }
                if (codigoRespuesta == "409")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                                          "alert", "alert('" + "El usuario que intenta crear ya existe en la BD" + "')", true);

                }

                if (codigoRespuesta == "500")
                {
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                                          "alert", "alert('" + "Error de servidor" + "')", true);

                }













            }
            catch(Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(),
                                                    "alert", "alert('" + ex.Message + "')", true);
            }
        }

        protected void txt_Apellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
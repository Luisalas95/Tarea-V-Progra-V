using ConsumeApis.Clases;
using ConsumeApis.APIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuickType;


namespace CapaCliente
{
    public partial class Login : System.Web.UI.Page
    {
        public ApiLogin ApiLogin = new ApiLogin();
      
        protected void Page_Load(object sender, EventArgs e)
        {
           

            
        }

        protected void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUsuario nuevoLogin = new LoginUsuario()
                {
                    Identificacion = txt_Usuario2.Value,
                    Password = txt_Clave2.Value
                };
                string retusltado =   ApiLogin.LoginConsulta(nuevoLogin);
                string[] arreglo = retusltado.Split('/');
             
                if (arreglo[0] == "201")
                {

                    Response.Redirect("AgregarProductoNuevo.aspx?Token=" + arreglo[1]);
                }

                if (arreglo[0] == "404")
                {

                    Response.Write("<script>alert('Usuario y/o contraseña incorrectos')</script>");
                }

                if (arreglo[0] == "500")
                {
                    Response.Write("<script>alert('Error interno')</script>");
                }


            }
            catch (Exception ex) {
                ScriptManager.RegisterStartupScript(this, GetType(),
                                                           "alert", "alert('" + ex.Message + "')", true);
            }
        }


        protected void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txt_Clave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
using ConsumeApis.Clases;
using ConsumeApis.APIS;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaCliente
{
    public partial class Login : System.Web.UI.Page
    {
        public ApiLogin ApiLogin = new ApiLogin();
        public List<Login> logins = new List<Login>();
        protected void Page_Load(object sender, EventArgs e)
        {
           

            
        }

        protected void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txt_Usuario.Text;
                int result = Int32.Parse(usuario);
                string clave = txt_Clave.Text;
                logins = ApiLogin.LoginConsulta(usuario);
              
                Response.Redirect("AgregarProductoNuevo.aspx");
            }
            catch {
                Response.Write("<script>alert('Usuario y/o contraseña incorrectos')</script>");
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
﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsumeApis;
using Swashbuckle.Swagger;
using ConsumeApis;
namespace CapaCliente.Páginas
{
    public partial class AgregarProductoNuevo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           // GridViewProductos.DataSource = ProductoNegocios.ConsultaProductos();
            GridViewProductos.DataBind();

        }

        protected void btn_GuardarProduc_Click(object sender, EventArgs e)
        {
            try
            {
              //  Producto1.CodigoProducto = int.Parse(txt_codigoproduct.Value);
                //Producto1.NombreProducto = txt_Nomb.Value;
             //   Producto1.Existencias = float.Parse(txt_existencia.Value);
              //  Producto1.BodegaUbicacion = txt_UbicacionBodega.Value;
               // ProductoNegocios.CrudProductos(1, Producto1);
                Response.Write("<script> alert('El producto se agrego con exito')  </script> ");
                txt_codigoproduct.Value = "";
                txt_Nomb.Value = "";
                txt_UbicacionBodega.Value = "";
                txt_existencia.Value = "";
                //GridViewProductos.DataSource = ProductoNegocios.ConsultaProductos();
                GridViewProductos.DataBind();


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
      
                Response.Redirect("MantenimientoProductos.aspx?CodigoP=" + CodigoProducto);


            }
            catch (Exception)
            {

                Response.Write("<script> alert('Error')  </script> ");
            }

        }
    }
}
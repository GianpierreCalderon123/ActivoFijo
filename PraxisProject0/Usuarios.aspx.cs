using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PraxisProject0
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            GridView1.DataSource = objCalimod.VerUsuarios();
            GridView1.DataBind();

            try
            {
                GridView1.HeaderRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#071456");
                GridView1.HeaderRow.ForeColor = System.Drawing.Color.White;
                foreach (GridViewRow row in GridView1.Rows)
                {
                    try
                    {
                        
                            row.BackColor = System.Drawing.ColorTranslator.FromHtml("#b8dbf6");
                        
                    }
                    catch (Exception)
                    {

                    }

                }

            }
            catch (Exception)
            {
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["OperacionUsuario"] = "Nuevo Usuario";
            Response.Redirect("NuevoUsuario.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (HiddenField1.Value == "Accesos")
            {
                //Session["OperacionItem"] = HiddenField1.Value;
                Session["UsuarioSeleccionado"] = HiddenField2.Value;
                Session["ContraseñaUsuarioSeleccionado"] = HiddenField3.Value;
                Response.Redirect("AccesoUsuarios.aspx?Usuario=" + Session["UsuarioSeleccionado"].ToString() + "&Persona=" + Session["Persona"].ToString());

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambioMasivoDeCartera.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());

        }
    }
}
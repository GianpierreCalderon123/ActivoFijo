using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PraxisProject0
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


            int operacion1 = objCalimod.InsUpdUsuariosFaber(TextBox1.Text, TextBox2.Text, Session["Usuario"].ToString());

            String script = "<script type='text/javascript'>  alert('" + "Registros Insertados en el Maestro de Usuarios" + "');</script>";
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "standard", script, false);


            Response.Redirect("Usuarios.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());
       
        }
    }
}
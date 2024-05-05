using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PraxisProject0
{
    public partial class VerClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //HiddenFieldUsuario.Value = Session["Usuario"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Session["OperacionUsuario"] = "Nuevo Usuario";
            //Response.Redirect("NuevoCliente.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("VerClientes.aspx");

        }
    }
}
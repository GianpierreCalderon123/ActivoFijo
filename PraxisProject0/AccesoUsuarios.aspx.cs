using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PraxisProject0
{
    public partial class AccesoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario;
            Usuario = Request.QueryString["Usuario"];

            HiddenField3.Value = Usuario;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
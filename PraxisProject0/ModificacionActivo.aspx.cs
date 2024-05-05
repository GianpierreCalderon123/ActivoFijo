using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PraxisProject0
{
    public partial class ModificacionCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Codigo;
            Codigo = Request.QueryString["Codigo"];
            HiddenField1.Value = Codigo;
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
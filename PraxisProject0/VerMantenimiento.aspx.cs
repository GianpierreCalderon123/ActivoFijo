using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PraxisProject0
{
    public partial class VerMantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Nro,Opcion;
                Nro = Request.QueryString["Nro"];
                Opcion = Request.QueryString["Opcion"];
                HiddenFieldNro.Value = Nro;
                HiddenFieldOpcion.Value = Opcion;
            }
            catch (Exception)
            {
                
            }

        }
    }
}
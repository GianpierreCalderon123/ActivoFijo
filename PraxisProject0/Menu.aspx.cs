using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PraxisProject0
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerAlmacenAccesos(Session["Usuario"].ToString());

            foreach (DataRow rw in dt.Rows)
            {


                if (rw[0].ToString() == "Registrar Activos" && rw[1].ToString() == "False") { Button6.Visible = false; }
                //if (rw[0].ToString() == "Registrar Guias Pesajes" && rw[1].ToString() == "False") { Button2.Visible = false; }
                //if (rw[0].ToString() == "Generar Hojas de Control" && rw[1].ToString() == "False") { Button9.Visible = false; }
                //if (rw[0].ToString() == "Generar Certificados" && rw[1].ToString() == "False") { Button4.Visible = false; }
                //if (rw[0].ToString() == "Generar Liquidaciones" && rw[1].ToString() == "False") { Button8.Visible = false; }
                if (rw[0].ToString() == "Reporte de Asignacion" && rw[1].ToString() == "False") { Button5.Visible = false; }
                if (rw[0].ToString() == "Movimientos" && rw[1].ToString() == "False") { btnmov.Visible = false; }
                
                
                //if (rw[0].ToString() == "Registrar Proveedores" && rw[1].ToString() == "False") { Button11.Visible = false; }
                //if (rw[0].ToString() == "Registrar Guias de Compra" && rw[1].ToString() == "False") { Button3.Visible = false; }
                //if (rw[0].ToString() == "Emitir Liquidaciones de Compra" && rw[1].ToString() == "False") { Button10.Visible = false; }
                if (rw[0].ToString() == "Registrar Usuarios" && rw[1].ToString() == "False") { Button1.Visible = false; }
                if (rw[0].ToString() == "Mantenimiento" && rw[1].ToString() == "False") { btnmantenimiento.Visible = false; }
                if (rw[0].ToString() == "Reportes" && rw[1].ToString() == "False") { Button13.Visible = false; }



            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}
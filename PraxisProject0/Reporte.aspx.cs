using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data;

namespace PraxisProject0
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report1.rdlc");
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                DataTable dt;
                
                dt = objCalimod.VerCliente(Session["nombre"].ToString());

                ReportDataSource datasource = new
                ReportDataSource("DataSet1", dt);

                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
                
                ReportParameter parameter = new ReportParameter("nombre", Session["nombre"].ToString());
                ReportViewer1.LocalReport.SetParameters(parameter);
                ReportViewer1.LocalReport.Refresh();

            }
        }
    }
}
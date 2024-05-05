using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.Reporting.WebForms;

namespace PraxisProject0
{
    public partial class ReporteDepreciacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/VerReporteDepreciacion.rdlc");
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                DataTable dt;

                dt = objCalimod.VerDepreciacionTotal();

                ReportDataSource datasource = new
                ReportDataSource("DataSet1", dt);

                ReportViewer1.LocalReport.EnableExternalImages = true;
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);

             
                ReportViewer1.LocalReport.Refresh();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/VerReporteDepreciacion.rdlc");
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            DataTable dt;

            dt = objCalimod.VerActivoCatalogo();

            ReportDataSource datasource = new
            ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.EnableExternalImages = true;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);


            ReportViewer1.LocalReport.Refresh();
        }
    }
}
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
    public partial class GuiaMovimiento : System.Web.UI.Page
    {
        public void Reporte()
        {
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/ReporteGuiaMovimiento.rdlc");
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            DataTable dt;

            string id = Request.QueryString["Codigo"];
            dt = objCalimod.verGuiaMovimiento(id);

            ReportDataSource datasource = new
            ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.EnableExternalImages = true;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);


            ReportParameter[] parameter = null;
            parameter = new ReportParameter[1];
            parameter[0] = new Microsoft.Reporting.WebForms.ReportParameter("id", id);
            //parameter[1] = new Microsoft.Reporting.WebForms.ReportParameter("Residuo", residuo);
            //new ReportParameter("Correlativo", Correlativo);
            //Dim parameters As Microsoft.Reporting.WinForms.ReportParameter() = Nothing
            //parameters = New Microsoft.Reporting.WinForms.ReportParameter(2) {}
            //parameters(0) = New Microsoft.Reporting.WinForms.ReportParameter("Horma", hormax)
            //parameters(1) = New Microsoft.Reporting.WinForms.ReportParameter("VersionFicha", versionFichax)

            ReportViewer1.LocalReport.SetParameters(parameter);
            ReportViewer1.LocalReport.Refresh();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Reporte();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Reporte();
        }
    }
}
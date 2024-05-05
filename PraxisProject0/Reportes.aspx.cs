using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using System.Text;


namespace PraxisProject0
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        System.Data.DataTable dt;
        protected void Button3_Click(object sender, EventArgs e)
        {
            CatalogoBL.CatalogoBL cat = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


            dt = cat.VerGuiasDeServicio();

            using (dt)
            {
                //sda.Fill(dt);
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Customers");

                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;filename=SqlExport.xlsx");
                    using (MemoryStream MyMemoryStream = new MemoryStream())
                    {
                        wb.SaveAs(MyMemoryStream);
                        MyMemoryStream.WriteTo(Response.OutputStream);
                        Response.Flush();
                        Response.End();
                    }
                }
            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CatalogoBL.CatalogoBL cat = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


            dt = cat.VerGuiasDeCompra();


            StringBuilder sb = new StringBuilder();

            //string[] columnNames = dt.Columns.Cast<DataColumn>().
            //                              Select(column => column.ColumnName).
            //                              ToArray();
            //sb.AppendLine(string.Join("|", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                            ToArray();
                sb.AppendLine(string.Join("|", fields));
            }
            
            //using (var sw = new StringWriter(sb))
            //{
            //    // init CsvWriter
            //    var csv = new CsvWriter(sw);

            //    // write all rptLines records to my StringBuilder
            //    csv.WriteRecords(rptLines);
            //}

            Response.ContentType = "application/txt";
            Response.AddHeader("content-disposition", @"attachment;filename=""export.txt""");   //necessary to return a 'filename' to the user
            Response.Write(sb.ToString());
            Response.End();
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CatalogoBL.CatalogoBL cat = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


            dt = cat.VerGuiasDeCompra();

            using (dt)
            {
                //sda.Fill(dt);
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Customers");

                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;filename=SqlExport.xlsx");
                    using (MemoryStream MyMemoryStream = new MemoryStream())
                    {
                        wb.SaveAs(MyMemoryStream);
                        MyMemoryStream.WriteTo(Response.OutputStream);
                        Response.Flush();
                        Response.End();
                    }
                }
            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            CatalogoBL.CatalogoBL cat = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


            dt = cat.VerDepreciacionTotal();

            using (dt)
            {
                //sda.Fill(dt);
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Customers");

                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;filename=SqlExport.xlsx");
                    using (MemoryStream MyMemoryStream = new MemoryStream())
                    {
                        wb.SaveAs(MyMemoryStream);
                        MyMemoryStream.WriteTo(Response.OutputStream);
                        Response.Flush();
                        Response.End();
                    }
                }
            }
        }
    }
}
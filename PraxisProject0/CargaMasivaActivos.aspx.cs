using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CatalogoBL;
using System.IO;

namespace PraxisProject0
{
    public partial class CargaMasivaActivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label5.Text = Session["AlmacenActual"].ToString();

            //DataTable Catalogo;
            //CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            //Catalogo = objCalimod.VerActivoCatalogo();

            //GridView3.DataSource = Catalogo;
            //GridView3.DataBind();
        }

      
        protected void Button3_Click(object sender, EventArgs e)
        {
            string textLine;
            string[] lines = null;
            lines = new string[0];
            int i = 0;

            if (FileUpload1.HasFile)
            {
                try
                {
                    StreamReader reader = new StreamReader(FileUpload1.FileContent);
                    do
                    {

                        lines = Add(lines, reader.ReadLine());

                        // do your coding 
                        //Loop trough txt file and add lines to ListBox1  
                        i++;
                    } while (reader.Peek() != -1);
                    reader.Close();


                    //string text = textLine;
                    //string[] lines = System.IO.File.ReadAllLines(FileUpload1.FileName);

                    foreach (string line in lines)
                    {
                        string[] datos = line.Split('\t');
                        //string catalogonombre = Session["CatalogoActual"].ToString();
                        CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

                        string operacion1 = objCalimod.UpdateActivo(
                        "0",
                        datos[0].ToString(),
                        datos[1].ToString(),
                        datos[2].ToString(),
                        datos[3].ToString(),
                        datos[4].ToString(),
                        datos[5].ToString(),
                        datos[6].ToString(),
                        datos[7].ToString(),
                        datos[8].ToString(),
                        datos[9].ToString(),
                        datos[10].ToString(),
                        datos[11].ToString(),
                        datos[12].ToString(),
                        datos[13].ToString(),
                        datos[14].ToString(),
                        datos[15].ToString(),
                        datos[16].ToString(),
                        datos[17].ToString(),
                        datos[18].ToString(),
                        datos[19].ToString(),
                        datos[20].ToString(),
                        "U",
                        datos[21].ToString(),
                        "",
                        datos[22].ToString(),
                         datos[23].ToString(),
 datos[24].ToString(),
 datos[25].ToString(),
 datos[26].ToString(),
 datos[27].ToString(),
 datos[28].ToString(),
 datos[29].ToString(),
 datos[30].ToString(),
 datos[31].ToString(),
 datos[32].ToString(),
 datos[33].ToString(),
 datos[34].ToString(),
 datos[35].ToString(),
 datos[36].ToString(),
 datos[37].ToString(),
 datos[38].ToString(),
 datos[39].ToString(),
 datos[40].ToString(),
 datos[41].ToString(),
 datos[42].ToString(),
 datos[43].ToString(),
 datos[44].ToString(),
 datos[45].ToString(),
 datos[46].ToString()

                        );
                    
                    }

                    String script = "<script type='text/javascript'>  alert('" + "Registros Insertados en el Catalogo" + "');</script>";
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "standard", script, false);


                    Response.Redirect("VerActivos.aspx");

                }
                catch
                {

                    String script = "<script type='text/javascript'>  alert('" + "Formato Erroneo" + "');</script>";
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "standard", script, false);
                    Response.Redirect("VerActivos.aspx");

                }

            }
        }

        public string[] Add(string[] array, string newValue)
        {
            int newLength = array.Length + 1;

            string[] result = new string[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PraxisProject0
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string opcion, usuario, contraseña;
                            opcion = HiddenField1.Value;
            usuario = HiddenField2.Value;
            contraseña = HiddenField3.Value;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            if (opcion == "Ingresar")
            {

                //CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                string m_MensajeError = string.Empty;
                try
                {
                    if (usuario == "" || contraseña == "")
                    {
                        String script = "<script type='text/javascript'>  alert('" + "Ingrese Usuario y Contraseña" + "');</script>";
                        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "standard", script, false);

                    }
                    else if (objCalimod.FunUsuarioComprobar(usuario, contraseña) > 0)
                    {
                        string Usuariox;
                        Usuariox = usuario;
                        Session["Persona"] = "Almacen";
                        Session["Vendedor"] = Usuariox;
                        Session["Usuario"] = Usuariox;
                        Response.Redirect("Menu.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());

                    }
                    else if (usuario == "demo" && contraseña == "123")
                    {



                        string Usuariox;
                        DataTable dtPermisos;
                        Usuariox = usuario;
                        //dtPermisos = new DataTable();
                        //dtPermisos = objCalimod.FunUsuarioNombreCompletoSpring(Usuariox);

                        //Session["_UsuarioDatos"] = Usuariox;
                        Session["Persona"] = "";
                        //Session["Vendedor"] = Usuariox;
                        Session["Usuario"] = Usuariox;

                        Response.Redirect("Menu.aspx?Usuario=" + Session["Usuario"].ToString() + "&Persona=" + Session["Persona"].ToString());

                    }
                    else
                    {
                        String script = "<script type='text/javascript'>  alert('" + "Ingrese Usuario y contraseña incorrecto" + "');</script>";
                        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "standard", script, false);

                    }
                }
                catch (Exception ex)
                {

                }

            }

        }
    }
}
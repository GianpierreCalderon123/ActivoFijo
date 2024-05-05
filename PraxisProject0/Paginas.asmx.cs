using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using CatalogoBL;
using System.Data;


using System.Diagnostics;
using System.Globalization;
using System.IO;

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Web.Script.Services;


namespace PraxisProject0
{
    /// <summary>
    /// Summary description for Paginas
    /// </summary>
    /// 
    [System.Web.Script.Services.ScriptService()]
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Paginas : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Cliente> VerClientes(string NombreB,string RucB,string usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerClientes(NombreB, RucB, usuario);

            List<Cliente> a = new List<Cliente>();
            foreach(DataRow row in dt.Rows)
            {
                Cliente b = new Cliente();
                b.CE = row["CE"].ToString();
                b.Correo = row["Correo"].ToString();
                b.DNI = row["DNI"].ToString();
                b.IngenieroResponsable = row["IngenieroResponsable"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();
                a.Add(b);      
            }
            return a;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<CategoriaActivo> verCategoria()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.verCategoria();

            List<CategoriaActivo> a = new List<CategoriaActivo>();
            foreach (DataRow row in dt.Rows)
            {
                CategoriaActivo b = new CategoriaActivo();
                b.categoria = row["categoria"].ToString();
                b.descripcionlocal = row["descripcionlocal"].ToString();
                a.Add(b);
            }
            return a;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Activo> GetActivoMov(string activo, string descripcion, string grupo)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.GetActivoMov(activo, descripcion,grupo);

            List<Activo> a = new List<Activo>();
            foreach (DataRow row in dt.Rows)
            {
                Activo b = new Activo();
                b.Codigo = row["Codigo"].ToString();
                b.descripcion = row["descripcion"].ToString();
                //b.DNI = row["DNI"].ToString();
                //b.IngenieroResponsable = row["IngenieroResponsable"].ToString();
                //b.Nombre = row["Nombre"].ToString();
                //b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                //b.Ruc_Dni = row["Ruc_Dni"].ToString();
                //b.Telefono = row["Telefono"].ToString();
                a.Add(b);
            }
            return a;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Activo> VerActivo(string Codigo, string descripcion)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerActivo(Codigo, descripcion);

            List<Activo> a = new List<Activo>();
            foreach (DataRow row in dt.Rows)
            {
                Activo b = new Activo();
                b.Codigo = row["Codigo"].ToString();
                b.descripcion = row["descripcion"].ToString();
                //b.DNI = row["DNI"].ToString();
                //b.IngenieroResponsable = row["IngenieroResponsable"].ToString();
                //b.Nombre = row["Nombre"].ToString();
                //b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                //b.Ruc_Dni = row["Ruc_Dni"].ToString();
                //b.Telefono = row["Telefono"].ToString();
                a.Add(b);
            }
            return a;
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public MantenimientoClass VerMantenimientoClassPorNro(string Nro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerMantenimientoClassPorNro(Nro);
            MantenimientoClass b = new MantenimientoClass();
            foreach (DataRow row in dt.Rows)
            { 
                
                b.Codigo = row["Codigo"].ToString();
                b.descripcionservicio = row["descripcionservicio"].ToString();
                b.Estado = row["Estado"].ToString();
                b.Nro = row["Nro"].ToString();
                b.descripcion = row["descripcion"].ToString();
              
            }
            return b;
        }




        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MantenimientoClass> VerMantenimientoClass()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerMantenimientoClass();

            List<MantenimientoClass> a = new List<MantenimientoClass>();
            foreach (DataRow row in dt.Rows)
            {
                MantenimientoClass b = new MantenimientoClass();
                b.Codigo = row["Codigo"].ToString();
                b.descripcionservicio = row["descripcionservicio"].ToString();
                b.Estado = row["Estado"].ToString();
                b.Nro = row["Nro"].ToString();
                b.descripcion = row["descripcion"].ToString();
                
                a.Add(b);
            }
            return a;
        
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Activo VerActivoPorCodigo(string Codigo)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerActivoPorCodigo(Codigo);

            Activo b = new Activo();
            
            try
            {
                b.UsuarioAnterior = dt.Rows[0]["UsuarioAnterior"].ToString();
                b.nrovoucher = dt.Rows[0]["nrovoucher"].ToString();
                b.Dimensiones = dt.Rows[0]["Dimensiones"].ToString();
                b.PESO = dt.Rows[0]["PESO"].ToString();
                b.CONSUMO_ENERGIA = dt.Rows[0]["CONSUMO_ENERGIA"].ToString();
                b.TIPO_EQUIPO_CATEGORIA = dt.Rows[0]["TIPO_EQUIPO_CATEGORIA"].ToString();
                b.Ruc_Proveedor = dt.Rows[0]["Ruc_Proveedor"].ToString();
                b.TIPO_DE_ACTIVO = dt.Rows[0]["TIPO_DE_ACTIVO"].ToString();
                b.TIPO_MATERIAL = dt.Rows[0]["TIPO_MATERIAL"].ToString();
                b.CATEGORIA = dt.Rows[0]["CATEGORIA"].ToString();
                b.EDIFICIO = dt.Rows[0]["EDIFICIO"].ToString();
                b.PISO = dt.Rows[0]["PISO"].ToString();
                b.UBICACION = dt.Rows[0]["UBICACION"].ToString();
                b.COD_LINEA = dt.Rows[0]["COD_LINEA"].ToString();
                b.DETALLE_STATUS = dt.Rows[0]["DETALLE_STATUS"].ToString();
                b.OBSERVACIONES = dt.Rows[0]["OBSERVACIONES"].ToString();
                b.TIPO_DE_EQUIPO_contable = dt.Rows[0]["TIPO_DE_EQUIPO_contable"].ToString();
                b.DESCRIPCIoN_contable = dt.Rows[0]["DESCRIPCIoN_contable"].ToString();
                b.CANTIDAD = dt.Rows[0]["CANTIDAD"].ToString();
                b.PRECIO_UND_MN = dt.Rows[0]["PRECIO_UND_MN"].ToString();
                b.PRECIO_UND_ME = dt.Rows[0]["PRECIO_UND_ME"].ToString();
                b.T_C = dt.Rows[0]["T_C"].ToString();
                b.IMPORTE__MN = dt.Rows[0]["IMPORTE__MN"].ToString();

                b.tasadepreciacion = dt.Rows[0]["tasadepreciacion"].ToString();
                b.imagen = dt.Rows[0]["imagen"].ToString();
                b.categoriasunat = dt.Rows[0]["categoriasunat"].ToString();
            
                b.Codigo = dt.Rows[0]["Codigo"].ToString();
                b.Fecha_de_adquision = dt.Rows[0]["Fecha_de_adquision"].ToString();
                b.nro_Factura = dt.Rows[0]["nro_Factura"].ToString();
                b.proveedor = dt.Rows[0]["proveedor"].ToString();
                b.descripcion = dt.Rows[0]["descripcion"].ToString();
                b.marca = dt.Rows[0]["marca"].ToString();
                b.modelo = dt.Rows[0]["modelo"].ToString();
                b.serie = dt.Rows[0]["serie"].ToString();
                b.largo = dt.Rows[0]["largo"].ToString();
                b.ancho = dt.Rows[0]["ancho"].ToString();
                b.altura = dt.Rows[0]["altura"].ToString();
                b.color = dt.Rows[0]["color"].ToString();
                b.estado = dt.Rows[0]["estado"].ToString();
                b.precio = dt.Rows[0]["precio"].ToString();
                b.igv = dt.Rows[0]["igv"].ToString();
                b.total = dt.Rows[0]["total"].ToString();

                b.local = dt.Rows[0]["local"].ToString();
                b.ambiente = dt.Rows[0]["ambiente"].ToString();

            
                b.Cod_familia = dt.Rows[0]["Cod_familia"].ToString();
                b.anio_fabricacion = dt.Rows[0]["anio_fabricacion"].ToString();
                b.fecha_de_inv = dt.Rows[0]["fecha_de_inv"].ToString();


                b.usuario = dt.Rows[0]["usuario"].ToString();
                b.dni = dt.Rows[0]["dni"].ToString();
                b.fechaasignacion = dt.Rows[0]["fechaasignacion"].ToString();
                b.CentroCostos = dt.Rows[0]["CentroCostos"].ToString();
            
            }
            catch (Exception)
            {

            }
            //}
            return b;
        }

         [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Cliente> VerClientePorUsuario(string usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerClientePorUsuario(usuario);

            List<Cliente> a = new List<Cliente>();
            foreach(DataRow row in dt.Rows)
            {
                Cliente b = new Cliente();
                b.Nombre = row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                 a.Add(b);      
            }
            return a;
        }

         [WebMethod]
         [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
         public string UpdateUsuarioClienteMasivo(List<string> Ruc_Dni, string Usuario)
         {
             foreach (string ruc in Ruc_Dni)
             {

                 DataTable dt = new DataTable();
                 CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                 dt = objCalimod.UpdateUsuarioClienteMasivo(ruc, Usuario);
             }
             return "ok";
         }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Cliente VerClientePorDNI(string ruc_dni)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerClientePorDNI(ruc_dni);

            Cliente b = new Cliente();
            foreach (DataRow row in dt.Rows)
            {
                
                b.CE = row["CE"].ToString();
                b.Correo = row["Correo"].ToString();
                b.DNI = row["DNI"].ToString();
                b.IngenieroResponsable = row["IngenieroResponsable"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();
                b.usuario = row["usuario"].ToString();
                b.TieneContrato = row["TieneContrato"].ToString();
                b.FechaRegistro = row["FechaRegistro"].ToString();
               
            }
            return b;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Direccionx> VerDireccion(string ruc_dni)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDireccion(ruc_dni);

            List<Direccionx> bb = new List<Direccionx>();
            foreach (DataRow row in dt.Rows)
            {
                Direccionx b = new Direccionx();
                
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Urbanizacion = row["Urbanizacion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Codigo_Postal = row["Codigo_Postal"].ToString();
                b.Sede = row["Sede"].ToString();
                bb.Add(b);
            }
            return bb;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Direccionx VerDireccionPorDireccion(string ruc_dni,string direccion)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDireccionPorDireccion(ruc_dni,direccion);

            Direccionx b = new Direccionx();
            foreach (DataRow row in dt.Rows)
            {
               

                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Urbanizacion = row["Urbanizacion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Codigo_Postal = row["Codigo_Postal"].ToString();

                b.Sede = row["Sede"].ToString();
               
            
            }
            return b;
        }


        //
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateCliente(string ruc_dni, string CE, string Correo, string DNI, string IngenieroResponsable,
            string Nombre, string RepresentanteLegal, string Telefono, string usuario,
            string TieneContrato,string FechaRegistro,string NuevoRuc_Dni,string opcion)
        {
            string dt ;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UpdateCliente( ruc_dni, CE, Correo, DNI, IngenieroResponsable,
            Nombre, RepresentanteLegal, Telefono ,usuario,TieneContrato,FechaRegistro,NuevoRuc_Dni, opcion);
            
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<DepreciacionClass> VerDepreciacionPorCodigo(string Codigo)
        {
            DataTable dt ;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDepreciacionPorCodigo(Codigo);
            List<DepreciacionClass> a = new List<DepreciacionClass>();
            foreach(DataRow row in dt.Rows)
            {
            DepreciacionClass aa = new DepreciacionClass();
                aa.Nro=row["Nro"].ToString();
                aa.Depreciacion=row["Depreciacion"].ToString();
                aa.Periodo=row["Periodo"].ToString();
                aa.Saldo=row["Saldo"].ToString();
                a.Add(aa);
            }
            return a;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int GrabarAlertas( List<AlertaClass> lista)
        {
            int x;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            foreach (AlertaClass l in lista)
            {
                x = objCalimod.InsUpdAlerta(l.Nro,l.Tlf,l.api);
            }

        return 1;
        }

                       [WebMethod] 
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<AlertaClass> TraeAlerta()
        {
            DataTable dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.TraeAlerta();
            List<AlertaClass> a = new List<AlertaClass>();
            foreach (DataRow row in dt.Rows)
            {
                AlertaClass aa = new AlertaClass();
                aa.Nro = row["Nro"].ToString();
                aa.api = row["api"].ToString();

                aa.Tlf = row["Tlf"].ToString();
                a.Add(aa);
            }
            return a;

                        }

         [WebMethod] 
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
                       public List<TrazaUsuario> Ver_activo_Trazabilidad_Usuario(string Codigo)
        {
            DataTable dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.Ver_activo_Trazabilidad_Usuario(Codigo);
            List<TrazaUsuario> a = new List<TrazaUsuario>();
            foreach (DataRow row in dt.Rows)
            {
                TrazaUsuario aa = new TrazaUsuario();
                aa.Codigo = row["Codigo"].ToString();
                aa.usuarioantiguo = row["usuarioantiguo"].ToString();

                aa.usuarionuevo = row["usuarionuevo"].ToString();
                
                aa.fecha = row["fecha"].ToString();
                a.Add(aa);


            }
            return a;

                        }

        

            [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int GenerarMantenimiento(MantenimientoClass mantenimiento)
        {
            int dt ;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            dt = objCalimod.GenerarMantenimiento(mantenimiento.Codigo,mantenimiento.descripcion,mantenimiento.descripcionservicio,mantenimiento.Estado,mantenimiento.Nro,mantenimiento.opcion);

            return dt;
       }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int GenerarMovimiento(MovimientoClass movimiento)
        {
            int dt ;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            string id = objCalimod.GetCorrelativoMov();

            dt = objCalimod.InsUpdMovimiento(id,movimiento.fecha,movimiento.Destinatario,movimiento.PuntodePartida,movimiento.Ruc,movimiento.PuntodeLlegada,movimiento.Ruc_transporte,movimiento.nombre_transporte,movimiento.marca_placa_transporte,movimiento.licencia);
           
            foreach( MovimientoDetalle row in movimiento.Detalle)
            {
                dt = objCalimod.InsupdMovimientodetalle(id, row.codigo);
           
            }
            return dt;
        }

        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MovimientoClass> VerMovimiento()
        {
            DataTable dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerMovimiento();
            List<MovimientoClass> a = new List<MovimientoClass>();
            foreach (DataRow row in dt.Rows)
            {
                MovimientoClass aa = new MovimientoClass();
                aa.id = row["id"].ToString();
                aa.fecha = row["fecha"].ToString();
                aa.Destinatario = row["Destinatario"].ToString();
                aa.PuntodeLlegada = row["PuntodeLlegada"].ToString();
                aa.PuntodePartida = row["PuntodePartida"].ToString();
                
                a.Add(aa);
            }
            return a;
        }
        

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdateActivo(string Codigo,string Fecha_de_adquision, string nro_Factura,
string proveedor,
string descripcion,
string marca,
string modelo,
string serie,
string largo,
string ancho,
string altura,
string color,
string estado,
string precio,
string igv,
string total,
string usuario,
            string local,
            string ambiente,
             string Cod_familia, string anio_fabricacion, string fecha_de_inv,
            string opcion, string categoriasunat, string imagen, string tasadepreciacion ,


            string UsuarioAnterior,
 string nrovoucher,
 string Dimensiones,
 string PESO,
 string CONSUMO_ENERGIA,
 string TIPO_EQUIPO_CATEGORIA,
 string Ruc_Proveedor,
 string TIPO_DE_ACTIVO,
 string TIPO_MATERIAL,
 string CATEGORIA,
 string EDIFICIO,
 string PISO,
 string UBICACION,
 string COD_LINEA,
 string DETALLE_STATUS,
 string OBSERVACIONES,
 string TIPO_DE_EQUIPO_contable,
 string DESCRIPCIoN_contable,
 string CANTIDAD,
 string PRECIO_UND_MN,
 string PRECIO_UND_ME,
 string T_C,
 string IMPORTE__MN, string CentroCostos
)
        {
            string dt ;
            
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UpdateActivo(Codigo, Fecha_de_adquision,nro_Factura,
proveedor,
descripcion,
marca,
modelo,
serie,
largo,
ancho,
altura,
color,
estado,
precio,
igv,
total,
usuario, local, ambiente, Cod_familia, anio_fabricacion, fecha_de_inv, opcion, categoriasunat, imagen, tasadepreciacion,

 UsuarioAnterior,
 nrovoucher,
 Dimensiones,
 PESO,
 CONSUMO_ENERGIA,
 TIPO_EQUIPO_CATEGORIA,
 Ruc_Proveedor,
 TIPO_DE_ACTIVO,
 TIPO_MATERIAL,
 CATEGORIA,
 EDIFICIO,
 PISO,
 UBICACION,
 COD_LINEA,
 DETALLE_STATUS,
 OBSERVACIONES,
 TIPO_DE_EQUIPO_contable,
 DESCRIPCIoN_contable,
 CANTIDAD,
 PRECIO_UND_MN,
 PRECIO_UND_ME,
 T_C,
 IMPORTE__MN, CentroCostos

);
            
            return dt;
        }

        


        //"ruc_dni": ruc_dni, "direccion": direccion, "Urbanizacion": Urbanizacion, "Distrito": Distrito,
        //                "Provincia": Provincia, "Departamento": Departamento,
        //                "Codigo_Postal": Codigo_Postal,"opcion":"U"

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UpdInsDireccion(string ruc_dni, string direccion, string Urbanizacion, string Distrito,
            string Provincia,string Departamento, string Codigo_Postal, string Sede,string NuevaDireccion, string opcion )
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UpdInsDireccion( ruc_dni, direccion, Urbanizacion, Distrito,
            Provincia,Departamento, Codigo_Postal,Sede,NuevaDireccion, opcion );

            return dt;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdServicios(string Servicio, string Unidad, string Tarifa, string opcion)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdServicios(Servicio, Unidad, Tarifa, opcion);

            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdResiduos(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
             dt = objCalimod.InsUpdResiduos(Residuo, Unidad, Tarifa, opcion);

            return dt;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdResiduosCompra(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdResiduosCompra(Residuo, Unidad, Tarifa, opcion);

            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Serviciosx> VerServicios()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerServicios();

            List<Serviciosx> bb = new List<Serviciosx>();
            foreach (DataRow row in dt.Rows)
            {
                Serviciosx b = new Serviciosx();

                b.Servicio = row["Servicio"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                bb.Add(b);

            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<String> VerUsuarioAsignados(string Usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerUsuarioAsignados(Usuario);

            List<string> bb = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                bb.Add(row[0].ToString());

            }
            return bb;
        }

        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<String> VerManifiestoDetalle(string Correlativo)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerManifiestoDetalle(Correlativo);

            List<string> bb = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                bb.Add(row[0].ToString());

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<String> VerCertificadoDetalle(string CertificadoNro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerCertificadoDetalle(CertificadoNro);

            List<string> bb = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                bb.Add(row[0].ToString());

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<String> VerLiquidacionProveedorReporte(string NroLiquidacion)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionProveedorDetalle(NroLiquidacion);

            List<string> bb = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                bb.Add(row["Descripcion"].ToString());

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Residuosx> VerResiduos()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerResiduos();

            List<Residuosx> bb = new List<Residuosx>();
            foreach (DataRow row in dt.Rows)
            {
                Residuosx b = new Residuosx();

                b.Residuo = row["Residuo"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                bb.Add(b);

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Residuosx> VerResiduosCompra()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerResiduosCompra();

            List<Residuosx> bb = new List<Residuosx>();
            foreach (DataRow row in dt.Rows)
            {
                Residuosx b = new Residuosx();

                b.Residuo = row["Residuo"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                bb.Add(b);

            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Serviciosx VerServiciosPorServicio(string Servicio)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerServiciosPorServicio(Servicio);

            Serviciosx b = new Serviciosx();
            foreach (DataRow row in dt.Rows)
            {
                b.Servicio = row["Servicio"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
               

            }
            return b;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Residuosx VerResiduosPorResiduo(string Residuo)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerResiduosPorResiduo(Residuo);

            Residuosx b = new Residuosx();
            foreach (DataRow row in dt.Rows)
            {
                b.Residuo = row["Residuo"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();


            }
            return b;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Guia_Pesaje> VerGuia_Pesaje(string guia,string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerGuia_Pesaje(guia,usuario, Nombre,FechaDesde,FechaHasta);

            List<Guia_Pesaje> bb = new List<Guia_Pesaje>();
            foreach (DataRow row in dt.Rows)
            {
                Guia_Pesaje b = new Guia_Pesaje();
                b.BoletaRelleno = row["BoletaRelleno"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();

                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.NroControl = row["NroControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();                

                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();
                b.UltimoUsuario = row["UltimoUsuario"].ToString();
                b.UsadoParaControl = row["UsadoParaControl"].ToString();

                b.UsadoParaManifiesto = row["UsadoParaManifiesto"].ToString();
                b.NroManifiesto = row["NroManifiesto"].ToString();
                b.Estado = row["Estado"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.TipoResiduo = row["TipoResiduo"].ToString();

                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();

                bb.Add(b);

            }
            return bb;
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Guia_PesajeTotal VerGuia_PesajePorGuia(string GuiaNumero)
        {
            DataSet dt = new DataSet();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerGuia_PesajePorGuia(GuiaNumero);

            Guia_PesajeTotal a = new Guia_PesajeTotal();
            Guia_Pesaje b = new Guia_Pesaje();

            foreach (DataRow row in dt.Tables[0].Rows)
            {
               
                b.BoletaRelleno = row["BoletaRelleno"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();

                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.NroControl = row["NroControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();

                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();
                b.UltimoUsuario = row["UltimoUsuario"].ToString();
                b.UsadoParaControl = row["UsadoParaControl"].ToString();

                b.UsadoParaManifiesto = row["UsadoParaManifiesto"].ToString();
                b.NroManifiesto = row["NroManifiesto"].ToString();
                b.OtrosDestinos = row["OtrosDestinos"].ToString();
                b.DestinoFinal = row["DestinoFinal"].ToString();
                b.TipoResiduo = row["TipoResiduo"].ToString();
                b.GuiaTransportista = row["GuiaTransportista"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Placa = row["Placa"].ToString();
            }
            a.Guia_PesajeCabecera = b;

            List<Guia_Pesaje_Detalle> c = new List<Guia_Pesaje_Detalle>();

            foreach (DataRow row in dt.Tables[1].Rows)
            {
                Guia_Pesaje_Detalle bb = new Guia_Pesaje_Detalle();
                bb.GuiaNumero = row["GuiaNumero"].ToString();
                bb.Residuos = row["Residuos"].ToString();
                bb.Servicio = row["Servicio"].ToString();
                bb.Boleta = row["Boleta"].ToString();
                bb.TipoResiduos = row["TipoResiduos"].ToString();
                bb.Unidad = row["Unidad"].ToString();
                bb.Cantidad = row["Cantidad"].ToString();
                bb.Cantidad1 = row["Cantidad1"].ToString();
                bb.UnidadDeposito = row["UnidadDeposito"].ToString();
                c.Add(bb);
            }
            a.Guia_PesajeCabecera = b;
            a.Detalle = c;
            return a;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UpdInsVerGuia_Pesaje(string GuiaNumero, string BoletaRelleno, string Ruc_Cliente, string FechaRecojo,
            string Fecha2, string DireccionRecojo, string UsadoParaManifiesto, string UsadoParaControl,string NroManifiesto,
            string NroControl, string UltimoUsuario, string UltimaFechaModif,string DestinoFinal,string TipoResiduo,string opcion)
        {
            int dt=0;
            //string bb;
            //CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            //bb = objCalimod.UpdInsVerGuia_Pesaje( GuiaNumero,  BoletaRelleno,  Ruc_Cliente,  FechaRecojo,
            // Fecha2,  DireccionRecojo,  UsadoParaManifiesto,  UsadoParaControl, NroManifiesto,
            // NroControl, UltimoUsuario, UltimaFechaModif, DestinoFinal, TipoResiduo,opcion);

            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UpdInsVerGuia_PesajeCompleto(Guia_Pesaje Guia, string opcion,string TipoOperacion)
        {
            int i=0;
            try
            {DateTime g = DateTime.Parse(Guia.FechaRecojo);}
            catch (Exception)
            { i = i + 1;  }

            if (i > 0 && opcion != "D") { return "El formato de Fecha de Recojo es Erroneo"; }
            try
            { DateTime g = DateTime.Parse(Guia.Fecha2); }
            catch (Exception)
            { if (opcion != "D" && TipoOperacion != "PR") { i = i + 1; } }
            if ((i > 0 && opcion != "D") && TipoOperacion !="PR") { return "El formato de Fecha de LLegada a Relleno es Erroneo"; }

            if (Guia.Detalle.Count == 0 && opcion !="D") { return "Inserte Detalles primero"; }

            int dt;

            string bb;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            bb = objCalimod.UpdInsVerGuia_Pesaje(Guia.GuiaNumero, Guia.BoletaRelleno, Guia.Ruc_Cliente, Guia.FechaRecojo,
             Guia.Fecha2, Guia.DireccionRecojo, Guia.UsadoParaManifiesto, Guia.UsadoParaControl, Guia.NroManifiesto,
             Guia.NroControl, Guia.UltimoUsuario, Guia.UltimaFechaModif, Guia.DestinoFinal, Guia.TipoResiduo, Guia.Placa, Guia.GuiaTransportista, opcion, TipoOperacion, Guia.OtrosDestinos);

            if(bb != "OK"){return bb;}

            dt = objCalimod.UpdInsGuia_Pesaje_Detalle(Guia.GuiaNumero, "", "", "","",
                 "","", "","","D");

            if(opcion !="D")
            { 
                    foreach (Guia_Pesaje_Detalle det in Guia.Detalle)
                    {
                        try
                        {
                            int dtt;
                            dtt = objCalimod.UpdInsGuia_Pesaje_Detalle(det.GuiaNumero, det.Residuos, det.Servicio, det.TipoResiduos,
                             det.Unidad, det.Cantidad, det.Cantidad1, det.Boleta, det.UnidadDeposito, "I");

                        }
                        catch (Exception)
                        {
                    
                        }
                    }  
            }
            if (i > 0)
            { return "Fecha Erroneas"; }
            else
            {
                if (opcion == "I")
                { return "Guia Insertada"; }
                else if (opcion == "D")
                { return "Guia Eliminada"; }
                else
                {return "Guia Actualizada"; }
            }

        }



     


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlClass> VerHojaControl(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojaControl(usuario,Nombre,FechaDesde,FechaHasta);

            List<HojaControlClass> bb = new List<HojaControlClass>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlClass b = new HojaControlClass();
                b.Correlativo = row["Correlativo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.Nombre = row["Nombre"].ToString();

                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.HojaControl = row["HojaControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();

                b.NroCertificado = row["NroCertificado"].ToString();
                b.NroLiquidacion = row["NroLiquidacion"].ToString();
                b.UsadoParaCertificado = row["UsadoParaCertificado"].ToString();

                b.UsadoParaLiquidacion = row["UsadoParaLiquidacion"].ToString();
                
                bb.Add(b);

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlClass> VerLiquidacionesDisponibles(string Ruc_Cliente)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionesDisponibles(Ruc_Cliente);

            List<HojaControlClass> bb = new List<HojaControlClass>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlClass b = new HojaControlClass();
                b.HojaControl = row["HojaControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                
                bb.Add(b);

            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlClass> VerCertificadosDisponibles(string Ruc_Cliente)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerCertificadosDisponibles(Ruc_Cliente);

            List<HojaControlClass> bb = new List<HojaControlClass>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlClass b = new HojaControlClass();
                b.HojaControl = row["HojaControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();

                bb.Add(b);

            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public HojaControlClass VerHojaControlPorHojaControl(string HojaControl)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojaControlPorHojaControl(HojaControl);

            HojaControlClass b = new HojaControlClass();
            foreach (DataRow row in dt.Rows)
            {
               
                b.Correlativo = row["Correlativo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();

                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.HojaControl = row["HojaControl"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.Nombre = row["Nombre"].ToString();

                b.NroCertificado = row["NroCertificado"].ToString();
                b.NroLiquidacion = row["NroLiquidacion"].ToString();
                b.UsadoParaCertificado = row["UsadoParaCertificado"].ToString();

                b.UsadoParaLiquidacion = row["UsadoParaLiquidacion"].ToString();

                

            }
            return b;
        }

//        [WebMethod]
//        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
//        public int InsUpdDelHojaControl(string	HojaControl	,string	Correlativo	,string	Ruc_Cliente	,string	FechaRecojo	,string	Fecha2	,string	DireccionRecojo	,string	UsadoParaLiquidacion	,string	NroLiquidacion	,string	UsadoParaCertificado	,
//string	NroCertificado	,string	opcion	)
//        {
//            int dt;
//            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
//            dt = objCalimod.InsUpdDelHojaControl(HojaControl	,
//Correlativo	,Ruc_Cliente	,FechaRecojo	,Fecha2	,DireccionRecojo	,UsadoParaLiquidacion	,NroLiquidacion	,UsadoParaCertificado	,
//NroCertificado	,opcion	
//);

//            return dt;
//        }


        //
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string InsUpdDelLiquidacion(LiquidacionClass liquidacion, string opcion)
        {
            if (liquidacion.Detalle.Count == 0 && opcion != "D")
            {
                return "Inserte Detalle";
            }

            DataTable dtt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dtt = objCalimod.UltimoCorrelativoLiquidacion();
            string bb = dtt.Rows[0][0].ToString();

            int dt;
            if (opcion == "I") { liquidacion.LiquidacionNro = bb; }

            dt = objCalimod.InsUpdLiquidacion(liquidacion.LiquidacionNro, liquidacion.Ruc_Cliente, liquidacion.FechaRecojo,
liquidacion.Fecha2, liquidacion.DireccionRecojo, liquidacion.CorrelativoHojaControl, opcion);

            if(opcion != "D")
            { 
                        foreach (LiquidacionDetalle d in liquidacion.Detalle)
                        {
                                            try
                                            {


                                                dt = objCalimod.InsUpdLiquidacionDetalle(liquidacion.LiquidacionNro, 
                                    d.GuiaNumero, d.Residuos, d.Servicio, d.Unidad,
                            d.Cantidad, d.UnidadparaCostear, d.Tarifa,d.Total, opcion);
                                            }
                                            catch (Exception)
                                            {


                                            }
                        }
            }

            if (opcion != "D")
            {
                return "Liquidacion insertada";
            }

            else

            {
                return "Liquidacion borrada";
            
            }



        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string InsUpdDelCertificado(CertificadoClass certificado, string opcion)
        {

            if (certificado.Detalle.Count == 0) { return "Inserte Detalle"; }

            DataTable dtt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dtt = objCalimod.UltimoCorrelativoCertificado();
            string bb = dtt.Rows[0][0].ToString();



            int dt;
            if (opcion == "I") { certificado.CertificadoNro = bb; }

            dt = objCalimod.InsUpdCertificado(certificado.CertificadoNro, certificado.Ruc_Cliente, certificado.FechaRecojo,
certificado.Fecha2, certificado.DireccionRecojo, certificado.CorrelativoHojaControl, opcion);


            foreach (CertificadoDetalle d in certificado.Detalle)
            {
                try
                {
                    if(opcion !="D")
                    { 

                    dt = objCalimod.InsUpdCertificadDetalle(certificado.CertificadoNro, d.GuiaNumero, d.Residuos, d.Servicio, d.Unidad,
d.Cantidad, d.UnidadparaCostear,  opcion);
                    }


                }
                catch (Exception)
                {


                }
            }
            if (opcion == "I")
            { return "Certificado Creado"; }
            else
            { return "Certificado Eliminado"; }
        }



        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string InsUpdDelHojaControl(HojaControlClasse hoja,string opcion)
        {

            DataTable dtt = new DataTable();

            if (hoja.Detalle.Count == 0 &&  opcion !="D") { return "Inserte Detalle"; }
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dtt = objCalimod.UltimoCorrelativoHojas();
            string bb = dtt.Rows[0][0].ToString();

            int dt;
            if (opcion == "I") { hoja.HojaControl = bb; }

            dt = objCalimod.InsUpdDelHojaControl(hoja.HojaControl,
hoja.Correlativo, hoja.Ruc_Cliente, hoja.FechaRecojo, hoja.Fecha2, hoja.DireccionRecojo, hoja.UsadoParaLiquidacion,
hoja.NroLiquidacion, hoja.UsadoParaCertificado,
hoja.NroCertificado, opcion
);


            dt = objCalimod.InsUpdHojaControlDetalle(hoja.HojaControl, "","",
                   "", "", "", "",
                    "D");

            if (opcion != "D")
            { 

            foreach (HojaControlDetalle d in hoja.Detalle)
            {
                try
                {
                    dt = objCalimod.InsUpdHojaControlDetalle(hoja.HojaControl, d.GuiaNumero, d.Residuos,
                    d.LineaDeNegocio, d.Unidad, d.Cantidad, d.UnidadparaCostear,
                    opcion);
                }
                catch (Exception)
                {
                    
                   
                } 
            }
            }
            if (opcion != "D")
            {
                return "Hoja de Control Insertada";
            }
            else
            { return "Hoja de Control Eliminada"; }
        
        }


        

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MaestroPrecios> VerMaestroPrecios(string Usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerMaestroPrecios(Usuario);

            List<MaestroPrecios> bb = new List<MaestroPrecios>();
            foreach (DataRow row in dt.Rows)
            {
                MaestroPrecios b = new MaestroPrecios();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                b.UnidadMedida = row["UnidadMedida"].ToString();
                b.Nombre = row["Nombre"].ToString();
              
                    bb.Add(b);

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MaestroPrecios> VerMaestroPreciosProveedor(string Usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerMaestroPreciosProveedor(Usuario);

            List<MaestroPrecios> bb = new List<MaestroPrecios>();
            foreach (DataRow row in dt.Rows)
            {
                MaestroPrecios b = new MaestroPrecios();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                b.UnidadMedida = row["UnidadMedida"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Moneda = row["Moneda"].ToString();

                bb.Add(b);

            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UPdateMaestroPrecios(string	Servicio	,
string	Ruc_Dni	,string	UnidadMedida	,string	Tarifa	,string	opcion	)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UPdateMaestroPrecios(Servicio, Ruc_Dni, UnidadMedida, Tarifa, opcion	

);
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UPdateMaestroPreciosNuevo(List<MaestroPreciosClientes> Precio)
        {
            int dt;
            dt = 1;
            foreach (MaestroPreciosClientes a in Precio)
            {
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                dt = objCalimod.UPdateMaestroPrecios(a.Servicio, a.Ruc_Dni, a.UnidadMedida, a.Tarifa, "I"

                        );
            }
            
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UPdateMaestroPreciosNuevoProveedor(List<MaestroPreciosClientes> Precio)
        {
            int dt;
            dt = 1;
            foreach (MaestroPreciosClientes a in Precio)
            {
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                dt = objCalimod.UPdateMaestroPreciosProveedor(a.Servicio, a.Ruc_Dni, a.UnidadMedida, a.Tarifa,a.Moneda, "I"

                        );
            }

            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int UPdateMaestroPreciosProveedor(string Servicio,
string Ruc_Dni, string UnidadMedida, string Tarifa,string Moneda, string opcion)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UPdateMaestroPreciosProveedor(Servicio, Ruc_Dni, UnidadMedida, Tarifa, Moneda,opcion

);
            return dt;
        }





        ////////////ok

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlDetalle> VerHojaControlDetalle(string CorrelativoHojaControl)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojaControlDetalle(CorrelativoHojaControl);

            List<HojaControlDetalle> bb = new List<HojaControlDetalle>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlDetalle b = new HojaControlDetalle();
                b.Cantidad = row["Cantidad"].ToString();
                b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.LineaDeNegocio = row["LineaDeNegocio"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
                bb.Add(b);
               

            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlDetalle> VerHojaControlDetalleDisponible(string HojaControl)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojaControlDetalleDisponible(HojaControl);

            List<HojaControlDetalle> bb = new List<HojaControlDetalle>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlDetalle b = new HojaControlDetalle();
                b.Cantidad = row["Cantidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                b.Total = row["Total"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.LineaDeNegocio = row["LineaDeNegocio"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlDetalle> VerHojaControlDetalleDisponibleCertificado(string HojaControl)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojaControlDetalleDisponibleCertificado(HojaControl);

            List<HojaControlDetalle> bb = new List<HojaControlDetalle>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlDetalle b = new HojaControlDetalle();
                b.Cantidad = row["Cantidad"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                b.Total = row["Total"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.LineaDeNegocio = row["LineaDeNegocio"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<HojaControlDetalle> VerHojasDisponibles(string Ruc_Cliente)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerHojasDisponibles(Ruc_Cliente);

            List<HojaControlDetalle> bb = new List<HojaControlDetalle>();
            foreach (DataRow row in dt.Rows)
            {
                HojaControlDetalle b = new HojaControlDetalle();
                b.Cantidad = row["Cantidad"].ToString();
                //b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.LineaDeNegocio = row["LineaDeNegocio"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.TipoResiduo = row["TipoResiduo"].ToString();
                b.Fecha = row["Fecha"].ToString();
                //b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
                bb.Add(b);


            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string UltimoCorrelativoHojas()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.UltimoCorrelativoHojas();
            return dt.Rows[0][0].ToString();
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdHojaControlDetalle(string	CorrelativoHojaControl	,string	GuiaNumero	,string	Residuos	,string	LineaDeNegocio	,string	Unidad	,string	Cantidad	,string	UnidadparaCostear	,
string	opcion	
)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdHojaControlDetalle(CorrelativoHojaControl	,GuiaNumero	,Residuos	,LineaDeNegocio	,Unidad	,Cantidad	,UnidadparaCostear	,
opcion	


);
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string InsUpdManifiesto(string	Correlativo	,
string	Ruc_Cliente	,string	FechaRecojo	,string	Fecha2	,
string	DireccionRecojo	,string	Transportista	,
string RellenoSanitario, string Servicio, string EstadoResiduo,
string Peligrosidad, string Fin,string Residuo, List<DetalleManifiesto> Detalle,string IngenieroResponsable, string opcion	
)
        {
            string dt;

            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

            string b;
            b = objCalimod.GetUltimocorrelativo();
            if (opcion == "I") { Correlativo = b; }

            dt = objCalimod.InsUpdManifiesto(Correlativo	,Ruc_Cliente	,
FechaRecojo	,Fecha2	,
DireccionRecojo	,Transportista	,
RellenoSanitario, Servicio, EstadoResiduo, Peligrosidad, Fin, Residuo, IngenieroResponsable,opcion	


);
            /////

            if (Detalle.Count==0) { return "Inserte Detalles primero"; }


            string dtt;
            dtt = objCalimod.InsUpdManifiestoDetalle(Correlativo,"","","", "D");

            if (opcion != "D")
            {
                foreach (DetalleManifiesto det in Detalle)
                {
                    try
                    {
                       
                        dtt = objCalimod.InsUpdManifiestoDetalle(Correlativo,det.Residuo,det.EstadoResiduo,det.Peligrosidad , "I");

                    }
                    catch (Exception)
                    {

                    }
                }
            }

            ////

             

            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Manifiesto> VerManifiesto(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerManifiesto(usuario, Nombre, FechaDesde, FechaHasta);

            List<Manifiesto> bb = new List<Manifiesto>();
            foreach (DataRow row in dt.Rows)
            {
                Manifiesto b = new Manifiesto();

                b.Correlativo = row["Correlativo"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.RellenoSanitario = row["RellenoSanitario"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Transportista = row["Transportista"].ToString();
                b.Nombre = row["Nombre"].ToString();
                bb.Add(b);


            }
            return bb;
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<ReporteLiquidacionClass> verReporteLiquidacion(string liquidacionnro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.verReporteLiquidacion(liquidacionnro);

            List<ReporteLiquidacionClass> bb = new List<ReporteLiquidacionClass>();
            foreach (DataRow row in dt.Rows)
            {
                ReporteLiquidacionClass b = new ReporteLiquidacionClass();

                b.Id = row["Id"].ToString();
                b.LiquidacionNro = row["LiquidacionNro"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.LiquidacionNro1 = row["LiquidacionNro1"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.Cantidad = row["Cantidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
                b.Tarifa = row["Tarifa"].ToString();
                b.Total = row["Total"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.FR = row["FR"].ToString();
                b.DR = row["DR"].ToString();
                b.DF = row["DF"].ToString();
                b.Sede = row["Sede"].ToString();

                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void ActualizaUsuario(UsuarioClass Usuario)
        {

            int dt1;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt1 = objCalimod.ActualizaContra(Usuario.Usuario, Usuario.Contraseña,Usuario.Privilegio);

            foreach (AccesoClass a in Usuario.Acceso)
            {
                try
                {
                    string aa = a.Acceso;
                    Boolean b;
                    b=false;
                    if (aa == "True")
                    { b = true; }
                    dt1 = objCalimod.ActualizaAcceso(Usuario.Usuario, a.Opcion,b);
                }
                catch (Exception)
                {
                    
                }

            }
                        
           
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<UsuarioClass> VerUsuarios()
        {
            DataTable dt1 = new DataTable();
            
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt1 = objCalimod.VerUsuarios();
            List<UsuarioClass> a = new List<UsuarioClass>();
            foreach (DataRow row in dt1.Rows)
            {
                UsuarioClass c = new UsuarioClass();
                    c.Contraseña = row["clave"].ToString();
                    c.Usuario=row["Usuario"].ToString();
                    c.Privilegio = row["Privilegio"].ToString();
                a.Add(c);
                
            }

            return a;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public UsuarioClass VerAccesos(string usuario)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            UsuarioClass c = new UsuarioClass();
            c.Usuario = usuario;

            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt1 = objCalimod.VerUsuarios();

            foreach (DataRow row in dt1.Rows)
            {
                if (row["Usuario"].ToString() == usuario)
                { c.Contraseña = row["clave"].ToString();

                c.Privilegio = row["Privilegio"].ToString();
                }
            }

            dt = objCalimod.VerAccesos(usuario);
            List<AccesoClass> bb = new List<AccesoClass>();
            
            foreach (DataRow row in dt.Rows)
            {
                AccesoClass b = new AccesoClass();

                b.Acceso = row["Acceso"].ToString();
                b.Opcion = row["Opcion"].ToString();
                bb.Add(b);


            }
            c.Acceso = bb;
            return c;
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Proveedor> VerProveedor(string usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerProveedor(usuario);

            List<Proveedor> bb = new List<Proveedor>();
            foreach (DataRow row in dt.Rows)
            {
                Proveedor b = new Proveedor();

                b.DireccionLegal = row["DireccionLegal"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();
                
                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Proveedor> VerProveedorFiltro(string usuario,string proveedor)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerProveedorFiltro(usuario, proveedor);

            List<Proveedor> bb = new List<Proveedor>();
            foreach (DataRow row in dt.Rows)
            {
                Proveedor b = new Proveedor();

                b.DireccionLegal = row["DireccionLegal"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();

                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<GuiasProveedor> VerGuiasProveedor(string guia,string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerGuiasProveedor(guia,Nombre, FechaDesde, FechaHasta);

            List<GuiasProveedor> bb = new List<GuiasProveedor>();
            foreach (DataRow row in dt.Rows)
            {
                GuiasProveedor b = new GuiasProveedor();

                b.Direccion = row["Direccion"].ToString();
                b.Fecha = row["Fecha"].ToString();
                b.NroGuia = row["NroGuia"].ToString();
                b.PersonaContacto = row["PersonaContacto"].ToString();


                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.FechaRegistro = row["FechaRegistro"].ToString();


                bb.Add(b);


            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public GuiasProveedor VerGuiaProveedorPorNroGuia(string NroGuia)
        {
            DataSet dt = new DataSet();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerGuiaProveedorPorNroGuia(NroGuia);

            GuiasProveedor b = new GuiasProveedor();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                try
                {
                    b.Direccion = row["Direccion"].ToString();
                    b.Fecha = row["Fecha"].ToString();
                    b.NroGuia = row["NroGuia"].ToString();
                    b.PersonaContacto = row["PersonaContacto"].ToString();
                    b.Ruc_Dni = row["Ruc_Dni"].ToString();

                    b.RellenoSanitario = row["RellenoSanitario"].ToString();
                    b.GuiaProveedor = row["GuiaProveedor"].ToString();
                    b.PlacaVehicular = row["PlacaVehicular"].ToString();
                }
                catch (Exception)
                {
                    
                }
                
            }
            List<GuiasProveedorDetalle> cc = new List<GuiasProveedorDetalle>();
            foreach (DataRow row in dt.Tables[1].Rows)
            {
                GuiasProveedorDetalle c = new GuiasProveedorDetalle();
                c.Cantidad = row["Cantidad"].ToString();
                c.Descripcion = row["Descripcion"].ToString();
                c.Unidad = row["Unidad"].ToString();

                cc.Add(c);
            
            }
            b.Detalle = cc;
            return b;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<GuiasProveedorDetalle> VerGuiasDisponiblesParaLiquidacion(string Ruc_Cliente)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerGuiasDisponiblesParaLiquidacion(Ruc_Cliente);

            List<GuiasProveedorDetalle> c = new List<GuiasProveedorDetalle>();
            foreach (DataRow row in dt.Rows)
            {
                GuiasProveedorDetalle b = new GuiasProveedorDetalle();
                b.Unidad = row["Unidad"].ToString();
                b.NroGuia = row["NroGuia"].ToString();
                b.Descripcion = row["Descripcion"].ToString();
                b.Cantidad = row["Cantidad"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.FechaRegistro = row["FechaRegistro"].ToString();
                b.GuiaProveedor = row["GuiaProveedor"].ToString();
                c.Add(b); 
            }
            return c;
        
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Proveedor VerProveedorPorRuc_Cliente(string Ruc_Dni)
        {
            DataSet dt = new DataSet();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerProveedorPorRuc_Cliente(Ruc_Dni);

            Proveedor b = new Proveedor();
            List<DireccionProveedor> c = new List<DireccionProveedor>();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                b.DireccionLegal = row["DireccionLegal"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.UltimaFechaModif = row["UltimaFechaModif"].ToString();
                b.Tipo = row["Tipo"].ToString();
                b.usuariop = row["Usuario"].ToString();
                b.PersonaContacto = row["PersonaContacto"].ToString();
             }
            foreach (DataRow row in dt.Tables[1].Rows)
            {
                DireccionProveedor cc = new DireccionProveedor();
                cc.Direccion = row["Direccion"].ToString();
                cc.Ruc_Dni = row["Ruc_Dni"].ToString();
                c.Add(cc);
            }
            b.Direcciones = c;
            return b;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String InsUpdGuiasProveedor(GuiasProveedor GuiasProveedor, string opcion)
        {
            try
            {
                int dt;
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);

                int u = GuiasProveedor.Detalle.Count;
                if (u == 0)
                {

                    return "No ha ingresado ningun detalle en la guia";
                }
                string ax;
                ax = objCalimod.InsUpdGuiasProveedor(GuiasProveedor.NroGuia,GuiasProveedor.Ruc_Dni,GuiasProveedor.Direccion,
                    GuiasProveedor.PersonaContacto,GuiasProveedor.Fecha,
                    GuiasProveedor.RellenoSanitario,GuiasProveedor.GuiaProveedor, GuiasProveedor.PlacaVehicular, opcion);

                if (ax != "ok")
                {
                    return ax; 
                }


                dt = objCalimod.InsUpdGuiasProveedorDetalle(GuiasProveedor.NroGuia, "","","", "D");
                foreach (GuiasProveedorDetalle det in GuiasProveedor.Detalle)
                {
                            try
                            {
                                if(opcion !="D")
                                { 
                                dt = objCalimod.InsUpdGuiasProveedorDetalle(GuiasProveedor.NroGuia, det.Descripcion, det.Unidad, det.Cantidad, "I");
                            }
                    }
                    catch (Exception)
                    {
                        
                    }

                }
                if (opcion == "I")
                { return "Guia Proveedor Insertada"; }
                else if (opcion == "D") { return "Guia Eliminada"; }
                else { return "Guia actualizada"; }
            }
            catch (Exception)
            {

                return "Error al insertar";
            }


        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<LiquidacionProveedor> VerLiquidacionProveedor(string Nombre, string FechaDesde, string FechaHasta,string usuario)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionProveedor(Nombre, FechaDesde, FechaHasta,usuario);

            
            List<LiquidacionProveedor> c = new List<LiquidacionProveedor>();
            foreach (DataRow row in dt.Rows)
            {
                LiquidacionProveedor b = new LiquidacionProveedor();
                b.Direccion = row["Direccion"].ToString();
                b.Fecha = row["Fecha"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.NroLiquidacion = row["NroLiquidacion"].ToString();
                b.PersonaContacto = row["PersonaContacto"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Tipo = row["Tipo"].ToString();
                c.Add(b);
            }
            return c;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<DireccionProveedor> VerDireccionProveedorPorRuc_Dni(string Ruc_Dni)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDireccionProveedorPorRuc_Dni(Ruc_Dni);


            List<DireccionProveedor> c = new List<DireccionProveedor>();
            foreach (DataRow row in dt.Rows)
            {
                DireccionProveedor b = new DireccionProveedor();
                b.Direccion = row["Direccion"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                c.Add(b);
            }
            return c;
        }
        


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public LiquidacionProveedor VerLiquidacionProveedorPorNroLiquidacion(string NroLiquidacion)
        {
            DataSet dt = new DataSet();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionProveedorPorNroLiquidacion(NroLiquidacion);


            LiquidacionProveedor b = new LiquidacionProveedor();
            List<LiquidacionProveedorDetalle> c = new List<LiquidacionProveedorDetalle>();
            foreach (DataRow row in dt.Tables[0].Rows)
            {   
                b.Direccion = row["Direccion"].ToString();
                b.Fecha = row["Fecha"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.NroLiquidacion = row["NroLiquidacion"].ToString();
                b.PersonaContacto = row["PersonaContacto"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
             
            }
            foreach (DataRow row in dt.Tables[1].Rows)
            {
                LiquidacionProveedorDetalle bb = new LiquidacionProveedorDetalle();
                bb.Cantidad = row["Cantidad"].ToString();
                bb.Descripcion = row["Descripcion"].ToString();
                bb.NroGuia = row["NroGuia"].ToString();
                bb.NroLiquidacion = row["NroLiquidacion"].ToString();
                bb.PrecioUnitario = row["PrecioUnitario"].ToString();
                bb.Total = row["Total"].ToString();
                bb.Unidad = row["Unidad"].ToString();
                c.Add(bb);
            }

            b.Detalle = c;
            return b;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String InsUpdLiquidacionProveedor(LiquidacionProveedor LiquidacionProveedor, string opcion)
        {
            try
            {
                int dt;


             
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);


                if (LiquidacionProveedor.Detalle.Count == 0 && opcion != "D") { return "Ingrese Detalle Primero"; }

                if(opcion=="I")
                {
                    string o = objCalimod.UltimoCorrelativoLiquidacionProveedor();
                    LiquidacionProveedor.NroLiquidacion = o;

                }              
                
                dt = objCalimod.InsUpdLiquidacionProveedor(LiquidacionProveedor.NroLiquidacion,LiquidacionProveedor.Ruc_Dni,
                    LiquidacionProveedor.Direccion,LiquidacionProveedor.PersonaContacto,LiquidacionProveedor.Fecha,LiquidacionProveedor.Factura, opcion);

                dt = objCalimod.InsUpdLiquidacionProveedorDetalle(LiquidacionProveedor.NroLiquidacion, "", "", "", "", "","", "", "D");
                foreach (LiquidacionProveedorDetalle det in LiquidacionProveedor.Detalle)
                {
                    try
                    {
                        if(opcion !="D")
                        { 
                    dt = objCalimod.InsUpdLiquidacionProveedorDetalle(LiquidacionProveedor.NroLiquidacion,
                        det.Descripcion,det.Unidad,det.Cantidad,det.PrecioUnitario,det.Total,det.NroGuia,"",opcion);
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                }
                if (opcion == "D")
                { return "Liquidacion de Proveedor Eliminada "; }
                else
                { return "Liquidacion de Proveedor Registrada "; }
            }
            catch (Exception)
            {

                return "Error al insertar";
            }


        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String InsUpdProveedor(Proveedor Proveedor, string opcion)
        {
            try
            {
                int dt; string dt1;
                CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
                dt1 = objCalimod.InsUpdProveedor(Proveedor.Ruc_Dni, Proveedor.Nombre, Proveedor.DireccionLegal,
                    Proveedor.Tipo, Proveedor.usuariop, Proveedor.PersonaContacto, Proveedor.NuevoRuc_Dni, opcion);

                if (dt1 != "ok")
                { return dt1;}

                dt = objCalimod.InsUpdDireccionProveedor(Proveedor.Ruc_Dni, "", "D");
                foreach (DireccionProveedor det in Proveedor.Direcciones)
                {
                    try
                    {
                        if (opcion !=  "D" )
                        {
                        dt = objCalimod.InsUpdDireccionProveedor(Proveedor.Ruc_Dni, det.Direccion, "I");
                        }
                    }
                    catch (Exception)
                    {
                        
                    }

                }
                if (opcion == "I")
                { return "Proveedor Insertado"; }
                else if (opcion == "D")
                { return "Proveedor Eliminado"; }
                else { return "Proveedor Actualizado"; }
            }
            catch (Exception)
            {

                return "Error al insertar";
            }
            
            
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Liquidacion> VerLiquidacion(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacion(usuario,Nombre, FechaDesde, FechaHasta);

            List<Liquidacion> bb = new List<Liquidacion>();
            foreach (DataRow row in dt.Rows)
            {
                Liquidacion b = new Liquidacion();
                b.Nombre = row["Nombre"].ToString();
                //b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.LiquidacionNro = row["LiquidacionNro"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.FechaRegistro = row["FechaRegistro"].ToString();
                
                
                bb.Add(b);


            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Certificado> VerCertificado(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerCertificado(usuario, Nombre, FechaDesde, FechaHasta);

            List<Certificado> bb = new List<Certificado>();
            foreach (DataRow row in dt.Rows)
            {
                Certificado b = new Certificado();
                b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.CertificadoNro = row["CertificadoNro"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.FechaRegistro = row["FechaRegistro"].ToString();
                bb.Add(b);


            }
            return bb;
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Liquidacion VerLiquidacionPorLiquidacionNro(string LiquidacionNro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionPorLiquidacionNro(LiquidacionNro);

            Liquidacion bb = new Liquidacion();
            foreach (DataRow row in dt.Rows)
            {
                Liquidacion b = new Liquidacion();
                b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.LiquidacionNro = row["LiquidacionNro"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Certificado VerCertificadoPorCertificadoNro(string CertificadoNro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerCertificadoPorCertificadoNro(CertificadoNro);

            Certificado bb = new Certificado();
            foreach (DataRow row in dt.Rows)
            {
                Certificado b = new Certificado();
                b.CorrelativoHojaControl = row["CorrelativoHojaControl"].ToString();
                b.DireccionRecojo = row["DireccionRecojo"].ToString();
                b.Fecha2 = row["Fecha2"].ToString();
                b.FechaRecojo = row["FechaRecojo"].ToString();
                b.CertificadoNro = row["LiquidacionNro"].ToString();
                b.Ruc_Cliente = row["Ruc_Cliente"].ToString();
            }
            return bb;
        }

          [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public LiquidacionDetalle VerLiquidacionDetallePorLiquidacionNro(string LiquidacionNro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerLiquidacionDetallePorLiquidacionNro(LiquidacionNro);

            LiquidacionDetalle b = new LiquidacionDetalle();
            foreach (DataRow row in dt.Rows)
            {
               
                b.Cantidad = row["Cantidad"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.LiquidacionNro = row["LiquidacionNro"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
            }
            return b;
        }

          [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public CertificadoDetalle VerCertificadoDetallePorCertificadoNro(string CertificadoNro)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerCertificadoDetallePorCertificadoNro(CertificadoNro);

            CertificadoDetalle b = new CertificadoDetalle();
            foreach (DataRow row in dt.Rows)
            {
               
                b.Cantidad = row["Cantidad"].ToString();
                b.GuiaNumero = row["GuiaNumero"].ToString();
                b.CertificadoNro = row["CertificadoNro"].ToString();
                b.Residuos = row["Residuos"].ToString();
                b.Servicio = row["Servicio"].ToString();
                b.Unidad = row["Unidad"].ToString();
                b.UnidadparaCostear = row["UnidadparaCostear"].ToString();
            }
            return b;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdLiquidacion(string	LiquidacionNro	,string	Ruc_Cliente	,string	FechaRecojo	,string	Fecha2	,
            string	DireccionRecojo	,string	CorrelativoHojaControl	,string	opcion	
)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdLiquidacion(LiquidacionNro	,Ruc_Cliente	,FechaRecojo	,
Fecha2	,DireccionRecojo	,CorrelativoHojaControl	,opcion	);
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdCertificado(string CertificadoNro, string Ruc_Cliente, string FechaRecojo, string Fecha2,
            string DireccionRecojo, string CorrelativoHojaControl, string opcion
)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdCertificado(CertificadoNro, Ruc_Cliente, FechaRecojo,
Fecha2, DireccionRecojo, CorrelativoHojaControl, opcion);
            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdLiquidacionDetalle(string	LiquidacionNro	,string	GuiaNumero	,string	Residuos	,string	Servicio
            ,string	Unidad	,string	Cantidad	,string	UnidadparaCostear,string tarifa,string total	,string	opcion	
)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdLiquidacionDetalle(LiquidacionNro	,GuiaNumero	,Residuos	,Servicio	,Unidad	,
Cantidad	,UnidadparaCostear	, tarifa, total,opcion	);
            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdCertificadDetalle(string CertificadoNro, string GuiaNumero, string Residuos, string Servicio
            , string Unidad, string Cantidad, string UnidadparaCostear, string opcion
)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdCertificadDetalle(CertificadoNro, GuiaNumero, Residuos, Servicio, Unidad,
Cantidad, UnidadparaCostear, opcion
);
            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<DestinoFinal> VerDestinoFinal()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDestinoFinal();

            List<DestinoFinal> bb = new List<DestinoFinal>();
            foreach (DataRow row in dt.Rows)
            {
                DestinoFinal b = new DestinoFinal();

                b.AutorizacionMunicial = row["AutorizacionMunicial"].ToString();
                b.AutorizacionSanitaria = row["AutorizacionSanitaria"].ToString();
                b.Cip = row["Cip"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.DNI = row["DNI"].ToString();
                b.Email = row["Email"].ToString();
                b.Ing = row["Ing"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.RegistroFechaVencimiento = row["RegistroFechaVencimiento"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Alias = row["Alias"].ToString();
                bb.Add(b);
            }
            return bb;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Transportistas> VerTransportistas()
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerTransportistas();

            List<Transportistas> bb = new List<Transportistas>();
            foreach (DataRow row in dt.Rows)
            {
                Transportistas b = new Transportistas();

                b.AutorizacionMunicial = row["AutorizacionMunicial"].ToString();
                b.AutorizacionSanitaria = row["AutorizacionSanitaria"].ToString();
                b.Cip = row["Cip"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.DNI = row["DNI"].ToString();
                b.Email = row["Email"].ToString();
                b.Ing = row["Ing"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.RegistroFechaVencimiento = row["RegistroFechaVencimiento"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();
                b.Nombre=row["Nombre"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                bb.Add(b);
            }
            return bb;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DestinoFinal VerDestinoFinalPorNombre(string Nombre)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerDestinoFinalPorNombre(Nombre);

            DestinoFinal b = new DestinoFinal();
            foreach (DataRow row in dt.Rows)
            {
                b.AutorizacionMunicial = row["AutorizacionMunicial"].ToString();
                b.AutorizacionSanitaria = row["AutorizacionSanitaria"].ToString();
                b.Cip = row["Cip"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.DNI = row["DNI"].ToString();
                b.Email = row["Email"].ToString();
                b.Ing = row["Ing"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.RegistroFechaVencimiento = row["RegistroFechaVencimiento"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();
                b.Alias = row["Alias"].ToString();

            }
            return b;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Transportistas VerTransportistasPorNombre(string Nombre)
        {
            DataTable dt = new DataTable();
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.VerTransportistasPorNombre(Nombre);

            Transportistas b = new Transportistas();
            foreach (DataRow row in dt.Rows)
            {
                b.AutorizacionMunicial = row["AutorizacionMunicial"].ToString();
                b.AutorizacionSanitaria = row["AutorizacionSanitaria"].ToString();
                b.Cip = row["Cip"].ToString();
                b.Departamento = row["Departamento"].ToString();
                b.Direccion = row["Direccion"].ToString();
                b.Distrito = row["Distrito"].ToString();
                b.DNI = row["DNI"].ToString();
                b.Email = row["Email"].ToString();
                b.Ing = row["Ing"].ToString();
                b.Nombre = row["Nombre"].ToString();
                b.Provincia = row["Provincia"].ToString();
                b.RegistroFechaVencimiento = row["RegistroFechaVencimiento"].ToString();
                b.RepresentanteLegal = row["RepresentanteLegal"].ToString();
                b.Ruc_Dni = row["Ruc_Dni"].ToString();
                b.Telefono = row["Telefono"].ToString();

            }
            return b;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdTransportistas(string	Nombre	,string	Ruc_Dni	,string	RegistroFechaVencimiento	,
            string	AutorizacionSanitaria	,string	AutorizacionMunicial	,string	Direccion	,
string	Distrito	,string	Provincia	,string	Departamento	,string	Telefono	,string	Email	,
string	RepresentanteLegal	,string	DNI	,string	Ing	,string	Cip	,string	opcion	)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdTransportistas(Nombre, Ruc_Dni, RegistroFechaVencimiento, AutorizacionSanitaria,
AutorizacionMunicial	,Direccion	,Distrito	,Provincia	,Departamento	,Telefono	,Email	,RepresentanteLegal	,
DNI	,Ing	,Cip	,
opcion	);


            return dt;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InsUpdDestinoFinal(string Nombre, string Ruc_Dni, string RegistroFechaVencimiento, string AutorizacionSanitaria, string AutorizacionMunicial, string Direccion,
string Distrito, string Provincia, string Departamento, string Telefono, string Email,
string RepresentanteLegal, string DNI, string Ing, string Cip,string Alias, string opcion)
        {
            int dt;
            CatalogoBL.CatalogoBL objCalimod = new CatalogoBL.CatalogoBL(System.Configuration.ConfigurationManager.ConnectionStrings["CatalogoBDSql"].ConnectionString);
            dt = objCalimod.InsUpdDestinoFinal(Nombre, Ruc_Dni, RegistroFechaVencimiento, AutorizacionSanitaria,
AutorizacionMunicial, Direccion, Distrito, Provincia, Departamento, Telefono, Email, RepresentanteLegal,
DNI, Ing, Cip,Alias,
opcion);


            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Security.Cryptography;
using System.Net;


namespace CatalogoDA
{
    public class CatalogoDA
    {
        private string _DataBaseName;

        public CatalogoDA(string DataBaseName)
        {
            _DataBaseName = DataBaseName;
        }
        public DataTable UsuarioNombreCompleto(string Nombre)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "spUsuarioNombreCompleto";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }



        public int FunUsuarioComprobar(string usuario, string contraseña)
        {
            try
            {
                //string claveSHA = GenerarClaveSHA1(Clave);
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "FunUsuarioPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@clave", DbType.String, contraseña);

                return int.Parse(db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerUsuarios()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerUsuarios";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@catalogo", DbType.String, catalogo);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdUsuariosFaber(string usuario, string clave, string usuarioregistro)
        {
            try
            {
                //string claveSHA = GenerarClaveSHA1(Clave);
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdUsuariosPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@clave", DbType.String, clave);
                db.AddInParameter(dbCommand, "@usuarioregistro", DbType.String, usuarioregistro);

                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerAccesos(string usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerAccesosPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int ActualizaAcceso(string usu, string cid, bool status)
        {
            try
            {
                //string claveSHA = GenerarClaveSHA1(Clave);
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "ActualizaAccesoPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usu);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, cid);
                db.AddInParameter(dbCommand, "@acceso", DbType.Boolean, status);

                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int ActualizaAcceso(string p, string a, string c)
        {
            try
            {
                //string claveSHA = GenerarClaveSHA1(Clave);
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "CambiarContraPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, p);
                db.AddInParameter(dbCommand, "@clave", DbType.String, a);
                db.AddInParameter(dbCommand, "@Privilegio", DbType.String, c);

                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }
        public DataSet VerAlmacenAccesos(string usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerAlmacenAccesosPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }
        //--VerclientesPraxy
        public DataSet VerClientes(string NombreB,string RucB,string usuario )
        {
        try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerclientesPraxy";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NombreB", DbType.String, NombreB);
                db.AddInParameter(dbCommand, "@RucB", DbType.String, RucB);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int insertcliente(string p1, string p2)
        {
            try
            {
                //string claveSHA = GenerarClaveSHA1(Clave);
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "insertcliente";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@nombre", DbType.String, p1);
                db.AddInParameter(dbCommand, "@apellido", DbType.String, p2);
                //db.AddInParameter(dbCommand, "@acceso", DbType.Boolean, status);

                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerCliente(string p)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "Vercliente";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@nombre", DbType.String, p);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerClientePorDNI(string ruc_dni)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerClientePorDNI";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string UpdateCliente(string ruc_dni, string CE, string Correo, string DNI,
            string IngenieroResponsable, string Nombre, string RepresentanteLegal, string Telefono, string usuario
            ,string TieneContrato,string FechaRegistro,string NuevoRuc_Dni,string opcion)
        {
            try
            {
                int a, m, d;
                a = 0; m = 0; d = 0;
                try
                {
                    a = DateTime.Parse(FechaRegistro).Year;
                    m = DateTime.Parse(FechaRegistro).Month;
                    d = DateTime.Parse(FechaRegistro).Day;
                }
                catch (Exception)
                {
                    
                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdateCliente";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                db.AddInParameter(dbCommand, "@CE", DbType.String, CE);
                db.AddInParameter(dbCommand, "@Correo", DbType.String, Correo);
                db.AddInParameter(dbCommand, "@DNI", DbType.String, DNI);

                db.AddInParameter(dbCommand, "@IngenieroResponsable", DbType.String, IngenieroResponsable);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                db.AddInParameter(dbCommand, "@RepresentanteLegal", DbType.String, RepresentanteLegal);
                db.AddInParameter(dbCommand, "@Telefono", DbType.String, Telefono);

                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);

                db.AddInParameter(dbCommand, "@TieneContrato", DbType.String, TieneContrato);
                db.AddInParameter(dbCommand, "@FechaRegistroAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaRegistroMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaRegistroDia", DbType.String, d);
                db.AddInParameter(dbCommand, "@NuevoRuc_Dni", DbType.String, NuevoRuc_Dni);
                
                

                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return ex.Message;
            }
        }

        public DataSet VerDireccion(string ruc_dni)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDireccion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerDireccionPorDireccion(string ruc_dni, string direccion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDireccionPorDireccion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int UpdInsDireccion(string ruc_dni, string direccion, string Urbanizacion, 
            string Distrito, string Provincia, string Departamento, string Codigo_Postal, string Sede,
            string NuevaDireccion, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdInsDireccion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                db.AddInParameter(dbCommand, "@Urbanizacion", DbType.String, Urbanizacion);
                db.AddInParameter(dbCommand, "@Distrito", DbType.String, Distrito);

                db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                db.AddInParameter(dbCommand, "@Codigo_Postal", DbType.String, Codigo_Postal);
                db.AddInParameter(dbCommand, "@Sede", DbType.String, Sede);
                db.AddInParameter(dbCommand, "@NuevaDireccion", DbType.String, NuevaDireccion);

                

                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }

        }

        public DataSet VerServicios()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerServicios";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdServicios(string Servicio, string Unidad, string Tarifa, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdServicios";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Tarifa", DbType.String, Tarifa);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                //db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                //db.AddInParameter(dbCommand, "@Codigo_Postal", DbType.String, Codigo_Postal);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerServiciosPorServicio(string Servicio)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerServiciosPorServicio";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerResiduos()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerResiduos";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }
        public DataSet VerResiduosCompra()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerResiduosCompra";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@ruc_dni", DbType.String, ruc_dni);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdResiduos(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdResiduos";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, Residuo);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Tarifa", DbType.String, Tarifa);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                //db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                //db.AddInParameter(dbCommand, "@Codigo_Postal", DbType.String, Codigo_Postal);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }
        public int InsUpdResiduosCompra(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdResiduosCompra";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, Residuo);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Tarifa", DbType.String, Tarifa);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                //db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                //db.AddInParameter(dbCommand, "@Codigo_Postal", DbType.String, Codigo_Postal);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerResiduosPorResiduo(string Residuo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerResiduosPorResiduo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, Residuo);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerGuia_Pesaje(string guia,string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            try
            {


                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {
            
                        a = DateTime.Parse(FechaDesde).Year;
                        a1 = DateTime.Parse(FechaHasta).Year;
                        m = DateTime.Parse(FechaDesde).Month;
                        m1 = DateTime.Parse(FechaHasta).Month;
                        d = DateTime.Parse(FechaDesde).Day;
                        d1 = DateTime.Parse(FechaHasta).Day;
                
                }
                catch (Exception)
                {
                    
                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuia_Pesaje";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@guia", DbType.String, guia);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);

                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerGuia_PesajePorGuia(string GuiaNumero)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuia_PesajePorGuia";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string UpdInsVerGuia_Pesaje(string GuiaNumero, string BoletaRelleno, string Ruc_Cliente, string FechaRecojo, 
            string Fecha2, string DireccionRecojo, string UsadoParaManifiesto, string UsadoParaControl, string NroManifiesto,
            string NroControl, string UltimoUsuario, string UltimaFechaModif, string DestinoFinal,
            string TipoResiduo, string Placa, string GuiaTransportista, string opcion, string TipoOperacion, string OtrosDestinos)
        {
            try
            {
                int a = 1900, a1 = 1900, m = 1, m1 = 1, d = 1, d1 = 1;
                
                if(opcion !="D")
                { 
                a = DateTime.Parse(FechaRecojo).Year;
                a1 = DateTime.Parse(FechaRecojo).Year;
                m = DateTime.Parse(FechaRecojo).Month;
                m1 = DateTime.Parse(FechaRecojo).Month;
                d = DateTime.Parse(FechaRecojo).Day;
                d1 = DateTime.Parse(FechaRecojo).Day;
                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdInsVerGuia_Pesaje";

                if (TipoOperacion == "PR") { sqlCommand = "UpdInsVerGuia_PesajeParcial"; Fecha2 = "01/01/1900"; }

                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                db.AddInParameter(dbCommand, "@BoletaRelleno", DbType.String, BoletaRelleno);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);

                db.AddInParameter(dbCommand, "@FechaRecojoAño", DbType.Int16, DateTime.Parse(FechaRecojo).Year);
                db.AddInParameter(dbCommand, "@Fecha2Año", DbType.Int16, DateTime.Parse(Fecha2).Year);

                db.AddInParameter(dbCommand, "@FechaRecojoMes", DbType.Int16, DateTime.Parse(FechaRecojo).Month);
                db.AddInParameter(dbCommand, "@Fecha2Mes", DbType.Int16, DateTime.Parse(Fecha2).Month);

                db.AddInParameter(dbCommand, "@FechaRecojoDia", DbType.Int16, DateTime.Parse(FechaRecojo).Day);
                db.AddInParameter(dbCommand, "@Fecha2Dia", DbType.Int16, DateTime.Parse(Fecha2).Day);


                db.AddInParameter(dbCommand, "@DireccionRecojo", DbType.String, DireccionRecojo);

                db.AddInParameter(dbCommand, "@UsadoParaManifiesto", DbType.String, UsadoParaManifiesto);
                db.AddInParameter(dbCommand, "@UsadoParaControl", DbType.String, UsadoParaControl);

                db.AddInParameter(dbCommand, "@NroManifiesto", DbType.String, NroManifiesto);
                db.AddInParameter(dbCommand, "@NroControl", DbType.String, NroControl);
                db.AddInParameter(dbCommand, "@UltimoUsuario", DbType.String, UltimoUsuario);
                db.AddInParameter(dbCommand, "@DestinoFinal", DbType.String, DestinoFinal);
                db.AddInParameter(dbCommand, "@TipoResiduo", DbType.String, TipoResiduo);
                db.AddInParameter(dbCommand, "@Placa", DbType.String, Placa);
                db.AddInParameter(dbCommand, "@GuiaTransportista", DbType.String, GuiaTransportista);
                db.AddInParameter(dbCommand, "@OtrosDestinos", DbType.String, OtrosDestinos);
                
                //TipoResiduo
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@pagina", DbType.String, pagina);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int UpdInsGuia_Pesaje_Detalle(string GuiaNumero, string Residuos, string Servicio, string TipoResiduos, string Unidad,
            string Cantidad, string Cantidad1,string Boleta,string UnidadDeposito, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdInsGuia_Pesaje_Detalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                db.AddInParameter(dbCommand, "@Residuos", DbType.String, Residuos);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@TipoResiduos", DbType.String, TipoResiduos);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                db.AddInParameter(dbCommand, "@Cantidad1", DbType.String, Cantidad1);
                db.AddInParameter(dbCommand, "@Boleta", DbType.String, Boleta);
                db.AddInParameter(dbCommand, "@UnidadDeposito", DbType.String, UnidadDeposito);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
               
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControl(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            try
            {
                
                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                              


                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControl";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControlPorHojaControl(string HojaControl)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControlPorHojaControl";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdDelHojaControl(string HojaControl, string Correlativo, string Ruc_Cliente,
            string FechaRecojo, string Fecha2, string DireccionRecojo, string UsadoParaLiquidacion,
            string NroLiquidacion, string UsadoParaCertificado, string NroCertificado, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdDelHojaControl";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                db.AddInParameter(dbCommand, "@Correlativo", DbType.String, Correlativo);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);

                db.AddInParameter(dbCommand, "@FechaRecojo", DbType.String, "01/01/1900");
                db.AddInParameter(dbCommand, "@Fecha2", DbType.String, Fecha2);
                db.AddInParameter(dbCommand, "@DireccionRecojo", DbType.String, DireccionRecojo);
                db.AddInParameter(dbCommand, "@UsadoParaLiquidacion", DbType.String, UsadoParaLiquidacion);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                db.AddInParameter(dbCommand, "@UsadoParaCertificado", DbType.String, UsadoParaCertificado);
                db.AddInParameter(dbCommand, "@NroCertificado", DbType.String, NroCertificado);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int UPdateMaestroPrecios(string Servicio, string Ruc_Dni, string UnidadMedida, string Tarifa, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UPdateMaestroPrecios";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@UnidadMedida", DbType.String, UnidadMedida);
                db.AddInParameter(dbCommand, "@Tarifa", DbType.String, Tarifa);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }



        public DataTable VerMaestroPrecios(string Usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerMaestroPrecios";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdHojaControlDetalle(string CorrelativoHojaControl, string GuiaNumero, string Residuos, 
            string LineaDeNegocio, string Unidad, string Cantidad, string UnidadparaCostear,
          
            string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdHojaControlDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CorrelativoHojaControl", DbType.String, CorrelativoHojaControl);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                db.AddInParameter(dbCommand, "@Residuos", DbType.String, Residuos);
                db.AddInParameter(dbCommand, "@LineaDeNegocio", DbType.String, LineaDeNegocio);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);

                db.AddInParameter(dbCommand, "@UnidadparaCostear", DbType.String, UnidadparaCostear);
        

                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControlDetalle(string CorrelativoHojaControl)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControlDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, CorrelativoHojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string InsUpdManifiesto(string Correlativo, string Ruc_Cliente, string FechaRecojo, string Fecha2, 
            string DireccionRecojo, string Transportista, string RellenoSanitario, string Servicio
            ,string EstadoResiduo,string Peligrosidad,string Fin,string Residuo,string IngenieroResponsable,
            string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdManifiesto";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Correlativo", DbType.String, Correlativo);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                db.AddInParameter(dbCommand, "@FechaRecojo", DbType.String, FechaRecojo);
                db.AddInParameter(dbCommand, "@Fecha2", DbType.String, Fecha2);
                db.AddInParameter(dbCommand, "@DireccionRecojo", DbType.String, DireccionRecojo);
                db.AddInParameter(dbCommand, "@Transportista", DbType.String, Transportista);
                db.AddInParameter(dbCommand, "@RellenoSanitario", DbType.String, RellenoSanitario);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);

                db.AddInParameter(dbCommand, "@EstadoResiduo", DbType.String, EstadoResiduo);
                db.AddInParameter(dbCommand, "@Peligrosidad", DbType.String, Peligrosidad);
                db.AddInParameter(dbCommand, "@Fin", DbType.String, Fin);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, Residuo);
                db.AddInParameter(dbCommand, "@IngenieroResponsable", DbType.String, IngenieroResponsable);

                
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return "Formato de Fecha Erroneo";
            }
        }

        public DataTable VerManifiesto(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            try
            {


                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                              


                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerManifiesto";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacion(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            try         
                
            {

                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerCertificado(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            try
            {
                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerCertificado";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionPorLiquidacionNro(string LiquidacionNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionPorLiquidacionNro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@LiquidacionNro", DbType.String, LiquidacionNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerCertificadoPorCertificadoNro(string CertificadoNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerCertificadoPorCertificadoNro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionDetallePorLiquidacionNro(string LiquidacionNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionDetallePorLiquidacionNro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@LiquidacionNro", DbType.String, LiquidacionNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerCertificadoDetallePorCertificadoNro(string CertificadoNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerCertificadoDetallePorCertificadoNro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdCertificado(string CertificadoNro, string Ruc_Cliente, string FechaRecojo, 
            string Fecha2, string DireccionRecojo, string CorrelativoHojaControl, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdCertificado";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                db.AddInParameter(dbCommand, "@FechaRecojo", DbType.String, FechaRecojo);
                db.AddInParameter(dbCommand, "@Fecha2", DbType.String, "01/01/2020");
                db.AddInParameter(dbCommand, "@DireccionRecojo", DbType.String, DireccionRecojo);
                db.AddInParameter(dbCommand, "@CorrelativoHojaControl", DbType.String, CorrelativoHojaControl);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdLiquidacion(string LiquidacionNro, string Ruc_Cliente, string FechaRecojo, string Fecha2, string DireccionRecojo, string CorrelativoHojaControl, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@LiquidacionNro", DbType.String, LiquidacionNro);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                db.AddInParameter(dbCommand, "@FechaRecojo", DbType.String, FechaRecojo);
                db.AddInParameter(dbCommand, "@Fecha2", DbType.String, "01/01/1900");
                db.AddInParameter(dbCommand, "@DireccionRecojo", DbType.String, DireccionRecojo);
                db.AddInParameter(dbCommand, "@CorrelativoHojaControl", DbType.String, CorrelativoHojaControl);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdLiquidacionDetalle(string LiquidacionNro, string GuiaNumero, string Residuos, string Servicio,
            string Unidad, string Cantidad, string UnidadparaCostear, string tarifa, string total, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdLiquidacionDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@LiquidacionNro", DbType.String, LiquidacionNro);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                db.AddInParameter(dbCommand, "@Residuos", DbType.String, Residuos);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                db.AddInParameter(dbCommand, "@UnidadparaCostear", DbType.String, UnidadparaCostear);
                db.AddInParameter(dbCommand, "@tarifa", DbType.String, tarifa);
                db.AddInParameter(dbCommand, "@total", DbType.String, total);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdCertificadDetalle(string CertificadoNro, string GuiaNumero, string Residuos, string Servicio, string Unidad, string Cantidad, string UnidadparaCostear, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdCertificadDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                db.AddInParameter(dbCommand, "@GuiaNumero", DbType.String, GuiaNumero);
                db.AddInParameter(dbCommand, "@Residuos", DbType.String, Residuos);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                db.AddInParameter(dbCommand, "@UnidadparaCostear", DbType.String, UnidadparaCostear);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerDestinoFinal()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDestinoFinal";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerTransportistas()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerTransportistas";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerDestinoFinalPorNombre(string Nombre)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDestinoFinalPorNombre";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerTransportistasPorNombre(string Nombre)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerTransportistasPorNombre";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdTransportistas(string Nombre, string Ruc_Dni, string RegistroFechaVencimiento, 
            string AutorizacionSanitaria, string AutorizacionMunicial, string Direccion, string Distrito,
            string Provincia, string Departamento, string Telefono, string Email, string RepresentanteLegal, 
            string DNI, string Ing, string Cip, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdTransportistas";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@RegistroFechaVencimiento", DbType.String, RegistroFechaVencimiento);
                db.AddInParameter(dbCommand, "@AutorizacionSanitaria", DbType.String, AutorizacionSanitaria);
                db.AddInParameter(dbCommand, "@AutorizacionMunicial", DbType.String, AutorizacionMunicial);
                db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);
                db.AddInParameter(dbCommand, "@Distrito", DbType.String, Distrito);
                db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                db.AddInParameter(dbCommand, "@Telefono", DbType.String, Telefono);
                db.AddInParameter(dbCommand, "@Email", DbType.String, Email);
                db.AddInParameter(dbCommand, "@RepresentanteLegal", DbType.String, RepresentanteLegal);
                db.AddInParameter(dbCommand, "@DNI", DbType.String, DNI);
                db.AddInParameter(dbCommand, "@Ing", DbType.String, Ing);
                db.AddInParameter(dbCommand, "@Cip", DbType.String, Cip);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdDestinoFinal(string Nombre, string Ruc_Dni, string RegistroFechaVencimiento,
            string AutorizacionSanitaria, string AutorizacionMunicial, string Direccion, string Distrito,
            string Provincia, string Departamento, string Telefono, string Email, string RepresentanteLegal, 
            string DNI, string Ing, string Cip, string Alias, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdDestinoFinal";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@RegistroFechaVencimiento", DbType.String, RegistroFechaVencimiento);
                db.AddInParameter(dbCommand, "@AutorizacionSanitaria", DbType.String, AutorizacionSanitaria);
                db.AddInParameter(dbCommand, "@AutorizacionMunicial", DbType.String, AutorizacionMunicial);
                db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);
                db.AddInParameter(dbCommand, "@Distrito", DbType.String, Distrito);
                db.AddInParameter(dbCommand, "@Provincia", DbType.String, Provincia);
                db.AddInParameter(dbCommand, "@Departamento", DbType.String, Departamento);
                db.AddInParameter(dbCommand, "@Telefono", DbType.String, Telefono);
                db.AddInParameter(dbCommand, "@Email", DbType.String, Email);
                db.AddInParameter(dbCommand, "@RepresentanteLegal", DbType.String, RepresentanteLegal);
                db.AddInParameter(dbCommand, "@DNI", DbType.String, DNI);
                db.AddInParameter(dbCommand, "@Ing", DbType.String, Ing);
                db.AddInParameter(dbCommand, "@Cip", DbType.String, Cip);
                db.AddInParameter(dbCommand, "@Alias", DbType.String, Alias);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojasDisponibles(string Ruc_Cliente)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojasDisponibles";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable UltimoCorrelativoHojas()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UltimoCorrelativoHojas";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                ////////// Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControlReporte(string HojaControl)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControlReporte";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionesDisponibles(string Ruc_Cliente)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionesDisponibles";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControlDetalleDisponible(string HojaControl)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControlDetalleDisponible";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable UltimoCorrelativoLiquidacion()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UltimoCorrelativoLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable verReporteLiquidacion(string LiquidacionNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "verReporteLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@LiquidacionNro", DbType.String, LiquidacionNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerCertificadosDisponibles(string Ruc_Cliente)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerCertificadosDisponibles";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerHojaControlDetalleDisponibleCertificado(string HojaControl)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerHojaControlDetalleDisponibleCertificado";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable UltimoCorrelativoCertificado()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UltimoCorrelativoCertificado";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@HojaControl", DbType.String, HojaControl);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable verReportecertificado(string CertificadoNro, string residuo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "verReportecertificado";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                db.AddInParameter(dbCommand, "@residuo", DbType.String, residuo);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerProveedor(string usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }


        public DataTable VerProveedorFiltro(string usuario,string proveedor)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerProveedorFiltro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@proveedor", DbType.String, proveedor);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }


        public DataSet VerProveedorPorRuc_Cliente(string Ruc_Dni)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerProveedorPorRuc_Cliente";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string InsUpdProveedor(string Ruc_Dni, string Nombre, string DireccionLegal,string Tipo,string Usuario, 
            string PersonaContacto,string NuevoRuc_Dni,string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
                db.AddInParameter(dbCommand, "@DireccionLegal", DbType.String, DireccionLegal);
                db.AddInParameter(dbCommand, "@Tipo", DbType.String, Tipo);
                db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);
                db.AddInParameter(dbCommand, "@PersonaContacto", DbType.String, PersonaContacto);
                db.AddInParameter(dbCommand, "@NuevoRuc_Dni", DbType.String, NuevoRuc_Dni);
                               
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdDireccionProveedor(string Ruc_Dni, string Direccion, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdDireccionProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerGuiaProveedorPorNroGuia(string NroGuia)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuiaProveedorPorNroGuia";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        

        public int InsUpdGuiasProveedorDetalle(string NroGuia, string Descripcion, string Unidad, 
            string Cantidad, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdGuiasProveedorDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);
                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionProveedor(string Nombre, string FechaDesde, string FechaHasta,string usuario)
        {

            try
            {
                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);
                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);

                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);

                //db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataSet VerLiquidacionProveedorPorNroLiquidacion(string NroLiquidacion)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionProveedorPorNroLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdLiquidacionProveedor(string NroLiquidacion, string Ruc_Dni, string Direccion,
            string PersonaContacto, string Fecha,string Factura ,string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdLiquidacionProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);

                db.AddInParameter(dbCommand, "@PersonaContacto", DbType.String, PersonaContacto);

                db.AddInParameter(dbCommand, "@Fecha", DbType.String, Fecha);
                db.AddInParameter(dbCommand, "@Factura", DbType.String, Factura);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdLiquidacionProveedorDetalle(string NroLiquidacion, string Descripcion, string Unidad, 
            string Cantidad, string PrecioUnitario, string Total, string NroGuia,string Factura, string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdLiquidacionProveedorDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
                db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                db.AddInParameter(dbCommand, "@Factura", DbType.String, Factura);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerGuiasProveedor(string guia,string Nombre, string FechaDesde, string FechaHasta)
        {
            try
            {
                int a = 0, a1 = 0, m = 1, m1 = 1, d = 1, d1 = 1;
                try
                {

                    a = DateTime.Parse(FechaDesde).Year;
                    a1 = DateTime.Parse(FechaHasta).Year;
                    m = DateTime.Parse(FechaDesde).Month;
                    m1 = DateTime.Parse(FechaHasta).Month;
                    d = DateTime.Parse(FechaDesde).Day;
                    d1 = DateTime.Parse(FechaHasta).Day;

                }
                catch (Exception)
                {

                }

                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuiasProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@guia", DbType.String, guia);
                
                db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);

                db.AddInParameter(dbCommand, "@FechaDesdeAño", DbType.String, a);
                db.AddInParameter(dbCommand, "@FechaDesdeMes", DbType.String, m);
                db.AddInParameter(dbCommand, "@FechaDesdeDia", DbType.String, d);


                db.AddInParameter(dbCommand, "@FechaHastaAño", DbType.String, a1);
                db.AddInParameter(dbCommand, "@FechaHastaMes", DbType.String, m1);
                db.AddInParameter(dbCommand, "@FechaHastaDia", DbType.String, d1);
                //db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                //db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
                //db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                //db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                //db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                //db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                //db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerGuiasDisponiblesParaLiquidacion(string Ruc_Cliente)
        {

            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuiasDisponiblesParaLiquidacion";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
                //db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                //db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                //db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                //db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                //db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string UltimoCorrelativoLiquidacionProveedor()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UltimoCorrelativoLiquidacionProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Ruc_Cliente", DbType.String, Ruc_Cliente);
                //db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
                //db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                //db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                //db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                //db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                //db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionProveedorReporte(string NroLiquidacion,string residuo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionProveedorReporte";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);
                db.AddInParameter(dbCommand, "@residuo", DbType.String, residuo);
                //db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                //db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                //db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                //db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                //db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerReporteManifiesto(string Correlativo, string Residuo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerReporteManifiesto";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Correlativo", DbType.String, Correlativo);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, Residuo);
                //db.AddInParameter(dbCommand, "@Unidad", DbType.String, Unidad);

                //db.AddInParameter(dbCommand, "@Cantidad", DbType.String, Cantidad);
                //db.AddInParameter(dbCommand, "@PrecioUnitario", DbType.String, PrecioUnitario);
                //db.AddInParameter(dbCommand, "@Total", DbType.String, Total);
                //db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string InsUpdGuiasProveedor(string NroGuia, string Ruc_Dni, string Direccion, string PersonaContacto,
            string Fecha, string RellenoSanitario, string GuiaProveedor,string PlacaVehicular, string opcion)
        {
         
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdGuiasProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroGuia", DbType.String, NroGuia);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);
                db.AddInParameter(dbCommand, "@PersonaContacto", DbType.String, PersonaContacto);
                db.AddInParameter(dbCommand, "@RellenoSanitario", DbType.String, RellenoSanitario);
                db.AddInParameter(dbCommand, "@GuiaProveedor", DbType.String, GuiaProveedor);
                db.AddInParameter(dbCommand, "@PlacaVehicular", DbType.String, PlacaVehicular);
                
                
                

                try
                {
                    db.AddInParameter(dbCommand, "@FechaAño", DbType.Int16, DateTime.Parse(Fecha).Year);
                    db.AddInParameter(dbCommand, "@FechaMes", DbType.Int16, DateTime.Parse(Fecha).Month);
                    db.AddInParameter(dbCommand, "@FechaDia", DbType.Int16, DateTime.Parse(Fecha).Day);

                }
                catch (Exception)
                {

                    db.AddInParameter(dbCommand, "@FechaAño", DbType.Int16, 2020);
                    db.AddInParameter(dbCommand, "@FechaMes", DbType.Int16, 1);
                    db.AddInParameter(dbCommand, "@FechaDia", DbType.Int16, 1);
                }
                
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);

                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                 return ex.Message;
            }
        
        }

        public DataTable VerDireccionProveedorPorRuc_Dni(string Ruc_Dni)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDireccionProveedorPorRuc_Dni";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                //db.AddInParameter(dbCommand, "@Direccion", DbType.String, Direccion);
                //db.AddInParameter(dbCommand, "@PersonaContacto", DbType.String, PersonaContacto);
                //db.AddInParameter(dbCommand, "@Fecha", DbType.String, "01/01/2020");
                //db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);

                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerMaestroPreciosProveedor(string Usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerMaestroPreciosProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);
                //db.AddInParameter(dbCommand, "@direccion", DbType.String, direccion);
                //db.AddInParameter(dbCommand, "@SistemaId", DbType.Int32, SistemaId);
                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int UPdateMaestroPreciosProveedor(string Servicio, string Ruc_Dni, string UnidadMedida,
            string Tarifa, string Moneda,string opcion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UPdateMaestroPreciosProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@UnidadMedida", DbType.String, UnidadMedida);
                db.AddInParameter(dbCommand, "@Tarifa", DbType.String, Tarifa);
                db.AddInParameter(dbCommand, "@Moneda", DbType.String, Moneda);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string TraeTarifaProveedor(string Servicio, string Ruc_Dni, string UnidadMedida)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "TraeTarifaProveedor";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                db.AddInParameter(dbCommand, "@UnidadMedida", DbType.String, UnidadMedida);
               

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string GetUltimocorrelativo()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "GetUltimocorrelativo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Servicio", DbType.String, Servicio);
                //db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, Ruc_Dni);
                //db.AddInParameter(dbCommand, "@UnidadMedida", DbType.String, UnidadMedida);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string InsUpdManifiestoDetalle(string Correlativo, string p1, string p2, string p3, string p4)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdManifiestoDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Correlativo", DbType.String, Correlativo);
                db.AddInParameter(dbCommand, "@Residuo", DbType.String, p1);
                db.AddInParameter(dbCommand, "@EstadoResiduo", DbType.String, p2);

                db.AddInParameter(dbCommand, "@Peligrosidad", DbType.String, p3);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, p4);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerManifiestoDetalle(string Correlativo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerManifiestoDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Correlativo", DbType.String, Correlativo);
                

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }



        public DataTable VerCertificadoDetalle(string CertificadoNro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerCertificadoDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@CertificadoNro", DbType.String, CertificadoNro);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerLiquidacionProveedorDetalle(string NroLiquidacion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerLiquidacionProveedorDetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@NroLiquidacion", DbType.String, NroLiquidacion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }


        public DataTable VerClientePorUsuario(string usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerClientePorUsuario";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable UpdateUsuarioClienteMasivo(string ruc, string Usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdateUsuarioClienteMasivo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, ruc);
                db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerGuiasDeServicio()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuiasDeServicio";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, ruc);
                //db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerGuiasDeCompra()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerGuiasDeCompra";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Ruc_Dni", DbType.String, ruc);
                //db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerActivo(string Codigo, string descripcion)
        {
             try
            
             {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerActivo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);
                db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }



        public DataTable VerActivoPorCodigo(string Codigo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerActivoPorCodigo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string UpdateActivo(string Codigo,string Fecha_de_adquision,string nro_Factura, string proveedor, string descripcion, string marca,
            string modelo, string serie, string largo, string ancho, string altura, string color, string estado,
            string precio, string igv, string total, string usuario,string local, string ambiente,
            string Cod_familia,string anio_fabricacion, string fecha_de_inv,

            string opcion, string categoriasunat, string imagen, string tasadepreciacion,
 
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


            try
            {

                int a, m, d;
                a = 0; m = 0; d = 0;
                try
                {
                    a = DateTime.Parse(Fecha_de_adquision).Year;
                    m = DateTime.Parse(Fecha_de_adquision).Month;
                    d = DateTime.Parse(Fecha_de_adquision).Day;
                }
                catch (Exception)
                {

                }



                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "UpdateActivo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);
                db.AddInParameter(dbCommand, "@Fecha_de_adquision_dia", DbType.String, d);
                db.AddInParameter(dbCommand, "@Fecha_de_adquision_mes", DbType.String, m);
                db.AddInParameter(dbCommand, "@Fecha_de_adquision_anio", DbType.String, a);
                db.AddInParameter(dbCommand, "@nro_Factura", DbType.String, nro_Factura);
                db.AddInParameter(dbCommand, "@proveedor", DbType.String, proveedor);
                db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);
                db.AddInParameter(dbCommand, "@marca", DbType.String, marca);
                db.AddInParameter(dbCommand, "@modelo", DbType.String, modelo);
                db.AddInParameter(dbCommand, "@serie", DbType.String, serie);
                db.AddInParameter(dbCommand, "@largo", DbType.String, largo);
                db.AddInParameter(dbCommand, "@ancho", DbType.String, ancho);
                db.AddInParameter(dbCommand, "@altura", DbType.String, altura);
                db.AddInParameter(dbCommand, "@color", DbType.String, color);
                db.AddInParameter(dbCommand, "@estado", DbType.String, estado);
                db.AddInParameter(dbCommand, "@precio", DbType.String, precio);
                db.AddInParameter(dbCommand, "@igv", DbType.String, igv);
                db.AddInParameter(dbCommand, "@total", DbType.String, total);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                db.AddInParameter(dbCommand, "@local", DbType.String, local);
                db.AddInParameter(dbCommand, "@ambiente", DbType.String, ambiente);

                db.AddInParameter(dbCommand, "@Cod_familia", DbType.String, Cod_familia);
                db.AddInParameter(dbCommand, "@anio_fabricacion", DbType.String, anio_fabricacion);
                db.AddInParameter(dbCommand, "@fecha_de_inv", DbType.String, fecha_de_inv);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, opcion);
                db.AddInParameter(dbCommand, "@categoriasunat", DbType.String, categoriasunat);
                db.AddInParameter(dbCommand, "@imagen", DbType.String, imagen);
                db.AddInParameter(dbCommand, "@tasadepreciacion", DbType.String, tasadepreciacion);


                db.AddInParameter(dbCommand, "@UsuarioAnterior", DbType.String, UsuarioAnterior);
                db.AddInParameter(dbCommand, "@nrovoucher", DbType.String, nrovoucher);
                db.AddInParameter(dbCommand, "@Dimensiones", DbType.String, Dimensiones);
                db.AddInParameter(dbCommand, "@PESO", DbType.String, PESO);
                db.AddInParameter(dbCommand, "@CONSUMO_ENERGIA", DbType.String, CONSUMO_ENERGIA);
                db.AddInParameter(dbCommand, "@TIPO_EQUIPO_CATEGORIA", DbType.String, TIPO_EQUIPO_CATEGORIA);
                db.AddInParameter(dbCommand, "@Ruc_Proveedor", DbType.String, Ruc_Proveedor);
                db.AddInParameter(dbCommand, "@TIPO_DE_ACTIVO", DbType.String, TIPO_DE_ACTIVO);
                db.AddInParameter(dbCommand, "@TIPO_MATERIAL", DbType.String, TIPO_MATERIAL);
                db.AddInParameter(dbCommand, "@CATEGORIA", DbType.String, CATEGORIA);
                db.AddInParameter(dbCommand, "@EDIFICIO", DbType.String, EDIFICIO);
                db.AddInParameter(dbCommand, "@PISO", DbType.String, PISO);
                db.AddInParameter(dbCommand, "@UBICACION", DbType.String, UBICACION);
                db.AddInParameter(dbCommand, "@COD_LINEA", DbType.String, COD_LINEA);
                db.AddInParameter(dbCommand, "@DETALLE_STATUS", DbType.String, DETALLE_STATUS);
                db.AddInParameter(dbCommand, "@OBSERVACIONES", DbType.String, OBSERVACIONES);
                db.AddInParameter(dbCommand, "@TIPO_DE_EQUIPO_contable", DbType.String, TIPO_DE_EQUIPO_contable);
                db.AddInParameter(dbCommand, "@DESCRIPCIoN_contable", DbType.String, DESCRIPCIoN_contable);
                db.AddInParameter(dbCommand, "@CANTIDAD", DbType.String, CANTIDAD);
                db.AddInParameter(dbCommand, "@PRECIO_UND_MN", DbType.String, PRECIO_UND_MN);
                db.AddInParameter(dbCommand, "@PRECIO_UND_ME", DbType.String, PRECIO_UND_ME);
                db.AddInParameter(dbCommand, "@T_C", DbType.String, T_C);
                db.AddInParameter(dbCommand, "@IMPORTE__MN", DbType.String, IMPORTE__MN);
                db.AddInParameter(dbCommand, "@CentroCostos", DbType.String, CentroCostos);
                
                // Ejecuta el Comando
                
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerReporteActivo(string usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerReporteActivo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@usuario", DbType.String, usuario);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerUsuarioAsignados(string Usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerUsuarioAsignados";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable verCategoria()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "verCategoria";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Usuario", DbType.String, Usuario);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerDepreciacionPorCodigo(string Codigo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDepreciacionPorCodigo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerActivoCatalogo()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerActivoCatalogo";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerMovimiento()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerMovimiento";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable verGuiaMovimiento(string id)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "verGuiaMovimiento";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@id", DbType.String, id);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable GetActivoMov(string activo, string descripcion, string grupo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "GetActivoMov";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@activo", DbType.String, activo);
                db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);
                db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public string GetCorrelativoMov()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "GetCorrelativoMov";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                //db.AddInParameter(dbCommand, "@activo", DbType.String, activo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);
                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdMovimiento(string id, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdMovimiento";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@id", DbType.String, id);
                
                db.AddInParameter(dbCommand, "@fecha", DbType.String, p1);
                db.AddInParameter(dbCommand, "@Destinatario", DbType.String, p2);
                db.AddInParameter(dbCommand, "@PuntodePartida", DbType.String, p3);


                db.AddInParameter(dbCommand, "@Ruc", DbType.String, p4);
                db.AddInParameter(dbCommand, "@PuntodeLLegada", DbType.String, p5);
                db.AddInParameter(dbCommand, "@Ruc_transporte", DbType.String, p6);

                db.AddInParameter(dbCommand, "@nombre_transporte", DbType.String, p7);
                db.AddInParameter(dbCommand, "@marca_placa_transporte", DbType.String, p8);
                db.AddInParameter(dbCommand, "@licencia", DbType.String, p9);
                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsupdMovimientodetalle(string id, string p)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsupdMovimientodetalle";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@id", DbType.String, id);
                db.AddInParameter(dbCommand, "@codigo", DbType.String, p);
                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerDepreciacionTotal()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerDepreciacionTotal";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                //db.AddInParameter(dbCommand, "@activo", DbType.String, activo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);
                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerMantenimientoClass()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerMantenimiento";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                //db.AddInParameter(dbCommand, "@activo", DbType.String, activo);
                //db.AddInParameter(dbCommand, "@descripcion", DbType.String, descripcion);
                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int GenerarMantenimiento(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdMantenimiento";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, p1);
                db.AddInParameter(dbCommand, "@descripcion", DbType.String, p2);
                db.AddInParameter(dbCommand, "@descripcionservicio", DbType.String, p3);
                db.AddInParameter(dbCommand, "@estado", DbType.String, p4);
                db.AddInParameter(dbCommand, "@Nro", DbType.String, p5);
                db.AddInParameter(dbCommand, "@opcion", DbType.String, p6);


                if (p6 == "I")
                {
                    DataTable dt = TraeAlerta();
                    
                    foreach(DataRow row in dt.Rows)
                    { 
                    WebClient proxy = new WebClient();
                    string url = "https://api.callmebot.com/whatsapp.php?phone=" + row["Tlf"].ToString() + "&text=El+siguientes+activo+se+encuentra+en+espera+para+mantenimiento%0A+Activo+" + p1 + "+" + p2.Replace(" ","+") + "+&apikey=" + row["api"].ToString();
                    byte[] data = proxy.DownloadData(url);
                    }
                }
                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable VerMantenimientoClassPorNro(string Nro)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "VerMantenimientoClassPorNro";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Nro", DbType.String, Nro);
            

                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable TraeAlerta()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "TraeAlerta";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                //db.AddInParameter(dbCommand, "@Nro", DbType.String, Nro);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public int InsUpdAlerta(string p1, string p2, string p3)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "InsUpdAlerta";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand, "@Nro", DbType.String, p1);
                db.AddInParameter(dbCommand, "@Tlf", DbType.String, p2);
                db.AddInParameter(dbCommand, "@api", DbType.String, p3);

                //db.AddInParameter(dbCommand, "@grupo", DbType.String, grupo);

                // Ejecuta el Comando
                return db.ExecuteNonQuery(dbCommand);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public DataTable Ver_activo_Trazabilidad_Usuario(string Codigo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Retail");
                string sqlCommand = "Ver_activo_Trazabilidad_Usuario";
                System.Data.Common.DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
                db.AddInParameter(dbCommand, "@Codigo", DbType.String, Codigo);


                // Ejecuta el Comando
                return db.ExecuteDataSet(dbCommand).Tables[0];
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }
    }
}

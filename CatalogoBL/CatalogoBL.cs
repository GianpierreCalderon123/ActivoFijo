using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CatalogoDA;


namespace CatalogoBL
{
    public class CatalogoBL
    {
        private string _DataBaseName;

        public CatalogoBL(string DataBaseName)
        {
            _DataBaseName = DataBaseName;
        }

        public DataTable FunUsuarioNombreCompleto(string Nombre)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UsuarioNombreCompleto(Nombre);
        }



        public int FunUsuarioComprobar(string usuario, string contraseña)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.FunUsuarioComprobar(usuario, contraseña);
        }


        public System.Data.DataTable VerUsuarios()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerUsuarios().Tables[0];
        }

        public int InsUpdUsuariosFaber(string usuario, string clave, string usuarioregistro)
        {
            try
            {
                CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
                return objData.InsUpdUsuariosFaber(usuario, clave, usuarioregistro);
                //string claveSHA = GenerarClaveSHA1(Clave);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new ArgumentException("Descripcion : " + ex.Message);
            }
        }

        public System.Data.DataTable VerAccesos(string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerAccesos(usuario).Tables[0];
        }

        public int ActualizaAcceso(string usu, string cid, bool status)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.ActualizaAcceso(usu, cid, status);
        }

        public int ActualizaContra(string p, string a,string c)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.ActualizaAcceso(p, a,c);
        }

        public DataTable VerAlmacenAccesos(string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerAlmacenAccesos(usuario).Tables[0];
        }

        public DataTable VerClientes(string NombreB, string RucB,string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerClientes(NombreB, RucB, usuario).Tables[0];
        }

        public int insertcliente(string p1, string p2)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.insertcliente(p1, p2);
        }

        public DataTable VerCliente(string p)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCliente(p).Tables[0];
        }

        public DataTable VerClientePorDNI(string ruc_dni)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerClientePorDNI(ruc_dni).Tables[0];
        }

        public string UpdateCliente(string ruc_dni, string CE, string Correo, string DNI, string IngenieroResponsable,
            string Nombre, string RepresentanteLegal, string Telefono, string usuario ,
            string TieneContrato,string FechaRegistro,string NuevoRuc_Dni,string opcion)
        {

            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UpdateCliente(ruc_dni, CE, Correo, DNI, IngenieroResponsable,
            Nombre, RepresentanteLegal, Telefono,usuario,TieneContrato,FechaRegistro,NuevoRuc_Dni, opcion);
        }

        public DataTable VerDireccion(string ruc_dni)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDireccion(ruc_dni).Tables[0];
        }

        public DataTable VerDireccionPorDireccion(string ruc_dni, string direccion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDireccionPorDireccion(ruc_dni,direccion).Tables[0];
        }

        public int UpdInsDireccion(string ruc_dni, string direccion, string Urbanizacion, string Distrito, 
            string Provincia, string Departamento, string Codigo_Postal,string Sede, string NuevaDireccion,string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UpdInsDireccion(ruc_dni, direccion, Urbanizacion, Distrito,
            Provincia,Departamento, Codigo_Postal, Sede,NuevaDireccion, opcion );
     
        }

        public DataTable VerServicios()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerServicios().Tables[0];
        }

        public int InsUpdServicios(string Servicio, string Unidad, string Tarifa,string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdServicios(Servicio, Unidad, Tarifa, opcion);
     
        }

        public DataTable VerServiciosPorServicio(string Servicio)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerServiciosPorServicio(Servicio).Tables[0];
        }

        public DataTable VerResiduosPorResiduo(string Residuo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerResiduosPorResiduo(Residuo).Tables[0];
        }

        public int InsUpdResiduos(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdResiduos(Residuo, Unidad, Tarifa, opcion);
        }
        public int InsUpdResiduosCompra(string Residuo, string Unidad, string Tarifa, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdResiduosCompra(Residuo, Unidad, Tarifa, opcion);
        }

        public DataTable VerResiduos()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerResiduos().Tables[0];
        }
        public DataTable VerResiduosCompra()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerResiduosCompra().Tables[0];
        }

        public DataTable VerGuia_Pesaje(string guia,string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuia_Pesaje(guia,usuario, Nombre,FechaDesde,FechaHasta).Tables[0];
        }

        public DataSet VerGuia_PesajePorGuia(string GuiaNumero)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuia_PesajePorGuia(GuiaNumero);
        }

        public string UpdInsVerGuia_Pesaje(string GuiaNumero, string BoletaRelleno, string Ruc_Cliente, string FechaRecojo, 
            string Fecha2, string DireccionRecojo, string UsadoParaManifiesto, string UsadoParaControl, string NroManifiesto,
            string NroControl, string UltimoUsuario, string UltimaFechaModif,string DestinoFinal,
            string TipoResiduo, string Placa, string GuiaTransportista, string opcion, string TipoOperacion, string OtrosDestinos)
        {
          CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
          return objData.UpdInsVerGuia_Pesaje(GuiaNumero, BoletaRelleno, Ruc_Cliente, FechaRecojo,
           Fecha2, DireccionRecojo, UsadoParaManifiesto, UsadoParaControl, NroManifiesto,
           NroControl, UltimoUsuario, UltimaFechaModif, DestinoFinal, TipoResiduo, Placa, GuiaTransportista, opcion, TipoOperacion, OtrosDestinos);
        }

        public int UpdInsGuia_Pesaje_Detalle(string GuiaNumero, string Residuos,
            string Servicio, string TipoResiduos, string Unidad, string Cantidad,string Cantidad1, string Boleta,
            string UnidadDeposito, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UpdInsGuia_Pesaje_Detalle(GuiaNumero, Residuos, Servicio, TipoResiduos,
             Unidad, Cantidad,Cantidad1, Boleta,UnidadDeposito, opcion);
        }

        public DataTable VerHojaControl(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControl(usuario, Nombre, FechaDesde, FechaHasta);
        }

        public DataTable VerHojaControlPorHojaControl(string HojaControl)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControlPorHojaControl(HojaControl);
        }

        public int InsUpdDelHojaControl(string HojaControl, string Correlativo, string Ruc_Cliente, string FechaRecojo, string Fecha2, string DireccionRecojo, string UsadoParaLiquidacion, string NroLiquidacion, string UsadoParaCertificado, string NroCertificado, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdDelHojaControl(HojaControl,
Correlativo, Ruc_Cliente, FechaRecojo, Fecha2, DireccionRecojo, UsadoParaLiquidacion, NroLiquidacion, UsadoParaCertificado,
NroCertificado, opcion);
        }

        public DataTable VerMaestroPrecios(string Usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerMaestroPrecios(Usuario);
        }

      
        public int UPdateMaestroPrecios(string Servicio, string Ruc_Dni, string UnidadMedida, string Tarifa, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UPdateMaestroPrecios(Servicio, Ruc_Dni, UnidadMedida, Tarifa, opcion);
        }

        public DataTable VerHojaControlDetalle(string CorrelativoHojaControl)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControlDetalle(CorrelativoHojaControl);
        }

        public int InsUpdHojaControlDetalle(string CorrelativoHojaControl, string GuiaNumero, string Residuos,
            string LineaDeNegocio, string Unidad, string Cantidad, string UnidadparaCostear,
          
            string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdHojaControlDetalle(CorrelativoHojaControl,
GuiaNumero	,Residuos	,LineaDeNegocio	,Unidad	,Cantidad	,UnidadparaCostear	,
opcion	);
        }

        public string InsUpdManifiesto(string Correlativo, string Ruc_Cliente, string FechaRecojo, 
            string Fecha2, string DireccionRecojo, string Transportista, 
            string RellenoSanitario, string Servicio,string EstadoResiduo,string Peligrosidad,string Fin,string Residuo,
            string IngenieroResponsable, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdManifiesto(Correlativo, Ruc_Cliente,
FechaRecojo, Fecha2,
DireccionRecojo, Transportista,
RellenoSanitario, Servicio, EstadoResiduo, Peligrosidad, Fin,Residuo,IngenieroResponsable, opcion);
        }






        public DataTable VerManifiesto(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerManifiesto(usuario, Nombre, FechaDesde, FechaHasta);
        }

        public DataTable VerLiquidacion(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacion(usuario,  Nombre, FechaDesde, FechaHasta);
        }

        public DataTable VerCertificado(string usuario, string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCertificado(usuario, Nombre, FechaDesde, FechaHasta);
        }

        public DataTable VerLiquidacionPorLiquidacionNro(string LiquidacionNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionPorLiquidacionNro(LiquidacionNro);
        }

        public DataTable VerCertificadoPorCertificadoNro(string CertificadoNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCertificadoPorCertificadoNro(CertificadoNro);
        }

        public DataTable VerLiquidacionDetallePorLiquidacionNro(string LiquidacionNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionDetallePorLiquidacionNro(LiquidacionNro);
        }

        public DataTable VerCertificadoDetallePorCertificadoNro(string CertificadoNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCertificadoDetallePorCertificadoNro(CertificadoNro);
        }

        public int InsUpdLiquidacion(string LiquidacionNro, string Ruc_Cliente, string FechaRecojo, string Fecha2, string DireccionRecojo, string CorrelativoHojaControl, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdLiquidacion(LiquidacionNro, Ruc_Cliente, FechaRecojo,
Fecha2, DireccionRecojo, CorrelativoHojaControl, opcion);
        }

        public int InsUpdCertificado(string CertificadoNro, string Ruc_Cliente, string FechaRecojo, string Fecha2, string DireccionRecojo, string CorrelativoHojaControl, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdCertificado(CertificadoNro, Ruc_Cliente, FechaRecojo,
Fecha2, DireccionRecojo, CorrelativoHojaControl, opcion);
        }

        public int InsUpdLiquidacionDetalle(string LiquidacionNro, string GuiaNumero, string Residuos, 
            string Servicio, string Unidad, string Cantidad, string UnidadparaCostear,string tarifa,string total, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdLiquidacionDetalle(LiquidacionNro, GuiaNumero, Residuos, Servicio, Unidad,
Cantidad, UnidadparaCostear,tarifa,total ,opcion);
        }

        public int InsUpdCertificadDetalle(string CertificadoNro, string GuiaNumero, string Residuos, string Servicio, string Unidad, string Cantidad, string UnidadparaCostear, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdCertificadDetalle(CertificadoNro, GuiaNumero, Residuos, Servicio, Unidad,
Cantidad, UnidadparaCostear, opcion);
        }

        public DataTable VerDestinoFinal()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDestinoFinal();
        }

        public DataTable VerTransportistas()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerTransportistas();
        }

        public DataTable VerDestinoFinalPorNombre(string Nombre)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDestinoFinalPorNombre(Nombre);
        }

        public DataTable VerTransportistasPorNombre(string Nombre)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerTransportistasPorNombre(Nombre);
        }

        public int InsUpdTransportistas(string Nombre, string Ruc_Dni, string RegistroFechaVencimiento, string AutorizacionSanitaria, string AutorizacionMunicial, string Direccion, string Distrito, string Provincia, string Departamento, string Telefono, string Email, string RepresentanteLegal, string DNI, string Ing, string Cip, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdTransportistas(Nombre, Ruc_Dni, RegistroFechaVencimiento, AutorizacionSanitaria,
AutorizacionMunicial, Direccion, Distrito, Provincia, Departamento, Telefono, Email, RepresentanteLegal,
DNI, Ing, Cip,
opcion);
        }

        public int InsUpdDestinoFinal(string Nombre, string Ruc_Dni, string RegistroFechaVencimiento,
            string AutorizacionSanitaria, string AutorizacionMunicial, string Direccion, string Distrito, string Provincia,
            string Departamento, string Telefono, string Email, string RepresentanteLegal, string DNI, 
            string Ing, string Cip,string Alias, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdDestinoFinal(Nombre, Ruc_Dni, RegistroFechaVencimiento, AutorizacionSanitaria,
AutorizacionMunicial, Direccion, Distrito, Provincia, Departamento, Telefono, Email, RepresentanteLegal,
DNI, Ing, Cip,Alias,
opcion);
        }

        public DataTable VerHojasDisponibles(string Ruc_Cliente)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojasDisponibles(Ruc_Cliente);
        }

        public DataTable UltimoCorrelativoHojas()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UltimoCorrelativoHojas();
        }

        public DataTable VerHojaControlReporte(string HojaControl)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControlReporte(HojaControl);
        }

        public DataTable VerLiquidacionesDisponibles(string Ruc_Cliente)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionesDisponibles(Ruc_Cliente);
        }

        public DataTable VerHojaControlDetalleDisponible(string HojaControl)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControlDetalleDisponible(HojaControl);
        }

        public DataTable UltimoCorrelativoLiquidacion()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UltimoCorrelativoLiquidacion();
        }

        public DataTable verReporteLiquidacion(string LiquidacionNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.verReporteLiquidacion(LiquidacionNro);
        }

        public DataTable VerCertificadosDisponibles(string Ruc_Cliente)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCertificadosDisponibles(Ruc_Cliente);
        }

        public DataTable VerHojaControlDetalleDisponibleCertificado(string HojaControl)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerHojaControlDetalleDisponibleCertificado(HojaControl);
        }

        public DataTable UltimoCorrelativoCertificado()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UltimoCorrelativoCertificado();
        }

        public DataTable verReportecertificado(string CertificadoNro, string residuo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.verReportecertificado(CertificadoNro, residuo);
        }

        public DataTable VerProveedor(string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerProveedor(usuario);
        }
        public DataTable VerProveedorFiltro(string usuario,string proveedor)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerProveedorFiltro(usuario, proveedor);
        }

        public DataSet VerProveedorPorRuc_Cliente(string Ruc_Dni)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerProveedorPorRuc_Cliente(Ruc_Dni);
        }

        public string InsUpdProveedor(string Ruc_Dni, string Nombre, string DireccionLegal, string Tipo,string Usuario,
            string PersonaContacto,string NuevoRuc_Dni, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdProveedor(Ruc_Dni, Nombre, DireccionLegal, Tipo, Usuario, PersonaContacto, NuevoRuc_Dni,opcion);
        }

        public int InsUpdDireccionProveedor(string Ruc_Dni, string Direccion, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdDireccionProveedor(Ruc_Dni, Direccion, opcion);
        }

        public DataSet VerGuiaProveedorPorNroGuia(string NroGuia)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuiaProveedorPorNroGuia(NroGuia);
        }

        public string InsUpdGuiasProveedor(string NroGuia, string Ruc_Dni, string Direccion, string PersonaContacto,
            string Fecha,string RellenoSanitario,string GuiaProveedor,string PlacaVehicular, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdGuiasProveedor(NroGuia, Ruc_Dni, Direccion, PersonaContacto, Fecha,
                RellenoSanitario,GuiaProveedor,PlacaVehicular, opcion);
        }

        public int InsUpdGuiasProveedorDetalle(string NroGuia, string Descripcion, string Unidad, string Cantidad, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdGuiasProveedorDetalle(NroGuia, Descripcion, Unidad, Cantidad, opcion);
        }

        public DataTable VerLiquidacionProveedor(string Nombre, string FechaDesde, string FechaHasta,string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionProveedor(Nombre, FechaDesde, FechaHasta,usuario);
        }

        public DataSet VerLiquidacionProveedorPorNroLiquidacion(string NroLiquidacion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionProveedorPorNroLiquidacion(NroLiquidacion);
        }

        public int InsUpdLiquidacionProveedor(string NroLiquidacion, string Ruc_Dni, string Direccion, 
            string PersonaContacto, string Fecha,string Factura, string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdLiquidacionProveedor(NroLiquidacion, Ruc_Dni,
                    Direccion, PersonaContacto, Fecha, Factura,opcion);
        }

        public int InsUpdLiquidacionProveedorDetalle(string NroLiquidacion ,
string Descripcion, string Unidad, string Cantidad, string PrecioUnitario, string Total, string NroGuia,
            string Factura,string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdLiquidacionProveedorDetalle(NroLiquidacion ,
Descripcion ,Unidad ,Cantidad ,PrecioUnitario ,Total ,NroGuia ,Factura, opcion);
        }

        public DataTable VerGuiasProveedor(string guia,string Nombre, string FechaDesde, string FechaHasta)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuiasProveedor(guia,Nombre, FechaDesde, FechaHasta);
        }


        public DataTable VerGuiasDisponiblesParaLiquidacion(string Ruc_Cliente)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuiasDisponiblesParaLiquidacion(Ruc_Cliente);
        }

        public string UltimoCorrelativoLiquidacionProveedor()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UltimoCorrelativoLiquidacionProveedor();
        }

        public DataTable VerLiquidacionProveedorReporte(string NroLiquidacion, string residuo)
        {

            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionProveedorReporte(NroLiquidacion, residuo);
        }

        public DataTable VerReporteManifiesto(string Correlativo,string Residuo)
        {

            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerReporteManifiesto(Correlativo,Residuo);
        }

        public DataTable VerDireccionProveedorPorRuc_Dni(string Ruc_Dni)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDireccionProveedorPorRuc_Dni(Ruc_Dni);
        }

        public DataTable VerMaestroPreciosProveedor(string Usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerMaestroPreciosProveedor(Usuario);
        }

        public int UPdateMaestroPreciosProveedor(string Servicio, string Ruc_Dni, 
            string UnidadMedida, string Tarifa, string Moneda,string opcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UPdateMaestroPreciosProveedor(Servicio, Ruc_Dni, UnidadMedida, Tarifa,Moneda, opcion);
        }


        public string TraeTarifaProveedor(string Servicio, string Ruc_Dni, string UnidadMedida)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.TraeTarifaProveedor(Servicio, Ruc_Dni, UnidadMedida);
        }

        public string GetUltimocorrelativo()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.GetUltimocorrelativo();
        }

        public string InsUpdManifiestoDetalle(string Correlativo, string p1, string p2, string p3, string p4)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdManifiestoDetalle(Correlativo,p1,p2,p3,p4);
        }

        public DataTable VerManifiestoDetalle(string Correlativo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerManifiestoDetalle(Correlativo);
        }

        public DataTable VerCertificadoDetalle(string CertificadoNro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerCertificadoDetalle(CertificadoNro);
        }

        public DataTable VerLiquidacionProveedorDetalle(string NroLiquidacion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerLiquidacionProveedorDetalle(NroLiquidacion);
        }

        public DataTable VerClientePorUsuario(string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerClientePorUsuario(usuario);
        }

        public DataTable UpdateUsuarioClienteMasivo(string ruc, string Usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UpdateUsuarioClienteMasivo(ruc, Usuario);
        }

        public DataTable VerGuiasDeServicio()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuiasDeServicio();
        }

        public DataTable VerGuiasDeCompra()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerGuiasDeCompra();
        }

        public DataTable VerActivo(string Codigo, string descripcion)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerActivo(Codigo,descripcion);
        }

        public DataTable VerActivoPorCodigo(string Codigo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerActivoPorCodigo(Codigo);
        }

        public string UpdateActivo(string Codigo,string Fecha_de_adquision,string nro_Factura, string proveedor,
            string descripcion, string marca, string modelo, string serie, string largo, string ancho, string altura, string color,
            string estado, string precio, string igv, string total, string usuario,string local,string ambiente,
            string Cod_familia, string anio_fabricacion, string fecha_de_inv,
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
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.UpdateActivo(Codigo, Fecha_de_adquision,nro_Factura,
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
        }

        public DataTable VerReporteActivo(string usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerReporteActivo(usuario);
        }

        public DataTable VerUsuarioAsignados(string Usuario)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerUsuarioAsignados(Usuario);
        }

        public DataTable verCategoria()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.verCategoria();
        }

        public DataTable VerDepreciacionPorCodigo(string Codigo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDepreciacionPorCodigo(Codigo);
        
        }

        public DataTable VerActivoCatalogo()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerActivoCatalogo();
        }

        public DataTable VerMovimiento()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerMovimiento();
        }

        public DataTable verGuiaMovimiento(string id)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.verGuiaMovimiento(id);
        }

        public DataTable GetActivoMov(string activo, string descripcion, string grupo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.GetActivoMov(activo,descripcion,grupo);
        }

        public string GetCorrelativoMov()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.GetCorrelativoMov();
        }

        public int InsUpdMovimiento(string id, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdMovimiento(id,p1,p2,p3,p4,p5,p6,p7,p8,p9);
        }

        public int InsupdMovimientodetalle(string id, string p)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsupdMovimientodetalle(id, p);
        }

        public DataTable VerDepreciacionTotal()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerDepreciacionTotal();
        }

        public DataTable VerMantenimientoClass()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerMantenimientoClass();
        }

        public int GenerarMantenimiento(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.GenerarMantenimiento(p1,p2,p3,p4,p5,p6);
        }

        public DataTable VerMantenimientoClassPorNro(string Nro)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.VerMantenimientoClassPorNro(Nro);
        }

        public DataTable TraeAlerta()
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.TraeAlerta();
        }

        public int InsUpdAlerta(string p1, string p2, string p3)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.InsUpdAlerta(p1,p2,p3);
        }

        public DataTable Ver_activo_Trazabilidad_Usuario(string Codigo)
        {
            CatalogoDA.CatalogoDA objData = new CatalogoDA.CatalogoDA(_DataBaseName);
            return objData.Ver_activo_Trazabilidad_Usuario(Codigo);
        }
    }
}

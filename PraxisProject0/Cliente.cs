using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraxisProject0
{

    public class CategoriaActivo
    {
        public string categoria { get; set; }
        public string descripcionlocal { get; set; }

    }
    public class Cliente
    {
        public string Ruc_Dni {get;set;}
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string RepresentanteLegal { get; set; }
        public string CE { get; set; }
        public string IngenieroResponsable { get; set; }
        public string DNI { get; set; }
        public string usuario { get; set; }
        public string TieneContrato { get; set; }
        public string FechaRegistro { get; set; }
   }


    public class DepreciacionClass
    {
        public string Nro { get; set; }
        public string Periodo { get; set; }
        public string Depreciacion { get; set; }
        public string Saldo { get; set; }
    }

    public class MovimientoClass
    {
        public string id { get; set; }
        public string fecha { get; set; }
        public string Destinatario { get; set; }
        public string PuntodePartida { get; set; }
        public string Ruc { get; set; }
        public string PuntodeLlegada { get; set; }
        public string Ruc_transporte { get; set; }
        public string nombre_transporte { get; set; }
        public string marca_placa_transporte   { get; set; }
        public string licencia { get; set; }
        public List<MovimientoDetalle> Detalle { get; set; }
    
    }
    public class MovimientoDetalle
    {
        public string id { get; set; }
        public string codigo { get; set; }
    }

    public class AlertaClass
    {
        public string Nro { get; set; }
        public string Tlf { get; set; }
        public string api { get; set; }
    }
    public class TrazaUsuario
    {
        public string Codigo { get; set; }
        public string usuarioantiguo { get; set; }
        public string usuarionuevo { get; set; }
        public string fecha { get; set; }
    }
    			

    public class MantenimientoClass
    {
        public string Nro { get; set; }
        public string Codigo { get; set; }
        public string descripcion { get; set; }
        public string descripcionservicio  { get; set; }
        public string Estado    { get; set; }
        public string opcion { get; set; }


        }
    public class Activo
    {
        public string UsuarioAnterior { get; set; }
        public string nrovoucher { get; set; }
        public string Dimensiones { get; set; }
        public string PESO { get; set; }
        public string CONSUMO_ENERGIA { get; set; }
        public string TIPO_EQUIPO_CATEGORIA { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string TIPO_DE_ACTIVO { get; set; }
        public string TIPO_MATERIAL { get; set; }
        public string CATEGORIA { get; set; }
        public string EDIFICIO { get; set; }
        public string PISO { get; set; }
        public string UBICACION { get; set; }
        public string COD_LINEA { get; set; }
        public string DETALLE_STATUS { get; set; }
        public string OBSERVACIONES { get; set; }
        public string TIPO_DE_EQUIPO_contable { get; set; }
        public string DESCRIPCIoN_contable { get; set; }
        public string CANTIDAD { get; set; }
        public string PRECIO_UND_MN { get; set; }
        public string PRECIO_UND_ME { get; set; }
        public string T_C { get; set; }
        public string IMPORTE__MN { get; set; }

        public string tasadepreciacion { get; set; }
        public string imagen { get; set; }
        public string categoriasunat { get; set; }

            public string local { get; set; }
        public string ambiente { get; set; }

        public string Codigo { get; set; }
        public string Fecha_de_adquision { get; set; }
        public string nro_Factura { get; set; }
        public string proveedor { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public string largo { get; set; }
        public string ancho { get; set; }
        public string altura { get; set; }
        public string color { get; set; }
        public string estado { get; set; }
        public string precio { get; set; }
        public string igv { get; set; }
        public string total { get; set; }
        public string usuario { get; set; }
        public string dni { get; set; }
        public string fechaasignacion { get; set; }

        public string Cod_familia { get; set; }
        public string anio_fabricacion { get; set; }
        public string fecha_de_inv { get; set; }
        public string CentroCostos { get; set; }
        
    }

    public class Proveedor
    {
        public string Ruc_Dni { get; set; }
        public string Nombre { get; set; }
        public string DireccionLegal { get; set; }
        public string UltimaFechaModif { get; set; }
        public string Tipo { get; set; }

        public string usuariop { get; set; }

        public string PersonaContacto { get; set; }
        public string NuevoRuc_Dni { get; set; }
        
        public List<DireccionProveedor> Direcciones { get; set; }
    
    }

    public class DireccionProveedor
    {
        public string Ruc_Dni { get; set; }
        public string Direccion { get; set; }
    }

    public class MaestroPreciosClientes
    {
        public string Servicio { get; set; }
        public string Ruc_Dni { get; set; }
        public string UnidadMedida { get; set; }
        public string Tarifa { get; set; }
        public string Moneda { get; set; }

        
    }

    public class GuiasProveedor
    {
        public string NroGuia { get; set; }
        public string Ruc_Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string PersonaContacto { get; set; }
        public string Fecha { get; set; }
        public string RellenoSanitario { get; set; }
        public string GuiaProveedor { get; set; }

        public string FechaRegistro { get; set; }

        public string PlacaVehicular { get; set; }
        
        

        public List<GuiasProveedorDetalle> Detalle { get; set; }

    }

    public class GuiasProveedorDetalle
    {
        public string NroGuia { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string FechaRecojo { get; set; }
        public string FechaRegistro { get; set; }
        public string GuiaProveedor { get; set; }
    }

    public class LiquidacionProveedor
    {
        public string NroLiquidacion { get; set; }
        public string Ruc_Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string PersonaContacto { get; set; }
        public string Fecha { get; set; }
        public string Tipo { get; set; }

        public string Factura { get; set; }

        
        public List<LiquidacionProveedorDetalle> Detalle { get; set; }
    }

    public class LiquidacionProveedorDetalle
    {
        public string NroLiquidacion { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string PrecioUnitario { get; set; }
        public string Total { get; set; }
        public string NroGuia { get; set; }
        public string Factura { get; set; }
    }



    public class Direccionx
       {
        public string Ruc_Dni {get;set;}
        public string Direccion { get; set; }
        public string Urbanizacion { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Codigo_Postal { get; set; }
        public string Sede { get; set; }
    
    }

    public class Serviciosx
    {
        public string Servicio { get; set; }
        public string Unidad { get; set; }
        public string Tarifa { get; set; }

    }


    public class Residuosx
    {
        public string Residuo { get; set; }
        public string Unidad { get; set; }
        public string Tarifa { get; set; }

    }

    public class Guia_Pesaje
    {
        public string GuiaNumero { get; set; }
        public string BoletaRelleno { get; set; }
        public string Ruc_Cliente { get; set; }

        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }

        public string UsadoParaManifiesto { get; set; }

        public string UsadoParaControl { get; set; }
        public string NroManifiesto { get; set; }
        public string NroControl { get; set; }

        public string UltimoUsuario { get; set; }
        public string UltimaFechaModif { get; set; }
        public string DestinoFinal { get; set; }
        public string TipoResiduo { get; set; }
        public string Placa { get; set; }
        public string GuiaTransportista { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string OtrosDestinos { get; set; }
        
        public List<Guia_Pesaje_Detalle> Detalle { get; set; }

    }
    public class Guia_PesajeTotal
    {
        public Guia_Pesaje Guia_PesajeCabecera { get; set; }
        public List<Guia_Pesaje_Detalle> Detalle { get; set; }
    }


    public class ReporteLiquidacionClass
    {
        public string Id { get; set; }
        public string LiquidacionNro { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string CorrelativoHojaControl { get; set; }
        public string LiquidacionNro1 { get; set; }
        public string GuiaNumero { get; set; }
        public string Residuos { get; set; }
        public string Servicio { get; set; }
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string UnidadparaCostear { get; set; }
        public string Tarifa { get; set; }
        public string Total { get; set; }
        public string Nombre { get; set; }
        public string FR { get; set; }
        public string DR { get; set; }
        public string DF { get; set; }
        public string Sede { get; set; }

    
    }


    public class Guia_Pesaje_Detalle
    {
        public string GuiaNumero { get; set; }
        public string Residuos { get; set; }
        public string Servicio { get; set; }

        public string TipoResiduos { get; set; }
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string Cantidad1 { get; set; }
        public string Boleta { get; set; }
        public string UnidadDeposito { get; set; }

    }

    public class Transportistas
    {
        public string Nombre { get; set; }
        public string Ruc_Dni { get; set; }
        public string RegistroFechaVencimiento { get; set; }

        public string AutorizacionSanitaria { get; set; }
        public string AutorizacionMunicial { get; set; }
        public string Direccion { get; set; }

        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }

        
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RepresentanteLegal { get; set; }
         
        public string DNI { get; set; }
        public string Ing { get; set; }
        public string Cip { get; set; }


    }

    public class DestinoFinal
    {
        public string Nombre { get; set; }
        public string Ruc_Dni { get; set; }
        public string RegistroFechaVencimiento { get; set; }

        public string AutorizacionSanitaria { get; set; }
        public string AutorizacionMunicial { get; set; }
        public string Direccion { get; set; }

        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }


        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RepresentanteLegal { get; set; }

        public string DNI { get; set; }
        public string Ing { get; set; }
        public string Cip { get; set; }

        public string Alias { get; set; }


    }



    public class HojaControlClass
    {
        public string HojaControl { get; set; }
        public string Correlativo { get; set; }
        public string Nombre { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string UsadoParaLiquidacion { get; set; }
        public string NroLiquidacion { get; set; }
        public string UsadoParaCertificado { get; set; }
        public string NroCertificado { get; set; }


    }

    public class HojaControlClasse
    {
        public string HojaControl { get; set; }
        public string Correlativo { get; set; }
        public string Nombre { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string UsadoParaLiquidacion { get; set; }
        public string NroLiquidacion { get; set; }
        public string UsadoParaCertificado { get; set; }
        public string NroCertificado { get; set; }
        public List<HojaControlDetalle> Detalle { get; set; }


    }


    
    public class MaestroPrecios
    {
        public string Nombre { get; set; }
        public string Servicio { get; set; }
        public string Ruc_Dni { get; set; }
        public string UnidadMedida { get; set; }
        public string Tarifa { get; set; }

        public string Moneda { get; set; }

    }

    public class HojaControlDetalle
    {
        public string CorrelativoHojaControl { get; set; }
        public string GuiaNumero { get; set; }
        public string Residuos { get; set; }
        public string LineaDeNegocio { get; set; }
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string UnidadparaCostear { get; set; }
        public string Tarifa { get; set; }
        public string Total { get; set; }
        public string TipoResiduo { get; set; }
        public string Fecha { get; set; }

    }
    public class AccesoClass
    {
        public string Opcion { get; set; }
        public string Acceso { get; set; }
    }
    public class UsuarioClass
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Privilegio { get; set; }
        public List<AccesoClass> Acceso { get; set; }
    }

    public class Manifiesto
    {
        public string Correlativo { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string Transportista { get; set; }
        public string RellenoSanitario { get; set; }
        public string Servicio { get; set; }
        public string Nombre { get; set; }
    }
    public class DetalleManifiesto
    {
        public string Residuo { get; set; }
        public string EstadoResiduo { get; set; }
        public string Peligrosidad { get; set; }
    }
    
    
     public class Liquidacion
    {
         public string Nombre { get; set; }
        public string LiquidacionNro { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string CorrelativoHojaControl { get; set; }
        public List<LiquidacionDetalle> Detalle { get; set; }
        public string FechaRegistro { get; set; }   
    }

    public class LiquidacionClass
    {
        public string Nombre { get; set; }
        public string LiquidacionNro { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string CorrelativoHojaControl { get; set; }
        public List<LiquidacionDetalle> Detalle { get; set; }
    }
    public class CertificadoClass
    {
        public string Nombre { get; set; }
        public string CertificadoNro { get; set; }
        public string Ruc_Cliente { get; set; }
        public string FechaRecojo { get; set; }
        public string Fecha2 { get; set; }
        public string DireccionRecojo { get; set; }
        public string CorrelativoHojaControl { get; set; }
        public List<CertificadoDetalle> Detalle { get; set; }
    }

     public class Certificado
     {
         public string CertificadoNro { get; set; }
         public string Ruc_Cliente { get; set; }
         public string FechaRecojo { get; set; }
         public string Fecha2 { get; set; }
         public string DireccionRecojo { get; set; }
         public string CorrelativoHojaControl { get; set; }
         public string Nombre { get; set; }
         public string FechaRegistro { get; set; }
     }


     public class LiquidacionDetalle
     {
         public string LiquidacionNro { get; set; }
         public string GuiaNumero { get; set; }
         public string Residuos { get; set; }
         public string Servicio { get; set; }
         public string Unidad { get; set; }
         public string Cantidad { get; set; }
         public string UnidadparaCostear { get; set; }
         public string Tarifa { get; set; }
         public string Total { get; set; }


     }


     public class CertificadoDetalle
     {
         public string CertificadoNro { get; set; }
         public string GuiaNumero { get; set; }
         public string Residuos { get; set; }
         public string Servicio { get; set; }
         public string Unidad { get; set; }
         public string Cantidad { get; set; }
         public string UnidadparaCostear { get; set; }


     }



}
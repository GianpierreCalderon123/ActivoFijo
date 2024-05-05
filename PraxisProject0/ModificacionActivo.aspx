<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificacionActivo.aspx.cs" Inherits="PraxisProject0.ModificacionCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activos</title>
     <style>
 

.open-button {
  background-color: #555;
  color: white;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  opacity: 0.8;
  position: fixed;
  bottom: 23px;
  right: 28px;
  width: 280px;
}

/* The popup form - hidden by default */
.form-popup {
  display: none;
  position: fixed;
  top: 20px;
  left: 150px;
  border: 3px solid #f1f1f1;
  z-index: 9;
  background-color:black;
}

/* Add styles to the form container */
.form-container {
  max-width: 1000px;
  padding: 10px;
  background-color: white;
}

/* Full-width input fields */
.form-container input[type=text], .form-container input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
}

/* When the inputs get focus, do something */
.form-container input[type=text]:focus, .form-container input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

  .ten {
  width: 10%;
  background: #e1fff4;
}
   .ten1 {
  width: 5%;
  background: #2BC2AC;
  font-size:4px;
}

/* Set a style for the submit/login button */
.form-container .btn {
  background-color: #04AA6D;
  color: white;
  padding: 16px 20px;
  border: none;
  cursor: pointer;
  width: 100%;
  margin-bottom:10px;
  opacity: 0.8;
}

/* Add a red background color to the cancel button */
.form-container .cancel {
  background-color: red;
}

/* Add some hover effects to buttons */
.form-container .btn:hover, .open-button:hover {
  opacity: 1;
}
</style>


     <meta name="viewport" content="width=device-width, initial-scale=1"/> 

     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
   
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script> 

            <script>


            console.log("2w")
            //first add an event listener for page load
            document.addEventListener("DOMContentLoaded", get_json_data, false); // get_json_data is the function name that will fire on page load


            //console.log("2e")
            //this function is in the event listener and will execute on page load
            function get_json_data() {
                var json_url = "Paginas.asmx"

                //console.log(json_url)
                //Build the XMLHttpRequest (aka AJAX Request)

                var codigo = document.getElementById("HiddenField1").value;
                //console.log(ruc_dni);

                var myData = { "Codigo": codigo };
                var encoded = JSON.stringify(myData);
                //console.log(myData);
                console.log(encoded);

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerActivoPorCodigo",
                    data: encoded,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');

                        //alert("worked" + msg.d);
                        console.log(msg.d);
                        append_json(msg.d);
                        //$("#sidebar").append(msg);
                    },
                    error: function (msg) {
                        console.log('er');

                        //alert(msg.d);
                        //$("#sidebar").append(msg);
                    }
                });

            }

            //this function appends the json data to the table 'gable'
            function append_json(data) {

                var Fecha_de_adquision = document.getElementById("Fecha_de_adquision");
                Fecha_de_adquision.value = data.Fecha_de_adquision;

                var nro_Factura = document.getElementById("nro_Factura");
                nro_Factura.value = data.nro_Factura;

                var proveedor = document.getElementById("proveedor");
                proveedor.value = data.proveedor;

                var descripcion = document.getElementById("descripcion");
                descripcion.value = data.descripcion;

                var marca = document.getElementById("marca");
                marca.value = data.marca;

                var modelo = document.getElementById("modelo");
                modelo.value = data.modelo;

                var serie = document.getElementById("serie");
                serie.value = data.serie;

                var largo = document.getElementById("largo");
                largo.value = data.largo;

                var ancho = document.getElementById("ancho");
                ancho.value = data.ancho;


                var altura = document.getElementById("altura");
                altura.value = data.altura;


                var color = document.getElementById("color");
                color.value = data.color;
                var estado = document.getElementById("estado");
                estado.value = data.estado;
                var precio = document.getElementById("precio");
                precio.value = data.precio;
                var igv = document.getElementById("igv");
                igv.value = data.igv;
                var total = document.getElementById("total");
                total.value = data.total;
                
                var usuario = document.getElementById("usuario");
                usuario.value = data.usuario;

                var local = document.getElementById("local");
                local.value = data.local;

                var ambiente = document.getElementById("ambiente");
                ambiente.value = data.ambiente;


                var Cod_familia = document.getElementById("Cod_familia");
                Cod_familia.value = data.Cod_familia;

                var anio_fabricacion = document.getElementById("anio_fabricacion");
                anio_fabricacion.value = data.anio_fabricacion;

                var fecha_de_inv = document.getElementById("fecha_de_inv");
                fecha_de_inv.value = data.fecha_de_inv;

                var categoriasunat = document.getElementById("categoriasunat");
                categoriasunat.value = data.categoriasunat;

                var imagen = document.getElementById("blah");
                imagen.src = data.imagen;

                var tasadepreciacion = document.getElementById("tasadepreciacion");
                tasadepreciacion.value = data.tasadepreciacion;


                var UsuarioAnterior = document.getElementById("UsuarioAnterior"); UsuarioAnterior.value = data.UsuarioAnterior
                var nrovoucher = document.getElementById("nrovoucher"); nrovoucher.value = data.nrovoucher
                var Dimensiones = document.getElementById("Dimensiones"); Dimensiones.value = data.Dimensiones
                var PESO = document.getElementById("PESO"); PESO.value = data.PESO
                var CONSUMO_ENERGIA = document.getElementById("CONSUMO_ENERGIA"); CONSUMO_ENERGIA.value = data.CONSUMO_ENERGIA
                var TIPO_EQUIPO_CATEGORIA = document.getElementById("TIPO_EQUIPO_CATEGORIA"); TIPO_EQUIPO_CATEGORIA.value = data.TIPO_EQUIPO_CATEGORIA
                var Ruc_Proveedor = document.getElementById("Ruc_Proveedor"); Ruc_Proveedor.value = data.Ruc_Proveedor
                var TIPO_DE_ACTIVO = document.getElementById("TIPO_DE_ACTIVO"); TIPO_DE_ACTIVO.value = data.TIPO_DE_ACTIVO
                var TIPO_MATERIAL = document.getElementById("TIPO_MATERIAL"); TIPO_MATERIAL.value = data.TIPO_MATERIAL
                var CATEGORIA = document.getElementById("CATEGORIA"); CATEGORIA.value = data.CATEGORIA
                var EDIFICIO = document.getElementById("EDIFICIO"); EDIFICIO.value = data.EDIFICIO
                var PISO = document.getElementById("PISO"); PISO.value = data.PISO
                var UBICACION = document.getElementById("UBICACION"); UBICACION.value = data.UBICACION
                var COD_LINEA = document.getElementById("COD_LINEA"); COD_LINEA.value = data.COD_LINEA
                var DETALLE_STATUS = document.getElementById("DETALLE_STATUS"); DETALLE_STATUS.value = data.DETALLE_STATUS
                var OBSERVACIONES = document.getElementById("OBSERVACIONES"); OBSERVACIONES.value = data.OBSERVACIONES
                var TIPO_DE_EQUIPO_contable = document.getElementById("TIPO_DE_EQUIPO_contable"); TIPO_DE_EQUIPO_contable.value = data.TIPO_DE_EQUIPO_contable
                var DESCRIPCIoN_contable = document.getElementById("DESCRIPCIoN_contable"); DESCRIPCIoN_contable.value = data.DESCRIPCIoN_contable
                var CANTIDAD = document.getElementById("CANTIDAD"); CANTIDAD.value = data.CANTIDAD
                var PRECIO_UND_MN = document.getElementById("PRECIO_UND_MN"); PRECIO_UND_MN.value = data.PRECIO_UND_MN
                var PRECIO_UND_ME = document.getElementById("PRECIO_UND_ME"); PRECIO_UND_ME.value = data.PRECIO_UND_ME
                var T_C = document.getElementById("T_C"); T_C.value = data.T_C
                var IMPORTE__MN = document.getElementById("IMPORTE__MN"); IMPORTE__MN.value = data.IMPORTE__MN
                var CentroCostos = document.getElementById("CentroCostos"); CentroCostos.value = data.CentroCostos
                

                //var FechaRegistro = document.getElementById("FechaRegistro");
                //FechaRegistro.value = data.FechaRegistro;

                //var ch = document.getElementById("TieneContrato");
                //if (data.TieneContrato == "Si")
                //{ ch.checked = true;}
                //else
                //{ ch.checked = false; }



                //console.log(data.Ruc_Dni);
                //var Direccion = document.getElementById("Direccion");
                //Direccion.innerHTML = '<a href="DireccionesCliente.aspx?ruc_dni=' + data.Ruc_Dni + '">Direcciones</a>';

                Usuarios();
            }


            function Usuarios() {
                var json_url = "Paginas.asmx";

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerUsuarios",
                    data: " {}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');
                        //append_json(msg);
                        var datos = msg.d;
                        //console.log(datos);
                        document.getElementById('languageList8').innerHTML = '';
                        datos.forEach(function (object) {
                            var option = document.createElement('option');
                         
                            //console.log(option);

                            option.value = object.Usuario;
                            option.innerHTML = object.Usuario;
                            //console.log(option);

                            $("#languageList8").append(option);
                        });

                        CategoriaSunat();
                    },
                    error: function (msg) {
                        console.log('er');

                        //alert(msg.d);
                        //$("#sidebar").append(msg);
                    }
                });

                //var param = { prefixText: $('#myInput').val() ,count:"1"};
                //url: "Paginas.asmx/SearchCustomers",
            }

            function CategoriaSunat() {
                var json_url = "Paginas.asmx";

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "verCategoria",
                    data: " {}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');
                        //append_json(msg);
                        var datos = msg.d;
                        //console.log(datos);
                        document.getElementById('languageList9').innerHTML = '';
                        datos.forEach(function (object) {
                            var option = document.createElement('option');

                            //console.log(option);

                            option.value = object.categoria;
                            option.innerHTML = object.descripcionlocal;
                            //console.log(option);

                            $("#languageList9").append(option);
                        });


                    },
                    error: function (msg) {
                        console.log('er');

                        //alert(msg.d);
                        //$("#sidebar").append(msg);
                    }
                });


                a4();
                //var param = { prefixText: $('#myInput').val() ,count:"1"};
                //url: "Paginas.asmx/SearchCustomers",
            }

            function a4()

            {
               
                $("#descrisunat").val($("#languageList9 option[value='" + $("#categoriasunat").val() + "']").attr("label"));
            }

                function Grabar()
                {
                    var json_url = "Paginas.asmx"


                    var Fecha_de_adquision = document.getElementById("Fecha_de_adquision").value;
                    var nro_Factura = document.getElementById("nro_Factura").value;
                    var proveedor = document.getElementById("proveedor").value;
                    var descripcion = document.getElementById("descripcion").value;
                    var marca = document.getElementById("marca").value;
                    var modelo = document.getElementById("modelo").value;
                    var serie = document.getElementById("serie").value;
                    var largo = document.getElementById("largo").value;
                    var ancho = document.getElementById("ancho").value;
                    var altura = document.getElementById("altura").value;
                    var color = document.getElementById("color").value;
                    var estado = document.getElementById("estado").value;
                    var precio = document.getElementById("precio").value;
                    var igv = document.getElementById("igv").value;
                    var total = document.getElementById("total").value;
                    var usuario = document.getElementById("usuario").value;

                    var local = document.getElementById("local").value;
                    var ambiente = document.getElementById("ambiente").value;
                    var Cod_familia = document.getElementById("Cod_familia").value;

                    var anio_fabricacion = document.getElementById("anio_fabricacion").value;
                    var fecha_de_inv = document.getElementById("fecha_de_inv").value;
                    var categoriasunat = document.getElementById("categoriasunat").value;
                    var tasadepreciacion = document.getElementById("tasadepreciacion").value;
                    
                    var myData = {
                        "anio_fabricacion":anio_fabricacion,
                        "Cod_familia":Cod_familia,
                        "fecha_de_inv":fecha_de_inv,
                        "Codigo": document.getElementById("HiddenField1").value,
                        "Fecha_de_adquision": Fecha_de_adquision,
                        "nro_Factura": nro_Factura,
                        "proveedor": proveedor,
                        "descripcion": descripcion,
                        "marca": marca,
                        "local": local,
                        "ambiente":ambiente,
                        "modelo": modelo,
                        "serie": serie,
                        "largo": largo,
                        "ancho": ancho,
                        "altura": altura,
                        "color": color,
                        "estado": estado,
                        "precio": precio,
                        "igv": igv,
                        "total": total,
                        "usuario": usuario,
                        "categoriasunat":categoriasunat,
                        "opcion": "U",
                        "imagen": document.getElementById("blah").src,
                        "tasadepreciacion": document.getElementById("tasadepreciacion").value,

                        "UsuarioAnterior": document.getElementById("UsuarioAnterior").value,
                        "nrovoucher": document.getElementById("nrovoucher").value,
                        "Dimensiones": document.getElementById("Dimensiones").value,
                        "PESO": document.getElementById("PESO").value,
                        "CONSUMO_ENERGIA": document.getElementById("CONSUMO_ENERGIA").value,
                        "TIPO_EQUIPO_CATEGORIA": document.getElementById("TIPO_EQUIPO_CATEGORIA").value,
                        "Ruc_Proveedor": document.getElementById("Ruc_Proveedor").value,
                        "TIPO_DE_ACTIVO": document.getElementById("TIPO_DE_ACTIVO").value,
                        "TIPO_MATERIAL": document.getElementById("TIPO_MATERIAL").value,
                        "CATEGORIA": document.getElementById("CATEGORIA").value,
                        "EDIFICIO": document.getElementById("EDIFICIO").value,
                        "PISO": document.getElementById("PISO").value,
                        "UBICACION": document.getElementById("UBICACION").value,
                        "COD_LINEA": document.getElementById("COD_LINEA").value,
                        "DETALLE_STATUS": document.getElementById("DETALLE_STATUS").value,
                        "OBSERVACIONES": document.getElementById("OBSERVACIONES").value,
                        "TIPO_DE_EQUIPO_contable": document.getElementById("TIPO_DE_EQUIPO_contable").value,
                        "DESCRIPCIoN_contable": document.getElementById("DESCRIPCIoN_contable").value,
                        "CANTIDAD": document.getElementById("CANTIDAD").value,
                        "PRECIO_UND_MN": document.getElementById("PRECIO_UND_MN").value,
                        "PRECIO_UND_ME": document.getElementById("PRECIO_UND_ME").value,
                        "T_C": document.getElementById("T_C").value,
                        "IMPORTE__MN": document.getElementById("IMPORTE__MN").value,
                        "CentroCostos": document.getElementById("CentroCostos").value

                    };
                    var encoded = JSON.stringify(myData);
                    
                    $.ajax({
                        type: "POST",
                        url: json_url + "/" + "UpdateActivo",
                        data: encoded,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (msg) {
                            alert(msg.d);
                            if (msg.d == "ok") {
                                window.location.href = "VerActivos.aspx";
                            }
                            //$("#sidebar").append(msg);
                        },
                        error: function (msg) {
                            console.log('er');
                            //revision
                            //alert(msg.d);
                            //$("#sidebar").append(msg);
                        }
                    });


                }


                function readURL(input) {
                    if (input.files && input.files[0]) {
                        var reader = new FileReader();

                        reader.onload = function (e) {
                            $('#blah')
                                .attr('src', e.target.result)
                                .width(300)
                                .height(300);
                        };

                        reader.readAsDataURL(input.files[0]);
                    }
                }

                function openForm() {
                    document.getElementById("myForm").style.display = "block";
                    getdepreciacion();
                }

                            function closeForm() {
                    document.getElementById("myForm").style.display = "none";
                            }

                            function getdepreciacion() {
                                
                                var json_url = "Paginas.asmx"

                                var Codigo = document.getElementById("HiddenField1").value;
                                var myData = { "Codigo": Codigo };
                                var encoded = JSON.stringify(myData);
                                //console.log(myData);
                                //console.log(encoded);

                                $.ajax({
                                    type: "POST",
                                    url: json_url + "/" + "VerDepreciacionPorCodigo",
                                    data: encoded,
                                    contentType: "application/json; charset=utf-8",
                                    dataType: "json",
                                    success: function (msg) {
                                        append_jsonitem(msg);
                                    },
                                    error: function (msg) {
                                        console.log('er');

                                    }
                                });

                            }

                            function append_jsonitem(data) {
                                var table = document.getElementById('gableitem');

                                try {

                                    //var yy = data.d
                                    data.d.forEach(function (object) {
                                        var tr = document.createElement('tr');
                                        tr.innerHTML =

                                       '<td>' + object.Nro + '</td>' +
                                       '<td>' + object.Periodo + '</td>' +
                                       '<td>' + object.Depreciacion + '</td>' +
                                       '<td>' + object.Saldo + '</td>';
                                        
                                        table.appendChild(tr);
                                    });
                                }
                                catch (error) {
                                }

                            }
            </script>
      
     <style>
        #titulo {
        color:#2BC2AC
        }
        #titulo2 {
        color:#2BC2AC;
        font-size:18px;
        }
    .ten {
  width: 10%;
  background: #2BC2AC;
}
        .twenty {
            width: 20%;
            background: #2BC2AC;
        }
        .glyphicon glyphicon-sort {
        background:#2BC2AC;
        }

    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div  id="titulo2" class="row" >
        <div class="col-12">
            <a href="VerActivos.aspx">  <img height="40px" src="atras-removebg-preview.png" /></a>
        </div>
     </div>
       
        <div style="background-color:#071456;color:white;border-radius:10px">
            <h4 style="background-color:black;color:white;font-weight:bold">Información del Bien</h4>
        <div class="row" align="center">
            <div class="col-4" >Tipo de activo<input style="border-radius:5px" class="form-control input-sm" type="text" id="TIPO_DE_ACTIVO" value="" /></div>
            <div class="col-4" >Descripción<input style="border-radius:5px;background-color:black;color:white" class="form-control input-sm" type="text" id="descripcion" value="" /></div>
            <div class="col-4" >Marca<input style="border-radius:5px" class="form-control input-sm" type="text" id="marca" /></div>    
        </div>
        
        <div class="row" align="center">
            <div class="col-4" >Modelo<input style="border-radius:5px" class="form-control input-sm" type="text" id="modelo" /></div>
          <div class="col-4" >Serie<input style="border-radius:5px" class="form-control input-sm" type="text" id="serie" /></div>
            <div class="col-4" >Color<input style="border-radius:5px" class="form-control input-sm" type="text" id="color" /></div>
        </div>
        
        <div class="row" align="center">
            <div class="col-4" >Tipo de material<input style="border-radius:5px" class="form-control input-sm" type="text" id="TIPO_MATERIAL" value="" /></div>
             <div class="col-4" >Largo<input style="border-radius:5px" class="form-control input-sm" type="text" id="largo" /></div>
        <div class="col-4" >Ancho<input style="border-radius:5px" class="form-control input-sm" type="text" id="ancho" /></div>
        </div>
       
          <div class="row" align="center">
            <div class="col-4" >Altura<input style="border-radius:5px" class="form-control input-sm" type="text" id="altura" /></div>
            <div class="col-4" >Dimensiones<input style="border-radius:5px" class="form-control input-sm" type="text" id="Dimensiones" value="" /></div>
            <div class="col-4" >Peso<input style="border-radius:5px" class="form-control input-sm" type="text" id="PESO" value="" /></div>
        </div>


       <div class="row" align="center">
           <div class="col-4" >Consumo energía<input style="border-radius:5px" class="form-control input-sm" type="text" id="CONSUMO_ENERGIA" value="" /></div>
            <div class="col-4" >Tipo equipo categoría<input style="border-radius:5px" class="form-control input-sm" type="text" id="TIPO_EQUIPO_CATEGORIA" value="" /></div>
       </div>

        <br />
        </div>
        

        <div style="background-color:#b8dbf6;border-radius:10px" color:"white">
            <h4 style="background-color:black;color:white;font-weight:bold">Ubicación del bien</h4>
        <div class="row" align="center">
        <div class="col-4" >Codigo familia<input style="border-radius:5px" class="form-control input-sm" type="text" id="Cod_familia" /></div>
         <div class="col-4" >Categoría<input style="border-radius:5px" class="form-control input-sm" type="text" id="CATEGORIA" value="" /></div>
         <div class="col-4" >Edificio<input style="border-radius:5px" class="form-control input-sm" type="text" id="EDIFICIO" value="" /></div>
        </div> 

        <div class="row" align="center">
         <div class="col-4" >Piso<input style="border-radius:5px" class="form-control input-sm" type="text" id="PISO" value="" /></div>
         <div class="col-4" >Ubicación<input style="border-radius:5px" class="form-control input-sm" type="text" id="UBICACION" value="" /></div>
         <div class="col-4" >Cod Linea<input style="border-radius:5px" class="form-control input-sm" type="text" id="COD_LINEA" value="" /></div>

        </div> 
        <br />
        </div>

          <div style="background-color:#071456;color:white;border-radius:10px" >
            <h4 style="background-color:black;color:white;font-weight:bold">Estado del Bien</h4>
               <div class="row" align="center">
        <div class="col-4" >Estado<input style="border-radius:5px" class="form-control input-sm" type="text" id="estado" /></div> 
        <div class="col-4" >Detalle status<input style="border-radius:5px" class="form-control input-sm" type="text" id="DETALLE_STATUS" value="" /></div>
        <div class="col-4" >Observaciones<input style="border-radius:5px" class="form-control input-sm" type="text" id="OBSERVACIONES" value="" /></div> 
        </div> 
                   <br />
        </div>
         

                  <div style="background-color:#b8dbf6;border-radius:10px" >
            <h4 style="background-color:black;color:white;font-weight:bold">Información del Área Usuaria</h4>
               <div class="row" align="center">
                 <div class="col-4" >Usuario<input style="border-radius:5px" class="form-control input-sm" type="text" id="usuario" list="languageList8" value="rrrrrr" />
                 <datalist id="languageList8" ></datalist></div>
                 <div class="col-4" >Usuario Anterior<input style="border-radius:5px" class="form-control input-sm" type="text" id="UsuarioAnterior" value="" /></div>
                 <div class="col-4" >Área<input style="border-radius:5px" class="form-control input-sm" type="text" id="local" /></div>
        </div>
             <div class="row" align="center">
            <div class="col-4" >Sede<input style="border-radius:5px" class="form-control input-sm" type="text" id="ambiente" /></div>
            </div>
                <br />
        </div>
         

                          <div style="background-color:#071456;color:white;border-radius:10px" >
            <h4 style="background-color:black;color:white;font-weight:bold">Información Contable</h4>
         <div class="row" align="center">
        <div class="col-4" >N° voucher<input style="border-radius:5px" class="form-control input-sm" type="text" id="nrovoucher" value="" /></div>
         <div class="col-4" >Categoría sunat<input style="border-radius:5px" class="form-control input-sm" type="text" id="categoriasunat" list="languageList9" 
                value=""  onchange="a4()"/><datalist id="languageList9" ></datalist></div>
         <div class="col-4" ><input style="border-radius:5px" style="width:100%" id="descrisunat" readonly="true" /></div>
         <div class="col-4" >Centro de Costos<input style="border-radius:5px" class="form-control input-sm" type="text" id="CentroCostos" value="" /></div>
               <div class="col-4" >Ruc proveedor<input style="border-radius:5px" class="form-control input-sm" type="text" id="Ruc_Proveedor" value="" /></div>
         <div class="col-4" >Proveedor<input style="border-radius:5px" class="form-control input-sm" type="text" id="proveedor" /></div>
         <div class="col-4" >Fecha de adquisición<input style="border-radius:5px;background-color:salmon" class="form-control input-sm" type="date" id="Fecha_de_adquision"  /></div>
         <div class="col-4" >N° Factura<input style="border-radius:5px" class="form-control input-sm" type="text" id="nro_Factura" value="" /></div>
         <div class="col-4" >Tipo de equipo contable<input style="border-radius:5px" class="form-control input-sm" type="text" id="TIPO_DE_EQUIPO_contable" value="" /></div>
         <div class="col-4" >Descripción contable<input style="border-radius:5px" class="form-control input-sm" type="text" id="DESCRIPCIoN_contable" value="" /></div>
         <div class="col-4" >Cantidad<input style="border-radius:5px" class="form-control input-sm" type="text" id="CANTIDAD" value="" /></div>
 <div class="col-4" >Precio und md<input style="border-radius:5px" class="form-control input-sm" type="text" id="PRECIO_UND_MN" value="" /></div>
 <div class="col-4" >Precio und me<input style="border-radius:5px" class="form-control input-sm" type="text" id="PRECIO_UND_ME" value="" /></div>
 <div class="col-4" >Tipo de Cambio<input style="border-radius:5px" class="form-control input-sm" type="text" id="T_C" value="" /></div>
 <div class="col-4" >Importe mn<input style="border-radius:5px" class="form-control input-sm" type="text" id="IMPORTE__MN" value="" /></div>
 <div class="col-4" >Precio<input style="border-radius:5px" class="form-control input-sm" type="text" id="precio" /></div>
 <div class="col-4" >Igv<input style="border-radius:5px" class="form-control input-sm" type="text" id="igv" /></div>
 <div class="col-4" >Total<input style="border-radius:5px;background-color:salmon" class="form-control input-sm" type="text" id="total" /></div>
 <div class="col-4" >Tasa de  Depreciación<input style="border-radius:5px;background-color:salmon" class="form-control input-sm" type="text" id="tasadepreciacion" /></div>
 <div class="col-4" ><button onclick="openForm();return false;">Ver Depreciación</button></div>
 <div class="col-4" >Año de Fabricación<input style="border-radius:5px" class="form-control input-sm" type="text" id="anio_fabricacion" /></div>
        <div class="col-4" >Fecha de Inventario<input style="border-radius:5px" class="form-control input-sm" type="text" id="fecha_de_inv" /></div>

            </div>
                              
                              <br />
        </div>

            <div style="background-color:black" >
            <h4 style="color:white">Imagen</h4>

         <div class="row" align="center">
            
             <div class="col-4" >
        <input style="border-radius:5px" type='file' onchange="readURL(this);return false;" />
        <img id="blah" src="#" alt="your image" />
             </div>
        <div class="col-4" >
        <asp:Button BackColor="GreenYellow" ID="Button1" runat="server" Text="Grabar Cambios" OnClientClick="Grabar();return false" OnClick="Button1_Click" />
        </div>
        </div>
           <br />
         </div>
        


    <asp:HiddenField ID="HiddenField1" runat="server" />


            </form>



    <div class="form-popup" id="myForm" >
  <form  class="form-container">
    <h4>Depreciación Acumulada</h4>

       <div class="row">
          <div class="col-6">
                    <button type="button" class="btn cancel" onclick="closeForm()">Cerrar</button>
          </div>

      </div>
      <div style="overflow:scroll;height:300px">
           <div class="row">
    <div class="col-10">
        <table id="gableitem" class="table table-p border-bottom">
            <colgroup>
                <col class="ten" />
                <col class="ten" />
                <col class="ten" />
                <col class="ten" />
             </colgroup>
            <tr>
                <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Nro</th>
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Periodo</th>
                <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Depreciación</th>
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Saldo</th>
            </tr>
        </table>
    </div>   </div></div>
  </form>

</div>


</body>
</html>

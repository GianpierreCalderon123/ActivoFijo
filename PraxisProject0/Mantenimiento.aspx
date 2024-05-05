<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="PraxisProject0.Mantenimiento" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta name="viewport" content="width=device-width, initial-scale=1"> 
    <title>Mantenimiento</title>
    <style>
        #titulo {
        color:#071456;
        font-weight:bold;
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
    
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" >
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
   
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script> 



<script type="text/javascript" src="jquery.json-2.2.min.js"  ></script>



    <script type="text/javascript">
        function VerDetalle() {
            var nuevo;

            var gvET = document.getElementById("GridView1");
            var rIndex;

            for (var i = 1; i < gvET.rows.length; i++) {
                gvET.rows[i].onclick = function () {
                    // get the seected row index
                    rIndex = this.rowIndex;

                    document.getElementById("HiddenField1").value = gvET.rows[rIndex].cells[8].innerHTML
                    document.getElementById("HiddenField2").value = gvET.rows[rIndex].cells[7].innerHTML

                    //gvET.rows[rIndex].cells[5].innerHTML = nuevo;

                };

            }
        }

        function VerDetalleNuevo() {
            var nuevo;

            var gvET = document.getElementById("gable");

            console.log(gvET);
            var rIndex;

            for (var i = 1; i < gvET.rows.length; i++) {
                gvET.rows[i].onclick = function () {
                    // get the seected row index
                    rIndex = this.rowIndex;

                    document.getElementById("HiddenField1").value = gvET.rows[rIndex].cells[8].innerHTML
                    document.getElementById("HiddenField2").value = gvET.rows[rIndex].cells[7].innerHTML

                    //gvET.rows[rIndex].cells[5].innerHTML = nuevo;

                };

            }

            console.log(document.getElementById("HiddenField1").value);
            console.log(document.getElementById("HiddenField2").value);

            function DoPostBack(obj) {
                __doPostBack(obj.id, 'OtherInformation');
            }

        }


    </script> 
<script type="text/javascript">
    console.log("entro")
    $('#HiddenField2').on('change', function () {
        window.location.reload(); // <-- there are several ways to swing this cat
    });
    console.log("salgo")
</script>

        <script>


            console.log("2w")
            //first add an event listener for page load
            document.addEventListener("DOMContentLoaded", get_json_data, false); // get_json_data is the function name that will fire on page load


            //console.log("2e")
            //this function is in the event listener and will execute on page load
            function get_json_data() {
                var json_url = "Paginas.asmx"


                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerMantenimientoClass",
                    data: "{}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');

                        //alert("worked" + msg.d);
                        append_json(msg);
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
                var table = document.getElementById('gable');


                try {
                    console.log(data.d);
                    console.log("1");

                    table.innerHTML =
                    '<colgroup>' +
                    '<col class="ten" />' +
                    '<col class="ten" />' +
                    '<col class="ten" />' +
                    '<col class="ten" />' +
                    '<col class="ten" />' +
                    '<col class="ten" />' +
                    '</colgroup>' +
                    '<tr style="background-color:#071456;color:white">' +
                    '<th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Nro</th>' +
                     '<th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Codigo</th>' +
                    '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>' +
                    '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Obs</th>' +
                     '<th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Estado</th>' +
                     '<th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Modificar</th>' +
                    '</tr>'


                    //var yy = data.d
                    data.d.forEach(function (object) {
                        var tr = document.createElement('tr');
                        tr.style.backgroundColor = "#b8dbf6";
                        tr.innerHTML =
                        '<td>' + object.Nro + '</td>' +
                         '<td>' + object.Codigo + '</td>' +
                         '<td>' + object.descripcion + '</td>' +
                         '<td>' + object.descripcionservicio + '</td>' +
                         '<td>' + object.Estado + '</td>' +
                         '<td><a href="VerMantenimiento.aspx?Opcion=U&&Nro=' + object.Nro + '"> Ver Detalle</a></td> '
                        table.appendChild(tr);
                    });

                    //Clientes99();
                }
                catch (error) {
                    console.log("2");
                    console.log(data.d);
                    var tr = document.createElement('tr');
                    tr.innerHTML = '<td>' + data.d + '</td>'
                    //    +
                    //'<td>' + object.LoC + '</td>' +
                    //'<td>' + object.BALANCE + '</td>' +
                    //'<td>' + object.DATE + '</td>';
                    table.appendChild(tr);
                }

            }
            function Grabar() {

                window.location.href = "ModificacionActivo.aspx?Codigo=0";


                return;

                var json_url = "Paginas.asmx"


                var Fecha_de_adquision = "";//document.getElementById("Fecha_de_adquision").value;
                var nro_Factura = "";//document.getElementById("nro_Factura").value;
                var proveedor = "";// document.getElementById("proveedor").value;
                var descripcion = "";// document.getElementById("descripcion").value;
                var marca = "";// document.getElementById("marca").value;
                var modelo = "";//document.getElementById("modelo").value;
                var serie = "";//document.getElementById("serie").value;
                var largo = "";//document.getElementById("largo").value;
                var ancho = "";//document.getElementById("ancho").value;
                var altura = "";//document.getElementById("altura").value;
                var color = "";//document.getElementById("color").value;
                var estado = "";//document.getElementById("estado").value;
                var precio = "";//document.getElementById("precio").value;
                var igv = "";//document.getElementById("igv").value;
                var total = "";//document.getElementById("total").value;
                var usuario = "";//document.getElementById("usuario").value;

                var local = "";//document.getElementById("local").value;
                var ambiente = "";//document.getElementById("ambiente").value;
                var Cod_familia = "";//document.getElementById("Cod_familia").value;

                var anio_fabricacion = "";//document.getElementById("anio_fabricacion").value;
                var fecha_de_inv = "";//document.getElementById("fecha_de_inv").value;


                var myData = {
                    "anio_fabricacion": anio_fabricacion,
                    "Cod_familia": Cod_familia,
                    "fecha_de_inv": fecha_de_inv,
                    "Codigo": document.getElementById("Codigo").value,
                    "Fecha_de_adquision": Fecha_de_adquision,
                    "nro_Factura": nro_Factura,
                    "proveedor": proveedor,
                    "descripcion": descripcion,
                    "marca": marca,
                    "local": local,
                    "ambiente": ambiente,
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
                    "opcion": "I"
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



            function eliminar(cod1) {


                var x = confirm("Desea Eliminar el Activo " + cod1)
                if (x == true)
                { Eliminar1(cod1); }
                else
                { }

            }

            function Eliminar1(cod1) {



                var json_url = "Paginas.asmx"


                var Fecha_de_adquision = "";//document.getElementById("Fecha_de_adquision").value;
                var nro_Factura = "";//document.getElementById("nro_Factura").value;
                var proveedor = "";// document.getElementById("proveedor").value;
                var descripcion = "";// document.getElementById("descripcion").value;
                var marca = "";// document.getElementById("marca").value;
                var modelo = "";//document.getElementById("modelo").value;
                var serie = "";//document.getElementById("serie").value;
                var largo = "";//document.getElementById("largo").value;
                var ancho = "";//document.getElementById("ancho").value;
                var altura = "";//document.getElementById("altura").value;
                var color = "";//document.getElementById("color").value;
                var estado = "";//document.getElementById("estado").value;
                var precio = "";//document.getElementById("precio").value;
                var igv = "";//document.getElementById("igv").value;
                var total = "";//document.getElementById("total").value;
                var usuario = "";//document.getElementById("usuario").value;

                var local = "";//document.getElementById("local").value;
                var ambiente = "";//document.getElementById("ambiente").value;
                var Cod_familia = "";//document.getElementById("Cod_familia").value;

                var anio_fabricacion = "";//document.getElementById("anio_fabricacion").value;
                var fecha_de_inv = "";//document.getElementById("fecha_de_inv").value;


                var myData = {
                    "anio_fabricacion": anio_fabricacion,
                    "Cod_familia": Cod_familia,
                    "fecha_de_inv": fecha_de_inv,
                    "Codigo": cod1,
                    "Fecha_de_adquision": Fecha_de_adquision,
                    "nro_Factura": nro_Factura,
                    "proveedor": proveedor,
                    "descripcion": descripcion,
                    "marca": marca,
                    "local": local,
                    "ambiente": ambiente,
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
                    "opcion": "D"
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


            function Clientes99() {
                var json_url = "Paginas.asmx"
                var usuario = document.getElementById("HiddenFieldUsuario").value;

                var myData = { "RucB": "", "NombreB": "", "usuario": usuario };
                var encoded = JSON.stringify(myData);
                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerClientes",
                    data: encoded,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');
                        //append_json(msg);
                        var datos = msg.d;
                        //console.log(datos);
                        document.getElementById('languageList99').innerHTML = '';
                        datos.forEach(function (object) {
                            var option = document.createElement('option');
                            //console.log(option);

                            option.value = object.Nombre;
                            option.innerHTML = object.Ruc_Dni;
                            //console.log(option);

                            $("#languageList99").append(option);
                        });

                        Clientes88();
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

            function Clientes88() {
                var json_url = "Paginas.asmx"
                var usuario = document.getElementById("HiddenFieldUsuario").value;

                var myData = { "RucB": "", "NombreB": "", "usuario": usuario };
                var encoded = JSON.stringify(myData);
                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerClientes",
                    data: encoded,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        console.log('ok');
                        //append_json(msg);
                        var datos = msg.d;
                        //console.log(datos);
                        document.getElementById('languageList88').innerHTML = '';
                        datos.forEach(function (object) {
                            var option = document.createElement('option');
                            //console.log(option);

                            option.value = object.Ruc_Dni;
                            option.innerHTML = object.Nombre;
                            //console.log(option);

                            $("#languageList88").append(option);
                        });


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
    </script>
 
</head>
<body>

        <form id="form1" runat="server">
    <div  id="titulo2" class="row" >
        <div class="col-12">
            <a href="Menu.aspx">  <img height="40px" src="atras-removebg-preview.png" /></a>
        </div>
     </div>
    
     <div class="row">
        <div class="col-12 " align="center" >
          
           &nbsp;</div>
     </div>
      <br />


    <div  id="titulo" class="row" align="center">
        <div class="col-12">
          
           <img align="center"height="30"   id="ImgFoto" src="mantenimiento-removebg-preview.png" alt="Foto" border="0" />Mantenimientos</div>
     </div>


        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-4" >
                 
                 <asp:Button style="background-color:#071456;color:white" ID="Button1" runat="server" Text="Insertar Mantenimiento"   PostBackUrl="~/VerMantenimiento.aspx?Opcion=I"  />
                 
             </div>
              <div class="col-3" >
<button style="background-color:#071456;color:white"  onclick='window.location.href = "Alerta.aspx";return false;' style="width:100%;height:50px;border-radius:10px">
Alertas</button>
                </div>
            
        </div>

           
                 

               <br />


    <div class="row">
    <div class="col-1"></div>
    <div class="col-10">
        <table id="gable" class="table table-p border-bottom">
        
        </table>
    </div>
        </div>

    <%--prueba--%>
    <div class="below-slideshow" style="padding-bottom: 0px">
            <div class="container"> 

      

    <div align="center">

        
          <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HiddenField ID="HiddenField2" runat="server" />
        <asp:HiddenField ID="HiddenField3" runat="server" />
        <asp:HiddenField ID="HiddenFieldUsuario" runat="server" />
          <br />

 
       </div>  
</div>
             
    </form>
</body>
</html>

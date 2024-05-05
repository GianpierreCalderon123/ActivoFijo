<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarMovimiento.aspx.cs" Inherits="PraxisProject0.InsertarMovimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movimientos</title>
         <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
   
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script> 

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

#titulo {
    color: #071456;
    font-weight: bold;
}
</style>



</head>
<body>

    <form id="form1" runat="server">
    
        <div class="col-12">
            <a href="Movimientos.aspx">  <img height="40px" src="atras-removebg-preview.png"></a>
        </div>
        
            <h1 id="titulo">Generación de Movimientos</h1>
  
<br>        
    <div class="row">
        <div class="col-2">Fecha</div>
        <div class="col-2"><input id="fecha" type="date" class="form-control input-sm" /></div>
        <div class="col-2">Destinatario</div>
        <div class="col-2"><input id="Destinatario" class="form-control input-sm" /></div>
        <div class="col-2">Punto de Partida</div>
        <div class="col-2"><input id="PuntodePartida" class="form-control input-sm" /></div>
    </div>
        <br />

          <div class="row">
        <div class="col-2">Ruc</div>
        <div class="col-2"><input id="Ruc" class="form-control input-sm" /></div>
        <div class="col-2">PuntodeLLegada</div>
        <div class="col-2"><input id="PuntodeLLegada" class="form-control input-sm" /></div>
      
    </div>
        <br />
        
          <div class="row">
        <div class="col-2">Ruc Transporte</div>
        <div class="col-2"><input id="Ruc_transporte" class="form-control input-sm" /></div>
        <div class="col-2">Nombre Transporte</div>
        <div class="col-2"><input id="nombre_transporte" class="form-control input-sm" /></div>
        
    </div>
        <br />
          <div class="row">
        <div class="col-2">Marca/Placa Vehiculo</div>
        <div class="col-2"><input id="marca_placa_transporte" class="form-control input-sm" /></div>
        <div class="col-2">Licencia Conductor</div>
        <div class="col-2"><input id="licencia" class="form-control input-sm" /></div>
    </div>
        <br />



    
        <br />
    <div class="row">
        <div class="col-6" ><button  style="background-color:#071456;color:white;width:100%"
            onclick="openForm();return false;" >Agregar Activos</button></div>
    </div>



        <br />

             <div class="row">
    <div class="col-1"></div>
    <div class="col-10">
        <table id="gable2" class="table table-p border-bottom">
            <colgroup>
                <col class="ten" />
                <col class="ten" />
                <col class="ten" />
             </colgroup>
            <tr style="background-color:#071456;color:white">
                <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>-</th>             
                <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Activo</th>             
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Descripcion</th>
            </tr>
        
        </table>
    </div>
                  </div>
        
        <div class="row">

        <div class="col-12" ><button style="background-color:#071456;color:white;width:100%" onclick="generarmovimiento();return false;" id="btnfac" >
            Generar Movimiento</button></div>
    </div>
        
              <asp:HiddenField ID="HiddenTipoDocumento" runat="server" />


    </form>


    
        <div class="form-popup" id="myForm" >
  <form  class="form-container">
    <h3>Activos</h3>

      <div class="row">
          <div class="col-6">
                <button type="submit"  onclick="JalaActivos();return false;"      class="btn">Agregar</button>
          </div>

          <div class="col-6">
                    <button type="button" class="btn cancel" onclick="closeForm()">Cerrar</button>
          </div>

      </div>

            <div class="row">
          <div class="col-2">Activo</div>
          <div class="col-2"><input id="filtroactivo" onchange="getactivos();return false;" /></div>
      </div>
       <div class="row">          
          <div class="col-2">Descripción</div>
         <div class="col-2"><input id="filtrodescripcion" onchange="getactivos();return false;" /></div>

      </div>

      <div style="overflow:scroll;height:300px">
  
           <div class="row">
    <div class="col-10">
        <table id="gable" class="table table-p border-bottom">
            <colgroup>
                <col class="ten" />
                <col class="ten" />
                <col class="ten" />
                <col class="ten" />
             </colgroup>
            <tr>
                <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>
                
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Activo</th>
                <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>
                
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span></th>
                
            </tr>
        
        </table>
    </div>
                  </div>
                            </div>

  </form>
</div>

    

</body>

     <script>

         function openForm() {
             document.getElementById("myForm").style.display = "block";
             getactivos();
         }

       


         function closeForm() {
             document.getElementById("myForm").style.display = "none";
         }


</script>
    <script>

        function generatotal() {
            var subtotal, igv, total;
            var subtotal = 0;
            var igv = 0;
            var total = 0;
            var row;
            var fact = document.getElementById("gable2");

            for (row = 1; row <= fact.rows.length - 1; row++) {
                subtotal = subtotal + Number(fact.rows[row].cells[7].innerText);
                igv = igv + Number(fact.rows[row].cells[8].innerText);
                total = total + Number(fact.rows[row].cells[9].innerText);
            }
            document.getElementById("Importe").value = subtotal;
            document.getElementById("IGV").value = igv;
            document.getElementById("ImporteTotal").value = total;

        }

        function generarmovimiento() {
            var gvET = document.getElementById("gable2");

            var row;
            var column;
            var tt = "";
            var rr = new Array();
            for (row = 1; row <= gvET.rows.length - 1; row++) {

                var myData1 = {
                    "codigo": gvET.rows[row].cells[1].innerText,
                };
                rr[row-1] = myData1;

            }


            var fecha = document.getElementById("fecha").value;
            var Destinatario = document.getElementById("Destinatario").value;
            var PuntodePartida = document.getElementById("PuntodePartida").value;
            var Ruc = document.getElementById("Ruc").value;
            var PuntodeLLegada = document.getElementById("PuntodeLLegada").value;
            var Ruc_transporte = document.getElementById("Ruc_transporte").value;
            var nombre_transporte = document.getElementById("nombre_transporte").value;

            var marca_placa_transporte = document.getElementById("marca_placa_transporte").value;
            var licencia = document.getElementById("licencia").value;

            var myData0 = {
                "fecha": fecha,
                "Destinatario": Destinatario,
                "PuntodePartida": PuntodePartida,
                "Ruc": Ruc,
                "PuntodeLLegada": PuntodeLLegada,
                "Ruc_transporte": Ruc_transporte,
                "nombre_transporte": nombre_transporte,
                "marca_placa_transporte": marca_placa_transporte,
                "licencia": licencia,
                "detalle": rr
            };

            var myData = {"movimiento": myData0};
            var encoded = JSON.stringify(myData);
            var json_url = "Paginas.asmx";

            console.log(encoded);

            $.ajax({
                type: "POST",
                url: json_url + "/" + "GenerarMovimiento",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    
                    alert("Movimiento Generado");
                    window.location.href = "Movimientos.aspx";
                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });


        }

        function cambiasede()
        {
            var json_url = "Paginas.asmx";
            var myData = {
                "sede": document.getElementById("sede").value,
                "tipodocumento": document.getElementById("HiddenTipoDocumento").value
            };
            var encoded = JSON.stringify(myData);

            $.ajax({
                type: "POST",
                url: json_url + "/" + "GetSerie",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    var datos = msg.d;
                    document.getElementById('serie').value = datos;
                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });


        }

        function Direcciones() {
            //var lista = document.getElementById("languageList2");
            //lista.forEach(function (option)
            //{
            //    console.log(option);
            //});

            //$(document).on('change', '#place', function () {
            $("#ClienteNombre").val($("#languageList2 option[value='" + $("#Ruc_Cliente").val() + "']").attr("label"));

            var json_url = "Paginas.asmx";
            var myData = { "ruc_dni": document.getElementById("Ruc_Cliente").value };
            var encoded = JSON.stringify(myData);

            $.ajax({
                type: "POST",
                url: json_url + "/" + "VerDireccionFactura",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    console.log('ok');
                    //append_json(msg);
                    var datos = msg.d;
                    //console.log(datos);
                    document.getElementById('languageList3').innerHTML = '';
                    datos.forEach(function (object) {
                        var option = document.createElement('option');
                        //console.log(option);

                        option.value = object.Direccion;
                        option.innerHTML = object.Direccion;

                        document.getElementById("ClienteNombre").value = object.nombre;

                        //console.log(option);

                        $("#languageList3").append(option);
                    });

                    dr();
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

        function dr() {
            document.getElementById("DireccionRecojo").value = document.getElementById("languageList3").value;
            limpiardetalle();
        }


        document.addEventListener("DOMContentLoaded", Clientes, false); // get_json_data is the function name that will fire on page load

        function Clientes() {

            //console.log(document.getElementById("HiddenTipoDocumento").value);
            //if (document.getElementById("HiddenTipoDocumento").value == "Factura")
            //
            //    document.getElementById("tit").innerHTML = "Generación de Facturas";
            //    document.getElementById("btnfac").innerHTML = "Generar Factura";

            //}
            //if (document.getElementById("HiddenTipoDocumento").value == "Boleta")
            //{
            //    document.getElementById("tit").innerHTML = "Generación de Boletas";
            //    document.getElementById("btnfac").innerHTML = "Generar Boleta";
            //}
            
            //var json_url = "Paginas.asmx"

            //var usuario = "";

            //var myData = { "RucB": "", "NombreB": "", "usuario": usuario };
            //var encoded = JSON.stringify(myData);

            //$.ajax({
            //    type: "POST",
            //    url: json_url + "/" + "VerClientes",
            //    data: encoded,
            //    contentType: "application/json; charset=utf-8",
            //    dataType: "json",
            //    success: function (msg) {
            //        console.log('ok');
            //        //append_json(msg);
            //        var datos = msg.d;
            //        console.log(datos);
            //        document.getElementById('languageList2').innerHTML = '';
            //        datos.forEach(function (object) {
            //            var option = document.createElement('option');
            //            //console.log(option);

            //            option.value = object.Ruc_Dni;
            //            option.label = object.Nombre;
            //            //console.log(option);

            //            $("#languageList2").append(option);
            //        });
                    
            //        cambiasede();
            //    },
            //    error: function (msg) {
            //        console.log('er');

            //        //alert(msg.d);
            //        //$("#sidebar").append(msg);
            //    }
            //});

            ////var param = { prefixText: $('#myInput').val() ,count:"1"};
            ////url: "Paginas.asmx/SearchCustomers",
        }


        function getactivos() {

            //limpiarliquidacionesdetalle();

            var json_url = "Paginas.asmx"

            var activo = document.getElementById("filtroactivo").value;
            var descripcion = document.getElementById("filtrodescripcion").value;

            var myData = { "activo": activo,"descripcion":descripcion,"grupo":"" };
            var encoded = JSON.stringify(myData);
            

            $.ajax({
                type: "POST",
                url: json_url + "/" + "GetActivoMov",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    append_jsonactivos(msg);
                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });

        }

        /////
        function getitem() {
            limpiaritemdetalle();

            var json_url = "Paginas.asmx"

            var descripcion = "";
            var myData = { "descripcion": descripcion };
            var encoded = JSON.stringify(myData);
            //console.log(myData);
            //console.log(encoded);

            $.ajax({
                type: "POST",
                url: json_url + "/" + "VerItemDisponible",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    append_jsonitem(msg);
                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });

        }

        //append_jsonitem
        function append_jsonitem(data) {
            var table = document.getElementById('gableitem');

            try {
                console.log(data.d);
                console.log("1");

                //var yy = data.d
                data.d.forEach(function (object) {
                    var tr = document.createElement('tr');
                    tr.innerHTML =

                   '<td><input type="checkbox" > </></td> ' +
                   '<td>' + object.Codigo + '</td>' +
                   '<td>' + object.Descripcion + '</td>' +
                   '<td>' + object.Unidadmedida + '</td>' +

                   '<td>' + object.CantidadDisponible + '</td>' +
                   '<td><input value= "" /></td>';

                    //                  <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Item</th>
                    //<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>
                    // <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>UnidadMedida</th>
                    //<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Cantidad Disponible</th>
                    //<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Cantidad</th>

                    table.appendChild(tr);
                });
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


        //this function appends the json data to the table 'gable'
        function append_jsonactivos(data) {
            var table = document.getElementById('gable');

            table.innerHTML=
            '<colgroup>'+
             '  <col class="ten" />'+
              ' <col class="ten" />'+
              ' <col class="ten" />'+
              ' <col class="ten" />'+
           ' </colgroup>'+
          ' <tr>'+
           '    <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>'+
                
            '   <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Activo</th>'+
             '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>'+
                
              ' <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span></th>' +
                
              ' </tr>';

            try {
                               //var yy = data.d
                data.d.forEach(function (object) {
                    var tr = document.createElement('tr');
                    tr.innerHTML =

                   '<td><input type="checkbox" > </></td> ' +
                   '<td>' + object.Codigo + '</td>' +
                   '<td>' + object.descripcion + '</td>' +
                   '<td>' + '' + '</td>' ;
                    table.appendChild(tr);
                });
            }
            catch (error) {
                
            }

        }

        
        function JalaActivos() {

            var pedido = "";

            var gvET = document.getElementById("gable");
            var fact = document.getElementById("gable2");


            var row;
            var column;
            var tt = "";
            var u = fact.rows.length - 1;

            for (row = 1; row <= gvET.rows.length - 1; row++) {

                if (gvET.rows[row].cells[0].firstElementChild.checked == true) {
                    u = u + 1;
                    var item, bienservicio, codigo, cantidad, unidad, descripcion, valorunitario,
                        preciounitario, importetotal,total;

                    codigo = gvET.rows[row].cells[1].innerText;
                    descripcion = gvET.rows[row].cells[2].innerText;

                    var row2;
                    var uu = 0;
                    for (row2 = 1; row2 <= fact.rows.length - 1; row2++) {

                        if (fact.rows[row2].cells[1].innerText  == codigo )
                        { uu = uu + 1; }

                    }

                    if (uu == 0) {
                        var tr = document.createElement('tr');
                        tr.innerHTML =
                       '<td>' +'' + '</td>' +
                       '<td>' + codigo + '</td>' +
                       '<td>' + descripcion + '</td>';
                        fact.appendChild(tr);
                    }


                }


            }


            if (u == 0) { alert("No se escogio ninguna Activo"); }


        }



        function JalaItems() {

            var pedido = "";

            var gvET = document.getElementById("gableitem");
            var fact = document.getElementById("gable2");


            var row;
            var column;
            var tt = "";

            var u = fact.rows.length - 1;

            for (row = 1; row <= gvET.rows.length - 1; row++) {

                if (gvET.rows[row].cells[0].firstElementChild.checked == true) {
                    u = u + 1;
                    var item, bienservicio, codigo, cantidad, unidad, descripcion, valorunitario,
                        preciounitario, importetotal,total;

                    item = u;
                    bienservicio = "Bien";
                    codigo = gvET.rows[row].cells[1].innerText;
                    cantidad = gvET.rows[row].cells[5].firstElementChild.value;
                    unidad = gvET.rows[row].cells[3].innerText;

                    descripcion = gvET.rows[row].cells[2].innerText;

                    valorunitario = 0;//gvET.rows[row].cells[7].innerText;
                    preciounitario = 0;//gvET.rows[row].cells[8].innerText;
                    importetotal = 0;//gvET.rows[row].cells[9].innerText;
                    total = 0;

                    var row2;
                    var uu = 0;
                    for (row2 = 1; row2 <= fact.rows.length - 1; row2++) {

                        if (fact.rows[row2].cells[2].innerText + fact.rows[row2].cells[5].innerText == codigo + descripcion)
                        { uu = uu + 1; }

                    }

                    if (uu == 0) {
                        var tr = document.createElement('tr');
                        tr.innerHTML =
                       '<td>' + item + '</td>' +
                       '<td>' + bienservicio + '</td>' +
                       '<td>' + codigo + '</td>' +
                       '<td>' + cantidad + '</td>' +
                       '<td>' + unidad + '</td>' +
                       '<td>' + descripcion + '</td>' +
                       '<td>' + valorunitario + '</td>' +
                       '<td>' + preciounitario + '</td>' +
                       '<td>' + importetotal + '</td>' +
                       '<td>' + importetotal + '</td>' 

                        fact.appendChild(tr);
                    }


                }


            }

            generatotal();
            if (u == 0) { alert("No se escogio ninguna item"); }


        }


        function limpiardetalle() {

            var tabla = document.getElementById("gable2");
            tabla.innerHTML =

            '<colgroup>' +
            '<col class="ten" />' +
            '<col class="ten" />' +
            '<col class="ten" />' +
            '<col class="ten" />' +

            '<col class="ten" />' +
             '<col class="ten" />' +

            '<col class="ten" />' +
            '<col class="ten" />' +
            '<col class="ten" />' +
            '<col class="ten" />' +
            '</colgroup>' +
            '<tr>' +
            '<th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>Item</th>' +
            '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Bien/Servicio</th>' +
            '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Código</th>' +
            '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Cantidad</th>' +

            '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Unidad</th>' +
            '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>' +

               '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>ValorUnitario</th>' +
                '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Importe</th> ' +
                '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>IGV</th>' +
                '<th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>ImporteTotal</th>' +
             
            '</tr>';
            generatotal();

        }
        function limpiarliquidacionesdetalle() {
            var tabla = document.getElementById("gable");
            tabla.innerHTML =
           ' <colgroup>' +
           '     <col class="ten" />' +

            '    <col class="ten" />' +
            '    <col class="ten" />' +
            '    <col class="ten" />' +

              '  <col class="ten1" />' +
            '    <col class="ten" />' +
             '   <col class="ten" />' +

            '    <col class="ten" />' +
            '    <col class="ten" />' +
            '    <col class="ten" />' +
            '    <col class="ten" />' +

           '  </colgroup>' +
           ' <tr>' +
               ' <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>' +

              '  <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>LiquidacionNro</th>' +
              '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Sede</th>' +

              '  <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>FechaRecojo</th>' +
               ' <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Servicio</th>' +

             '   <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Cantidad</th>' +
             '   <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>UnidadparaCostear</th>' +

             '   <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Tarifa</th>' +
             '   <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>SubTotal</th>' +

              '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>IGV</th>' +
              '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Total</th>' +
           ' </tr>'
        }


        function limpiaritemdetalle() {
            var tabla = document.getElementById("gableitem");
            tabla.innerHTML =
         '<colgroup>' +
            '    <col class="ten" />' +
             '   <col class="ten" />' +
              '  <col class="ten" />' +
               ' <col class="ten" />' +
                '<col class="ten" />' +
                '<col class="ten" />' +

             '</colgroup>' +
           ' <tr>' +
             '   <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>' +
            '    <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Item</th>' +
              '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Descripción</th>' +
               '  <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>UnidadMedida</th>' +
                '<th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Cantidad Disponible</th>' +
               ' <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Cantidad</th>' +

            '</tr>';
        }

        function detrachange() {
            if (document.getElementById("detraccion").value == "1.5%")
            {
                document.getElementById("detracciondescri").innerHTML =
                "Bienes exonerados del IGV<br>" +
"Oro y demás minerales metálicos   exonerados del IGV<br>";
            }

            if (document.getElementById("detraccion").value == "4%")
            {
                document.getElementById("detracciondescri").innerHTML =
               "Recursos hidrobiológicos<br>" +
"Maíz amarillo duro<br>" +
"Carnes y despojos comestibles<br>";

            }

            if (document.getElementById("detraccion").value == "10%")
            {
                document.getElementById("detracciondescri").innerHTML =
               "Azúcar y melaza de caña<br>" +
"Alcohol etílico<br>" +
"Arena y piedra<br>" +
"Oro gravado con el IGV<br>" +
"Minerales metálicos no auríferos<br>" +
"Minerales no metálicos<br>" +
"Caña de azúcar<br>" +
"Bienes gravados con el IGV por renuncia a la exoneración<br>" +
"Aceite de Pescado<br>" +
"Páprika y otros frutos de los géneros capsicum o pimienta<br>" +
"Intermediación laboral y tercerización<br>" +
"Arrendamiento de bienes<br>" +
"Mantenimiento y reparación de bienes muebles<br>" +
"Movimiento de carga<br>" +
"Comisión Mercantil<br>" +
"Fabricación de bienes por encargo<br>" +
"Servicio de transporte de personas<br>";

            }

            if (document.getElementById("detraccion").value == "12%")
            {
                document.getElementById("detracciondescri").innerHTML =
              "Otros Servicios Empresariales<br>" +
"Demás servicios gravados con el IGV<br>";
            }

            if (document.getElementById("detraccion").value == "15%")
            {
                document.getElementById("detracciondescri").innerHTML =
             "Residuos, subproductos, desechos, recortes, desperdicios y formas primarias derivadas de los mismos<br>" +
"Plomo<br>";
            }
        }

        function detracheck() {

            if (document.getElementById("flagdetraccion").checked == true)
            {
                document.getElementById("detraccion").style.display = "block";
                document.getElementById("detracciondescri").style.display = "block";
            }
            else
            {
                document.getElementById("detraccion").style.display = "none";
                document.getElementById("detracciondescri").style.display = "none";
            }
        }
    </script>
</html>


   
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alerta.aspx.cs" Inherits="PraxisProject0.Alerta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alerta</title>
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
#titulo {
    color: #071456;
    font-weight: bold;
}
</style>



</head>
<body>
    <form id="form1" runat="server">
       
        <div  id="titulo2" class="row" >
     

          <div class="col-12">
            <a href="Mantenimiento.aspx">  <img height="40px" src="atras-removebg-preview.png"></a>
        </div>


     </div>

         <h1 id="titulo">Alerta para Mantenimientos</h1>
         <br />

        <div class="row">

        <div class="col-12" ><button style="background-color:#071456;color:white;width:100%" onclick="GrabarAlertas();return false;" id="btnfac" >
            Grabar Alertas</button></div>
    </div>
              <asp:HiddenField ID="HiddenTipoDocumento" runat="server" />
              <asp:HiddenField ID="HiddenFieldNro" runat="server" />
         <asp:HiddenField ID="HiddenFieldOpcion" runat="server" />

        <br />
           <div class="row">
    <div class="col-10">
        <table id="gable" class="table table-p border-bottom">
            <colgroup>
            
             </colgroup>
            <tr  style="background-color:#071456;color:white">
                <th onclick="sortTable(0)"><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>
                <th onclick="sortTable(2)"><span class="glyphicon glyphicon-sort"></span>Tlf</th>
                <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Api</th>
                
                
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

        function GrabarAlertas() {
            

            var gvET = document.getElementById("gable");

            var row;
            var column;
            var tt = "";
            var rr = new Array();
            for (row = 1; row <= gvET.rows.length - 1; row++) {

                var myData1 = {
                    "Nro": gvET.rows[row].cells[0].innerText,
                    "Tlf": gvET.rows[row].cells[1].firstElementChild.value,
                    "api": gvET.rows[row].cells[2].firstElementChild.value
                };
                rr[row - 1] = myData1;

            }

            var myData = {"lista": rr};
            var json_url = "Paginas.asmx";
            var encoded = JSON.stringify(myData);

            
            $.ajax({
                type: "POST",
                url: json_url + "/" + "GrabarAlertas",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    
                    alert("Mantenimiento Actualizado");
                    window.location.href = "Mantenimiento.aspx";
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


        document.addEventListener("DOMContentLoaded", TraeAlerta, false); // get_json_data is the function name that will fire on page load

        function TraeInfoMantenimiento() {

            var json_url = "Paginas.asmx"

            var usuario = "";

            var myData = { "Nro": document.getElementById("HiddenFieldNro").value };
            var encoded = JSON.stringify(myData);

            $.ajax({
                type: "POST",
                url: json_url + "/" + "VerMantenimientoClassPorNro",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    document.getElementById("Codigo").value = msg.d.Codigo;
                    document.getElementById("descripcion").value = msg.d.descripcion;
                    document.getElementById("descripcionservicio").value = msg.d.descripcionservicio;
                    document.getElementById("Estado").value = msg.d.Estado;


                  },
                error: function (msg) {
                    console.log('er');
                }
            });

            //var param = { prefixText: $('#myInput').val() ,count:"1"};
            //url: "Paginas.asmx/SearchCustomers",
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
        function TraeAlerta() {
           
            var json_url = "Paginas.asmx"

       
       
            $.ajax({
                type: "POST",
                url: json_url + "/" + "TraeAlerta",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    append_jsonalerta(msg);
                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });

        }

        //append_jsonitem
        function append_jsonalerta(data) {
            var table = document.getElementById('gable');

            try {
               
                //var yy = data.d
                data.d.forEach(function (object) {
                    var tr = document.createElement('tr');
                    tr.innerHTML =

                   '<td>' + object.Nro + '</td>' +
                   '<td><input value=' + object.Tlf + '></td>' +
                   '<td><input value=' + object.api + '></td>';

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

        
        function JalaAlerta() {

            var pedido = "";

            var gvET = document.getElementById("gable");
            //var fact = document.getElementById("gable2");
            

            var row;
            var column;
            var tt = "";
            var u = 0;
                //fact.rows.length - 1;

            for (row = 1; row <= gvET.rows.length - 1; row++) {

                if (gvET.rows[row].cells[0].firstElementChild.checked == true) {
                    u = u + 1;
                    var item, bienservicio, codigo, cantidad, unidad, descripcion, valorunitario,
                        preciounitario, importetotal,total;

                    codigo = gvET.rows[row].cells[1].innerText;
                    descripcion = gvET.rows[row].cells[2].innerText;

                    var row2;
                    var uu = 0;
                    //for (row2 = 1; row2 <= fact.rows.length - 1; row2++) {

                    //    if (fact.rows[row2].cells[1].innerText  == codigo )
                    //    { uu = uu + 1; }

                    //}

                    if (uu == 0) {

                        document.getElementById("Codigo").value = codigo;
                        document.getElementById("descripcion").value = descripcion;
                       // var tr = document.createElement('tr');

                       // tr.innerHTML =
                       //'<td>' +'' + '</td>' +
                       //'<td>' + codigo + '</td>' +
                       //'<td>' + descripcion + '</td>';
                       // fact.appendChild(tr);
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


   
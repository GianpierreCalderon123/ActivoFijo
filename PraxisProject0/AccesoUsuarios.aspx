<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoUsuarios.aspx.cs" Inherits="PraxisProject0.AccesoUsuarios" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta name="viewport" content="width=device-width, initial-scale=1"> 
    <title>Accesos</title>
    <style>
        #titulo {
        color:#071456
        }
        #titulo2 {
        color:#2BC2AC;
        font-size:18px;
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

                var usuario = document.getElementById("HiddenField3").value;
                console.log(usuario);

                var myData = { "usuario": usuario };
                var encoded = JSON.stringify(myData);
                //console.log(myData);
                //console.log(encoded);

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerAccesos",
                    data: encoded,
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
                console.log(data);
                var Usuario = document.getElementById('Usuario');
                Usuario.value = data.d.Usuario;

                var Contraseña = document.getElementById('Contraseña');
                Contraseña.value = data.d.Contraseña;

                var Alto = document.getElementById("Alto");
                var Bajo= document.getElementById("Bajo");

                if (data.d.Privilegio == "Alto")
                { Alto.checked = true; }
                else
                { Bajo.checked = true; }



                

                var table = document.getElementById('gable');

                try {
                    console.log(data.d);
                    console.log("1");

                    //var yy = data.d
                    data.d.Acceso.forEach(function (object) {
                        var u = true;
                        console.log(object.Acceso);
                        if (object.Acceso== "False")
                        {
                            u = 0;
                            xx = '<td><input type="checkbox" value= ' + u + ' /> </td>';
                        }

                        else
                        {
                            u = 0;
                            xx = '<td><input type="checkbox" checked= ' + u + ' /> </td>';
                        }

                        console.log(u);


                        var tr = document.createElement('tr');
                        tr.innerHTML =

                            xx +

                        '<td>' + object.Opcion + '</td>'
                        tr.style.backgroundColor = "#b8dbf6";
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
            function Grabar() {
                var r = confirm("Esta Seguro de Guardar los Cambios");

                if (r == true) {
                        grabando();

                    
                } else {

                }


            }
            function grabando()
            {

                var json_url = "Paginas.asmx"



                var gvET = document.getElementById("gable");
                var rr = new Array();
                for (row = 1; row <= gvET.rows.length - 1; row++) {
                    var myData1 = {
                        "Acceso": gvET.rows[row].cells[0].firstChild.checked,
                        "Opcion": gvET.rows[row].cells[1].innerText
                    };
                    rr[row] = myData1;

                }

                var Usuario = document.getElementById('Usuario').value;
                var Contraseña = document.getElementById('Contraseña').value;
                

                var Privilegiox = document.getElementsByName("Privilegio")

                for (var i = 0, length = Privilegiox.length; i < length; i++) {
                    if (Privilegiox[i].checked) {
                        // do whatever you want with the checked radio
                        var Privilegio = Privilegiox[i].value;

                        // only one radio can be logically checked, don't check the rest
                        break;
                    }
                }

                if (Privilegio == undefined) { alert("Seleccione Privilegio"); return; }


                var myData = {
                    "Usuario": Usuario, "Contraseña": Contraseña, "Privilegio": Privilegio, "Acceso": rr, "opcion": "U"
                };
                var myData0 = {
                    "Usuario": myData
                };

                var encoded = JSON.stringify(myData0);
                //console.log(myData);

                console.log(encoded);

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "ActualizaUsuario",
                    data: encoded,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        
                        window.location.href = "Usuarios.aspx";

                    },
                    error: function (msg) {
                        console.log('er');

                        alert(msg.d);
                        //$("#sidebar").append(msg);
                    }
                });
            }
    </script>
    <%--a--%>
    
     <script type="text/javascript">
         function Clientes() {
             var json_url = "Paginas.asmx"
             $.ajax({
                 type: "POST",
                 url: json_url + "/" + "VerClientes",
                 data: "{}",
                 contentType: "application/json; charset=utf-8",
                 dataType: "json",
                 success: function (msg) {
                     console.log('ok');
                     //append_json(msg);
                     var datos = msg.d;
                     //console.log(datos);
                     document.getElementById('languageList').innerHTML = '';
                     datos.forEach(function (object) {
                         var option = document.createElement('option');
                         //console.log(option);

                         option.value = object.Ruc_Dni;
                         option.innerHTML = object.Nombre;
                         //console.log(option);

                         $("#languageList").append(option);
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
<%--    a--%>
 
</head>
<body>

        <form id="form1" runat="server">
    <div  id="titulo2" class="row" >
        <div class="col-12">
            <a href="Usuarios.aspx">
                <img height="40px" src="atras-removebg-preview.png" />
            </a>
        </div>
     </div>
    
     <div class="row">
        <div class="col-12 " align="center" >
          
           &nbsp;</div>
     </div>
      <br />


    <div  id="titulo" class="row" align="center">
        <div class="col-12">
          
           <img align="center"  height="30"   runat="server" id="ImgFoto" src="cliente.png" alt="Foto" border="0" />Accesos</div>
     </div>
    <br />
        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-4" >Usuario</div>
            <div class="col-4" ><input class="form-control input-sm"  type="text" id="Usuario" value="" readonly="true" />
                    
             </div>
           




        </div>

            <br />
        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-4" >Contraseña</div>
            <div class="col-4" ><input class="form-control input-sm"  type="text" id="Contraseña" value="" />
                    
             </div>

        </div>
            <br />
            <div class="row" align="center">
            <div class="col-2" ></div>
            <div class="col-4" >
                <label>Privilegio  </label>
                 </div>
                <div class="col-4" >
                <input type="radio" id="Alto" name="Privilegio" value="Alto"/>
                  <label for="Alto">Alto</label>
                  <input type="radio" id="Bajo" name="Privilegio" value="Bajo"/>
                  <label for="Bajo">Bajo</label>
            </div>        
            </div>        
       
        
        <br />
        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-8" >
                 
                 <asp:Button style="background-color:#071456;color:white" ID="Button1" runat="server" Text="Grabar" OnClientClick="Grabar(); return false" OnClick="Button1_Click"  />
                 
             </div>
            
        </div>
    <br />

    <div class="row">
    <div class="col-1"></div>
    <div class="col-10">
        <table id="gable" class="table table-p border-bottom">
            <colgroup>
                <col class="ten" />
                <col class="ten" />
               
                        <col class="ten" />
            </colgroup>
            <tr style="background-color:#071456;color:white">
               
                <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Acceso</th>
                <th onclick="sortTable(1)"><span class="glyphicon glyphicon-sort"></span>Opcion</th>
               
            </tr>
        
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
        <asp:HiddenField ID="HiddenField4" runat="server" />
          <br />

 
       </div>  
</div>
             
    </form>
</body>
</html>




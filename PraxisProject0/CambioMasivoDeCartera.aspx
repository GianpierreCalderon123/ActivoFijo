<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambioMasivoDeCartera.aspx.cs" Inherits="PraxisProject0.CambioMasivoDeCartera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta name="viewport" content="width=device-width, initial-scale=1"> 

     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" >
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
   
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
                Usuarios();
            }

            function carga()
            {
                var json_url = "Paginas.asmx"
                
                var usuario = document.getElementById("usuario").value;
      

                var myData = { "usuario": usuario };
                var encoded = JSON.stringify(myData);
                //console.log(myData);
                console.log(encoded);

                $.ajax({
                    type: "POST",
                    url: json_url + "/" + "VerClientePorUsuario",
                    data: encoded,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                     
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

                table.innerHTML=
                   '  <colgroup>'+
              '  <col class="ten" />'+
               ' <col class="ten" />'+
                '<col class="ten" />'+
         '   </colgroup>'+
                '   <tr>' +
                 '      <th ><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>' +
                 '     <th ><span class="glyphicon glyphicon-sort"></span>Ruc_DNI</th>' +
                 '      <th ><span class="glyphicon glyphicon-sort"></span>Nombre</th>' +
                  ' </tr>';

                try {
                    data.d.forEach(function (object) {
                        var tr = document.createElement('tr');
                        tr.innerHTML =


                        '<td><input type="checkbox"></td> ' +
                        '<td>' + object.Ruc_Dni + '</td>' +
                         '<td>' + object.Nombre + '</td>'
                        table.appendChild(tr);
                    });
                } catch (e) {
                    console.log(e);
                }
              

             
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

                function Grabar()
                {
                    var json_url = "Paginas.asmx"

                    var Usuario = document.getElementById("usuario1").value;
              

                    var gvET = document.getElementById("gable");
                    var rr = new Array();
                    for (row = 1; row <= gvET.rows.length - 1; row++) {

                        if(gvET.rows[row].cells[0].firstChild.checked ==true)
                        {
                                 
                                    rr[row - 1] = gvET.rows[row].cells[1].innerText;
                        }
                    }


                    var myData = {
                          "Ruc_Dni": rr, "Usuario": Usuario
                    };
                    var encoded = JSON.stringify(myData);
                    //console.log(myData);
                    console.log(encoded);

                    $.ajax({
                        type: "POST",
                        url: json_url + "/" + "UpdateUsuarioClienteMasivo",
                        data: encoded,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (msg) {
                            alert(msg.d);
                            if (msg.d == "ok") {
                                window.location.href = "CambioMasivoDeCartera.aspx";
                            }
                            //$("#sidebar").append(msg);
                        },
                        error: function (msg) {
                            console.log('er');

                            //alert(msg.d);
                            //$("#sidebar").append(msg);
                        }
                    });


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
       <div  id="titulo2" class="row" >
        <div class="col-12">
            <a href="Usuarios.aspx">  <img height="40px" src="atras-removebg-preview.png" /></a>
        </div>
     </div>
        
        <div>
       <br />
        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-4" >Usuario</div>
            <div class="col-4" ><input class="form-control input-sm" type="text" id="usuario" 
                list="languageList8"  />
                 <datalist id="languageList8" >
                    </datalist>

            </div>
        </div>
        <br />
        <div class="row">
             <div class="col-2" ></div>
            <div class="col-4" >
                <button onclick="carga();return false;"> Ver Cartera </button>
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
            <tr>
                <th ><span class="glyphicon glyphicon-sort"></span>&nbsp&nbspx</th>
               <th ><span class="glyphicon glyphicon-sort"></span>Ruc_DNI</th>
                <th ><span class="glyphicon glyphicon-sort"></span>Nombre</th>
            </tr>
        
        </table>
    </div>
        </div>
              <br />
        <div class="row" align="center">
            <div class="col-2" ></div>
             <div class="col-4" >Usuario</div>
            <div class="col-4" ><input class="form-control input-sm" type="text" id="usuario1" 
                list="languageList8"  />
                 <datalist id="languageList8" >
                    </datalist>

            </div>
        </div>
        <br />

               <br />
        <div class="row">
             <div class="col-2" ></div>
            <div class="col-4" >
                <button onclick="Grabar();return false;"> Transferir Clientes </button>
            </div>
        
                 </div>
              <br />
              <br />

    </div>
    </form>
</body>
</html>

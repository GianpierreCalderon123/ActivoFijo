<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PraxisProject0.Login" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
   <title>Sistema de Gestión de Activos Fijos</title>
  <meta charset="utf-8">

<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">


<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>

    <script type="text/javascript">
        function Ingresar()
        {
           
            document.getElementById("HiddenField1").value = "Ingresar"
            document.getElementById("HiddenField2").value = document.getElementById("usuario").value
            document.getElementById("HiddenField3").value = document.getElementById("contraseña").value

        }

        function Contraseña()
        {
            
            document.getElementById("HiddenField1").value = "Contraseña"
            document.getElementById("HiddenField2").value = document.getElementById("usuario").value
            document.getElementById("HiddenField3").value = document.getElementById("contraseña").value

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">


          <asp:HiddenField ID="HiddenField1" runat="server" />
          <asp:HiddenField ID="HiddenField2" runat="server" />
          <asp:HiddenField ID="HiddenField3" runat="server" />

    
     
     
     
     <%-- <h2>Inicio de Sesion</h2>
    <div class="form-group">
      <label for="email">Usuario:</label>
      <input type="text" class="form-control" id="usuario" placeholder="Enter email">
    </div>
    <div class="form-group">
      <label for="pwd">Contraseña:</label>
      <input type="password" class="form-control" id="contraseña" placeholder="Enter password">
    </div>
      <button align="center" type="submit" class="btn btn-default" onclick="Ingresar()">Ingresar</button>
      <br />
      <br />--%>


     <div class="row">
             <div class="col-xs-12 col-sm-5 col-md-5 col-lg-5">

                 <br>
                 <br>
                 <br>

       <div class="row" style="background-color:#071456;color:#ffffff">
             <div class="col-1"></div>

                      <div class="col-10" style="text-align:left"><h2>FW Logistics</h2></div>
            

        </div>

        <div class="row" style="background-color:#b8dbf6">
             <div class="col-1"></div>

                      <div class="col-10" style="text-align:center"><h3>Control de Activos</h3></div>
            

        </div>
        
        <br>

          <div class="row">
            <div class="col-1"></div>
            <div class="col-4">Usuario</div>
            <div class="col-4"><input placeholder="usuario" style="border-radius:5px;" id="usuario"></div>

        </div>
        <br>

         <div class="row">
              <div class="col-1"></div>
            <div class="col-4">Contraseña</div>
            <div class="col-4"><input placeholder="contraseña" style="border-radius:5px;" id="contraseña" type="password">

            </div>
        </div>
        
        <br>
        <br>
          <div class="row">
             <div class="col-1"></div>
               <div class="col-10" style="text-align:center"><button style="border-radius:5px;background-color:#071456;color:white" onclick="Ingresar()">Registrar</button></div>
            

        </div>

   
<br>
                 <br>
                 <br><br><br><br><br><br><br><br>

                 
            </div>
            <div class="col-xs-12 col-sm-7 col-md-7 col-lg-7">
             
<img src="imagen activo.jpg" style="width:100%">
            </div>


            </div>



    </form>
</body>
</html>
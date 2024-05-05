<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PraxisProject0.Menu" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
   <title>Menu</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <script type="text/javascript">
       

    </script>
</head>
<body >
    <form id="form1" runat="server">
 <div class="container" align="center">
  <h2 align="center">
             <asp:HiddenField ID="HiddenField1" runat="server" />
          <asp:HiddenField ID="HiddenField2" runat="server" />
          <asp:HiddenField ID="HiddenField3" runat="server" />
     </h2>
     <h2 style="background-color:#071456;color:white">Menu</h2>
          <br />
  

      <div class="row">
                <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="Button6">
<button  onclick='window.location.href = "VerActivos.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="activo-removebg-preview.png"  style="height:30px;" />&nbsp;Registrar Activos</button>

                </div>

           <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="Button5">
<button  onclick='window.location.href = "ReporteAsignacion.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="_asig-removebg-preview.png"  style="height:30px;" />&nbsp;Reporte de Asignacion</button>

                </div>

            <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="Button1">
<button  onclick='window.location.href = "Usuarios.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="_usu-removebg-preview.png"  style="height:30px;" />&nbsp;Registrar Usuarios</button>

                </div>
</div>

     
     <br />
     <br />
      <div class="row">
          
          <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="btnmov">
<button  onclick='window.location.href = "Movimientos.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="ArrowCross.svg.png"  style="height:30px;" />&nbsp;Movimientos</button>
                </div>
         
          
           <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="btnmantenimiento">
<button  onclick='window.location.href = "Mantenimiento.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="mantenimiento-removebg-preview.png"  style="height:30px;" />&nbsp;Mantenimiento</button>
                </div>
                 
          <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="Button13">
<button  onclick='window.location.href = "Reportes.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="reporte-removebg-preview.png"  style="height:30px;" />&nbsp;Reportes</button>

                </div>

         


</div>


         <br />
      <div class="row">
          
           <div runat="server" class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="Div3">
<button  onclick='window.location.href = "default.aspx";return false;' style="width:100%;height:150px;border-radius:10px;background-color:#b8dbf6;background-image: linear-gradient(to right, #071456, #92dbeb);font-weight: bold;color:white">
<img src="salir-removebg-preview.png"  style="height:30px;" />&nbsp;Cerrar Sesion</button>

                </div>
</div>
  
    
   
</div>
        <p>
            
        </p>
    </form>
</body>
</html>
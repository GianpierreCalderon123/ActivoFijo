<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="PraxisProject0.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" >
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">

   <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script> 
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

</head>
<body>
    <form id="form1" runat="server">
    <div>
    

          <div>
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

     <div align="center">         <h4 style="color:#071456;font-weight:bold">
          
           <img align="center" height="30"   runat="server" id="ImgFoto" src="reporte-removebg-preview.png" alt="Foto" border="0" />Reportes</h4>
</div>   
</div>   
    </div>
       

        <div class="row">
            <div class="col-3">
            </div>
             <div class="col-3">
                Reporte de Activos</div>
            <div class="col-3">
                             <asp:Button style="background-color:#071456;color:white" ID="Button3" runat="server"  Text="Exportar" OnClick="Button3_Click"  />
            </div>

        </div>
         <br />

        <div class="row">
            <div class="col-3">
            </div>
             <div class="col-3">
               7.1 Detalle de los Activos Fijos Revaluados y no Revaluados.</div>
            <div class="col-3">
                             <asp:Button style="background-color:#071456;color:white" ID="Button1" runat="server"  Text="Exportar" OnClick="Button4_Click"  />
            </div>

        </div>


       
         <br />
         <div class="row">
            <div class="col-3">
            </div>
             <div class="col-3">
               Catalogo de Activos</div>
            <div class="col-3">
                             <asp:Button style="background-color:#071456;color:white" ID="Button2" runat="server"  Text="Exportar"   PostBackUrl="~/CatalogoActivos.aspx" />
            </div>

        </div>

        <br />
         <div class="row">
            <div class="col-3">
            </div>
             <div class="col-1">
              Depreciación</div>
            <div class="col-1">
                           <asp:Button style="background-color:#071456;color:white" ID="Button4" runat="server"  Text="Exportar  Data" OnClick="Button7_Click"  />

            </div>
             <div class="col-1">
                           <asp:Button style="background-color:#071456;color:white" ID="Button5" runat="server"  Text="Reporte"   PostBackUrl="~/ReporteDepreciacion.aspx" />

            </div>

        </div>
       
         <br />
        

       <%-- <div class="row">
            <div class="col-3">
            </div>
             <div class="col-3">
                Reporte de Guias de Compra
            </div>
            <div class="col-3">
                             <asp:Button ID="Button1" runat="server"  Text="Exportar" OnClick="Button4_Click"  />
            </div>

        </div>--%>






    </form>
</body>
</html>

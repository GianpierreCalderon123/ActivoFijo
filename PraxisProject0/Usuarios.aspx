<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PraxisProject0.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1"> 
    <title>Usuarios</title>
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

                    document.getElementById("HiddenField1").value = "Accesos"

                    document.getElementById("HiddenField2").value = gvET.rows[rIndex].cells[1].innerHTML
                    document.getElementById("HiddenField3").value = gvET.rows[rIndex].cells[2].innerHTML
                    //console.log(gvET.rows[rIndex].cells[0].innerHTML)

                    //gvET.rows[rIndex].cells[5].innerHTML = nuevo;

                };

            }
        }


    </script> 
     
      <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Foundation/js/foundation.min.js" type="text/javascript"></script>  
    <link href="Foundation/css/foundation.min.css" rel="stylesheet" type="text/css" />  


</head>
<body>
    <div class="below-slideshow" style="padding-bottom: 0px">
            <div class="container"> 

        <form id="form2" runat="server">

      <div  id="titulo2" class="row" >
        <div class="col-12">
            <a href="Menu.aspx">  <img height="40px" src="atras-removebg-preview.png" /></a>
        </div>
     </div>

    <div align="center">

    <div align="center">

             <div align="center">         <h4 style="color:#071456;font-weight:bold">Usuarios</h4>
       
          <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HiddenField ID="HiddenField2" runat="server" />
        <asp:HiddenField ID="HiddenField3" runat="server" />
    
      <%--   <br />
            <asp:FileUpload ID="FileUpload1" runat="server" ToolTip="Ingrese Txt con Items y caracteristicas para insertar y / o actualizar" />
         <br />
         <br />
        <asp:Button ID="Button3" runat="server" Text="Registrar y/o actualizar items" OnClick="Button3_Click" />
              <br />--%>
    

        <asp:Button ID="Button7" runat="server" Text="+ Agregar" OnClick="Button3_Click" style="background-color:#071456;color:white" />
              <br />
      <asp:Label ID="Label3" runat="server" Text="Usuario:"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Acceso">
        </asp:Label>
        <br />
        
        <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Acceso"></asp:Label>

        <asp:GridView CssClass="table table-responsive table-striped" ID="GridView1" runat="server" 
            AutoGenerateColumns="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
     <Columns>
                 <asp:TemplateField >
            <ItemTemplate>
                <asp:Button  CommandName="Select"  ID="idbtnSube" runat="server" Text="-O" OnClientClick="VerDetalle()"  />
               
           </ItemTemplate>
        </asp:TemplateField>
                
                

            </Columns>
        </asp:GridView>

           <br />
        <%--<asp:Button ID="Button1" runat="server" Text="+ Cambio Masivo Cartera" OnClick="Button1_Click" style="background-color:#071456;color:white" />--%>
              <br />
    </form>
       </div>  
</div>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargaMasivaActivos.aspx.cs" Inherits="PraxisProject0.CargaMasivaActivos" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Foundation/js/foundation.min.js" type="text/javascript"></script>  
    <link href="Foundation/css/foundation.min.css" rel="stylesheet" type="text/css" />  

    <script type="text/javascript">
        function BorrarTodo() {

            var gvET = document.getElementById("GridView3");
            var count = gvET.rows.length

            if (count > 0) {
                var r = confirm("Desea Borrar Todos los Estilos del Catalogo?");
                if (r == true) {
                    document.getElementById("HiddenField5").value = "ok";
                    document.getElementById("HiddenField3").value = "borrartodo";
                } else {
                    document.getElementById("HiddenField5").value = "";
                }
            }


        }
        function OperacionBorrar() {

            var nuevo;

            var gvET = document.getElementById("GridView3");
            var rIndex;

            for (var i = 1; i < gvET.rows.length; i++) {
                gvET.rows[i].onclick = function () {
                    // get the seected row index
                    rIndex = this.rowIndex;
                    console.log(gvET.rows[rIndex].cells[3].innerHTML);
                    document.getElementById("HiddenField4").value = gvET.rows[rIndex].cells[2].innerHTML + "|" + gvET.rows[rIndex].cells[4].innerHTML;
                    document.getElementById("HiddenField3").value = "borrar";


                    //gvET.rows[rIndex].cells[5].innerHTML = nuevo;

                };

            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button6" runat="server" Text="Maestro de Activos" PostBackUrl="~/VerActivos.aspx" />
    <div align="center">
            <h2>
     <asp:Label ID="Label5" runat="server" Text="Activos"></asp:Label>
         </h2>  
              <br />
              Carga Masiva <br />
              <br />
            <asp:FileUpload ID="FileUpload1" runat="server" ToolTip="Ingrese Txt con Estilos para Cargar Masivamente" />
         <br />
         <asp:HiddenField ID="HiddenField3" runat="server" />
              <br />
         <asp:HiddenField ID="HiddenField4" runat="server" />
              <br />
         <asp:HiddenField ID="HiddenField5" runat="server"  />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Registrar Masivamente" OnClick="Button3_Click" />
              <br />
         <br />

        <asp:GridView CssClass="table table-striped"  ID="GridView3" runat="server" Height="129px" Width="180px" ></asp:GridView>
         <br />
        <%--<asp:Button ID="Button5" runat="server" Text="Borrar Todos los Estilos" onclientclick="BorrarTodo()" OnClick="Button5_Click" />--%>
    </div>
    </form>
</body>
</html>

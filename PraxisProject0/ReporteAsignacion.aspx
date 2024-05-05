<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteAsignacion.aspx.cs" Inherits="PraxisProject0.ReporteAsignacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
        <meta name="viewport" content="width=device-width, initial-scale=1"/> 
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
	  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
   
     <script  type="text/javascript"src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	  <script  type="text/javascript"src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script> 

     <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", get_json_data, false); // get_json_data is the function name that will fire on page load
        function asignar()
        {
            document.getElementById("HiddenFieldUsuario").value = document.getElementById("Usuario").value;
                       
        
        }
        function get_json_data() {
          //  document.getElementById("r").innerText = "Reporte de Asignacion de Activos ";
                //document.getElementById("HiddenFieldCorrelativo").value;

            var json_url = "Paginas.asmx"
            var Usuario = document.getElementById("HiddenFieldUsuarioSesion").value;
            var myData = { "Usuario": Usuario };
            var encoded = JSON.stringify(myData);
            console.log(encoded);
            $.ajax({
                type: "POST",
                url: json_url + "/" + "VerUsuarioAsignados",
                data: encoded,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    console.log('ok');
                    //append_json(msg);
                    var datos = msg.d;
                    //console.log(datos);
                    document.getElementById('Usuario').innerHTML = '';
                    datos.forEach(function (object) {
                        var option = document.createElement('option');
                        //console.log(option);

                        option.value = object;
                        option.innerHTML = object;
                        //console.log(option);

                        $("#Usuario").append(option);
                    });
                  

                },
                error: function (msg) {
                    console.log('er');

                    //alert(msg.d);
                    //$("#sidebar").append(msg);
                }
            });

        }
       
    </script>
      <script type="text/javascript">
         
          function printReport(report_ID) {

              var rv1 = $('#' + report_ID);
              var iDoc = rv1.parents('html');

              // Reading the report styles
              var styles = iDoc.find("head style[id$='ReportControl_styles']").html();
              if ((styles == undefined) || (styles == '')) {
                  iDoc.find('head script').each(function () {
                      var cnt = $(this).html();
                      var p1 = cnt.indexOf('ReportStyles":"');
                      if (p1 > 0) {
                          p1 += 15;
                          var p2 = cnt.indexOf('"', p1);
                          styles = cnt.substr(p1, p2 - p1);
                      }
                  });
              }
              if (styles == '') { alert("Cannot generate styles, Displaying without styles.."); }
              styles = '<style type="text/css">' + styles + "</style>";

              // Reading the report html
              var table = rv1.find("div[id$='_oReportDiv']");
              if (table == undefined) {
                  alert("Report source not found.");
                  return;
              }

              // Generating a copy of the report in a new window
              var docType = '<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/loose.dtd">';
              var docCnt = styles + table.parent().html();
              var docHead = '<head><title>Printing ...</title><style>body{margin:5;padding:0;}</style></head>';
              var winAttr = "location=yes, statusbar=no, directories=no, menubar=no, titlebar=no, toolbar=no, dependent=no, width=720, height=600, resizable=yes, screenX=200, screenY=200, personalbar=no, scrollbars=yes";;
              var newWin = window.open("", "_blank", winAttr);
              writeDoc = newWin.document;
              writeDoc.open();
              writeDoc.write(docType + '<html>' + docHead + '<body onload="window.print();">' + docCnt + '</body></html>');
              writeDoc.close();

              // The print event will fire as soon as the window loads
              newWin.focus();
              // uncomment to autoclose the preview window when printing is confirmed or canceled.
              // newWin.close();

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


        <div class="row" align="center">
            <div class="col-4">
                </div>
            <div class="col-4">
              
                     <div align="center">         <h4 style="color:#071456;font-weight:bold">Reporte de Asignación de Activos</h4>
            </div>
                </div>
        </div>
       
                     <div class="row" align="center">
              <div class="col-4">
                </div>
            <div class="col-4">
                                               <label>Usuario:</label>
                                    <select id="Usuario">  </select>
                    </div>
                         </div>
        <br />
        <div class="row" align="center">
              <div class="col-4">
                </div>
            <div class="col-4">
                                          <asp:Button style="background-color:#071456;color:white" ID="Button1" runat="server"  onclientClick="asignar()" Text="Ver Reporte" OnClick="Button1_Click" />

                    </div>
              <div class="col-4">
                    <button style="background-color:#071456;color:white" onclick="printReport('ReportViewer1');"   >Imprimir</button>                      
                    </div>
                         </div>
        
        
        <br />
        <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </div>

        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" 
            WaitMessageFont-Size="14pt" 
            
             Width="100%">
            </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" 
            TypeName="PraxisProject0.PraxyEcologyDataDataSetTableAdapters.VerHojaControlReporteTableAdapter"></asp:ObjectDataSource>
      
    
     <asp:HiddenField ID="HiddenFieldCorrelativo" runat="server" />
             <asp:HiddenField ID="HiddenFieldResiduo" runat="server" />

          <asp:HiddenField ID="HiddenFieldUsuario" runat="server" />
        <asp:HiddenField ID="HiddenFieldUsuarioSesion" runat="server" />

                     <asp:HiddenField ID="HiddenField1" runat="server" />
    </form>

    
       
</body>
</html>

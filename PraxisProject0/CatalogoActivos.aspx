<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoActivos.aspx.cs" Inherits="PraxisProject0.CatalogoActivos" %>


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
            <a href="Reportes.aspx">  <img height="40px" src="atras-removebg-preview.png" /></a>
        </div>
     </div>


        <div class="row" align="center">
            <div class="col-4">
                </div>
            <div class="col-4">
                <label id="r">Cátalogo de Activos</label>
            </div>
            
        </div>
        <br />
            
          <asp:Button style="background-color:#071456;color:white"  ID="Button1" runat="server"   Text="Ver Reporte" OnClick="Button1_Click" />
           <br />
        <br />
        <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </div>

        

     
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="ReportCatalogo.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>

        
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" TypeName="VacunaProject0.PraxyEcologyDataDataSetTableAdapters.VerActivoCatalogoTableAdapter"></asp:ObjectDataSource>

     
    </form>

    
       
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoImpresionOrdenCompra.aspx.cs" Inherits="PraxisProject0.DemoImpresionOrdenCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- Use only one Bootstrap CSS link -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />

    <!-- Use only one jQuery script reference -->
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <!-- Use only one Bootstrap JS link -->
    <script type="text/javascript" src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>

    <script src="JsBarcode.js"></script>
    <script src="JsBarcode.all.js"></script>
    <script src="JsBarcode.all.min.js"></script>
    <script src="JsBarcode.all.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="row">
            </div>

            <div class="row">
                <div class="col-1"></div>
                <div class="col-2"><h2>Impresión de Ordenes de Compra Por OC</h2></div>
            </div>

            <div class="row">
                <div class="col-1"></div>
                <div class="col-2">Orden de Compra</div>
                <div class="col-2"><input id="oc" onchange="mostrarDatatable();return false;" /></div>

            </div>

              <div class="row">
                <div class="col-1"></div>
                <div class="col-2"><h5>Pruebe con los siguientes ejemplos: 4500091764  -   4500092169   -   4500092253</h5></div>
            </div>
             <div class="row">
                <div class="col-1"></div>
                <div class="col-2"><button onclick="printPreview();return false;"> Imprime</button></div>
            </div>


                

                <div class="row">
                <div class="col-1"></div>
                <div class="col-10"> <div class="row" id="datatable-container"></div></div>
               
            </div>
           

        </div>


                <div class="modal fade" id="printPreviewModal" tabindex="-1" role="dialog" aria-labelledby="printPreviewModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="printPreviewModalLabel">Prevista de Impresión</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body" id="printPreviewContent">
                        <!-- The preview content will be added here -->
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick="printBarcode()">Imprimir</button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>

        <script>
          
                // Función para mostrar el datatable con los valores correspondientes
                function mostrarDatatable() {

                    var oc = document.getElementById("oc").value;
                    // Verificar el valor de "oc" y mostrar el datatable correspondiente
                    if (oc === "4500091764") {
                        var data = [
                            { codigo: '010-08927', descripcion: 'PERNO ALLEN CAB. PLANA M5 X 40 ROSCA CORRIDA' },
                            { codigo: '010-08928', descripcion: 'PERNO ALLEN CAB. REDONDA M5 X 40 R. CORRIDA' },
                            { codigo: '010-05614', descripcion: 'PERNO AC INOX ALLEN M5 X 10MM' },
                            { codigo: '010-02047', descripcion: 'PERNO ALLEN CAB. PLANA M5 X 30MM' },
                            { codigo: '010-01985', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 1.1/4"' },
                            { codigo: '010-01904', descripcion: 'PERNO ALLEN PRISIONERO 6-32 x 3/16"' },
                            { codigo: '010-01926', descripcion: 'PERNO ALLEN PRISIONERO 1/4 -20 NC 1/4"' },
                            { codigo: '010-01927', descripcion: 'PERNO ALLEN PRISIONERO 1/4-20 UNC 1/2"' },
                            { codigo: '010-01987', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 1/2"' },
                            { codigo: '010-01988', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 2"' }
                        ];
                        var datatable = "<table class='table'>";
                        datatable += "<thead><tr><th>Código</th><th>Descripción</th><th>Cod Barras</th><th>Cantidad</th><th>Tamaño</th></tr></thead>";
                        datatable += "<tbody>";
                        data.forEach(function (item) {
                            datatable += "<tr><td>" + item.codigo + "</td><td>" + item.descripcion + "</td><td><svg class='barcode-svg'></svg></td><td><input value='1'></input></td><td><select class='form-control'><option value='pequeño'>Pequeño</option><option value='mediano'>Mediano</option><option value='grande'>Grande</option></select></td></tr>";
                        });
                        datatable += "</tbody></table>";
                        $("#datatable-container").html(datatable);
                    } else if (oc === "4500092169") {
                        var data = [
                            { codigo: '011-11298', descripcion: 'MANGUERA HIDRAULICA 100 R2 DE 3/4" DIAM. X 70 CM. CONEXIÓN HEMBRA RECTA JIC AMBOS LADOS' },
                            { codigo: '010-08904', descripcion: 'ADAPTADOR CODO 90° MACHO 3/4 JIC 3/4 NPT' },
                            { codigo: '009-00730', descripcion: 'FIELTRO 3/8 " x 1 x 1 M' },
                            { codigo: '008-00084', descripcion: 'MANGUILLA SOLDADOR CUERO CROMO' },
                            { codigo: '010-08914', descripcion: 'MANGUERA MELLIZA PARKER 1/4" DIAM.' }
                        ];
                        var datatable = "<table class='table'>";
                        datatable += "<thead><tr><th>Código</th><th>Descripción</th><th>Cod Barras</th><th>Cantidad</th><th>Tamaño</th></tr></thead>";
                        datatable += "<tbody>";
                        data.forEach(function (item) {
                            datatable += "<tr><td>" + item.codigo + "</td><td>" + item.descripcion + "</td><td><svg class='barcode-svg'></svg></td><td><input value='1'></input></td><td><select class='form-control'><option value='pequeño'>Pequeño</option><option value='mediano'>Mediano</option><option value='grande'>Grande</option></select></td></tr>";
                        });
                        datatable += "</tbody></table>";
                        $("#datatable-container").html(datatable);
                    } else if (oc === "4500092253") {
                        var data = [
                            { codigo: '010-08927', descripcion: 'PERNO ALLEN CAB. PLANA M5 X 40 ROSCA CORRIDA' },
                            { codigo: '010-08928', descripcion: 'PERNO ALLEN CAB. REDONDA M5 X 40 R. CORRIDA' },
                            { codigo: '010-05614', descripcion: 'PERNO AC INOX ALLEN M5 X 10MM' },
                            { codigo: '010-02047', descripcion: 'PERNO ALLEN CAB. PLANA M5 X 30MM' },
                            { codigo: '010-01985', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 1.1/4"' },
                            { codigo: '010-01904', descripcion: 'PERNO ALLEN PRISIONERO 6-32 x 3/16"' },
                            { codigo: '010-01926', descripcion: 'PERNO ALLEN PRISIONERO 1/4 -20 NC 1/4"' },
                            { codigo: '010-01927', descripcion: 'PERNO ALLEN PRISIONERO 1/4-20 UNC 1/2"' },
                            { codigo: '010-01987', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 1/2"' },
                            { codigo: '010-01988', descripcion: 'PERNO ALLEN 1/4-20 UNRC x 2"' }
                        ];
                        var datatable = "<table class='table'>";
                        datatable += "<thead><tr><th>Código</th><th>Descripción</th><th>Cod Barras</th><th>Cantidad</th><th>Tamaño</th></tr></thead>";
                        datatable += "<tbody>";
                        data.forEach(function (item) {
                            datatable += "<tr><td>" + item.codigo + "</td><td>" + item.descripcion + "</td><td><svg class='barcode-svg'></svg></td><td><input value='1'></input></td><td><select class='form-control'><option value='pequeño'>Pequeño</option><option value='mediano'>Mediano</option><option value='grande'>Grande</option></select></td></tr>";
                        });
                        datatable += "</tbody></table>";
                        $("#datatable-container").html(datatable);
                    } else {
                        // Si "oc" no coincide con ningún valor, vaciar el datatable
                        $("#datatable-container").empty();
                    }

                    $("#datatable-container").find("table tbody tr").each(function () {
                        var firstColumnValue = $(this).find("td:first-child").text();
                        var secondColumnValue = $(this).find("td:nth-child(2)").text();


                        console.log(firstColumnValue);

                        var targetSVG = $(this).find(".barcode-svg")[0];
                        generateBarcode(firstColumnValue,secondColumnValue, targetSVG);
                    }); 
                }



                function generateBarcode(value, description, targetSVG, size) {
                    // Generamos el código de barras con JsBarcode y lo agregamos al elemento SVG correspondiente
                    JsBarcode(targetSVG, value, {
                        format: "CODE128", // Puedes ajustar el formato del código de barras si lo necesitas
                        displayValue: false // Ocultamos el valor numérico del código de barras
                    });

                    // Tamaño del código de barras según el valor seleccionado
                    var barcodeHeight = "80"; // Tamaño por defecto
                    if (size === "mediano") {
                        barcodeHeight = "100";
                    } else if (size === "grande") {
                        barcodeHeight = "140";
                    }
                    targetSVG.setAttribute("height", barcodeHeight);

                    var codeTextElement = document.createElementNS("http://www.w3.org/2000/svg", "text");
                    codeTextElement.setAttribute("x", "50%");
                    codeTextElement.setAttribute("y", "100%");
                    codeTextElement.setAttribute("text-anchor", "middle");
                    codeTextElement.setAttribute("textLength", "90%"); // Adjust the text length based on your preference
                    codeTextElement.setAttribute("lengthAdjust", "spacingAndGlyphs");
                    codeTextElement.textContent = value;
                    targetSVG.appendChild(codeTextElement);

                    // Calculate the spacing between code and description (1.5em = font-size + additional spacing)
                    var spacing = 1.5; // You can adjust this value based on your preference

                    // Add the description below the code using SVG text element
                    var descTextElement = document.createElementNS("http://www.w3.org/2000/svg", "text");
                    descTextElement.setAttribute("x", "50%");
                    descTextElement.setAttribute("y", "100%");
                    descTextElement.setAttribute("dy", spacing + "em"); // Add spacing below the code
                    descTextElement.setAttribute("text-anchor", "middle");
                    descTextElement.setAttribute("textLength", "90%"); // Adjust the text length based on your preference
                    descTextElement.setAttribute("lengthAdjust", "spacingAndGlyphs");
                    descTextElement.textContent = description;
                    targetSVG.appendChild(descTextElement);
                }

                function printPreview() {
                    try {
                        var previewContent = "";

                        var rows = document.querySelectorAll("#datatable-container table tbody tr");
                        rows.forEach(function (row) {
                            var inputs = row.querySelectorAll("input");
                            var quantity = parseInt(inputs[0].value);

                            var code = row.querySelector("td:nth-child(1)").innerText;
                            var description = row.querySelector("td:nth-child(2)").innerText;

                            // Get the selected size value from the ComboBox
                            var sizeSelect = row.querySelector("select");
                            var selectedSize = sizeSelect.value;

                            // Generate the barcode with proper quantity and size and add to the preview content
                            var barcodeElement = document.createElement("div");
                            for (var i = 0; i < quantity; i++) {
                                var barcodeSVG = document.createElementNS("http://www.w3.org/2000/svg", "svg");
                                barcodeSVG.setAttribute("class", "barcode-svg");

                                // Generate a unique ID for each SVG element
                                var uniqueId = "barcode-" + code + "-" + i;
                                barcodeSVG.setAttribute("id", uniqueId);

                                generateBarcode(code, description, barcodeSVG, selectedSize);
                                barcodeElement.appendChild(barcodeSVG);
                            }
                            previewContent += barcodeElement.innerHTML;
                        });

                        // Add the preview content to the modal body
                        var printPreviewContent = document.getElementById("printPreviewContent");
                        printPreviewContent.innerHTML = previewContent;

                        // Show the modal
                        $("#printPreviewModal").modal("show");
                    } catch (e) {
                        console.log(e.message);
                    }
                }

                function showPrintPreview(content) {
                    $("#printPreviewContent").html(content);
                    $("#printPreviewModal").modal("show");
                }
                function printBarcode() {
                    var content = $("#printPreviewContent").html();
                    var myWindow = window.open("", "Print", "width=800,height=600");
                    myWindow.document.write('<html><head><title>Print</title></head><body>');
                    myWindow.document.write(content);
                    myWindow.document.write('</body></html>');
                    myWindow.document.close();
                    myWindow.focus();
                    myWindow.print();
                    myWindow.close();
                }
                //// Detectar el cambio en el input con id "oc"
                //$("#oc").on("change", function () {
                //    var ocValue = $(this).val();
                //    mostrarDatatable(ocValue);
        
        </script>
    </form>
</body>
</html>

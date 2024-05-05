<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p0.aspx.cs" Inherits="PraxisProject0.p0" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script type="text/javascript">
        function PrintDiv() {
            var contents = document.getElementById("dvContents").innerHTML;
            var frame1 = document.createElement('iframe');
            frame1.name = "frame1";
            frame1.style.position = "absolute";
            frame1.style.top = "-1000000px";
            document.body.appendChild(frame1);
            var frameDoc = frame1.contentWindow ? frame1.contentWindow : frame1.contentDocument.document ? frame1.contentDocument.document : frame1.contentDocument;
            frameDoc.document.open();
            frameDoc.document.write('<html><head><title>DIV Contents</title>');
            frameDoc.document.write('</head><body>');
            frameDoc.document.write(contents);
            frameDoc.document.write('</body></html>');
            frameDoc.document.close();
            setTimeout(function () {
                window.frames["frame1"].focus();
                window.frames["frame1"].print();
                document.body.removeChild(frame1);
            }, 500);
            return false;
        }

        function Export2Doc(){
            var preHtml = "<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:w='urn:schemas-microsoft-com:office:word' xmlns='http://www.w3.org/TR/REC-html40'><head><meta charset='utf-8'><title>Export HTML To Doc</title></head><body>";
            var postHtml = "</body></html>";
            var html = preHtml+document.getElementById("dvContents").innerHTML+postHtml;

            var blob = new Blob(['ufeff', html], {
                type: 'application/msword'
            });
    
            // Specify link url
            var url = 'data:application/vnd.ms-word;charset=utf-8,' + encodeURIComponent(html);
    
            var filename="prueba";

            // Specify file name
            filename = filename?filename+'.doc':'document.doc';
    
            // Create download link element
            var downloadLink = document.createElement("a");

            document.body.appendChild(downloadLink);
    
            if(navigator.msSaveOrOpenBlob ){
                navigator.msSaveOrOpenBlob(blob, filename);
            }else{
                // Create a link to the file
                downloadLink.href = url;
        
                // Setting the file name
                downloadLink.download = filename;
        
                //triggering the function
                downloadLink.click();
            }
    
            document.body.removeChild(downloadLink);
        }

        function Export3Doc() {
            var preHtml = "<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:w='urn:schemas-microsoft-com:office:excel' xmlns='http://www.w3.org/TR/REC-html40'><head><meta charset='utf-8'><title>Export HTML To Doc</title></head><body>";
            var postHtml = "</body></html>";
            var html = preHtml + document.getElementById("dvContents").innerHTML + postHtml;

            var blob = new Blob(['ufeff', html], {
                type: 'application/msword'
            });

            // Specify link url
            var url = 'data:application/vnd.ms-excel;charset=utf-8,' + encodeURIComponent(html);

            var filename = "prueba";

            // Specify file name
            filename = filename ? filename + '.xls' : 'document.xls';

            // Create download link element
            var downloadLink = document.createElement("a");

            document.body.appendChild(downloadLink);

            if (navigator.msSaveOrOpenBlob) {
                navigator.msSaveOrOpenBlob(blob, filename);
            } else {
                // Create a link to the file
                downloadLink.href = url;

                // Setting the file name
                downloadLink.download = filename;

                //triggering the function
                downloadLink.click();
            }

            document.body.removeChild(downloadLink);
        }
    </script>
</head>
<body>
    <form id="form1">
    <span style="font-size: 10pt; font-weight: bold; font-family: Arial">ASPSnippets.com
        Sample page</span>
    <hr />
    <div id="dvContents" style="border: 1px dotted black; padding: 5px; width: 300px">
        <span style="font-size: 10pt; font-weight: bold; font-family: Arial">Hello,
            <br />
            This is <span style="color: #18B5F0">Mudassar Khan</span>.<br />
            Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!Hoping that you are enjoying my articles!</span>
    </div>
    <br />
    <input type="button" onclick="PrintDiv();" value="Print" />
    <input type="button" onclick="Export2Doc();" value="Word" />
    <input type="button" onclick="Export3Doc();" value="Excel" />

        
    </form>
</body>
</html>
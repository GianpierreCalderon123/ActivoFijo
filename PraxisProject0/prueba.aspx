<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="PraxisProject0.prueba" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <title></title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        #autocomplete-list {
            display: none;
            border: 1px solid #ccc;
            max-height: 150px;
            overflow-y: auto;
        }
    </style>
    <script>
        function llena() {


            

            var json ; // Replace with your JSON data


            if (input.value.toLowerCase.length < 3) {
                json = '[{"id":1,"nombre":"gian"},{"id":2,"nombre":"gian 2"}]';
            }
            else {
                json = "";
            }

            var options = JSON.parse(json);
            var inputValue = input.value.toLowerCase();
            var matchedOptions = options.filter(function (option) {
                return option.nombre.toLowerCase().indexOf(inputValue) !== -1;
            });

            if (inputValue.length >= 3 && matchedOptions.length > 0) {
                autocompleteList.innerHTML = '';

                matchedOptions.forEach(function (option) {
                    var optionElement = document.createElement('div');
                    optionElement.textContent = option.nombre;
                    optionElement.addEventListener('click', function () {
                        input.value = option.id;
                        inputName.value = option.nombre;
                        autocompleteList.innerHTML = '';
                    });
                    autocompleteList.appendChild(optionElement);
                });

                autocompleteList.style.display = 'block';
            } else {
                autocompleteList.style.display = 'none';
            }
        }
    </script>
</head>

<body>
    <input type="text" id="myInput" placeholder="Type something..." onkeyup="llena()">
    <input type="text" id="myInputName">
    <div id="autocomplete-list"></div>
</body>

</html>


<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="PraxisProject0.prueba" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <title></title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
    #autocomplete-list {
  display: none;
  border: 1px solid #ccc;
  max-height: 150px;
  overflow-y: auto;
}

    </style>
    <script>
      

        function llena() {
            var input = document.getElementById('myInput');
            var autocompleteList = document.getElementById('autocomplete-list');

            var options;

            if (input.value.toLowerCase.length < 3) {
                options = ['Option 1', 'Option 2', 'Option 3', 'Option 4', 'Option 5', 'Option 6', 'Option 7', 'Option 8', 'Option 9']; // Replace with your own options

            }
            else {
                
            }

            var inputValue = input.value.toLowerCase();
            var matchedOptions = options.filter(function (option) {
                return option.toLowerCase().indexOf(inputValue) !== -1;
            });


            if (inputValue.length >= 3 && matchedOptions.length > 0) {
                autocompleteList.innerHTML = '';

                matchedOptions.forEach(function (option) {
                    var optionElement = document.createElement('div');
                    optionElement.textContent = option;
                    optionElement.addEventListener('click', function () {
                        input.value = option;
                        autocompleteList.innerHTML = '';
                    });
                    autocompleteList.appendChild(optionElement);
                });

                autocompleteList.style.display = 'block';
            } else {
                autocompleteList.style.display = 'none';
            }
        }

    </script>
</head>

<body>
  
   <input type="text" id="myInput" placeholder="Type something..." onkeyup="llena()">
    <div id="autocomplete-list"></div>


</body>

</html>--%>
$(document).ready(function () {

    //Método que carga por medio de AJAX el formulario NuevoCliente en la ventana modal 
    $("#nuevoCliente").click(function () {
        $(".modal-content").load("home/nuevoCliente");
    });

    //Método que carga por medio de AJAX el formulario EditaCliente en la ventana modal
    $(".btn-warning").click(function () {
        $(".modal-content").load("home/nuevoCliente/" + $(this).data("id"));
    });

    //Método que carga por medio de AJAX el formulario EliminaCliente en la ventana modal
    $(".btn-danger").click(function () {
        $(".modal-content").load("home/eliminaCliente/" + $(this).data("id"));
    });

    //Capta el Objeto JSON que viene del controlador y lo manipula para crear la tabla con cada uno de los registros
    $("#consulta1").click(function () {
        $.getJSON(
            'home/QueryClienteCiudad',
            function (data) {
                $.each(data, function(i, item){
                    $("#cuerpo1").append("<tr><td>"+ item.DNI +"</td><td>"+ item.Nombres +"</td><td>"+ item.Sede +"</td><td>"+ item.Ciudad +"</td></tr>");
                });  
            }
        );
        $("#tabla1").show();
    });

    //Capta el Objeto JSON que viene del controlador y lo manipula para crear la tabla con cada uno de los registros
    $("#consulta2").click(function () {
        $.getJSON(
            'home/QueryTopClientes',
            function (data) {
                $.each(data, function (i, item) {
                    $("#cuerpo2").append("<tr><td>" + item.Cedula + "</td><td>" + item.Nombres + "</td><td>"+ item.Valor +"</td><td>" + item.Sede + "</td><td>" + item.Ciudad + "</td></tr>");
                });
            }
        );
        $("#tabla2").show();
    });
});
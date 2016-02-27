$(document).ready(function () {
    //Método Invoca la ventana modal para ingresar al sistema
    $("a.item").click(function () {
        var texto = $(this).html();
        if (texto == "Log In")
        {
            $("#modal1").modal("show");
            $(".content").load("/Home/Ingresar");
        }else if (texto == "Log Out")
        {
            location.href = "/Home/Salir";
        }
        
    });

    //Método consulta los datos registrados en el login y devulve objeto JSON con respuesta
    $("#Entrar").click(function () {

        $("#ingForm").addClass("loading");
        var datos = $("#IngForm").serialize();

        $.ajax({
            url: "http://localhost:51044/home/ConsultaIngreso",
            data: datos,
            type: "POST",
            datatype:"json",
            success: function (data) {
                if (data != "")
                {
                    location.href = "/Home/IndexVal";
                } else
                {
                    $("#ingForm").removeClass("loading");
                    $("#mensaje").css("visibility", "visible");
                }
            },
            fail: function (mensaje) {
                alert("Error");
            }
        });
    });

    //Método invoca ventana modal para crear nuevo cliente
    $(".inverted").click(function () {
        $("#modal2").load("http://localhost:51044/Cliente/NuevoCliente");
        $("#modal2").modal("show");
    });

    //Método invoca ventana modal para editar un cliente
    $(".yellow").click(function () {
        alert("Presion2");
        $("#modal2").load("http://localhost:51044/Cliente/EditaCliente/" + $(this).data("id"));
        $("#modal2").modal("show");
    });

    //Método invoca ventana modal para eliminar un cliente
    $(".red").click(function () {
        $("#modal2").load("http://localhost:51044/Cliente/EliminaCliente/" + $(this).data("id"));
        $("#modal2").modal("show");
    });
});

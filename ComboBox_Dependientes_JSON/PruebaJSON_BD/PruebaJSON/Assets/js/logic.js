$(document).ready(function () {
    $("#dpContinente").change(function () {
        var continente = $(this).val();

        if(continente != "")
        {
            $.getJSON(
                'http://localhost:59039/home/getPaises/' + continente,
                function (data) {
                    $("#dpPais").empty();
                    $("#dpPais").append("<option> Seleccione... </option>");
                    $.each(data, function (i, item) {
                        $("#dpPais").append("<option id='"
                       + item.id_Pais + "'>" + item.Nombre
                       + "</option>");
                    });
                }
            );
        }

    });
});
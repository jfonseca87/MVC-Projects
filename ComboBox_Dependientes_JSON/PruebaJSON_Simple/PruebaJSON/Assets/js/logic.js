$(document).ready(function () {
    $("#dpContinente").change(function () {
        var continente = $(this).val();

        if(continente != "")
        {
            $("#dpPais").empty();
            $("#dpPais").append("<option> Seleccione... </option>");
            $.getJSON(
                'http://localhost:59039/home/getPaises/' + continente,
                function (data) {
                    $.each(data, function (i, item) {
                        $("#dpPais").append("<option id='"
                       + item.Pais_Id + "'>" + item.NPais
                       + "</option>");
                    });
                }
            );
        }

    });
});
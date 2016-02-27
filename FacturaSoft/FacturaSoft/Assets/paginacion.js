//Método para cargar la tabla con los registros de los clientes
//$(".page-number").click(function () {
//    var page = parseInt($(this).html());
//    $("#registros").load("/cliente/clientelist/" + page);
//});

//<script type="text/javascript">
    $(document).ready(function () {
        $(".page-number").click(function () {
            var page = parseInt($(this).html());

            $("#registros").load("/Cliente/ClienteList/"+ page);

            //$.ajax({
            //    url: '@Url.Action("http://localhost:51044/Cliente/ClienteList")',
            //    data: { "id": page },
            //    success: function (data) {
            //        $("#registros").html(data);
            //    }
            //});

        });
    });
//</script>
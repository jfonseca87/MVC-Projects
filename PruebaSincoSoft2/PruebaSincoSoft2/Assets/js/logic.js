$(document).ready(function () {

    var valor = 0;

    //Método que consulta el valor delarticulo que se selecciona
    $("#dpProducto").change(function () {
        var id = $(this).val();
        
        if(id != "")
        {
            $.getJSON(
                '/Home/getValorUnitario/'+ id,
                function (data) {
                    $("#PedVrUnit").empty();
                    $.each(data, function (i, item) {
                        $("#PedVrUnit").val(item.ProValor);
                        valor = item.ProValor
                    });
                }
            )
        }
    });

    //Método que realiza los calculos necesarios para el subtotal y total
    $("#PedCant").blur(function () {
        var subTotal = valor * $(this).val();
        var IVA = subTotal * 0.16;
        var Total = subTotal + IVA;

        alert("SubTotal: " + subTotal + " IVA: " + IVA + " Total: " + Total);

        $("#PedIVA").val(IVA);
        $("#PedSubTot").val(subTotal);
        $("#PedTotal").val(Total);
    });

});
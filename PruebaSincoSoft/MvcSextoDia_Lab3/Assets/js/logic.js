$(document).ready(function () {
    var valor = 0;
    $("#dpProduct").change(function () {
        var producto = $(this).val();

        if (producto != "")
        {
            $.getJSON(
                'http://localhost:51284/home/getValorUnitario/' + producto,
                function(data)
                {
                    $("#valUnit").empty();
                    $.each(data, function (i, item) {
                        $("#txtValUnit").val(item.Amount);
                        valor = item.Amount;
                    });
                }
            )
        }
    });

    $("#txtCantidad").on("blur", function () {
        var cantidad = $(this).val();
        var subTotal = valor * cantidad;
        var IVA = subTotal * 0.16;
        var Total = subTotal + IVA;
       
        $("#txtSubtotal").val(subTotal);
        $("#txtIVA").val(IVA);
        $("#txtTotal").val(Total);
    });
});
$(document).ready(function () {
    $("#frmProduct").submit(function (e) {
        
        var Codigo = $("#txtCode").val();
        var Nombre = $("#txtName").val();
        var Amount = $("#txtVal").val();

        if (Codigo == "" || Nombre == "" || Amount == "") {
            e.preventDefault();
            if (Codigo == "") {
                $("#Codigo").css("visibility", "visible");
            } else
            {
                $("#Codigo").css("visibility", "hidden");
            }
            if (Nombre == "") {
                $("#Nombre").css("visibility", "visible");
            } else {
                $("#Nombre").css("visibility", "hidden");
            }
            if (Amount == "") {
                $("#Monto").css("visibility", "visible");
            } else {
                $("#Monto").css("visibility", "hidden");
            }
        } else {
            $("#Codigo").css("visibility", "hidden");
            $("#Nombre").css("visibility", "hidden");
            $("#Monto").css("visibility", "hidden");
        }; 
    });

    $("#frmCustomer").submit(function (e) {

        var Codigo = $("#txtCode").val();
        var Nombre = $("#txtName").val();
        var Amount = $("#txtAmount").val();

        if (Codigo == "" || Nombre == "" || Amount == "") {
            e.preventDefault();
            if (Codigo == "") {
                $("#Codigo").css("visibility", "visible");
            } else {
                $("#Codigo").css("visibility", "hidden");
            }
            if (Nombre == "") {
                $("#Nombre").css("visibility", "visible");
            } else {
                $("#Nombre").css("visibility", "hidden");
            }
            if (Amount == "") {
                $("#Monto").css("visibility", "visible");
            } else {
                $("#Monto").css("visibility", "hidden");
            }
        } else {
            $("#Codigo").css("visibility", "hidden");
            $("#Nombre").css("visibility", "hidden");
            $("#Monto").css("visibility", "hidden");
        };
    });
});
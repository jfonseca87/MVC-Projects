$(document).ready(function () {
    $(".btn-primary").click(function () {
        $("#myModalLabel").html("New Person");
        $(".modal-body").load("http://localhost:49631/Home/InsertPeople");
    });

    $(".btn-warning").click(function () {
        $("#myModalLabel").html("Edit Person");
        $(".modal-body").load("http://localhost:49631/Home/EditPeople/" + $(this).data("id"));
    });

    $(".btn-danger").click(function () {
        $(".modal-body").load("http://localhost:49631/Home/DeletePeople/" + $(this).data("id"));
    });
});
$(document).ready(function () {
    $("#MyTable").hide(function () {
        $("#ver").click(function () {
            $("#MyTable").slideDown("slow", function () {
                $("#MyTable").show(function () {
                    $("#MyTable").DataTable(function () {
                        $("#MyTable").dataTable();
                    });
                });    
            });
        });
    });
});


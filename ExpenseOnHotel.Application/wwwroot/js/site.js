const emptyGuid = "00000000-0000-0000-0000-000000000000";

jQuery.ajaxSetup({
    beforeSend: function () {
        $("#loader-wrapper").css("visibility", "visible");
    },
    complete: function () {
        $("#loader-wrapper").css("visibility", "hidden");
    },
    success: function () { }
});

const modal = new bootstrap.Modal(document.getElementById('modalEditor'), {
    keyboard: true
});

$('#modalEditor').on('hidden.bs.modal', function (e) {
    window.location.reload();
})


function OpenModal(title, url) {
    $('#partial').load(url);
    $("#modalHeader").text(title);
    modal.show();
}

function CloseModal() {
    modal.hide();
}
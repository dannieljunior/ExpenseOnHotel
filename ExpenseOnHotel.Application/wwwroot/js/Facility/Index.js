function Delete(id) {
    $.ajax({
        type: 'POST',
        url: 'Facility/Delete/',
        data: {id: id}
    }).done(function (response) {
        if (response.sucesso === true) {
            window.location.reload();
            alert(response.message);
        }
        else {
            $.toaster(response.message, 'Erro', 'danger');
        }
    });
}
$("#frm").submit(function () {
    event.preventDefault();

    var url = $("#frm").attr("action");

    var formData = new FormData();

    formData.append("Id", $("#Id").val());
    formData.append("Description", $("#Description").val());
    formData.append("Icon", $("#Icon").val());

    $.ajax({
      type: 'POST',
      url: url,
      data: formData,
      processData: false,
      contentType: false
    }).done(function (response) {
      if (response.sucesso === true) {
        $.toaster(response.message, 'Sucesso', 'success');
        $("#Id").val(response.uid);
      }
      else {
        $.toaster(response.message, 'Erro', 'danger');
      }
    });
  });
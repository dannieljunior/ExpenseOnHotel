$("#frm").submit(function () {
    event.preventDefault();
    
    var url = $("#frm").attr("action");

    var formData = new FormData();

    formData.append("Id", $("#Id").val());
    formData.append("Name", $("#Name").val());
    formData.append("Description", $("#Description").val());
    formData.append("Address", $("#Address").val());
    formData.append("AddressComplement", $("#AddressComplement").val());
    formData.append("AddressPostalCode", $("#AddressPostalCode").val());
    formData.append("AddressDistrict", $("#AddressDistrict").val());
    formData.append("AddressCity", $("#AddressCity").val());
    formData.append("AddressState", $("#AddressState").val());

    var hotelFaciltiesToAdd = hotelFacilities.filter((x) => x.Id === "");

    for (var index = 0; index < hotelFaciltiesToAdd.length; index++) {
        formData.append(`Facilities[${index}].FacilityId`, hotelFaciltiesToAdd[index].FacilityId);
    }

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
        hotelFacilitiesRemote = response.facilities;
        $('#hotelFacilitiesList').empty();
        BindListToRemote();
      }
      else {
        $.toaster(response.message, 'Erro', 'danger');
      }
    });

  });
let hotelFacilities = [];

BindListToRemote();

function OnSelectFacility() {
    const facility = facilities.filter((x) => x.value === $("#Facility").val())[0];

    const alreadyExistItem = hotelFacilities.filter((x) => x.FacilityId === $("#Facility").val())[0];

    if (alreadyExistItem === null || alreadyExistItem == undefined) {

        const newHotelFacility = {
            Id: "",
            FacilityId: facility.value,
            Description: facility.text
        };

        AddFacility(newHotelFacility);
    }
}

function AddFacility(obj) {
    hotelFacilities.push(obj);
    CreateLiElement(obj);
}

function CreateLiElement(obj) {

    var listItemTemplate = `<li id="${obj.FacilityId}" class="list-group-item d-flex justify-content-between align-items-start">
                                    <div class="ms-2 me-auto">
                                        <div class="fw-bold">${obj.Description}</div>
                                    </div>
                                    <a href="javascript: RemoveFacility('${obj.FacilityId}');" style="color: red;" title="Remover comodidade"><i class="fas fa-trash-alt"></i></span>
                                </li>`;

    $('#hotelFacilitiesList').append(listItemTemplate);
}

function BindListToRemote() {
    hotelFacilitiesRemote.forEach(function (item) {
        AddFacility({
            Id: item.id,
            FacilityId: item.facilityId,
            Description: item.description
        });
    });
}

function RemoveFacility(id) {
    let facilityToDelete = hotelFacilities.filter((x) => x.FacilityId === id)[0];

    if (facilityToDelete.Id !== "") {
        RemoveHotelFacilityInRemote(facilityToDelete.Id);
    }
    else {
        RemoveLiElement(facilityToDelete.FacilityId);
    }

    hotelFacilities = hotelFacilities.filter((x) => x.FacilityId !== id);
    RemoveLiElement(id);
}

function RemoveLiElement(id) {
    $(`#${id}`).remove();
}


function RemoveHotelFacilityInRemote(id) {
    $.ajax({
        type: 'POST',
        url: 'HotelFacility/Delete/',
        data: { id: id }
    }).done(function (response) {
        if (response.sucesso === true) {
            $.toaster(response.message, 'Sucesso', 'success');
        }
        else {
            $.toaster(response.message, 'Erro', 'danger');
        }
    });
}
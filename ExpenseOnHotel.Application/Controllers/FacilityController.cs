using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExpenseOnHotel.Infrastructure.Contracts;
using ExpenseOnHotel.Domain;
using ExpenseOnHotel.Infrastructure.Commom;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExpenseOnHotel.Application.Models;
using AutoMapper;

namespace ExpenseOnHotel.Application.Controllers
{
    public class FacilityController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUowService _uowService;
        private readonly IMapper _mapper;

        public FacilityController(IUowService uowService, IMapper mapper, ILogger<HomeController> logger)
        {
            _logger = logger;
            _uowService = uowService;
            _mapper = mapper;
        }

        public IActionResult Index(string textSearch = "")
        {
            List<FacilityViewModel> result;
            var facilityQuery = _uowService.Facilities.GetAll();
            if (textSearch != string.Empty)
                result = _mapper.Map<List<FacilityViewModel>>(facilityQuery
                            .Where(x => x.Description.StartsWith(textSearch)).ToList());
            else
                result = _mapper.Map<List<FacilityViewModel>>(facilityQuery.ToList());

            return View(result);
        }

        public async Task<PartialViewResult> Edit(string id)
        {
            ViewBag.IconList = Icons.FontAwesome().OrderBy(x => x.Value)
                .Select(c => new SelectListItem(){ 
                    Text = c.Value, Value = c.Key }).ToList();

            if (string.IsNullOrEmpty(id))
                return PartialView("_Edit", new FacilityViewModel());
            else
            {
                var result = _mapper.Map<FacilityViewModel>(await _uowService.Facilities.GetByIdAsync(new Guid(id)));
                return PartialView("_Edit", result);
            }
        }        

        [HttpPost]
        public async Task<JsonResult> Edit(FacilityViewModel obj)
        {
            try
            {
                if(!ModelState.IsValid){
                    var errorsInString = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    throw new Exception(errorsInString);
                }

                Facility resultObj = null;

                if (obj.Id == Guid.Empty)
                    resultObj = await _uowService.Facilities.AddAsync(_mapper.Map<Facility>(obj));
                else
                    resultObj = await _uowService.Facilities.UpdateAsync(_mapper.Map<Facility>(obj));

                await _uowService.SaveChangesAsync();
                return Json(new {sucesso = true, message = "Dados da comodidade foram salvos com sucesso", uid = resultObj.Id.ToString()});
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, message = $"Erro ao tentar salvar dados da comodidade. Detalhes: {ex.Message}"  });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Delete(string id){
            try{
                await _uowService.Facilities.DeleteAsync(new Guid(id));
                await _uowService.SaveChangesAsync();
                return Json(new { sucesso = true, message = $"Comodidade excluída com sucesso."  });
            }
            catch(Exception ex){
                return Json(new { sucesso = false, message = $"Erro ao tentar excluir comodidade. Detalhes: {ex.Message}"  });
            }
        }
    }
}

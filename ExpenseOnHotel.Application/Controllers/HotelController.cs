using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExpenseOnHotel.Infrastructure.Contracts;
using ExpenseOnHotel.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExpenseOnHotel.Infrastructure.Commom;
using AutoMapper;
using ExpenseOnHotel.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseOnHotel.Application.Controllers
{
    public class HotelController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUowService _uowService;
        private readonly IMapper _mapper;

        public HotelController(IUowService uowService, IMapper mapper, ILogger<HomeController> logger)
        {
            _logger = logger;
            _uowService = uowService;
            _mapper = mapper;
        }

        public IActionResult Index(string textSearch = "")
        {
            List<HotelViewModel> result;
            var hotelQuery = _uowService.Hotels.GetAll()
                .Include(x => x.Facilities)
                .ThenInclude(f => f.Facility); 
            
            if (textSearch != string.Empty){
                var query = hotelQuery.Where(x => x.Name.StartsWith(textSearch) ||
                                x.Description.Contains(textSearch)
                                || x.Facilities.Any(f => f.Facility.Description.Contains(textSearch))
                                ).ToList();
                
                result = _mapper.Map<List<HotelViewModel>>(query);
            }
            else
                result = _mapper.Map<List<HotelViewModel>>(hotelQuery.ToList());

            return View(result);
        }

        public async Task<PartialViewResult> Edit(string id)
        {
            ViewBag.Ufs = StatesAndProvincies.FromBrazil().OrderBy(x => x.Key)
                .Select(c => new SelectListItem(){ 
                    Text = c.Value, Value = c.Key 
                }).ToList();

            if (string.IsNullOrEmpty(id))
                return PartialView("_Edit", new HotelViewModel());
            else
            {
                var result = await _uowService.Hotels.GetByIdAsync(new Guid(id));
                return PartialView("_Edit", _mapper.Map<HotelViewModel>(result));
            }
        }
        

        [HttpPost]
        public async Task<JsonResult> Edit(HotelViewModel obj)
        {
            try
            {
                Hotel resultObj = null;

                if (obj.Id == Guid.Empty)
                    resultObj = await _uowService.Hotels.AddAsync(_mapper.Map<Hotel>(obj));
                else
                    resultObj = await _uowService.Hotels.UpdateAsync(_mapper.Map<Hotel>(obj));

                if(obj.Facilities?.Count > 0)
                    await AddHotelFacilityToHotelAsync(resultObj.Id, obj.Facilities);

                await _uowService.SaveChangesAsync();

                var hotelFacilities = _uowService.HotelFacilities.GetAll()
                                    .Include(x => x.Facility).Where(x => x.HotelId == resultObj.Id).ToList();

                return Json(new {sucesso = true, message = "Dados do hotel foram salvos com sucesso", uid = resultObj.Id.ToString(), facilities = _mapper.Map<List<HotelFacilityViewModel>>(hotelFacilities)});
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, message = $"Erro ao tentar salvar dados do hotel. Detalhes: {ex.Message}", });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Delete(string id){
            try{
                await _uowService.Hotels.DeleteAsync(new Guid(id));
                await _uowService.SaveChangesAsync();
                return Json(new { sucesso = true, message = $"Hotel excluído com sucesso."  });
            }
            catch(Exception ex){
                return Json(new { sucesso = false, message = $"Erro ao tentar excluir hotel. Detalhes: {ex.Message}"  });
            }
        }

        private async Task AddHotelFacilityToHotelAsync(Guid hotelId, List<HotelFacilityViewModel> facilities)
        {
            try
            {
                facilities.ForEach(async x => 
                {
                    var f = new HotelFacility()
                    {
                        HotelId = hotelId,
                        FacilityId = new Guid(x.FacilityId)
                    };
                    await _uowService.HotelFacilities.AddAsync(f);
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu o erro ao vincular as comodidades ao hotel: {ex.Message}");
            }
        }
    }
}


using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExpenseOnHotel.Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;

namespace ExpenseOnHotel.Application.Controllers
{
    public class HotelFacilityController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUowService _uowService;
        private readonly IMapper _mapper;

        public HotelFacilityController(IUowService uowService, IMapper mapper, ILogger<HomeController> logger)
        {
            _logger = logger;
            _uowService = uowService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<JsonResult> Delete(string id)
        {
            try{
                await _uowService.HotelFacilities.DeleteAsync(new Guid(id));
                await _uowService.SaveChangesAsync();
                return Json(new { sucesso = true, message = $"Comodidade removida do hotel com sucesso." });
            }
            catch(Exception ex){
                return Json(new { sucesso = false, message = $"Ocorreu o erro: {ex.Message}" });
            }
        }

    }
}

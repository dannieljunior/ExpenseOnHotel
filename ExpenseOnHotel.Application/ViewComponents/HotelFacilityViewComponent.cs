using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ExpenseOnHotel.Application.Models;
using ExpenseOnHotel.Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExpenseOnHotel.Application.ViewComponents
{
    public class HotelFacilityViewComponent: ViewComponent
    {
        private readonly IUowService _uowService;
        private readonly IMapper _mapper;
        public HotelFacilityViewComponent(IUowService uowService, IMapper mapper)
        {
            _uowService = uowService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(Guid id)
        {
            var facilities = _uowService.Facilities.GetAll().ToList().OrderBy(x => x.Description).ToList(); 

            ViewBag.Facilities = facilities.Select(c => new SelectListItem(){ 
                    Text = c.Description, Value = c.Id.ToString() 
                }).ToList();

            var hotelFacilities = _uowService.HotelFacilities.GetAll()
                                    .Include(x => x.Facility).Where(x => x.HotelId == id).ToList();

            var result = _mapper.Map<List<HotelFacilityViewModel>>(hotelFacilities);
            return View(result);
        }
    }
}
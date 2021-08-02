using AutoMapper;
using ExpenseOnHotel.Application.Models;
using ExpenseOnHotel.Domain;

namespace ExpenseOnHotel.Application.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<HotelViewModel, Hotel>()
                .ForMember(x => x.Facilities, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.UpdatedDate, opt => opt.Ignore());

            CreateMap<FacilityViewModel, Facility>()
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.UpdatedDate, opt => opt.Ignore());

            CreateMap<HotelFacilityViewModel, HotelFacility>()
                .ForMember(x => x.Hotel, opt => opt.Ignore())
                .ForMember(x => x.Facility, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.UpdatedDate, opt => opt.Ignore());
            
            CreateMap<Hotel, HotelViewModel>();

            CreateMap<Facility, FacilityViewModel>();

            CreateMap<HotelFacility, HotelFacilityViewModel>()
                .ForMember(x => x.Description, 
                   opt => opt.MapFrom
                   (src =>  src.Facility != null ? src.Facility.Description : string.Empty))
                .ForMember(x => x.Icon, 
                   opt => opt.MapFrom
                   (src =>  src.Facility != null ? src.Facility.Icon : string.Empty));

        }
    }
}
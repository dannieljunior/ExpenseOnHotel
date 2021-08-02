using System.Threading.Tasks;

namespace ExpenseOnHotel.Infrastructure.Contracts
{
    public interface IUowService
    {
        IHotelRepository Hotels {get;}
        IFacilityRepository Facilities {get;}
        IHotelFacilityRepository HotelFacilities {get;}
        Task SaveChangesAsync();
    }
}
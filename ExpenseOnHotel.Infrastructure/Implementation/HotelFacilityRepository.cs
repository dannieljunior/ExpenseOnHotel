using ExpenseOnHotel.Domain;
using ExpenseOnHotel.Infrastructure.Base;
using ExpenseOnHotel.Infrastructure.Contracts;

namespace ExpenseOnHotel.Infrastructure.Implementation
{
    public class HotelFacilityRepository : Repository<HotelFacility>, IHotelFacilityRepository
    {
        public HotelFacilityRepository(ExpenseOnHotelContext dbContext) : base(dbContext)
        {
        }
    }
}
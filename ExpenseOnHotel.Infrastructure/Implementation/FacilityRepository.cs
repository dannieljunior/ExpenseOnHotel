using ExpenseOnHotel.Domain;
using ExpenseOnHotel.Infrastructure.Base;
using ExpenseOnHotel.Infrastructure.Contracts;

namespace ExpenseOnHotel.Infrastructure.Implementation
{
    public class FacilityRepository : Repository<Facility>, IFacilityRepository
    {
        public FacilityRepository(ExpenseOnHotelContext dbContext) : base(dbContext)
        {
        }
    }
}
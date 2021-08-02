using ExpenseOnHotel.Domain;
using ExpenseOnHotel.Infrastructure.Base;
using ExpenseOnHotel.Infrastructure.Contracts;

namespace ExpenseOnHotel.Infrastructure.Implementation
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(ExpenseOnHotelContext dbContext) : base(dbContext)
        {
        }
    }
}
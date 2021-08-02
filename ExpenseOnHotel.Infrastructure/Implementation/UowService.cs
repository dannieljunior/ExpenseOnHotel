using System.Threading.Tasks;
using ExpenseOnHotel.Infrastructure.Contracts;

namespace ExpenseOnHotel.Infrastructure.Implementation
{
    public class UowService: IUowService
    {
        ExpenseOnHotelContext Context;
        IHotelRepository _hotelRepository;
        IFacilityRepository _facilityRepository;
        IHotelFacilityRepository _hotelFacilityRepository;

        public IHotelRepository Hotels => _hotelRepository;
        public IFacilityRepository Facilities => _facilityRepository;
        public IHotelFacilityRepository HotelFacilities => _hotelFacilityRepository;

       
        /// Nota do Desenvolvedor: UOW aqui faz papel da camada de serviço.
        /// Em um cenário real os repositórios estariam agregados em serviços
        /// Injetando apenas os respoitórios utilizados no agregador 
        public UowService(ExpenseOnHotelContext context, 
                          IHotelRepository hotelRepository, 
                          IFacilityRepository facilityRepository, 
                          IHotelFacilityRepository hotelFacilityRepository)
        {
            Context = context;
            _hotelRepository = hotelRepository;
            _facilityRepository = facilityRepository;
            _hotelFacilityRepository = hotelFacilityRepository;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
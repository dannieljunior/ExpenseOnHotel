using System;

namespace ExpenseOnHotel.Domain
{
    public class HotelFacility: ModelBase 
    {
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public Guid FacilityId { get; set; }
        public Facility Facility { get; set; }
    }
}
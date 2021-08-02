using System;
using System.Collections.Generic;

namespace ExpenseOnHotel.Domain
{
    public class Facility: ModelBase
    {
        public string Description { get; set; }
        public string Icon { get; set; }
        public IList<HotelFacility> Facilities { get; set; }
    }
}

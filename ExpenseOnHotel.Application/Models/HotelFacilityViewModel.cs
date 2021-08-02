using System.ComponentModel.DataAnnotations;

namespace ExpenseOnHotel.Application.Models
{
    ///Nota do desenvolvedor: Não usei outros view models e nem DTO's ,
    /// para não aumentar complexidade com o uso de automapping e etc... (estou sem tempo)
    /// Esta View Model é específica para a trativa em memória das comodidades
    public class HotelFacilityViewModel: ViewModelBase
    {
        [Required]
        public string HotelId { get; set; }
        [Required]
        public string FacilityId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
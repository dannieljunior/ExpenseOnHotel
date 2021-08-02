using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpenseOnHotel.Application.Models
{
    public class HotelViewModel: ViewModelBase
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Name { get; set; }   
        [Required(ErrorMessage = "Informe uma Descrição.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Classifique o hotel.")]
        public int Rating { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório.")]
        public string Address { get; set; }
        
        public string AddressComplement { get; set; }
        [Required(ErrorMessage = "Informe o bairro.")]
        public string AddressDistrict { get; set; }
        [Required(ErrorMessage = "Informe a cidade.")]
        public string AddressCity { get; set; }
        [Required(ErrorMessage = "Selecione um estado.")]
        public string AddressState { get; set; }       
        [Required(ErrorMessage = "Informe o CEP.")]
        public string AddressPostalCode { get; set; }
        public List<HotelFacilityViewModel> Facilities { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ExpenseOnHotel.Application.Models
{
    ///Nota do desenvolvedor: Não usei outros view models e nem DTO's ,
    /// para não aumentar complexidade com o uso de automapping e etc... (estou sem tempo)
    /// Esta View Model é específica para a trativa em memória das comodidades
    public class FacilityViewModel: ViewModelBase
    {
        [Required(ErrorMessage = "Informe a descrição da comodidade.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Selecione um ícone para a comodidade.")]
        public string Icon { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpenseOnHotel.Domain
{
    public class Hotel : ModelBase
    {
        /// <summary>
        /// Nome do Hotel
        /// </summary>    
        ///
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Descrição
        /// </summary>   
        public string Description { get; set; }
        /// <summary>
        /// Avaliação
        /// </summary>   
        public int Rating { get; set; }
        /// <summary>
        /// Endereço - Logradouro
        /// </summary>   
        public string Address { get; set; }
        /// <summary>
        /// Endereço - Complemento
        /// </summary> 
        public string AddressComplement { get; set; }
        /// <summary>
        /// Endereço - Bairro / setor
        /// </summary> 
        public string AddressDistrict { get; set; }
        /// <summary>
        /// Endereço - Cidade
        /// </summary> 
        public string AddressCity { get; set; }
        /// <summary>
        /// Endereço - Cep
        /// </summary> 
        
        /// <summary>
        /// Endereço - Estado (UF)
        /// </summary> 
        public string AddressState { get; set; }
        /// <summary>
        /// Endereço - Cep
        /// </summary>         
        public string AddressPostalCode { get; set; }
        public IList<HotelFacility> Facilities { get; set; }
    }
}

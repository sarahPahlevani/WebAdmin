using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class ActionTypeDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

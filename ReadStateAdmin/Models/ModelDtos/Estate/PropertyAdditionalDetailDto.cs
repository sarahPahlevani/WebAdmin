using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyAdditionalDetailDto 
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Value { get; set; }

    }
}

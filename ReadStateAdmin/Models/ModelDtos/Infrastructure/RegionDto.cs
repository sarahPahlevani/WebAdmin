using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Infrastructure
{
    public class RegionDto
    {
        public int Id { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

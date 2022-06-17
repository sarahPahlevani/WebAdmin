using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Infrastructure
{
    public class PriceScaleUnitDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Scale { get; set; }

    }
}

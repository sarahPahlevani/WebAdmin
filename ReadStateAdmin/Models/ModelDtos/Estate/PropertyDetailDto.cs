using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyDetailDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        public decimal? Size { get; set; }
        public decimal? LandArea { get; set; }
        public int? Rooms { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Garages { get; set; }
        public decimal? GaragesSize { get; set; }
        public int? YearBuild { get; set; }

    }
}

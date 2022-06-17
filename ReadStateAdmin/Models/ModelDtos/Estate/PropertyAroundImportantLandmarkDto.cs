using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyAroundImportantLandmarkDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public int ImportantPlaceTypeId { get; set; }

        public string Description { get; set; }
        public decimal? DistanceMiles { get; set; }
        public decimal? DistanceKm { get; set; }
        public int? WalkToMin { get; set; }

    }
}

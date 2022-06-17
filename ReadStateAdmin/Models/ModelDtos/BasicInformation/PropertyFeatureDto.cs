using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.BasicInformation
{
    public class PropertyFeatureDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Icon { get; set; }
    }
}

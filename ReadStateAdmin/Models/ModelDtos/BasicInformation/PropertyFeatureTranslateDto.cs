using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.BasicInformation
{
    public class PropertyFeatureTranslateDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyFeatureId { get; set; }

        public PropertyFeature PropertyFeature { get; set; }

        [Required]
        public int LanguageId { get; set; }

        public DAL.Models.Language Language { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

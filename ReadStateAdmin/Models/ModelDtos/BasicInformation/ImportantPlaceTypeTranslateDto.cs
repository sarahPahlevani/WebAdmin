using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.BasicInformation
{
    public class ImportantPlaceTypeTranslateDto
    {
        public int Id { get; set; }

        [Required]
        public int ImportantPlaceTypeId { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

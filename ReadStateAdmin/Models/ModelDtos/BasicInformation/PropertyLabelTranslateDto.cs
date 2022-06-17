using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.BasicInformation
{
    public class PropertyLabelTranslateDto 
    {
        public int Id { get; set; }

        [Required]
        public int PropertyLabelId { get; set; }

        public PropertyLabel PropertyLabel { get; set; }

        [Required]
        public int LanguageId { get; set; }

        public DAL.Models.Language Language { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestTypeTranslateDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestTypeId { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}

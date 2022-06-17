using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Infrastructure
{
    public class LanguageDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ShortName { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Direction { get; set; }

        public string Flag { get; set; }

        public bool IsDefault { get; set; }

        public string UrlCode { get; set; }

    }
}

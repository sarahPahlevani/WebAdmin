using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Infrastructure
{
    public class CountryDto
    {
        public int Id { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [Required]
        public string Name { get; set; }

        public string OfficialShortForm { get; set; }
        public string OfficialLongForm { get; set; }
        public int? Isocode { get; set; }
        public string Isoshort { get; set; }
        public string Isolong { get; set; }

    }
}

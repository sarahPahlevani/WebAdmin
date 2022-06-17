using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyPriceDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [Required]
        public int PriceScaleUnitId { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string BeforePriceLabel { get; set; }
        public string AfterPriceLabel { get; set; }

        [Required]
        public bool PriceOnCall { get; set; }

        public decimal CalculatedPriceUnit { get; set; }

        public byte? Commission { get; set; }
    }
}

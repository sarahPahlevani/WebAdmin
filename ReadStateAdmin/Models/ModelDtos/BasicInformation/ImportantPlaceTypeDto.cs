using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.BasicInformation
{
    public class ImportantPlaceTypeDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] TypeIcon { get; set; }
        public string TypeIconImageUrl { get; set; }

    }
}

using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestPropertyDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public string Description { get; set; }

    }
}

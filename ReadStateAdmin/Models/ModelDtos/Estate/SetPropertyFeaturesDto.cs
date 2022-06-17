using RealEstateAdmin.Models.DAL.DtoContracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class SetPropertyFeaturesDto : IDto
    {
        [Required]
        public int PropertyId { get; set; }

        [Required]
        public List<int> PropertyFeatureIds { get; set; }
    }
}

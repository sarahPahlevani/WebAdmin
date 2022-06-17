using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyFloorPlanDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        public string FloorName { get; set; }

        public int? FloorPrice { get; set; }
        public string PricePostfix { get; set; }
        public int? FloorSize { get; set; }
        public string SizePostfix { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public string PlanDescription { get; set; }
        public string ImageCaption { get; set; }
        public DateTime? UploadDate { get; set; }
        public string ImageExtension { get; set; }
        public int? ImageSize { get; set; }
        public string ImagePath { get; set; }
        public string TumbPath { get; set; }
        public bool? Is360View { get; set; }

    }
}

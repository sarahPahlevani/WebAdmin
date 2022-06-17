using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int PropertyId { get; set; }
        public string ImageCaption { get; set; }
        public DateTime UploadDate { get; set; }
        public string ImageExtension { get; set; }
        public string ImagePath { get; set; }
        public string TumbPath { get; set; }
        public int ImageSize { get; set; }
        public bool Is360View { get; set; }
        public int Priority { get; set; }
        public bool IsForBanner { get; set; }

    }
}

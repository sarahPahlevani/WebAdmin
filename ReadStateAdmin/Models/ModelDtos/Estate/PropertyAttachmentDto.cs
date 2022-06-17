using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyAttachmentDto
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string FileCaption { get; set; }
        public DateTime UploadDate { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }

    }
}

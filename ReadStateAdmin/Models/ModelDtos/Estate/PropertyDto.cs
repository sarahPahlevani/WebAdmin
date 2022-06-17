using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Estate
{
    public class PropertyDto
    {
        public int Id { get; set; }

        [Required]
        public int PropertyTypeId { get; set; }

        [Required]
        public int PropertyLabelId { get; set; }

        [Required]
        public int PropertyStatusId { get; set; }

        public string Title { get; set; }

        public string PropertyUniqId { get; set; }

        [Required]
        public string Description { get; set; }

        public string VideoUrl { get; set; }

        public string DraftInformation { get; set; }

        public string ExtraInformation { get; set; }

        public DateTime? DateUpdated { get; set; }
        public int? RequestId { get; set; }
        public bool ReadyForPublish { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishingDate { get; set; }
        public int? UserAccountIdReadyForPublish { get; set; }
        public int? UserAccountIdPublished { get; set; }
        public DateTime? ReadyForPublishDate { get; set; }
        public byte? Commission { get; set; }
    }
}

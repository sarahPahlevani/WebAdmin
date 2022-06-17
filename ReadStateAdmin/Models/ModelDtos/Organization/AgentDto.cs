using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Organization
{
    public class AgentDto
    {
        public int Id { get; set; }

        [Required]
        public int RealEstateId { get; set; }

        [Required]
        public int UserAccountId { get; set; }

        public string MetadataJson { get; set; }
        public byte[] BusinessCardFront { get; set; }
        public byte[] BusinessCardBack { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsResponsible { get; set; }
        [Required]
        public bool HasPublishingAuthorization { get; set; }

    }
}

using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Organization
{
    public class MarketingAssistantDto
    {
        public int Id { get; set; }
        public int RealEstateId { get; set; }
        public int UserAccountId { get; set; }
        public string MetadataJson { get; set; }
        public string Description { get; set; }
        public string TrackingCode { get; set; }
        public bool HasPlusLevel { get; set; }

    }
}

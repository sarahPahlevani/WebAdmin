using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestActionDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }

        [Required]
        public int ActionTypeId { get; set; }

        [Required]
        public int AgentId { get; set; }

        public int? RequestActionFollowUpReference { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime ActionDate { get; set; }
        public string ActionTime { get; set; }
        public bool? ActionIsSuccess { get; set; }
        public string MetaDataJson { get; set; }

    }
}

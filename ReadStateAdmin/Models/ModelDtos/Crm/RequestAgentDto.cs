using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestAgentDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }

        [Required]
        public int AgentId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsActive { get; set; }

        [Required]
        public string Description { get; set; }

    }
}

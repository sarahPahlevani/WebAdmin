using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestStateDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }

        [Required]
        public int WorkflowStepId { get; set; }

        public DateTime? StartStepDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        
        public string Description { get; set; }

        public bool IsDone { get; set; }

        public bool IsSuccess { get; set; }

        [Required]
        public int AgentId { get; set; }

    }
}

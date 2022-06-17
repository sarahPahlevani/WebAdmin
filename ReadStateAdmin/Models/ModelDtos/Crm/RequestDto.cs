using System;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestTypeId { get; set; }

        public RequestType RequestType { get; set; }

        public int? AgentId { get; set; }

        public Agent Agent { get; set; }

        [Required]
        public int? UserAccountIdRequester { get; set; }

        public int? WorkflowId { get; set; }

        public Workflow Workflow { get; set; }

        public string TrackingNumber { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        //public string MarketingAssistantTrackingCode { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? UserAccountIdDeleteBy { get; set; }
        public int? SharedPropertyClickId { get; set; }

        public IEnumerable<RequestAction> Actions { get; set; }
        public IEnumerable<RequestState> States { get; set; }
        public int? PropertyId { get; set; }
        public string PropertyTitle { get; set; }
        public int Commision { get; set; }
        public bool IsDone { get; set; }
        public bool IsSuccess { get; set; }
    }
}

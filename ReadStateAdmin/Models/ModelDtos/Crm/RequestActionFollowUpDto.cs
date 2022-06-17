using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestActionFollowUpDto
    {
        public int Id { get; set; }

        [Required]
        public int RequestActionId { get; set; }

        [Required]
        public int ActionTypeId { get; set; }

        [Required]
        public int AgentIdFollowUp { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime FollowUpDateTime { get; set; }
        public DateTime? FollowUpDateTimeSnooze { get; set; }
        public bool IsDone { get; set; }

    }
}

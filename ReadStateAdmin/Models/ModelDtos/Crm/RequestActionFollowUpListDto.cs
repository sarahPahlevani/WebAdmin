﻿using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class RequestActionFollowUpListDto : IDto
    {
        public int Id { get; set; }
        public int RequestActionId { get; set; }
        public int ActionTypeId { get; set; }
        public int AgentIdFollowUp { get; set; }
        public string Description { get; set; }
        public DateTime FollowUpDateTime { get; set; }
        public DateTime? FollowUpDateTimeSnooze { get; set; }
        public bool IsDone { get; set; }
        public ActionType ActionType { get; set; }
    }
}

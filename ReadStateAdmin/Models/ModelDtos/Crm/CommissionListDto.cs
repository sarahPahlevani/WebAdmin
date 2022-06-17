using RealEstateAdmin.Models.DAL.Models;
using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class CommissionListDto
    {
        public int Id { get; set; }
        public byte CommissionPercent { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsPay { get; set; }
        public string PayCode { get; set; }
        public DateTime? PayDate { get; set; }

        public string UserAccountId { get; set; }
        public string Username { get; set; }
        public int PropertyId { get; set; }
        public string PropertyTitle { get; set; }
        public decimal PropertyPrice { get; set; }
        public Currency PropertyPriceCurrency { get; set; }
    }
}

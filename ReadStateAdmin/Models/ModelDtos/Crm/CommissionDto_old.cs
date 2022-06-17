
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Dtos.ModelDtos.Crm
{
    public class CommissionDto_old
    {
        public decimal? TotalCommission { get; set; }
        public int PropertyId { get; set; }
        public string PropertyTitle { get; set; }
        public byte? CommissionPercent { get; set; }
        public decimal PropertyPrice { get; set; }
        public string RequesterFullname { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string CurrencySymbol { get; set; }
    }
}

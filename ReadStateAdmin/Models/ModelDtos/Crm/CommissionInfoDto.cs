using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class CommissionInfoDto
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal Amount { get; set; }
        public bool IsPay { get; set; }

        public decimal TotalCommission { get; set; }
        public decimal TotalEarn { get; set; }
    }
}

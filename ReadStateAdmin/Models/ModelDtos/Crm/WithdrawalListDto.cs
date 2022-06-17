using System;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class WithdrawalListDto
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class WithdrawalDto
    {
        public int Id { get; set; }

        [Required]
        public int UserAccountId { get; set; }

        public UserAccount UserAccount { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

    }
}

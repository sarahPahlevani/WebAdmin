using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class CommissionDto
    {
        public int Id { get; set; }

        [Required]
        public byte CommissionPercent { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public bool IsPay { get; set; }

        public string PayCode { get; set; }

        public DateTime? PayDate { get; set; }


        public Request Request { get; set; }
        public UserAccount UserAccount { get; set; }
        public DAL.Models.Property Property { get; set; }


    }
}

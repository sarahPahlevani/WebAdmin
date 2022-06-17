using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class Subscribes
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? UserAccountIdDeleteBy { get; set; }
    }
}

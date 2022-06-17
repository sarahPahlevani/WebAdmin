using System;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class SubscribeDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? UserAccountId_DeleteBy { get; set; }
    }
}

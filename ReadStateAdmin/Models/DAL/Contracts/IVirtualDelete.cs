using System;

namespace RealEstateAdmin.Models.DAL.Contracts
{
    public interface IVirtualDelete : IEntity
    {
        bool Deleted { get; set; }
        DateTime? DeletedDate { get; set; }
        int? UserAccountIdDeleteBy { get; set; }
    }
}

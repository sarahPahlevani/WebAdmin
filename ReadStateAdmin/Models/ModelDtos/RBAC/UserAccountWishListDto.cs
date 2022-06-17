using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class UserAccountWishListDto
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int PropertyId { get; set; }

    }
}

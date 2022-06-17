using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class UserGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StaticCode { get; set; }

    }
}

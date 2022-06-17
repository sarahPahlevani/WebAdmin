using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class UserGroupTranslateDto
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

    }
}

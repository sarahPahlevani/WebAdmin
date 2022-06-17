using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class WorkflowDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RequestTypeId { get; set; }

    }
}

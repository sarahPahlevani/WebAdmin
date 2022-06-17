using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Crm
{
    public class WorkflowStepDto
    {
        public int Id { get; set; }

        [Required]
        public int WorkflowId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int StepNumber { get; set; }

        public bool IsFinish { get; set; }

    }
}

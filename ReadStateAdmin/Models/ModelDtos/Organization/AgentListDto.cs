using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Organization
{
    public class AgentListDto : IDto
    {
        public int Id { get; set; }
        public int RealEstateId { get; set; }
        public int UserAccountId { get; set; }
        public string Description { get; set; }
        public bool IsResponsible { get; set; }
        public bool HasPublishingAuthorization { get; set; }


        //public UserAccount UserAccount { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone01 { get; set; }
        public string Address01 { get; set; }
    }
}

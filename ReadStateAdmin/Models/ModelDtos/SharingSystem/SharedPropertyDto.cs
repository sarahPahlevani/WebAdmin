using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.SharingSystem
{
    public class SharedPropertyDto
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int? UserAccountId { get; set; }
        public int? SocialNetworkId { get; set; }
        public string ReferralCodeAndSharingNetworkId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.SharingSystem
{
    public class SocialNetworkDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] LogoPicture { get; set; }
        public string UniqueKey { get; set; }

    }
}

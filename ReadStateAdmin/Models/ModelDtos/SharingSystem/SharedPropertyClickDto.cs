using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.SharingSystem
{
    public class SharedPropertyClickDto
    {
        public int Id { get; set; }
        public int SharedPropertyId { get; set; }
        public string MetaData { get; set; }

    }
}

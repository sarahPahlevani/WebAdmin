using RealEstateAdmin.Models.DAL.Models;
using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.ModelDtos.CMS
{
    public class ContentDto
    {

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public Content Parent { get; set; }
        public string ParentName { get; set; }
        public int? RealEstateId { get; set; }
        public bool IsMenu { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Deleted { get; set; }
        public int? UserAccountId_DeleteBy { get; set; }
        public DateTime? DeletedDate { get; set; }

    }

}

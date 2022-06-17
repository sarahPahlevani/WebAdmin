using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class Content
    {
        public Content()
        {
            ContentTranslate = new HashSet<ContentTranslate>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? RealEstateId { get; set; }
        public bool IsMenu { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Deleted { get; set; }
        public int? UserAccountIdDeleteBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<ContentTranslate> ContentTranslate { get; set; }
    }
}

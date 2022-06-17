using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class ContentTranslate
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public virtual Content Content { get; set; }
        public virtual Language Language { get; set; }
    }
}

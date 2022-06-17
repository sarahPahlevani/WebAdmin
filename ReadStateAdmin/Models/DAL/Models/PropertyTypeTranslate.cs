using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class PropertyTypeTranslate
    {
        public int Id { get; set; }
        public int PropertyTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language Language { get; set; }
        public virtual PropertyType PropertyType { get; set; }
    }
}

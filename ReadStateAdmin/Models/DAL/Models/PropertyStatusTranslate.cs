﻿using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class PropertyStatusTranslate
    {
        public int Id { get; set; }
        public int PropertyStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual Language Language { get; set; }
        public virtual PropertyStatus PropertyStatus { get; set; }
    }
}

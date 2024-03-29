﻿using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class PropertyImage
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int? UserAccountIdDeleteBy { get; set; }
        public string ImageCaption { get; set; }
        public DateTime UploadDate { get; set; }
        public string ImageExtension { get; set; }
        public int ImageSize { get; set; }
        public string ImagePath { get; set; }
        public string TumbPath { get; set; }
        public bool Is360View { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Priority { get; set; }
        public bool IsForBanner { get; set; }

        public virtual Property Property { get; set; }
        public virtual UserAccount UserAccountIdDeleteByNavigation { get; set; }
    }
}

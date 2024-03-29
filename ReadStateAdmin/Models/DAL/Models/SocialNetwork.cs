﻿using System;
using System.Collections.Generic;

namespace RealEstateAdmin.Models.DAL.Models
{
    public partial class SocialNetwork
    {
        public SocialNetwork()
        {
            SharedProperty = new HashSet<SharedProperty>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] LogoPicture { get; set; }
        public string UniqueKey { get; set; }

        public virtual ICollection<SharedProperty> SharedProperty { get; set; }
    }
}

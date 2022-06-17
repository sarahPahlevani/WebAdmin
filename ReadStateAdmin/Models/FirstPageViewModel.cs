using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.FirstPage
{
    public class FirstPageViewModel
    {
        public RootObject Latest { get; set; }
        public RootObject HotOffers { get; set; }
        public string PropertyType { get; set; }
        public SelectList PropertyTypeList { get; set; }
        public SelectList PropertyStatusList { get; set; }

    }
}

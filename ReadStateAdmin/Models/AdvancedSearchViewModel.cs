using RealEstateAdmin.Models.DAL.Models;
using RealEstateAdmin.Models.ModelDtos.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models
{
    public class AdvancedSearchViewModel
    {
        public int Count { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }
        public int Total { get; set; }
        public List<PropertyWebAppListDto> Items { get; set; }
        public List<PropertyType> CategoryList { get; set; }

        public List<PropertyStatus> PropertyStatuses { get; set; }
    }


    public class AdvancedSearchInputViewModel
    {
        public string page_number { get; set; }
        public string page_size { get; set; }
        public string search { get; set; }
        //public List<string> type { get; set; }
        public string type { get; set; }
        public List<string> status { get; set; }
        public List<string> label { get; set; }
        public List<string> feature { get; set; }
        public string price_from { get; set; }
        public string price_to { get; set; }
        public string size_from { get; set; }
        public string size_to { get; set; }
        public string area_from { get; set; }
        public string area_to { get; set; }
        public string rooms_from { get; set; }
        public string rooms_to { get; set; }
        public string bed_rooms_from { get; set; }
        public string bed_rooms_to { get; set; }
        public string bath_rooms_from { get; set; }
        public string bath_rooms_to { get; set; }
        public string garages_from { get; set; }
        public string garages_to { get; set; }
        public string garages_size_from { get; set; }
        public string garages_size_to { get; set; }
        public string year_build_from { get; set; }
        public string year_build_to { get; set; }
        public string floors_from { get; set; }
        public string floors_to { get; set; }
        public string has_image { get; set; }
        public string city { get; set; }
        public string lat { get; set; }
        public string _long { get; set; }
    }
}

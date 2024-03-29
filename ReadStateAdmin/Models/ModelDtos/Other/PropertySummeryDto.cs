﻿using System;
using System.Collections.Generic;
using System.Text;
using RealEstateAdmin.Models.DAL.Models;

namespace RealEstateAdmin.Models.ModelDtos.Other
{
    public class PropertySummeryDto
    {
        public int Id { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Title { get; set; }
        public int PropertyTypeId { get; set; }
        public int PropertyLabelId { get; set; }
        public int PropertyStatusId { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        //public int? CityId { get; set; }
        //public int? RegionId { get; set; }
        public decimal Price { get; set; }
        public decimal CalculatedPriceUnit { get; set; }
        public int CurrencyId { get; set; }
        public int PriceScaleUnitId { get; set; }
        public decimal? Size { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Garages { get; set; }
        public int? Rooms { get; set; }
        public int? YearBuild { get; set; }
        public IEnumerable<PropertyImage> Images { get; set; }
        public List<string> ImagesUrl { get; set; }

    }
}

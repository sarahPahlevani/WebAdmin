using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using RealEstateAdmin.Models.ModelDtos.Crm;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RealEstateAdmin.Models.ModelDtos.Infrastructure;
using RealEstateAdmin.Models.ModelDtos.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.FirstPage
{
    public class Price
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public int priceScaleUnitId { get; set; }
        public long price { get; set; }
        public string beforePriceLabel { get; set; }
        public string afterPriceLabel { get; set; }
        public bool priceOnCall { get; set; }
        public object calculatedPriceUnit { get; set; }
        public object currency { get; set; }
        public object idNavigation { get; set; }
        public object priceScaleUnit { get; set; }
    }

    public class PropertyLocation
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public int regionId { get; set; }
        public int cityId { get; set; }
        public string zipCode { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public object googleMapsLatitude { get; set; }
        public object googleMapsLongitude { get; set; }
        public object city { get; set; }
        public object country { get; set; }
        public object idNavigation { get; set; }
        public object region { get; set; }
    }

    public class PropertyDetail
    {
        public int id { get; set; }
        public float size { get; set; }
        public float landArea { get; set; }
        public int rooms { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public int garages { get; set; }
        public float garagesSize { get; set; }
        public int? yearBuild { get; set; }
        public object idNavigation { get; set; }
    }

    public class ImagesId
    {
        public int id { get; set; }
        public int order { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int propertyLabelId { get; set; }
        public int propertyStatusId { get; set; }
        public string title { get; set; }
        public string videoUrl { get; set; }
        public Price price { get; set; }
        public string zipCode { get; set; }
        public string description { get; set; }
        public string propertyUniqId { get; set; }
        public PropertyLocation propertyLocation { get; set; }
        public PropertyDetail propertyDetail { get; set; }
        public List<string> imagesUrl { get; set; }
        public List<ImagesId> imagesId { get; set; }


        public string propertyType { get; set; }
        public string propertyStatus { get; set; }


        public string SharingFacebook { get; set; }
        public string SharingTwitter { get; set; }
        public string SharingLinkedin { get; set; }
        public string SharingPinterest { get; set; }

    }

    public class RootObject
    {
        public int count { get; set; }
        public List<Item> items { get; set; }
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }


    public class RequestPage
    {
        //
        public IEnumerable<RequestListDto> AllRequest { get; set; }
        public IEnumerable<RequestListDto> YourRequest { get; set; }
        public IEnumerable<AgentListDto> Agents { get; set; }
    }

    public class PropertyCreatePage
    {
        public IEnumerable<PropertyLabelDto> PropertyLabel { get; set; }
        public IEnumerable<PropertyStatusDto> PropertyStatus { get; set; }
        public IEnumerable<PropertyTypeDto> PropertyType { get; set; }
    }
    public class PropertyLocationPage
    {
        public IEnumerable<CountryDto> Country { get; set; }
        public IEnumerable<CityDto> City { get; set; }
        public IEnumerable<RegionDto> Region { get; set; }
    }
    public class PropertyPricePage
    {
        public IEnumerable<CurrencyDto> Currency { get; set; }
        public IEnumerable<PriceScaleUnitDto> PriceScaleUnit { get; set; }
    }
    public class PropertyFeaturesPage
    {
        public IEnumerable<PropertyFeatureDto> PropertyFeature { get; set; }
    }
    public class PropertyDetailsPage
    {
        public PropertyDetailDto PropertyDetail { get; set; }
    }
    public class PropertyCreatePageViewComponentViewModel
    {
        public string ActionName { get; set; }
        public int PropertyId { get; set; }
        /// <summary>
        /// page information
        /// </summary>
        public dynamic Dynamic { get; set; }
        /// <summary>
        /// entry data 
        /// </summary>
        public dynamic EntryData { get; set; }

        public int FloorId { get; set; }
    }
}

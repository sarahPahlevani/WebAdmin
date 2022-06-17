using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models.FirstPage;
using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RealEstateAdmin.Models.ModelDtos.Other;
using RealEstateAdmin.Models.ModelDtos.Page;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Components.PropertyCreatingSteps
{
    public class PropertyCreatingStepsViewComponent : ViewComponent
    {
        private readonly ApiCaller _request;
        private readonly AppSetting _appSetting;
        public PropertyCreatingStepsViewComponent(ApiCaller request, IOptions<AppSetting> options)
        {
            _request = request;
            _appSetting = options.Value;
        }

        public IViewComponentResult Invoke(PropertyCreatePageViewComponentViewModel model)
        {
            #region Description Tab
            if (model.ActionName == "description")
            {
                var body = new Dictionary<string, object>();
                body.Add("filter", new Dictionary<string, object>() { });
                body.Add("pageNumber", 0);
                body.Add("pageSize", 2000);
                var Propertyitem = _request.Send<PropertyDto>(body, Method.GET, "Property/" + model.PropertyId);
                model.EntryData = Propertyitem;
            }
            #endregion
            #region location tab
            if (model.ActionName == "location")
            {
                //var body = new Dictionary<string, object>();
                //body.Add("filter", new Dictionary<string, object>() { });
                //body.Add("pageNumber", 0);
                //body.Add("pageSize", 2000);

                var Propertylocationitem = new PropertyLocationDto();
                try
                {
                    Propertylocationitem = _request.Send<PropertyLocationDto>(null, Method.GET, "PropertyLocation/" + model.PropertyId);
                    model.EntryData = Propertylocationitem;
                    // Edit 
                }
                catch
                {
                    Propertylocationitem.PropertyId = model.PropertyId;
                    Propertylocationitem.AddressLine1 = "";
                    Propertylocationitem.AddressLine2 = "";
                    Propertylocationitem.ZipCode = "";
                    Propertylocationitem.Country = "";
                    Propertylocationitem.Region = "";
                    Propertylocationitem.City = "";
                    Propertylocationitem.GoogleMapsLatitude = "47.482984";
                    Propertylocationitem.GoogleMapsLongitude = "19.077423";
                    model.EntryData = Propertylocationitem;

                    //create
                }

            }
            #endregion
            #region Price
            //PropertyPricePage
            if (model.ActionName == "price")
            {


                var PropertyPriceitem = new PropertyPriceDto();
                try
                {
                    PropertyPriceitem = _request.Send<PropertyPriceDto>(null, Method.GET, "PropertyPrice/" + model.PropertyId);

                    #region Commission
                    var propertyCommission = _request.Send<PropertyDto>(null, Method.GET, $"Property/{model.PropertyId}");
                    PropertyPriceitem.Commission = propertyCommission.Commission;
                    #endregion

                    model.EntryData = PropertyPriceitem;
                }
                catch
                {
                    PropertyPriceitem.PropertyId = model.PropertyId;
                    //Propertylocationitem. = "";
                    //Propertylocationitem.AddressLine2 = "";
                    //Propertylocationitem.ZipCode = "";
                    //Propertylocationitem.CountryId = -1;
                    //Propertylocationitem.RegionId = -1;
                    //Propertylocationitem.CityId = -1;
                    model.EntryData = PropertyPriceitem;

                    //create
                }
            }
            #endregion
            #region Feature
            if (model.ActionName == "features")
            {
                ViewBag.PropertyId = model.PropertyId;
                var PropertyPriceitem = new List<PropertyFeatureDto>();
                try
                {
                    PropertyPriceitem = _request.Send<List<PropertyFeatureDto>>(null, Method.GET, "PropertyFeature/GetPropertyFeatures/" + model.PropertyId);
                    model.EntryData = PropertyPriceitem;
                    // Edit 
                }
                catch
                {
                    //PropertyPriceitem.PropertyId = model.PropertyId;
                    //Propertylocationitem. = "";
                    //Propertylocationitem.AddressLine2 = "";
                    //Propertylocationitem.ZipCode = "";
                    //Propertylocationitem.CountryId = -1;
                    //Propertylocationitem.RegionId = -1;
                    //Propertylocationitem.CityId = -1;
                    model.EntryData = PropertyPriceitem;

                    //create
                }
            }
            #endregion
            #region Details
            if (model.ActionName == "details")
            {
                ViewBag.PropertyId = model.PropertyId;
                var PropertyDetailitem = new PropertyDetailDto();
                try
                {
                    PropertyDetailitem = _request.Send<PropertyDetailDto>(null, Method.GET, "PropertyDetail/" + model.PropertyId);
                    model.EntryData = PropertyDetailitem;
                    // Edit 
                }
                catch
                {
                    //PropertyPriceitem.PropertyId = model.PropertyId;
                    //Propertylocationitem. = "";
                    //Propertylocationitem.AddressLine2 = "";
                    //Propertylocationitem.ZipCode = "";
                    //Propertylocationitem.CountryId = -1;
                    //Propertylocationitem.RegionId = -1;
                    //Propertylocationitem.CityId = -1;
                    model.EntryData = PropertyDetailitem;

                    //create
                }
            }
            #endregion
            #region additionalDetails
            if (model.ActionName == "additionaldetails")
            {
                ViewBag.PropertyId = model.PropertyId;
                var PropertyAdditionalDetailList = new List<PropertyAdditionalDetailDto>();
                try
                {
                    PropertyAdditionalDetailList = _request.Send<List<PropertyAdditionalDetailDto>>(null, Method.GET, "PropertyAdditionalDetail/GetPropertyAdditionalDetails/" + model.PropertyId);
                    model.EntryData = PropertyAdditionalDetailList;
                    // Edit 
                }
                catch
                {
                    //PropertyPriceitem.PropertyId = model.PropertyId;
                    //Propertylocationitem. = "";
                    //Propertylocationitem.AddressLine2 = "";
                    //Propertylocationitem.ZipCode = "";
                    //Propertylocationitem.CountryId = -1;
                    //Propertylocationitem.RegionId = -1;
                    //Propertylocationitem.CityId = -1;
                    model.EntryData = PropertyAdditionalDetailList;

                    //create
                }
            }
            #endregion

            #region media
            if (model.ActionName == "media")
            {
                ViewBag.PropertyId = model.PropertyId;
                var propertyImage = _request.Send<List<PropertyImageDto>>(null, Method.GET, "PropertyImage/" + model.PropertyId);

                var baseUrl = _appSetting.ApiBaseUrl;
                if (baseUrl.EndsWith("/"))
                    baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
                foreach (var item in propertyImage)
                {
                    item.ImagePath = $"{baseUrl}{item.ImagePath}";
                    item.TumbPath = $"{baseUrl}{item.TumbPath}";
                }
                model.EntryData = propertyImage;
            }
            #endregion
            #region floors
            if (model.ActionName == "floors")
            {
                ViewBag.PropertyId = model.PropertyId;
                var propertyFloorPlan = _request.Send<List<PropertyFloorPlanDto>>(null, Method.GET, "PropertyFloorPlan/GetPropertyFloorPlans/" + model.PropertyId);

                var baseUrl = _appSetting.ApiBaseUrl;
                if (baseUrl.EndsWith("/"))
                    baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
                foreach (var item in propertyFloorPlan)
                {
                    item.ImagePath = $"{baseUrl}{item.ImagePath}";
                    item.TumbPath = $"{baseUrl}{item.TumbPath}";
                }
                model.EntryData = propertyFloorPlan;

            }
            #endregion

            #region summary
            if (model.ActionName == "summary")
            {
                ViewBag.PropertyId = model.PropertyId;
                var summary = _request.Send<PropertySummeryDto>(null, Method.GET, $"Property/GetPropertySummery/{model.PropertyId}");
                var baseUrl = _appSetting.ApiBaseUrl;
                if (baseUrl.EndsWith("/"))
                    baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
                foreach (var item in summary.Images)
                {
                    item.ImagePath = $"{baseUrl}{item.ImagePath}";
                    item.TumbPath = $"{baseUrl}{item.TumbPath}";
                }
                model.EntryData = summary;
            }
            #endregion
            return View(model);
        }
    }

}

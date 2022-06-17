using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstateAdmin.Models.ModelDtos.Page;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateAdmin.Models.DAL.Models;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RestSharp;
using RealEstateAgency.Dtos.Other.PaginationListDtos;
using RealEstateAdmin.Models.FirstPage;
using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using RealEstateAdmin.Models.ModelDtos.Infrastructure;
using System.Net.Http;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using Fluentx.Mvc;
using System.Net;

namespace RealEstateAdmin.Controllers
{


    public class PropertyController : BaseController
    {

        public PropertyController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }

        // GET: Property
        public ActionResult Index()
        {
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<PageResultDto<PropertyPaginationListDto>>(body, Method.POST, "Property/page");
            #endregion

            return View(latestList.Items);
        }

        [HttpPost]
        public ActionResult Publish(int propertyId)
        {
            try
            {
                var publishResualt = _api.Send<ActionResult>(null, Method.PUT, $"Property/PublishProperty/{propertyId}");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public ActionResult UnPublish(int propertyId)
        {
            try
            {
                var result = _api.Send<PageResultDto<PropertyPaginationListDto>>(null, Method.PUT, $"Property/UnPublishProperty/{propertyId}");

                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public ActionResult Delete(int propertyId)
        {
            try
            {
                var latestList = _api.Send<ActionResult>(null, Method.DELETE, $"Property/{propertyId}");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Property/Create
        public ActionResult Create()
        {

            #region Type
            var PropertyTypeList = _api.Send<List<PropertyTypeDto>>(null, Method.GET, "PropertyType");
            #endregion

            #region Status
            var PropertyStatusList = _api.Send<List<PropertyStatusDto>>(null, Method.GET, "PropertyStatus");
            #endregion

            #region Label
            var PropertyLabelList = _api.Send<List<PropertyLabelDto>>(null, Method.GET, "PropertyLabel");
            #endregion

            return View(new PropertyCreatePage
            {
                PropertyType = PropertyTypeList,
                PropertyStatus = PropertyStatusList,
                PropertyLabel = PropertyLabelList,
            });
        }

        // POST: Property/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyDto item, string GeneratedTitle)
        {
            try
            {
                item.Title = GeneratedTitle;
                var PropertyResualt = _api.Send<PropertyDto>(item, Method.POST, "Property");
                return Redirect($"/estate/{PropertyResualt.Id}/description");
            }
            catch
            {
                return View();
            }
        }

        [Route("estate/{propertyId}/{actionName}")]
        public ActionResult Estate(int? propertyId, string actionName)
        {
            PropertyCreatePageViewComponentViewModel propertyCreatePageViewComponentViewModel = new PropertyCreatePageViewComponentViewModel();
            propertyCreatePageViewComponentViewModel.ActionName = actionName;
            propertyCreatePageViewComponentViewModel.PropertyId = propertyId.Value;
            ViewBag.ActionName = actionName;
            switch (actionName)
            {
                case "summary":
                    break;

                case "description":

                    #region Type
                    var PropertyTypeList = _api.Send<List<PropertyTypeDto>>(null, Method.GET, "PropertyType");
                    #endregion

                    #region Status
                    var PropertyStatusList = _api.Send<List<PropertyStatusDto>>(null, Method.POST, "PropertyStatus");
                    #endregion

                    #region Label
                    var PropertyLabelList = _api.Send<List<PropertyLabelDto>>(null, Method.POST, "PropertyLabel");
                    #endregion

                    var myObject = new PropertyCreatePage
                    {
                        PropertyType = PropertyTypeList,
                        PropertyStatus = PropertyStatusList,
                        PropertyLabel = PropertyLabelList
                    };
                    propertyCreatePageViewComponentViewModel.Dynamic = myObject;
                    break;

                case "location":
                    #region Region
                    var RegionList = _api.Send<IEnumerable<RegionDto>>(null, Method.GET, "Region/GetAllByLanguage/en");
                    #endregion

                    #region City
                    var CityList = _api.Send<IEnumerable<CityDto>>(null, Method.GET, "City/GetAllByLanguage/en");
                    #endregion

                    #region Country
                    var CountryList = _api.Send<IEnumerable<CountryDto>>(null, Method.GET, "Country");
                    #endregion

                    var myObject1 = new PropertyLocationPage
                    {
                        Region = RegionList,
                        Country = CountryList,
                        City = CityList
                    };
                    propertyCreatePageViewComponentViewModel.Dynamic = myObject1;
                    break;

                case "price":

                    #region Currency
                    var CurrencyList = _api.Send<IEnumerable<CurrencyDto>>(null, Method.GET, "Currency");
                    #endregion

                    #region Unit
                    var UnitList = _api.Send<IEnumerable<PriceScaleUnitDto>>(null, Method.GET, "PriceScale");
                    #endregion

                    var myObject2 = new PropertyPricePage
                    {
                        Currency = CurrencyList,
                        PriceScaleUnit = UnitList
                    };
                    propertyCreatePageViewComponentViewModel.Dynamic = myObject2;
                    break;

                case "features":
                    
                    #region Unit
                    var FeatureList = _api.Send<IEnumerable<PropertyFeatureDto>>(null, Method.GET, "PropertyFeature");
                    #endregion

                    var myObject3 = new PropertyFeaturesPage
                    {
                        PropertyFeature = FeatureList
                    };
                    propertyCreatePageViewComponentViewModel.Dynamic = myObject3;
                    break;

                case "details":
                    break;
                case "additionaldetails":
                    break;
                case "media":
                    break;
                case "floors":
                    break;
                case "floorEdit":
                    break;
                default:
                    break;
            }
            return View(propertyCreatePageViewComponentViewModel);
        }

        [Route("estate/{propertyId}/description")]
        [HttpPost]
        public ActionResult Description(int propertyId, PropertyDto propertyDto)
        {
            try
            {
                propertyDto.Id = propertyId;
                var PropertyLabelList = _api.Send<PageResultDto<PropertyLabelDto>>(propertyDto, Method.PUT, "property");
                return Redirect($"/estate/{propertyId}/location");
            }
            catch
            {
                ///estate/6/location
                return Redirect($"/estate/{propertyId}/location");
            }

        }

        [Route("estate/{propertyId}/location")]
        [HttpPost]
        public ActionResult Location(PropertyLocationDto model)
        {
            model.Id = model.PropertyId;

            var item = new PropertyLocationDto();
            try
            {
                item = _api.Send<PropertyLocationDto>(null, Method.GET, "PropertyLocation/" + model.PropertyId);
            }
            catch (Exception ex)
            {

            }

            if (item is null || item.PropertyId <= 0)
            {
                #region Create
                _api.Send<PropertyLocationDto>(model, Method.POST, "PropertyLocation");
                #endregion
            }
            else
            {
                #region Edit
                _api.Send<HttpStatusCode>(model, Method.PUT, "PropertyLocation");
                #endregion
            }

            return Redirect($"/estate/{model.PropertyId}/price");
        }

        [Route("estate/{propertyId}/price")]
        [HttpPost]
        public ActionResult Price(PropertyPriceDto model)
        {
            if (model.Price <= 0)
            {
                return Redirect($"/estate/{model.PropertyId}/price?err=Please enter correct price");
            }

            model.Id = model.PropertyId;

            var item = new PropertyPriceDto();
            try
            {
                item = _api.Send<PropertyPriceDto>(null, Method.GET, "PropertyPrice/" + model.PropertyId);
            }
            catch (Exception ex)
            {

            }



            if (item is null || item.PropertyId <= 0)
            {
                #region Create
                _api.Send<PropertyPriceDto>(model, Method.POST, "PropertyPrice");
                #endregion
            }
            else
            {
                #region Edit
                _api.Send<HttpStatusCode>(model, Method.PUT, "PropertyPrice");
                #endregion
            }


            #region Commission
            var propertyItem = _api.Send<PropertyDto>(null, Method.GET, $"Property/{model.PropertyId}");
            propertyItem.Commission = model.Commission;
            var propertyUpdate = _api.Send<PropertyDto>(propertyItem, Method.PUT, $"Property");
            #endregion

            return Redirect($"/estate/{model.Id}/features");
        }

        [Route("estate/{propertyId}/features")]
        [HttpPost]
        public ActionResult Features(int propertyId, List<int> propertyFeatureIds)
        {
            //SetPropertyFeaturesDto
            //PropertyFeature/SetPropertyFeatures patch
            try
            {
                SetPropertyFeaturesDto item = new SetPropertyFeaturesDto();
                item.PropertyFeatureIds = propertyFeatureIds;
                //for (int i = 0; i < propertyFeatureIds.Count; i++)
                //{
                //    item.PropertyFeatureIds.Add(Convert.ToInt32(propertyFeatureIds[i].ToString()));
                //}
                item.PropertyId = propertyId;

                #region Set 
                //PropertyLocation
                _api.Send<SetPropertyFeaturesDto>(item, Method.PATCH, "PropertyFeature/SetPropertyFeatures");
                return Redirect($"/estate/{propertyId}/details");
                #endregion
            }
            catch (Exception exp)
            {
                var sdd = exp;
                return Redirect($"/estate/{propertyId}/details");
            }
        }

        [Route("estate/{propertyId}/details")]
        [HttpPost]
        public ActionResult Details(PropertyDetailDto model)
        {
            model.Id = model.PropertyId;

            var item = new PropertyDetailDto();
            try
            {
                item = _api.Send<PropertyDetailDto>(null, Method.GET, "PropertyDetail/" + model.PropertyId);
            }
            catch (Exception ex)
            {

            }

            if (item is null || item.PropertyId <= 0)
            {
                #region Create
                _api.Send<PropertyDetailDto>(model, Method.POST, "PropertyDetail");
                #endregion
            }
            else
            {
                #region Edit
                _api.Send<HttpStatusCode>(model, Method.PUT, "PropertyDetail");
                #endregion
            }


            return Redirect($"/estate/{model.Id}/additionaldetails");
        }

        [Route("estate/{propertyId}/additionaldetails")]
        [HttpPost]
        public ActionResult Additionaldetails(int propertyId, PropertyAdditionalDetail propertyAdditionalDetail)
        {
            //create 
            try
            {
                #region Create
                _api.Send<PropertyAdditionalDetail>(propertyAdditionalDetail, Method.POST, "PropertyAdditionalDetail");
                return Redirect($"/estate/{propertyId}/additionaldetails");
                #endregion
            }
            catch
            {
                return Redirect($"/estate/{propertyId}/additionaldetails");
            }
        }

        [Route("estate/{propertyId}/media")]
        [HttpPost]
        public ActionResult Media(PropertyImageDto propertyImageDto, IFormFile image)
        {
            var param = new Dictionary<string, object>();
            param.Add("propertyId", propertyImageDto.PropertyId);
            param.Add("imageCaption", propertyImageDto.ImageCaption);
            param.Add("priority", propertyImageDto.Priority);
            param.Add("is360View", propertyImageDto.Is360View);

            _api.SendByFile<PropertyImageDto>(param, image, Method.POST, "PropertyImage");

            return Redirect($"/estate/{propertyImageDto.PropertyId}/media");
        }


        [Route("estate/{propertyId}/floors")]
        [HttpPost]
        public ActionResult Floors(PropertyFloorPlanDto propertyFloorPlanDto, IFormFile image, int typeOfRequest)
        {
            // typeOfRequest == 1 => Create 
            // TypeOfRequest == 2 => Update
            if (typeOfRequest == 1)
            {// Create new Floor
                var param = new PropertyFloorPlanDto
                {
                    PropertyId = propertyFloorPlanDto.PropertyId,
                    FloorName = propertyFloorPlanDto.FloorName,
                    FloorPrice = propertyFloorPlanDto.FloorPrice,
                    PricePostfix = propertyFloorPlanDto.PricePostfix,
                    FloorSize = propertyFloorPlanDto.FloorSize,
                    SizePostfix = propertyFloorPlanDto.SizePostfix,
                    Bedrooms = propertyFloorPlanDto.Bedrooms,
                    Bathrooms = propertyFloorPlanDto.Bathrooms,
                    ImageCaption = propertyFloorPlanDto.ImageCaption,
                };
                var floor = _api.Send<PropertyFloorPlanDto>(param, Method.POST, "PropertyFloorPlan");
                if (floor.Id > 0)
                {
                    if (image != null)
                    {
                        var imgParam = new Dictionary<string, object>();
                        imgParam.Add("propertyFloorPlanId", floor.Id);
                        _api.SendByFile<PropertyFloorPlanDto>(imgParam, image, Method.POST, "PropertyFloorPlan/SetPropertyFloorPlanImage");
                    }
                }
                return Redirect($"/estate/{propertyFloorPlanDto.PropertyId}/floors");
            }
            else
            {//Update Floor
                try
                {
                    var item = _api.Send<PropertyFloorPlanDto>(null, Method.GET, $"PropertyFloorPlan/{propertyFloorPlanDto.Id}");
                    item.Id = propertyFloorPlanDto.Id;
                    item.FloorName = propertyFloorPlanDto.FloorName;
                    item.FloorPrice = propertyFloorPlanDto.FloorPrice;
                    item.PricePostfix = propertyFloorPlanDto.PricePostfix;
                    item.FloorSize = propertyFloorPlanDto.FloorSize;
                    item.SizePostfix = propertyFloorPlanDto.SizePostfix;
                    item.Bedrooms = propertyFloorPlanDto.Bedrooms;
                    item.Bathrooms = propertyFloorPlanDto.Bathrooms;
                    item.ImageCaption = propertyFloorPlanDto.ImageCaption;
                    item.Is360View = propertyFloorPlanDto.Is360View;

                    //var param = new Dictionary<string, object>();
                    //param.Add("propertyId", propertyFloorPlanDto.PropertyId);
                    //param.Add("FloorName", propertyFloorPlanDto.FloorName);
                    //param.Add("FloorPrice", propertyFloorPlanDto.FloorPrice);
                    //param.Add("PricePostfix", propertyFloorPlanDto.PricePostfix);
                    //param.Add("FloorSize", propertyFloorPlanDto.FloorSize);
                    //param.Add("SizePostfix", propertyFloorPlanDto.SizePostfix);
                    //param.Add("Bedrooms", propertyFloorPlanDto.Bedrooms);
                    //param.Add("Bathrooms", propertyFloorPlanDto.Bathrooms);
                    //param.Add("ImageCaption", propertyFloorPlanDto.ImageCaption);
                    //param.Add("Is360View", propertyFloorPlanDto.Is360View);
                    //param.Add("Id", propertyFloorPlanDto.Id);
                    //if(image is null)
                    //{
                    //    param.Add("ImagePath", item.ImagePath);
                    //    param.Add("TumbPath", item.TumbPath);
                    //}
                    
                    var floor = _api.Send<PropertyFloorPlanDto>(item, Method.PUT, "PropertyFloorPlan");

                    if (image != null)
                    {
                        var imgParam = new Dictionary<string, object>();
                        imgParam.Add("propertyFloorPlanId", propertyFloorPlanDto.Id);
                        _api.SendByFile<PropertyFloorPlanDto>(imgParam, image, Method.POST, "PropertyFloorPlan/SetPropertyFloorPlanImage");
                    }
                }
                catch
                {
                    return Redirect($"/estate/{propertyFloorPlanDto.PropertyId}/floors");
                }
                return Redirect($"/estate/{propertyFloorPlanDto.PropertyId}/floors");

            }
        }
        


        [HttpPost, HttpGet]
        public ActionResult GetFloor(int id)
        {

            var PropertyFloorPlan = _api.Send<PropertyFloorPlanDto>(null, Method.GET, "PropertyFloorPlan/" + id);

            return Json(PropertyFloorPlan);

        }

        [HttpPost]
        public ActionResult FloorDelete(int id, int propertyId)
        {
            try
            {
                _api.Send<PropertyLocationDto>(null, Method.DELETE, "PropertyFloorPlan/" + id);
                return Redirect($"/estate/{propertyId}/floors");

            }
            catch
            {
                return Redirect($"/estate/{propertyId}/floors");


            }
        }

        //PropertyImage/{id}
        [HttpPost]
        public ActionResult ImageDelete(int id, int propertyId)
        {
            try
            {
                _api.Send<PropertyLocationDto>(null, Method.DELETE, "PropertyImage/" + id);
                return Redirect($"/estate/{propertyId}/media");

            }
            catch
            {
                return Redirect($"/estate/{propertyId}/media");


            }
        }


        //[HttpPost]
        //public ActionResult ChangeCommission(int PropId, byte? txtChangeCommision)
        //{
        //    try
        //    {
        //        var propertyItem = _api.Send<PropertyDto>(null, Method.GET, $"Property/{PropId}");
        //        propertyItem.Commission = txtChangeCommision;
        //        var propertyUpdate = _api.Send<PropertyDto>(propertyItem, Method.PUT, $"Property");

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {

        //        return RedirectToAction(nameof(Index));
        //    }

        //}


        //// POST: Property/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Organization;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class RealEstateManagementController : BaseController
    {

        public RealEstateManagementController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }

        // GET: RealEstateManagement
        public ActionResult Index()
        {
            #region GET All  
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<List<RealEstateDto>>(null, Method.GET, "RealEstate");
            var list = latestList.Where(r => r.Deleted == null || r.Deleted == false).ToList();
            #endregion

            return View(list);
        }

        // GET: RealEstateManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RealEstateManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RealEstateManagement/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RealEstateDto item)
        {
            try
            {
                // TODO: Add insert logic here
                #region Create  
                item.CurrencyId = 1;
                item.MetadataJson = "";
                item.LanguageIdDefault = 1;
                var latestList = _api.Send<string>(item, Method.POST, "RealEstate");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));

            }
        }

        // GET: RealEstateManagement/Edit/5
        public ActionResult Edit(int id)
        {

            #region Edit  
            //item.CurrencyId = 1;
            //item.MetadataJson = "";
            //item.LanguageIdDefault = 1;
            var item = _api.Send<RealEstateDto>(null, Method.GET, $"RealEstate/{id}");
            #endregion
            return View(item);
        }

        // POST: RealEstateManagement/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RealEstateDto item)
        {
            try
            {
                #region Edit  
                item.CurrencyId = 1;
                item.MetadataJson = "";
                item.LanguageIdDefault = 1;
                item.DateFormat = "YYYY-MM-DD";
                var latestList = _api.Send<string>(item, Method.PUT, "RealEstate");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // POST: RealEstateManagement/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int EstateId)
        {

            try
            {
                var item = _api.Send<RealEstateDto>(null, Method.GET, $"RealEstate/{EstateId}");
                if (item == null)
                    return View();

                #region Edit  
                item.Deleted = true;
                item.UserAccountId_DeleteBy = _user.Id;
                var latestList = _api.Send<string>(item, Method.PUT, "RealEstate");
                #endregion

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }

            //try
            //{
            //    #region Delete
            //    var latestList = _api.Send<List<RealEstateDto>>(null, Method.DELETE, $"RealEstate/{EstateId}");
            //    #endregion
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }




        public ActionResult Settings()
        {
            if (_user.Role != UserGroups.RealEstateAdministrator)
            {
                return RedirectToAction("Index", "Home");
            }

            var item = _api.Send<RealEstateDto>(null, Method.GET, "Auth/GetUserRealEstate");
            if (item == null)
            {
                return RedirectToAction("Index", "Home");
            }
            item.Metadata = new VmRealEstateMetadata();
            if (!string.IsNullOrEmpty(item.MetadataJson))
                item.Metadata = JsonConvert.DeserializeObject<VmRealEstateMetadata>(item.MetadataJson);

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Settings(RealEstateDto model, IFormFile logoFile, IFormFile logoMobFile, IFormFile headerBackgroundFile, IFormFile headerPicFile)
        {
            var item = _api.Send<RealEstateDto>(null, Method.GET, "Auth/GetUserRealEstate");
            if (item == null)
            {
                return RedirectToAction("Index", "Home");
            }

            item.Name = model.Name;
            item.Email = model.Email;
            item.WebsiteUrl = model.WebsiteUrl;
            item.Address01 = model.Address01;
            item.Address02 = model.Address02;
            item.Phone01 = model.Phone01;
            item.Phone02 = model.Phone02;
            item.Phone03 = model.Phone03;
            item.Fax = model.Fax;
            item.ZipCode = model.ZipCode;
            item.MetadataJson = JsonConvert.SerializeObject(model.Metadata);
            var result = _api.Send<RealEstateDto>(item, Method.PUT, "RealEstate");

            var files = new Dictionary<string, IFormFile>();
            files.Add(nameof(item.LogoFile), logoFile);
            files.Add(nameof(item.LogoMobFile), logoMobFile);
            files.Add(nameof(item.HeaderBackgroundFile), headerBackgroundFile);
            files.Add(nameof(item.HeaderPicFile), headerPicFile);
            var param = new Dictionary<string, object>();
            param.Add(nameof(item.Id), item.Id);
            result = _api.Send<RealEstateDto>(param, files, Method.POST, "RealEstate/UpdateImages");

            return RedirectToAction(nameof(Settings));
        }


    }
}
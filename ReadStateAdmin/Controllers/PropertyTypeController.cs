using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using RealEstateAdmin.Models.ModelDtos.Page;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class PropertyTypeController : BaseController
    {
        public PropertyTypeController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }


        // GET: PropertyType
        public ActionResult Index()
        {
            //PropertyLabel/page
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<PageResultDto<PropertyTypeDto>>(body, Method.POST, "PropertyType/page");
            #endregion
            return View(latestList.Items);
        }

        // GET: PropertyType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyType/Create
        public ActionResult Create()
        {
            var logFile = System.IO.File.ReadAllLines("fa.txt");
            ViewBag.FaList = new List<string>(logFile);

            return View();
        }

        // POST: PropertyType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string name, string icon)
        {
            try
            {
                // TODO: Add insert logic here
                #region Latest 
                var body = new Dictionary<string, object>();
                //body.Add("id", id);
                body.Add("name", name);
                body.Add("icon", icon);
                var latestList = _api.Send<PageResultDto<PropertyTypeDto>>(body, Method.POST, "PropertyType");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertyType/Edit/5
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                #region Latest 
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var latestList = _api.Send<PropertyTypeDto>(body, Method.GET, "PropertyType/" + id);

                var logFile = System.IO.File.ReadAllLines("fa.txt");
                ViewBag.FaList = new List<string>(logFile);

                ViewBag.LangList = _api.Send<IEnumerable<PropertyTypeTranslateDto>>(null, Method.GET, "PropertyTypeTranslate/PropertyTypeTranslates/" + id);

                ViewBag.langs = _langs._langs;

                return View(latestList);
                #endregion
            }
            else
            {
                return View();
            }
        }

        // POST: PropertyType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string name, string icon)
        {
            try
            {
                ///api/PropertyFeature
                ///
                if (id > 0)
                {
                    #region Latest 
                    var body = new Dictionary<string, object>();
                    body.Add("id", id);
                    body.Add("name", name);
                    body.Add("icon", icon);
                    var latestList = _api.Send<PageResultDto<PropertyTypeDto>>(body, Method.PUT, "PropertyType");
                    #endregion
                    // TODO: Add update logic here
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exp)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: PropertyType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyType/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLang(int ptId, int langId, string lName)
        {
            try
            {
                var body = new PropertyTypeTranslateDto
                {
                    PropertyTypeId = ptId,
                    LanguageId = langId,
                    Name = lName,
                };
                var latestList = _api.Send<PropertyTypeTranslateDto>(body, Method.POST, "PropertyTypeTranslate");

                return RedirectToAction(nameof(Edit), new { id = ptId });
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Edit), new { id = ptId });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteLang(int id)
        {
            try
            {
                // TODO: Add delete logic here
                #region Latest 
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var latestList = _api.Send<PropertyTypeDto>(body, Method.DELETE, "PropertyTypeTranslate/" + id);
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }


    }
}
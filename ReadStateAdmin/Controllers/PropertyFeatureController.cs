using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models.ModelDtos.BasicInformation;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RealEstateAdmin.Models.ModelDtos.Page;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class PropertyFeatureController : BaseController
    {

        public PropertyFeatureController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }


        // GET: PropertyFeature
        public ActionResult Index()
        {

            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 1000);
            var latestList = _api.Send<PageResultDto<PropertyFeatureDto>>(body, Method.POST, "PropertyFeature/page");
            #endregion
            return View(latestList.Items);
        }

        // GET: PropertyFeature/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyFeature/Create
        public ActionResult Create()
        {
            var logFile = System.IO.File.ReadAllLines("fa.txt");
            ViewBag.FaList = new List<string>(logFile);

            return View();
        }

        // POST: PropertyFeature/Create
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
                var latestList = _api.Send<PageResultDto<PropertyFeatureDto>>(body, Method.POST, "PropertyFeature");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertyFeature/Edit/5
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                #region item 
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var item = _api.Send<PropertyFeatureDto>(body, Method.GET, "PropertyFeature/" + id);

                var logFile = System.IO.File.ReadAllLines("fa.txt");
                ViewBag.FaList = new List<string>(logFile);

                ViewBag.LangList = _api.Send<IEnumerable<PropertyFeatureTranslateDto>>(null, Method.GET, "PropertyFeatureTranslate/PropertyFeatureTranslates/" + id);

                ViewBag.langs = _langs._langs;

                return View(item);
                #endregion
            }
            else
            {
                return View();
            }
        }

        // POST: PropertyFeature/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string name, string icon)
        {
            try
            {
                if (id > 0)
                {
                    #region Latest 
                    var body = new Dictionary<string, object>();
                    body.Add("id", id);
                    body.Add("name", name);
                    body.Add("icon", icon);
                    var latestList = _api.Send<PageResultDto<PropertyFeatureDto>>(body, Method.PUT, "PropertyFeature");
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

        // GET: PropertyFeature/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: PropertyFeature/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                #region Latest 
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var latestList = _api.Send<PropertyFeatureDto>(body, Method.DELETE, "PropertyFeature/" + id);
                #endregion

                TempData["MsgSuccess"] = "Delete property feature success";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLang(int pfId, int langId, string lName)
        {
            try
            {
                var body = new PropertyFeatureTranslateDto
                {
                    PropertyFeatureId = pfId,
                    LanguageId = langId,
                    Name = lName,
                };
                var latestList = _api.Send<PropertyFeatureTranslateDto>(body, Method.POST, "PropertyFeatureTranslate");
                
                return RedirectToAction(nameof(Edit), new { id = pfId });
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Edit), new { id = pfId });
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
                var latestList = _api.Send<PropertyFeatureDto>(body, Method.DELETE, "PropertyFeatureTranslate/" + id);
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
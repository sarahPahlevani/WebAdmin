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
    public class PropertyStatusController : BaseController
    {
        public PropertyStatusController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }


        // GET: PropertyStatus
        public ActionResult Index()
        {
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 1000);
            var latestList = _api.Send<PageResultDto<PropertyStatusDto>>(body, Method.POST, "PropertyStatus/page");
            #endregion
            return View(latestList.Items);
        }

        // GET: PropertyStatus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyStatus/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string name, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                #region Latest 
                var body = new Dictionary<string, object>();
                //body.Add("id", id);
                body.Add("name", name);
                var latestList = _api.Send<PageResultDto<PropertyStatusDto>>(body, Method.POST, "PropertyStatus");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: PropertyStatus/Edit/5
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                #region Latest 
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var latestList = _api.Send<PropertyStatusDto>(body, Method.GET, "PropertyStatus/" + id);

                ViewBag.LangList = _api.Send<IEnumerable<PropertyStatusTranslateDto>>(null, Method.GET, "PropertyStatusTranslate/PropertyStatusTranslates/" + id);

                ViewBag.langs = _langs._langs;

                return View(latestList);
                #endregion
            }
            else
            {
                return View();
            }
        }

        // POST: PropertyStatus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string name, IFormCollection collection)
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
                    var latestList = _api.Send<PageResultDto<PropertyStatusDto>>(body, Method.PUT, "PropertyStatus");
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

        // GET: PropertyStatus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyStatus/Delete/5
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
        public ActionResult CreateLang(int psId, int langId, string lName)
        {
            try
            {
                var body = new PropertyStatusTranslateDto
                {
                    PropertyStatusId = psId,
                    LanguageId = langId,
                    Name = lName,
                };
                var latestList = _api.Send<PropertyStatusTranslateDto>(body, Method.POST, "PropertyStatusTranslate");

                return RedirectToAction(nameof(Edit), new { id = psId });
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Edit), new { id = psId });
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
                var latestList = _api.Send<PropertyStatusDto>(body, Method.DELETE, "PropertyStatusTranslate/" + id);
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
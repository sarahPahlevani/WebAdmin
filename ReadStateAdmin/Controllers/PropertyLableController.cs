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
    public class PropertyLableController : BaseController
    {

        public PropertyLableController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }

        // GET: PropertyLable
        public ActionResult Index()
        {

            //PropertyLabel/page
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<PageResultDto<PropertyLabelDto>>(body, Method.POST, "PropertyLabel/page");
            #endregion
            return View(latestList.Items);
        }

        // GET: PropertyLable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyLable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyLable/Create
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
                var latestList = _api.Send<PageResultDto<PropertyLabelDto>>(body, Method.POST, "PropertyLabel");
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertyLable/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var item = _api.Send<PropertyLabelDto>(body, Method.GET, "PropertyLabel/" + id);

                ViewBag.LangList = _api.Send<IEnumerable<PropertyLabelTranslateDto>>(null, Method.GET, "PropertyLabelTranslate/PropertyLabelTranslates/" + id);

                ViewBag.langs = _langs._langs;

                
                return View(item);
            }
            catch (Exception ex)
            {
                
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: PropertyLable/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string name, IFormCollection collection)
        {
            try
            {
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                body.Add("name", name);
                var result = _api.Send<PageResultDto<PropertyLabelDto>>(body, Method.PUT, "PropertyLabel");

                TempData["MsgSuccess"] = "Update property label success";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: PropertyLable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyLable/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var result = _api.Send<PropertyLabelDto>(body, Method.DELETE, "PropertyLabel/" + id);

                TempData["MsgSuccess"] = "Delete property label success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLang(int plId, int langId, string lName)
        {
            try
            {
                var body = new PropertyLabelTranslateDto
                {
                    PropertyLabelId = plId,
                    LanguageId = langId,
                    Name = lName,
                };
                var latestList = _api.Send<PropertyLabelTranslateDto>(body, Method.POST, "PropertyLabelTranslate");

                return RedirectToAction(nameof(Edit), new { id = plId });
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Edit), new { id = plId });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteLang(int id)
        {
            try
            {
                var body = new Dictionary<string, object>();
                body.Add("id", id);
                var result = _api.Send<PropertyLabelDto>(body, Method.DELETE, "PropertyLabelTranslate/" + id);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
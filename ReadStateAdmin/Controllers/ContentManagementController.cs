using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models.ModelDtos.Page;
using RealEstateAdmin.Models.ModelDtos.CMS;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class ContentManagementController : BaseController
    {
      
        public ContentManagementController(IHttpContextAccessor httpContextAccessor, ApiCaller api, IOptions<AppSetting> options) : base(httpContextAccessor, options, api)
        {
           
        }



        public IActionResult Index()
        {
            var list = _api.Send<List<ContentDto>>(null, Method.GET, "Content");
            return View(list);
        }



        public ActionResult Create()
        {

            ViewBag.ParentList = _api.Send<List<ContentDto>>(null, Method.GET, $"Content/GetParents/{_langs.Current.Code}");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContentDto model)
        {
            try
            {
                if (model.IsMenu)
                {
                    model.ParentId = null;
                    model.Body = null;
                }
                model.RealEstateId = _user.RealEstateId;
                var result = _api.Send<ContentDto>(model, Method.POST, "Content");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            var item = _api.Send<ContentDto>(null, Method.GET, $"Content/{id}");
            ViewBag.ParentList = _api.Send<List<ContentDto>>(null, Method.GET, $"Content/GetParents/{_langs.Current.Code}");
            ViewBag.LangList = _api.Send<IEnumerable<ContentTranslateDto>>(null, Method.GET, "ContentTranslate/ContentTranslates/" + id);
            ViewBag.langs = _langs._langs;

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContentDto model)
        {
            try
            {
                if (model.IsMenu)
                {
                    model.ParentId = null;
                    model.Body = null;
                }
                model.RealEstateId = _user.RealEstateId;
                _api.Send<ActionResult>(model, Method.PUT, $"Content");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var result = _api.Send<List<ContentDto>>(null, Method.DELETE, $"Content/{id}");

                TempData["MsgSuccess"] = "Success";
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
        public ActionResult CreateLang(int cId, int langId)
        {
            try
            {
                var item = _api.Send<ContentDto>(null, Method.GET, $"Content/{cId}");
                var body = new ContentTranslateDto
                {
                    ContentId = cId,
                    LanguageId = langId,
                    Title = item.Title,
                };
                var result = _api.Send<ContentTranslateDto>(body, Method.POST, "ContentTranslate");

                return RedirectToAction(nameof(Edit), new { id = cId });
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Edit), new { id = cId });
            }
        }


        public ActionResult EditLang(int id)
        {
            var item = _api.Send<ContentTranslateDto>(null, Method.GET, $"ContentTranslate/{id}");

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditLang(ContentTranslateDto model)
        {
            try
            {
                var item = _api.Send<ContentTranslateDto>(null, Method.GET, $"ContentTranslate/{model.Id}");
                item.Title = model.Title;
                item.Body = model.Body;
                _api.Send<ActionResult>(item, Method.PUT, $"ContentTranslate");

                TempData["MsgSuccess"] = "Success";
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
        public ActionResult DeleteLang(int id)
        {
            try
            {
                var result = _api.Send<ContentTranslateDto>(null, Method.DELETE, "ContentTranslate/" + id);

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }


    }
}
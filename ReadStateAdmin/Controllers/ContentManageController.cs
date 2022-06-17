using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models.ModelDtos.Page;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class ContentManageController : BaseController
    {
      //  private readonly AppSetting _appSetting;

        public ContentManageController(IHttpContextAccessor httpContextAccessor, ApiCaller api, IOptions<AppSetting> options) : base(httpContextAccessor, options, api)
        {
           // _appSetting = options.Value;
        }
        public IActionResult Index()
        {
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var _pagelist = _api.Send<PageResultDto<ContentPage>>(body, Method.POST, "ContentPage/page");
            return View(_pagelist.Items);
        }
   


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
         [ValidateAntiForgeryToken]
        public ActionResult Create(ContentPage item)
        {
            try
            {

                var PropertyResualt = _api.Send<ContentPage>(item, Method.POST, "ContentPage");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       

        [HttpPost]
        public ActionResult Delete(int ContentPageId)
        {
            try
            {
                var latestList = _api.Send<List<ContentPage>>(null, Method.DELETE, $"ContentPage/Delete/{ContentPageId}");
                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }

        }
        [Route("ContentManage/{Id}/{actionName}")]
        public ActionResult Edit(int Id)
        {
            var item = _api.Send<ContentPage>(null, Method.GET, $"ContentPage/GetById/{Id}");
            return View(item);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edits(ContentPage model)
        {
            try
            {
                _api.Send<ActionResult>(model, Method.PUT, $"ContentPage");
                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

    }
}
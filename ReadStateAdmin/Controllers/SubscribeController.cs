using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Organization;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class SubscribeController : BaseController
    {

        public SubscribeController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }


        public ActionResult Index()
        {
            #region GET All  
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<List<SubscribeDto>>(null, Method.GET, "Subscribe");
            var list = latestList.Where(r => !r.Deleted).ToList();
            #endregion

            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var item = _api.Send<SubscribeDto>(null, Method.GET, $"Subscribe/{id}");
                if (item == null)
                    return View();

                #region Edit  
                item.Deleted = true;
                item.DeletedDate = DateTime.UtcNow;
                item.UserAccountId_DeleteBy = _user.Id;
                var result = _api.Send<string>(item, Method.PUT, "Subscribe");
                #endregion

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
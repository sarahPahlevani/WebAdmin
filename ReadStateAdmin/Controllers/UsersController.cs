using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Crm;
using RealEstateAdmin.Models.ModelDtos.Infrastructure;
using RealEstateAdmin.Models.ModelDtos.Other.Auth;
using RealEstateAdmin.Models.ModelDtos.Page;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class UsersController : BaseController
    {
        public UsersController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }



        public ActionResult Index()
        {
            
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<PageResultDto<UserAccountListDto>>(body, Method.POST, "UserAccount/page");
            #endregion

            return View(latestList.Items);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Agents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterUserDto item)
        {
            try
            {
                item.RealEstateId = _user.RealEstateId;
                item.RecaptchaToken = "6Lf4k7oUAAAAAM13diHiv7UUTmaiMQsGcHGcN7LY";
                var result = _api.Send<UserAccountDto>(item, Method.POST, "Auth/Register");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _api.Send<UserAccountDto>(null, Method.GET, $"UserAccount/{id}");
            ViewBag.CountryList = _api.Send<List<CountryDto>>(null, Method.GET, $"Country");
            return View(item);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserAccountDto model)
        {
            try
            {
                _api.Send<ActionResult>(model, Method.PUT, $"UserAccount");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var result = _api.Send<string>(null, Method.DELETE, $"UserAccount/{id}");

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
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(int uid, string newPass, string confirmNewPass)
        {
            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmNewPass))
            {
                TempData["MsgError"] = "Enter all data";
                return RedirectToAction(nameof(Index));
            }
            if (newPass != confirmNewPass)
            {
                TempData["MsgError"] = "Confirm new password is invalid";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                var result = _api.Send<ActionResult>(null, Method.POST, $"Auth/AdminChangePassword?id={uid}&password={newPass}");

                TempData["MsgSuccess"] = "Change password success";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }


    }
}
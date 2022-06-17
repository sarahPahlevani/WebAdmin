using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Crm;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RealEstateAdmin.Models.ModelDtos.Organization;
using RealEstateAdmin.Models.ModelDtos.Page;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RealEstateAdmin.Models.ModelDtos.SharingSystem;
using RealEstateAgency.Dtos.ModelDtos.Crm;
using RealEstateAgency.Dtos.Other.PaginationListDtos;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }



        public IActionResult Index()
        {
            #region Get Property Count
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var propertyList = _api.Send<PageResultDto<PropertyPaginationListDto>>(body, Method.POST, "Property/page");
            ViewBag.PropertyCount = propertyList.Count;
            #endregion

            #region GEt Total Agent 
            body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            //var agentList = _api.Send<PageResultDto<AgentListDto>>(body, Method.POST, "Agent/page");
            ViewBag.AgentCount = 0; //agentList.Count;
            #endregion

            #region Total Sales 
            //total sales 
            ViewBag.TotalSales = 0;
            #endregion

            #region Total Shares
            body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var sharedList = _api.Send<List<SharedPropertyDto>>(null, Method.GET, "SharedProperty");
            ViewBag.SharedCount = sharedList.Count;
            #endregion

            ViewData["Role"] = _user.Role;

            if (_user.Role == UserGroups.Administrator || _user.Role == UserGroups.RealEstateAdministrator)
            {
                #region Agents List
                var latestList = new PageResultDto<AgentListDto>();
                body = new Dictionary<string, object>();
                body.Add("filter", new Dictionary<string, object>() { });
                body.Add("pageNumber", 0);
                body.Add("pageSize", 2000);
                latestList = _api.Send<PageResultDto<AgentListDto>>(body, Method.POST, "Agent/page");
                ViewData["AgentList"] = latestList.Items;
                #endregion
            }

            #region Your request 
            var body1 = new Dictionary<string, object>();
            body1.Add("filter", new Dictionary<string, object>() { });
            body1.Add("pageNumber", 0);
            body1.Add("pageSize", 7);
            var yourrequest = _api.Send<PageResultDto<RequestListDto>>(body1, Method.POST, "request/page");
            ViewData["YourRequest"] = yourrequest.Items;
            #endregion


            //_Layout();
            return View();
        }



        public IActionResult Login()
        {
            if (_user != null)
                return RedirectToAction("Index");

            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            #region Call Login Api

            var body = new Dictionary<string, object>();
            body.Add("usernameOrEmail", userName);
            body.Add("password", password);
            var result = new UserAccountDto();
            try
            {
                result = _api.Send<UserAccountDto>(body, Method.POST, "Auth/Login");
            }
            catch (Exception ex)
            {
                ViewData["Message"] = ex.Message;
                //ViewData["Message"] = "Incorrect Username or Password";
            }



            try
            {
                var cookieOptions = new CookieOptions()
                {
                    Path = "/",
                    HttpOnly = false,
                    IsEssential = true,
                    Expires = DateTime.Now.AddMonths(1),
                };
                Response.Cookies.Append("token", result.Token, cookieOptions);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["Message"] = "Incorrect Username or Password";
            }

            #endregion

            return View();
        }

        public IActionResult ForgetMyPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetMyPassword(string email)
        {
            try
            {
                var body = new Dictionary<string, object>();
                body.Add("usernameOrEmail", email);
                body.Add("password", "****");
                var propertyList = _api.Send<string>(body, Method.POST, $"Auth/RequestResetPassword");
                ViewData["lblMessage"] = "Reset password email is sent. please check your email.";
            }
            catch
            {
                ViewData["lblMessage"] = "Error ! please try again later";
            }
            return View();
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("token");

            return RedirectToAction("login");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult ChangeLang(string shortName)
        {
            _langs.Change(shortName);
            return Redirect(Request.Headers["Referer"].ToString() ?? nameof(Index));
        }


        //[Route("langeng")]
        //public IActionResult LangEng()
        //{
        //    _langCookie.Change("en-US");
        //    return RedirectToAction(nameof(Index));
        //}

        //[Route("langhu")]
        //public IActionResult LangHu()
        //{
        //    _langCookie.Change("hu-HU");
        //    return RedirectToAction(nameof(Index));
        //}

    }
}

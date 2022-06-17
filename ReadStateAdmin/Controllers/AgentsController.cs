using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RealEstateAdmin.Models.ModelDtos.Organization;
using RealEstateAdmin.Models.ModelDtos.Other.Auth;
using RealEstateAdmin.Models.ModelDtos.Page;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;

namespace RealEstateAdmin.Controllers
{

    public class AgentsController : BaseController
    {

        public AgentsController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }



        // GET: Agents
        public ActionResult Index()
        {
            #region Latest 
            var body = new Dictionary<string, object>();
            body.Add("filter", new Dictionary<string, object>() { });
            body.Add("pageNumber", 0);
            body.Add("pageSize", 2000);
            var latestList = _api.Send<PageResultDto<AgentListDto>>(body, Method.POST, "Agent/page");
            #endregion
            return View(latestList.Items);
        }

        // GET: Agents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Agents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterAgentDto model)
        {
            try
            {
                model.RealEstateId = _user.RealEstateId;
                model.RecaptchaToken = "6Lf4k7oUAAAAAM13diHiv7UUTmaiMQsGcHGcN7LY";
                var result = _api.Send<UserAccountDto>(model, Method.POST, "Auth/RegisterAgent");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

        // GET: Agents/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _api.Send<AgentAccountDto>(null, Method.GET, $"Agent/GetAgentByUserId/{id}");

            return View(item);
        }

        // POST: Agents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AgentAccountDto model)
        {
            try
            {
                _api.Send<ActionResult>(model, Method.PUT, $"Agent/UpdateAgent");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }

        // GET: Agents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agents/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var item = _api.Send<string>(null, Method.DELETE, $"Agent/{id}");

                TempData["MsgSuccess"] = "Success";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["MsgError"] = ex.Message;
                return View();
            }
        }
    }
}
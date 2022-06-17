using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.FirstPage;
using RealEstateAdmin.Models.ModelDtos.Crm;
using RealEstateAdmin.Models.ModelDtos.Organization;
using RealEstateAdmin.Models.ModelDtos.Page;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class RequestsController : BaseController
    {

        public RequestsController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {

        }


        // GET: Requests
        public ActionResult All()
        {
            #region Open Request 
            var latestList = new PageResultDto<RequestListDto>();
            if (_user.Role == "Administrator" || _user.Role == "RealEstateAdministrator")
            {
                var body = new Dictionary<string, object>();
                body.Add("filter", new Dictionary<string, object>() { });
                body.Add("pageNumber", 0);
                body.Add("pageSize", 2000);
                latestList = _api.Send<PageResultDto<RequestListDto>>(body, Method.POST, "request/GetOpenRequests");
            }
            #endregion

            #region Agents 
            var AgentList = new PageResultDto<AgentListDto>();
            if (_user.Role == "Administrator" || _user.Role == "RealEstateAdministrator")
            {
                var body2 = new Dictionary<string, object>();
                body2.Add("filter", new Dictionary<string, object>() { });
                body2.Add("pageNumber", 0);
                body2.Add("pageSize", 2000);
                AgentList = _api.Send<PageResultDto<AgentListDto>>(body2, Method.POST, "Agent/page");
            }
            #endregion

            //request/page
            return View(new RequestPage
            {
                AllRequest = latestList.Items,
                //YourRequest = yourrequest.Items,
                Agents = AgentList.Items
            });
        }

        public ActionResult HistoryStatus(int id)
        {
            var history = _api.Send<PageResultDto<RequestStateListDto>>(null, Method.GET, $"RequestState/GetByRequestId?requestId={id}");

            return View(history.Items);
        }


        public ActionResult Index()
        {
            #region Your request 
            var body1 = new Dictionary<string, object>();
            body1.Add("filter", new Dictionary<string, object>() { });
            body1.Add("pageNumber", 0);
            body1.Add("pageSize", 2000);
            var yourrequest = _api.Send<PageResultDto<RequestListDto>>(body1, Method.POST, "request/page");
            #endregion

            //#region Agents 
            //var AgentList = new PageResultDto<AgentListDto>();
            //if (_user.Role == "RealEstateAdministrator")
            //{
            //    var body2 = new Dictionary<string, object>();
            //    body2.Add("filter", new Dictionary<string, object>() { });
            //    body2.Add("pageNumber", 0);
            //    body2.Add("pageSize", 2000);
            //    AgentList = _api.Send<PageResultDto<AgentListDto>>(body2, Method.POST, "Agent/page");
            //}
            //#endregion

            //request/page
            return View(new RequestPage
            {
                //AllRequest = latestList.Items,
                YourRequest = yourrequest.Items,
                //Agents = AgentList.Items
            });
        }

        [HttpPost]
        public ActionResult Assign(int assingRequestId, int agentid, string description)
        {

            try
            {
                #region Your request 
                var param = new ChangeRequestAgentDto
                {
                    RequestId = assingRequestId,
                    NewAgentId = agentid,
                    Description = description,
                };
                //var body = new Dictionary<string, object>();
                //body.Add("newAgentId", agentid);
                //body.Add("requestId", requestid);
                //body.Add("description", description);
                var yourrequest = _api.Send<PageResultDto<RequestListDto>>(param, Method.POST, "request/ChangeRequestAgent");
                #endregion

                TempData["AlertSuccess"] = "Assing Agent Success";
            }
            catch (Exception ex)
            {
                TempData["AlertDanger"] = ex.Message;
            }

            return RedirectToAction(nameof(All));
        }

        public ActionResult changeCommition(int requestid, int txtChangeCommision)
        {
            var requestItem = _api.Send<RequestDto>(null, Method.GET, $"Request/{requestid}");
            requestItem.Commision = txtChangeCommision;
            var requestItemUpdate = _api.Send<RequestDto>(requestItem, Method.PUT, $"Request");

            return RedirectToAction(nameof(All));
        }

        ///[Route("/ChangeStatus/2056")]
        public ActionResult ChangeStatus(int id)
        {
            var item = _api.Send<RequestDto>(null, Method.GET, $"request/{id}");

            var history = _api.Send<PageResultDto<RequestStateListDto>>(null, Method.GET, $"RequestState/GetByRequestId?requestId={id}");

            var model = new VmRequestStatus
            {
                Request = item,
                History = history.Items.ToList(),
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult ChangeStatus(VmRequestChangeStatus model)
        {
            try
            {
                #region request 
                var body = new RequestStateDto
                {
                    RequestId = model.RequestId,
                    WorkflowStepId = model.Step,
                    Description = model.Description,
                    StartStepDate = DateTime.UtcNow,
                    IsDone = model.IsDone,
                    IsSuccess = false,
                    AgentId = _user.AgentId.GetValueOrDefault(0),
                };
                var yourrequest = _api.Send<RequestStateDto>(body, Method.POST, "RequestState");
                #endregion

                TempData["AlertSuccess"] = "Success";
            }
            catch (Exception ex)
            {
                TempData["AlertDanger"] = ex.Message;
            }

            return RedirectToAction(nameof(Index));
        }


        // GET: Requests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Requests/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Requests/Delete/5
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
    }
}
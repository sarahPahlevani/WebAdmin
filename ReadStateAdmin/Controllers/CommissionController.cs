using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Crm;
using RestSharp;

namespace RealEstateAdmin.Controllers
{
    public class CommissionController : BaseController
    {

        public CommissionController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
        }



        // GET: Commission
        public ActionResult Index()
        {
            var list = _api.Send<List<CommissionInfoDto>>(null, Method.GET, "Commission/GetCommissionInfo");

            return View(list);
        }


        public ActionResult Pay(int cid)
        {
            var list = _api.Send<List<CommissionListDto>>(null, Method.GET, $"Commission/GetDetails/{cid}/false");
            ViewBag.cid = cid;

            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pay(CommissionDto model, int cid)
        {
            try
            {
                var item = _api.Send<CommissionDto>(null, Method.GET, $"Commission/{model.Id}");
                item.IsPay = true;
                item.PayCode = model.PayCode;
                item.PayDate = DateTime.UtcNow;
                
                var result = _api.Send<List<CommissionDto>>(item, Method.PUT, $"Commission");

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Pay), new { cid = cid });
            }
        }

        public ActionResult Paid(int cid)
        {
            var list = _api.Send<List<CommissionListDto>>(null, Method.GET, $"Commission/GetDetails/{cid}/true");

            return View(list);
        }







        // GET: Commission/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Commission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Commission/Create
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

        // GET: Commission/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Commission/Edit/5
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

        // GET: Commission/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Commission/Delete/5
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
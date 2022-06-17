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
    public class PageManagmentController : BaseController
    {
         
        public PageManagmentController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
            : base(httpContextAccessor, options, api)
        {
            
        }


        public IActionResult Index()
        {
            var list = _api.Send<List<UserGroupDto>>(null, Method.GET, "UserGroup");

            return View(list);
        }

        public IActionResult Permissions(int id, string name)
        {
            var list = _api.Send<List<UserGroupPermissionDto>>(null, Method.GET, $"UserGroupPermission/GetByGroupId/{id}");
            ViewBag.UserGroupId = id;
            ViewBag.UserGroupName = name;
            ViewBag.MenuList = _api.Send<List<MenuDto>>(null, Method.GET, "Menu");

            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int newUserGroupId, int newMenuId, bool newRead, bool newUpdate, bool newDelete)
        {
            try
            {
                var item = new UserGroupPermissionDto
                {
                    UserGroupId = newUserGroupId,
                    MenuId = newMenuId,
                    ReadPermission = newRead,
                    UpdatePermission = newUpdate,
                    DeletePermission = newDelete,
                };
                var resualt = _api.Send<PageManagmentDto>(item, Method.POST, "UserGroupPermission");

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
        public ActionResult Edit(int editId, bool editRead, bool editUpdate, bool editDelete)
        {
            try
            {
                var item = _api.Send<UserGroupPermissionDto>(null, Method.GET, $"UserGroupPermission/{editId}");
                if (item == null)
                {
                    TempData["MsgSuccess"] = "Not found permission";
                    return RedirectToAction(nameof(Index));
                }

                item.ReadPermission = editRead;
                item.UpdatePermission = editUpdate;
                item.DeletePermission = editDelete;
                _api.Send<ActionResult>(item, Method.PUT, $"UserGroupPermission");

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
        public ActionResult Delete(int UserGroupPermissionId)
        {
            try
            {
                var latestList = _api.Send<List<PageManagment>>(null, Method.DELETE, $"UserGroupPermission/Delete/{UserGroupPermissionId}");

                TempData["MsgSuccess"] = "Success";
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
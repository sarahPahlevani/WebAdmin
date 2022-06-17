using Microsoft.AspNetCore.Http;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin
{
    public class MenuLayout
    {
        public HttpContext _httpContext;
        public ApiCaller _api;
        public CurrentUser _user;
        
        public MenuLayout(IHttpContextAccessor httpContextAccessor, ApiCaller api, CurrentUser user)
        {
            _api = api;
            _httpContext = httpContextAccessor.HttpContext;
            _user = user;
        }
        public List<MenuDto> GetMenus()
        {
            return _api.Send<List<MenuDto>>(null, Method.GET, $"Menu/GetMenuByGroupId/{_user.Get.GroupId}");
        }
       
        
    }
}

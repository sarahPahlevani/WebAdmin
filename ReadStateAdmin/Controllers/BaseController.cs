using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstateAdmin.Models;

namespace RealEstateAdmin.Controllers
{
    [Auth]
    public class BaseController : Controller
    {
        public HttpContext _httpContext;
        public AppSetting _appSetting;
        public ApiCaller _api;
        public CurrentUserModel _user;
        public Langs _langs;

        public BaseController(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options, ApiCaller api)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _appSetting = options.Value;
            _api = api;
            _user = new CurrentUser(httpContextAccessor).Get;
            _langs = new Langs(httpContextAccessor, api);
        }

    }
}

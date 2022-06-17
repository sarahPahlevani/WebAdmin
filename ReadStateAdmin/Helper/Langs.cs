using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateAdmin.Models.ModelDtos.Infrastructure;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealEstateAdmin
{

    public class Langs
    {

        private readonly HttpContext _httpContext;
        private readonly ApiCaller _api;
        public List<LanguageDto> _langs;

        public Langs(IHttpContextAccessor httpContextAccessor, ApiCaller api)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _api = api;

            _langs = _api.Send<List<LanguageDto>>(null, Method.GET, "Language");



            var cookieOptions = new CookieOptions()
            {
                Path = "/",
                HttpOnly = false,
                IsEssential = true,
                Expires = DateTime.Now.AddMonths(1),
            };

            var langCookie = _httpContext.Request.Cookies["lang"];
            if (langCookie == null || string.IsNullOrEmpty(langCookie))
            {
                var defLang = _langs.FirstOrDefault(r => r.IsDefault);

                var ci = new CultureInfo(defLang.ShortName);
                //var ci = new CultureInfo("hu-HU");
                //ci.NumberFormat.NumberDecimalSeparator = ".";
                //ci.NumberFormat.CurrencyDecimalSeparator = ".";
                //ci.NumberFormat.CurrencySymbol = "$";

                CultureInfo.DefaultThreadCurrentCulture = ci;
                CultureInfo.DefaultThreadCurrentUICulture = ci;
                //Thread.CurrentThread.CurrentCulture = ci;
                //Thread.CurrentThread.CurrentUICulture = ci;

                _httpContext.Response.Cookies.Append("lang", defLang.ShortName, cookieOptions);
            }
            else
            {
                var ci = new CultureInfo(langCookie);
                //ci.NumberFormat.NumberDecimalSeparator = ".";
                //ci.NumberFormat.CurrencyDecimalSeparator = ".";
                //ci.NumberFormat.CurrencySymbol = langCookie == "en-US" ? "$" : "€";

                CultureInfo.DefaultThreadCurrentCulture = ci;
                CultureInfo.DefaultThreadCurrentUICulture = ci;
                //Thread.CurrentThread.CurrentCulture = ci;
                //Thread.CurrentThread.CurrentUICulture = ci;

                _httpContext.Response.Cookies.Append("lang", langCookie, cookieOptions);
            }
        }


        public void Change(string lang)
        {
            var cookieOptions = new CookieOptions()
            {
                Path = "/",
                HttpOnly = false,
                IsEssential = true,
                Expires = DateTime.Now.AddMonths(1),
            };

            //var langCookie = _httpContext.Request.Cookies["lang"];
            var ci = new CultureInfo(lang);
            //ci.NumberFormat.NumberDecimalSeparator = ".";
            //ci.NumberFormat.CurrencyDecimalSeparator = ".";
            //ci.NumberFormat.CurrencySymbol = lang == "en-US" ? "$" : "€";
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            _httpContext.Response.Cookies.Append("lang", lang, cookieOptions);
        }


        //public IEnumerable<LanguageDto> Languages()
        //{
        //    var list = _api.Send<IEnumerable<LanguageDto>>(null, Method.GET, "Language");
        //    return list;
        //}

        public LanguageDto Current
        {
            get
            {
                var langCookie = _httpContext.Request.Cookies["lang"];
                return _langs.FirstOrDefault(r => r.ShortName == langCookie);
            }
        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.Estate;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace RealEstateAdmin
{

    public class ApiCaller
    {

        private readonly HttpContext _httpContext;
        private readonly AppSetting _appSetting;

        public ApiCaller(IHttpContextAccessor httpContextAccessor, IOptions<AppSetting> options)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _appSetting = options.Value;
        }

        public T Send<T>(object body, Method method, string originAddress)
        {
            var client = new RestClient($"{_appSetting.ApiBaseUrl}/api/{originAddress}");
            var request = new RestRequest(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");

            var userToken = _httpContext.Request.Cookies["token"] ?? "";
            if (!string.IsNullOrEmpty(userToken))
                request.AddHeader("authorization", $"bearer {userToken}");

            if (body != null)
                request.AddJsonBody(body);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var result = JsonConvert.DeserializeObject<VmApiContent>(response.Content);
                throw new Exception(result.Message);
            }
            else if ((method != Method.PUT && method != Method.DELETE && response.StatusCode != HttpStatusCode.OK) || ((method == Method.PUT || method == Method.DELETE) && response.StatusCode != HttpStatusCode.NoContent))
            {
                if (string.IsNullOrEmpty(response.Content))
                    throw new Exception(response.ErrorMessage);

                var result = JsonConvert.DeserializeObject<VmApiContent>(response.Content);
                throw new Exception(result.Message);
            }

            T oMycustomclassname = default(T);
            if (method != Method.PUT && method != Method.DELETE)
                oMycustomclassname = JsonConvert.DeserializeObject<T>(response.Content);

            return oMycustomclassname;
        }

        public T Send<T>(Dictionary<string, object> param, Dictionary<string, IFormFile> files, Method method, string originAddress)
        {
            var client = new RestClient($"{_appSetting.ApiBaseUrl}/api/{originAddress}");

            var request = new RestRequest(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AlwaysMultipartFormData = true;

            if (files != null && files.Count > 0)
            {
                foreach (var item in files)
                {
                    if (item.Value is null) continue;
                    using (var ms = new MemoryStream())
                    {
                        item.Value.CopyTo(ms);
                        var fileBytes = ms.GetBuffer();
                        request.AddFile(item.Key, fileBytes, item.Value.FileName);
                    }
                }
            }
            foreach (var item in param)
            {
                request.AddParameter(item.Key, item.Value);
            }
            
            var userToken = _httpContext.Request.Cookies["token"] ?? "";
            if (!string.IsNullOrEmpty(userToken))
                request.AddHeader("authorization", $"bearer {userToken}");

            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var result = JsonConvert.DeserializeObject<VmApiContent>(response.Content);
                throw new Exception(result.Message);
            }
            else if ((method != Method.PUT && method != Method.DELETE && response.StatusCode != HttpStatusCode.OK) || ((method == Method.PUT || method == Method.DELETE) && response.StatusCode != HttpStatusCode.NoContent))
            {
                if (string.IsNullOrEmpty(response.Content))
                    throw new Exception(response.ErrorMessage);

                var result = JsonConvert.DeserializeObject<VmApiContent>(response.Content);
                throw new Exception(result.Message);
            }

            T oMycustomclassname = default(T);
            if (method != Method.PUT && method != Method.DELETE)
                oMycustomclassname = JsonConvert.DeserializeObject<T>(response.Content);

            return oMycustomclassname;
        }

        public T SendByFile<T>(Dictionary<string, object> parameter, IFormFile imageFile, Method method, string originAddress)
        {
            var client = new RestClient($"{_appSetting.ApiBaseUrl}/api/{originAddress}");

            var request = new RestRequest(method);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AlwaysMultipartFormData = true;

            if (imageFile != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageFile.CopyTo(ms);
                    var fileBytes = ms.GetBuffer();

                    request.AddFile("file", fileBytes, imageFile.FileName);
                }
            }

            //request.AddFile("PicTest", imageFile, , imageFile.ContentType());


            foreach (var param in parameter)
            {
                request.AddParameter(param.Key, param.Value);
            }

            var userToken = _httpContext.Request.Cookies["token"] ?? "";
            if (!string.IsNullOrEmpty(userToken))
                request.AddHeader("authorization", $"bearer {userToken}");

            //if (body != null)
            //    request.AddJsonBody(body);
            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(response.ErrorMessage ?? response.StatusDescription);

            T oMycustomclassname = JsonConvert.DeserializeObject<T>(response.Content);
            return oMycustomclassname;
        }

        public T SendQueryParameter<T>(string param, string originAddress)
        {
            var client = new RestClient($"{_appSetting.ApiBaseUrl}/api/{originAddress}");

            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");

            var userToken = _httpContext.Request.Cookies["token"] ?? "";
            if (!string.IsNullOrEmpty(userToken))
                request.AddHeader("authorization", $"bearer {userToken}");

            var response = client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(response.ErrorMessage ?? response.StatusDescription);

            T oMycustomclassname = JsonConvert.DeserializeObject<T>(response.Content);
            return oMycustomclassname;
        }
    }



    public static class TempDataExtensions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);

        }

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            object o;
            tempData.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}

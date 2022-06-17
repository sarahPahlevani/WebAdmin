using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RealEstateAdmin.Models;
using RealEstateAdmin.Models.ModelDtos.RBAC;
using RestSharp;

namespace RealEstateAdmin
{

    public class CurrentUser
    {

        private static HttpContext _httpContext;

        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }

        public CurrentUserModel Get
        {
            get
            {
                var userToken = _httpContext.Request.Cookies["token"] ?? "";
                if (string.IsNullOrEmpty(userToken))
                    return null;

                //var tokenStr = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjIyIiwicm9sZSI6IlJlYWxFc3RhdGVBZG1pbmlzdHJhdG9yIiwiRnVsbE5hbWUiOiJIYW1lZCAgUmFoaW1pIiwiZW1haWwiOiJSZWFsRXN0YXRlQWRtaW5pc3RyYXRvckBnbWFpbC5jb20iLCJaaXBDb2RlIjoiIiwiQWRkcmVzcyI6IiIsIlBob25lIjoiIiwiR3JvdXBJZCI6IjIiLCJSZWdpc3RyYXRpb25EYXRlIjoiMDkvMDIvMjAxOSAwODoyODoxOSIsIkFnZW50SWQiOiIxMiIsIklzUmVzcG9uc2libGUiOiJUcnVlIiwiSGFzUHVibGlzaGluZ0F1dGhvcml6YXRpb24iOiJUcnVlIiwiUmVhbEVzdGF0ZUlkIjoiNiIsIm5iZiI6MTU3NDc5MjEwNiwiZXhwIjoxNTc1Mzk2OTA2LCJpYXQiOjE1NzQ3OTIxMDZ9.TP25Jjy1coVWWOsegU9mymbeMCevzkyjkRgeWG9vZlg";
                var key = Encoding.ASCII.GetBytes("secret string for securing app. hahahahahaha");
                var validations = new TokenValidationParameters
                {
                    LifetimeValidator = (before, expires, token, param)
                        => expires > DateTime.Now,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                var handler = new JwtSecurityTokenHandler();
                SecurityToken tokenSecure;
                var claims = handler.ValidateToken(userToken, validations, out tokenSecure);
                var data = (JwtSecurityToken)tokenSecure;

                
                var item = new CurrentUserModel();
                item.Id = int.Parse(data.Claims.FirstOrDefault(r => r.Type == "unique_name").Value);
                item.Role = data.Claims.FirstOrDefault(r => r.Type == "role").Value;
                item.FullName = data.Claims.FirstOrDefault(r => r.Type == "FullName").Value;
                item.Email = data.Claims.FirstOrDefault(r => r.Type == "email").Value;
                item.ZipCode = data.Claims.FirstOrDefault(r => r.Type == "ZipCode").Value;
                item.Address = data.Claims.FirstOrDefault(r => r.Type == "Address").Value;
                item.Phone = data.Claims.FirstOrDefault(r => r.Type == "Phone").Value;
                item.GroupId = int.Parse(data.Claims.FirstOrDefault(r => r.Type == "GroupId").Value);
                //if (!string.IsNullOrEmpty(data.Claims.FirstOrDefault(r => r.Type == "LanguageId").Value))
                //    item.LanguageId = int.Parse(data.Claims.FirstOrDefault(r => r.Type == "LanguageId").Value);
                if (data.Claims.Any(r => r.Type == "RealEstateId"))
                    item.RealEstateId = int.Parse(data.Claims.FirstOrDefault(r => r.Type == "RealEstateId").Value);
                if (data.Claims.Any(r => r.Type == "AgentId"))
                    item.AgentId = int.Parse(data.Claims.FirstOrDefault(r => r.Type == "AgentId").Value);
                item.IsAgent = item.AgentId.HasValue;
                if (data.Claims.Any(r => r.Type == "IsResponsible"))
                    item.IsResponsible = bool.Parse(data.Claims.FirstOrDefault(r => r.Type == "IsResponsible").Value);
                if (data.Claims.Any(r => r.Type == "HasPublishingAuthorization"))
                    item.HasPublishingAuthorization = bool.Parse(data.Claims.FirstOrDefault(r => r.Type == "HasPublishingAuthorization").Value);
                //item.RegistrationDate = DateTime.Parse(data.Claims.FirstOrDefault(r => r.Type == "RegistrationDate").Value);
                item.IsAuthenticated = true;
                item.UserPic = data.Claims.FirstOrDefault(r => r.Type == "UserPic").Value;

                return item;
            }
        }

    }
}

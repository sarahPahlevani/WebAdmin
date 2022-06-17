using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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

namespace RealEstateAdmin.Models
{

    public class CurrentUserModel
    {
        public bool IsAuthenticated { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int GroupId { get; set; }
        public int? LanguageId { get; }
        public int? RealEstateId { get; set; }
        public int? AgentId { get; set; }
        public bool IsAgent { get; set; }
        public bool? IsResponsible { get; set; }
        public bool? HasPublishingAuthorization { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string UserPic { get; set; }

    }
}

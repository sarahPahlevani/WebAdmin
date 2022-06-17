using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RealEstateAdmin.Models.ModelDtos.Crm;
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

    public class VmRequestChangeStatus
    {

        public int RequestId { get; set; }

        public int Step { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

    }
}

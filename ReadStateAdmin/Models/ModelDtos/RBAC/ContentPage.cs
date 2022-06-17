using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class ContentPage
    {
        public int Id { get; set; }
        public string ContentHeader { get; set; }
        public string ContectDetail { get; set; }
        public string ContentFooter { get; set; }
     //   public int? MenuId { get; set; }
        public string Title { get; set; }
        public bool IsMainPage { get; set; }
    }
}

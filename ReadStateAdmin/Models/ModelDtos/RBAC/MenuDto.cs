using RealEstateAdmin.Models.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class MenuDto
    {
        //public MenuDto()
        //{
        //    subs = new List<subMenu>();
        //}
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string IconName { get; set; }
        public string ControllerName { get; set; }
        public string PluginName { get; set; }
        public string Address { get; set; }
        public byte? Priority { get; set; }
        
        public List<Menu> Childs { get; set; }
    }
    //public  class subMenu
    //{
    //    public int Id { get; set; }
    //    public string IconName { get; set; }
    //    public string Name { get; set; }
    //    public string ActionName { get; set; }
    //    public string ControllerName { get; set; }
    //    public string PluginName { get; set; }
    //    public string address { get; set; }
    //    public byte? Priority { get; set; }
    //}
}

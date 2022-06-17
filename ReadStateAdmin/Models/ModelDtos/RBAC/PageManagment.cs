using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class PageManagment
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public int MenuId { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
        public bool HasUpdatePermmite { get; set; }
        public bool HasDeletePermmite { get; set; }
        public bool HasReadPermmite { get; set; }
       
    }
    public class PageManagmentCreate
    {

        public IEnumerable<UserGroupDto> RoleType { get; set; }
        public IEnumerable<MenuTypeDto> MenuType { get; set; }
        //public IEnumerable<UsersGroupDto> UserGroup { get; set; }
    }

    public class PageManagmentDto
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int MenuId { get; set; }
        public bool ReadPermission { get; set; }
        public bool UpdatePermission { get; set; }
        public bool DeletePermission { get; set; }
    }

    public class RoleTypeDto
    {
        public int Id { get; set; }
        public string RoleTypeName { get; set; }
        
    }
    public class MenuTypeDto
    {
        public int Id { get; set; }
        public string MenuTypeName { get; set; }

    }
    //public class UsersGroupDto
    //{
    //    public int Id { get; set; }
    //    public string UserGroupName { get; set; }

    //}
}

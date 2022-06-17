using RealEstateAdmin.Models.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class UserGroupPermissionDto
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int MenuId { get; set; }
        public bool ReadPermission { get; set; }
        public bool UpdatePermission { get; set; }
        public bool DeletePermission { get; set; }

        public UserGroup UserGroup { get; set; }
        public Menu Menu { get; set; }

    }
   
}

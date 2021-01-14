using eShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Models
{
    public class RoleAssignViewModel
    {
        public string UserName { get; set; }

        public RoleAssignRequest RoleAssign { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Models.Role
{
    public class UpdateRoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
    }
}
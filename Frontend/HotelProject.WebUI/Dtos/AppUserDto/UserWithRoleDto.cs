using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class UserWithRoleDto
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ImageUrl { get; set; }
        public List<string>? Roles { get; set; }
    }
}
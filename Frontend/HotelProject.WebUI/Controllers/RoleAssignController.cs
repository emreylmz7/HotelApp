using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelProject.WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public RoleAssignController(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            var usersWithRoles = new List<UserWithRoleDto>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                var userWithRoles = new UserWithRoleDto
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    ImageUrl = user.ImageUrl,
                    Roles = roles.ToList()
                };

                usersWithRoles.Add(userWithRoles);
            }

            return View(usersWithRoles);
        }



        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id)!;
            TempData["userId"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach(var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleID = item.Id;
                model.RoleName = item.Name!;
                model.RoleExist = userRoles.Contains(item.Name!);
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId = (int)TempData["userId"]!;
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId)!;
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
                
            }
            return RedirectToAction("Index");
        }
    }
}